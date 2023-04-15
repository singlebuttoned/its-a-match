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

class Task(Meta):
    def __init__(taskType: str, meta: Meta, expectedResult: str):
        self.type = taskType
        self.meta = meta
        self.expectedResult = expectedResult
    def getType(self):
        return self.type
    def getExpectedResult(self):
        return self.expectedResult

class Test(Meta):
    def __init__(self,meta: Meta,*tasks):
        self.meta = meta
        self.tasks = tasks
    def getTaskSet(self):
        return self.tasks
        
class Solution:
    def __init__(self,taskId:int, taskType:str, result:str):
        self.taskId = taskId
        self.taskType = taskType
        self.result = result