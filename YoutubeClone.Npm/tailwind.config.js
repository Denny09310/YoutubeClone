import path from 'node:path'
import daisyui from 'daisyui'

const projectRoot = "../YoutubeClone/YoutubeClone"

/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [path.join(projectRoot, "**/*.{razor,html}")],
    theme: {
        extend: {},
    },
    plugins: [daisyui],
}