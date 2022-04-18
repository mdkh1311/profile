CREATE TABLE bio (
    id INT GENERATED ALWAYS AS IDENTITY,
    bio_text TEXT NOT NULL,
    CONSTRAINT pk_bio PRIMARY KEY (id)
);

INSERT INTO bio(bio_text)
VALUES
('Hey, I''m Scott, I play Chess and Pool');