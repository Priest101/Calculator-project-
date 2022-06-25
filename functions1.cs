  using system;
  using system.Collections.Generic;
namespace Calculator
{
    public partial class Functions1:form
    {
        string input=string.Empty;
        string operand1=string.Empty;
        string operand2=string.Empty;
        char operation;
        double num1,num2;
        double result=0.0;

        public Functions1()
        {
    }
    private void button0_click(object sender,EventArgs e)  
    {
      this.textBox1.Text=""
    input+= "0"
    this.textBox1.Text+=input;
    }
      private void button1_click(object sender,EventArgs e)    
    {
      this.textBox1.Text="";
    input+= "1"
    this.textBox1.Text+=input;
    }
      private void button2_click(object sender,EventArgs e)  
    {
      this.textBox1.Text="";
    input+= "2"
    this.textBox1.Text+=input;
    }
      private void button3_click(object sender,EventArgs e)  
    {
      this.textBox1.Text="";
    input+= "3"
    this.textBox1.Text+=input;
    }
      private void button4_click(object sender,EventArgs e)  
    {
      this.textBox1.Text="";
    input+= "4"
    this.textBox1.Text+=input;
    }
      private void button5_click(object sender,EventArgs e)  
    {
      this.textBox1.Text="";
    input+= "5"
    this.textBox1.Text+=input;
    }
      private void button6_click(object sender,EventArgs e)  
    {
      this.textBox1.Text="";
    input+= "6"
    this.textBox1.Text+=input;
    }
      private void button7_click(object sender,EventArgs e)  
    {
      this.textBox1.Text="";
    input+= "7"
    this.textBox1.Text+=input;
    }
      private void button8_click(object sender,EventArgs e)  
    {
      this.textBox1.Text="";
    input+= "8"
    this.textBox1.Text+=input;
    }
      private void button9_click(object sender,EventArgs e)  
    {
      this.textBox1.Text="";
    input+= "9"
    this.textBox1.Text+=input;
    }
      private void buttondot_click(object sender,EventArgs e)  
    {
      this.textBox1.Text="";
    input+= "."
    this.textBox1.Text+=input;
    }
       private void buttonfrontbrace_click(object sender,EventArgs e)  
    {
      this.textBox1.Text="";
   input+= "("
    this.textBox1.Text+=input;
    }
     private void buttonbackbrace_click(object sender,EventArgs e)  
    {
      this.textBox1.Text="";
    input+= ")"
    this.textBox1.Text+=input;

    }
      private void buttonadd_click(object sender,EventArgs e)  
    {
    operand1=input;
    operation='+';
    input=string.Empty;
    }     
       private void buttonminus_click(object sender,EventArgs e)  
    {
    operand1=input;
    operation='-';
    input=string.Empty;
    }
       private void buttonmultiply_click(object sender,EventArgs e)  
    {
    operand1=input;
    operation='*';
    input=string.Empty;
    }
       private void buttondivide_click(object sender,EventArgs e)  
    {
    operand1=input;
    operation='/';
    input=string.Empty;
    }
       private void buttonAC_click(object sender,EventArgs e)  
    {
      this.textBox1.Text="";
    this input=string.Empty;
    this.operand1=string.Empty
    this.operand2=string.Empty
    }
       private void buttonpercent_click(object sender,EventArgs e)  
    {
      
    operand1=input; 
      double.TryParse(operand1,out num1);
    operation='%';
    result=num1%;
     TextBox1.Text=result.Tostring();
    }
        private void buttonbackspace_Click(object sender, EventArgs e)
    {
       if (TextBox1.Text.Length>0)
    {
       TextBox1.Text = TextBox1.Text.Remove(lastCharPosi, 1);
    }
       if (TextBox1.Text=="")
    {
       TextBox1.Text = "0.0";
    }
       MessageBox.Show(TextBox1.Text);
    }
    
      private int lastCharPosi;
      private void textBox1_TextChanged(object sender, EventArgs e)
    {
      lastCharPosi= TextBox1.Text.Length-1;
    }
       private void buttonequalsto_click(object sender,EventArgs e)  
    {
    operand2=input;
    double.TryParse(operand1,out num1);
    double.TryParse(operand2,out num2);
    }
    if(operation=='+')
    {
      result=num1+num2;
      TextBox1.Text=result.Tostring();
    }
     else if(operation=='-')
    {
      result=num1-num2;
      TextBox1.Text=result.Tostring();
    }
     else if(operation=='*')
    {
      result=num1*num2;
      TextBox1.Text=result.Tostring();
    }
     else if(operation=='/')
    {
      result=num1/num2;
      TextBox1.Text=result.Tostring();
    }
    else
    {
      TextBox1.Text="error";
    }

}   
}
