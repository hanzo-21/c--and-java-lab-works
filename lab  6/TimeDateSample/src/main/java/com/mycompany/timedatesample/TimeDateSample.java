/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.timedatesample;

import java.text.SimpleDateFormat;
import java.util.Date;

/**
 *
 * @author Dell
 */
public class TimeDateSample {

    public static void main(String[] args) {
       SimpleDateFormat formatter = new SimpleDateFormat("dd-M-yyyy HH:mm:ss");
       
       Date date = new Date();
       System.out.println(formatter.format(date));
    }
}
