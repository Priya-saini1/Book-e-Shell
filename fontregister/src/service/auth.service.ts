import { basename } from "path";
import { CreateUserModel, LoginModel } from "../models/AuthModel";
import BaseList from "../models/BaseList";
import UserModel from "../models/UserModel";
import { Role } from "../utils/enum";
import request from "./request";

class AuthService {
   //ENDPOINT = 'api/BookStore';
   ENDPOINT = 'api/user';

    public async login(data: LoginModel): Promise<UserModel> {
        const url = `${this.ENDPOINT}/Login`;
        return request.post(url, data).then((res) => {
            return res.data as UserModel;
        });
    }
//RegisterUser
    public async create(model: CreateUserModel): Promise<CreateUserModel> {
        const url = `${this.ENDPOINT}/register`;
        return request.post<CreateUserModel>(url, model).then((res) => {
            return res.data;
        });
    }
}
export default new AuthService();
