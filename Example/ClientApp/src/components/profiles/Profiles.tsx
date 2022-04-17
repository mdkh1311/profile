import {useEffect, useState} from "react";
import {Profile, ProfileController} from "../../api/profileController";

export const Profiles = (() => {
    const [profiles, setProfiles] = useState<Profile[]>();

    useEffect(() => {
        ProfileController.getProfiles()
        .then(profiles => {
            setProfiles(profiles);
        });
    }, [])

    if (!profiles){
        return <div />;
    }

    return (
      <div>
      {
          profiles.map(profile =>
              <div>{profile.name}</div>
          )
      }
      </div>
    );
});
