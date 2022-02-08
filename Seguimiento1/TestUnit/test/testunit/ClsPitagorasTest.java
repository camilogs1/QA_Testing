/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package testunit;

import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author User
 */
public class ClsPitagorasTest {
    
    public ClsPitagorasTest() {
    }
    
    @BeforeClass
    public static void setUpClass() {
    }
    
    @AfterClass
    public static void tearDownClass() {
    }
    
    @Before
    public void setUp() {
    }
    
    @After
    public void tearDown() {
    }

    /**
     * Test of pitagoras method, of class ClsPitagoras.
     */
    @Test
    public void testPitagoras() {
        System.out.println("pitagoras");
        double a = 6.0;
        double b = 8.0;
        double expResult = 10.0;
        double result = ClsPitagoras.pitagoras(a, b);
        assertEquals(expResult, result,0.0);
        // TODO review the generated test code and remove the default call to fail.
        
    }
    
}
