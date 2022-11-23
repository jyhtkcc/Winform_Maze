﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using BenScreenRecorder;
namespace MCS_Week_003_final
{
    public partial class Form1 : Form
    {
        private int XTILES = 25;
        private int YTILES = 25;
        private int TILESIZE = 10;
        private PictureBox[,] mazeTiles;
        string outputPath = "";
        bool folderSelected = false;
        ScreenRecorder screenRec = new ScreenRecorder(new Rectangle(), "");
        int hours, minutes, seconds;

        public Form1()
        {
            InitializeComponent();
            CreateNewMaze();    
            this.KeyPreview = true;
        }

        // 미로 바닥 생성 
        public void CreateNewMaze()
        {
            mazeTiles = new PictureBox[XTILES, YTILES];
            for (int i = 0; i < XTILES; i++)
            {
                for (int j = 0; j < YTILES; j++)
                {
                    mazeTiles[i, j] = new PictureBox();
                    int xPosition = (i * TILESIZE) + 25;
                    int yPosition = (j * TILESIZE) + 10;
                    mazeTiles[i, j].SetBounds(xPosition, yPosition, TILESIZE, TILESIZE);

                    this.Controls.Add(mazeTiles[i, j]);
                }
            }
        }
        // 미로 랜덤 생성
        public void LoadMaze() { 
           
            for (int i = 0; i < XTILES; i++)
            {
                for (int j = 0; j < YTILES; j++)
                {
                    if (i % 2 == 0 || j % 2 == 0)
                    {
                        mazeTiles[i, j].BackColor = Color.Black;                  
                    }            
                    else
                    mazeTiles[i, j].BackColor = Color.White;
                    mazeTiles[23, 23].BackColor = Color.Blue;
                }
            }
          
        Random rand = new Random();

            for (int i = 0; i < XTILES; i++)
            {
                for (int j = 0; j < YTILES; j++)
                {
                    // 짝수타일 막기 -> 동서남북 막기 
                    if (i % 2 == 0 || j % 2 == 0)
                    {
                        continue;
                    }
                    // 오른쪽 벽이 가장 자리이고 동시에 아래 쪽 벽도 가장자리일 경우엔
                    // 아무런 처리도 하지 않도록 continue

                    if (i == XTILES - 2 && j == YTILES - 2)
                    {
                        continue;
                    }

                    // 아래쪽 벽이 가장 자리인 경우엔
                    // 아래쪽 벽을 뚫지 않도록 오른쪽 벽을 뚫도록 한 후 continue
                    if (j == YTILES - 2)
                    {
                        mazeTiles[j, i + 1].BackColor = Color.White;
                        continue;
                    }
                    // 오른쪽 벽이 가장 자리인 경우엔
                    // 오른쪽 벽을 뚫지 않도록 아래쪽 벽을 뚫도록 한 후 continue
                    if (i == XTILES - 2)
                    {
                        mazeTiles[j + 1, i].BackColor = Color.White;
                        continue;
                    }
                    //오른쪽 벽을 뚫기로 결정해 왔던 초록 타일 중에서 랜덤하게 하나를 선택하여 그 타일의 아래 벽을 뚫는다.
                    //미로 만들기 전부터 초록색이었던,
                    //즉 벽을 뚫는 기준이 되는 초록 타일들은 벽 하나를 두고 띄엄 띄엄 있으므로 x - randomIndex * 2 열에 위치한 타일의 i +1 아래 벽을 뚫으면 된다.

                    if (rand.Next(0, 2) == 0)
                    {
                        mazeTiles[j, i + 1].BackColor = Color.White;  // 0이면 오른쪽 뚫기
                    }

                    else
                    {
                        mazeTiles[j + 1, i].BackColor = Color.White;  // 1이면 아래 뚫기
                    }
                }
            }
        }
            // 자동길찾기 알고리즘
            private bool solveMaze(int xPos, int yPos, bool[,] alreadySearched)
            {             
            bool correctPath = false;
            bool shouldCheck = true;
            
            if (xPos >= XTILES || xPos < 0 || yPos >= YTILES || yPos < 0)

                shouldCheck = false;

            else
            {     
                if (mazeTiles[xPos, yPos].BackColor == Color.Blue)         
                    correctPath = true;                             
                
                if (mazeTiles[xPos, yPos].BackColor == Color.Black)        
                    shouldCheck = false;
 
                if (alreadySearched[xPos, yPos])
                    shouldCheck = false;
            }

            if (shouldCheck == true)

            {  
                // 이미 탐색한 경로가 아니면 
                alreadySearched[xPos, yPos] = true;

                //타일을 동서남북 이동시킨다. alereadysearched값이 파라미터로 들어가 있기 때문에 위의
                //else 문을 돌아 파란색 벽 + 벽으로 가지 않음 + 이미 갔던길로 돌아가지 않는다의 자동길찾기 알고리즘이 수행된다.

                correctPath = correctPath || solveMaze(xPos + 1, yPos, alreadySearched);
                correctPath = correctPath || solveMaze(xPos, yPos + 1, alreadySearched);
                correctPath = correctPath || solveMaze(xPos - 1, yPos, alreadySearched);
                correctPath = correctPath || solveMaze(xPos, yPos - 1, alreadySearched);
            }
                if (correctPath == true)
                mazeTiles[xPos, yPos].BackColor = Color.Red;
                return correctPath;
        }
        // 자동 길 찾기 버튼
        private void button1_Click(object sender, EventArgs e)

