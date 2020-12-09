from django.shortcuts import render

from rest_framework.decorators import api_view
from rest_framework.response import Response

from .models import AccessCounter
from .serializers import AccessCounterSerializer

# Create your views here.

@api_view(['GET'])
def health(request):
    # value = AccessCounter.objects.get(id=1)
    # value.value = value.value + 1
    # value.save()
    # return Response(value.value)
    return Response("OK")