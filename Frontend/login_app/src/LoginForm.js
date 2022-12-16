import React,  { useState } from "react";
import './LoginForm.css';

const LoginForm = (props) => {
    const [data, setData] = useState({})

	const doUpdateData = e => {
        setData({
            ...data,
            [e.target.id]: e.target.value
        })
    }
	const doSubmit = (event) =>{
		event.preventDefault();

		props.onSubmit({
			login: undefined,
			password: undefined,
		});
	}

	return (
		<form className="form">
			<h1>Login</h1>
			<label htmlFor="name">Name</label>
			<input type="text" id="name" onChange={doUpdateData}/>
			<label htmlFor="password">Password</label>
			<input type="password" id="password" onChange={doUpdateData}/>
			<button type="submit" onClick={doSubmit}>Continue</button>
		</form>
	)
}

export default LoginForm;
