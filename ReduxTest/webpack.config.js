module.exports = {
    entry: './App/index.js',
    output: {
        filename: 'Scripts/redux-app.js'
    },
    resolve: {
        extensions: ['', '.Webpack.js', '.web.js', '.js']
    },
    module: {
        loaders: [
            {
                test: /\.js?$/,
                exclude: /(node_modules|bower_components)/,
                loader: 'babel-loader',
                query: {
                    presets: ['es2015', 'react']
                }
            }
        ]
    }
}