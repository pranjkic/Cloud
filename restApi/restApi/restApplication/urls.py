from django.urls import path
from . import views

urlpatterns = [
    
    path('', views.count),
    path('initialize/', views.initialize),
]