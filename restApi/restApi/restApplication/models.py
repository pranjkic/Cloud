from django.db import models

# Create your models here.
class AccessCounter(models.Model):
    value = models.IntegerField()