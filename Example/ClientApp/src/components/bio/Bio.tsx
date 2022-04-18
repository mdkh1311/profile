import { useEffect, useState } from "react";
import { Bio, BioController } from "../../api/bioController";

export const Bios = () => {
  const [bios, setBios] = useState<Bio[]>();

  useEffect(() => {
    BioController.getBios().then((bio) => {
      setBios(bio);
    });
  }, []);

  if (!bios) {
    return <div />;
  }

  return (
    <div>
      {bios.map((bio) => (
        <div>{bio.bioText}</div>
      ))}
    </div>
  );
};
