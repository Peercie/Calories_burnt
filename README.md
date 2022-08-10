# Calories_burnt
"for (int i = 1; i < 6; i++)
            {
                minutes += 10;
                if (rbtnCycling.Checked)
                {
                    calories = weight * CYCLING;
                    total = calories * i;
                }
                else if (rbtnRunning.Checked)
                {
                    calories = weight * RUNNING;
                    total = calories * i;
                }
                else if (rbtnRowing.Checked)
                {
                    calories = weight * ROWING;
                    total = calories * i;
                }
                else
                {
                    MessageBox.Show("Choose an exercise");
                }

                lstbxOutput.Items.Add(minutes +"\t"+Math.Round(total,0));
               
            }"
            USing a nested if statement was revolutionary to me
