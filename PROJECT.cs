  using system
namespace Calculator
{
    
    public partial class Functions:form;
    {
        string input=string.Empty;
        string operand1=string.Empty;
        string operand2=string.Empty;
        char operation;
        double num1,num2;
        double result=0.0;

        public form()
    }
    private void button0(object sender,EventArgs e) 
    {
      this.textBox1.Text=""
    input+= "0"
    this.textBox1.Text+=input;


    }
      private void button1(object sender,EventArgs e) 
    {
      this.textBox1.Text="";
    input+= "1"
    this.textBox1.Text+=input;
    }
      private void button2(object sender,EventArgs e) 
    {
      this.textBox1.Text="";
    input+= "2"
    this.textBox1.Text+=input;
    }
      private void button3(object sender,EventArgs e) 
    {
      this.textBox1.Text="";
    input+= "3"
    this.textBox1.Text+=input;
    }
      private void button4(object sender,EventArgs e) 
    {
      this.textBox1.Text="";
    input+= "4"
    this.textBox1.Text+=input;
    }
      private void button5(object sender,EventArgs e) 
    {
      this.textBox1.Text="";
    input+= "5"
    this.textBox1.Text+=input;
    }
      private void button6(object sender,EventArgs e) 
    {
      this.textBox1.Text="";
    input+= "6"
    this.textBox1.Text+=input;
    }
      private void button7(object sender,EventArgs e) 
    {
      this.textBox1.Text="";
    input+= "7"
    this.textBox1.Text+=input;
    }
      private void button8(object sender,EventArgs e) 
    {
      this.textBox1.Text="";
    input+= "8"
    this.textBox1.Text+=input;
    }
      private void button9(object sender,EventArgs e) 
    {
      this.textBox1.Text="";
    input+= "9"
    this.textBox1.Text+=input;
    }
      private void buttondot(object sender,EventArgs e) 
    {
      this.textBox1.Text="";
    input+= "."
    this.textBox1.Text+=input;
    }
      private void buttonadd(object sender,EventArgs e) 
    {
    operand1=input;
    operation='+';
    input=string.Empty;
    }     
       private void buttonminus(object sender,EventArgs e) 
    {
    operand1=input;
    operation='-';
    input=string.Empty;
    }
       private void buttonmultiply(object sender,EventArgs e) 
    {
    operand1=input;
    operation='*';
    input=string.Empty;
    }
       private void buttondivide(object sender,EventArgs e) 
    {
    operand1=input;
    operation='/';
    input=string.Empty;
    }
       private void buttonAC(object sender,EventArgs e) 
    {
      this.textBox1.Text="";
    this input=string.Empty;
    this.operand1=string.Empty
    this.operand2=string.Empty
    }
       private void buttonfrontbrace(object sender,EventArgs e) 
    {
      this.textBox1.Text="";
    operation='(';
    this.textBox1.Text+=input;
    }
     private void buttonbackbrace(object sender,EventArgs e) 
    {
      this.textBox1.Text="";
    operation=')';
    this.textBox1.Text+=input;

    }
       private void buttonmod(object sender,EventArgs e) 
    {
      
    operand1=input;
    operation='%';
    result=num1%
     TextBox1.Text=result.Tostring();
    }
       private void buttonequalsto(object sender,EventArgs e) 
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
    {1
      TextBox1.Text="error"
    }






}   
