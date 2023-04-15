import handler
import src/BackendLib

def getDefaultCode(lang: str):
    codefile = open(f"src/defaults/{lang}-default.{lang}",'r')
    return codefile.read()
def getTestById(id:int):
    pass
def solutionRequest(solution: Solution):
    pass # вызвать requestHandle
    