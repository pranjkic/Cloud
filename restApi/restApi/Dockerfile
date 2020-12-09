FROM python:3.8

RUN mkdir /app
WORKDIR /app

ADD . /app/

ENV PYTHONUNBUFFERED 1
ENV LANG C.UTF-8
ENV DEBIAN_FRONTEND=noninteractive 

RUN pip install -r requirements.txt

EXPOSE 8888
CMD python -c "print('Hello world')" && \
    # python manage.py makemigrations && \
    # python manage.py migrate && \
    python manage.py runserver 0.0.0.0:8888