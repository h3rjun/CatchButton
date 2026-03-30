namespace CatchButton
{
    public partial class Form1 : Form
    {
        private int score = 0;
        private int missCount = 0; // 놓친 횟수

        public Form1()
        {
            InitializeComponent();
            this.Text = "버튼 잡기 게임 시작!";
        }

        private void RestartGame()
        {
            score = 0;
            missCount = 0;
            btnTarget.Enabled = true;
            btnTarget.Location = new Point(285, 153); // 초기 위치로 복원
            this.Text = "게임 재시작! | 점수: 0 | 놓침: 0/10";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 제목과 함께
            score = score + 100;
            MessageBox.Show($"버튼 잡기에 성공하셨네요. 축하드립니다.~!\n현재 점수: {score}", "버튼 잡기 성공");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // 놓친 횟수 증가
            missCount++;

            // 10번 놓치면 게임 오버
            if (missCount >= 10)
            {
                btnTarget.Enabled = false;
                var result = MessageBox.Show(
                    $"Game Over!\n최종 점수: {score}\n놓친 횟수: {missCount}\n\n다시 시작하시겠습니까?", 
                    "게임 종료", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Stop);

                this.Text = $"Game Over | 최종 점수: {score}";

                if (result == DialogResult.Yes)
                {
                    RestartGame();
                }

                return; // 더 이상 실행하지 않음
            }

            // 1. 난수 생성기 준비
            Random rd = new Random();

            // 2. 가용 영역 계산 (버튼이 폼 테두리에 걸리지 않게 보호)
            // ClientSize는 타이틀 바와 테두리를 제외한 실제 흰 도화지 영역임
            int maxX = this.ClientSize.Width - btnTarget.Width;
            int maxY = this.ClientSize.Height - btnTarget.Height;

            // 3. 랜덤 좌표 추출 (0 ~ 최대 가용치 사이)
            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);

            // 4. 위치 할당 (새로운 Point 객체 생성)
            btnTarget.Location = new Point(nextX, nextY);

            score = score - 5;

            // 5. 시각적 피드백 (폼 제목 표시줄에 좌표 출력)
            this.Text = $"버튼 위치: ({nextX}, {nextY}) | 점수: {score} | 놓침: {missCount}/10";

            //System.Media.SystemSounds.Exclamation.Play();
            Console.Beep();

            // 버튼 크기를 점점 작게 (최소 크기 제한)
            //if (btnTarget.Width > 50)
            //{
            //    btnTarget.Size = new Size((int)(btnTarget.Width * 0.9), (int)(btnTarget.Height * 0.9));
            //}

        }
    }
}