        {
            TimerReset();
            Timer.Stop();
    
            bool[,] alreadySearched = new bool[XTILES, YTILES];

            if (!solveMaze(1, 1, alreadySearched))

            {
                MessageBox.Show("이미 길을 찾았습니다");
            }
        }
        // 새 게임 버튼 스톱워치 리셋
        private void MakeMaze_Click(object sender, EventArgs e)
        {
            LoadMaze();     
            Timer.Start();
            TimerReset();
            ResetLocaiton();
         }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Timer.Stop();   
        }

        private void ResumeButton_Click(object sender, EventArgs e)
        {
            Timer.Start();
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            bool[,] alreadySearched = new bool[XTILES, YTILES];
            LoadMaze();
        }

        public void TimerReset()
        {
            lblTimer2.Text = "00:00:00";
            hours = 0;
            minutes = 0;
            seconds = 0;
        }

        private void SelectPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "폴더를 선택하세요";

            if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                outputPath = folderBrowser.SelectedPath;
                folderSelected = true;
                Rectangle bounds = Screen.FromControl(this).Bounds;
                screenRec = new ScreenRecorder(bounds, outputPath);
            }

            else
            {
                MessageBox.Show("폴더를 선택하세요");
            }
        }
        
        private void RecButton_Click(object sender, EventArgs e)
        {
            if (folderSelected)
           
                tmrRecord.Start();
           
            else        
                MessageBox.Show("폴더를 선택하세요");
        }

        private void RecordStop_BUTTON_Click(object sender, EventArgs e)
        {
            tmrRecord.Stop();
            screenRec.Stop();
            Application.Restart();    
        }

        public void ResetLocaiton()
        {
            PlayerPictureBox.Location = new Point(37, 22);        
        }

        public void EndGame()
        {
            if (PlayerPictureBox.Bounds.IntersectsWith(endPointPictureBox.Bounds)) 

            {
                Timer.Stop();
                PlayerPictureBox.Location = new Point(37, 22);
                MessageBox.Show("탈출 성공!" + "\r\n" + "탈출 소요 시간: " + lblTimer2.Text + "초");           
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool isRoad = mazeTiles[(PlayerPictureBox.Left - 25) / TILESIZE, (PlayerPictureBox.Top - 10) / TILESIZE].BackColor != Color.Black;
            switch (keyData)
            {
                case Keys.Left:
                    if (isRoad)
                        PlayerPictureBox.Left -= 10;
                    else
                        ResetLocaiton();
                        EndGame();                 
                    return true;

                case Keys.Right:
                    if (isRoad)
                        PlayerPictureBox.Left += 10;            
                    else                  
                        ResetLocaiton();
                        EndGame();
                    return true;

                case Keys.Up:
                    if (isRoad)
                        PlayerPictureBox.Top -= 10;
                    else
                        ResetLocaiton();
                        EndGame();
                    return true;

                case Keys.Down:
                    if (isRoad)
                        PlayerPictureBox.Top += 10;  
                   else
                        ResetLocaiton();
                        EndGame();

               return true;
             }
               return base.ProcessCmdKey(ref msg, keyData);            
          }

        private void tmrRecord_Tick(object sender, EventArgs e)
        {
            screenRec.RecordAudio();
            screenRec.RecordVideo();
            lblTimer.Text = screenRec.getElapsed();
        }

        private void tmrRecord2_Tick(object sender, EventArgs e)
        {
            seconds++;
            if(seconds > 60)
            {
                minutes++;
                seconds = 0;
            }       
            if(minutes > 60)
            {
                hours++;
                minutes = 0;
            }
            string hrs, min, sec;
            if (seconds < 10)
                sec = $"0{seconds}";
            else
                sec = seconds.ToString();
            if (minutes < 10)
                min = $"0{minutes}";
            else
                min = minutes.ToString();
            if (hours < 10)
                hrs = $"0{hours}";
            else
                hrs = hours.ToString();
            lblTimer2.Text = $"{hrs}:{min}:{sec}";           
        }
    }
}
