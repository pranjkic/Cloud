from django.urls import path
from . import views

urlpatterns = [
    
    path('app/', views.count),
    path('initialize/', views.initialize),
]