import axios from "axios";

export type Bio = {
  bioText: string;
};

export class BioController {
  static getBios = async () => {
    const result = await axios.get("bio/getBios");
    return result.data as Bio[];
  };
}
