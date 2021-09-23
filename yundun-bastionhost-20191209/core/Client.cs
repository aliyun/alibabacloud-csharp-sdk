// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Yundun_bastionhost20191209.Models;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("yundun-bastionhost", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddHostsToGroupResponse AddHostsToGroupWithOptions(AddHostsToGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddHostsToGroupResponse>(DoRPCRequest("AddHostsToGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddHostsToGroupResponse> AddHostsToGroupWithOptionsAsync(AddHostsToGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddHostsToGroupResponse>(await DoRPCRequestAsync("AddHostsToGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddHostsToGroupResponse AddHostsToGroup(AddHostsToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddHostsToGroupWithOptions(request, runtime);
        }

        public async Task<AddHostsToGroupResponse> AddHostsToGroupAsync(AddHostsToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddHostsToGroupWithOptionsAsync(request, runtime);
        }

        public AddUsersToGroupResponse AddUsersToGroupWithOptions(AddUsersToGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddUsersToGroupResponse>(DoRPCRequest("AddUsersToGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddUsersToGroupResponse> AddUsersToGroupWithOptionsAsync(AddUsersToGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddUsersToGroupResponse>(await DoRPCRequestAsync("AddUsersToGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddUsersToGroupResponse AddUsersToGroup(AddUsersToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUsersToGroupWithOptions(request, runtime);
        }

        public async Task<AddUsersToGroupResponse> AddUsersToGroupAsync(AddUsersToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUsersToGroupWithOptionsAsync(request, runtime);
        }

        public AttachHostAccountsToUserResponse AttachHostAccountsToUserWithOptions(AttachHostAccountsToUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachHostAccountsToUserResponse>(DoRPCRequest("AttachHostAccountsToUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachHostAccountsToUserResponse> AttachHostAccountsToUserWithOptionsAsync(AttachHostAccountsToUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachHostAccountsToUserResponse>(await DoRPCRequestAsync("AttachHostAccountsToUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachHostAccountsToUserResponse AttachHostAccountsToUser(AttachHostAccountsToUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachHostAccountsToUserWithOptions(request, runtime);
        }

        public async Task<AttachHostAccountsToUserResponse> AttachHostAccountsToUserAsync(AttachHostAccountsToUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachHostAccountsToUserWithOptionsAsync(request, runtime);
        }

        public AttachHostAccountsToUserGroupResponse AttachHostAccountsToUserGroupWithOptions(AttachHostAccountsToUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachHostAccountsToUserGroupResponse>(DoRPCRequest("AttachHostAccountsToUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachHostAccountsToUserGroupResponse> AttachHostAccountsToUserGroupWithOptionsAsync(AttachHostAccountsToUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachHostAccountsToUserGroupResponse>(await DoRPCRequestAsync("AttachHostAccountsToUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachHostAccountsToUserGroupResponse AttachHostAccountsToUserGroup(AttachHostAccountsToUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachHostAccountsToUserGroupWithOptions(request, runtime);
        }

        public async Task<AttachHostAccountsToUserGroupResponse> AttachHostAccountsToUserGroupAsync(AttachHostAccountsToUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachHostAccountsToUserGroupWithOptionsAsync(request, runtime);
        }

        public AttachHostGroupAccountsToUserResponse AttachHostGroupAccountsToUserWithOptions(AttachHostGroupAccountsToUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachHostGroupAccountsToUserResponse>(DoRPCRequest("AttachHostGroupAccountsToUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachHostGroupAccountsToUserResponse> AttachHostGroupAccountsToUserWithOptionsAsync(AttachHostGroupAccountsToUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachHostGroupAccountsToUserResponse>(await DoRPCRequestAsync("AttachHostGroupAccountsToUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachHostGroupAccountsToUserResponse AttachHostGroupAccountsToUser(AttachHostGroupAccountsToUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachHostGroupAccountsToUserWithOptions(request, runtime);
        }

        public async Task<AttachHostGroupAccountsToUserResponse> AttachHostGroupAccountsToUserAsync(AttachHostGroupAccountsToUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachHostGroupAccountsToUserWithOptionsAsync(request, runtime);
        }

        public AttachHostGroupAccountsToUserGroupResponse AttachHostGroupAccountsToUserGroupWithOptions(AttachHostGroupAccountsToUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachHostGroupAccountsToUserGroupResponse>(DoRPCRequest("AttachHostGroupAccountsToUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachHostGroupAccountsToUserGroupResponse> AttachHostGroupAccountsToUserGroupWithOptionsAsync(AttachHostGroupAccountsToUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachHostGroupAccountsToUserGroupResponse>(await DoRPCRequestAsync("AttachHostGroupAccountsToUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachHostGroupAccountsToUserGroupResponse AttachHostGroupAccountsToUserGroup(AttachHostGroupAccountsToUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachHostGroupAccountsToUserGroupWithOptions(request, runtime);
        }

        public async Task<AttachHostGroupAccountsToUserGroupResponse> AttachHostGroupAccountsToUserGroupAsync(AttachHostGroupAccountsToUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachHostGroupAccountsToUserGroupWithOptionsAsync(request, runtime);
        }

        public ConfigInstanceSecurityGroupsResponse ConfigInstanceSecurityGroupsWithOptions(ConfigInstanceSecurityGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigInstanceSecurityGroupsResponse>(DoRPCRequest("ConfigInstanceSecurityGroups", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigInstanceSecurityGroupsResponse> ConfigInstanceSecurityGroupsWithOptionsAsync(ConfigInstanceSecurityGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigInstanceSecurityGroupsResponse>(await DoRPCRequestAsync("ConfigInstanceSecurityGroups", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConfigInstanceSecurityGroupsResponse ConfigInstanceSecurityGroups(ConfigInstanceSecurityGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigInstanceSecurityGroupsWithOptions(request, runtime);
        }

        public async Task<ConfigInstanceSecurityGroupsResponse> ConfigInstanceSecurityGroupsAsync(ConfigInstanceSecurityGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigInstanceSecurityGroupsWithOptionsAsync(request, runtime);
        }

        public ConfigInstanceWhiteListResponse ConfigInstanceWhiteListWithOptions(ConfigInstanceWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigInstanceWhiteListResponse>(DoRPCRequest("ConfigInstanceWhiteList", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigInstanceWhiteListResponse> ConfigInstanceWhiteListWithOptionsAsync(ConfigInstanceWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigInstanceWhiteListResponse>(await DoRPCRequestAsync("ConfigInstanceWhiteList", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConfigInstanceWhiteListResponse ConfigInstanceWhiteList(ConfigInstanceWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigInstanceWhiteListWithOptions(request, runtime);
        }

        public async Task<ConfigInstanceWhiteListResponse> ConfigInstanceWhiteListAsync(ConfigInstanceWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigInstanceWhiteListWithOptionsAsync(request, runtime);
        }

        public CreateHostResponse CreateHostWithOptions(CreateHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHostResponse>(DoRPCRequest("CreateHost", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateHostResponse> CreateHostWithOptionsAsync(CreateHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHostResponse>(await DoRPCRequestAsync("CreateHost", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateHostResponse CreateHost(CreateHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHostWithOptions(request, runtime);
        }

        public async Task<CreateHostResponse> CreateHostAsync(CreateHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHostWithOptionsAsync(request, runtime);
        }

        public CreateHostAccountResponse CreateHostAccountWithOptions(CreateHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHostAccountResponse>(DoRPCRequest("CreateHostAccount", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateHostAccountResponse> CreateHostAccountWithOptionsAsync(CreateHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHostAccountResponse>(await DoRPCRequestAsync("CreateHostAccount", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateHostAccountResponse CreateHostAccount(CreateHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHostAccountWithOptions(request, runtime);
        }

        public async Task<CreateHostAccountResponse> CreateHostAccountAsync(CreateHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHostAccountWithOptionsAsync(request, runtime);
        }

        public CreateHostGroupResponse CreateHostGroupWithOptions(CreateHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHostGroupResponse>(DoRPCRequest("CreateHostGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateHostGroupResponse> CreateHostGroupWithOptionsAsync(CreateHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHostGroupResponse>(await DoRPCRequestAsync("CreateHostGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateHostGroupResponse CreateHostGroup(CreateHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHostGroupWithOptions(request, runtime);
        }

        public async Task<CreateHostGroupResponse> CreateHostGroupAsync(CreateHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHostGroupWithOptionsAsync(request, runtime);
        }

        public CreateUserResponse CreateUserWithOptions(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserResponse>(DoRPCRequest("CreateUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateUserResponse> CreateUserWithOptionsAsync(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserResponse>(await DoRPCRequestAsync("CreateUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateUserResponse CreateUser(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserWithOptions(request, runtime);
        }

        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserWithOptionsAsync(request, runtime);
        }

        public CreateUserGroupResponse CreateUserGroupWithOptions(CreateUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserGroupResponse>(DoRPCRequest("CreateUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateUserGroupResponse> CreateUserGroupWithOptionsAsync(CreateUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserGroupResponse>(await DoRPCRequestAsync("CreateUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateUserGroupResponse CreateUserGroup(CreateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserGroupWithOptions(request, runtime);
        }

        public async Task<CreateUserGroupResponse> CreateUserGroupAsync(CreateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserGroupWithOptionsAsync(request, runtime);
        }

        public DeleteHostResponse DeleteHostWithOptions(DeleteHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHostResponse>(DoRPCRequest("DeleteHost", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteHostResponse> DeleteHostWithOptionsAsync(DeleteHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHostResponse>(await DoRPCRequestAsync("DeleteHost", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteHostResponse DeleteHost(DeleteHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHostWithOptions(request, runtime);
        }

        public async Task<DeleteHostResponse> DeleteHostAsync(DeleteHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHostWithOptionsAsync(request, runtime);
        }

        public DeleteHostAccountResponse DeleteHostAccountWithOptions(DeleteHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHostAccountResponse>(DoRPCRequest("DeleteHostAccount", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteHostAccountResponse> DeleteHostAccountWithOptionsAsync(DeleteHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHostAccountResponse>(await DoRPCRequestAsync("DeleteHostAccount", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteHostAccountResponse DeleteHostAccount(DeleteHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHostAccountWithOptions(request, runtime);
        }

        public async Task<DeleteHostAccountResponse> DeleteHostAccountAsync(DeleteHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHostAccountWithOptionsAsync(request, runtime);
        }

        public DeleteHostGroupResponse DeleteHostGroupWithOptions(DeleteHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHostGroupResponse>(DoRPCRequest("DeleteHostGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteHostGroupResponse> DeleteHostGroupWithOptionsAsync(DeleteHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHostGroupResponse>(await DoRPCRequestAsync("DeleteHostGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteHostGroupResponse DeleteHostGroup(DeleteHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHostGroupWithOptions(request, runtime);
        }

        public async Task<DeleteHostGroupResponse> DeleteHostGroupAsync(DeleteHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHostGroupWithOptionsAsync(request, runtime);
        }

        public DeleteUserResponse DeleteUserWithOptions(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserResponse>(DoRPCRequest("DeleteUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUserResponse> DeleteUserWithOptionsAsync(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserResponse>(await DoRPCRequestAsync("DeleteUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserWithOptions(request, runtime);
        }

        public async Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserWithOptionsAsync(request, runtime);
        }

        public DeleteUserGroupResponse DeleteUserGroupWithOptions(DeleteUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserGroupResponse>(DoRPCRequest("DeleteUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUserGroupResponse> DeleteUserGroupWithOptionsAsync(DeleteUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserGroupResponse>(await DoRPCRequestAsync("DeleteUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteUserGroupResponse DeleteUserGroup(DeleteUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserGroupWithOptions(request, runtime);
        }

        public async Task<DeleteUserGroupResponse> DeleteUserGroupAsync(DeleteUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserGroupWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceAttributeResponse DescribeInstanceAttributeWithOptions(DescribeInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAttributeResponse>(DoRPCRequest("DescribeInstanceAttribute", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceAttributeResponse> DescribeInstanceAttributeWithOptionsAsync(DescribeInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAttributeResponse>(await DoRPCRequestAsync("DescribeInstanceAttribute", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceAttributeResponse DescribeInstanceAttribute(DescribeInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceAttributeResponse> DescribeInstanceAttributeAsync(DescribeInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeInstancesResponse DescribeInstancesWithOptions(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(DoRPCRequest("DescribeInstances", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstancesResponse> DescribeInstancesWithOptionsAsync(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(await DoRPCRequestAsync("DescribeInstances", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        public DetachHostAccountsFromUserResponse DetachHostAccountsFromUserWithOptions(DetachHostAccountsFromUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachHostAccountsFromUserResponse>(DoRPCRequest("DetachHostAccountsFromUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachHostAccountsFromUserResponse> DetachHostAccountsFromUserWithOptionsAsync(DetachHostAccountsFromUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachHostAccountsFromUserResponse>(await DoRPCRequestAsync("DetachHostAccountsFromUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachHostAccountsFromUserResponse DetachHostAccountsFromUser(DetachHostAccountsFromUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachHostAccountsFromUserWithOptions(request, runtime);
        }

        public async Task<DetachHostAccountsFromUserResponse> DetachHostAccountsFromUserAsync(DetachHostAccountsFromUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachHostAccountsFromUserWithOptionsAsync(request, runtime);
        }

        public DetachHostAccountsFromUserGroupResponse DetachHostAccountsFromUserGroupWithOptions(DetachHostAccountsFromUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachHostAccountsFromUserGroupResponse>(DoRPCRequest("DetachHostAccountsFromUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachHostAccountsFromUserGroupResponse> DetachHostAccountsFromUserGroupWithOptionsAsync(DetachHostAccountsFromUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachHostAccountsFromUserGroupResponse>(await DoRPCRequestAsync("DetachHostAccountsFromUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachHostAccountsFromUserGroupResponse DetachHostAccountsFromUserGroup(DetachHostAccountsFromUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachHostAccountsFromUserGroupWithOptions(request, runtime);
        }

        public async Task<DetachHostAccountsFromUserGroupResponse> DetachHostAccountsFromUserGroupAsync(DetachHostAccountsFromUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachHostAccountsFromUserGroupWithOptionsAsync(request, runtime);
        }

        public DetachHostGroupAccountsFromUserResponse DetachHostGroupAccountsFromUserWithOptions(DetachHostGroupAccountsFromUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachHostGroupAccountsFromUserResponse>(DoRPCRequest("DetachHostGroupAccountsFromUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachHostGroupAccountsFromUserResponse> DetachHostGroupAccountsFromUserWithOptionsAsync(DetachHostGroupAccountsFromUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachHostGroupAccountsFromUserResponse>(await DoRPCRequestAsync("DetachHostGroupAccountsFromUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachHostGroupAccountsFromUserResponse DetachHostGroupAccountsFromUser(DetachHostGroupAccountsFromUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachHostGroupAccountsFromUserWithOptions(request, runtime);
        }

        public async Task<DetachHostGroupAccountsFromUserResponse> DetachHostGroupAccountsFromUserAsync(DetachHostGroupAccountsFromUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachHostGroupAccountsFromUserWithOptionsAsync(request, runtime);
        }

        public DetachHostGroupAccountsFromUserGroupResponse DetachHostGroupAccountsFromUserGroupWithOptions(DetachHostGroupAccountsFromUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachHostGroupAccountsFromUserGroupResponse>(DoRPCRequest("DetachHostGroupAccountsFromUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachHostGroupAccountsFromUserGroupResponse> DetachHostGroupAccountsFromUserGroupWithOptionsAsync(DetachHostGroupAccountsFromUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachHostGroupAccountsFromUserGroupResponse>(await DoRPCRequestAsync("DetachHostGroupAccountsFromUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachHostGroupAccountsFromUserGroupResponse DetachHostGroupAccountsFromUserGroup(DetachHostGroupAccountsFromUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachHostGroupAccountsFromUserGroupWithOptions(request, runtime);
        }

        public async Task<DetachHostGroupAccountsFromUserGroupResponse> DetachHostGroupAccountsFromUserGroupAsync(DetachHostGroupAccountsFromUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachHostGroupAccountsFromUserGroupWithOptionsAsync(request, runtime);
        }

        public DisableInstancePublicAccessResponse DisableInstancePublicAccessWithOptions(DisableInstancePublicAccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableInstancePublicAccessResponse>(DoRPCRequest("DisableInstancePublicAccess", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableInstancePublicAccessResponse> DisableInstancePublicAccessWithOptionsAsync(DisableInstancePublicAccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableInstancePublicAccessResponse>(await DoRPCRequestAsync("DisableInstancePublicAccess", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableInstancePublicAccessResponse DisableInstancePublicAccess(DisableInstancePublicAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableInstancePublicAccessWithOptions(request, runtime);
        }

        public async Task<DisableInstancePublicAccessResponse> DisableInstancePublicAccessAsync(DisableInstancePublicAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableInstancePublicAccessWithOptionsAsync(request, runtime);
        }

        public EnableInstancePublicAccessResponse EnableInstancePublicAccessWithOptions(EnableInstancePublicAccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableInstancePublicAccessResponse>(DoRPCRequest("EnableInstancePublicAccess", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableInstancePublicAccessResponse> EnableInstancePublicAccessWithOptionsAsync(EnableInstancePublicAccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableInstancePublicAccessResponse>(await DoRPCRequestAsync("EnableInstancePublicAccess", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableInstancePublicAccessResponse EnableInstancePublicAccess(EnableInstancePublicAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableInstancePublicAccessWithOptions(request, runtime);
        }

        public async Task<EnableInstancePublicAccessResponse> EnableInstancePublicAccessAsync(EnableInstancePublicAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableInstancePublicAccessWithOptionsAsync(request, runtime);
        }

        public GetHostResponse GetHostWithOptions(GetHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHostResponse>(DoRPCRequest("GetHost", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetHostResponse> GetHostWithOptionsAsync(GetHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHostResponse>(await DoRPCRequestAsync("GetHost", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetHostResponse GetHost(GetHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHostWithOptions(request, runtime);
        }

        public async Task<GetHostResponse> GetHostAsync(GetHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHostWithOptionsAsync(request, runtime);
        }

        public GetHostAccountResponse GetHostAccountWithOptions(GetHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHostAccountResponse>(DoRPCRequest("GetHostAccount", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetHostAccountResponse> GetHostAccountWithOptionsAsync(GetHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHostAccountResponse>(await DoRPCRequestAsync("GetHostAccount", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetHostAccountResponse GetHostAccount(GetHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHostAccountWithOptions(request, runtime);
        }

        public async Task<GetHostAccountResponse> GetHostAccountAsync(GetHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHostAccountWithOptionsAsync(request, runtime);
        }

        public GetHostGroupResponse GetHostGroupWithOptions(GetHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHostGroupResponse>(DoRPCRequest("GetHostGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetHostGroupResponse> GetHostGroupWithOptionsAsync(GetHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHostGroupResponse>(await DoRPCRequestAsync("GetHostGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetHostGroupResponse GetHostGroup(GetHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHostGroupWithOptions(request, runtime);
        }

        public async Task<GetHostGroupResponse> GetHostGroupAsync(GetHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHostGroupWithOptionsAsync(request, runtime);
        }

        public GetInstanceUpgradeInfoResponse GetInstanceUpgradeInfoWithOptions(GetInstanceUpgradeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceUpgradeInfoResponse>(DoRPCRequest("GetInstanceUpgradeInfo", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceUpgradeInfoResponse> GetInstanceUpgradeInfoWithOptionsAsync(GetInstanceUpgradeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceUpgradeInfoResponse>(await DoRPCRequestAsync("GetInstanceUpgradeInfo", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceUpgradeInfoResponse GetInstanceUpgradeInfo(GetInstanceUpgradeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceUpgradeInfoWithOptions(request, runtime);
        }

        public async Task<GetInstanceUpgradeInfoResponse> GetInstanceUpgradeInfoAsync(GetInstanceUpgradeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceUpgradeInfoWithOptionsAsync(request, runtime);
        }

        public GetUserResponse GetUserWithOptions(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserResponse>(DoRPCRequest("GetUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetUserResponse> GetUserWithOptionsAsync(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserResponse>(await DoRPCRequestAsync("GetUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetUserResponse GetUser(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserWithOptions(request, runtime);
        }

        public async Task<GetUserResponse> GetUserAsync(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserWithOptionsAsync(request, runtime);
        }

        public GetUserGroupResponse GetUserGroupWithOptions(GetUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserGroupResponse>(DoRPCRequest("GetUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetUserGroupResponse> GetUserGroupWithOptionsAsync(GetUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserGroupResponse>(await DoRPCRequestAsync("GetUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetUserGroupResponse GetUserGroup(GetUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserGroupWithOptions(request, runtime);
        }

        public async Task<GetUserGroupResponse> GetUserGroupAsync(GetUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserGroupWithOptionsAsync(request, runtime);
        }

        public ListHostAccountsResponse ListHostAccountsWithOptions(ListHostAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHostAccountsResponse>(DoRPCRequest("ListHostAccounts", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListHostAccountsResponse> ListHostAccountsWithOptionsAsync(ListHostAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHostAccountsResponse>(await DoRPCRequestAsync("ListHostAccounts", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListHostAccountsResponse ListHostAccounts(ListHostAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHostAccountsWithOptions(request, runtime);
        }

        public async Task<ListHostAccountsResponse> ListHostAccountsAsync(ListHostAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHostAccountsWithOptionsAsync(request, runtime);
        }

        public ListHostAccountsForUserResponse ListHostAccountsForUserWithOptions(ListHostAccountsForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHostAccountsForUserResponse>(DoRPCRequest("ListHostAccountsForUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListHostAccountsForUserResponse> ListHostAccountsForUserWithOptionsAsync(ListHostAccountsForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHostAccountsForUserResponse>(await DoRPCRequestAsync("ListHostAccountsForUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListHostAccountsForUserResponse ListHostAccountsForUser(ListHostAccountsForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHostAccountsForUserWithOptions(request, runtime);
        }

        public async Task<ListHostAccountsForUserResponse> ListHostAccountsForUserAsync(ListHostAccountsForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHostAccountsForUserWithOptionsAsync(request, runtime);
        }

        public ListHostAccountsForUserGroupResponse ListHostAccountsForUserGroupWithOptions(ListHostAccountsForUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHostAccountsForUserGroupResponse>(DoRPCRequest("ListHostAccountsForUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListHostAccountsForUserGroupResponse> ListHostAccountsForUserGroupWithOptionsAsync(ListHostAccountsForUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHostAccountsForUserGroupResponse>(await DoRPCRequestAsync("ListHostAccountsForUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListHostAccountsForUserGroupResponse ListHostAccountsForUserGroup(ListHostAccountsForUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHostAccountsForUserGroupWithOptions(request, runtime);
        }

        public async Task<ListHostAccountsForUserGroupResponse> ListHostAccountsForUserGroupAsync(ListHostAccountsForUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHostAccountsForUserGroupWithOptionsAsync(request, runtime);
        }

        public ListHostGroupAccountNamesForUserResponse ListHostGroupAccountNamesForUserWithOptions(ListHostGroupAccountNamesForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHostGroupAccountNamesForUserResponse>(DoRPCRequest("ListHostGroupAccountNamesForUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListHostGroupAccountNamesForUserResponse> ListHostGroupAccountNamesForUserWithOptionsAsync(ListHostGroupAccountNamesForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHostGroupAccountNamesForUserResponse>(await DoRPCRequestAsync("ListHostGroupAccountNamesForUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListHostGroupAccountNamesForUserResponse ListHostGroupAccountNamesForUser(ListHostGroupAccountNamesForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHostGroupAccountNamesForUserWithOptions(request, runtime);
        }

        public async Task<ListHostGroupAccountNamesForUserResponse> ListHostGroupAccountNamesForUserAsync(ListHostGroupAccountNamesForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHostGroupAccountNamesForUserWithOptionsAsync(request, runtime);
        }

        public ListHostGroupAccountNamesForUserGroupResponse ListHostGroupAccountNamesForUserGroupWithOptions(ListHostGroupAccountNamesForUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHostGroupAccountNamesForUserGroupResponse>(DoRPCRequest("ListHostGroupAccountNamesForUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListHostGroupAccountNamesForUserGroupResponse> ListHostGroupAccountNamesForUserGroupWithOptionsAsync(ListHostGroupAccountNamesForUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHostGroupAccountNamesForUserGroupResponse>(await DoRPCRequestAsync("ListHostGroupAccountNamesForUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListHostGroupAccountNamesForUserGroupResponse ListHostGroupAccountNamesForUserGroup(ListHostGroupAccountNamesForUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHostGroupAccountNamesForUserGroupWithOptions(request, runtime);
        }

        public async Task<ListHostGroupAccountNamesForUserGroupResponse> ListHostGroupAccountNamesForUserGroupAsync(ListHostGroupAccountNamesForUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHostGroupAccountNamesForUserGroupWithOptionsAsync(request, runtime);
        }

        public ListHostGroupsResponse ListHostGroupsWithOptions(ListHostGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHostGroupsResponse>(DoRPCRequest("ListHostGroups", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListHostGroupsResponse> ListHostGroupsWithOptionsAsync(ListHostGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHostGroupsResponse>(await DoRPCRequestAsync("ListHostGroups", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListHostGroupsResponse ListHostGroups(ListHostGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHostGroupsWithOptions(request, runtime);
        }

        public async Task<ListHostGroupsResponse> ListHostGroupsAsync(ListHostGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHostGroupsWithOptionsAsync(request, runtime);
        }

        public ListHostGroupsForUserResponse ListHostGroupsForUserWithOptions(ListHostGroupsForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHostGroupsForUserResponse>(DoRPCRequest("ListHostGroupsForUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListHostGroupsForUserResponse> ListHostGroupsForUserWithOptionsAsync(ListHostGroupsForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHostGroupsForUserResponse>(await DoRPCRequestAsync("ListHostGroupsForUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListHostGroupsForUserResponse ListHostGroupsForUser(ListHostGroupsForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHostGroupsForUserWithOptions(request, runtime);
        }

        public async Task<ListHostGroupsForUserResponse> ListHostGroupsForUserAsync(ListHostGroupsForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHostGroupsForUserWithOptionsAsync(request, runtime);
        }

        public ListHostGroupsForUserGroupResponse ListHostGroupsForUserGroupWithOptions(ListHostGroupsForUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHostGroupsForUserGroupResponse>(DoRPCRequest("ListHostGroupsForUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListHostGroupsForUserGroupResponse> ListHostGroupsForUserGroupWithOptionsAsync(ListHostGroupsForUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHostGroupsForUserGroupResponse>(await DoRPCRequestAsync("ListHostGroupsForUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListHostGroupsForUserGroupResponse ListHostGroupsForUserGroup(ListHostGroupsForUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHostGroupsForUserGroupWithOptions(request, runtime);
        }

        public async Task<ListHostGroupsForUserGroupResponse> ListHostGroupsForUserGroupAsync(ListHostGroupsForUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHostGroupsForUserGroupWithOptionsAsync(request, runtime);
        }

        public ListHostsResponse ListHostsWithOptions(ListHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHostsResponse>(DoRPCRequest("ListHosts", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListHostsResponse> ListHostsWithOptionsAsync(ListHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHostsResponse>(await DoRPCRequestAsync("ListHosts", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListHostsResponse ListHosts(ListHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHostsWithOptions(request, runtime);
        }

        public async Task<ListHostsResponse> ListHostsAsync(ListHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHostsWithOptionsAsync(request, runtime);
        }

        public ListHostsForUserResponse ListHostsForUserWithOptions(ListHostsForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHostsForUserResponse>(DoRPCRequest("ListHostsForUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListHostsForUserResponse> ListHostsForUserWithOptionsAsync(ListHostsForUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHostsForUserResponse>(await DoRPCRequestAsync("ListHostsForUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListHostsForUserResponse ListHostsForUser(ListHostsForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHostsForUserWithOptions(request, runtime);
        }

        public async Task<ListHostsForUserResponse> ListHostsForUserAsync(ListHostsForUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHostsForUserWithOptionsAsync(request, runtime);
        }

        public ListHostsForUserGroupResponse ListHostsForUserGroupWithOptions(ListHostsForUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHostsForUserGroupResponse>(DoRPCRequest("ListHostsForUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListHostsForUserGroupResponse> ListHostsForUserGroupWithOptionsAsync(ListHostsForUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHostsForUserGroupResponse>(await DoRPCRequestAsync("ListHostsForUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListHostsForUserGroupResponse ListHostsForUserGroup(ListHostsForUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHostsForUserGroupWithOptions(request, runtime);
        }

        public async Task<ListHostsForUserGroupResponse> ListHostsForUserGroupAsync(ListHostsForUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHostsForUserGroupWithOptionsAsync(request, runtime);
        }

        public ListTagKeysResponse ListTagKeysWithOptions(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagKeysResponse>(DoRPCRequest("ListTagKeys", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagKeysResponse> ListTagKeysWithOptionsAsync(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagKeysResponse>(await DoRPCRequestAsync("ListTagKeys", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTagKeysResponse ListTagKeys(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagKeysWithOptions(request, runtime);
        }

        public async Task<ListTagKeysResponse> ListTagKeysAsync(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagKeysWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRPCRequest("ListTagResources", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRPCRequestAsync("ListTagResources", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        public ListUserGroupsResponse ListUserGroupsWithOptions(ListUserGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserGroupsResponse>(DoRPCRequest("ListUserGroups", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUserGroupsResponse> ListUserGroupsWithOptionsAsync(ListUserGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserGroupsResponse>(await DoRPCRequestAsync("ListUserGroups", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUserGroupsResponse ListUserGroups(ListUserGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserGroupsWithOptions(request, runtime);
        }

        public async Task<ListUserGroupsResponse> ListUserGroupsAsync(ListUserGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserGroupsWithOptionsAsync(request, runtime);
        }

        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsersResponse>(DoRPCRequest("ListUsers", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsersResponse>(await DoRPCRequestAsync("ListUsers", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersWithOptions(request, runtime);
        }

        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersWithOptionsAsync(request, runtime);
        }

        public LockUsersResponse LockUsersWithOptions(LockUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LockUsersResponse>(DoRPCRequest("LockUsers", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<LockUsersResponse> LockUsersWithOptionsAsync(LockUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LockUsersResponse>(await DoRPCRequestAsync("LockUsers", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public LockUsersResponse LockUsers(LockUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LockUsersWithOptions(request, runtime);
        }

        public async Task<LockUsersResponse> LockUsersAsync(LockUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LockUsersWithOptionsAsync(request, runtime);
        }

        public ModifyHostResponse ModifyHostWithOptions(ModifyHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHostResponse>(DoRPCRequest("ModifyHost", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyHostResponse> ModifyHostWithOptionsAsync(ModifyHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHostResponse>(await DoRPCRequestAsync("ModifyHost", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyHostResponse ModifyHost(ModifyHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHostWithOptions(request, runtime);
        }

        public async Task<ModifyHostResponse> ModifyHostAsync(ModifyHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHostWithOptionsAsync(request, runtime);
        }

        public ModifyHostAccountResponse ModifyHostAccountWithOptions(ModifyHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHostAccountResponse>(DoRPCRequest("ModifyHostAccount", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyHostAccountResponse> ModifyHostAccountWithOptionsAsync(ModifyHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHostAccountResponse>(await DoRPCRequestAsync("ModifyHostAccount", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyHostAccountResponse ModifyHostAccount(ModifyHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHostAccountWithOptions(request, runtime);
        }

        public async Task<ModifyHostAccountResponse> ModifyHostAccountAsync(ModifyHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHostAccountWithOptionsAsync(request, runtime);
        }

        public ModifyHostGroupResponse ModifyHostGroupWithOptions(ModifyHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHostGroupResponse>(DoRPCRequest("ModifyHostGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyHostGroupResponse> ModifyHostGroupWithOptionsAsync(ModifyHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHostGroupResponse>(await DoRPCRequestAsync("ModifyHostGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyHostGroupResponse ModifyHostGroup(ModifyHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHostGroupWithOptions(request, runtime);
        }

        public async Task<ModifyHostGroupResponse> ModifyHostGroupAsync(ModifyHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHostGroupWithOptionsAsync(request, runtime);
        }

        public ModifyHostsActiveAddressTypeResponse ModifyHostsActiveAddressTypeWithOptions(ModifyHostsActiveAddressTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHostsActiveAddressTypeResponse>(DoRPCRequest("ModifyHostsActiveAddressType", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyHostsActiveAddressTypeResponse> ModifyHostsActiveAddressTypeWithOptionsAsync(ModifyHostsActiveAddressTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHostsActiveAddressTypeResponse>(await DoRPCRequestAsync("ModifyHostsActiveAddressType", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyHostsActiveAddressTypeResponse ModifyHostsActiveAddressType(ModifyHostsActiveAddressTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHostsActiveAddressTypeWithOptions(request, runtime);
        }

        public async Task<ModifyHostsActiveAddressTypeResponse> ModifyHostsActiveAddressTypeAsync(ModifyHostsActiveAddressTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHostsActiveAddressTypeWithOptionsAsync(request, runtime);
        }

        public ModifyHostsPortResponse ModifyHostsPortWithOptions(ModifyHostsPortRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHostsPortResponse>(DoRPCRequest("ModifyHostsPort", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyHostsPortResponse> ModifyHostsPortWithOptionsAsync(ModifyHostsPortRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHostsPortResponse>(await DoRPCRequestAsync("ModifyHostsPort", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyHostsPortResponse ModifyHostsPort(ModifyHostsPortRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHostsPortWithOptions(request, runtime);
        }

        public async Task<ModifyHostsPortResponse> ModifyHostsPortAsync(ModifyHostsPortRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHostsPortWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceAttributeResponse ModifyInstanceAttributeWithOptions(ModifyInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAttributeResponse>(DoRPCRequest("ModifyInstanceAttribute", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeWithOptionsAsync(ModifyInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAttributeResponse>(await DoRPCRequestAsync("ModifyInstanceAttribute", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeAsync(ModifyInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceUpgradePeriodResponse ModifyInstanceUpgradePeriodWithOptions(ModifyInstanceUpgradePeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceUpgradePeriodResponse>(DoRPCRequest("ModifyInstanceUpgradePeriod", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceUpgradePeriodResponse> ModifyInstanceUpgradePeriodWithOptionsAsync(ModifyInstanceUpgradePeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceUpgradePeriodResponse>(await DoRPCRequestAsync("ModifyInstanceUpgradePeriod", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceUpgradePeriodResponse ModifyInstanceUpgradePeriod(ModifyInstanceUpgradePeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceUpgradePeriodWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceUpgradePeriodResponse> ModifyInstanceUpgradePeriodAsync(ModifyInstanceUpgradePeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceUpgradePeriodWithOptionsAsync(request, runtime);
        }

        public ModifyUserResponse ModifyUserWithOptions(ModifyUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUserResponse>(DoRPCRequest("ModifyUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyUserResponse> ModifyUserWithOptionsAsync(ModifyUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUserResponse>(await DoRPCRequestAsync("ModifyUser", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyUserResponse ModifyUser(ModifyUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyUserWithOptions(request, runtime);
        }

        public async Task<ModifyUserResponse> ModifyUserAsync(ModifyUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyUserWithOptionsAsync(request, runtime);
        }

        public ModifyUserGroupResponse ModifyUserGroupWithOptions(ModifyUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUserGroupResponse>(DoRPCRequest("ModifyUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyUserGroupResponse> ModifyUserGroupWithOptionsAsync(ModifyUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUserGroupResponse>(await DoRPCRequestAsync("ModifyUserGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyUserGroupResponse ModifyUserGroup(ModifyUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyUserGroupWithOptions(request, runtime);
        }

        public async Task<ModifyUserGroupResponse> ModifyUserGroupAsync(ModifyUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyUserGroupWithOptionsAsync(request, runtime);
        }

        public MoveResourceGroupResponse MoveResourceGroupWithOptions(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(DoRPCRequest("MoveResourceGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MoveResourceGroupResponse> MoveResourceGroupWithOptionsAsync(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(await DoRPCRequestAsync("MoveResourceGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MoveResourceGroupResponse MoveResourceGroup(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveResourceGroupWithOptions(request, runtime);
        }

        public async Task<MoveResourceGroupResponse> MoveResourceGroupAsync(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveResourceGroupWithOptionsAsync(request, runtime);
        }

        public RemoveHostsFromGroupResponse RemoveHostsFromGroupWithOptions(RemoveHostsFromGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveHostsFromGroupResponse>(DoRPCRequest("RemoveHostsFromGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveHostsFromGroupResponse> RemoveHostsFromGroupWithOptionsAsync(RemoveHostsFromGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveHostsFromGroupResponse>(await DoRPCRequestAsync("RemoveHostsFromGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveHostsFromGroupResponse RemoveHostsFromGroup(RemoveHostsFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveHostsFromGroupWithOptions(request, runtime);
        }

        public async Task<RemoveHostsFromGroupResponse> RemoveHostsFromGroupAsync(RemoveHostsFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveHostsFromGroupWithOptionsAsync(request, runtime);
        }

        public RemoveUsersFromGroupResponse RemoveUsersFromGroupWithOptions(RemoveUsersFromGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveUsersFromGroupResponse>(DoRPCRequest("RemoveUsersFromGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveUsersFromGroupResponse> RemoveUsersFromGroupWithOptionsAsync(RemoveUsersFromGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveUsersFromGroupResponse>(await DoRPCRequestAsync("RemoveUsersFromGroup", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveUsersFromGroupResponse RemoveUsersFromGroup(RemoveUsersFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveUsersFromGroupWithOptions(request, runtime);
        }

        public async Task<RemoveUsersFromGroupResponse> RemoveUsersFromGroupAsync(RemoveUsersFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveUsersFromGroupWithOptionsAsync(request, runtime);
        }

        public ResetHostAccountCredentialResponse ResetHostAccountCredentialWithOptions(ResetHostAccountCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetHostAccountCredentialResponse>(DoRPCRequest("ResetHostAccountCredential", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetHostAccountCredentialResponse> ResetHostAccountCredentialWithOptionsAsync(ResetHostAccountCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetHostAccountCredentialResponse>(await DoRPCRequestAsync("ResetHostAccountCredential", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResetHostAccountCredentialResponse ResetHostAccountCredential(ResetHostAccountCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetHostAccountCredentialWithOptions(request, runtime);
        }

        public async Task<ResetHostAccountCredentialResponse> ResetHostAccountCredentialAsync(ResetHostAccountCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetHostAccountCredentialWithOptionsAsync(request, runtime);
        }

        public StartInstanceResponse StartInstanceWithOptions(StartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartInstanceResponse>(DoRPCRequest("StartInstance", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartInstanceResponse> StartInstanceWithOptionsAsync(StartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartInstanceResponse>(await DoRPCRequestAsync("StartInstance", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartInstanceResponse StartInstance(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartInstanceWithOptions(request, runtime);
        }

        public async Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartInstanceWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        public UnlockUsersResponse UnlockUsersWithOptions(UnlockUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnlockUsersResponse>(DoRPCRequest("UnlockUsers", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnlockUsersResponse> UnlockUsersWithOptionsAsync(UnlockUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnlockUsersResponse>(await DoRPCRequestAsync("UnlockUsers", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnlockUsersResponse UnlockUsers(UnlockUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnlockUsersWithOptions(request, runtime);
        }

        public async Task<UnlockUsersResponse> UnlockUsersAsync(UnlockUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnlockUsersWithOptionsAsync(request, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(DoRPCRequest("UntagResources", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRPCRequestAsync("UntagResources", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        public UpgradeInstanceImageVersionResponse UpgradeInstanceImageVersionWithOptions(UpgradeInstanceImageVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeInstanceImageVersionResponse>(DoRPCRequest("UpgradeInstanceImageVersion", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpgradeInstanceImageVersionResponse> UpgradeInstanceImageVersionWithOptionsAsync(UpgradeInstanceImageVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeInstanceImageVersionResponse>(await DoRPCRequestAsync("UpgradeInstanceImageVersion", "2019-12-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpgradeInstanceImageVersionResponse UpgradeInstanceImageVersion(UpgradeInstanceImageVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeInstanceImageVersionWithOptions(request, runtime);
        }

        public async Task<UpgradeInstanceImageVersionResponse> UpgradeInstanceImageVersionAsync(UpgradeInstanceImageVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeInstanceImageVersionWithOptionsAsync(request, runtime);
        }

    }
}
