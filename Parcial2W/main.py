from os import system
from selenium import webdriver

driver = webdriver.Firefox(executable_path=r"D:\Universidad Catolica Luis Amigo\Semestre 7\Verificacion & Validacion de Software\QA_Testing\Parcial2\geckodriver.exe")
driver.get("https://dev.to")