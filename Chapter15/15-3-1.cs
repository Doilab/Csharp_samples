// リスト15-8 ~ 15-9

using System;

namespace Example{
    class Program{
        static void Main(string[] arg){
            try{
                var bc = new BmiCalculator();
                var bmi = bc.GetBmi(1.57, 49.5);
                Console.WriteLine(bmi);
            }catch(ArgumentException ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
    class BmiCalculator{
        public double GetBmi(double height, double weight){
            if(height < 60.0 || 250.0 < height){
                throw new ArgumentException("heightの指定に誤りがあります");    // 例外をスルー
            }
            if(weight < 10.0 || 200.0 < weight){
                throw new ArgumentException("weightの指定に誤りがあります");    // 例外をスルー
            }
            var metersTall = height / 100;
            var bmi = weight / (metersTall * metersTall);
            return bmi;
        }
    }
}