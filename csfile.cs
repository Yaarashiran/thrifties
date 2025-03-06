/* Set the size of the map */
#map {
    height: 100vh; /* Full viewport height */
    width: 100%;   /* Full width */
}

body {
    margin: 0;
    padding: 0;
    font-family: Arial, sans-serif; /* Optional: Set a font */
}

/* Style for the title */
#title {
    position: absolute;
    top: 10px;
    left: 50%;
    transform: translateX(-50%);
    z-index: 1000;
    background: rgba(255, 255, 224, 0.8); /* Light yellow with 80% opacity */
    padding: 10px 20px;
    border-radius: 5px;
    box-shadow: 0 2px 6px rgba(0, 0, 0, 0.3);
    font-size: 24px;
    font-weight: bold;
    text-align: center;
    color: black; /* Black text for better contrast */
}

/* Style for category filter buttons */
#category-filters {
    position: absolute;
    top: 60px; /* Adjusted to make space for the title */
    left: 10px;
    z-index: 1000;
    background: white;
    padding: 10px;
    border-radius: 5px;
    box-shadow: 0 2px 6px rgba(0, 0, 0, 0.3);
}

#category-filters button {
    margin: 5px;
    padding: 5px 10px;
    cursor: pointer;
}

/* Style for highlighted category button */
#category-filters button.highlighted {
    background-color: yellow; /* Highlight color */
}

/* Style for the favorites list */
#favorites-list {
    position: absolute;
    top: 60px;
    right: 10px;
    z-index: 1000;
    background: white;
    padding: 10px;
    border-radius: 5px;
    box-shadow: 0 2px 6px rgba(0, 0, 0, 0.3);
    max-width: 300px;
    display: none; /* Hidden by default */
}

#favorites-list ul {
    list-style-type: none;
    padding: 0;
    margin: 0;
}

#favorites-list li {
    margin: 5px 0;
    padding: 5px;
    border-bottom: 1px solid #ddd;
}

#favorites-list li:last-child {
    border-bottom: none;
}
