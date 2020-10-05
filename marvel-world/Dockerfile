# build environment
FROM node:13.12.0-alpine as build
WORKDIR /app

# ENV REACT_APP_INMINUTU_API_URL2 PRUEBA2
ENV PATH /app/node_modules/.bin:$PATH
COPY package.json ./
COPY package-lock.json ./
# COPY nginx.conf ./ 
RUN npm install --silent
RUN npm install react-scripts@3.4.1 -g --silent
COPY . ./
RUN npm run build

# Create deployable image
FROM beamaustralia/react-env:latest as buildenv
WORKDIR /var/www
ARG ARG_REACT_APP_MARVEL
# RUN echo "Oh ARG_REACT_APP_MARVEL equal to: $ARG_REACT_APP_MARVEL"
#el orden de la variable de entorno importa en la capa.
ENV REACT_APP_API_URL=$ARG_REACT_APP_MARVEL

# Remove the default Nginx configuration file
# RUN rm -v /etc/nginx/conf.d/*
#ADD nginx.conf /etc/nginx

# RUN rm /etc/nginx/conf.d/default.conf
# COPY nginx.conf /etc/nginx/conf.d

# COPY --from=build app/nginx.conf /etc/nginx/conf.d/
COPY --from=build app/build /var/www

# Append "daemon off;" to the beginning of the configuration
# RUN echo "daemon off;" >> ../../etc/nginx/ngifrontendnx.conf
COPY .env* /var/www/

# # production environment
# FROM nginx:stable-alpine
# COPY --from=buildenv /var/www /usr/share/nginx/html
# EXPOSE 80

# CMD ["nginx", "-g", "daemon off;"]

#fire up nginx
EXPOSE 80
CMD ["nginx","-g","daemon off;"]