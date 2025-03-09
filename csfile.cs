/* Style for the calendar container */
#calendar-container {
    position: fixed;
    top: 0;
    right: -400px; /* Initially hidden off-screen */
    width: 400px; /* Width of the calendar */
    height: 100vh; /* Full viewport height */
    background-color: #f9f9f9;
    box-shadow: -2px 0 6px rgba(0, 0, 0, 0.3);
    transition: right 0.3s ease-in-out; /* Smooth slide-in animation */
    z-index: 1001; /* Ensure it's above other elements */
    padding: 20px;
    overflow-y: auto; /* Enable scrolling if content overflows */
}

/* Style for the calendar toggle button */
#calendar-toggle {
    position: fixed;
    top: 20px;
    right: 20px;
    z-index: 1002; /* Ensure it's above the calendar */
    background-color: #fff;
    border: 1px solid #ccc;
    padding: 10px 20px;
    cursor: pointer;
    border-radius: 5px;
    box-shadow: 0 2px 6px rgba(0, 0, 0, 0.3);
    font-size: 16px;
}

/* Style for the calendar */
#calendar {
    width: 100%;
    height: 100%;
}
