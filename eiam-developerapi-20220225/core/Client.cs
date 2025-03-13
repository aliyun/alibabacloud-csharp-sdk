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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将账户加入多个组织</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUserToOrganizationalUnitsRequest
        /// </param>
        /// <param name="headers">
        /// AddUserToOrganizationalUnitsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddUserToOrganizationalUnitsResponse
        /// </returns>
        public AddUserToOrganizationalUnitsResponse AddUserToOrganizationalUnitsWithOptions(string instanceId, string applicationId, string userId, AddUserToOrganizationalUnitsRequest request, AddUserToOrganizationalUnitsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitIds))
            {
                body["organizationalUnitIds"] = request.OrganizationalUnitIds;
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
                Action = "AddUserToOrganizationalUnits",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId) + "/actions/addUserToOrganizationalUnits",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddUserToOrganizationalUnitsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddUserToOrganizationalUnitsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将账户加入多个组织</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUserToOrganizationalUnitsRequest
        /// </param>
        /// <param name="headers">
        /// AddUserToOrganizationalUnitsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddUserToOrganizationalUnitsResponse
        /// </returns>
        public async Task<AddUserToOrganizationalUnitsResponse> AddUserToOrganizationalUnitsWithOptionsAsync(string instanceId, string applicationId, string userId, AddUserToOrganizationalUnitsRequest request, AddUserToOrganizationalUnitsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitIds))
            {
                body["organizationalUnitIds"] = request.OrganizationalUnitIds;
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
                Action = "AddUserToOrganizationalUnits",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId) + "/actions/addUserToOrganizationalUnits",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddUserToOrganizationalUnitsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddUserToOrganizationalUnitsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将账户加入多个组织</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUserToOrganizationalUnitsRequest
        /// </param>
        /// 
        /// <returns>
        /// AddUserToOrganizationalUnitsResponse
        /// </returns>
        public AddUserToOrganizationalUnitsResponse AddUserToOrganizationalUnits(string instanceId, string applicationId, string userId, AddUserToOrganizationalUnitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddUserToOrganizationalUnitsHeaders headers = new AddUserToOrganizationalUnitsHeaders();
            return AddUserToOrganizationalUnitsWithOptions(instanceId, applicationId, userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将账户加入多个组织</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUserToOrganizationalUnitsRequest
        /// </param>
        /// 
        /// <returns>
        /// AddUserToOrganizationalUnitsResponse
        /// </returns>
        public async Task<AddUserToOrganizationalUnitsResponse> AddUserToOrganizationalUnitsAsync(string instanceId, string applicationId, string userId, AddUserToOrganizationalUnitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddUserToOrganizationalUnitsHeaders headers = new AddUserToOrganizationalUnitsHeaders();
            return await AddUserToOrganizationalUnitsWithOptionsAsync(instanceId, applicationId, userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为指定组批量关联账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUsersToGroupRequest
        /// </param>
        /// <param name="headers">
        /// AddUsersToGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddUsersToGroupResponse
        /// </returns>
        public AddUsersToGroupResponse AddUsersToGroupWithOptions(string instanceId, string applicationId, string groupId, AddUsersToGroupRequest request, AddUsersToGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "AddUsersToGroup",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/actions/addUsersToGroup",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddUsersToGroupResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddUsersToGroupResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为指定组批量关联账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUsersToGroupRequest
        /// </param>
        /// <param name="headers">
        /// AddUsersToGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddUsersToGroupResponse
        /// </returns>
        public async Task<AddUsersToGroupResponse> AddUsersToGroupWithOptionsAsync(string instanceId, string applicationId, string groupId, AddUsersToGroupRequest request, AddUsersToGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "AddUsersToGroup",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/actions/addUsersToGroup",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddUsersToGroupResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddUsersToGroupResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为指定组批量关联账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUsersToGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AddUsersToGroupResponse
        /// </returns>
        public AddUsersToGroupResponse AddUsersToGroup(string instanceId, string applicationId, string groupId, AddUsersToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddUsersToGroupHeaders headers = new AddUsersToGroupHeaders();
            return AddUsersToGroupWithOptions(instanceId, applicationId, groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为指定组批量关联账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUsersToGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AddUsersToGroupResponse
        /// </returns>
        public async Task<AddUsersToGroupResponse> AddUsersToGroupAsync(string instanceId, string applicationId, string groupId, AddUsersToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddUsersToGroupHeaders headers = new AddUsersToGroupHeaders();
            return await AddUsersToGroupWithOptionsAsync(instanceId, applicationId, groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个EIAM组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupRequest
        /// </param>
        /// <param name="headers">
        /// CreateGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupResponse
        /// </returns>
        public CreateGroupResponse CreateGroupWithOptions(string instanceId, string applicationId, CreateGroupRequest request, CreateGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupExternalId))
            {
                body["groupExternalId"] = request.GroupExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
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
                Action = "CreateGroup",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/groups",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateGroupResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateGroupResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个EIAM组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupRequest
        /// </param>
        /// <param name="headers">
        /// CreateGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupResponse
        /// </returns>
        public async Task<CreateGroupResponse> CreateGroupWithOptionsAsync(string instanceId, string applicationId, CreateGroupRequest request, CreateGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupExternalId))
            {
                body["groupExternalId"] = request.GroupExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
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
                Action = "CreateGroup",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/groups",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateGroupResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateGroupResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个EIAM组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupResponse
        /// </returns>
        public CreateGroupResponse CreateGroup(string instanceId, string applicationId, CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupHeaders headers = new CreateGroupHeaders();
            return CreateGroupWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个EIAM组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupResponse
        /// </returns>
        public async Task<CreateGroupResponse> CreateGroupAsync(string instanceId, string applicationId, CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupHeaders headers = new CreateGroupHeaders();
            return await CreateGroupWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an organizational unit.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOrganizationalUnitRequest
        /// </param>
        /// <param name="headers">
        /// CreateOrganizationalUnitHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOrganizationalUnitResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateOrganizationalUnitResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateOrganizationalUnitResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an organizational unit.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOrganizationalUnitRequest
        /// </param>
        /// <param name="headers">
        /// CreateOrganizationalUnitHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOrganizationalUnitResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateOrganizationalUnitResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateOrganizationalUnitResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an organizational unit.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOrganizationalUnitRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOrganizationalUnitResponse
        /// </returns>
        public CreateOrganizationalUnitResponse CreateOrganizationalUnit(string instanceId, string applicationId, CreateOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateOrganizationalUnitHeaders headers = new CreateOrganizationalUnitHeaders();
            return CreateOrganizationalUnitWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an organizational unit.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOrganizationalUnitRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOrganizationalUnitResponse
        /// </returns>
        public async Task<CreateOrganizationalUnitResponse> CreateOrganizationalUnitAsync(string instanceId, string applicationId, CreateOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateOrganizationalUnitHeaders headers = new CreateOrganizationalUnitHeaders();
            return await CreateOrganizationalUnitWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Employee Identity and Access Management (EIAM) account in an organizational unit.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserRequest
        /// </param>
        /// <param name="headers">
        /// CreateUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateUserResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateUserResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Employee Identity and Access Management (EIAM) account in an organizational unit.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserRequest
        /// </param>
        /// <param name="headers">
        /// CreateUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateUserResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateUserResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Employee Identity and Access Management (EIAM) account in an organizational unit.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
        public CreateUserResponse CreateUser(string instanceId, string applicationId, CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateUserHeaders headers = new CreateUserHeaders();
            return CreateUserWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Employee Identity and Access Management (EIAM) account in an organizational unit.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
        public async Task<CreateUserResponse> CreateUserAsync(string instanceId, string applicationId, CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateUserHeaders headers = new CreateUserHeaders();
            return await CreateUserWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定组</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGroupResponse
        /// </returns>
        public DeleteGroupResponse DeleteGroupWithOptions(string instanceId, string applicationId, string groupId, DeleteGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteGroup",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "DELETE",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteGroupResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteGroupResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定组</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGroupResponse
        /// </returns>
        public async Task<DeleteGroupResponse> DeleteGroupWithOptionsAsync(string instanceId, string applicationId, string groupId, DeleteGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteGroup",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "DELETE",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteGroupResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteGroupResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定组</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteGroupResponse
        /// </returns>
        public DeleteGroupResponse DeleteGroup(string instanceId, string applicationId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteGroupHeaders headers = new DeleteGroupHeaders();
            return DeleteGroupWithOptions(instanceId, applicationId, groupId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定组</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteGroupResponse
        /// </returns>
        public async Task<DeleteGroupResponse> DeleteGroupAsync(string instanceId, string applicationId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteGroupHeaders headers = new DeleteGroupHeaders();
            return await DeleteGroupWithOptionsAsync(instanceId, applicationId, groupId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an organizational unit.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteOrganizationalUnitHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOrganizationalUnitResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteOrganizationalUnitResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteOrganizationalUnitResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an organizational unit.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteOrganizationalUnitHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOrganizationalUnitResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteOrganizationalUnitResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteOrganizationalUnitResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an organizational unit.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteOrganizationalUnitResponse
        /// </returns>
        public DeleteOrganizationalUnitResponse DeleteOrganizationalUnit(string instanceId, string applicationId, string organizationalUnitId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteOrganizationalUnitHeaders headers = new DeleteOrganizationalUnitHeaders();
            return DeleteOrganizationalUnitWithOptions(instanceId, applicationId, organizationalUnitId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an organizational unit.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteOrganizationalUnitResponse
        /// </returns>
        public async Task<DeleteOrganizationalUnitResponse> DeleteOrganizationalUnitAsync(string instanceId, string applicationId, string organizationalUnitId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteOrganizationalUnitHeaders headers = new DeleteOrganizationalUnitHeaders();
            return await DeleteOrganizationalUnitWithOptionsAsync(instanceId, applicationId, organizationalUnitId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an Employee Identity and Access Management (EIAM) account.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteUserResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteUserResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an Employee Identity and Access Management (EIAM) account.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DeleteUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteUserResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteUserResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an Employee Identity and Access Management (EIAM) account.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteUserResponse
        /// </returns>
        public DeleteUserResponse DeleteUser(string instanceId, string applicationId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteUserHeaders headers = new DeleteUserHeaders();
            return DeleteUserWithOptions(instanceId, applicationId, userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an Employee Identity and Access Management (EIAM) account.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteUserResponse
        /// </returns>
        public async Task<DeleteUserResponse> DeleteUserAsync(string instanceId, string applicationId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteUserHeaders headers = new DeleteUserHeaders();
            return await DeleteUserWithOptionsAsync(instanceId, applicationId, userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables an Employee Identity and Access Management (EIAM) account.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DisableUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableUserResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DisableUserResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DisableUserResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables an Employee Identity and Access Management (EIAM) account.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// DisableUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableUserResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DisableUserResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DisableUserResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables an Employee Identity and Access Management (EIAM) account.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DisableUserResponse
        /// </returns>
        public DisableUserResponse DisableUser(string instanceId, string applicationId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DisableUserHeaders headers = new DisableUserHeaders();
            return DisableUserWithOptions(instanceId, applicationId, userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables an Employee Identity and Access Management (EIAM) account.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DisableUserResponse
        /// </returns>
        public async Task<DisableUserResponse> DisableUserAsync(string instanceId, string applicationId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DisableUserHeaders headers = new DisableUserHeaders();
            return await DisableUserWithOptionsAsync(instanceId, applicationId, userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an Employee Identity and Access Management (EIAM) account.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// EnableUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableUserResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<EnableUserResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EnableUserResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an Employee Identity and Access Management (EIAM) account.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// EnableUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableUserResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<EnableUserResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EnableUserResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an Employee Identity and Access Management (EIAM) account.</para>
        /// </summary>
        /// 
        /// <returns>
        /// EnableUserResponse
        /// </returns>
        public EnableUserResponse EnableUser(string instanceId, string applicationId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EnableUserHeaders headers = new EnableUserHeaders();
            return EnableUserWithOptions(instanceId, applicationId, userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an Employee Identity and Access Management (EIAM) account.</para>
        /// </summary>
        /// 
        /// <returns>
        /// EnableUserResponse
        /// </returns>
        public async Task<EnableUserResponse> EnableUserAsync(string instanceId, string applicationId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EnableUserHeaders headers = new EnableUserHeaders();
            return await EnableUserWithOptionsAsync(instanceId, applicationId, userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a device code.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateDeviceCodeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateDeviceCodeResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GenerateDeviceCodeResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GenerateDeviceCodeResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a device code.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateDeviceCodeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateDeviceCodeResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GenerateDeviceCodeResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GenerateDeviceCodeResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a device code.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateDeviceCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateDeviceCodeResponse
        /// </returns>
        public GenerateDeviceCodeResponse GenerateDeviceCode(string instanceId, string applicationId, GenerateDeviceCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateDeviceCodeWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a device code.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateDeviceCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateDeviceCodeResponse
        /// </returns>
        public async Task<GenerateDeviceCodeResponse> GenerateDeviceCodeAsync(string instanceId, string applicationId, GenerateDeviceCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateDeviceCodeWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a token for accessing an application in an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The following authorization types are supported: authorization code, device code, refresh token, and client credentials.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateTokenResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GenerateTokenResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GenerateTokenResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a token for accessing an application in an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The following authorization types are supported: authorization code, device code, refresh token, and client credentials.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateTokenResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GenerateTokenResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GenerateTokenResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a token for accessing an application in an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The following authorization types are supported: authorization code, device code, refresh token, and client credentials.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateTokenResponse
        /// </returns>
        public GenerateTokenResponse GenerateToken(string instanceId, string applicationId, GenerateTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateTokenWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a token for accessing an application in an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The following authorization types are supported: authorization code, device code, refresh token, and client credentials.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateTokenResponse
        /// </returns>
        public async Task<GenerateTokenResponse> GenerateTokenAsync(string instanceId, string applicationId, GenerateTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateTokenWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the synchronization scope of an application in an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can go to the Applications page in the IDaaS console to set the synchronization scope. After an application is created, the application has the permission to call this operation by default.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="headers">
        /// GetApplicationProvisioningScopeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationProvisioningScopeResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetApplicationProvisioningScopeResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetApplicationProvisioningScopeResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the synchronization scope of an application in an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can go to the Applications page in the IDaaS console to set the synchronization scope. After an application is created, the application has the permission to call this operation by default.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="headers">
        /// GetApplicationProvisioningScopeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationProvisioningScopeResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetApplicationProvisioningScopeResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetApplicationProvisioningScopeResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the synchronization scope of an application in an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can go to the Applications page in the IDaaS console to set the synchronization scope. After an application is created, the application has the permission to call this operation by default.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <returns>
        /// GetApplicationProvisioningScopeResponse
        /// </returns>
        public GetApplicationProvisioningScopeResponse GetApplicationProvisioningScope(string instanceId, string applicationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetApplicationProvisioningScopeHeaders headers = new GetApplicationProvisioningScopeHeaders();
            return GetApplicationProvisioningScopeWithOptions(instanceId, applicationId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the synchronization scope of an application in an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can go to the Applications page in the IDaaS console to set the synchronization scope. After an application is created, the application has the permission to call this operation by default.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <returns>
        /// GetApplicationProvisioningScopeResponse
        /// </returns>
        public async Task<GetApplicationProvisioningScopeResponse> GetApplicationProvisioningScopeAsync(string instanceId, string applicationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetApplicationProvisioningScopeHeaders headers = new GetApplicationProvisioningScopeHeaders();
            return await GetApplicationProvisioningScopeWithOptionsAsync(instanceId, applicationId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一个EIAM组信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGroupResponse
        /// </returns>
        public GetGroupResponse GetGroupWithOptions(string instanceId, string applicationId, string groupId, GetGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetGroup",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetGroupResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetGroupResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一个EIAM组信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGroupResponse
        /// </returns>
        public async Task<GetGroupResponse> GetGroupWithOptionsAsync(string instanceId, string applicationId, string groupId, GetGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetGroup",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetGroupResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetGroupResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一个EIAM组信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetGroupResponse
        /// </returns>
        public GetGroupResponse GetGroup(string instanceId, string applicationId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGroupHeaders headers = new GetGroupHeaders();
            return GetGroupWithOptions(instanceId, applicationId, groupId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询一个EIAM组信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetGroupResponse
        /// </returns>
        public async Task<GetGroupResponse> GetGroupAsync(string instanceId, string applicationId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetGroupHeaders headers = new GetGroupHeaders();
            return await GetGroupWithOptionsAsync(instanceId, applicationId, groupId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of an organizational unit.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetOrganizationalUnitHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrganizationalUnitResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetOrganizationalUnitResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetOrganizationalUnitResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of an organizational unit.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetOrganizationalUnitHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrganizationalUnitResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetOrganizationalUnitResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetOrganizationalUnitResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of an organizational unit.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetOrganizationalUnitResponse
        /// </returns>
        public GetOrganizationalUnitResponse GetOrganizationalUnit(string instanceId, string applicationId, string organizationalUnitId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizationalUnitHeaders headers = new GetOrganizationalUnitHeaders();
            return GetOrganizationalUnitWithOptions(instanceId, applicationId, organizationalUnitId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of an organizational unit.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetOrganizationalUnitResponse
        /// </returns>
        public async Task<GetOrganizationalUnitResponse> GetOrganizationalUnitAsync(string instanceId, string applicationId, string organizationalUnitId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizationalUnitHeaders headers = new GetOrganizationalUnitHeaders();
            return await GetOrganizationalUnitWithOptionsAsync(instanceId, applicationId, organizationalUnitId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the ID of an organizational unit based on the external ID</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrganizationalUnitIdByExternalIdRequest
        /// </param>
        /// <param name="headers">
        /// GetOrganizationalUnitIdByExternalIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrganizationalUnitIdByExternalIdResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetOrganizationalUnitIdByExternalIdResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetOrganizationalUnitIdByExternalIdResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the ID of an organizational unit based on the external ID</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrganizationalUnitIdByExternalIdRequest
        /// </param>
        /// <param name="headers">
        /// GetOrganizationalUnitIdByExternalIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOrganizationalUnitIdByExternalIdResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetOrganizationalUnitIdByExternalIdResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetOrganizationalUnitIdByExternalIdResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the ID of an organizational unit based on the external ID</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrganizationalUnitIdByExternalIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOrganizationalUnitIdByExternalIdResponse
        /// </returns>
        public GetOrganizationalUnitIdByExternalIdResponse GetOrganizationalUnitIdByExternalId(string instanceId, string applicationId, GetOrganizationalUnitIdByExternalIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizationalUnitIdByExternalIdHeaders headers = new GetOrganizationalUnitIdByExternalIdHeaders();
            return GetOrganizationalUnitIdByExternalIdWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the ID of an organizational unit based on the external ID</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetOrganizationalUnitIdByExternalIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOrganizationalUnitIdByExternalIdResponse
        /// </returns>
        public async Task<GetOrganizationalUnitIdByExternalIdResponse> GetOrganizationalUnitIdByExternalIdAsync(string instanceId, string applicationId, GetOrganizationalUnitIdByExternalIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizationalUnitIdByExternalIdHeaders headers = new GetOrganizationalUnitIdByExternalIdHeaders();
            return await GetOrganizationalUnitIdByExternalIdWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of an Employee Identity and Access Management (EIAM) account.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetUserResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetUserResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of an Employee Identity and Access Management (EIAM) account.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetUserResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetUserResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of an Employee Identity and Access Management (EIAM) account.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public GetUserResponse GetUser(string instanceId, string applicationId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHeaders headers = new GetUserHeaders();
            return GetUserWithOptions(instanceId, applicationId, userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of an Employee Identity and Access Management (EIAM) account.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public async Task<GetUserResponse> GetUserAsync(string instanceId, string applicationId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHeaders headers = new GetUserHeaders();
            return await GetUserWithOptionsAsync(instanceId, applicationId, userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ID of an Employee Identity and Access Management (EIAM) account by email address.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserIdByEmailRequest
        /// </param>
        /// <param name="headers">
        /// GetUserIdByEmailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserIdByEmailResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetUserIdByEmailResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetUserIdByEmailResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ID of an Employee Identity and Access Management (EIAM) account by email address.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserIdByEmailRequest
        /// </param>
        /// <param name="headers">
        /// GetUserIdByEmailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserIdByEmailResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetUserIdByEmailResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetUserIdByEmailResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ID of an Employee Identity and Access Management (EIAM) account by email address.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserIdByEmailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserIdByEmailResponse
        /// </returns>
        public GetUserIdByEmailResponse GetUserIdByEmail(string instanceId, string applicationId, GetUserIdByEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserIdByEmailHeaders headers = new GetUserIdByEmailHeaders();
            return GetUserIdByEmailWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ID of an Employee Identity and Access Management (EIAM) account by email address.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserIdByEmailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserIdByEmailResponse
        /// </returns>
        public async Task<GetUserIdByEmailResponse> GetUserIdByEmailAsync(string instanceId, string applicationId, GetUserIdByEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserIdByEmailHeaders headers = new GetUserIdByEmailHeaders();
            return await GetUserIdByEmailWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ID of an Employee Identity and Access Management (EIAM) account based on the mobile number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserIdByPhoneNumberRequest
        /// </param>
        /// <param name="headers">
        /// GetUserIdByPhoneNumberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserIdByPhoneNumberResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetUserIdByPhoneNumberResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetUserIdByPhoneNumberResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ID of an Employee Identity and Access Management (EIAM) account based on the mobile number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserIdByPhoneNumberRequest
        /// </param>
        /// <param name="headers">
        /// GetUserIdByPhoneNumberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserIdByPhoneNumberResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetUserIdByPhoneNumberResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetUserIdByPhoneNumberResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ID of an Employee Identity and Access Management (EIAM) account based on the mobile number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserIdByPhoneNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserIdByPhoneNumberResponse
        /// </returns>
        public GetUserIdByPhoneNumberResponse GetUserIdByPhoneNumber(string instanceId, string applicationId, GetUserIdByPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserIdByPhoneNumberHeaders headers = new GetUserIdByPhoneNumberHeaders();
            return GetUserIdByPhoneNumberWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ID of an Employee Identity and Access Management (EIAM) account based on the mobile number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserIdByPhoneNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserIdByPhoneNumberResponse
        /// </returns>
        public async Task<GetUserIdByPhoneNumberResponse> GetUserIdByPhoneNumberAsync(string instanceId, string applicationId, GetUserIdByPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserIdByPhoneNumberHeaders headers = new GetUserIdByPhoneNumberHeaders();
            return await GetUserIdByPhoneNumberWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ID of an Employee Identity and Access Management (EIAM) account based on the external ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserIdByUserExternalIdRequest
        /// </param>
        /// <param name="headers">
        /// GetUserIdByUserExternalIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserIdByUserExternalIdResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetUserIdByUserExternalIdResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetUserIdByUserExternalIdResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ID of an Employee Identity and Access Management (EIAM) account based on the external ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserIdByUserExternalIdRequest
        /// </param>
        /// <param name="headers">
        /// GetUserIdByUserExternalIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserIdByUserExternalIdResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetUserIdByUserExternalIdResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetUserIdByUserExternalIdResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ID of an Employee Identity and Access Management (EIAM) account based on the external ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserIdByUserExternalIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserIdByUserExternalIdResponse
        /// </returns>
        public GetUserIdByUserExternalIdResponse GetUserIdByUserExternalId(string instanceId, string applicationId, GetUserIdByUserExternalIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserIdByUserExternalIdHeaders headers = new GetUserIdByUserExternalIdHeaders();
            return GetUserIdByUserExternalIdWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ID of an Employee Identity and Access Management (EIAM) account based on the external ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserIdByUserExternalIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserIdByUserExternalIdResponse
        /// </returns>
        public async Task<GetUserIdByUserExternalIdResponse> GetUserIdByUserExternalIdAsync(string instanceId, string applicationId, GetUserIdByUserExternalIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserIdByUserExternalIdHeaders headers = new GetUserIdByUserExternalIdHeaders();
            return await GetUserIdByUserExternalIdWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ID of an Employee Identity and Access Management (EIAM) account based on the username.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserIdByUsernameRequest
        /// </param>
        /// <param name="headers">
        /// GetUserIdByUsernameHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserIdByUsernameResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetUserIdByUsernameResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetUserIdByUsernameResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ID of an Employee Identity and Access Management (EIAM) account based on the username.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserIdByUsernameRequest
        /// </param>
        /// <param name="headers">
        /// GetUserIdByUsernameHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserIdByUsernameResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetUserIdByUsernameResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetUserIdByUsernameResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ID of an Employee Identity and Access Management (EIAM) account based on the username.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserIdByUsernameRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserIdByUsernameResponse
        /// </returns>
        public GetUserIdByUsernameResponse GetUserIdByUsername(string instanceId, string applicationId, GetUserIdByUsernameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserIdByUsernameHeaders headers = new GetUserIdByUsernameHeaders();
            return GetUserIdByUsernameWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ID of an Employee Identity and Access Management (EIAM) account based on the username.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserIdByUsernameRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserIdByUsernameResponse
        /// </returns>
        public async Task<GetUserIdByUsernameResponse> GetUserIdByUsernameAsync(string instanceId, string applicationId, GetUserIdByUsernameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserIdByUsernameHeaders headers = new GetUserIdByUsernameHeaders();
            return await GetUserIdByUsernameWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of a user by using the user token.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetUserInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserInfoResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetUserInfoResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetUserInfoResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of a user by using the user token.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetUserInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserInfoResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetUserInfoResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetUserInfoResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of a user by using the user token.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetUserInfoResponse
        /// </returns>
        public GetUserInfoResponse GetUserInfo(string instanceId, string applicationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserInfoHeaders headers = new GetUserInfoHeaders();
            return GetUserInfoWithOptions(instanceId, applicationId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of a user by using the user token.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetUserInfoResponse
        /// </returns>
        public async Task<GetUserInfoResponse> GetUserInfoAsync(string instanceId, string applicationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserInfoHeaders headers = new GetUserInfoHeaders();
            return await GetUserInfoWithOptionsAsync(instanceId, applicationId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupsRequest
        /// </param>
        /// <param name="headers">
        /// ListGroupsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGroupsResponse
        /// </returns>
        public ListGroupsResponse ListGroupsWithOptions(string instanceId, string applicationId, ListGroupsRequest request, ListGroupsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupNameStartWith))
            {
                query["groupNameStartWith"] = request.GroupNameStartWith;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "ListGroups",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/groups",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListGroupsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListGroupsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupsRequest
        /// </param>
        /// <param name="headers">
        /// ListGroupsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGroupsResponse
        /// </returns>
        public async Task<ListGroupsResponse> ListGroupsWithOptionsAsync(string instanceId, string applicationId, ListGroupsRequest request, ListGroupsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupNameStartWith))
            {
                query["groupNameStartWith"] = request.GroupNameStartWith;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "ListGroups",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/groups",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListGroupsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListGroupsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGroupsResponse
        /// </returns>
        public ListGroupsResponse ListGroups(string instanceId, string applicationId, ListGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListGroupsHeaders headers = new ListGroupsHeaders();
            return ListGroupsWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGroupsResponse
        /// </returns>
        public async Task<ListGroupsResponse> ListGroupsAsync(string instanceId, string applicationId, ListGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListGroupsHeaders headers = new ListGroupsHeaders();
            return await ListGroupsWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取账户关联组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupsForUserRequest
        /// </param>
        /// <param name="headers">
        /// ListGroupsForUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGroupsForUserResponse
        /// </returns>
        public ListGroupsForUserResponse ListGroupsForUserWithOptions(string instanceId, string applicationId, string userId, ListGroupsForUserRequest request, ListGroupsForUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "ListGroupsForUser",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId) + "/actions/listGroupsForUser",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListGroupsForUserResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListGroupsForUserResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取账户关联组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupsForUserRequest
        /// </param>
        /// <param name="headers">
        /// ListGroupsForUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGroupsForUserResponse
        /// </returns>
        public async Task<ListGroupsForUserResponse> ListGroupsForUserWithOptionsAsync(string instanceId, string applicationId, string userId, ListGroupsForUserRequest request, ListGroupsForUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "ListGroupsForUser",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId) + "/actions/listGroupsForUser",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListGroupsForUserResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListGroupsForUserResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取账户关联组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupsForUserRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGroupsForUserResponse
        /// </returns>
        public ListGroupsForUserResponse ListGroupsForUser(string instanceId, string applicationId, string userId, ListGroupsForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListGroupsForUserHeaders headers = new ListGroupsForUserHeaders();
            return ListGroupsForUserWithOptions(instanceId, applicationId, userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取账户关联组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupsForUserRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGroupsForUserResponse
        /// </returns>
        public async Task<ListGroupsForUserResponse> ListGroupsForUserAsync(string instanceId, string applicationId, string userId, ListGroupsForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListGroupsForUserHeaders headers = new ListGroupsForUserHeaders();
            return await ListGroupsForUserWithOptionsAsync(instanceId, applicationId, userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of all the parent organizational units of an organizational unit.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListOrganizationalUnitParentIdsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOrganizationalUnitParentIdsResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListOrganizationalUnitParentIdsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListOrganizationalUnitParentIdsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of all the parent organizational units of an organizational unit.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListOrganizationalUnitParentIdsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOrganizationalUnitParentIdsResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListOrganizationalUnitParentIdsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListOrganizationalUnitParentIdsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of all the parent organizational units of an organizational unit.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListOrganizationalUnitParentIdsResponse
        /// </returns>
        public ListOrganizationalUnitParentIdsResponse ListOrganizationalUnitParentIds(string instanceId, string applicationId, string organizationalUnitId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListOrganizationalUnitParentIdsHeaders headers = new ListOrganizationalUnitParentIdsHeaders();
            return ListOrganizationalUnitParentIdsWithOptions(instanceId, applicationId, organizationalUnitId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of all the parent organizational units of an organizational unit.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListOrganizationalUnitParentIdsResponse
        /// </returns>
        public async Task<ListOrganizationalUnitParentIdsResponse> ListOrganizationalUnitParentIdsAsync(string instanceId, string applicationId, string organizationalUnitId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListOrganizationalUnitParentIdsHeaders headers = new ListOrganizationalUnitParentIdsHeaders();
            return await ListOrganizationalUnitParentIdsWithOptionsAsync(instanceId, applicationId, organizationalUnitId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of Employee Identity and Access Management (EIAM) organizational units by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOrganizationalUnitsRequest
        /// </param>
        /// <param name="headers">
        /// ListOrganizationalUnitsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOrganizationalUnitsResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListOrganizationalUnitsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListOrganizationalUnitsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of Employee Identity and Access Management (EIAM) organizational units by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOrganizationalUnitsRequest
        /// </param>
        /// <param name="headers">
        /// ListOrganizationalUnitsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOrganizationalUnitsResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListOrganizationalUnitsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListOrganizationalUnitsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of Employee Identity and Access Management (EIAM) organizational units by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOrganizationalUnitsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOrganizationalUnitsResponse
        /// </returns>
        public ListOrganizationalUnitsResponse ListOrganizationalUnits(string instanceId, string applicationId, ListOrganizationalUnitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListOrganizationalUnitsHeaders headers = new ListOrganizationalUnitsHeaders();
            return ListOrganizationalUnitsWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of Employee Identity and Access Management (EIAM) organizational units by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOrganizationalUnitsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOrganizationalUnitsResponse
        /// </returns>
        public async Task<ListOrganizationalUnitsResponse> ListOrganizationalUnitsAsync(string instanceId, string applicationId, ListOrganizationalUnitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListOrganizationalUnitsHeaders headers = new ListOrganizationalUnitsHeaders();
            return await ListOrganizationalUnitsWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of Employee Identity and Access Management (EIAM) accounts by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// <param name="headers">
        /// ListUsersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListUsersResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListUsersResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of Employee Identity and Access Management (EIAM) accounts by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// <param name="headers">
        /// ListUsersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListUsersResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListUsersResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of Employee Identity and Access Management (EIAM) accounts by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public ListUsersResponse ListUsers(string instanceId, string applicationId, ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUsersHeaders headers = new ListUsersHeaders();
            return ListUsersWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of Employee Identity and Access Management (EIAM) accounts by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public async Task<ListUsersResponse> ListUsersAsync(string instanceId, string applicationId, ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUsersHeaders headers = new ListUsersHeaders();
            return await ListUsersWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定组下账户IDS</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersForGroupRequest
        /// </param>
        /// <param name="headers">
        /// ListUsersForGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersForGroupResponse
        /// </returns>
        public ListUsersForGroupResponse ListUsersForGroupWithOptions(string instanceId, string applicationId, string groupId, ListUsersForGroupRequest request, ListUsersForGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "ListUsersForGroup",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/actions/listUsersForGroup",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListUsersForGroupResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListUsersForGroupResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定组下账户IDS</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersForGroupRequest
        /// </param>
        /// <param name="headers">
        /// ListUsersForGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersForGroupResponse
        /// </returns>
        public async Task<ListUsersForGroupResponse> ListUsersForGroupWithOptionsAsync(string instanceId, string applicationId, string groupId, ListUsersForGroupRequest request, ListUsersForGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "ListUsersForGroup",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/actions/listUsersForGroup",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListUsersForGroupResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListUsersForGroupResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定组下账户IDS</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersForGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersForGroupResponse
        /// </returns>
        public ListUsersForGroupResponse ListUsersForGroup(string instanceId, string applicationId, string groupId, ListUsersForGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUsersForGroupHeaders headers = new ListUsersForGroupHeaders();
            return ListUsersForGroupWithOptions(instanceId, applicationId, groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定组下账户IDS</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersForGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersForGroupResponse
        /// </returns>
        public async Task<ListUsersForGroupResponse> ListUsersForGroupAsync(string instanceId, string applicationId, string groupId, ListUsersForGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListUsersForGroupHeaders headers = new ListUsersForGroupHeaders();
            return await ListUsersForGroupWithOptionsAsync(instanceId, applicationId, groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新组信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PatchGroupRequest
        /// </param>
        /// <param name="headers">
        /// PatchGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PatchGroupResponse
        /// </returns>
        public PatchGroupResponse PatchGroupWithOptions(string instanceId, string applicationId, string groupId, PatchGroupRequest request, PatchGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
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
                Action = "PatchGroup",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "PATCH",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PatchGroupResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PatchGroupResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新组信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PatchGroupRequest
        /// </param>
        /// <param name="headers">
        /// PatchGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PatchGroupResponse
        /// </returns>
        public async Task<PatchGroupResponse> PatchGroupWithOptionsAsync(string instanceId, string applicationId, string groupId, PatchGroupRequest request, PatchGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
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
                Action = "PatchGroup",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "PATCH",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PatchGroupResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PatchGroupResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新组信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PatchGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// PatchGroupResponse
        /// </returns>
        public PatchGroupResponse PatchGroup(string instanceId, string applicationId, string groupId, PatchGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PatchGroupHeaders headers = new PatchGroupHeaders();
            return PatchGroupWithOptions(instanceId, applicationId, groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新组信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PatchGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// PatchGroupResponse
        /// </returns>
        public async Task<PatchGroupResponse> PatchGroupAsync(string instanceId, string applicationId, string groupId, PatchGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PatchGroupHeaders headers = new PatchGroupHeaders();
            return await PatchGroupWithOptionsAsync(instanceId, applicationId, groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an EIAM organizational unit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The operation conforms to the HTTP PATCH request method. The value of a parameter is modified only if the parameter is specified in the request.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PatchOrganizationalUnitRequest
        /// </param>
        /// <param name="headers">
        /// PatchOrganizationalUnitHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PatchOrganizationalUnitResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PatchOrganizationalUnitResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PatchOrganizationalUnitResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an EIAM organizational unit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The operation conforms to the HTTP PATCH request method. The value of a parameter is modified only if the parameter is specified in the request.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PatchOrganizationalUnitRequest
        /// </param>
        /// <param name="headers">
        /// PatchOrganizationalUnitHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PatchOrganizationalUnitResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PatchOrganizationalUnitResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PatchOrganizationalUnitResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an EIAM organizational unit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The operation conforms to the HTTP PATCH request method. The value of a parameter is modified only if the parameter is specified in the request.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PatchOrganizationalUnitRequest
        /// </param>
        /// 
        /// <returns>
        /// PatchOrganizationalUnitResponse
        /// </returns>
        public PatchOrganizationalUnitResponse PatchOrganizationalUnit(string instanceId, string applicationId, string organizationalUnitId, PatchOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PatchOrganizationalUnitHeaders headers = new PatchOrganizationalUnitHeaders();
            return PatchOrganizationalUnitWithOptions(instanceId, applicationId, organizationalUnitId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an EIAM organizational unit.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The operation conforms to the HTTP PATCH request method. The value of a parameter is modified only if the parameter is specified in the request.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PatchOrganizationalUnitRequest
        /// </param>
        /// 
        /// <returns>
        /// PatchOrganizationalUnitResponse
        /// </returns>
        public async Task<PatchOrganizationalUnitResponse> PatchOrganizationalUnitAsync(string instanceId, string applicationId, string organizationalUnitId, PatchOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PatchOrganizationalUnitHeaders headers = new PatchOrganizationalUnitHeaders();
            return await PatchOrganizationalUnitWithOptionsAsync(instanceId, applicationId, organizationalUnitId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an Employee Identity and Access Management (EIAM) account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The operation conforms to the HTTP PATCH request method. The value of a parameter is modified only if the parameter is specified in the request.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PatchUserRequest
        /// </param>
        /// <param name="headers">
        /// PatchUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PatchUserResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PatchUserResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PatchUserResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an Employee Identity and Access Management (EIAM) account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The operation conforms to the HTTP PATCH request method. The value of a parameter is modified only if the parameter is specified in the request.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PatchUserRequest
        /// </param>
        /// <param name="headers">
        /// PatchUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PatchUserResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PatchUserResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PatchUserResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an Employee Identity and Access Management (EIAM) account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The operation conforms to the HTTP PATCH request method. The value of a parameter is modified only if the parameter is specified in the request.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PatchUserRequest
        /// </param>
        /// 
        /// <returns>
        /// PatchUserResponse
        /// </returns>
        public PatchUserResponse PatchUser(string instanceId, string applicationId, string userId, PatchUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PatchUserHeaders headers = new PatchUserHeaders();
            return PatchUserWithOptions(instanceId, applicationId, userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an Employee Identity and Access Management (EIAM) account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The operation conforms to the HTTP PATCH request method. The value of a parameter is modified only if the parameter is specified in the request.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PatchUserRequest
        /// </param>
        /// 
        /// <returns>
        /// PatchUserResponse
        /// </returns>
        public async Task<PatchUserResponse> PatchUserAsync(string instanceId, string applicationId, string userId, PatchUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PatchUserHeaders headers = new PatchUserHeaders();
            return await PatchUserWithOptionsAsync(instanceId, applicationId, userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将账户从多个组织移除【不支持移除主组织】</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveUserFromOrganizationalUnitsRequest
        /// </param>
        /// <param name="headers">
        /// RemoveUserFromOrganizationalUnitsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserFromOrganizationalUnitsResponse
        /// </returns>
        public RemoveUserFromOrganizationalUnitsResponse RemoveUserFromOrganizationalUnitsWithOptions(string instanceId, string applicationId, string userId, RemoveUserFromOrganizationalUnitsRequest request, RemoveUserFromOrganizationalUnitsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitIds))
            {
                body["organizationalUnitIds"] = request.OrganizationalUnitIds;
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
                Action = "RemoveUserFromOrganizationalUnits",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId) + "/actions/removeUserFromOrganizationalUnits",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RemoveUserFromOrganizationalUnitsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RemoveUserFromOrganizationalUnitsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将账户从多个组织移除【不支持移除主组织】</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveUserFromOrganizationalUnitsRequest
        /// </param>
        /// <param name="headers">
        /// RemoveUserFromOrganizationalUnitsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserFromOrganizationalUnitsResponse
        /// </returns>
        public async Task<RemoveUserFromOrganizationalUnitsResponse> RemoveUserFromOrganizationalUnitsWithOptionsAsync(string instanceId, string applicationId, string userId, RemoveUserFromOrganizationalUnitsRequest request, RemoveUserFromOrganizationalUnitsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitIds))
            {
                body["organizationalUnitIds"] = request.OrganizationalUnitIds;
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
                Action = "RemoveUserFromOrganizationalUnits",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId) + "/actions/removeUserFromOrganizationalUnits",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RemoveUserFromOrganizationalUnitsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RemoveUserFromOrganizationalUnitsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将账户从多个组织移除【不支持移除主组织】</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveUserFromOrganizationalUnitsRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserFromOrganizationalUnitsResponse
        /// </returns>
        public RemoveUserFromOrganizationalUnitsResponse RemoveUserFromOrganizationalUnits(string instanceId, string applicationId, string userId, RemoveUserFromOrganizationalUnitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveUserFromOrganizationalUnitsHeaders headers = new RemoveUserFromOrganizationalUnitsHeaders();
            return RemoveUserFromOrganizationalUnitsWithOptions(instanceId, applicationId, userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将账户从多个组织移除【不支持移除主组织】</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveUserFromOrganizationalUnitsRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserFromOrganizationalUnitsResponse
        /// </returns>
        public async Task<RemoveUserFromOrganizationalUnitsResponse> RemoveUserFromOrganizationalUnitsAsync(string instanceId, string applicationId, string userId, RemoveUserFromOrganizationalUnitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveUserFromOrganizationalUnitsHeaders headers = new RemoveUserFromOrganizationalUnitsHeaders();
            return await RemoveUserFromOrganizationalUnitsWithOptionsAsync(instanceId, applicationId, userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为指定组批量解除账户关联</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveUsersFromGroupRequest
        /// </param>
        /// <param name="headers">
        /// RemoveUsersFromGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveUsersFromGroupResponse
        /// </returns>
        public RemoveUsersFromGroupResponse RemoveUsersFromGroupWithOptions(string instanceId, string applicationId, string groupId, RemoveUsersFromGroupRequest request, RemoveUsersFromGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "RemoveUsersFromGroup",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/actions/removeUsersFromGroup",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RemoveUsersFromGroupResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RemoveUsersFromGroupResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为指定组批量解除账户关联</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveUsersFromGroupRequest
        /// </param>
        /// <param name="headers">
        /// RemoveUsersFromGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveUsersFromGroupResponse
        /// </returns>
        public async Task<RemoveUsersFromGroupResponse> RemoveUsersFromGroupWithOptionsAsync(string instanceId, string applicationId, string groupId, RemoveUsersFromGroupRequest request, RemoveUsersFromGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "RemoveUsersFromGroup",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/actions/removeUsersFromGroup",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RemoveUsersFromGroupResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RemoveUsersFromGroupResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为指定组批量解除账户关联</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveUsersFromGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveUsersFromGroupResponse
        /// </returns>
        public RemoveUsersFromGroupResponse RemoveUsersFromGroup(string instanceId, string applicationId, string groupId, RemoveUsersFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveUsersFromGroupHeaders headers = new RemoveUsersFromGroupHeaders();
            return RemoveUsersFromGroupWithOptions(instanceId, applicationId, groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为指定组批量解除账户关联</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveUsersFromGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveUsersFromGroupResponse
        /// </returns>
        public async Task<RemoveUsersFromGroupResponse> RemoveUsersFromGroupAsync(string instanceId, string applicationId, string groupId, RemoveUsersFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveUsersFromGroupHeaders headers = new RemoveUsersFromGroupHeaders();
            return await RemoveUsersFromGroupWithOptionsAsync(instanceId, applicationId, groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes an access token or refresh token.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevokeTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokeTokenResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RevokeTokenResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RevokeTokenResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes an access token or refresh token.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevokeTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokeTokenResponse
        /// </returns>
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
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RevokeTokenResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RevokeTokenResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes an access token or refresh token.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevokeTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// RevokeTokenResponse
        /// </returns>
        public RevokeTokenResponse RevokeToken(string instanceId, string applicationId, RevokeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RevokeTokenWithOptions(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes an access token or refresh token.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevokeTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// RevokeTokenResponse
        /// </returns>
        public async Task<RevokeTokenResponse> RevokeTokenAsync(string instanceId, string applicationId, RevokeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RevokeTokenWithOptionsAsync(instanceId, applicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将指定组织设置为账户主组织，移除旧主组织，加入新主组织。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetUserPrimaryOrganizationalUnitRequest
        /// </param>
        /// <param name="headers">
        /// SetUserPrimaryOrganizationalUnitHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetUserPrimaryOrganizationalUnitResponse
        /// </returns>
        public SetUserPrimaryOrganizationalUnitResponse SetUserPrimaryOrganizationalUnitWithOptions(string instanceId, string applicationId, string userId, SetUserPrimaryOrganizationalUnitRequest request, SetUserPrimaryOrganizationalUnitHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitId))
            {
                body["organizationalUnitId"] = request.OrganizationalUnitId;
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
                Action = "SetUserPrimaryOrganizationalUnit",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId) + "/actions/setUserPrimaryOrganizationalUnit",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<SetUserPrimaryOrganizationalUnitResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SetUserPrimaryOrganizationalUnitResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将指定组织设置为账户主组织，移除旧主组织，加入新主组织。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetUserPrimaryOrganizationalUnitRequest
        /// </param>
        /// <param name="headers">
        /// SetUserPrimaryOrganizationalUnitHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetUserPrimaryOrganizationalUnitResponse
        /// </returns>
        public async Task<SetUserPrimaryOrganizationalUnitResponse> SetUserPrimaryOrganizationalUnitWithOptionsAsync(string instanceId, string applicationId, string userId, SetUserPrimaryOrganizationalUnitRequest request, SetUserPrimaryOrganizationalUnitHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationalUnitId))
            {
                body["organizationalUnitId"] = request.OrganizationalUnitId;
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
                Action = "SetUserPrimaryOrganizationalUnit",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId) + "/actions/setUserPrimaryOrganizationalUnit",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<SetUserPrimaryOrganizationalUnitResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SetUserPrimaryOrganizationalUnitResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将指定组织设置为账户主组织，移除旧主组织，加入新主组织。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetUserPrimaryOrganizationalUnitRequest
        /// </param>
        /// 
        /// <returns>
        /// SetUserPrimaryOrganizationalUnitResponse
        /// </returns>
        public SetUserPrimaryOrganizationalUnitResponse SetUserPrimaryOrganizationalUnit(string instanceId, string applicationId, string userId, SetUserPrimaryOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetUserPrimaryOrganizationalUnitHeaders headers = new SetUserPrimaryOrganizationalUnitHeaders();
            return SetUserPrimaryOrganizationalUnitWithOptions(instanceId, applicationId, userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将指定组织设置为账户主组织，移除旧主组织，加入新主组织。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetUserPrimaryOrganizationalUnitRequest
        /// </param>
        /// 
        /// <returns>
        /// SetUserPrimaryOrganizationalUnitResponse
        /// </returns>
        public async Task<SetUserPrimaryOrganizationalUnitResponse> SetUserPrimaryOrganizationalUnitAsync(string instanceId, string applicationId, string userId, SetUserPrimaryOrganizationalUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetUserPrimaryOrganizationalUnitHeaders headers = new SetUserPrimaryOrganizationalUnitHeaders();
            return await SetUserPrimaryOrganizationalUnitWithOptionsAsync(instanceId, applicationId, userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新账户密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserPasswordRequest
        /// </param>
        /// <param name="headers">
        /// UpdateUserPasswordHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserPasswordResponse
        /// </returns>
        public UpdateUserPasswordResponse UpdateUserPasswordWithOptions(string instanceId, string applicationId, string userId, UpdateUserPasswordRequest request, UpdateUserPasswordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["password"] = request.Password;
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
                Action = "UpdateUserPassword",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId) + "/actions/updateUserPassword",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateUserPasswordResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateUserPasswordResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新账户密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserPasswordRequest
        /// </param>
        /// <param name="headers">
        /// UpdateUserPasswordHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserPasswordResponse
        /// </returns>
        public async Task<UpdateUserPasswordResponse> UpdateUserPasswordWithOptionsAsync(string instanceId, string applicationId, string userId, UpdateUserPasswordRequest request, UpdateUserPasswordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["password"] = request.Password;
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
                Action = "UpdateUserPassword",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/v2/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(applicationId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId) + "/actions/updateUserPassword",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateUserPasswordResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateUserPasswordResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新账户密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserPasswordResponse
        /// </returns>
        public UpdateUserPasswordResponse UpdateUserPassword(string instanceId, string applicationId, string userId, UpdateUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUserPasswordHeaders headers = new UpdateUserPasswordHeaders();
            return UpdateUserPasswordWithOptions(instanceId, applicationId, userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新账户密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserPasswordResponse
        /// </returns>
        public async Task<UpdateUserPasswordResponse> UpdateUserPasswordAsync(string instanceId, string applicationId, string userId, UpdateUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUserPasswordHeaders headers = new UpdateUserPasswordHeaders();
            return await UpdateUserPasswordWithOptionsAsync(instanceId, applicationId, userId, request, headers, runtime);
        }

    }
}
