for redux app:
	- npm init in root
	- npm install --save react redux react-redux 
	- npm install --save-dev babel-loader babel-core babel-preset-es2015 babel-preset-react
	
	- add "scripts": { "webpack": "webpack -w" } to package.json in root.
	
	- add webpack.config.js with the following
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
		
	- install npm task runner extension in vs (extensions and updates)
	- link bundle (redux-app) in layout.cshtml
	
	