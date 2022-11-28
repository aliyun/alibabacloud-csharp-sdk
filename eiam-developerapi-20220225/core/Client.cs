// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Eiam_developerapi20220225.Models;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("eiam-developerapi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateOrganizationalUnitResponse CreateOrganizationalUnit(string instanceId, string applicationId, CreateOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateOrganizationalUnitHeaders headers = new CreateOrganizationalUnitHeaders();
            return CreateOrganizationalUnitWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        public async Task<CreateOrganizationalUnitResponse> CreateOrganizationalUnitAsync(string instanceId, string applicationId, CreateOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateOrganizationalUnitHeaders headers = new CreateOrganizationalUnitHeaders();
            return await CreateOrganizationalUnitWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        public CreateOrganizationalUnitResponse CreateOrganizationalUnitWithOptions(string instanceId, string applicationId, CreateOrganizationalUnitRequest request, CreateOrganizationalUnitHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitExternalId))
            {
                body["organizationalUnitExternalId"] = request.OrganizationalUnitExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitName))
            {
                body["organizationalUnitName"] = request.OrganizationalUnitName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrganizationalUnit",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/organizationalUnits",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrganizationalUnitResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateOrganizationalUnitResponse> CreateOrganizationalUnitWithOptionsAsync(string instanceId, string applicationId, CreateOrganizationalUnitRequest request, CreateOrganizationalUnitHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitExternalId))
            {
                body["organizationalUnitExternalId"] = request.OrganizationalUnitExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitName))
            {
                body["organizationalUnitName"] = request.OrganizationalUnitName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                body["parentId"] = request.ParentId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrganizationalUnit",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/organizationalUnits",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrganizationalUnitResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateUserResponse CreateUser(string instanceId, string applicationId, CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateUserHeaders headers = new CreateUserHeaders();
            return CreateUserWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        public async Task<CreateUserResponse> CreateUserAsync(string instanceId, string applicationId, CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateUserHeaders headers = new CreateUserHeaders();
            return await CreateUserWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        public CreateUserResponse CreateUserWithOptions(string instanceId, string applicationId, CreateUserRequest request, CreateUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFields))
            {
                body["customFields"] = request.CustomFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailVerified))
            {
                body["emailVerified"] = request.EmailVerified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordInitializationConfig))
            {
                body["passwordInitializationConfig"] = request.PasswordInitializationConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["phoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumberVerified))
            {
                body["phoneNumberVerified"] = request.PhoneNumberVerified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneRegion))
            {
                body["phoneRegion"] = request.PhoneRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryOrganizationalUnitId))
            {
                body["primaryOrganizationalUnitId"] = request.PrimaryOrganizationalUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserExternalId))
            {
                body["userExternalId"] = request.UserExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["username"] = request.Username;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateUserResponse> CreateUserWithOptionsAsync(string instanceId, string applicationId, CreateUserRequest request, CreateUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFields))
            {
                body["customFields"] = request.CustomFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailVerified))
            {
                body["emailVerified"] = request.EmailVerified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordInitializationConfig))
            {
                body["passwordInitializationConfig"] = request.PasswordInitializationConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["phoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumberVerified))
            {
                body["phoneNumberVerified"] = request.PhoneNumberVerified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneRegion))
            {
                body["phoneRegion"] = request.PhoneRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryOrganizationalUnitId))
            {
                body["primaryOrganizationalUnitId"] = request.PrimaryOrganizationalUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserExternalId))
            {
                body["userExternalId"] = request.UserExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["username"] = request.Username;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUser",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteOrganizationalUnitResponse DeleteOrganizationalUnit(string instanceId, string applicationId, string organizationalUnitId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteOrganizationalUnitHeaders headers = new DeleteOrganizationalUnitHeaders();
            return DeleteOrganizationalUnitWithOptions(instanceId, applicationId, organizationalUnitId, headers, runtime);
        }

        public async Task<DeleteOrganizationalUnitResponse> DeleteOrganizationalUnitAsync(string instanceId, string applicationId, string organizationalUnitId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteOrganizationalUnitHeaders headers = new DeleteOrganizationalUnitHeaders();
            return await DeleteOrganizationalUnitWithOptionsAsync(instanceId, applicationId, organizationalUnitId, headers, runtime);
        }

        public DeleteOrganizationalUnitResponse DeleteOrganizationalUnitWithOptions(string instanceId, string applicationId, string organizationalUnitId, DeleteOrganizationalUnitHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOrganizationalUnit",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/organizationalUnits/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationalUnitId),
                Method = "DELETE",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteOrganizationalUnitResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteOrganizationalUnitResponse> DeleteOrganizationalUnitWithOptionsAsync(string instanceId, string applicationId, string organizationalUnitId, DeleteOrganizationalUnitHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOrganizationalUnit",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/organizationalUnits/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationalUnitId),
                Method = "DELETE",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteOrganizationalUnitResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteUserResponse DeleteUser(string instanceId, string applicationId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteUserHeaders headers = new DeleteUserHeaders();
            return DeleteUserWithOptions(instanceId, applicationId, userId, headers, runtime);
        }

        public async Task<DeleteUserResponse> DeleteUserAsync(string instanceId, string applicationId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteUserHeaders headers = new DeleteUserHeaders();
            return await DeleteUserWithOptionsAsync(instanceId, applicationId, userId, headers, runtime);
        }

        public DeleteUserResponse DeleteUserWithOptions(string instanceId, string applicationId, string userId, DeleteUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId),
                Method = "DELETE",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteUserResponse> DeleteUserWithOptionsAsync(string instanceId, string applicationId, string userId, DeleteUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUser",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId),
                Method = "DELETE",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisableUserResponse DisableUser(string instanceId, string applicationId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DisableUserHeaders headers = new DisableUserHeaders();
            return DisableUserWithOptions(instanceId, applicationId, userId, headers, runtime);
        }

        public async Task<DisableUserResponse> DisableUserAsync(string instanceId, string applicationId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DisableUserHeaders headers = new DisableUserHeaders();
            return await DisableUserWithOptionsAsync(instanceId, applicationId, userId, headers, runtime);
        }

        public DisableUserResponse DisableUserWithOptions(string instanceId, string applicationId, string userId, DisableUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableUser",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId) + "/actions/disable",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DisableUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisableUserResponse> DisableUserWithOptionsAsync(string instanceId, string applicationId, string userId, DisableUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableUser",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId) + "/actions/disable",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DisableUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableUserResponse EnableUser(string instanceId, string applicationId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EnableUserHeaders headers = new EnableUserHeaders();
            return EnableUserWithOptions(instanceId, applicationId, userId, headers, runtime);
        }

        public async Task<EnableUserResponse> EnableUserAsync(string instanceId, string applicationId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EnableUserHeaders headers = new EnableUserHeaders();
            return await EnableUserWithOptionsAsync(instanceId, applicationId, userId, headers, runtime);
        }

        public EnableUserResponse EnableUserWithOptions(string instanceId, string applicationId, string userId, EnableUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableUser",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId) + "/actions/enable",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<EnableUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableUserResponse> EnableUserWithOptionsAsync(string instanceId, string applicationId, string userId, EnableUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableUser",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId) + "/actions/enable",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<EnableUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GenerateDeviceCodeResponse GenerateDeviceCode(string instanceId, string applicationId, GenerateDeviceCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateDeviceCodeWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        public async Task<GenerateDeviceCodeResponse> GenerateDeviceCodeAsync(string instanceId, string applicationId, GenerateDeviceCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateDeviceCodeWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        public GenerateDeviceCodeResponse GenerateDeviceCodeWithOptions(string instanceId, string applicationId, GenerateDeviceCodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateDeviceCode",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/oauth2/device/code",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateDeviceCodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GenerateDeviceCodeResponse> GenerateDeviceCodeWithOptionsAsync(string instanceId, string applicationId, GenerateDeviceCodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateDeviceCode",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/oauth2/device/code",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateDeviceCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GenerateTokenResponse GenerateToken(string instanceId, string applicationId, GenerateTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateTokenWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        public async Task<GenerateTokenResponse> GenerateTokenAsync(string instanceId, string applicationId, GenerateTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateTokenWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        public GenerateTokenResponse GenerateTokenWithOptions(string instanceId, string applicationId, GenerateTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["client_id"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSecret))
            {
                query["client_secret"] = request.ClientSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeVerifier))
            {
                query["code_verifier"] = request.CodeVerifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                query["device_code"] = request.DeviceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExclusiveTag))
            {
                query["exclusive_tag"] = request.ExclusiveTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantType))
            {
                query["grant_type"] = request.GrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUri))
            {
                query["redirect_uri"] = request.RedirectUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefreshToken))
            {
                query["refresh_token"] = request.RefreshToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateToken",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/oauth2/token",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateTokenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GenerateTokenResponse> GenerateTokenWithOptionsAsync(string instanceId, string applicationId, GenerateTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["client_id"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSecret))
            {
                query["client_secret"] = request.ClientSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeVerifier))
            {
                query["code_verifier"] = request.CodeVerifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                query["device_code"] = request.DeviceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExclusiveTag))
            {
                query["exclusive_tag"] = request.ExclusiveTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantType))
            {
                query["grant_type"] = request.GrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUri))
            {
                query["redirect_uri"] = request.RedirectUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefreshToken))
            {
                query["refresh_token"] = request.RefreshToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateToken",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/oauth2/token",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetApplicationProvisioningScopeResponse GetApplicationProvisioningScope(string instanceId, string applicationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetApplicationProvisioningScopeHeaders headers = new GetApplicationProvisioningScopeHeaders();
            return GetApplicationProvisioningScopeWithOptions(instanceId, applicationId, headers, runtime);
        }

        public async Task<GetApplicationProvisioningScopeResponse> GetApplicationProvisioningScopeAsync(string instanceId, string applicationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetApplicationProvisioningScopeHeaders headers = new GetApplicationProvisioningScopeHeaders();
            return await GetApplicationProvisioningScopeWithOptionsAsync(instanceId, applicationId, headers, runtime);
        }

        public GetApplicationProvisioningScopeResponse GetApplicationProvisioningScopeWithOptions(string instanceId, string applicationId, GetApplicationProvisioningScopeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplicationProvisioningScope",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/provisioningScope",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationProvisioningScopeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetApplicationProvisioningScopeResponse> GetApplicationProvisioningScopeWithOptionsAsync(string instanceId, string applicationId, GetApplicationProvisioningScopeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplicationProvisioningScope",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/provisioningScope",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationProvisioningScopeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetOrganizationalUnitResponse GetOrganizationalUnit(string instanceId, string applicationId, string organizationalUnitId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizationalUnitHeaders headers = new GetOrganizationalUnitHeaders();
            return GetOrganizationalUnitWithOptions(instanceId, applicationId, organizationalUnitId, headers, runtime);
        }

        public async Task<GetOrganizationalUnitResponse> GetOrganizationalUnitAsync(string instanceId, string applicationId, string organizationalUnitId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizationalUnitHeaders headers = new GetOrganizationalUnitHeaders();
            return await GetOrganizationalUnitWithOptionsAsync(instanceId, applicationId, organizationalUnitId, headers, runtime);
        }

        public GetOrganizationalUnitResponse GetOrganizationalUnitWithOptions(string instanceId, string applicationId, string organizationalUnitId, GetOrganizationalUnitHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrganizationalUnit",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/organizationalUnits/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationalUnitId),
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizationalUnitResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetOrganizationalUnitResponse> GetOrganizationalUnitWithOptionsAsync(string instanceId, string applicationId, string organizationalUnitId, GetOrganizationalUnitHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrganizationalUnit",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/organizationalUnits/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationalUnitId),
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizationalUnitResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetOrganizationalUnitIdByExternalIdResponse GetOrganizationalUnitIdByExternalId(string instanceId, string applicationId, GetOrganizationalUnitIdByExternalIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizationalUnitIdByExternalIdHeaders headers = new GetOrganizationalUnitIdByExternalIdHeaders();
            return GetOrganizationalUnitIdByExternalIdWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        public async Task<GetOrganizationalUnitIdByExternalIdResponse> GetOrganizationalUnitIdByExternalIdAsync(string instanceId, string applicationId, GetOrganizationalUnitIdByExternalIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizationalUnitIdByExternalIdHeaders headers = new GetOrganizationalUnitIdByExternalIdHeaders();
            return await GetOrganizationalUnitIdByExternalIdWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        public GetOrganizationalUnitIdByExternalIdResponse GetOrganizationalUnitIdByExternalIdWithOptions(string instanceId, string applicationId, GetOrganizationalUnitIdByExternalIdRequest request, GetOrganizationalUnitIdByExternalIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitExternalId))
            {
                body["organizationalUnitExternalId"] = request.OrganizationalUnitExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitSourceId))
            {
                body["organizationalUnitSourceId"] = request.OrganizationalUnitSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitSourceType))
            {
                body["organizationalUnitSourceType"] = request.OrganizationalUnitSourceType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrganizationalUnitIdByExternalId",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/organizationalUnits/_/actions/getOrganizationalUnitIdByExternalId",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizationalUnitIdByExternalIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetOrganizationalUnitIdByExternalIdResponse> GetOrganizationalUnitIdByExternalIdWithOptionsAsync(string instanceId, string applicationId, GetOrganizationalUnitIdByExternalIdRequest request, GetOrganizationalUnitIdByExternalIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitExternalId))
            {
                body["organizationalUnitExternalId"] = request.OrganizationalUnitExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitSourceId))
            {
                body["organizationalUnitSourceId"] = request.OrganizationalUnitSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitSourceType))
            {
                body["organizationalUnitSourceType"] = request.OrganizationalUnitSourceType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrganizationalUnitIdByExternalId",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/organizationalUnits/_/actions/getOrganizationalUnitIdByExternalId",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizationalUnitIdByExternalIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetUserResponse GetUser(string instanceId, string applicationId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHeaders headers = new GetUserHeaders();
            return GetUserWithOptions(instanceId, applicationId, userId, headers, runtime);
        }

        public async Task<GetUserResponse> GetUserAsync(string instanceId, string applicationId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHeaders headers = new GetUserHeaders();
            return await GetUserWithOptionsAsync(instanceId, applicationId, userId, headers, runtime);
        }

        public GetUserResponse GetUserWithOptions(string instanceId, string applicationId, string userId, GetUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId),
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUserResponse> GetUserWithOptionsAsync(string instanceId, string applicationId, string userId, GetUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId),
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetUserIdByEmailResponse GetUserIdByEmail(string instanceId, string applicationId, GetUserIdByEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserIdByEmailHeaders headers = new GetUserIdByEmailHeaders();
            return GetUserIdByEmailWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        public async Task<GetUserIdByEmailResponse> GetUserIdByEmailAsync(string instanceId, string applicationId, GetUserIdByEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserIdByEmailHeaders headers = new GetUserIdByEmailHeaders();
            return await GetUserIdByEmailWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        public GetUserIdByEmailResponse GetUserIdByEmailWithOptions(string instanceId, string applicationId, GetUserIdByEmailRequest request, GetUserIdByEmailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["email"] = request.Email;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserIdByEmail",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/_/actions/getUserIdByEmail",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserIdByEmailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUserIdByEmailResponse> GetUserIdByEmailWithOptionsAsync(string instanceId, string applicationId, GetUserIdByEmailRequest request, GetUserIdByEmailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["email"] = request.Email;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserIdByEmail",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/_/actions/getUserIdByEmail",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserIdByEmailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetUserIdByPhoneNumberResponse GetUserIdByPhoneNumber(string instanceId, string applicationId, GetUserIdByPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserIdByPhoneNumberHeaders headers = new GetUserIdByPhoneNumberHeaders();
            return GetUserIdByPhoneNumberWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        public async Task<GetUserIdByPhoneNumberResponse> GetUserIdByPhoneNumberAsync(string instanceId, string applicationId, GetUserIdByPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserIdByPhoneNumberHeaders headers = new GetUserIdByPhoneNumberHeaders();
            return await GetUserIdByPhoneNumberWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        public GetUserIdByPhoneNumberResponse GetUserIdByPhoneNumberWithOptions(string instanceId, string applicationId, GetUserIdByPhoneNumberRequest request, GetUserIdByPhoneNumberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["phoneNumber"] = request.PhoneNumber;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserIdByPhoneNumber",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/_/actions/getUserIdByPhoneNumber",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserIdByPhoneNumberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUserIdByPhoneNumberResponse> GetUserIdByPhoneNumberWithOptionsAsync(string instanceId, string applicationId, GetUserIdByPhoneNumberRequest request, GetUserIdByPhoneNumberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["phoneNumber"] = request.PhoneNumber;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserIdByPhoneNumber",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/_/actions/getUserIdByPhoneNumber",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserIdByPhoneNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetUserIdByUserExternalIdResponse GetUserIdByUserExternalId(string instanceId, string applicationId, GetUserIdByUserExternalIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserIdByUserExternalIdHeaders headers = new GetUserIdByUserExternalIdHeaders();
            return GetUserIdByUserExternalIdWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        public async Task<GetUserIdByUserExternalIdResponse> GetUserIdByUserExternalIdAsync(string instanceId, string applicationId, GetUserIdByUserExternalIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserIdByUserExternalIdHeaders headers = new GetUserIdByUserExternalIdHeaders();
            return await GetUserIdByUserExternalIdWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        public GetUserIdByUserExternalIdResponse GetUserIdByUserExternalIdWithOptions(string instanceId, string applicationId, GetUserIdByUserExternalIdRequest request, GetUserIdByUserExternalIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserExternalId))
            {
                body["userExternalId"] = request.UserExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSourceId))
            {
                body["userSourceId"] = request.UserSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSourceType))
            {
                body["userSourceType"] = request.UserSourceType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserIdByUserExternalId",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/_/actions/getUserIdByExternalId",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserIdByUserExternalIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUserIdByUserExternalIdResponse> GetUserIdByUserExternalIdWithOptionsAsync(string instanceId, string applicationId, GetUserIdByUserExternalIdRequest request, GetUserIdByUserExternalIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserExternalId))
            {
                body["userExternalId"] = request.UserExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSourceId))
            {
                body["userSourceId"] = request.UserSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSourceType))
            {
                body["userSourceType"] = request.UserSourceType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserIdByUserExternalId",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/_/actions/getUserIdByExternalId",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserIdByUserExternalIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetUserIdByUsernameResponse GetUserIdByUsername(string instanceId, string applicationId, GetUserIdByUsernameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserIdByUsernameHeaders headers = new GetUserIdByUsernameHeaders();
            return GetUserIdByUsernameWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        public async Task<GetUserIdByUsernameResponse> GetUserIdByUsernameAsync(string instanceId, string applicationId, GetUserIdByUsernameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserIdByUsernameHeaders headers = new GetUserIdByUsernameHeaders();
            return await GetUserIdByUsernameWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        public GetUserIdByUsernameResponse GetUserIdByUsernameWithOptions(string instanceId, string applicationId, GetUserIdByUsernameRequest request, GetUserIdByUsernameHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["username"] = request.Username;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserIdByUsername",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/_/actions/getUserIdByUsername",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserIdByUsernameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUserIdByUsernameResponse> GetUserIdByUsernameWithOptionsAsync(string instanceId, string applicationId, GetUserIdByUsernameRequest request, GetUserIdByUsernameHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["username"] = request.Username;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserIdByUsername",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/_/actions/getUserIdByUsername",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserIdByUsernameResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetUserInfoResponse GetUserInfo(string instanceId, string applicationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserInfoHeaders headers = new GetUserInfoHeaders();
            return GetUserInfoWithOptions(instanceId, applicationId, headers, runtime);
        }

        public async Task<GetUserInfoResponse> GetUserInfoAsync(string instanceId, string applicationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserInfoHeaders headers = new GetUserInfoHeaders();
            return await GetUserInfoWithOptionsAsync(instanceId, applicationId, headers, runtime);
        }

        public GetUserInfoResponse GetUserInfoWithOptions(string instanceId, string applicationId, GetUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserInfo",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/oauth2/userinfo",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUserInfoResponse> GetUserInfoWithOptionsAsync(string instanceId, string applicationId, GetUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserInfo",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/oauth2/userinfo",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListOrganizationalUnitParentIdsResponse ListOrganizationalUnitParentIds(string instanceId, string applicationId, string organizationalUnitId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListOrganizationalUnitParentIdsHeaders headers = new ListOrganizationalUnitParentIdsHeaders();
            return ListOrganizationalUnitParentIdsWithOptions(instanceId, applicationId, organizationalUnitId, headers, runtime);
        }

        public async Task<ListOrganizationalUnitParentIdsResponse> ListOrganizationalUnitParentIdsAsync(string instanceId, string applicationId, string organizationalUnitId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListOrganizationalUnitParentIdsHeaders headers = new ListOrganizationalUnitParentIdsHeaders();
            return await ListOrganizationalUnitParentIdsWithOptionsAsync(instanceId, applicationId, organizationalUnitId, headers, runtime);
        }

        public ListOrganizationalUnitParentIdsResponse ListOrganizationalUnitParentIdsWithOptions(string instanceId, string applicationId, string organizationalUnitId, ListOrganizationalUnitParentIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrganizationalUnitParentIds",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/organizationalUnits/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationalUnitId) + "/parentIds",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrganizationalUnitParentIdsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListOrganizationalUnitParentIdsResponse> ListOrganizationalUnitParentIdsWithOptionsAsync(string instanceId, string applicationId, string organizationalUnitId, ListOrganizationalUnitParentIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrganizationalUnitParentIds",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/organizationalUnits/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationalUnitId) + "/parentIds",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrganizationalUnitParentIdsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListOrganizationalUnitsResponse ListOrganizationalUnits(string instanceId, string applicationId, ListOrganizationalUnitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListOrganizationalUnitsHeaders headers = new ListOrganizationalUnitsHeaders();
            return ListOrganizationalUnitsWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        public async Task<ListOrganizationalUnitsResponse> ListOrganizationalUnitsAsync(string instanceId, string applicationId, ListOrganizationalUnitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListOrganizationalUnitsHeaders headers = new ListOrganizationalUnitsHeaders();
            return await ListOrganizationalUnitsWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        public ListOrganizationalUnitsResponse ListOrganizationalUnitsWithOptions(string instanceId, string applicationId, ListOrganizationalUnitsRequest request, ListOrganizationalUnitsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["parentId"] = request.ParentId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrganizationalUnits",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/organizationalUnits",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrganizationalUnitsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListOrganizationalUnitsResponse> ListOrganizationalUnitsWithOptionsAsync(string instanceId, string applicationId, ListOrganizationalUnitsRequest request, ListOrganizationalUnitsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["parentId"] = request.ParentId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrganizationalUnits",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/organizationalUnits",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrganizationalUnitsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListUsersResponse ListUsers(string instanceId, string applicationId, ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUsersHeaders headers = new ListUsersHeaders();
            return ListUsersWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        public async Task<ListUsersResponse> ListUsersAsync(string instanceId, string applicationId, ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUsersHeaders headers = new ListUsersHeaders();
            return await ListUsersWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        public ListUsersResponse ListUsersWithOptions(string instanceId, string applicationId, ListUsersRequest request, ListUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitId))
            {
                query["organizationalUnitId"] = request.OrganizationalUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(string instanceId, string applicationId, ListUsersRequest request, ListUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitId))
            {
                query["organizationalUnitId"] = request.OrganizationalUnitId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PatchOrganizationalUnitResponse PatchOrganizationalUnit(string instanceId, string applicationId, string organizationalUnitId, PatchOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PatchOrganizationalUnitHeaders headers = new PatchOrganizationalUnitHeaders();
            return PatchOrganizationalUnitWithOptions(instanceId, applicationId, organizationalUnitId, request, headers, runtime);
        }

        public async Task<PatchOrganizationalUnitResponse> PatchOrganizationalUnitAsync(string instanceId, string applicationId, string organizationalUnitId, PatchOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PatchOrganizationalUnitHeaders headers = new PatchOrganizationalUnitHeaders();
            return await PatchOrganizationalUnitWithOptionsAsync(instanceId, applicationId, organizationalUnitId, request, headers, runtime);
        }

        public PatchOrganizationalUnitResponse PatchOrganizationalUnitWithOptions(string instanceId, string applicationId, string organizationalUnitId, PatchOrganizationalUnitRequest request, PatchOrganizationalUnitHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitName))
            {
                body["organizationalUnitName"] = request.OrganizationalUnitName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PatchOrganizationalUnit",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/organizationalUnits/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationalUnitId),
                Method = "PATCH",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PatchOrganizationalUnitResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PatchOrganizationalUnitResponse> PatchOrganizationalUnitWithOptionsAsync(string instanceId, string applicationId, string organizationalUnitId, PatchOrganizationalUnitRequest request, PatchOrganizationalUnitHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitName))
            {
                body["organizationalUnitName"] = request.OrganizationalUnitName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PatchOrganizationalUnit",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/organizationalUnits/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationalUnitId),
                Method = "PATCH",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PatchOrganizationalUnitResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PatchUserResponse PatchUser(string instanceId, string applicationId, string userId, PatchUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PatchUserHeaders headers = new PatchUserHeaders();
            return PatchUserWithOptions(instanceId, applicationId, userId, request, headers, runtime);
        }

        public async Task<PatchUserResponse> PatchUserAsync(string instanceId, string applicationId, string userId, PatchUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PatchUserHeaders headers = new PatchUserHeaders();
            return await PatchUserWithOptionsAsync(instanceId, applicationId, userId, request, headers, runtime);
        }

        public PatchUserResponse PatchUserWithOptions(string instanceId, string applicationId, string userId, PatchUserRequest request, PatchUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFields))
            {
                body["customFields"] = request.CustomFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailVerified))
            {
                body["emailVerified"] = request.EmailVerified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["phoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumberVerified))
            {
                body["phoneNumberVerified"] = request.PhoneNumberVerified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneRegion))
            {
                body["phoneRegion"] = request.PhoneRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["username"] = request.Username;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PatchUser",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId),
                Method = "PATCH",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PatchUserResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PatchUserResponse> PatchUserWithOptionsAsync(string instanceId, string applicationId, string userId, PatchUserRequest request, PatchUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFields))
            {
                body["customFields"] = request.CustomFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                body["email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmailVerified))
            {
                body["emailVerified"] = request.EmailVerified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                body["phoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumberVerified))
            {
                body["phoneNumberVerified"] = request.PhoneNumberVerified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneRegion))
            {
                body["phoneRegion"] = request.PhoneRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["username"] = request.Username;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PatchUser",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId),
                Method = "PATCH",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PatchUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RevokeTokenResponse RevokeToken(string instanceId, string applicationId, RevokeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RevokeTokenWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        public async Task<RevokeTokenResponse> RevokeTokenAsync(string instanceId, string applicationId, RevokeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RevokeTokenWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        public RevokeTokenResponse RevokeTokenWithOptions(string instanceId, string applicationId, RevokeTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["client_id"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSecret))
            {
                query["client_secret"] = request.ClientSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenTypeHint))
            {
                query["token_type_hint"] = request.TokenTypeHint;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeToken",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/oauth2/revoke",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeTokenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RevokeTokenResponse> RevokeTokenWithOptionsAsync(string instanceId, string applicationId, RevokeTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["client_id"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSecret))
            {
                query["client_secret"] = request.ClientSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenTypeHint))
            {
                query["token_type_hint"] = request.TokenTypeHint;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeToken",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/oauth2/revoke",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

    }
}
