/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.javaswingprogrmama;

import java.awt.FlowLayout;
import javax.swing.JButton;
import javax.swing.JFrame;

/**
 *
 * @author Dell
 */
public class JavaSwingProgrmama extends JFrame {
    
    JButton B1;
    
    JavaSwingProgrmama(){
        
        setTitle("Sanepa-2 Lalitpur");
        
        B1= new JButton("EEC");
        add(B1);
        
        setLayout(new FlowLayout());
        
        setSize(400,400);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setVisible(true);
        
        
    }

    public static void main(String[] args) {
        
        JavaSwingProgrmama eec = new JavaSwingProgrmama();
    }
}
