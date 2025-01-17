/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.jframeexamples;

import java.awt.FlowLayout;
import javax.swing.JButton;
import javax.swing.JCheckBox;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JRadioButton;
import javax.swing.JTextArea;
import javax.swing.JTextField;

/**
 *
 * @author Dell
 */
public class JFrameExamples  extends JFrame {
    
    JButton butn;
    JRadioButton jrabtn;
    JCheckBox jchkbx;
    JLabel jlab;
    JTextField jtxtfld;
    JTextArea jta;
    JComboBox jcombx;
    
    String[] options = {"list" , "of" , "options" ,"to","choose"};
    
    JFrameExamples(){
        
         setTitle("ex:JFrame by extending class ");
        
         butn = new JButton("cick this button");
         add(butn);
         
         butn = new JButton("click this button too");
         add(butn);
         
         jrabtn = new JRadioButton("click to select radio button 1");
         add(jrabtn);
         
         jrabtn = new JRadioButton("click to select radio button 2");
         add(jrabtn);
         
         jchkbx = new JCheckBox("click to check this box");
         add(jchkbx);
         
         jlab = new JLabel("""
                           
                           this is lable, a text that cannot be changed.
                           this is a textfield of size 10 i.e box can be filled and is visable to 10 character.""");
         add(jlab);
         
         jtxtfld = new JTextField(10);
         add(jtxtfld);
         
          jta = new JTextArea("""
                              this is text area. where all the text can be edited unlike Lable
                              and all of them are visible unlike textfied""");
          add(jta);
          
          jcombx = new JComboBox(options);
          add(jcombx);
         
          
        
        setLayout(new FlowLayout());
        setSize(700,1000);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setVisible(true);
        
    }

    public static void main(String[] args) {
        
        JFrameExamples jfe = new JFrameExamples();
        
    }
}
