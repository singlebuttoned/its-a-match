import subprocess
import os

Compilers = {
    "cs" : "csc",
    "py" : "python",
    "go" : "go",
    "c" : "clang",
    "cpp" : "clang",
    "jar" : "java -jar",
    "js" : "node",
    "ts" : "npx ts-node"
}

class Task:
    def __init__(self,name):
        self.name = name
        self.id = '1'
        self.result = "hello"
    def getResult(self):
        return self.result
#ДОПИСАТЬ КОД ЗАДАЧИ, ДОЛЖЕН СОДЕРЖАТЬ МЕТАДАННЫЕ(имя итд.) И ОТВЕТ НА ЗАДАЧУ(string)

def requestHandle(lang: str,code: str, task: Task):
    codefile = open(f'codeToTest.{lang}','w')
    codefile.write(code)
    codefile.close()
    result = str(subprocess.run(f'{Compilers[lang]} codeToTest.{lang}',capture_output = True, shell = True).stdout)[2:-3]
    os.remove(f'codeToTest.{lang}')
    return hash(str(result))==hash(str(task.getResult()))