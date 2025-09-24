#!/bin/bash
cd /home/kavia/workspace/code-generation/react-frontend-prototype-143872-143881/react_frontend
npm run build
EXIT_CODE=$?
if [ $EXIT_CODE -ne 0 ]; then
   exit 1
fi

