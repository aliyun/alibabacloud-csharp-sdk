// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Codeup20200414.Models;

namespace AlibabaCloud.SDK.Codeup20200414
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("codeup", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddGroupMemberResponse AddGroupMember(string GroupId, AddGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddGroupMemberWithOptions(GroupId, request, headers, runtime);
        }

        public async Task<AddGroupMemberResponse> AddGroupMemberAsync(string GroupId, AddGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddGroupMemberWithOptionsAsync(GroupId, request, headers, runtime);
        }

        public AddGroupMemberResponse AddGroupMemberWithOptions(string GroupId, AddGroupMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<AddGroupMemberResponse>(DoROARequest("AddGroupMember", "2020-04-14", "HTTPS", "POST", "AK", "/api/v4/groups/" + GroupId + "/members", "json", req, runtime));
        }

        public async Task<AddGroupMemberResponse> AddGroupMemberWithOptionsAsync(string GroupId, AddGroupMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<AddGroupMemberResponse>(await DoROARequestAsync("AddGroupMember", "2020-04-14", "HTTPS", "POST", "AK", "/api/v4/groups/" + GroupId + "/members", "json", req, runtime));
        }

        public AddRepositoryMemberResponse AddRepositoryMember(string ProjectId, AddRepositoryMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddRepositoryMemberWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<AddRepositoryMemberResponse> AddRepositoryMemberAsync(string ProjectId, AddRepositoryMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddRepositoryMemberWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public AddRepositoryMemberResponse AddRepositoryMemberWithOptions(string ProjectId, AddRepositoryMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<AddRepositoryMemberResponse>(DoROARequest("AddRepositoryMember", "2020-04-14", "HTTPS", "POST", "AK", "/api/v4/projects/" + ProjectId + "/members", "json", req, runtime));
        }

        public async Task<AddRepositoryMemberResponse> AddRepositoryMemberWithOptionsAsync(string ProjectId, AddRepositoryMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<AddRepositoryMemberResponse>(await DoROARequestAsync("AddRepositoryMember", "2020-04-14", "HTTPS", "POST", "AK", "/api/v4/projects/" + ProjectId + "/members", "json", req, runtime));
        }

        public AddWebhookResponse AddWebhook(string ProjectId, AddWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddWebhookWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<AddWebhookResponse> AddWebhookAsync(string ProjectId, AddWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddWebhookWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public AddWebhookResponse AddWebhookWithOptions(string ProjectId, AddWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<AddWebhookResponse>(DoROARequest("AddWebhook", "2020-04-14", "HTTPS", "POST", "AK", "/api/v3/projects/" + ProjectId + "/hooks", "json", req, runtime));
        }

        public async Task<AddWebhookResponse> AddWebhookWithOptionsAsync(string ProjectId, AddWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<AddWebhookResponse>(await DoROARequestAsync("AddWebhook", "2020-04-14", "HTTPS", "POST", "AK", "/api/v3/projects/" + ProjectId + "/hooks", "json", req, runtime));
        }

        public CreateBranchResponse CreateBranch(string ProjectId, CreateBranchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateBranchWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<CreateBranchResponse> CreateBranchAsync(string ProjectId, CreateBranchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateBranchWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public CreateBranchResponse CreateBranchWithOptions(string ProjectId, CreateBranchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateBranchResponse>(DoROARequest("CreateBranch", "2020-04-14", "HTTPS", "POST", "AK", "/api/v3/projects/" + ProjectId + "/repository/branches", "json", req, runtime));
        }

        public async Task<CreateBranchResponse> CreateBranchWithOptionsAsync(string ProjectId, CreateBranchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateBranchResponse>(await DoROARequestAsync("CreateBranch", "2020-04-14", "HTTPS", "POST", "AK", "/api/v3/projects/" + ProjectId + "/repository/branches", "json", req, runtime));
        }

        public CreateFileResponse CreateFile(string ProjectId, CreateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFileWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<CreateFileResponse> CreateFileAsync(string ProjectId, CreateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFileWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public CreateFileResponse CreateFileWithOptions(string ProjectId, CreateFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateFileResponse>(DoROARequest("CreateFile", "2020-04-14", "HTTPS", "POST", "AK", "/api/v3/projects/" + ProjectId + "/repository/files", "json", req, runtime));
        }

        public async Task<CreateFileResponse> CreateFileWithOptionsAsync(string ProjectId, CreateFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateFileResponse>(await DoROARequestAsync("CreateFile", "2020-04-14", "HTTPS", "POST", "AK", "/api/v3/projects/" + ProjectId + "/repository/files", "json", req, runtime));
        }

        public CreateMergeRequestResponse CreateMergeRequest(string ProjectId, CreateMergeRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMergeRequestWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<CreateMergeRequestResponse> CreateMergeRequestAsync(string ProjectId, CreateMergeRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMergeRequestWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public CreateMergeRequestResponse CreateMergeRequestWithOptions(string ProjectId, CreateMergeRequestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateMergeRequestResponse>(DoROARequest("CreateMergeRequest", "2020-04-14", "HTTPS", "POST", "AK", "/api/v4/projects/" + ProjectId + "/merge_requests", "json", req, runtime));
        }

        public async Task<CreateMergeRequestResponse> CreateMergeRequestWithOptionsAsync(string ProjectId, CreateMergeRequestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateMergeRequestResponse>(await DoROARequestAsync("CreateMergeRequest", "2020-04-14", "HTTPS", "POST", "AK", "/api/v4/projects/" + ProjectId + "/merge_requests", "json", req, runtime));
        }

        public CreateRepositoryResponse CreateRepository(CreateRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRepositoryWithOptions(request, headers, runtime);
        }

        public async Task<CreateRepositoryResponse> CreateRepositoryAsync(CreateRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRepositoryWithOptionsAsync(request, headers, runtime);
        }

        public CreateRepositoryResponse CreateRepositoryWithOptions(CreateRepositoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sync))
            {
                query["Sync"] = request.Sync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateParentPath))
            {
                query["CreateParentPath"] = request.CreateParentPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateRepositoryResponse>(DoROARequest("CreateRepository", "2020-04-14", "HTTPS", "POST", "AK", "/api/v3/projects", "json", req, runtime));
        }

        public async Task<CreateRepositoryResponse> CreateRepositoryWithOptionsAsync(CreateRepositoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sync))
            {
                query["Sync"] = request.Sync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateParentPath))
            {
                query["CreateParentPath"] = request.CreateParentPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateRepositoryResponse>(await DoROARequestAsync("CreateRepository", "2020-04-14", "HTTPS", "POST", "AK", "/api/v3/projects", "json", req, runtime));
        }

        public CreateRepositoryGroupResponse CreateRepositoryGroup(CreateRepositoryGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRepositoryGroupWithOptions(request, headers, runtime);
        }

        public async Task<CreateRepositoryGroupResponse> CreateRepositoryGroupAsync(CreateRepositoryGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRepositoryGroupWithOptionsAsync(request, headers, runtime);
        }

        public CreateRepositoryGroupResponse CreateRepositoryGroupWithOptions(CreateRepositoryGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateRepositoryGroupResponse>(DoROARequest("CreateRepositoryGroup", "2020-04-14", "HTTPS", "POST", "AK", "/api/v3/groups", "json", req, runtime));
        }

        public async Task<CreateRepositoryGroupResponse> CreateRepositoryGroupWithOptionsAsync(CreateRepositoryGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateRepositoryGroupResponse>(await DoROARequestAsync("CreateRepositoryGroup", "2020-04-14", "HTTPS", "POST", "AK", "/api/v3/groups", "json", req, runtime));
        }

        public CreateTagResponse CreateTag(string ProjectId, CreateTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTagWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<CreateTagResponse> CreateTagAsync(string ProjectId, CreateTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTagWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public CreateTagResponse CreateTagWithOptions(string ProjectId, CreateTagRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateTagResponse>(DoROARequest("CreateTag", "2020-04-14", "HTTPS", "POST", "AK", "/api/v3/projects/" + ProjectId + "/repository/tags", "json", req, runtime));
        }

        public async Task<CreateTagResponse> CreateTagWithOptionsAsync(string ProjectId, CreateTagRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateTagResponse>(await DoROARequestAsync("CreateTag", "2020-04-14", "HTTPS", "POST", "AK", "/api/v3/projects/" + ProjectId + "/repository/tags", "json", req, runtime));
        }

        public DeleteBranchResponse DeleteBranch(string ProjectId, DeleteBranchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteBranchWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<DeleteBranchResponse> DeleteBranchAsync(string ProjectId, DeleteBranchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteBranchWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public DeleteBranchResponse DeleteBranchWithOptions(string ProjectId, DeleteBranchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteBranchResponse>(DoROARequest("DeleteBranch", "2020-04-14", "HTTPS", "DELETE", "AK", "/api/v3/projects/" + ProjectId + "/repository/branches/delete", "json", req, runtime));
        }

        public async Task<DeleteBranchResponse> DeleteBranchWithOptionsAsync(string ProjectId, DeleteBranchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteBranchResponse>(await DoROARequestAsync("DeleteBranch", "2020-04-14", "HTTPS", "DELETE", "AK", "/api/v3/projects/" + ProjectId + "/repository/branches/delete", "json", req, runtime));
        }

        public DeleteFileResponse DeleteFile(string ProjectId, DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFileWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<DeleteFileResponse> DeleteFileAsync(string ProjectId, DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFileWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public DeleteFileResponse DeleteFileWithOptions(string ProjectId, DeleteFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommitMessage))
            {
                query["CommitMessage"] = request.CommitMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteFileResponse>(DoROARequest("DeleteFile", "2020-04-14", "HTTPS", "DELETE", "AK", "/api/v3/projects/" + ProjectId + "/repository/files", "json", req, runtime));
        }

        public async Task<DeleteFileResponse> DeleteFileWithOptionsAsync(string ProjectId, DeleteFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommitMessage))
            {
                query["CommitMessage"] = request.CommitMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteFileResponse>(await DoROARequestAsync("DeleteFile", "2020-04-14", "HTTPS", "DELETE", "AK", "/api/v3/projects/" + ProjectId + "/repository/files", "json", req, runtime));
        }

        public DeleteGroupMemberResponse DeleteGroupMember(string GroupId, string UserId, DeleteGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteGroupMemberWithOptions(GroupId, UserId, request, headers, runtime);
        }

        public async Task<DeleteGroupMemberResponse> DeleteGroupMemberAsync(string GroupId, string UserId, DeleteGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteGroupMemberWithOptionsAsync(GroupId, UserId, request, headers, runtime);
        }

        public DeleteGroupMemberResponse DeleteGroupMemberWithOptions(string GroupId, string UserId, DeleteGroupMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteGroupMemberResponse>(DoROARequest("DeleteGroupMember", "2020-04-14", "HTTPS", "DELETE", "AK", "/api/v3/groups/" + GroupId + "/members/{UserId}", "json", req, runtime));
        }

        public async Task<DeleteGroupMemberResponse> DeleteGroupMemberWithOptionsAsync(string GroupId, string UserId, DeleteGroupMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteGroupMemberResponse>(await DoROARequestAsync("DeleteGroupMember", "2020-04-14", "HTTPS", "DELETE", "AK", "/api/v3/groups/" + GroupId + "/members/{UserId}", "json", req, runtime));
        }

        public DeleteRepositoryResponse DeleteRepository(string ProjectId, DeleteRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRepositoryWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<DeleteRepositoryResponse> DeleteRepositoryAsync(string ProjectId, DeleteRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRepositoryWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public DeleteRepositoryResponse DeleteRepositoryWithOptions(string ProjectId, DeleteRepositoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteRepositoryResponse>(DoROARequest("DeleteRepository", "2020-04-14", "HTTPS", "POST", "AK", "/api/v3/projects/" + ProjectId + "/remove", "json", req, runtime));
        }

        public async Task<DeleteRepositoryResponse> DeleteRepositoryWithOptionsAsync(string ProjectId, DeleteRepositoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteRepositoryResponse>(await DoROARequestAsync("DeleteRepository", "2020-04-14", "HTTPS", "POST", "AK", "/api/v3/projects/" + ProjectId + "/remove", "json", req, runtime));
        }

        public DeleteRepositoryGroupResponse DeleteRepositoryGroup(string GroupId, DeleteRepositoryGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRepositoryGroupWithOptions(GroupId, request, headers, runtime);
        }

        public async Task<DeleteRepositoryGroupResponse> DeleteRepositoryGroupAsync(string GroupId, DeleteRepositoryGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRepositoryGroupWithOptionsAsync(GroupId, request, headers, runtime);
        }

        public DeleteRepositoryGroupResponse DeleteRepositoryGroupWithOptions(string GroupId, DeleteRepositoryGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteRepositoryGroupResponse>(DoROARequest("DeleteRepositoryGroup", "2020-04-14", "HTTPS", "POST", "AK", "/api/v3/groups/" + GroupId + "/remove", "json", req, runtime));
        }

        public async Task<DeleteRepositoryGroupResponse> DeleteRepositoryGroupWithOptionsAsync(string GroupId, DeleteRepositoryGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteRepositoryGroupResponse>(await DoROARequestAsync("DeleteRepositoryGroup", "2020-04-14", "HTTPS", "POST", "AK", "/api/v3/groups/" + GroupId + "/remove", "json", req, runtime));
        }

        public DeleteRepositoryMemberResponse DeleteRepositoryMember(string ProjectId, string UserId, DeleteRepositoryMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRepositoryMemberWithOptions(ProjectId, UserId, request, headers, runtime);
        }

        public async Task<DeleteRepositoryMemberResponse> DeleteRepositoryMemberAsync(string ProjectId, string UserId, DeleteRepositoryMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRepositoryMemberWithOptionsAsync(ProjectId, UserId, request, headers, runtime);
        }

        public DeleteRepositoryMemberResponse DeleteRepositoryMemberWithOptions(string ProjectId, string UserId, DeleteRepositoryMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteRepositoryMemberResponse>(DoROARequest("DeleteRepositoryMember", "2020-04-14", "HTTPS", "DELETE", "AK", "/api/v3/projects/" + ProjectId + "/members/{UserId}", "json", req, runtime));
        }

        public async Task<DeleteRepositoryMemberResponse> DeleteRepositoryMemberWithOptionsAsync(string ProjectId, string UserId, DeleteRepositoryMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteRepositoryMemberResponse>(await DoROARequestAsync("DeleteRepositoryMember", "2020-04-14", "HTTPS", "DELETE", "AK", "/api/v3/projects/" + ProjectId + "/members/{UserId}", "json", req, runtime));
        }

        public DeleteRepositoryTagResponse DeleteRepositoryTag(string ProjectId, string TagName, DeleteRepositoryTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRepositoryTagWithOptions(ProjectId, TagName, request, headers, runtime);
        }

        public async Task<DeleteRepositoryTagResponse> DeleteRepositoryTagAsync(string ProjectId, string TagName, DeleteRepositoryTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRepositoryTagWithOptionsAsync(ProjectId, TagName, request, headers, runtime);
        }

        public DeleteRepositoryTagResponse DeleteRepositoryTagWithOptions(string ProjectId, string TagName, DeleteRepositoryTagRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteRepositoryTagResponse>(DoROARequest("DeleteRepositoryTag", "2020-04-14", "HTTPS", "DELETE", "AK", "/api/v3/projects/" + ProjectId + "/repository/tags/{TagName}", "json", req, runtime));
        }

        public async Task<DeleteRepositoryTagResponse> DeleteRepositoryTagWithOptionsAsync(string ProjectId, string TagName, DeleteRepositoryTagRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteRepositoryTagResponse>(await DoROARequestAsync("DeleteRepositoryTag", "2020-04-14", "HTTPS", "DELETE", "AK", "/api/v3/projects/" + ProjectId + "/repository/tags/{TagName}", "json", req, runtime));
        }

        public DeleteRepositoryWebhookResponse DeleteRepositoryWebhook(string ProjectId, string WebhookId, DeleteRepositoryWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRepositoryWebhookWithOptions(ProjectId, WebhookId, request, headers, runtime);
        }

        public async Task<DeleteRepositoryWebhookResponse> DeleteRepositoryWebhookAsync(string ProjectId, string WebhookId, DeleteRepositoryWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRepositoryWebhookWithOptionsAsync(ProjectId, WebhookId, request, headers, runtime);
        }

        public DeleteRepositoryWebhookResponse DeleteRepositoryWebhookWithOptions(string ProjectId, string WebhookId, DeleteRepositoryWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteRepositoryWebhookResponse>(DoROARequest("DeleteRepositoryWebhook", "2020-04-14", "HTTPS", "DELETE", "AK", "/api/v3/projects/" + ProjectId + "/hooks/{WebhookId}", "json", req, runtime));
        }

        public async Task<DeleteRepositoryWebhookResponse> DeleteRepositoryWebhookWithOptionsAsync(string ProjectId, string WebhookId, DeleteRepositoryWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteRepositoryWebhookResponse>(await DoROARequestAsync("DeleteRepositoryWebhook", "2020-04-14", "HTTPS", "DELETE", "AK", "/api/v3/projects/" + ProjectId + "/hooks/{WebhookId}", "json", req, runtime));
        }

        public GetBranchInfoResponse GetBranchInfo(string ProjectId, GetBranchInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetBranchInfoWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<GetBranchInfoResponse> GetBranchInfoAsync(string ProjectId, GetBranchInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetBranchInfoWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public GetBranchInfoResponse GetBranchInfoWithOptions(string ProjectId, GetBranchInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetBranchInfoResponse>(DoROARequest("GetBranchInfo", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/projects/" + ProjectId + "/repository/branches/detail", "json", req, runtime));
        }

        public async Task<GetBranchInfoResponse> GetBranchInfoWithOptionsAsync(string ProjectId, GetBranchInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetBranchInfoResponse>(await DoROARequestAsync("GetBranchInfo", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/projects/" + ProjectId + "/repository/branches/detail", "json", req, runtime));
        }

        public GetCodeupOrganizationResponse GetCodeupOrganization(string OrganizationIdentity, GetCodeupOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCodeupOrganizationWithOptions(OrganizationIdentity, request, headers, runtime);
        }

        public async Task<GetCodeupOrganizationResponse> GetCodeupOrganizationAsync(string OrganizationIdentity, GetCodeupOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCodeupOrganizationWithOptionsAsync(OrganizationIdentity, request, headers, runtime);
        }

        public GetCodeupOrganizationResponse GetCodeupOrganizationWithOptions(string OrganizationIdentity, GetCodeupOrganizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetCodeupOrganizationResponse>(DoROARequest("GetCodeupOrganization", "2020-04-14", "HTTPS", "GET", "AK", "/api/v4/organization/" + OrganizationIdentity, "json", req, runtime));
        }

        public async Task<GetCodeupOrganizationResponse> GetCodeupOrganizationWithOptionsAsync(string OrganizationIdentity, GetCodeupOrganizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetCodeupOrganizationResponse>(await DoROARequestAsync("GetCodeupOrganization", "2020-04-14", "HTTPS", "GET", "AK", "/api/v4/organization/" + OrganizationIdentity, "json", req, runtime));
        }

        public GetFileBlobsResponse GetFileBlobs(string ProjectId, GetFileBlobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFileBlobsWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<GetFileBlobsResponse> GetFileBlobsAsync(string ProjectId, GetFileBlobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFileBlobsWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public GetFileBlobsResponse GetFileBlobsWithOptions(string ProjectId, GetFileBlobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ref))
            {
                query["Ref"] = request.Ref;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["To"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetFileBlobsResponse>(DoROARequest("GetFileBlobs", "2020-04-14", "HTTPS", "GET", "AK", "/api/v4/projects/" + ProjectId + "/repository/blobs", "json", req, runtime));
        }

        public async Task<GetFileBlobsResponse> GetFileBlobsWithOptionsAsync(string ProjectId, GetFileBlobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ref))
            {
                query["Ref"] = request.Ref;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["To"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetFileBlobsResponse>(await DoROARequestAsync("GetFileBlobs", "2020-04-14", "HTTPS", "GET", "AK", "/api/v4/projects/" + ProjectId + "/repository/blobs", "json", req, runtime));
        }

        public GetGroupDetailResponse GetGroupDetail(GetGroupDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGroupDetailWithOptions(request, headers, runtime);
        }

        public async Task<GetGroupDetailResponse> GetGroupDetailAsync(GetGroupDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGroupDetailWithOptionsAsync(request, headers, runtime);
        }

        public GetGroupDetailResponse GetGroupDetailWithOptions(GetGroupDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetGroupDetailResponse>(DoROARequest("GetGroupDetail", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/groups/detail", "json", req, runtime));
        }

        public async Task<GetGroupDetailResponse> GetGroupDetailWithOptionsAsync(GetGroupDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetGroupDetailResponse>(await DoROARequestAsync("GetGroupDetail", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/groups/detail", "json", req, runtime));
        }

        public GetProjectMemberResponse GetProjectMember(string ProjectId, string UserId, GetProjectMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProjectMemberWithOptions(ProjectId, UserId, request, headers, runtime);
        }

        public async Task<GetProjectMemberResponse> GetProjectMemberAsync(string ProjectId, string UserId, GetProjectMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProjectMemberWithOptionsAsync(ProjectId, UserId, request, headers, runtime);
        }

        public GetProjectMemberResponse GetProjectMemberWithOptions(string ProjectId, string UserId, GetProjectMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetProjectMemberResponse>(DoROARequest("GetProjectMember", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/projects/" + ProjectId + "/members/{UserId}", "json", req, runtime));
        }

        public async Task<GetProjectMemberResponse> GetProjectMemberWithOptionsAsync(string ProjectId, string UserId, GetProjectMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetProjectMemberResponse>(await DoROARequestAsync("GetProjectMember", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/projects/" + ProjectId + "/members/{UserId}", "json", req, runtime));
        }

        public GetRepositoryInfoResponse GetRepositoryInfo(GetRepositoryInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRepositoryInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetRepositoryInfoResponse> GetRepositoryInfoAsync(GetRepositoryInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRepositoryInfoWithOptionsAsync(request, headers, runtime);
        }

        public GetRepositoryInfoResponse GetRepositoryInfoWithOptions(GetRepositoryInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                query["Identity"] = request.Identity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetRepositoryInfoResponse>(DoROARequest("GetRepositoryInfo", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/projects/info", "json", req, runtime));
        }

        public async Task<GetRepositoryInfoResponse> GetRepositoryInfoWithOptionsAsync(GetRepositoryInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                query["Identity"] = request.Identity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetRepositoryInfoResponse>(await DoROARequestAsync("GetRepositoryInfo", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/projects/info", "json", req, runtime));
        }

        public GetRepositoryTagResponse GetRepositoryTag(string ProjectId, string TagName, GetRepositoryTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRepositoryTagWithOptions(ProjectId, TagName, request, headers, runtime);
        }

        public async Task<GetRepositoryTagResponse> GetRepositoryTagAsync(string ProjectId, string TagName, GetRepositoryTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRepositoryTagWithOptionsAsync(ProjectId, TagName, request, headers, runtime);
        }

        public GetRepositoryTagResponse GetRepositoryTagWithOptions(string ProjectId, string TagName, GetRepositoryTagRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetRepositoryTagResponse>(DoROARequest("GetRepositoryTag", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/projects/" + ProjectId + "/repository/tags/{TagName}", "json", req, runtime));
        }

        public async Task<GetRepositoryTagResponse> GetRepositoryTagWithOptionsAsync(string ProjectId, string TagName, GetRepositoryTagRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetRepositoryTagResponse>(await DoROARequestAsync("GetRepositoryTag", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/projects/" + ProjectId + "/repository/tags/{TagName}", "json", req, runtime));
        }

        public GetUserInfoResponse GetUserInfo(GetUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetUserInfoResponse> GetUserInfoAsync(GetUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserInfoWithOptionsAsync(request, headers, runtime);
        }

        public GetUserInfoResponse GetUserInfoWithOptions(GetUserInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetUserInfoResponse>(DoROARequest("GetUserInfo", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/user/current", "json", req, runtime));
        }

        public async Task<GetUserInfoResponse> GetUserInfoWithOptionsAsync(GetUserInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetUserInfoResponse>(await DoROARequestAsync("GetUserInfo", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/user/current", "json", req, runtime));
        }

        public ListGroupMemberResponse ListGroupMember(string GroupId, ListGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGroupMemberWithOptions(GroupId, request, headers, runtime);
        }

        public async Task<ListGroupMemberResponse> ListGroupMemberAsync(string GroupId, ListGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGroupMemberWithOptionsAsync(GroupId, request, headers, runtime);
        }

        public ListGroupMemberResponse ListGroupMemberWithOptions(string GroupId, ListGroupMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListGroupMemberResponse>(DoROARequest("ListGroupMember", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/groups/" + GroupId + "/members", "json", req, runtime));
        }

        public async Task<ListGroupMemberResponse> ListGroupMemberWithOptionsAsync(string GroupId, ListGroupMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListGroupMemberResponse>(await DoROARequestAsync("ListGroupMember", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/groups/" + GroupId + "/members", "json", req, runtime));
        }

        public ListGroupRepositoriesResponse ListGroupRepositories(string Identity, ListGroupRepositoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGroupRepositoriesWithOptions(Identity, request, headers, runtime);
        }

        public async Task<ListGroupRepositoriesResponse> ListGroupRepositoriesAsync(string Identity, ListGroupRepositoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGroupRepositoriesWithOptionsAsync(Identity, request, headers, runtime);
        }

        public ListGroupRepositoriesResponse ListGroupRepositoriesWithOptions(string Identity, ListGroupRepositoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsMember))
            {
                query["IsMember"] = request.IsMember;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListGroupRepositoriesResponse>(DoROARequest("ListGroupRepositories", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/groups/" + Identity + "/projects", "json", req, runtime));
        }

        public async Task<ListGroupRepositoriesResponse> ListGroupRepositoriesWithOptionsAsync(string Identity, ListGroupRepositoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsMember))
            {
                query["IsMember"] = request.IsMember;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListGroupRepositoriesResponse>(await DoROARequestAsync("ListGroupRepositories", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/groups/" + Identity + "/projects", "json", req, runtime));
        }

        public ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGroupsWithOptions(request, headers, runtime);
        }

        public async Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGroupsWithOptionsAsync(request, headers, runtime);
        }

        public ListGroupsResponse ListGroupsWithOptions(ListGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludePersonal))
            {
                query["IncludePersonal"] = request.IncludePersonal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListGroupsResponse>(DoROARequest("ListGroups", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/groups/all", "json", req, runtime));
        }

        public async Task<ListGroupsResponse> ListGroupsWithOptionsAsync(ListGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludePersonal))
            {
                query["IncludePersonal"] = request.IncludePersonal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListGroupsResponse>(await DoROARequestAsync("ListGroups", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/groups/all", "json", req, runtime));
        }

        public ListOrganizationsResponse ListOrganizations(ListOrganizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListOrganizationsWithOptions(request, headers, runtime);
        }

        public async Task<ListOrganizationsResponse> ListOrganizationsAsync(ListOrganizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListOrganizationsWithOptionsAsync(request, headers, runtime);
        }

        public ListOrganizationsResponse ListOrganizationsWithOptions(ListOrganizationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLevel))
            {
                query["AccessLevel"] = request.AccessLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinAccessLevel))
            {
                query["MinAccessLevel"] = request.MinAccessLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListOrganizationsResponse>(DoROARequest("ListOrganizations", "2020-04-14", "HTTPS", "GET", "AK", "/api/v4/organization", "json", req, runtime));
        }

        public async Task<ListOrganizationsResponse> ListOrganizationsWithOptionsAsync(ListOrganizationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLevel))
            {
                query["AccessLevel"] = request.AccessLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinAccessLevel))
            {
                query["MinAccessLevel"] = request.MinAccessLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListOrganizationsResponse>(await DoROARequestAsync("ListOrganizations", "2020-04-14", "HTTPS", "GET", "AK", "/api/v4/organization", "json", req, runtime));
        }

        public ListRepositoriesResponse ListRepositories(ListRepositoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRepositoriesWithOptions(request, headers, runtime);
        }

        public async Task<ListRepositoriesResponse> ListRepositoriesAsync(ListRepositoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRepositoriesWithOptionsAsync(request, headers, runtime);
        }

        public ListRepositoriesResponse ListRepositoriesWithOptions(ListRepositoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Archive))
            {
                query["Archive"] = request.Archive;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListRepositoriesResponse>(DoROARequest("ListRepositories", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/projects/all", "json", req, runtime));
        }

        public async Task<ListRepositoriesResponse> ListRepositoriesWithOptionsAsync(ListRepositoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Archive))
            {
                query["Archive"] = request.Archive;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListRepositoriesResponse>(await DoROARequestAsync("ListRepositories", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/projects/all", "json", req, runtime));
        }

        public ListRepositoryBranchesResponse ListRepositoryBranches(string ProjectId, ListRepositoryBranchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRepositoryBranchesWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<ListRepositoryBranchesResponse> ListRepositoryBranchesAsync(string ProjectId, ListRepositoryBranchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRepositoryBranchesWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public ListRepositoryBranchesResponse ListRepositoryBranchesWithOptions(string ProjectId, ListRepositoryBranchesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListRepositoryBranchesResponse>(DoROARequest("ListRepositoryBranches", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/projects/" + ProjectId + "/repository/branches", "json", req, runtime));
        }

        public async Task<ListRepositoryBranchesResponse> ListRepositoryBranchesWithOptionsAsync(string ProjectId, ListRepositoryBranchesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListRepositoryBranchesResponse>(await DoROARequestAsync("ListRepositoryBranches", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/projects/" + ProjectId + "/repository/branches", "json", req, runtime));
        }

        public ListRepositoryMemberResponse ListRepositoryMember(string ProjectId, ListRepositoryMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRepositoryMemberWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<ListRepositoryMemberResponse> ListRepositoryMemberAsync(string ProjectId, ListRepositoryMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRepositoryMemberWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public ListRepositoryMemberResponse ListRepositoryMemberWithOptions(string ProjectId, ListRepositoryMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListRepositoryMemberResponse>(DoROARequest("ListRepositoryMember", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/projects/" + ProjectId + "/members", "json", req, runtime));
        }

        public async Task<ListRepositoryMemberResponse> ListRepositoryMemberWithOptionsAsync(string ProjectId, ListRepositoryMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListRepositoryMemberResponse>(await DoROARequestAsync("ListRepositoryMember", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/projects/" + ProjectId + "/members", "json", req, runtime));
        }

        public ListRepositoryTagsResponse ListRepositoryTags(string ProjectId, ListRepositoryTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRepositoryTagsWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<ListRepositoryTagsResponse> ListRepositoryTagsAsync(string ProjectId, ListRepositoryTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRepositoryTagsWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public ListRepositoryTagsResponse ListRepositoryTagsWithOptions(string ProjectId, ListRepositoryTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSignature))
            {
                query["ShowSignature"] = request.ShowSignature;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListRepositoryTagsResponse>(DoROARequest("ListRepositoryTags", "2020-04-14", "HTTPS", "GET", "AK", "/api/v4/projects/" + ProjectId + "/repository/tags", "json", req, runtime));
        }

        public async Task<ListRepositoryTagsResponse> ListRepositoryTagsWithOptionsAsync(string ProjectId, ListRepositoryTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSignature))
            {
                query["ShowSignature"] = request.ShowSignature;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListRepositoryTagsResponse>(await DoROARequestAsync("ListRepositoryTags", "2020-04-14", "HTTPS", "GET", "AK", "/api/v4/projects/" + ProjectId + "/repository/tags", "json", req, runtime));
        }

        public ListRepositoryTreeResponse ListRepositoryTree(string ProjectId, ListRepositoryTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRepositoryTreeWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<ListRepositoryTreeResponse> ListRepositoryTreeAsync(string ProjectId, ListRepositoryTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRepositoryTreeWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public ListRepositoryTreeResponse ListRepositoryTreeWithOptions(string ProjectId, ListRepositoryTreeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefName))
            {
                query["RefName"] = request.RefName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListRepositoryTreeResponse>(DoROARequest("ListRepositoryTree", "2020-04-14", "HTTPS", "GET", "AK", "/api/v4/projects/" + ProjectId + "/repository/tree", "json", req, runtime));
        }

        public async Task<ListRepositoryTreeResponse> ListRepositoryTreeWithOptionsAsync(string ProjectId, ListRepositoryTreeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefName))
            {
                query["RefName"] = request.RefName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListRepositoryTreeResponse>(await DoROARequestAsync("ListRepositoryTree", "2020-04-14", "HTTPS", "GET", "AK", "/api/v4/projects/" + ProjectId + "/repository/tree", "json", req, runtime));
        }

        public ListRepositoryWebhookResponse ListRepositoryWebhook(string ProjectId, ListRepositoryWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRepositoryWebhookWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<ListRepositoryWebhookResponse> ListRepositoryWebhookAsync(string ProjectId, ListRepositoryWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRepositoryWebhookWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public ListRepositoryWebhookResponse ListRepositoryWebhookWithOptions(string ProjectId, ListRepositoryWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListRepositoryWebhookResponse>(DoROARequest("ListRepositoryWebhook", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/projects/" + ProjectId + "/hooks", "json", req, runtime));
        }

        public async Task<ListRepositoryWebhookResponse> ListRepositoryWebhookWithOptionsAsync(string ProjectId, ListRepositoryWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListRepositoryWebhookResponse>(await DoROARequestAsync("ListRepositoryWebhook", "2020-04-14", "HTTPS", "GET", "AK", "/api/v3/projects/" + ProjectId + "/hooks", "json", req, runtime));
        }

        public MergeMergeRequestResponse MergeMergeRequest(string ProjectId, string MergeRequestId, MergeMergeRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return MergeMergeRequestWithOptions(ProjectId, MergeRequestId, request, headers, runtime);
        }

        public async Task<MergeMergeRequestResponse> MergeMergeRequestAsync(string ProjectId, string MergeRequestId, MergeMergeRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await MergeMergeRequestWithOptionsAsync(ProjectId, MergeRequestId, request, headers, runtime);
        }

        public MergeMergeRequestResponse MergeMergeRequestWithOptions(string ProjectId, string MergeRequestId, MergeMergeRequestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<MergeMergeRequestResponse>(DoROARequest("MergeMergeRequest", "2020-04-14", "HTTPS", "PUT", "AK", "/api/v3/projects/" + ProjectId + "/mergeRequest/{MergeRequestId}/merge", "json", req, runtime));
        }

        public async Task<MergeMergeRequestResponse> MergeMergeRequestWithOptionsAsync(string ProjectId, string MergeRequestId, MergeMergeRequestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<MergeMergeRequestResponse>(await DoROARequestAsync("MergeMergeRequest", "2020-04-14", "HTTPS", "PUT", "AK", "/api/v3/projects/" + ProjectId + "/mergeRequest/{MergeRequestId}/merge", "json", req, runtime));
        }

        public UpdateFileResponse UpdateFile(string ProjectId, UpdateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFileWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<UpdateFileResponse> UpdateFileAsync(string ProjectId, UpdateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFileWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public UpdateFileResponse UpdateFileWithOptions(string ProjectId, UpdateFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateFileResponse>(DoROARequest("UpdateFile", "2020-04-14", "HTTPS", "PUT", "AK", "/api/v4/projects/" + ProjectId + "/repository/files", "json", req, runtime));
        }

        public async Task<UpdateFileResponse> UpdateFileWithOptionsAsync(string ProjectId, UpdateFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateFileResponse>(await DoROARequestAsync("UpdateFile", "2020-04-14", "HTTPS", "PUT", "AK", "/api/v4/projects/" + ProjectId + "/repository/files", "json", req, runtime));
        }

        public UpdateGroupMemberResponse UpdateGroupMember(string GroupId, string UserId, UpdateGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateGroupMemberWithOptions(GroupId, UserId, request, headers, runtime);
        }

        public async Task<UpdateGroupMemberResponse> UpdateGroupMemberAsync(string GroupId, string UserId, UpdateGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateGroupMemberWithOptionsAsync(GroupId, UserId, request, headers, runtime);
        }

        public UpdateGroupMemberResponse UpdateGroupMemberWithOptions(string GroupId, string UserId, UpdateGroupMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateGroupMemberResponse>(DoROARequest("UpdateGroupMember", "2020-04-14", "HTTPS", "PUT", "AK", "/api/v3/groups/" + GroupId + "/members/{UserId}", "json", req, runtime));
        }

        public async Task<UpdateGroupMemberResponse> UpdateGroupMemberWithOptionsAsync(string GroupId, string UserId, UpdateGroupMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateGroupMemberResponse>(await DoROARequestAsync("UpdateGroupMember", "2020-04-14", "HTTPS", "PUT", "AK", "/api/v3/groups/" + GroupId + "/members/{UserId}", "json", req, runtime));
        }

        public UpdateRepositoryMemberResponse UpdateRepositoryMember(string ProjectId, string UserId, UpdateRepositoryMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateRepositoryMemberWithOptions(ProjectId, UserId, request, headers, runtime);
        }

        public async Task<UpdateRepositoryMemberResponse> UpdateRepositoryMemberAsync(string ProjectId, string UserId, UpdateRepositoryMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateRepositoryMemberWithOptionsAsync(ProjectId, UserId, request, headers, runtime);
        }

        public UpdateRepositoryMemberResponse UpdateRepositoryMemberWithOptions(string ProjectId, string UserId, UpdateRepositoryMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateRepositoryMemberResponse>(DoROARequest("UpdateRepositoryMember", "2020-04-14", "HTTPS", "PUT", "AK", "/api/v3/projects/" + ProjectId + "/members/{UserId}", "json", req, runtime));
        }

        public async Task<UpdateRepositoryMemberResponse> UpdateRepositoryMemberWithOptionsAsync(string ProjectId, string UserId, UpdateRepositoryMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateRepositoryMemberResponse>(await DoROARequestAsync("UpdateRepositoryMember", "2020-04-14", "HTTPS", "PUT", "AK", "/api/v3/projects/" + ProjectId + "/members/{UserId}", "json", req, runtime));
        }

    }
}
