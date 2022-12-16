import React from "react";
import "./LoginAttemptList.css";

const LoginAttempt = (props) => props.attempts.map(attempt => <li key={attempt}>"Welcome " {attempt.login}</li>);

const LoginAttemptList = (props) => (
	<div className="Attempt-List-Main">
	 	<p>Recent activity</p>
	  	<input type="input" placeholder="Filter..." />
		<ul className="Attempt-List">
			<LoginAttempt  {...props}> </LoginAttempt>
		</ul>
	</div>
);

export default LoginAttemptList;
