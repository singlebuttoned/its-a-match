class Meta:
    def __init__(self,name: str, taskId: int, description: str)
        self.name = name
        self.id = taskId
        self.description = description
    def getId(self):
        return self.id
    def getDescription(self):
        return self.description
    def getName(self):
        return self.name
class Test(Meta):
    def __init__(self,meta: Meta,):
        pass

class Solution:
    def __init__(self,task: Task, code: str = None, compInfo:str = None):
        self.compInfo = compInfo
        self.code = code
        self.task = task