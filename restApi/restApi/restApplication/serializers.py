from rest_framework import serializers
from restApplication.models import *

class AccessCounterSerializer(serializers.ModelSerializer):
    class Meta:
        model = AccessCounter
        fields = ['id','value']