import path from 'node:path'
import daisyui from 'daisyui'
import animate from 'tailwindcss-animate'

const projectRoot = "../YoutubeClone/YoutubeClone"

/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [path.join(projectRoot, "**/*.{razor,html}")],
    theme: {
        extend: {},
    },
    plugins: [animate, daisyui],
}