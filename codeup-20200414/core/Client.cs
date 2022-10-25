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
            this._signatureAlgorithm = "v2";
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

        public AcceptMergeRequestResponse AcceptMergeRequest(string ProjectId, string MergeRequestId, AcceptMergeRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AcceptMergeRequestWithOptions(ProjectId, MergeRequestId, request, headers, runtime);
        }

        public async Task<AcceptMergeRequestResponse> AcceptMergeRequestAsync(string ProjectId, string MergeRequestId, AcceptMergeRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AcceptMergeRequestWithOptionsAsync(ProjectId, MergeRequestId, request, headers, runtime);
        }

        public AcceptMergeRequestResponse AcceptMergeRequestWithOptions(string ProjectId, string MergeRequestId, AcceptMergeRequestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AcceptMergeRequest",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/merge_request/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MergeRequestId) + "/accept",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcceptMergeRequestResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AcceptMergeRequestResponse> AcceptMergeRequestWithOptionsAsync(string ProjectId, string MergeRequestId, AcceptMergeRequestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AcceptMergeRequest",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/merge_request/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MergeRequestId) + "/accept",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcceptMergeRequestResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddGroupMember",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GroupId) + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGroupMemberResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddGroupMember",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GroupId) + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGroupMemberResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddRepositoryMember",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRepositoryMemberResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddRepositoryMember",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRepositoryMemberResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddWebhook",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/hooks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddWebhookResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddWebhook",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/hooks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddWebhookResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                body["branchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ref))
            {
                body["ref"] = request.Ref;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBranch",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/branches",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBranchResponse>(CallApi(params_, req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                body["branchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ref))
            {
                body["ref"] = request.Ref;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBranch",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/branches",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBranchResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFile",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/files",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFileResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFile",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/files",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFileResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMergeRequest",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/merge_requests",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMergeRequestResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMergeRequest",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/merge_requests",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMergeRequestResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateMergeRequestCommentResponse CreateMergeRequestComment(string ProjectId, string MergeRequestId, CreateMergeRequestCommentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMergeRequestCommentWithOptions(ProjectId, MergeRequestId, request, headers, runtime);
        }

        public async Task<CreateMergeRequestCommentResponse> CreateMergeRequestCommentAsync(string ProjectId, string MergeRequestId, CreateMergeRequestCommentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMergeRequestCommentWithOptionsAsync(ProjectId, MergeRequestId, request, headers, runtime);
        }

        public CreateMergeRequestCommentResponse CreateMergeRequestCommentWithOptions(string ProjectId, string MergeRequestId, CreateMergeRequestCommentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMergeRequestComment",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/merge_request/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MergeRequestId) + "/comments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMergeRequestCommentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateMergeRequestCommentResponse> CreateMergeRequestCommentWithOptionsAsync(string ProjectId, string MergeRequestId, CreateMergeRequestCommentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMergeRequestComment",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/merge_request/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MergeRequestId) + "/comments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMergeRequestCommentResponse>(await CallApiAsync(params_, req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sync))
            {
                query["Sync"] = request.Sync;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarUrl))
            {
                body["avatarUrl"] = request.AvatarUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GitignoreType))
            {
                body["gitignoreType"] = request.GitignoreType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportAccount))
            {
                body["importAccount"] = request.ImportAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportDemoProject))
            {
                body["importDemoProject"] = request.ImportDemoProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportRepoType))
            {
                body["importRepoType"] = request.ImportRepoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportToken))
            {
                body["importToken"] = request.ImportToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportTokenEncrypted))
            {
                body["importTokenEncrypted"] = request.ImportTokenEncrypted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportUrl))
            {
                body["importUrl"] = request.ImportUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitStandardService))
            {
                body["initStandardService"] = request.InitStandardService;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCryptoEnabled))
            {
                body["isCryptoEnabled"] = request.IsCryptoEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalImportUrl))
            {
                body["localImportUrl"] = request.LocalImportUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                body["namespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadmeType))
            {
                body["readmeType"] = request.ReadmeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisibilityLevel))
            {
                body["visibilityLevel"] = request.VisibilityLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepository",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepositoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateRepositoryResponse> CreateRepositoryWithOptionsAsync(CreateRepositoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sync))
            {
                query["Sync"] = request.Sync;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvatarUrl))
            {
                body["avatarUrl"] = request.AvatarUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GitignoreType))
            {
                body["gitignoreType"] = request.GitignoreType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportAccount))
            {
                body["importAccount"] = request.ImportAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportDemoProject))
            {
                body["importDemoProject"] = request.ImportDemoProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportRepoType))
            {
                body["importRepoType"] = request.ImportRepoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportToken))
            {
                body["importToken"] = request.ImportToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportTokenEncrypted))
            {
                body["importTokenEncrypted"] = request.ImportTokenEncrypted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportUrl))
            {
                body["importUrl"] = request.ImportUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitStandardService))
            {
                body["initStandardService"] = request.InitStandardService;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCryptoEnabled))
            {
                body["isCryptoEnabled"] = request.IsCryptoEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalImportUrl))
            {
                body["localImportUrl"] = request.LocalImportUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                body["namespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadmeType))
            {
                body["readmeType"] = request.ReadmeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisibilityLevel))
            {
                body["visibilityLevel"] = request.VisibilityLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepository",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepositoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateRepositoryDeployKeyResponse CreateRepositoryDeployKey(string ProjectId, CreateRepositoryDeployKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRepositoryDeployKeyWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<CreateRepositoryDeployKeyResponse> CreateRepositoryDeployKeyAsync(string ProjectId, CreateRepositoryDeployKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRepositoryDeployKeyWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public CreateRepositoryDeployKeyResponse CreateRepositoryDeployKeyWithOptions(string ProjectId, CreateRepositoryDeployKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepositoryDeployKey",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/keys",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepositoryDeployKeyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateRepositoryDeployKeyResponse> CreateRepositoryDeployKeyWithOptionsAsync(string ProjectId, CreateRepositoryDeployKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepositoryDeployKey",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/keys",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepositoryDeployKeyResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepositoryGroup",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepositoryGroupResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepositoryGroup",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepositoryGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateRepositoryProtectedBranchResponse CreateRepositoryProtectedBranch(string ProjectId, CreateRepositoryProtectedBranchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRepositoryProtectedBranchWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<CreateRepositoryProtectedBranchResponse> CreateRepositoryProtectedBranchAsync(string ProjectId, CreateRepositoryProtectedBranchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRepositoryProtectedBranchWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public CreateRepositoryProtectedBranchResponse CreateRepositoryProtectedBranchWithOptions(string ProjectId, CreateRepositoryProtectedBranchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepositoryProtectedBranch",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/protect_branches",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepositoryProtectedBranchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateRepositoryProtectedBranchResponse> CreateRepositoryProtectedBranchWithOptionsAsync(string ProjectId, CreateRepositoryProtectedBranchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRepositoryProtectedBranch",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/protect_branches",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepositoryProtectedBranchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateSshKeyResponse CreateSshKey(CreateSshKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSshKeyWithOptions(request, headers, runtime);
        }

        public async Task<CreateSshKeyResponse> CreateSshKeyAsync(CreateSshKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSshKeyWithOptionsAsync(request, headers, runtime);
        }

        public CreateSshKeyResponse CreateSshKeyWithOptions(CreateSshKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSshKey",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/user/keys",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSshKeyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSshKeyResponse> CreateSshKeyWithOptionsAsync(CreateSshKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSshKey",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/user/keys",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSshKeyResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTag",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTagResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTag",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTagResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBranch",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/branches/delete",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBranchResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBranch",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/branches/delete",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBranchResponse>(await CallApiAsync(params_, req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommitMessage))
            {
                query["CommitMessage"] = request.CommitMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFile",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/files",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFileResponse> DeleteFileWithOptionsAsync(string ProjectId, DeleteFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommitMessage))
            {
                query["CommitMessage"] = request.CommitMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFile",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/files",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFileResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroupMember",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GroupId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(UserId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupMemberResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroupMember",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GroupId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(UserId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupMemberResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepository",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepositoryResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepository",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepositoryResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepositoryGroup",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GroupId) + "/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepositoryGroupResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepositoryGroup",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GroupId) + "/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepositoryGroupResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepositoryMember",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(UserId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepositoryMemberResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepositoryMember",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(UserId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepositoryMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteRepositoryMemberWithExternUidResponse DeleteRepositoryMemberWithExternUid(string ProjectId, DeleteRepositoryMemberWithExternUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRepositoryMemberWithExternUidWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<DeleteRepositoryMemberWithExternUidResponse> DeleteRepositoryMemberWithExternUidAsync(string ProjectId, DeleteRepositoryMemberWithExternUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRepositoryMemberWithExternUidWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public DeleteRepositoryMemberWithExternUidResponse DeleteRepositoryMemberWithExternUidWithOptions(string ProjectId, DeleteRepositoryMemberWithExternUidRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternUserId))
            {
                query["ExternUserId"] = request.ExternUserId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepositoryMemberWithExternUid",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/members/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepositoryMemberWithExternUidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteRepositoryMemberWithExternUidResponse> DeleteRepositoryMemberWithExternUidWithOptionsAsync(string ProjectId, DeleteRepositoryMemberWithExternUidRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternUserId))
            {
                query["ExternUserId"] = request.ExternUserId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepositoryMemberWithExternUid",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/members/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepositoryMemberWithExternUidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteRepositoryProtectedBranchResponse DeleteRepositoryProtectedBranch(string ProjectId, string ProtectedBranchId, DeleteRepositoryProtectedBranchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRepositoryProtectedBranchWithOptions(ProjectId, ProtectedBranchId, request, headers, runtime);
        }

        public async Task<DeleteRepositoryProtectedBranchResponse> DeleteRepositoryProtectedBranchAsync(string ProjectId, string ProtectedBranchId, DeleteRepositoryProtectedBranchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRepositoryProtectedBranchWithOptionsAsync(ProjectId, ProtectedBranchId, request, headers, runtime);
        }

        public DeleteRepositoryProtectedBranchResponse DeleteRepositoryProtectedBranchWithOptions(string ProjectId, string ProtectedBranchId, DeleteRepositoryProtectedBranchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepositoryProtectedBranch",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/protect_branches/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProtectedBranchId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepositoryProtectedBranchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteRepositoryProtectedBranchResponse> DeleteRepositoryProtectedBranchWithOptionsAsync(string ProjectId, string ProtectedBranchId, DeleteRepositoryProtectedBranchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepositoryProtectedBranch",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/protect_branches/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProtectedBranchId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepositoryProtectedBranchResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepositoryTag",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/tags/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TagName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepositoryTagResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepositoryTag",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/tags/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TagName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepositoryTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteRepositoryTagV2Response DeleteRepositoryTagV2(string ProjectId, DeleteRepositoryTagV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRepositoryTagV2WithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<DeleteRepositoryTagV2Response> DeleteRepositoryTagV2Async(string ProjectId, DeleteRepositoryTagV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRepositoryTagV2WithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public DeleteRepositoryTagV2Response DeleteRepositoryTagV2WithOptions(string ProjectId, DeleteRepositoryTagV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepositoryTagV2",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/tag/delete",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepositoryTagV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteRepositoryTagV2Response> DeleteRepositoryTagV2WithOptionsAsync(string ProjectId, DeleteRepositoryTagV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepositoryTagV2",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/tag/delete",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepositoryTagV2Response>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepositoryWebhook",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/hooks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WebhookId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepositoryWebhookResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepositoryWebhook",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/hooks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WebhookId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepositoryWebhookResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableRepositoryDeployKeyResponse EnableRepositoryDeployKey(string ProjectId, string KeyId, EnableRepositoryDeployKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableRepositoryDeployKeyWithOptions(ProjectId, KeyId, request, headers, runtime);
        }

        public async Task<EnableRepositoryDeployKeyResponse> EnableRepositoryDeployKeyAsync(string ProjectId, string KeyId, EnableRepositoryDeployKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableRepositoryDeployKeyWithOptionsAsync(ProjectId, KeyId, request, headers, runtime);
        }

        public EnableRepositoryDeployKeyResponse EnableRepositoryDeployKeyWithOptions(string ProjectId, string KeyId, EnableRepositoryDeployKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableRepositoryDeployKey",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/keys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KeyId) + "/enable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableRepositoryDeployKeyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableRepositoryDeployKeyResponse> EnableRepositoryDeployKeyWithOptionsAsync(string ProjectId, string KeyId, EnableRepositoryDeployKeyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableRepositoryDeployKey",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/keys/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(KeyId) + "/enable",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableRepositoryDeployKeyResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBranchInfo",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/branches/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBranchInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetBranchInfoResponse> GetBranchInfoWithOptionsAsync(string ProjectId, GetBranchInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBranchInfo",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/branches/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBranchInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetCodeCompletionResponse GetCodeCompletion(string ServiceName, GetCodeCompletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCodeCompletionWithOptions(ServiceName, request, headers, runtime);
        }

        public async Task<GetCodeCompletionResponse> GetCodeCompletionAsync(string ServiceName, GetCodeCompletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCodeCompletionWithOptionsAsync(ServiceName, request, headers, runtime);
        }

        public GetCodeCompletionResponse GetCodeCompletionWithOptions(string ServiceName, GetCodeCompletionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FetchKeys))
            {
                query["FetchKeys"] = request.FetchKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEncrypted))
            {
                query["IsEncrypted"] = request.IsEncrypted;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCodeCompletion",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v2/service/invoke/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName),
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCodeCompletionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCodeCompletionResponse> GetCodeCompletionWithOptionsAsync(string ServiceName, GetCodeCompletionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FetchKeys))
            {
                query["FetchKeys"] = request.FetchKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEncrypted))
            {
                query["IsEncrypted"] = request.IsEncrypted;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCodeCompletion",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v2/service/invoke/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName),
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCodeCompletionResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCodeupOrganization",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(OrganizationIdentity),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCodeupOrganizationResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCodeupOrganization",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(OrganizationIdentity),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCodeupOrganizationResponse>(await CallApiAsync(params_, req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ref))
            {
                query["Ref"] = request.Ref;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["To"] = request.To;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileBlobs",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/blobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileBlobsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFileBlobsResponse> GetFileBlobsWithOptionsAsync(string ProjectId, GetFileBlobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ref))
            {
                query["Ref"] = request.Ref;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["To"] = request.To;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileBlobs",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/blobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileBlobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetFileLastCommitResponse GetFileLastCommit(string ProjectId, GetFileLastCommitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFileLastCommitWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<GetFileLastCommitResponse> GetFileLastCommitAsync(string ProjectId, GetFileLastCommitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFileLastCommitWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public GetFileLastCommitResponse GetFileLastCommitWithOptions(string ProjectId, GetFileLastCommitRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sha))
            {
                query["Sha"] = request.Sha;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileLastCommit",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/files/last_commit",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileLastCommitResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFileLastCommitResponse> GetFileLastCommitWithOptionsAsync(string ProjectId, GetFileLastCommitRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sha))
            {
                query["Sha"] = request.Sha;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileLastCommit",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/files/last_commit",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileLastCommitResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGroupDetail",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/groups/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGroupDetailResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGroupDetail",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/groups/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGroupDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetMergeRequestApproveStatusResponse GetMergeRequestApproveStatus(string ProjectId, string MergeRequestId, GetMergeRequestApproveStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMergeRequestApproveStatusWithOptions(ProjectId, MergeRequestId, request, headers, runtime);
        }

        public async Task<GetMergeRequestApproveStatusResponse> GetMergeRequestApproveStatusAsync(string ProjectId, string MergeRequestId, GetMergeRequestApproveStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMergeRequestApproveStatusWithOptionsAsync(ProjectId, MergeRequestId, request, headers, runtime);
        }

        public GetMergeRequestApproveStatusResponse GetMergeRequestApproveStatusWithOptions(string ProjectId, string MergeRequestId, GetMergeRequestApproveStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMergeRequestApproveStatus",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/merge_request/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MergeRequestId) + "/approve_status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMergeRequestApproveStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetMergeRequestApproveStatusResponse> GetMergeRequestApproveStatusWithOptionsAsync(string ProjectId, string MergeRequestId, GetMergeRequestApproveStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMergeRequestApproveStatus",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/merge_request/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MergeRequestId) + "/approve_status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMergeRequestApproveStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetMergeRequestDetailResponse GetMergeRequestDetail(string ProjectId, string MergeRequestId, GetMergeRequestDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMergeRequestDetailWithOptions(ProjectId, MergeRequestId, request, headers, runtime);
        }

        public async Task<GetMergeRequestDetailResponse> GetMergeRequestDetailAsync(string ProjectId, string MergeRequestId, GetMergeRequestDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMergeRequestDetailWithOptionsAsync(ProjectId, MergeRequestId, request, headers, runtime);
        }

        public GetMergeRequestDetailResponse GetMergeRequestDetailWithOptions(string ProjectId, string MergeRequestId, GetMergeRequestDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMergeRequestDetail",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/merge_request/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MergeRequestId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMergeRequestDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetMergeRequestDetailResponse> GetMergeRequestDetailWithOptionsAsync(string ProjectId, string MergeRequestId, GetMergeRequestDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMergeRequestDetail",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/merge_request/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MergeRequestId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMergeRequestDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetMergeRequestSettingResponse GetMergeRequestSetting(string ProjectId, GetMergeRequestSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMergeRequestSettingWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<GetMergeRequestSettingResponse> GetMergeRequestSettingAsync(string ProjectId, GetMergeRequestSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMergeRequestSettingWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public GetMergeRequestSettingResponse GetMergeRequestSettingWithOptions(string ProjectId, GetMergeRequestSettingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMergeRequestSetting",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/settings/merge_requests",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMergeRequestSettingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetMergeRequestSettingResponse> GetMergeRequestSettingWithOptionsAsync(string ProjectId, GetMergeRequestSettingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMergeRequestSetting",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/settings/merge_requests",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMergeRequestSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetOrganizationRepositorySettingResponse GetOrganizationRepositorySetting(GetOrganizationRepositorySettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetOrganizationRepositorySettingWithOptions(request, headers, runtime);
        }

        public async Task<GetOrganizationRepositorySettingResponse> GetOrganizationRepositorySettingAsync(GetOrganizationRepositorySettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetOrganizationRepositorySettingWithOptionsAsync(request, headers, runtime);
        }

        public GetOrganizationRepositorySettingResponse GetOrganizationRepositorySettingWithOptions(GetOrganizationRepositorySettingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrganizationRepositorySetting",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/organization/settings/repo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizationRepositorySettingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetOrganizationRepositorySettingResponse> GetOrganizationRepositorySettingWithOptionsAsync(GetOrganizationRepositorySettingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrganizationRepositorySetting",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/organization/settings/repo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizationRepositorySettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetOrganizationSecurityCenterStatusResponse GetOrganizationSecurityCenterStatus(GetOrganizationSecurityCenterStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetOrganizationSecurityCenterStatusWithOptions(request, headers, runtime);
        }

        public async Task<GetOrganizationSecurityCenterStatusResponse> GetOrganizationSecurityCenterStatusAsync(GetOrganizationSecurityCenterStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetOrganizationSecurityCenterStatusWithOptionsAsync(request, headers, runtime);
        }

        public GetOrganizationSecurityCenterStatusResponse GetOrganizationSecurityCenterStatusWithOptions(GetOrganizationSecurityCenterStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrganizationSecurityCenterStatus",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/organization/security/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizationSecurityCenterStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetOrganizationSecurityCenterStatusResponse> GetOrganizationSecurityCenterStatusWithOptionsAsync(GetOrganizationSecurityCenterStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrganizationSecurityCenterStatus",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/organization/security/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizationSecurityCenterStatusResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProjectMember",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(UserId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectMemberResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProjectMember",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(UserId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRepositoryCommitResponse GetRepositoryCommit(string ProjectId, string Sha, GetRepositoryCommitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRepositoryCommitWithOptions(ProjectId, Sha, request, headers, runtime);
        }

        public async Task<GetRepositoryCommitResponse> GetRepositoryCommitAsync(string ProjectId, string Sha, GetRepositoryCommitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRepositoryCommitWithOptionsAsync(ProjectId, Sha, request, headers, runtime);
        }

        public GetRepositoryCommitResponse GetRepositoryCommitWithOptions(string ProjectId, string Sha, GetRepositoryCommitRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepositoryCommit",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/commits/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Sha),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepositoryCommitResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRepositoryCommitResponse> GetRepositoryCommitWithOptionsAsync(string ProjectId, string Sha, GetRepositoryCommitRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepositoryCommit",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/commits/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Sha),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepositoryCommitResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepositoryInfo",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/info",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepositoryInfoResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepositoryInfo",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/info",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepositoryInfoResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepositoryTag",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/tags/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TagName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepositoryTagResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepositoryTag",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/tags/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TagName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepositoryTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRepositoryTagV2Response GetRepositoryTagV2(string ProjectId, GetRepositoryTagV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRepositoryTagV2WithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<GetRepositoryTagV2Response> GetRepositoryTagV2Async(string ProjectId, GetRepositoryTagV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRepositoryTagV2WithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public GetRepositoryTagV2Response GetRepositoryTagV2WithOptions(string ProjectId, GetRepositoryTagV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepositoryTagV2",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/tag/info",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepositoryTagV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<GetRepositoryTagV2Response> GetRepositoryTagV2WithOptionsAsync(string ProjectId, GetRepositoryTagV2Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                query["TagName"] = request.TagName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepositoryTagV2",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/tag/info",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepositoryTagV2Response>(await CallApiAsync(params_, req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserInfo",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/user/current",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUserInfoResponse> GetUserInfoWithOptionsAsync(GetUserInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserInfo",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/user/current",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public IsSlsUserAuthrizedCodeupResponse IsSlsUserAuthrizedCodeup(IsSlsUserAuthrizedCodeupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return IsSlsUserAuthrizedCodeupWithOptions(request, headers, runtime);
        }

        public async Task<IsSlsUserAuthrizedCodeupResponse> IsSlsUserAuthrizedCodeupAsync(IsSlsUserAuthrizedCodeupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await IsSlsUserAuthrizedCodeupWithOptionsAsync(request, headers, runtime);
        }

        public IsSlsUserAuthrizedCodeupResponse IsSlsUserAuthrizedCodeupWithOptions(IsSlsUserAuthrizedCodeupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunSubUserId))
            {
                body["aliyunSubUserId"] = request.AliyunSubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunUserId))
            {
                body["aliyunUserId"] = request.AliyunUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeupProjectId))
            {
                body["codeupProjectId"] = request.CodeupProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsLogStore))
            {
                body["slsLogStore"] = request.SlsLogStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsProject))
            {
                body["slsProject"] = request.SlsProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IsSlsUserAuthrizedCodeup",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/repository/is_codeup_authrized",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<IsSlsUserAuthrizedCodeupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<IsSlsUserAuthrizedCodeupResponse> IsSlsUserAuthrizedCodeupWithOptionsAsync(IsSlsUserAuthrizedCodeupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunSubUserId))
            {
                body["aliyunSubUserId"] = request.AliyunSubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunUserId))
            {
                body["aliyunUserId"] = request.AliyunUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeupProjectId))
            {
                body["codeupProjectId"] = request.CodeupProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsLogStore))
            {
                body["slsLogStore"] = request.SlsLogStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsProject))
            {
                body["slsProject"] = request.SlsProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IsSlsUserAuthrizedCodeup",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/repository/is_codeup_authrized",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<IsSlsUserAuthrizedCodeupResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroupMember",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GroupId) + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupMemberResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroupMember",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GroupId) + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupMemberResponse>(await CallApiAsync(params_, req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsMember))
            {
                query["IsMember"] = request.IsMember;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroupRepositories",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Identity) + "/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupRepositoriesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListGroupRepositoriesResponse> ListGroupRepositoriesWithOptionsAsync(string Identity, ListGroupRepositoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsMember))
            {
                query["IsMember"] = request.IsMember;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroupRepositories",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Identity) + "/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupRepositoriesResponse>(await CallApiAsync(params_, req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludePersonal))
            {
                query["IncludePersonal"] = request.IncludePersonal;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroups",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/groups/all",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListGroupsResponse> ListGroupsWithOptionsAsync(ListGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludePersonal))
            {
                query["IncludePersonal"] = request.IncludePersonal;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroups",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/groups/all",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListMergeRequestCommentsResponse ListMergeRequestComments(string ProjectId, string MergeRequestId, ListMergeRequestCommentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMergeRequestCommentsWithOptions(ProjectId, MergeRequestId, request, headers, runtime);
        }

        public async Task<ListMergeRequestCommentsResponse> ListMergeRequestCommentsAsync(string ProjectId, string MergeRequestId, ListMergeRequestCommentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMergeRequestCommentsWithOptionsAsync(ProjectId, MergeRequestId, request, headers, runtime);
        }

        public ListMergeRequestCommentsResponse ListMergeRequestCommentsWithOptions(string ProjectId, string MergeRequestId, ListMergeRequestCommentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromCommit))
            {
                query["FromCommit"] = request.FromCommit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToCommit))
            {
                query["ToCommit"] = request.ToCommit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMergeRequestComments",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/merge_request/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MergeRequestId) + "/comments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMergeRequestCommentsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListMergeRequestCommentsResponse> ListMergeRequestCommentsWithOptionsAsync(string ProjectId, string MergeRequestId, ListMergeRequestCommentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromCommit))
            {
                query["FromCommit"] = request.FromCommit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToCommit))
            {
                query["ToCommit"] = request.ToCommit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMergeRequestComments",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/merge_request/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MergeRequestId) + "/comments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMergeRequestCommentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListMergeRequestsResponse ListMergeRequests(ListMergeRequestsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMergeRequestsWithOptions(request, headers, runtime);
        }

        public async Task<ListMergeRequestsResponse> ListMergeRequestsAsync(ListMergeRequestsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMergeRequestsWithOptionsAsync(request, headers, runtime);
        }

        public ListMergeRequestsResponse ListMergeRequestsWithOptions(ListMergeRequestsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AfterDate))
            {
                query["AfterDate"] = request.AfterDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssigneeCodeupIdList))
            {
                query["AssigneeCodeupIdList"] = request.AssigneeCodeupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssigneeIdList))
            {
                query["AssigneeIdList"] = request.AssigneeIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorCodeupIdList))
            {
                query["AuthorCodeupIdList"] = request.AuthorCodeupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorIdList))
            {
                query["AuthorIdList"] = request.AuthorIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeforeDate))
            {
                query["BeforeDate"] = request.BeforeDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIdList))
            {
                query["GroupIdList"] = request.GroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIdList))
            {
                query["ProjectIdList"] = request.ProjectIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriberCodeupIdList))
            {
                query["SubscriberCodeupIdList"] = request.SubscriberCodeupIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMergeRequests",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/merge_requests/advanced_search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMergeRequestsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListMergeRequestsResponse> ListMergeRequestsWithOptionsAsync(ListMergeRequestsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AfterDate))
            {
                query["AfterDate"] = request.AfterDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssigneeCodeupIdList))
            {
                query["AssigneeCodeupIdList"] = request.AssigneeCodeupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssigneeIdList))
            {
                query["AssigneeIdList"] = request.AssigneeIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorCodeupIdList))
            {
                query["AuthorCodeupIdList"] = request.AuthorCodeupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorIdList))
            {
                query["AuthorIdList"] = request.AuthorIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeforeDate))
            {
                query["BeforeDate"] = request.BeforeDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIdList))
            {
                query["GroupIdList"] = request.GroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIdList))
            {
                query["ProjectIdList"] = request.ProjectIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriberCodeupIdList))
            {
                query["SubscriberCodeupIdList"] = request.SubscriberCodeupIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMergeRequests",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/merge_requests/advanced_search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMergeRequestsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListOrganizationSecurityScoresResponse ListOrganizationSecurityScores(ListOrganizationSecurityScoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListOrganizationSecurityScoresWithOptions(request, headers, runtime);
        }

        public async Task<ListOrganizationSecurityScoresResponse> ListOrganizationSecurityScoresAsync(ListOrganizationSecurityScoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListOrganizationSecurityScoresWithOptionsAsync(request, headers, runtime);
        }

        public ListOrganizationSecurityScoresResponse ListOrganizationSecurityScoresWithOptions(ListOrganizationSecurityScoresRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrganizationSecurityScores",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/organization/security/scores",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrganizationSecurityScoresResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListOrganizationSecurityScoresResponse> ListOrganizationSecurityScoresWithOptionsAsync(ListOrganizationSecurityScoresRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrganizationSecurityScores",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/organization/security/scores",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrganizationSecurityScoresResponse>(await CallApiAsync(params_, req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLevel))
            {
                query["AccessLevel"] = request.AccessLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrganizations",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/organization",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrganizationsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListOrganizationsResponse> ListOrganizationsWithOptionsAsync(ListOrganizationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLevel))
            {
                query["AccessLevel"] = request.AccessLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrganizations",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/organization",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrganizationsResponse>(await CallApiAsync(params_, req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Archive))
            {
                query["Archive"] = request.Archive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositories",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/all",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoriesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRepositoriesResponse> ListRepositoriesWithOptionsAsync(ListRepositoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Archive))
            {
                query["Archive"] = request.Archive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositories",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/all",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoriesResponse>(await CallApiAsync(params_, req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryBranches",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/branches",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryBranchesResponse>(CallApi(params_, req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryBranches",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/branches",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryBranchesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRepositoryCodeResponse ListRepositoryCode(ListRepositoryCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRepositoryCodeWithOptions(request, headers, runtime);
        }

        public async Task<ListRepositoryCodeResponse> ListRepositoryCodeAsync(ListRepositoryCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRepositoryCodeWithOptionsAsync(request, headers, runtime);
        }

        public ListRepositoryCodeResponse ListRepositoryCodeWithOptions(ListRepositoryCodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath.ToMap()))
            {
                body["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCodeBlock))
            {
                body["IsCodeBlock"] = request.IsCodeBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                body["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepositoryPath.ToMap()))
            {
                body["RepositoryPath"] = request.RepositoryPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                body["Sort"] = request.Sort;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryCode",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/search/v3/code",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryCodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRepositoryCodeResponse> ListRepositoryCodeWithOptionsAsync(ListRepositoryCodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath.ToMap()))
            {
                body["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCodeBlock))
            {
                body["IsCodeBlock"] = request.IsCodeBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                body["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                body["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                body["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepositoryPath.ToMap()))
            {
                body["RepositoryPath"] = request.RepositoryPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                body["Sort"] = request.Sort;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryCode",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/search/v3/code",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRepositoryCommitDiffResponse ListRepositoryCommitDiff(string ProjectId, string Sha, ListRepositoryCommitDiffRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRepositoryCommitDiffWithOptions(ProjectId, Sha, request, headers, runtime);
        }

        public async Task<ListRepositoryCommitDiffResponse> ListRepositoryCommitDiffAsync(string ProjectId, string Sha, ListRepositoryCommitDiffRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRepositoryCommitDiffWithOptionsAsync(ProjectId, Sha, request, headers, runtime);
        }

        public ListRepositoryCommitDiffResponse ListRepositoryCommitDiffWithOptions(string ProjectId, string Sha, ListRepositoryCommitDiffRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextLine))
            {
                query["ContextLine"] = request.ContextLine;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryCommitDiff",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/commits/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Sha) + "/diff",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryCommitDiffResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRepositoryCommitDiffResponse> ListRepositoryCommitDiffWithOptionsAsync(string ProjectId, string Sha, ListRepositoryCommitDiffRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextLine))
            {
                query["ContextLine"] = request.ContextLine;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryCommitDiff",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/commits/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Sha) + "/diff",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryCommitDiffResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRepositoryCommitsResponse ListRepositoryCommits(string ProjectId, ListRepositoryCommitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRepositoryCommitsWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<ListRepositoryCommitsResponse> ListRepositoryCommitsAsync(string ProjectId, ListRepositoryCommitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRepositoryCommitsWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public ListRepositoryCommitsResponse ListRepositoryCommitsWithOptions(string ProjectId, ListRepositoryCommitsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefName))
            {
                query["RefName"] = request.RefName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryCommits",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/commits",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryCommitsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRepositoryCommitsResponse> ListRepositoryCommitsWithOptionsAsync(string ProjectId, ListRepositoryCommitsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefName))
            {
                query["RefName"] = request.RefName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryCommits",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/commits",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryCommitsResponse>(await CallApiAsync(params_, req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryMember",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryMemberResponse>(CallApi(params_, req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryMember",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRepositoryMemberWithInheritedResponse ListRepositoryMemberWithInherited(string ProjectId, ListRepositoryMemberWithInheritedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRepositoryMemberWithInheritedWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<ListRepositoryMemberWithInheritedResponse> ListRepositoryMemberWithInheritedAsync(string ProjectId, ListRepositoryMemberWithInheritedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRepositoryMemberWithInheritedWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public ListRepositoryMemberWithInheritedResponse ListRepositoryMemberWithInheritedWithOptions(string ProjectId, ListRepositoryMemberWithInheritedRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryMemberWithInherited",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/all_members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryMemberWithInheritedResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRepositoryMemberWithInheritedResponse> ListRepositoryMemberWithInheritedWithOptionsAsync(string ProjectId, ListRepositoryMemberWithInheritedRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryMemberWithInherited",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/all_members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryMemberWithInheritedResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRepositoryProtectedBranchResponse ListRepositoryProtectedBranch(string ProjectId, ListRepositoryProtectedBranchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRepositoryProtectedBranchWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<ListRepositoryProtectedBranchResponse> ListRepositoryProtectedBranchAsync(string ProjectId, ListRepositoryProtectedBranchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRepositoryProtectedBranchWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public ListRepositoryProtectedBranchResponse ListRepositoryProtectedBranchWithOptions(string ProjectId, ListRepositoryProtectedBranchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryProtectedBranch",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/protect_branches",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryProtectedBranchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRepositoryProtectedBranchResponse> ListRepositoryProtectedBranchWithOptionsAsync(string ProjectId, ListRepositoryProtectedBranchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryProtectedBranch",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/protect_branches",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryProtectedBranchResponse>(await CallApiAsync(params_, req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSignature))
            {
                query["ShowSignature"] = request.ShowSignature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryTags",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryTagsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRepositoryTagsResponse> ListRepositoryTagsWithOptionsAsync(string ProjectId, ListRepositoryTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["Search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSignature))
            {
                query["ShowSignature"] = request.ShowSignature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryTags",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryTagsResponse>(await CallApiAsync(params_, req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefName))
            {
                query["RefName"] = request.RefName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryTree",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/tree",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryTreeResponse>(CallApi(params_, req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefName))
            {
                query["RefName"] = request.RefName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryTree",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/tree",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryTreeResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryWebhook",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/hooks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryWebhookResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryWebhook",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/hooks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryWebhookResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MergeMergeRequest",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/merge_request/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MergeRequestId) + "/merge",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MergeMergeRequestResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MergeMergeRequest",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/merge_request/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MergeRequestId) + "/merge",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MergeMergeRequestResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QuerySlsRelationResponse QuerySlsRelation(QuerySlsRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QuerySlsRelationWithOptions(request, headers, runtime);
        }

        public async Task<QuerySlsRelationResponse> QuerySlsRelationAsync(QuerySlsRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QuerySlsRelationWithOptionsAsync(request, headers, runtime);
        }

        public QuerySlsRelationResponse QuerySlsRelationWithOptions(QuerySlsRelationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunUserId))
            {
                body["aliyunUserId"] = request.AliyunUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeupProjectId))
            {
                body["codeupProjectId"] = request.CodeupProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsLogStore))
            {
                body["slsLogStore"] = request.SlsLogStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsProject))
            {
                body["slsProject"] = request.SlsProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySlsRelation",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/repository/query_sls_relation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySlsRelationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QuerySlsRelationResponse> QuerySlsRelationWithOptionsAsync(QuerySlsRelationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunUserId))
            {
                body["aliyunUserId"] = request.AliyunUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeupProjectId))
            {
                body["codeupProjectId"] = request.CodeupProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsLogStore))
            {
                body["slsLogStore"] = request.SlsLogStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsProject))
            {
                body["slsProject"] = request.SlsProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySlsRelation",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/repository/query_sls_relation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySlsRelationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RelatedSlsLogStoreResponse RelatedSlsLogStore(RelatedSlsLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RelatedSlsLogStoreWithOptions(request, headers, runtime);
        }

        public async Task<RelatedSlsLogStoreResponse> RelatedSlsLogStoreAsync(RelatedSlsLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RelatedSlsLogStoreWithOptionsAsync(request, headers, runtime);
        }

        public RelatedSlsLogStoreResponse RelatedSlsLogStoreWithOptions(RelatedSlsLogStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunUserId))
            {
                body["aliyunUserId"] = request.AliyunUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeupProjectId))
            {
                body["codeupProjectId"] = request.CodeupProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultViewer))
            {
                body["defaultViewer"] = request.DefaultViewer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsLogStore))
            {
                body["slsLogStore"] = request.SlsLogStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsProject))
            {
                body["slsProject"] = request.SlsProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RelatedSlsLogStore",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/repository/related_to_sls_log_store",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RelatedSlsLogStoreResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RelatedSlsLogStoreResponse> RelatedSlsLogStoreWithOptionsAsync(RelatedSlsLogStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunUserId))
            {
                body["aliyunUserId"] = request.AliyunUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeupProjectId))
            {
                body["codeupProjectId"] = request.CodeupProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultViewer))
            {
                body["defaultViewer"] = request.DefaultViewer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsLogStore))
            {
                body["slsLogStore"] = request.SlsLogStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsProject))
            {
                body["slsProject"] = request.SlsProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RelatedSlsLogStore",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/repository/related_to_sls_log_store",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RelatedSlsLogStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TriggerRepositoryMirrorSyncResponse TriggerRepositoryMirrorSync(string ProjectId, TriggerRepositoryMirrorSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TriggerRepositoryMirrorSyncWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<TriggerRepositoryMirrorSyncResponse> TriggerRepositoryMirrorSyncAsync(string ProjectId, TriggerRepositoryMirrorSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TriggerRepositoryMirrorSyncWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public TriggerRepositoryMirrorSyncResponse TriggerRepositoryMirrorSyncWithOptions(string ProjectId, TriggerRepositoryMirrorSyncRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                query["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerRepositoryMirrorSync",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/mirror",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerRepositoryMirrorSyncResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TriggerRepositoryMirrorSyncResponse> TriggerRepositoryMirrorSyncWithOptionsAsync(string ProjectId, TriggerRepositoryMirrorSyncRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                query["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerRepositoryMirrorSync",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/mirror",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerRepositoryMirrorSyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnRelatedSlsLogStoreResponse UnRelatedSlsLogStore(UnRelatedSlsLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UnRelatedSlsLogStoreWithOptions(request, headers, runtime);
        }

        public async Task<UnRelatedSlsLogStoreResponse> UnRelatedSlsLogStoreAsync(UnRelatedSlsLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UnRelatedSlsLogStoreWithOptionsAsync(request, headers, runtime);
        }

        public UnRelatedSlsLogStoreResponse UnRelatedSlsLogStoreWithOptions(UnRelatedSlsLogStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunUserId))
            {
                body["aliyunUserId"] = request.AliyunUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeupProjectId))
            {
                body["codeupProjectId"] = request.CodeupProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsLogStore))
            {
                body["slsLogStore"] = request.SlsLogStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsProject))
            {
                body["slsProject"] = request.SlsProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnRelatedSlsLogStore",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/repository/unrelated_to_sls_log_store",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnRelatedSlsLogStoreResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnRelatedSlsLogStoreResponse> UnRelatedSlsLogStoreWithOptionsAsync(UnRelatedSlsLogStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["OrganizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunUserId))
            {
                body["aliyunUserId"] = request.AliyunUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeupProjectId))
            {
                body["codeupProjectId"] = request.CodeupProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsLogStore))
            {
                body["slsLogStore"] = request.SlsLogStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsProject))
            {
                body["slsProject"] = request.SlsProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnRelatedSlsLogStore",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/repository/unrelated_to_sls_log_store",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnRelatedSlsLogStoreResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFile",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/files",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFileResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFile",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/repository/files",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFileResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroupMember",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GroupId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(UserId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupMemberResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroupMember",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GroupId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(UserId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateMergeRequestResponse UpdateMergeRequest(string ProjectId, string MergeRequestId, UpdateMergeRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMergeRequestWithOptions(ProjectId, MergeRequestId, request, headers, runtime);
        }

        public async Task<UpdateMergeRequestResponse> UpdateMergeRequestAsync(string ProjectId, string MergeRequestId, UpdateMergeRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMergeRequestWithOptionsAsync(ProjectId, MergeRequestId, request, headers, runtime);
        }

        public UpdateMergeRequestResponse UpdateMergeRequestWithOptions(string ProjectId, string MergeRequestId, UpdateMergeRequestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMergeRequest",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/merge_request/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MergeRequestId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMergeRequestResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateMergeRequestResponse> UpdateMergeRequestWithOptionsAsync(string ProjectId, string MergeRequestId, UpdateMergeRequestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMergeRequest",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/merge_request/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MergeRequestId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMergeRequestResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateMergeRequestCommentResponse UpdateMergeRequestComment(string ProjectId, string MergeRequestId, string NoteId, UpdateMergeRequestCommentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMergeRequestCommentWithOptions(ProjectId, MergeRequestId, NoteId, request, headers, runtime);
        }

        public async Task<UpdateMergeRequestCommentResponse> UpdateMergeRequestCommentAsync(string ProjectId, string MergeRequestId, string NoteId, UpdateMergeRequestCommentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMergeRequestCommentWithOptionsAsync(ProjectId, MergeRequestId, NoteId, request, headers, runtime);
        }

        public UpdateMergeRequestCommentResponse UpdateMergeRequestCommentWithOptions(string ProjectId, string MergeRequestId, string NoteId, UpdateMergeRequestCommentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMergeRequestComment",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/merge_requests/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MergeRequestId) + "/notes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NoteId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMergeRequestCommentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateMergeRequestCommentResponse> UpdateMergeRequestCommentWithOptionsAsync(string ProjectId, string MergeRequestId, string NoteId, UpdateMergeRequestCommentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMergeRequestComment",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/merge_requests/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(MergeRequestId) + "/notes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NoteId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMergeRequestCommentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateMergeRequestSettingResponse UpdateMergeRequestSetting(string ProjectId, UpdateMergeRequestSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMergeRequestSettingWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<UpdateMergeRequestSettingResponse> UpdateMergeRequestSettingAsync(string ProjectId, UpdateMergeRequestSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMergeRequestSettingWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public UpdateMergeRequestSettingResponse UpdateMergeRequestSettingWithOptions(string ProjectId, UpdateMergeRequestSettingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMergeRequestSetting",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/settings/merge_requests",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMergeRequestSettingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateMergeRequestSettingResponse> UpdateMergeRequestSettingWithOptionsAsync(string ProjectId, UpdateMergeRequestSettingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMergeRequestSetting",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v4/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/settings/merge_requests",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMergeRequestSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateRepositoryResponse UpdateRepository(string ProjectId, UpdateRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateRepositoryWithOptions(ProjectId, request, headers, runtime);
        }

        public async Task<UpdateRepositoryResponse> UpdateRepositoryAsync(string ProjectId, UpdateRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateRepositoryWithOptionsAsync(ProjectId, request, headers, runtime);
        }

        public UpdateRepositoryResponse UpdateRepositoryWithOptions(string ProjectId, UpdateRepositoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRepository",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRepositoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateRepositoryResponse> UpdateRepositoryWithOptionsAsync(string ProjectId, UpdateRepositoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRepository",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRepositoryResponse>(await CallApiAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRepositoryMember",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(UserId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRepositoryMemberResponse>(CallApi(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRepositoryMember",
                Version = "2020-04-14",
                Protocol = "HTTPS",
                Pathname = "/api/v3/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(UserId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRepositoryMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

    }
}
