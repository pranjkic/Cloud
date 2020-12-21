FROM python:3.8.5

MAINTAINER Milica

RUN apt-get update && apt-get install -y --no-install-recommends \
        python3-setuptools \
        python3-pip \
        python3-dev \
        python3-venv \
        git \
        && \
    apt-get clean && \
    rm -rf /var/lib/apt/lists/*

# ENV PYTHONUNBUFFERED 1
# ENV LANG C.UTF-8
# ENV DEBIAN_FRONTEND=noninteractive 

RUN mkdir /app
WORKDIR /app

ADD . /app/

COPY ./requirements.txt /app/

RUN pip install --upgrade pip

RUN pip install -r requirements.txt

COPY . /app/

 EXPOSE 8000
# #CMD exec gunicorn djangoapp.wsgi:application --bind 0.0.0.0:8000 --workers 3
 CMD python -c "print('Hello world')" && \
# #     ls -la
     python manage.py makemigrations && \
     python manage.py migrate && \
     python manage.py runserver 0.0.0.0:8000