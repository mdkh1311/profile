CREATE TABLE profile (
    id INT GENERATED ALWAYS AS IDENTITY,
    name TEXT NOT NULL,
    age INT NOT NULL,
    interests TEXT[] NOT NULL,
    gender text NOT NULL,
    CONSTRAINT pk_profile PRIMARY KEY (id)
);

INSERT INTO profile(name, age, interests, gender)
VALUES
    ('John', 28, array['Dinosaurs', 'Penguins'], 'Male'),
    ('Mary', 24, array['Walking'], 'Female'),
    ('Tim', 27, array['Reading'], 'Male');
