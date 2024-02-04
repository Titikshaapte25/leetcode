# SQL Query to Retrieve Author IDs Who Viewed Their Own Content

## Description:

This SQL query retrieves the unique author IDs of individuals who have viewed their own content within the Views table. It filters for cases where the author_id matches the viewer_id, indicating that the author has interacted with their own material. The results are ordered by id in ascending order.

## Key Features:

Leverages DISTINCT to return only unique author IDs, eliminating duplicates.
Employs a WHERE clause to filter for specific conditions (author_id = viewer_id).
Applies ORDER BY to arrange the results in a specific order (ascending by id).

## Breakdown:

SELECT DISTINCT author_id AS id:

    Retrieves the author_id column.
    Uses DISTINCT to eliminate duplicate IDs.
    Aliases the column as id for clarity.
    FROM Views:

    Specifies the Views table as the source of data.
    WHERE author_id = viewer_id:

Filters results to include only rows where the author and viewer are the same person.
ORDER BY id ASC:

Arranges the retrieved IDs in ascending order based on their values.

## Usage:

This query can be executed within a database management system (DBMS) to obtain the desired results.
Replace Views with the actual name of your table if it differs.