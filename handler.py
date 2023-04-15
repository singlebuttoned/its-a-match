import subprocess
import os
import BackendAPI

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

def requestHandle(solution: Solution):
    lang = solution.lang
    code = solution.code
    codefile = open(f'codeToTest.{lang}','w')
    codefile.write(code)
    codefile.close()
    result = str(subprocess.run(f'{Compilers[lang]} codeToTest.{lang}',capture_output = True, shell = True).stdout)[2:-3]
    os.remove(f'codeToTest.{lang}')
    return hash(str(result))==hash(str(task.getResult()))