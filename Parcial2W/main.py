from os import system
from selenium import webdriver

driver = webdriver.Firefox(executable_path=r"D:\Universidad Catolica Luis Amigo\Semestre 7\Verificacion & Validacion de Software\QA_Testing\Parcial2W\geckodriver.exe")
driver.get("https://www.facebook.com/")
driver.maximize_window()

email = driver.find_element_by_name("email")
password = driver.find_element_by_name("pass")

email.send_keys('abc@gmail.com')
password.send_keys('12345678')

driver.find_element_by_name('login').click()