import request from "@/utils/request";
import { GetPermissionsInput, UpdatePermissionsInput } from "./data";

export async function getPermissions(params:GetPermissionsInput) {
  return request('api/abp/permissions', {
    method: 'GET',
    params,
  });
}
export async function updatePermissions(data:UpdatePermissionsInput) {
  return request(`api/abp/permissions?providerKey=${data.providerKey}&providerName=${data.providerName}`, {
    method: 'PUT',
    data:{
      permissions:data.permissions
    }
  });
}
