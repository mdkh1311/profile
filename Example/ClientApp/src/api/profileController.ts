import axios from 'axios';

export type Profile = {
  name: string;
  age: number;
  interests: string[];
  gender: string
}

export class ProfileController {
  static getProfiles = async () => {
    const result = await axios.get('profile/getProfiles');
    return result.data as Profile[]
  };
}
