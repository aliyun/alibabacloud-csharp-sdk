// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ram20150501.Models;

namespace AlibabaCloud.SDK.Ram20150501
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ram", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public string GetEndpoint(string productId, string regionId, string endpointRule, string network, string suffix, Dictionary<string, string> endpointMap, string endpoint)
        {
            if (!AlibabaCloud.TeaUtil.Common.Empty(endpoint))
            {
                return endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(endpointMap) && !AlibabaCloud.TeaUtil.Common.Empty(endpointMap.Get(regionId)))
            {
                return endpointMap.Get(regionId);
            }
            return AlibabaCloud.EndpointUtil.Common.GetEndpointRules(productId, regionId, endpointRule, network, suffix);
        }

        /**
         * @summary Adds a RAM user to a RAM user group.
         *
         * @param request AddUserToGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddUserToGroupResponse
         */
        public AddUserToGroupResponse AddUserToGroupWithOptions(AddUserToGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserToGroup",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserToGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds a RAM user to a RAM user group.
         *
         * @param request AddUserToGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddUserToGroupResponse
         */
        public async Task<AddUserToGroupResponse> AddUserToGroupWithOptionsAsync(AddUserToGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddUserToGroup",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUserToGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds a RAM user to a RAM user group.
         *
         * @param request AddUserToGroupRequest
         * @return AddUserToGroupResponse
         */
        public AddUserToGroupResponse AddUserToGroup(AddUserToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUserToGroupWithOptions(request, runtime);
        }

        /**
         * @summary Adds a RAM user to a RAM user group.
         *
         * @param request AddUserToGroupRequest
         * @return AddUserToGroupResponse
         */
        public async Task<AddUserToGroupResponse> AddUserToGroupAsync(AddUserToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUserToGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Attaches a policy to a RAM user group.
         *
         * @param request AttachPolicyToGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachPolicyToGroupResponse
         */
        public AttachPolicyToGroupResponse AttachPolicyToGroupWithOptions(AttachPolicyToGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachPolicyToGroup",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachPolicyToGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Attaches a policy to a RAM user group.
         *
         * @param request AttachPolicyToGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachPolicyToGroupResponse
         */
        public async Task<AttachPolicyToGroupResponse> AttachPolicyToGroupWithOptionsAsync(AttachPolicyToGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachPolicyToGroup",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachPolicyToGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Attaches a policy to a RAM user group.
         *
         * @param request AttachPolicyToGroupRequest
         * @return AttachPolicyToGroupResponse
         */
        public AttachPolicyToGroupResponse AttachPolicyToGroup(AttachPolicyToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachPolicyToGroupWithOptions(request, runtime);
        }

        /**
         * @summary Attaches a policy to a RAM user group.
         *
         * @param request AttachPolicyToGroupRequest
         * @return AttachPolicyToGroupResponse
         */
        public async Task<AttachPolicyToGroupResponse> AttachPolicyToGroupAsync(AttachPolicyToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachPolicyToGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Attaches a policy to a RAM role.
         *
         * @param request AttachPolicyToRoleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachPolicyToRoleResponse
         */
        public AttachPolicyToRoleResponse AttachPolicyToRoleWithOptions(AttachPolicyToRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachPolicyToRole",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachPolicyToRoleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Attaches a policy to a RAM role.
         *
         * @param request AttachPolicyToRoleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachPolicyToRoleResponse
         */
        public async Task<AttachPolicyToRoleResponse> AttachPolicyToRoleWithOptionsAsync(AttachPolicyToRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachPolicyToRole",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachPolicyToRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Attaches a policy to a RAM role.
         *
         * @param request AttachPolicyToRoleRequest
         * @return AttachPolicyToRoleResponse
         */
        public AttachPolicyToRoleResponse AttachPolicyToRole(AttachPolicyToRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachPolicyToRoleWithOptions(request, runtime);
        }

        /**
         * @summary Attaches a policy to a RAM role.
         *
         * @param request AttachPolicyToRoleRequest
         * @return AttachPolicyToRoleResponse
         */
        public async Task<AttachPolicyToRoleResponse> AttachPolicyToRoleAsync(AttachPolicyToRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachPolicyToRoleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Attaches a policy to a RAM user.
         *
         * @param request AttachPolicyToUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachPolicyToUserResponse
         */
        public AttachPolicyToUserResponse AttachPolicyToUserWithOptions(AttachPolicyToUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachPolicyToUser",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachPolicyToUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Attaches a policy to a RAM user.
         *
         * @param request AttachPolicyToUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachPolicyToUserResponse
         */
        public async Task<AttachPolicyToUserResponse> AttachPolicyToUserWithOptionsAsync(AttachPolicyToUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachPolicyToUser",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachPolicyToUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Attaches a policy to a RAM user.
         *
         * @param request AttachPolicyToUserRequest
         * @return AttachPolicyToUserResponse
         */
        public AttachPolicyToUserResponse AttachPolicyToUser(AttachPolicyToUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachPolicyToUserWithOptions(request, runtime);
        }

        /**
         * @summary Attaches a policy to a RAM user.
         *
         * @param request AttachPolicyToUserRequest
         * @return AttachPolicyToUserResponse
         */
        public async Task<AttachPolicyToUserResponse> AttachPolicyToUserAsync(AttachPolicyToUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachPolicyToUserWithOptionsAsync(request, runtime);
        }

        /**
         * @param request BindMFADeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindMFADeviceResponse
         */
        public BindMFADeviceResponse BindMFADeviceWithOptions(BindMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationCode1))
            {
                query["AuthenticationCode1"] = request.AuthenticationCode1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationCode2))
            {
                query["AuthenticationCode2"] = request.AuthenticationCode2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                query["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindMFADevice",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindMFADeviceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request BindMFADeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindMFADeviceResponse
         */
        public async Task<BindMFADeviceResponse> BindMFADeviceWithOptionsAsync(BindMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationCode1))
            {
                query["AuthenticationCode1"] = request.AuthenticationCode1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationCode2))
            {
                query["AuthenticationCode2"] = request.AuthenticationCode2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                query["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindMFADevice",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindMFADeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request BindMFADeviceRequest
         * @return BindMFADeviceResponse
         */
        public BindMFADeviceResponse BindMFADevice(BindMFADeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindMFADeviceWithOptions(request, runtime);
        }

        /**
         * @param request BindMFADeviceRequest
         * @return BindMFADeviceResponse
         */
        public async Task<BindMFADeviceResponse> BindMFADeviceAsync(BindMFADeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindMFADeviceWithOptionsAsync(request, runtime);
        }

        /**
         * @description >  This operation is available only for RAM users. Before you call this operation, make sure that `AllowUserToChangePassword` in [SetSecurityPreference](https://help.aliyun.com/document_detail/43765.html) is set to `True`. The value True indicates that RAM users can change their passwords.
         *
         * @param request ChangePasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangePasswordResponse
         */
        public ChangePasswordResponse ChangePasswordWithOptions(ChangePasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPassword))
            {
                query["NewPassword"] = request.NewPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldPassword))
            {
                query["OldPassword"] = request.OldPassword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangePassword",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangePasswordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description >  This operation is available only for RAM users. Before you call this operation, make sure that `AllowUserToChangePassword` in [SetSecurityPreference](https://help.aliyun.com/document_detail/43765.html) is set to `True`. The value True indicates that RAM users can change their passwords.
         *
         * @param request ChangePasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangePasswordResponse
         */
        public async Task<ChangePasswordResponse> ChangePasswordWithOptionsAsync(ChangePasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPassword))
            {
                query["NewPassword"] = request.NewPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldPassword))
            {
                query["OldPassword"] = request.OldPassword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangePassword",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangePasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description >  This operation is available only for RAM users. Before you call this operation, make sure that `AllowUserToChangePassword` in [SetSecurityPreference](https://help.aliyun.com/document_detail/43765.html) is set to `True`. The value True indicates that RAM users can change their passwords.
         *
         * @param request ChangePasswordRequest
         * @return ChangePasswordResponse
         */
        public ChangePasswordResponse ChangePassword(ChangePasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangePasswordWithOptions(request, runtime);
        }

        /**
         * @description >  This operation is available only for RAM users. Before you call this operation, make sure that `AllowUserToChangePassword` in [SetSecurityPreference](https://help.aliyun.com/document_detail/43765.html) is set to `True`. The value True indicates that RAM users can change their passwords.
         *
         * @param request ChangePasswordRequest
         * @return ChangePasswordResponse
         */
        public async Task<ChangePasswordResponse> ChangePasswordAsync(ChangePasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangePasswordWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ClearAccountAliasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ClearAccountAliasResponse
         */
        public ClearAccountAliasResponse ClearAccountAliasWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClearAccountAlias",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearAccountAliasResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ClearAccountAliasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ClearAccountAliasResponse
         */
        public async Task<ClearAccountAliasResponse> ClearAccountAliasWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ClearAccountAlias",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ClearAccountAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return ClearAccountAliasResponse
         */
        public ClearAccountAliasResponse ClearAccountAlias()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ClearAccountAliasWithOptions(runtime);
        }

        /**
         * @return ClearAccountAliasResponse
         */
        public async Task<ClearAccountAliasResponse> ClearAccountAliasAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ClearAccountAliasWithOptionsAsync(runtime);
        }

        /**
         * @param request CreateAccessKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAccessKeyResponse
         */
        public CreateAccessKeyResponse CreateAccessKeyWithOptions(CreateAccessKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccessKey",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessKeyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateAccessKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAccessKeyResponse
         */
        public async Task<CreateAccessKeyResponse> CreateAccessKeyWithOptionsAsync(CreateAccessKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccessKey",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccessKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateAccessKeyRequest
         * @return CreateAccessKeyResponse
         */
        public CreateAccessKeyResponse CreateAccessKey(CreateAccessKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccessKeyWithOptions(request, runtime);
        }

        /**
         * @param request CreateAccessKeyRequest
         * @return CreateAccessKeyResponse
         */
        public async Task<CreateAccessKeyResponse> CreateAccessKeyAsync(CreateAccessKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccessKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a RAM user group.
         *
         * @param request CreateGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGroupResponse
         */
        public CreateGroupResponse CreateGroupWithOptions(CreateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                query["Comments"] = request.Comments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroup",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a RAM user group.
         *
         * @param request CreateGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGroupResponse
         */
        public async Task<CreateGroupResponse> CreateGroupWithOptionsAsync(CreateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                query["Comments"] = request.Comments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroup",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a RAM user group.
         *
         * @param request CreateGroupRequest
         * @return CreateGroupResponse
         */
        public CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGroupWithOptions(request, runtime);
        }

        /**
         * @summary Creates a RAM user group.
         *
         * @param request CreateGroupRequest
         * @return CreateGroupResponse
         */
        public async Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables console logon for a RAM user.
         *
         * @param request CreateLoginProfileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLoginProfileResponse
         */
        public CreateLoginProfileResponse CreateLoginProfileWithOptions(CreateLoginProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MFABindRequired))
            {
                query["MFABindRequired"] = request.MFABindRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordResetRequired))
            {
                query["PasswordResetRequired"] = request.PasswordResetRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoginProfile",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoginProfileResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables console logon for a RAM user.
         *
         * @param request CreateLoginProfileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLoginProfileResponse
         */
        public async Task<CreateLoginProfileResponse> CreateLoginProfileWithOptionsAsync(CreateLoginProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MFABindRequired))
            {
                query["MFABindRequired"] = request.MFABindRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordResetRequired))
            {
                query["PasswordResetRequired"] = request.PasswordResetRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLoginProfile",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLoginProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables console logon for a RAM user.
         *
         * @param request CreateLoginProfileRequest
         * @return CreateLoginProfileResponse
         */
        public CreateLoginProfileResponse CreateLoginProfile(CreateLoginProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoginProfileWithOptions(request, runtime);
        }

        /**
         * @summary Enables console logon for a RAM user.
         *
         * @param request CreateLoginProfileRequest
         * @return CreateLoginProfileResponse
         */
        public async Task<CreateLoginProfileResponse> CreateLoginProfileAsync(CreateLoginProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoginProfileWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a custom policy.
         *
         * @description For more information about policies, see [Policy overview](https://help.aliyun.com/document_detail/93732.html).
         * This topic provides an example on how to create a custom policy to query Elastic Compute Service (ECS) instances in a specific region.
         *
         * @param request CreatePolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePolicyResponse
         */
        public CreatePolicyResponse CreatePolicyWithOptions(CreatePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyDocument))
            {
                query["PolicyDocument"] = request.PolicyDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicy",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a custom policy.
         *
         * @description For more information about policies, see [Policy overview](https://help.aliyun.com/document_detail/93732.html).
         * This topic provides an example on how to create a custom policy to query Elastic Compute Service (ECS) instances in a specific region.
         *
         * @param request CreatePolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePolicyResponse
         */
        public async Task<CreatePolicyResponse> CreatePolicyWithOptionsAsync(CreatePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyDocument))
            {
                query["PolicyDocument"] = request.PolicyDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicy",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a custom policy.
         *
         * @description For more information about policies, see [Policy overview](https://help.aliyun.com/document_detail/93732.html).
         * This topic provides an example on how to create a custom policy to query Elastic Compute Service (ECS) instances in a specific region.
         *
         * @param request CreatePolicyRequest
         * @return CreatePolicyResponse
         */
        public CreatePolicyResponse CreatePolicy(CreatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePolicyWithOptions(request, runtime);
        }

        /**
         * @summary Creates a custom policy.
         *
         * @description For more information about policies, see [Policy overview](https://help.aliyun.com/document_detail/93732.html).
         * This topic provides an example on how to create a custom policy to query Elastic Compute Service (ECS) instances in a specific region.
         *
         * @param request CreatePolicyRequest
         * @return CreatePolicyResponse
         */
        public async Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreatePolicyVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePolicyVersionResponse
         */
        public CreatePolicyVersionResponse CreatePolicyVersionWithOptions(CreatePolicyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyDocument))
            {
                query["PolicyDocument"] = request.PolicyDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RotateStrategy))
            {
                query["RotateStrategy"] = request.RotateStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetAsDefault))
            {
                query["SetAsDefault"] = request.SetAsDefault;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicyVersion",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicyVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreatePolicyVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePolicyVersionResponse
         */
        public async Task<CreatePolicyVersionResponse> CreatePolicyVersionWithOptionsAsync(CreatePolicyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyDocument))
            {
                query["PolicyDocument"] = request.PolicyDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RotateStrategy))
            {
                query["RotateStrategy"] = request.RotateStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetAsDefault))
            {
                query["SetAsDefault"] = request.SetAsDefault;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicyVersion",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicyVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreatePolicyVersionRequest
         * @return CreatePolicyVersionResponse
         */
        public CreatePolicyVersionResponse CreatePolicyVersion(CreatePolicyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePolicyVersionWithOptions(request, runtime);
        }

        /**
         * @param request CreatePolicyVersionRequest
         * @return CreatePolicyVersionResponse
         */
        public async Task<CreatePolicyVersionResponse> CreatePolicyVersionAsync(CreatePolicyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePolicyVersionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a RAM role.
         *
         * @description ## Description
         * For more information about RAM roles, see [Overview of RAM roles](https://help.aliyun.com/document_detail/93689.html).
         *
         * @param request CreateRoleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRoleResponse
         */
        public CreateRoleResponse CreateRoleWithOptions(CreateRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeRolePolicyDocument))
            {
                query["AssumeRolePolicyDocument"] = request.AssumeRolePolicyDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSessionDuration))
            {
                query["MaxSessionDuration"] = request.MaxSessionDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRole",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRoleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a RAM role.
         *
         * @description ## Description
         * For more information about RAM roles, see [Overview of RAM roles](https://help.aliyun.com/document_detail/93689.html).
         *
         * @param request CreateRoleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRoleResponse
         */
        public async Task<CreateRoleResponse> CreateRoleWithOptionsAsync(CreateRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssumeRolePolicyDocument))
            {
                query["AssumeRolePolicyDocument"] = request.AssumeRolePolicyDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSessionDuration))
            {
                query["MaxSessionDuration"] = request.MaxSessionDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRole",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a RAM role.
         *
         * @description ## Description
         * For more information about RAM roles, see [Overview of RAM roles](https://help.aliyun.com/document_detail/93689.html).
         *
         * @param request CreateRoleRequest
         * @return CreateRoleResponse
         */
        public CreateRoleResponse CreateRole(CreateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRoleWithOptions(request, runtime);
        }

        /**
         * @summary Creates a RAM role.
         *
         * @description ## Description
         * For more information about RAM roles, see [Overview of RAM roles](https://help.aliyun.com/document_detail/93689.html).
         *
         * @param request CreateRoleRequest
         * @return CreateRoleResponse
         */
        public async Task<CreateRoleResponse> CreateRoleAsync(CreateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRoleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a Resource Access Management (RAM) user.
         *
         * @description This topic provides an example on how to create a RAM user named `alice`.
         *
         * @param request CreateUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUserResponse
         */
        public CreateUserResponse CreateUserWithOptions(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                query["Comments"] = request.Comments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobilePhone))
            {
                query["MobilePhone"] = request.MobilePhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a Resource Access Management (RAM) user.
         *
         * @description This topic provides an example on how to create a RAM user named `alice`.
         *
         * @param request CreateUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUserResponse
         */
        public async Task<CreateUserResponse> CreateUserWithOptionsAsync(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                query["Comments"] = request.Comments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobilePhone))
            {
                query["MobilePhone"] = request.MobilePhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a Resource Access Management (RAM) user.
         *
         * @description This topic provides an example on how to create a RAM user named `alice`.
         *
         * @param request CreateUserRequest
         * @return CreateUserResponse
         */
        public CreateUserResponse CreateUser(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserWithOptions(request, runtime);
        }

        /**
         * @summary Creates a Resource Access Management (RAM) user.
         *
         * @description This topic provides an example on how to create a RAM user named `alice`.
         *
         * @param request CreateUserRequest
         * @return CreateUserResponse
         */
        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateVirtualMFADeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVirtualMFADeviceResponse
         */
        public CreateVirtualMFADeviceResponse CreateVirtualMFADeviceWithOptions(CreateVirtualMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualMFADeviceName))
            {
                query["VirtualMFADeviceName"] = request.VirtualMFADeviceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVirtualMFADevice",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVirtualMFADeviceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateVirtualMFADeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVirtualMFADeviceResponse
         */
        public async Task<CreateVirtualMFADeviceResponse> CreateVirtualMFADeviceWithOptionsAsync(CreateVirtualMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualMFADeviceName))
            {
                query["VirtualMFADeviceName"] = request.VirtualMFADeviceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVirtualMFADevice",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVirtualMFADeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateVirtualMFADeviceRequest
         * @return CreateVirtualMFADeviceResponse
         */
        public CreateVirtualMFADeviceResponse CreateVirtualMFADevice(CreateVirtualMFADeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVirtualMFADeviceWithOptions(request, runtime);
        }

        /**
         * @param request CreateVirtualMFADeviceRequest
         * @return CreateVirtualMFADeviceResponse
         */
        public async Task<CreateVirtualMFADeviceResponse> CreateVirtualMFADeviceAsync(CreateVirtualMFADeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVirtualMFADeviceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Decodes the diagnostic information in the response that contains an access denied error. The error is caused by no RAM permissions.
         *
         * @param request DecodeDiagnosticMessageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DecodeDiagnosticMessageResponse
         */
        public DecodeDiagnosticMessageResponse DecodeDiagnosticMessageWithOptions(DecodeDiagnosticMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodedDiagnosticMessage))
            {
                query["EncodedDiagnosticMessage"] = request.EncodedDiagnosticMessage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DecodeDiagnosticMessage",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DecodeDiagnosticMessageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Decodes the diagnostic information in the response that contains an access denied error. The error is caused by no RAM permissions.
         *
         * @param request DecodeDiagnosticMessageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DecodeDiagnosticMessageResponse
         */
        public async Task<DecodeDiagnosticMessageResponse> DecodeDiagnosticMessageWithOptionsAsync(DecodeDiagnosticMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncodedDiagnosticMessage))
            {
                query["EncodedDiagnosticMessage"] = request.EncodedDiagnosticMessage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DecodeDiagnosticMessage",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DecodeDiagnosticMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Decodes the diagnostic information in the response that contains an access denied error. The error is caused by no RAM permissions.
         *
         * @param request DecodeDiagnosticMessageRequest
         * @return DecodeDiagnosticMessageResponse
         */
        public DecodeDiagnosticMessageResponse DecodeDiagnosticMessage(DecodeDiagnosticMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DecodeDiagnosticMessageWithOptions(request, runtime);
        }

        /**
         * @summary Decodes the diagnostic information in the response that contains an access denied error. The error is caused by no RAM permissions.
         *
         * @param request DecodeDiagnosticMessageRequest
         * @return DecodeDiagnosticMessageResponse
         */
        public async Task<DecodeDiagnosticMessageResponse> DecodeDiagnosticMessageAsync(DecodeDiagnosticMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DecodeDiagnosticMessageWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteAccessKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAccessKeyResponse
         */
        public DeleteAccessKeyResponse DeleteAccessKeyWithOptions(DeleteAccessKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccessKey",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessKeyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteAccessKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAccessKeyResponse
         */
        public async Task<DeleteAccessKeyResponse> DeleteAccessKeyWithOptionsAsync(DeleteAccessKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccessKey",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccessKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteAccessKeyRequest
         * @return DeleteAccessKeyResponse
         */
        public DeleteAccessKeyResponse DeleteAccessKey(DeleteAccessKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccessKeyWithOptions(request, runtime);
        }

        /**
         * @param request DeleteAccessKeyRequest
         * @return DeleteAccessKeyResponse
         */
        public async Task<DeleteAccessKeyResponse> DeleteAccessKeyAsync(DeleteAccessKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccessKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @description Before you delete a RAM user group, make sure that no policies are attached to the group and no RAM users are included in the group.
         *
         * @param request DeleteGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGroupResponse
         */
        public DeleteGroupResponse DeleteGroupWithOptions(DeleteGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroup",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description Before you delete a RAM user group, make sure that no policies are attached to the group and no RAM users are included in the group.
         *
         * @param request DeleteGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGroupResponse
         */
        public async Task<DeleteGroupResponse> DeleteGroupWithOptionsAsync(DeleteGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroup",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description Before you delete a RAM user group, make sure that no policies are attached to the group and no RAM users are included in the group.
         *
         * @param request DeleteGroupRequest
         * @return DeleteGroupResponse
         */
        public DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGroupWithOptions(request, runtime);
        }

        /**
         * @description Before you delete a RAM user group, make sure that no policies are attached to the group and no RAM users are included in the group.
         *
         * @param request DeleteGroupRequest
         * @return DeleteGroupResponse
         */
        public async Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteLoginProfileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLoginProfileResponse
         */
        public DeleteLoginProfileResponse DeleteLoginProfileWithOptions(DeleteLoginProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLoginProfile",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLoginProfileResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteLoginProfileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLoginProfileResponse
         */
        public async Task<DeleteLoginProfileResponse> DeleteLoginProfileWithOptionsAsync(DeleteLoginProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLoginProfile",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLoginProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteLoginProfileRequest
         * @return DeleteLoginProfileResponse
         */
        public DeleteLoginProfileResponse DeleteLoginProfile(DeleteLoginProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLoginProfileWithOptions(request, runtime);
        }

        /**
         * @param request DeleteLoginProfileRequest
         * @return DeleteLoginProfileResponse
         */
        public async Task<DeleteLoginProfileResponse> DeleteLoginProfileAsync(DeleteLoginProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLoginProfileWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeletePolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePolicyResponse
         */
        public DeletePolicyResponse DeletePolicyWithOptions(DeletePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicy",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeletePolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePolicyResponse
         */
        public async Task<DeletePolicyResponse> DeletePolicyWithOptionsAsync(DeletePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicy",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeletePolicyRequest
         * @return DeletePolicyResponse
         */
        public DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePolicyWithOptions(request, runtime);
        }

        /**
         * @param request DeletePolicyRequest
         * @return DeletePolicyResponse
         */
        public async Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeletePolicyVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePolicyVersionResponse
         */
        public DeletePolicyVersionResponse DeletePolicyVersionWithOptions(DeletePolicyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicyVersion",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeletePolicyVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePolicyVersionResponse
         */
        public async Task<DeletePolicyVersionResponse> DeletePolicyVersionWithOptionsAsync(DeletePolicyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicyVersion",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeletePolicyVersionRequest
         * @return DeletePolicyVersionResponse
         */
        public DeletePolicyVersionResponse DeletePolicyVersion(DeletePolicyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePolicyVersionWithOptions(request, runtime);
        }

        /**
         * @param request DeletePolicyVersionRequest
         * @return DeletePolicyVersionResponse
         */
        public async Task<DeletePolicyVersionResponse> DeletePolicyVersionAsync(DeletePolicyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePolicyVersionWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteRoleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRoleResponse
         */
        public DeleteRoleResponse DeleteRoleWithOptions(DeleteRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRole",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRoleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteRoleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRoleResponse
         */
        public async Task<DeleteRoleResponse> DeleteRoleWithOptionsAsync(DeleteRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRole",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteRoleRequest
         * @return DeleteRoleResponse
         */
        public DeleteRoleResponse DeleteRole(DeleteRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRoleWithOptions(request, runtime);
        }

        /**
         * @param request DeleteRoleRequest
         * @return DeleteRoleResponse
         */
        public async Task<DeleteRoleResponse> DeleteRoleAsync(DeleteRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRoleWithOptionsAsync(request, runtime);
        }

        /**
         * @description Before you delete a RAM user, make sure that no policies are attached to the RAM user and that the RAM user does not belong to any groups.
         *
         * @param request DeleteUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserResponse
         */
        public DeleteUserResponse DeleteUserWithOptions(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description Before you delete a RAM user, make sure that no policies are attached to the RAM user and that the RAM user does not belong to any groups.
         *
         * @param request DeleteUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserResponse
         */
        public async Task<DeleteUserResponse> DeleteUserWithOptionsAsync(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description Before you delete a RAM user, make sure that no policies are attached to the RAM user and that the RAM user does not belong to any groups.
         *
         * @param request DeleteUserRequest
         * @return DeleteUserResponse
         */
        public DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserWithOptions(request, runtime);
        }

        /**
         * @description Before you delete a RAM user, make sure that no policies are attached to the RAM user and that the RAM user does not belong to any groups.
         *
         * @param request DeleteUserRequest
         * @return DeleteUserResponse
         */
        public async Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteVirtualMFADeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVirtualMFADeviceResponse
         */
        public DeleteVirtualMFADeviceResponse DeleteVirtualMFADeviceWithOptions(DeleteVirtualMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                query["SerialNumber"] = request.SerialNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVirtualMFADevice",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVirtualMFADeviceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteVirtualMFADeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVirtualMFADeviceResponse
         */
        public async Task<DeleteVirtualMFADeviceResponse> DeleteVirtualMFADeviceWithOptionsAsync(DeleteVirtualMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                query["SerialNumber"] = request.SerialNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVirtualMFADevice",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVirtualMFADeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteVirtualMFADeviceRequest
         * @return DeleteVirtualMFADeviceResponse
         */
        public DeleteVirtualMFADeviceResponse DeleteVirtualMFADevice(DeleteVirtualMFADeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVirtualMFADeviceWithOptions(request, runtime);
        }

        /**
         * @param request DeleteVirtualMFADeviceRequest
         * @return DeleteVirtualMFADeviceResponse
         */
        public async Task<DeleteVirtualMFADeviceResponse> DeleteVirtualMFADeviceAsync(DeleteVirtualMFADeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVirtualMFADeviceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Detaches a policy from a RAM user group.
         *
         * @param request DetachPolicyFromGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachPolicyFromGroupResponse
         */
        public DetachPolicyFromGroupResponse DetachPolicyFromGroupWithOptions(DetachPolicyFromGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachPolicyFromGroup",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachPolicyFromGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Detaches a policy from a RAM user group.
         *
         * @param request DetachPolicyFromGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachPolicyFromGroupResponse
         */
        public async Task<DetachPolicyFromGroupResponse> DetachPolicyFromGroupWithOptionsAsync(DetachPolicyFromGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachPolicyFromGroup",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachPolicyFromGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Detaches a policy from a RAM user group.
         *
         * @param request DetachPolicyFromGroupRequest
         * @return DetachPolicyFromGroupResponse
         */
        public DetachPolicyFromGroupResponse DetachPolicyFromGroup(DetachPolicyFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachPolicyFromGroupWithOptions(request, runtime);
        }

        /**
         * @summary Detaches a policy from a RAM user group.
         *
         * @param request DetachPolicyFromGroupRequest
         * @return DetachPolicyFromGroupResponse
         */
        public async Task<DetachPolicyFromGroupResponse> DetachPolicyFromGroupAsync(DetachPolicyFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachPolicyFromGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Detaches a policy from a RAM role.
         *
         * @param request DetachPolicyFromRoleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachPolicyFromRoleResponse
         */
        public DetachPolicyFromRoleResponse DetachPolicyFromRoleWithOptions(DetachPolicyFromRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachPolicyFromRole",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachPolicyFromRoleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Detaches a policy from a RAM role.
         *
         * @param request DetachPolicyFromRoleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachPolicyFromRoleResponse
         */
        public async Task<DetachPolicyFromRoleResponse> DetachPolicyFromRoleWithOptionsAsync(DetachPolicyFromRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachPolicyFromRole",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachPolicyFromRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Detaches a policy from a RAM role.
         *
         * @param request DetachPolicyFromRoleRequest
         * @return DetachPolicyFromRoleResponse
         */
        public DetachPolicyFromRoleResponse DetachPolicyFromRole(DetachPolicyFromRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachPolicyFromRoleWithOptions(request, runtime);
        }

        /**
         * @summary Detaches a policy from a RAM role.
         *
         * @param request DetachPolicyFromRoleRequest
         * @return DetachPolicyFromRoleResponse
         */
        public async Task<DetachPolicyFromRoleResponse> DetachPolicyFromRoleAsync(DetachPolicyFromRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachPolicyFromRoleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Detaches a policy from a RAM user.
         *
         * @param request DetachPolicyFromUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachPolicyFromUserResponse
         */
        public DetachPolicyFromUserResponse DetachPolicyFromUserWithOptions(DetachPolicyFromUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachPolicyFromUser",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachPolicyFromUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Detaches a policy from a RAM user.
         *
         * @param request DetachPolicyFromUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachPolicyFromUserResponse
         */
        public async Task<DetachPolicyFromUserResponse> DetachPolicyFromUserWithOptionsAsync(DetachPolicyFromUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachPolicyFromUser",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachPolicyFromUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Detaches a policy from a RAM user.
         *
         * @param request DetachPolicyFromUserRequest
         * @return DetachPolicyFromUserResponse
         */
        public DetachPolicyFromUserResponse DetachPolicyFromUser(DetachPolicyFromUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachPolicyFromUserWithOptions(request, runtime);
        }

        /**
         * @summary Detaches a policy from a RAM user.
         *
         * @param request DetachPolicyFromUserRequest
         * @return DetachPolicyFromUserResponse
         */
        public async Task<DetachPolicyFromUserResponse> DetachPolicyFromUserAsync(DetachPolicyFromUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachPolicyFromUserWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetAccessKeyLastUsedRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAccessKeyLastUsedResponse
         */
        public GetAccessKeyLastUsedResponse GetAccessKeyLastUsedWithOptions(GetAccessKeyLastUsedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessKeyLastUsed",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessKeyLastUsedResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetAccessKeyLastUsedRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAccessKeyLastUsedResponse
         */
        public async Task<GetAccessKeyLastUsedResponse> GetAccessKeyLastUsedWithOptionsAsync(GetAccessKeyLastUsedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessKeyLastUsed",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessKeyLastUsedResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetAccessKeyLastUsedRequest
         * @return GetAccessKeyLastUsedResponse
         */
        public GetAccessKeyLastUsedResponse GetAccessKeyLastUsed(GetAccessKeyLastUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessKeyLastUsedWithOptions(request, runtime);
        }

        /**
         * @param request GetAccessKeyLastUsedRequest
         * @return GetAccessKeyLastUsedResponse
         */
        public async Task<GetAccessKeyLastUsedResponse> GetAccessKeyLastUsedAsync(GetAccessKeyLastUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessKeyLastUsedWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetAccountAliasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAccountAliasResponse
         */
        public GetAccountAliasResponse GetAccountAliasWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountAlias",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountAliasResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetAccountAliasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAccountAliasResponse
         */
        public async Task<GetAccountAliasResponse> GetAccountAliasWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountAlias",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return GetAccountAliasResponse
         */
        public GetAccountAliasResponse GetAccountAlias()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccountAliasWithOptions(runtime);
        }

        /**
         * @return GetAccountAliasResponse
         */
        public async Task<GetAccountAliasResponse> GetAccountAliasAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccountAliasWithOptionsAsync(runtime);
        }

        /**
         * @summary Queries the information of a RAM user group.
         *
         * @param request GetGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGroupResponse
         */
        public GetGroupResponse GetGroupWithOptions(GetGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGroup",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information of a RAM user group.
         *
         * @param request GetGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGroupResponse
         */
        public async Task<GetGroupResponse> GetGroupWithOptionsAsync(GetGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGroup",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information of a RAM user group.
         *
         * @param request GetGroupRequest
         * @return GetGroupResponse
         */
        public GetGroupResponse GetGroup(GetGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGroupWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information of a RAM user group.
         *
         * @param request GetGroupRequest
         * @return GetGroupResponse
         */
        public async Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetLoginProfileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLoginProfileResponse
         */
        public GetLoginProfileResponse GetLoginProfileWithOptions(GetLoginProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLoginProfile",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLoginProfileResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetLoginProfileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLoginProfileResponse
         */
        public async Task<GetLoginProfileResponse> GetLoginProfileWithOptionsAsync(GetLoginProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLoginProfile",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLoginProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetLoginProfileRequest
         * @return GetLoginProfileResponse
         */
        public GetLoginProfileResponse GetLoginProfile(GetLoginProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLoginProfileWithOptions(request, runtime);
        }

        /**
         * @param request GetLoginProfileRequest
         * @return GetLoginProfileResponse
         */
        public async Task<GetLoginProfileResponse> GetLoginProfileAsync(GetLoginProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLoginProfileWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetPasswordPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPasswordPolicyResponse
         */
        public GetPasswordPolicyResponse GetPasswordPolicyWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPasswordPolicy",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPasswordPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetPasswordPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPasswordPolicyResponse
         */
        public async Task<GetPasswordPolicyResponse> GetPasswordPolicyWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPasswordPolicy",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPasswordPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return GetPasswordPolicyResponse
         */
        public GetPasswordPolicyResponse GetPasswordPolicy()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPasswordPolicyWithOptions(runtime);
        }

        /**
         * @return GetPasswordPolicyResponse
         */
        public async Task<GetPasswordPolicyResponse> GetPasswordPolicyAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPasswordPolicyWithOptionsAsync(runtime);
        }

        /**
         * @summary Queries the information of a policy.
         *
         * @param request GetPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPolicyResponse
         */
        public GetPolicyResponse GetPolicyWithOptions(GetPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPolicy",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information of a policy.
         *
         * @param request GetPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPolicyResponse
         */
        public async Task<GetPolicyResponse> GetPolicyWithOptionsAsync(GetPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPolicy",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information of a policy.
         *
         * @param request GetPolicyRequest
         * @return GetPolicyResponse
         */
        public GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information of a policy.
         *
         * @param request GetPolicyRequest
         * @return GetPolicyResponse
         */
        public async Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information of a policy version.
         *
         * @param request GetPolicyVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPolicyVersionResponse
         */
        public GetPolicyVersionResponse GetPolicyVersionWithOptions(GetPolicyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPolicyVersion",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPolicyVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information of a policy version.
         *
         * @param request GetPolicyVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPolicyVersionResponse
         */
        public async Task<GetPolicyVersionResponse> GetPolicyVersionWithOptionsAsync(GetPolicyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPolicyVersion",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPolicyVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information of a policy version.
         *
         * @param request GetPolicyVersionRequest
         * @return GetPolicyVersionResponse
         */
        public GetPolicyVersionResponse GetPolicyVersion(GetPolicyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPolicyVersionWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information of a policy version.
         *
         * @param request GetPolicyVersionRequest
         * @return GetPolicyVersionResponse
         */
        public async Task<GetPolicyVersionResponse> GetPolicyVersionAsync(GetPolicyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPolicyVersionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries information of a RAM role.
         *
         * @param request GetRoleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRoleResponse
         */
        public GetRoleResponse GetRoleWithOptions(GetRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRole",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRoleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries information of a RAM role.
         *
         * @param request GetRoleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRoleResponse
         */
        public async Task<GetRoleResponse> GetRoleWithOptionsAsync(GetRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRole",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries information of a RAM role.
         *
         * @param request GetRoleRequest
         * @return GetRoleResponse
         */
        public GetRoleResponse GetRole(GetRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRoleWithOptions(request, runtime);
        }

        /**
         * @summary Queries information of a RAM role.
         *
         * @param request GetRoleRequest
         * @return GetRoleResponse
         */
        public async Task<GetRoleResponse> GetRoleAsync(GetRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRoleWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetSecurityPreferenceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSecurityPreferenceResponse
         */
        public GetSecurityPreferenceResponse GetSecurityPreferenceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecurityPreference",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecurityPreferenceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetSecurityPreferenceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSecurityPreferenceResponse
         */
        public async Task<GetSecurityPreferenceResponse> GetSecurityPreferenceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecurityPreference",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecurityPreferenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return GetSecurityPreferenceResponse
         */
        public GetSecurityPreferenceResponse GetSecurityPreference()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSecurityPreferenceWithOptions(runtime);
        }

        /**
         * @return GetSecurityPreferenceResponse
         */
        public async Task<GetSecurityPreferenceResponse> GetSecurityPreferenceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSecurityPreferenceWithOptionsAsync(runtime);
        }

        /**
         * @summary Queries the information about a RAM user.
         *
         * @description This topic provides an example on how to query the information about the RAM user `alice`.
         *
         * @param request GetUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserResponse
         */
        public GetUserResponse GetUserWithOptions(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a RAM user.
         *
         * @description This topic provides an example on how to query the information about the RAM user `alice`.
         *
         * @param request GetUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserResponse
         */
        public async Task<GetUserResponse> GetUserWithOptionsAsync(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a RAM user.
         *
         * @description This topic provides an example on how to query the information about the RAM user `alice`.
         *
         * @param request GetUserRequest
         * @return GetUserResponse
         */
        public GetUserResponse GetUser(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about a RAM user.
         *
         * @description This topic provides an example on how to query the information about the RAM user `alice`.
         *
         * @param request GetUserRequest
         * @return GetUserResponse
         */
        public async Task<GetUserResponse> GetUserAsync(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetUserMFAInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserMFAInfoResponse
         */
        public GetUserMFAInfoResponse GetUserMFAInfoWithOptions(GetUserMFAInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserMFAInfo",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserMFAInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetUserMFAInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserMFAInfoResponse
         */
        public async Task<GetUserMFAInfoResponse> GetUserMFAInfoWithOptionsAsync(GetUserMFAInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserMFAInfo",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserMFAInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetUserMFAInfoRequest
         * @return GetUserMFAInfoResponse
         */
        public GetUserMFAInfoResponse GetUserMFAInfo(GetUserMFAInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserMFAInfoWithOptions(request, runtime);
        }

        /**
         * @param request GetUserMFAInfoRequest
         * @return GetUserMFAInfoResponse
         */
        public async Task<GetUserMFAInfoResponse> GetUserMFAInfoAsync(GetUserMFAInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserMFAInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the list of all AccessKey pairs that belong to a RAM user.
         *
         * @param request ListAccessKeysRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAccessKeysResponse
         */
        public ListAccessKeysResponse ListAccessKeysWithOptions(ListAccessKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccessKeys",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccessKeysResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the list of all AccessKey pairs that belong to a RAM user.
         *
         * @param request ListAccessKeysRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAccessKeysResponse
         */
        public async Task<ListAccessKeysResponse> ListAccessKeysWithOptionsAsync(ListAccessKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccessKeys",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccessKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the list of all AccessKey pairs that belong to a RAM user.
         *
         * @param request ListAccessKeysRequest
         * @return ListAccessKeysResponse
         */
        public ListAccessKeysResponse ListAccessKeys(ListAccessKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccessKeysWithOptions(request, runtime);
        }

        /**
         * @summary Queries the list of all AccessKey pairs that belong to a RAM user.
         *
         * @param request ListAccessKeysRequest
         * @return ListAccessKeysResponse
         */
        public async Task<ListAccessKeysResponse> ListAccessKeysAsync(ListAccessKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccessKeysWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the entities to which a policy is attached.
         *
         * @param request ListEntitiesForPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEntitiesForPolicyResponse
         */
        public ListEntitiesForPolicyResponse ListEntitiesForPolicyWithOptions(ListEntitiesForPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEntitiesForPolicy",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEntitiesForPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the entities to which a policy is attached.
         *
         * @param request ListEntitiesForPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEntitiesForPolicyResponse
         */
        public async Task<ListEntitiesForPolicyResponse> ListEntitiesForPolicyWithOptionsAsync(ListEntitiesForPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEntitiesForPolicy",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEntitiesForPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the entities to which a policy is attached.
         *
         * @param request ListEntitiesForPolicyRequest
         * @return ListEntitiesForPolicyResponse
         */
        public ListEntitiesForPolicyResponse ListEntitiesForPolicy(ListEntitiesForPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEntitiesForPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Queries the entities to which a policy is attached.
         *
         * @param request ListEntitiesForPolicyRequest
         * @return ListEntitiesForPolicyResponse
         */
        public async Task<ListEntitiesForPolicyResponse> ListEntitiesForPolicyAsync(ListEntitiesForPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEntitiesForPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries RAM user groups.
         *
         * @param request ListGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupsResponse
         */
        public ListGroupsResponse ListGroupsWithOptions(ListGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroups",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries RAM user groups.
         *
         * @param request ListGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupsResponse
         */
        public async Task<ListGroupsResponse> ListGroupsWithOptionsAsync(ListGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroups",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries RAM user groups.
         *
         * @param request ListGroupsRequest
         * @return ListGroupsResponse
         */
        public ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Queries RAM user groups.
         *
         * @param request ListGroupsRequest
         * @return ListGroupsResponse
         */
        public async Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the Resource Access Management (RAM) user groups to which a RAM user belongs.
         *
         * @description This topic provides an example on how to query the RAM user groups to which the RAM user `Alice` belongs. The response shows that `Alice` belongs to the RAM user group named `Dev-Team`.
         *
         * @param request ListGroupsForUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupsForUserResponse
         */
        public ListGroupsForUserResponse ListGroupsForUserWithOptions(ListGroupsForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroupsForUser",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupsForUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the Resource Access Management (RAM) user groups to which a RAM user belongs.
         *
         * @description This topic provides an example on how to query the RAM user groups to which the RAM user `Alice` belongs. The response shows that `Alice` belongs to the RAM user group named `Dev-Team`.
         *
         * @param request ListGroupsForUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupsForUserResponse
         */
        public async Task<ListGroupsForUserResponse> ListGroupsForUserWithOptionsAsync(ListGroupsForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroupsForUser",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupsForUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the Resource Access Management (RAM) user groups to which a RAM user belongs.
         *
         * @description This topic provides an example on how to query the RAM user groups to which the RAM user `Alice` belongs. The response shows that `Alice` belongs to the RAM user group named `Dev-Team`.
         *
         * @param request ListGroupsForUserRequest
         * @return ListGroupsForUserResponse
         */
        public ListGroupsForUserResponse ListGroupsForUser(ListGroupsForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGroupsForUserWithOptions(request, runtime);
        }

        /**
         * @summary Queries the Resource Access Management (RAM) user groups to which a RAM user belongs.
         *
         * @description This topic provides an example on how to query the RAM user groups to which the RAM user `Alice` belongs. The response shows that `Alice` belongs to the RAM user group named `Dev-Team`.
         *
         * @param request ListGroupsForUserRequest
         * @return ListGroupsForUserResponse
         */
        public async Task<ListGroupsForUserResponse> ListGroupsForUserAsync(ListGroupsForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGroupsForUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of policies.
         *
         * @param request ListPoliciesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPoliciesResponse
         */
        public ListPoliciesResponse ListPoliciesWithOptions(ListPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicies",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPoliciesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of policies.
         *
         * @param request ListPoliciesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPoliciesResponse
         */
        public async Task<ListPoliciesResponse> ListPoliciesWithOptionsAsync(ListPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicies",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of policies.
         *
         * @param request ListPoliciesRequest
         * @return ListPoliciesResponse
         */
        public ListPoliciesResponse ListPolicies(ListPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPoliciesWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of policies.
         *
         * @param request ListPoliciesRequest
         * @return ListPoliciesResponse
         */
        public async Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPoliciesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the policies that are attached to a RAM user group.
         *
         * @param request ListPoliciesForGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPoliciesForGroupResponse
         */
        public ListPoliciesForGroupResponse ListPoliciesForGroupWithOptions(ListPoliciesForGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPoliciesForGroup",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPoliciesForGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the policies that are attached to a RAM user group.
         *
         * @param request ListPoliciesForGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPoliciesForGroupResponse
         */
        public async Task<ListPoliciesForGroupResponse> ListPoliciesForGroupWithOptionsAsync(ListPoliciesForGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPoliciesForGroup",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPoliciesForGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the policies that are attached to a RAM user group.
         *
         * @param request ListPoliciesForGroupRequest
         * @return ListPoliciesForGroupResponse
         */
        public ListPoliciesForGroupResponse ListPoliciesForGroup(ListPoliciesForGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPoliciesForGroupWithOptions(request, runtime);
        }

        /**
         * @summary Queries the policies that are attached to a RAM user group.
         *
         * @param request ListPoliciesForGroupRequest
         * @return ListPoliciesForGroupResponse
         */
        public async Task<ListPoliciesForGroupResponse> ListPoliciesForGroupAsync(ListPoliciesForGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPoliciesForGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the policies that are attached to a RAM role.
         *
         * @param request ListPoliciesForRoleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPoliciesForRoleResponse
         */
        public ListPoliciesForRoleResponse ListPoliciesForRoleWithOptions(ListPoliciesForRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPoliciesForRole",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPoliciesForRoleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the policies that are attached to a RAM role.
         *
         * @param request ListPoliciesForRoleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPoliciesForRoleResponse
         */
        public async Task<ListPoliciesForRoleResponse> ListPoliciesForRoleWithOptionsAsync(ListPoliciesForRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPoliciesForRole",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPoliciesForRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the policies that are attached to a RAM role.
         *
         * @param request ListPoliciesForRoleRequest
         * @return ListPoliciesForRoleResponse
         */
        public ListPoliciesForRoleResponse ListPoliciesForRole(ListPoliciesForRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPoliciesForRoleWithOptions(request, runtime);
        }

        /**
         * @summary Queries the policies that are attached to a RAM role.
         *
         * @param request ListPoliciesForRoleRequest
         * @return ListPoliciesForRoleResponse
         */
        public async Task<ListPoliciesForRoleResponse> ListPoliciesForRoleAsync(ListPoliciesForRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPoliciesForRoleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the policies that are attached to a RAM user.
         *
         * @description > You can call this operation to query only the policies that are attached to Alibaba Cloud accounts. You cannot query the policies that are attached to resource groups.
         *
         * @param request ListPoliciesForUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPoliciesForUserResponse
         */
        public ListPoliciesForUserResponse ListPoliciesForUserWithOptions(ListPoliciesForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPoliciesForUser",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPoliciesForUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the policies that are attached to a RAM user.
         *
         * @description > You can call this operation to query only the policies that are attached to Alibaba Cloud accounts. You cannot query the policies that are attached to resource groups.
         *
         * @param request ListPoliciesForUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPoliciesForUserResponse
         */
        public async Task<ListPoliciesForUserResponse> ListPoliciesForUserWithOptionsAsync(ListPoliciesForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPoliciesForUser",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPoliciesForUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the policies that are attached to a RAM user.
         *
         * @description > You can call this operation to query only the policies that are attached to Alibaba Cloud accounts. You cannot query the policies that are attached to resource groups.
         *
         * @param request ListPoliciesForUserRequest
         * @return ListPoliciesForUserResponse
         */
        public ListPoliciesForUserResponse ListPoliciesForUser(ListPoliciesForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPoliciesForUserWithOptions(request, runtime);
        }

        /**
         * @summary Queries the policies that are attached to a RAM user.
         *
         * @description > You can call this operation to query only the policies that are attached to Alibaba Cloud accounts. You cannot query the policies that are attached to resource groups.
         *
         * @param request ListPoliciesForUserRequest
         * @return ListPoliciesForUserResponse
         */
        public async Task<ListPoliciesForUserResponse> ListPoliciesForUserAsync(ListPoliciesForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPoliciesForUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the versions of a policy.
         *
         * @param request ListPolicyVersionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPolicyVersionsResponse
         */
        public ListPolicyVersionsResponse ListPolicyVersionsWithOptions(ListPolicyVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicyVersions",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPolicyVersionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the versions of a policy.
         *
         * @param request ListPolicyVersionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPolicyVersionsResponse
         */
        public async Task<ListPolicyVersionsResponse> ListPolicyVersionsWithOptionsAsync(ListPolicyVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                query["PolicyType"] = request.PolicyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicyVersions",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPolicyVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the versions of a policy.
         *
         * @param request ListPolicyVersionsRequest
         * @return ListPolicyVersionsResponse
         */
        public ListPolicyVersionsResponse ListPolicyVersions(ListPolicyVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPolicyVersionsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the versions of a policy.
         *
         * @param request ListPolicyVersionsRequest
         * @return ListPolicyVersionsResponse
         */
        public async Task<ListPolicyVersionsResponse> ListPolicyVersionsAsync(ListPolicyVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPolicyVersionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the list of all RAM roles.
         *
         * @param request ListRolesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRolesResponse
         */
        public ListRolesResponse ListRolesWithOptions(ListRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoles",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRolesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the list of all RAM roles.
         *
         * @param request ListRolesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRolesResponse
         */
        public async Task<ListRolesResponse> ListRolesWithOptionsAsync(ListRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoles",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRolesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the list of all RAM roles.
         *
         * @param request ListRolesRequest
         * @return ListRolesResponse
         */
        public ListRolesResponse ListRoles(ListRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRolesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the list of all RAM roles.
         *
         * @param request ListRolesRequest
         * @return ListRolesResponse
         */
        public async Task<ListRolesResponse> ListRolesAsync(ListRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRolesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about all RAM users.
         *
         * @param request ListUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsersResponse
         */
        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about all RAM users.
         *
         * @param request ListUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsersResponse
         */
        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about all RAM users.
         *
         * @param request ListUsersRequest
         * @return ListUsersResponse
         */
        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about all RAM users.
         *
         * @param request ListUsersRequest
         * @return ListUsersResponse
         */
        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListUsersForGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsersForGroupResponse
         */
        public ListUsersForGroupResponse ListUsersForGroupWithOptions(ListUsersForGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsersForGroup",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersForGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListUsersForGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsersForGroupResponse
         */
        public async Task<ListUsersForGroupResponse> ListUsersForGroupWithOptionsAsync(ListUsersForGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItems))
            {
                query["MaxItems"] = request.MaxItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsersForGroup",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersForGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListUsersForGroupRequest
         * @return ListUsersForGroupResponse
         */
        public ListUsersForGroupResponse ListUsersForGroup(ListUsersForGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersForGroupWithOptions(request, runtime);
        }

        /**
         * @param request ListUsersForGroupRequest
         * @return ListUsersForGroupResponse
         */
        public async Task<ListUsersForGroupResponse> ListUsersForGroupAsync(ListUsersForGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersForGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the list of all multi-factor authentication (MFA) devices.
         *
         * @param request ListVirtualMFADevicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListVirtualMFADevicesResponse
         */
        public ListVirtualMFADevicesResponse ListVirtualMFADevicesWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVirtualMFADevices",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVirtualMFADevicesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the list of all multi-factor authentication (MFA) devices.
         *
         * @param request ListVirtualMFADevicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListVirtualMFADevicesResponse
         */
        public async Task<ListVirtualMFADevicesResponse> ListVirtualMFADevicesWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVirtualMFADevices",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVirtualMFADevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the list of all multi-factor authentication (MFA) devices.
         *
         * @return ListVirtualMFADevicesResponse
         */
        public ListVirtualMFADevicesResponse ListVirtualMFADevices()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVirtualMFADevicesWithOptions(runtime);
        }

        /**
         * @summary Queries the list of all multi-factor authentication (MFA) devices.
         *
         * @return ListVirtualMFADevicesResponse
         */
        public async Task<ListVirtualMFADevicesResponse> ListVirtualMFADevicesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVirtualMFADevicesWithOptionsAsync(runtime);
        }

        /**
         * @param request RemoveUserFromGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveUserFromGroupResponse
         */
        public RemoveUserFromGroupResponse RemoveUserFromGroupWithOptions(RemoveUserFromGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveUserFromGroup",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUserFromGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request RemoveUserFromGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveUserFromGroupResponse
         */
        public async Task<RemoveUserFromGroupResponse> RemoveUserFromGroupWithOptionsAsync(RemoveUserFromGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveUserFromGroup",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUserFromGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request RemoveUserFromGroupRequest
         * @return RemoveUserFromGroupResponse
         */
        public RemoveUserFromGroupResponse RemoveUserFromGroup(RemoveUserFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveUserFromGroupWithOptions(request, runtime);
        }

        /**
         * @param request RemoveUserFromGroupRequest
         * @return RemoveUserFromGroupResponse
         */
        public async Task<RemoveUserFromGroupResponse> RemoveUserFromGroupAsync(RemoveUserFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveUserFromGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to specify an alias for an Alibaba Cloud account.
         *
         * @param request SetAccountAliasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetAccountAliasResponse
         */
        public SetAccountAliasResponse SetAccountAliasWithOptions(SetAccountAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountAlias))
            {
                query["AccountAlias"] = request.AccountAlias;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetAccountAlias",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAccountAliasResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to specify an alias for an Alibaba Cloud account.
         *
         * @param request SetAccountAliasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetAccountAliasResponse
         */
        public async Task<SetAccountAliasResponse> SetAccountAliasWithOptionsAsync(SetAccountAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountAlias))
            {
                query["AccountAlias"] = request.AccountAlias;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetAccountAlias",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAccountAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to specify an alias for an Alibaba Cloud account.
         *
         * @param request SetAccountAliasRequest
         * @return SetAccountAliasResponse
         */
        public SetAccountAliasResponse SetAccountAlias(SetAccountAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAccountAliasWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to specify an alias for an Alibaba Cloud account.
         *
         * @param request SetAccountAliasRequest
         * @return SetAccountAliasResponse
         */
        public async Task<SetAccountAliasResponse> SetAccountAliasAsync(SetAccountAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAccountAliasWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Sets the default version of a policy.
         *
         * @param request SetDefaultPolicyVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDefaultPolicyVersionResponse
         */
        public SetDefaultPolicyVersionResponse SetDefaultPolicyVersionWithOptions(SetDefaultPolicyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDefaultPolicyVersion",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDefaultPolicyVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Sets the default version of a policy.
         *
         * @param request SetDefaultPolicyVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDefaultPolicyVersionResponse
         */
        public async Task<SetDefaultPolicyVersionResponse> SetDefaultPolicyVersionWithOptionsAsync(SetDefaultPolicyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDefaultPolicyVersion",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDefaultPolicyVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Sets the default version of a policy.
         *
         * @param request SetDefaultPolicyVersionRequest
         * @return SetDefaultPolicyVersionResponse
         */
        public SetDefaultPolicyVersionResponse SetDefaultPolicyVersion(SetDefaultPolicyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDefaultPolicyVersionWithOptions(request, runtime);
        }

        /**
         * @summary Sets the default version of a policy.
         *
         * @param request SetDefaultPolicyVersionRequest
         * @return SetDefaultPolicyVersionResponse
         */
        public async Task<SetDefaultPolicyVersionResponse> SetDefaultPolicyVersionAsync(SetDefaultPolicyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDefaultPolicyVersionWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SetPasswordPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetPasswordPolicyResponse
         */
        public SetPasswordPolicyResponse SetPasswordPolicyWithOptions(SetPasswordPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HardExpiry))
            {
                query["HardExpiry"] = request.HardExpiry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxLoginAttemps))
            {
                query["MaxLoginAttemps"] = request.MaxLoginAttemps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPasswordAge))
            {
                query["MaxPasswordAge"] = request.MaxPasswordAge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinimumPasswordLength))
            {
                query["MinimumPasswordLength"] = request.MinimumPasswordLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordReusePrevention))
            {
                query["PasswordReusePrevention"] = request.PasswordReusePrevention;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireLowercaseCharacters))
            {
                query["RequireLowercaseCharacters"] = request.RequireLowercaseCharacters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireNumbers))
            {
                query["RequireNumbers"] = request.RequireNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireSymbols))
            {
                query["RequireSymbols"] = request.RequireSymbols;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireUppercaseCharacters))
            {
                query["RequireUppercaseCharacters"] = request.RequireUppercaseCharacters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetPasswordPolicy",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetPasswordPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request SetPasswordPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetPasswordPolicyResponse
         */
        public async Task<SetPasswordPolicyResponse> SetPasswordPolicyWithOptionsAsync(SetPasswordPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HardExpiry))
            {
                query["HardExpiry"] = request.HardExpiry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxLoginAttemps))
            {
                query["MaxLoginAttemps"] = request.MaxLoginAttemps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPasswordAge))
            {
                query["MaxPasswordAge"] = request.MaxPasswordAge;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinimumPasswordLength))
            {
                query["MinimumPasswordLength"] = request.MinimumPasswordLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordReusePrevention))
            {
                query["PasswordReusePrevention"] = request.PasswordReusePrevention;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireLowercaseCharacters))
            {
                query["RequireLowercaseCharacters"] = request.RequireLowercaseCharacters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireNumbers))
            {
                query["RequireNumbers"] = request.RequireNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireSymbols))
            {
                query["RequireSymbols"] = request.RequireSymbols;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireUppercaseCharacters))
            {
                query["RequireUppercaseCharacters"] = request.RequireUppercaseCharacters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetPasswordPolicy",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetPasswordPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request SetPasswordPolicyRequest
         * @return SetPasswordPolicyResponse
         */
        public SetPasswordPolicyResponse SetPasswordPolicy(SetPasswordPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetPasswordPolicyWithOptions(request, runtime);
        }

        /**
         * @param request SetPasswordPolicyRequest
         * @return SetPasswordPolicyResponse
         */
        public async Task<SetPasswordPolicyResponse> SetPasswordPolicyAsync(SetPasswordPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetPasswordPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SetSecurityPreferenceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetSecurityPreferenceResponse
         */
        public SetSecurityPreferenceResponse SetSecurityPreferenceWithOptions(SetSecurityPreferenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUserToChangePassword))
            {
                query["AllowUserToChangePassword"] = request.AllowUserToChangePassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUserToManageAccessKeys))
            {
                query["AllowUserToManageAccessKeys"] = request.AllowUserToManageAccessKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUserToManageMFADevices))
            {
                query["AllowUserToManageMFADevices"] = request.AllowUserToManageMFADevices;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUserToManagePublicKeys))
            {
                query["AllowUserToManagePublicKeys"] = request.AllowUserToManagePublicKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSaveMFATicket))
            {
                query["EnableSaveMFATicket"] = request.EnableSaveMFATicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginNetworkMasks))
            {
                query["LoginNetworkMasks"] = request.LoginNetworkMasks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginSessionDuration))
            {
                query["LoginSessionDuration"] = request.LoginSessionDuration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSecurityPreference",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSecurityPreferenceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request SetSecurityPreferenceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetSecurityPreferenceResponse
         */
        public async Task<SetSecurityPreferenceResponse> SetSecurityPreferenceWithOptionsAsync(SetSecurityPreferenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUserToChangePassword))
            {
                query["AllowUserToChangePassword"] = request.AllowUserToChangePassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUserToManageAccessKeys))
            {
                query["AllowUserToManageAccessKeys"] = request.AllowUserToManageAccessKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUserToManageMFADevices))
            {
                query["AllowUserToManageMFADevices"] = request.AllowUserToManageMFADevices;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowUserToManagePublicKeys))
            {
                query["AllowUserToManagePublicKeys"] = request.AllowUserToManagePublicKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSaveMFATicket))
            {
                query["EnableSaveMFATicket"] = request.EnableSaveMFATicket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginNetworkMasks))
            {
                query["LoginNetworkMasks"] = request.LoginNetworkMasks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginSessionDuration))
            {
                query["LoginSessionDuration"] = request.LoginSessionDuration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSecurityPreference",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSecurityPreferenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request SetSecurityPreferenceRequest
         * @return SetSecurityPreferenceResponse
         */
        public SetSecurityPreferenceResponse SetSecurityPreference(SetSecurityPreferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetSecurityPreferenceWithOptions(request, runtime);
        }

        /**
         * @param request SetSecurityPreferenceRequest
         * @return SetSecurityPreferenceResponse
         */
        public async Task<SetSecurityPreferenceResponse> SetSecurityPreferenceAsync(SetSecurityPreferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetSecurityPreferenceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UnbindMFADeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindMFADeviceResponse
         */
        public UnbindMFADeviceResponse UnbindMFADeviceWithOptions(UnbindMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindMFADevice",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindMFADeviceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UnbindMFADeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindMFADeviceResponse
         */
        public async Task<UnbindMFADeviceResponse> UnbindMFADeviceWithOptionsAsync(UnbindMFADeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindMFADevice",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindMFADeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UnbindMFADeviceRequest
         * @return UnbindMFADeviceResponse
         */
        public UnbindMFADeviceResponse UnbindMFADevice(UnbindMFADeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindMFADeviceWithOptions(request, runtime);
        }

        /**
         * @param request UnbindMFADeviceRequest
         * @return UnbindMFADeviceResponse
         */
        public async Task<UnbindMFADeviceResponse> UnbindMFADeviceAsync(UnbindMFADeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindMFADeviceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateAccessKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAccessKeyResponse
         */
        public UpdateAccessKeyResponse UpdateAccessKeyWithOptions(UpdateAccessKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAccessKey",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAccessKeyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateAccessKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAccessKeyResponse
         */
        public async Task<UpdateAccessKeyResponse> UpdateAccessKeyWithOptionsAsync(UpdateAccessKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAccessKey",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAccessKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateAccessKeyRequest
         * @return UpdateAccessKeyResponse
         */
        public UpdateAccessKeyResponse UpdateAccessKey(UpdateAccessKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAccessKeyWithOptions(request, runtime);
        }

        /**
         * @param request UpdateAccessKeyRequest
         * @return UpdateAccessKeyResponse
         */
        public async Task<UpdateAccessKeyResponse> UpdateAccessKeyAsync(UpdateAccessKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAccessKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a RAM user group.
         *
         * @param request UpdateGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupResponse
         */
        public UpdateGroupResponse UpdateGroupWithOptions(UpdateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewComments))
            {
                query["NewComments"] = request.NewComments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewGroupName))
            {
                query["NewGroupName"] = request.NewGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroup",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies a RAM user group.
         *
         * @param request UpdateGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupResponse
         */
        public async Task<UpdateGroupResponse> UpdateGroupWithOptionsAsync(UpdateGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewComments))
            {
                query["NewComments"] = request.NewComments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewGroupName))
            {
                query["NewGroupName"] = request.NewGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroup",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a RAM user group.
         *
         * @param request UpdateGroupRequest
         * @return UpdateGroupResponse
         */
        public UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGroupWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a RAM user group.
         *
         * @param request UpdateGroupRequest
         * @return UpdateGroupResponse
         */
        public async Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateLoginProfileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLoginProfileResponse
         */
        public UpdateLoginProfileResponse UpdateLoginProfileWithOptions(UpdateLoginProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MFABindRequired))
            {
                query["MFABindRequired"] = request.MFABindRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordResetRequired))
            {
                query["PasswordResetRequired"] = request.PasswordResetRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLoginProfile",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLoginProfileResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateLoginProfileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLoginProfileResponse
         */
        public async Task<UpdateLoginProfileResponse> UpdateLoginProfileWithOptionsAsync(UpdateLoginProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MFABindRequired))
            {
                query["MFABindRequired"] = request.MFABindRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordResetRequired))
            {
                query["PasswordResetRequired"] = request.PasswordResetRequired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLoginProfile",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLoginProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateLoginProfileRequest
         * @return UpdateLoginProfileResponse
         */
        public UpdateLoginProfileResponse UpdateLoginProfile(UpdateLoginProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLoginProfileWithOptions(request, runtime);
        }

        /**
         * @param request UpdateLoginProfileRequest
         * @return UpdateLoginProfileResponse
         */
        public async Task<UpdateLoginProfileResponse> UpdateLoginProfileAsync(UpdateLoginProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLoginProfileWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the description of a custom policy.
         *
         * @description You can call this operation to modify only the description of a custom policy. You cannot modify the description of a system policy.
         *
         * @param request UpdatePolicyDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePolicyDescriptionResponse
         */
        public UpdatePolicyDescriptionResponse UpdatePolicyDescriptionWithOptions(UpdatePolicyDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDescription))
            {
                query["NewDescription"] = request.NewDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePolicyDescription",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePolicyDescriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the description of a custom policy.
         *
         * @description You can call this operation to modify only the description of a custom policy. You cannot modify the description of a system policy.
         *
         * @param request UpdatePolicyDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePolicyDescriptionResponse
         */
        public async Task<UpdatePolicyDescriptionResponse> UpdatePolicyDescriptionWithOptionsAsync(UpdatePolicyDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDescription))
            {
                query["NewDescription"] = request.NewDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePolicyDescription",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePolicyDescriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the description of a custom policy.
         *
         * @description You can call this operation to modify only the description of a custom policy. You cannot modify the description of a system policy.
         *
         * @param request UpdatePolicyDescriptionRequest
         * @return UpdatePolicyDescriptionResponse
         */
        public UpdatePolicyDescriptionResponse UpdatePolicyDescription(UpdatePolicyDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePolicyDescriptionWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the description of a custom policy.
         *
         * @description You can call this operation to modify only the description of a custom policy. You cannot modify the description of a system policy.
         *
         * @param request UpdatePolicyDescriptionRequest
         * @return UpdatePolicyDescriptionResponse
         */
        public async Task<UpdatePolicyDescriptionResponse> UpdatePolicyDescriptionAsync(UpdatePolicyDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePolicyDescriptionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the description of a RAM role.
         *
         * @description This topic provides an example to show how to change the description of ECSAdmin to ECS administrator.
         *
         * @param request UpdateRoleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRoleResponse
         */
        public UpdateRoleResponse UpdateRoleWithOptions(UpdateRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewAssumeRolePolicyDocument))
            {
                query["NewAssumeRolePolicyDocument"] = request.NewAssumeRolePolicyDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDescription))
            {
                query["NewDescription"] = request.NewDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewMaxSessionDuration))
            {
                query["NewMaxSessionDuration"] = request.NewMaxSessionDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRole",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRoleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes the description of a RAM role.
         *
         * @description This topic provides an example to show how to change the description of ECSAdmin to ECS administrator.
         *
         * @param request UpdateRoleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRoleResponse
         */
        public async Task<UpdateRoleResponse> UpdateRoleWithOptionsAsync(UpdateRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewAssumeRolePolicyDocument))
            {
                query["NewAssumeRolePolicyDocument"] = request.NewAssumeRolePolicyDocument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDescription))
            {
                query["NewDescription"] = request.NewDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewMaxSessionDuration))
            {
                query["NewMaxSessionDuration"] = request.NewMaxSessionDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRole",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes the description of a RAM role.
         *
         * @description This topic provides an example to show how to change the description of ECSAdmin to ECS administrator.
         *
         * @param request UpdateRoleRequest
         * @return UpdateRoleResponse
         */
        public UpdateRoleResponse UpdateRole(UpdateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRoleWithOptions(request, runtime);
        }

        /**
         * @summary Changes the description of a RAM role.
         *
         * @description This topic provides an example to show how to change the description of ECSAdmin to ECS administrator.
         *
         * @param request UpdateRoleRequest
         * @return UpdateRoleResponse
         */
        public async Task<UpdateRoleResponse> UpdateRoleAsync(UpdateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRoleWithOptionsAsync(request, runtime);
        }

        /**
         * @description This topic provides an example on how to change the name of a RAM user from `zhangq****` to `xiaoq****`.
         *
         * @param request UpdateUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserResponse
         */
        public UpdateUserResponse UpdateUserWithOptions(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewComments))
            {
                query["NewComments"] = request.NewComments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDisplayName))
            {
                query["NewDisplayName"] = request.NewDisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewEmail))
            {
                query["NewEmail"] = request.NewEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewMobilePhone))
            {
                query["NewMobilePhone"] = request.NewMobilePhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewUserName))
            {
                query["NewUserName"] = request.NewUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description This topic provides an example on how to change the name of a RAM user from `zhangq****` to `xiaoq****`.
         *
         * @param request UpdateUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserResponse
         */
        public async Task<UpdateUserResponse> UpdateUserWithOptionsAsync(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewComments))
            {
                query["NewComments"] = request.NewComments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDisplayName))
            {
                query["NewDisplayName"] = request.NewDisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewEmail))
            {
                query["NewEmail"] = request.NewEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewMobilePhone))
            {
                query["NewMobilePhone"] = request.NewMobilePhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewUserName))
            {
                query["NewUserName"] = request.NewUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2015-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description This topic provides an example on how to change the name of a RAM user from `zhangq****` to `xiaoq****`.
         *
         * @param request UpdateUserRequest
         * @return UpdateUserResponse
         */
        public UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserWithOptions(request, runtime);
        }

        /**
         * @description This topic provides an example on how to change the name of a RAM user from `zhangq****` to `xiaoq****`.
         *
         * @param request UpdateUserRequest
         * @return UpdateUserResponse
         */
        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserWithOptionsAsync(request, runtime);
        }

    }
}
