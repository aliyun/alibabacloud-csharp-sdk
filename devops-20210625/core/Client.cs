// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Devops20210625.Models;

namespace AlibabaCloud.SDK.Devops20210625
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("devops", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddRepositoryMemberResponse AddRepositoryMember(string repositoryId, AddRepositoryMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddRepositoryMemberWithOptions(repositoryId, request, headers, runtime);
        }

        public async Task<AddRepositoryMemberResponse> AddRepositoryMemberAsync(string repositoryId, AddRepositoryMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddRepositoryMemberWithOptionsAsync(repositoryId, request, headers, runtime);
        }

        public AddRepositoryMemberResponse AddRepositoryMemberWithOptions(string repositoryId, AddRepositoryMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLevel))
            {
                body["accessLevel"] = request.AccessLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPks))
            {
                body["aliyunPks"] = request.AliyunPks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddRepositoryMember",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRepositoryMemberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddRepositoryMemberResponse> AddRepositoryMemberWithOptionsAsync(string repositoryId, AddRepositoryMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLevel))
            {
                body["accessLevel"] = request.AccessLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunPks))
            {
                body["aliyunPks"] = request.AliyunPks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddRepositoryMember",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRepositoryMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddWebhookResponse AddWebhook(string repositoryId, AddWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddWebhookWithOptions(repositoryId, request, headers, runtime);
        }

        public async Task<AddWebhookResponse> AddWebhookAsync(string repositoryId, AddWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddWebhookWithOptionsAsync(repositoryId, request, headers, runtime);
        }

        public AddWebhookResponse AddWebhookWithOptions(string repositoryId, AddWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSslVerification))
            {
                body["enableSslVerification"] = request.EnableSslVerification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergeRequestsEvents))
            {
                body["mergeRequestsEvents"] = request.MergeRequestsEvents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoteEvents))
            {
                body["noteEvents"] = request.NoteEvents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushEvents))
            {
                body["pushEvents"] = request.PushEvents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretToken))
            {
                body["secretToken"] = request.SecretToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagPushEvents))
            {
                body["tagPushEvents"] = request.TagPushEvents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddWebhook",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/webhooks/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddWebhookResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddWebhookResponse> AddWebhookWithOptionsAsync(string repositoryId, AddWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSslVerification))
            {
                body["enableSslVerification"] = request.EnableSslVerification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergeRequestsEvents))
            {
                body["mergeRequestsEvents"] = request.MergeRequestsEvents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoteEvents))
            {
                body["noteEvents"] = request.NoteEvents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushEvents))
            {
                body["pushEvents"] = request.PushEvents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretToken))
            {
                body["secretToken"] = request.SecretToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagPushEvents))
            {
                body["tagPushEvents"] = request.TagPushEvents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddWebhook",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/webhooks/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddWebhookResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFileResponse CreateFile(string repositoryId, CreateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFileWithOptions(repositoryId, request, headers, runtime);
        }

        public async Task<CreateFileResponse> CreateFileAsync(string repositoryId, CreateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFileWithOptionsAsync(repositoryId, request, headers, runtime);
        }

        public CreateFileResponse CreateFileWithOptions(string repositoryId, CreateFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                body["branchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommitMessage))
            {
                body["commitMessage"] = request.CommitMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Encoding))
            {
                body["encoding"] = request.Encoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                body["filePath"] = request.FilePath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFile",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/files",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFileResponse> CreateFileWithOptionsAsync(string repositoryId, CreateFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                body["branchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommitMessage))
            {
                body["commitMessage"] = request.CommitMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Encoding))
            {
                body["encoding"] = request.Encoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                body["filePath"] = request.FilePath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFile",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/files",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFlowTagResponse CreateFlowTag(string organizationId, CreateFlowTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFlowTagWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<CreateFlowTagResponse> CreateFlowTagAsync(string organizationId, CreateFlowTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFlowTagWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public CreateFlowTagResponse CreateFlowTagWithOptions(string organizationId, CreateFlowTagRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Color))
            {
                query["color"] = request.Color;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowTagGroupId))
            {
                query["flowTagGroupId"] = request.FlowTagGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowTag",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/flow/tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowTagResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFlowTagResponse> CreateFlowTagWithOptionsAsync(string organizationId, CreateFlowTagRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Color))
            {
                query["color"] = request.Color;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowTagGroupId))
            {
                query["flowTagGroupId"] = request.FlowTagGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowTag",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/flow/tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFlowTagGroupResponse CreateFlowTagGroup(string organizationId, CreateFlowTagGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFlowTagGroupWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<CreateFlowTagGroupResponse> CreateFlowTagGroupAsync(string organizationId, CreateFlowTagGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFlowTagGroupWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public CreateFlowTagGroupResponse CreateFlowTagGroupWithOptions(string organizationId, CreateFlowTagGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowTagGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/flow/tagGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowTagGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFlowTagGroupResponse> CreateFlowTagGroupWithOptionsAsync(string organizationId, CreateFlowTagGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowTagGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/flow/tagGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowTagGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateHostGroupResponse CreateHostGroup(string organizationId, CreateHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateHostGroupWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<CreateHostGroupResponse> CreateHostGroupAsync(string organizationId, CreateHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateHostGroupWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public CreateHostGroupResponse CreateHostGroupWithOptions(string organizationId, CreateHostGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunRegion))
            {
                body["aliyunRegion"] = request.AliyunRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsLabelKey))
            {
                body["ecsLabelKey"] = request.EcsLabelKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsLabelValue))
            {
                body["ecsLabelValue"] = request.EcsLabelValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsType))
            {
                body["ecsType"] = request.EcsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["envId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MachineInfos))
            {
                body["machineInfos"] = request.MachineInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceConnectionId))
            {
                body["serviceConnectionId"] = request.ServiceConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagIds))
            {
                body["tagIds"] = request.TagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHostGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/hostGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHostGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateHostGroupResponse> CreateHostGroupWithOptionsAsync(string organizationId, CreateHostGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunRegion))
            {
                body["aliyunRegion"] = request.AliyunRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsLabelKey))
            {
                body["ecsLabelKey"] = request.EcsLabelKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsLabelValue))
            {
                body["ecsLabelValue"] = request.EcsLabelValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsType))
            {
                body["ecsType"] = request.EcsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["envId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MachineInfos))
            {
                body["machineInfos"] = request.MachineInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceConnectionId))
            {
                body["serviceConnectionId"] = request.ServiceConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagIds))
            {
                body["tagIds"] = request.TagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHostGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/hostGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHostGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateOAuthTokenResponse CreateOAuthToken(CreateOAuthTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateOAuthTokenWithOptions(request, headers, runtime);
        }

        public async Task<CreateOAuthTokenResponse> CreateOAuthTokenAsync(CreateOAuthTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateOAuthTokenWithOptionsAsync(request, headers, runtime);
        }

        public CreateOAuthTokenResponse CreateOAuthTokenWithOptions(CreateOAuthTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["clientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSecret))
            {
                body["clientSecret"] = request.ClientSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantType))
            {
                body["grantType"] = request.GrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Login))
            {
                body["login"] = request.Login;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOAuthToken",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/login/oauth/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOAuthTokenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateOAuthTokenResponse> CreateOAuthTokenWithOptionsAsync(CreateOAuthTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["clientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSecret))
            {
                body["clientSecret"] = request.ClientSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantType))
            {
                body["grantType"] = request.GrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Login))
            {
                body["login"] = request.Login;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOAuthToken",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/login/oauth/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOAuthTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreatePipelineGroupResponse CreatePipelineGroup(string organizationId, CreatePipelineGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePipelineGroupWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<CreatePipelineGroupResponse> CreatePipelineGroupAsync(string organizationId, CreatePipelineGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePipelineGroupWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public CreatePipelineGroupResponse CreatePipelineGroupWithOptions(string organizationId, CreatePipelineGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePipelineGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelineGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePipelineGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreatePipelineGroupResponse> CreatePipelineGroupWithOptionsAsync(string organizationId, CreatePipelineGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePipelineGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelineGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePipelineGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateProjectResponse CreateProject(string organizationId, CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProjectWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<CreateProjectResponse> CreateProjectAsync(string organizationId, CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProjectWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public CreateProjectResponse CreateProjectWithOptions(string organizationId, CreateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomCode))
            {
                body["customCode"] = request.CustomCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIdentifier))
            {
                body["templateIdentifier"] = request.TemplateIdentifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/projects/createProject",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(string organizationId, CreateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomCode))
            {
                body["customCode"] = request.CustomCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIdentifier))
            {
                body["templateIdentifier"] = request.TemplateIdentifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/projects/createProject",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(await CallApiAsync(params_, req, runtime));
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
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateParentPath))
            {
                query["createParentPath"] = request.CreateParentPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sync))
            {
                query["sync"] = request.Sync;
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
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/create",
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
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateParentPath))
            {
                query["createParentPath"] = request.CreateParentPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sync))
            {
                query["sync"] = request.Sync;
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
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRepositoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateResourceMemberResponse CreateResourceMember(string organizationId, string resourceType, string resourceId, CreateResourceMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateResourceMemberWithOptions(organizationId, resourceType, resourceId, request, headers, runtime);
        }

        public async Task<CreateResourceMemberResponse> CreateResourceMemberAsync(string organizationId, string resourceType, string resourceId, CreateResourceMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateResourceMemberWithOptionsAsync(organizationId, resourceType, resourceId, request, headers, runtime);
        }

        public CreateResourceMemberResponse CreateResourceMemberWithOptions(string organizationId, string resourceType, string resourceId, CreateResourceMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["roleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceMember",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceType) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceId) + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceMemberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateResourceMemberResponse> CreateResourceMemberWithOptionsAsync(string organizationId, string resourceType, string resourceId, CreateResourceMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["roleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceMember",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceType) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceId) + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateSprintResponse CreateSprint(string organizationId, CreateSprintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSprintWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<CreateSprintResponse> CreateSprintAsync(string organizationId, CreateSprintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSprintWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public CreateSprintResponse CreateSprintWithOptions(string organizationId, CreateSprintRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceIdentifier))
            {
                body["spaceIdentifier"] = request.SpaceIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StaffIds))
            {
                body["staffIds"] = request.StaffIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSprint",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/sprints/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSprintResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSprintResponse> CreateSprintWithOptionsAsync(string organizationId, CreateSprintRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceIdentifier))
            {
                body["spaceIdentifier"] = request.SpaceIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StaffIds))
            {
                body["staffIds"] = request.StaffIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSprint",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/sprints/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSprintResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateSshKeyResponse CreateSshKey(string organizationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSshKeyWithOptions(organizationId, headers, runtime);
        }

        public async Task<CreateSshKeyResponse> CreateSshKeyAsync(string organizationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSshKeyWithOptionsAsync(organizationId, headers, runtime);
        }

        public CreateSshKeyResponse CreateSshKeyWithOptions(string organizationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSshKey",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/sshKey",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSshKeyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSshKeyResponse> CreateSshKeyWithOptionsAsync(string organizationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSshKey",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/sshKey",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSshKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateVariableGroupResponse CreateVariableGroup(string organizationId, CreateVariableGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateVariableGroupWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<CreateVariableGroupResponse> CreateVariableGroupAsync(string organizationId, CreateVariableGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateVariableGroupWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public CreateVariableGroupResponse CreateVariableGroupWithOptions(string organizationId, CreateVariableGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVariableGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/variableGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVariableGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateVariableGroupResponse> CreateVariableGroupWithOptionsAsync(string organizationId, CreateVariableGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVariableGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/variableGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVariableGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateWorkitemResponse CreateWorkitem(string organizationId, CreateWorkitemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateWorkitemWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<CreateWorkitemResponse> CreateWorkitemAsync(string organizationId, CreateWorkitemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateWorkitemWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public CreateWorkitemResponse CreateWorkitemWithOptions(string organizationId, CreateWorkitemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignedTo))
            {
                body["assignedTo"] = request.AssignedTo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DescriptionFormat))
            {
                body["descriptionFormat"] = request.DescriptionFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldValueList))
            {
                body["fieldValueList"] = request.FieldValueList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parent))
            {
                body["parent"] = request.Parent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Participant))
            {
                body["participant"] = request.Participant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Space))
            {
                body["space"] = request.Space;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceIdentifier))
            {
                body["spaceIdentifier"] = request.SpaceIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceType))
            {
                body["spaceType"] = request.SpaceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sprint))
            {
                body["sprint"] = request.Sprint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                body["subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tracker))
            {
                body["tracker"] = request.Tracker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verifier))
            {
                body["verifier"] = request.Verifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkitemType))
            {
                body["workitemType"] = request.WorkitemType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkitem",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/workitems/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkitemResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateWorkitemResponse> CreateWorkitemWithOptionsAsync(string organizationId, CreateWorkitemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssignedTo))
            {
                body["assignedTo"] = request.AssignedTo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DescriptionFormat))
            {
                body["descriptionFormat"] = request.DescriptionFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldValueList))
            {
                body["fieldValueList"] = request.FieldValueList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parent))
            {
                body["parent"] = request.Parent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Participant))
            {
                body["participant"] = request.Participant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Space))
            {
                body["space"] = request.Space;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceIdentifier))
            {
                body["spaceIdentifier"] = request.SpaceIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceType))
            {
                body["spaceType"] = request.SpaceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sprint))
            {
                body["sprint"] = request.Sprint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                body["subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tracker))
            {
                body["tracker"] = request.Tracker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verifier))
            {
                body["verifier"] = request.Verifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkitemType))
            {
                body["workitemType"] = request.WorkitemType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkitem",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/workitems/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkitemResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateWorkspaceWithOptions(request, headers, runtime);
        }

        public async Task<CreateWorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateWorkspaceWithOptionsAsync(request, headers, runtime);
        }

        public CreateWorkspaceResponse CreateWorkspaceWithOptions(CreateWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeUrl))
            {
                body["codeUrl"] = request.CodeUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeVersion))
            {
                body["codeVersion"] = request.CodeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                body["filePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestFrom))
            {
                body["requestFrom"] = request.RequestFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdentifier))
            {
                body["resourceIdentifier"] = request.ResourceIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reuse))
            {
                body["reuse"] = request.Reuse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceTemplate))
            {
                body["workspaceTemplate"] = request.WorkspaceTemplate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspace",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/api/workspaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateWorkspaceResponse> CreateWorkspaceWithOptionsAsync(CreateWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeUrl))
            {
                body["codeUrl"] = request.CodeUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeVersion))
            {
                body["codeVersion"] = request.CodeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                body["filePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestFrom))
            {
                body["requestFrom"] = request.RequestFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdentifier))
            {
                body["resourceIdentifier"] = request.ResourceIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reuse))
            {
                body["reuse"] = request.Reuse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceTemplate))
            {
                body["workspaceTemplate"] = request.WorkspaceTemplate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWorkspace",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/api/workspaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFileResponse DeleteFile(string repositoryId, DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFileWithOptions(repositoryId, request, headers, runtime);
        }

        public async Task<DeleteFileResponse> DeleteFileAsync(string repositoryId, DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFileWithOptionsAsync(repositoryId, request, headers, runtime);
        }

        public DeleteFileResponse DeleteFileWithOptions(string repositoryId, DeleteFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["branchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommitMessage))
            {
                query["commitMessage"] = request.CommitMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["filePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFile",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/files/delete",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFileResponse> DeleteFileWithOptionsAsync(string repositoryId, DeleteFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["branchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommitMessage))
            {
                query["commitMessage"] = request.CommitMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["filePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFile",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/files/delete",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFlowTagResponse DeleteFlowTag(string organizationId, string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFlowTagWithOptions(organizationId, id, headers, runtime);
        }

        public async Task<DeleteFlowTagResponse> DeleteFlowTagAsync(string organizationId, string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFlowTagWithOptionsAsync(organizationId, id, headers, runtime);
        }

        public DeleteFlowTagResponse DeleteFlowTagWithOptions(string organizationId, string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowTag",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/flow/tags/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowTagResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFlowTagResponse> DeleteFlowTagWithOptionsAsync(string organizationId, string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowTag",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/flow/tags/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFlowTagGroupResponse DeleteFlowTagGroup(string organizationId, string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteFlowTagGroupWithOptions(organizationId, id, headers, runtime);
        }

        public async Task<DeleteFlowTagGroupResponse> DeleteFlowTagGroupAsync(string organizationId, string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteFlowTagGroupWithOptionsAsync(organizationId, id, headers, runtime);
        }

        public DeleteFlowTagGroupResponse DeleteFlowTagGroupWithOptions(string organizationId, string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowTagGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/flow/tagGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowTagGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFlowTagGroupResponse> DeleteFlowTagGroupWithOptionsAsync(string organizationId, string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowTagGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/flow/tagGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowTagGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteHostGroupResponse DeleteHostGroup(string organizationId, string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteHostGroupWithOptions(organizationId, id, headers, runtime);
        }

        public async Task<DeleteHostGroupResponse> DeleteHostGroupAsync(string organizationId, string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteHostGroupWithOptionsAsync(organizationId, id, headers, runtime);
        }

        public DeleteHostGroupResponse DeleteHostGroupWithOptions(string organizationId, string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHostGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/hostGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHostGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteHostGroupResponse> DeleteHostGroupWithOptionsAsync(string organizationId, string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHostGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/hostGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHostGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeletePipelineResponse DeletePipeline(string organizationId, string pipelineId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePipelineWithOptions(organizationId, pipelineId, headers, runtime);
        }

        public async Task<DeletePipelineResponse> DeletePipelineAsync(string organizationId, string pipelineId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePipelineWithOptionsAsync(organizationId, pipelineId, headers, runtime);
        }

        public DeletePipelineResponse DeletePipelineWithOptions(string organizationId, string pipelineId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePipeline",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePipelineResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeletePipelineResponse> DeletePipelineWithOptionsAsync(string organizationId, string pipelineId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePipeline",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeletePipelineGroupResponse DeletePipelineGroup(string organizationId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePipelineGroupWithOptions(organizationId, groupId, headers, runtime);
        }

        public async Task<DeletePipelineGroupResponse> DeletePipelineGroupAsync(string organizationId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePipelineGroupWithOptionsAsync(organizationId, groupId, headers, runtime);
        }

        public DeletePipelineGroupResponse DeletePipelineGroupWithOptions(string organizationId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePipelineGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelineGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePipelineGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeletePipelineGroupResponse> DeletePipelineGroupWithOptionsAsync(string organizationId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePipelineGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelineGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePipelineGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteProjectResponse DeleteProject(string organizationId, DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProjectWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<DeleteProjectResponse> DeleteProjectAsync(string organizationId, DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProjectWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public DeleteProjectResponse DeleteProjectWithOptions(string organizationId, DeleteProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["identifier"] = request.Identifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProject",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/projects/delete",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteProjectResponse> DeleteProjectWithOptionsAsync(string organizationId, DeleteProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["identifier"] = request.Identifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProject",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/projects/delete",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteRepositoryResponse DeleteRepository(string repositoryId, DeleteRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRepositoryWithOptions(repositoryId, request, headers, runtime);
        }

        public async Task<DeleteRepositoryResponse> DeleteRepositoryAsync(string repositoryId, DeleteRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRepositoryWithOptionsAsync(repositoryId, request, headers, runtime);
        }

        public DeleteRepositoryResponse DeleteRepositoryWithOptions(string repositoryId, DeleteRepositoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["reason"] = request.Reason;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepository",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepositoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteRepositoryResponse> DeleteRepositoryWithOptionsAsync(string repositoryId, DeleteRepositoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["reason"] = request.Reason;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRepository",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRepositoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteResourceMemberResponse DeleteResourceMember(string organizationId, string resourceType, string resourceId, string accountId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteResourceMemberWithOptions(organizationId, resourceType, resourceId, accountId, headers, runtime);
        }

        public async Task<DeleteResourceMemberResponse> DeleteResourceMemberAsync(string organizationId, string resourceType, string resourceId, string accountId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteResourceMemberWithOptionsAsync(organizationId, resourceType, resourceId, accountId, headers, runtime);
        }

        public DeleteResourceMemberResponse DeleteResourceMemberWithOptions(string organizationId, string resourceType, string resourceId, string accountId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceMember",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceType) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(accountId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceMemberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteResourceMemberResponse> DeleteResourceMemberWithOptionsAsync(string organizationId, string resourceType, string resourceId, string accountId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceMember",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceType) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(accountId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteVariableGroupResponse DeleteVariableGroup(string organizationId, string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteVariableGroupWithOptions(organizationId, id, headers, runtime);
        }

        public async Task<DeleteVariableGroupResponse> DeleteVariableGroupAsync(string organizationId, string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteVariableGroupWithOptionsAsync(organizationId, id, headers, runtime);
        }

        public DeleteVariableGroupResponse DeleteVariableGroupWithOptions(string organizationId, string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVariableGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/variableGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVariableGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteVariableGroupResponse> DeleteVariableGroupWithOptionsAsync(string organizationId, string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVariableGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/variableGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVariableGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FrozenWorkspaceResponse FrozenWorkspace(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FrozenWorkspaceWithOptions(workspaceId, headers, runtime);
        }

        public async Task<FrozenWorkspaceResponse> FrozenWorkspaceAsync(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FrozenWorkspaceWithOptionsAsync(workspaceId, headers, runtime);
        }

        public FrozenWorkspaceResponse FrozenWorkspaceWithOptions(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FrozenWorkspace",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/api/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/frozen",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FrozenWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FrozenWorkspaceResponse> FrozenWorkspaceWithOptionsAsync(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FrozenWorkspace",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/api/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/frozen",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FrozenWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetCodeupOrganizationResponse GetCodeupOrganization(string identity, GetCodeupOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCodeupOrganizationWithOptions(identity, request, headers, runtime);
        }

        public async Task<GetCodeupOrganizationResponse> GetCodeupOrganizationAsync(string identity, GetCodeupOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCodeupOrganizationWithOptionsAsync(identity, request, headers, runtime);
        }

        public GetCodeupOrganizationResponse GetCodeupOrganizationWithOptions(string identity, GetCodeupOrganizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCodeupOrganization",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/api/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(identity),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCodeupOrganizationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCodeupOrganizationResponse> GetCodeupOrganizationWithOptionsAsync(string identity, GetCodeupOrganizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCodeupOrganization",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/api/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(identity),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCodeupOrganizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetCustomFieldOptionResponse GetCustomFieldOption(string organizationId, string fieldId, GetCustomFieldOptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCustomFieldOptionWithOptions(organizationId, fieldId, request, headers, runtime);
        }

        public async Task<GetCustomFieldOptionResponse> GetCustomFieldOptionAsync(string organizationId, string fieldId, GetCustomFieldOptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCustomFieldOptionWithOptionsAsync(organizationId, fieldId, request, headers, runtime);
        }

        public GetCustomFieldOptionResponse GetCustomFieldOptionWithOptions(string organizationId, string fieldId, GetCustomFieldOptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceIdentifier))
            {
                query["spaceIdentifier"] = request.SpaceIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceType))
            {
                query["spaceType"] = request.SpaceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkitemTypeIdentifier))
            {
                query["workitemTypeIdentifier"] = request.WorkitemTypeIdentifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomFieldOption",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/fields/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fieldId) + "/getCustomOption",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomFieldOptionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetCustomFieldOptionResponse> GetCustomFieldOptionWithOptionsAsync(string organizationId, string fieldId, GetCustomFieldOptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceIdentifier))
            {
                query["spaceIdentifier"] = request.SpaceIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceType))
            {
                query["spaceType"] = request.SpaceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkitemTypeIdentifier))
            {
                query["workitemTypeIdentifier"] = request.WorkitemTypeIdentifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomFieldOption",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/fields/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fieldId) + "/getCustomOption",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomFieldOptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetFileBlobsResponse GetFileBlobs(string repositoryId, GetFileBlobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFileBlobsWithOptions(repositoryId, request, headers, runtime);
        }

        public async Task<GetFileBlobsResponse> GetFileBlobsAsync(string repositoryId, GetFileBlobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFileBlobsWithOptionsAsync(repositoryId, request, headers, runtime);
        }

        public GetFileBlobsResponse GetFileBlobsWithOptions(string repositoryId, GetFileBlobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["filePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ref))
            {
                query["ref"] = request.Ref;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["to"] = request.To;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileBlobs",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/files/blobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileBlobsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFileBlobsResponse> GetFileBlobsWithOptionsAsync(string repositoryId, GetFileBlobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["filePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ref))
            {
                query["ref"] = request.Ref;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["to"] = request.To;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileBlobs",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/files/blobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileBlobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetFileLastCommitResponse GetFileLastCommit(string repositoryId, GetFileLastCommitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFileLastCommitWithOptions(repositoryId, request, headers, runtime);
        }

        public async Task<GetFileLastCommitResponse> GetFileLastCommitAsync(string repositoryId, GetFileLastCommitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFileLastCommitWithOptionsAsync(repositoryId, request, headers, runtime);
        }

        public GetFileLastCommitResponse GetFileLastCommitWithOptions(string repositoryId, GetFileLastCommitRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filepath))
            {
                query["filepath"] = request.Filepath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sha))
            {
                query["sha"] = request.Sha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSignature))
            {
                query["showSignature"] = request.ShowSignature;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileLastCommit",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/files/lastCommit",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileLastCommitResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFileLastCommitResponse> GetFileLastCommitWithOptionsAsync(string repositoryId, GetFileLastCommitRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filepath))
            {
                query["filepath"] = request.Filepath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sha))
            {
                query["sha"] = request.Sha;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowSignature))
            {
                query["showSignature"] = request.ShowSignature;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileLastCommit",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/files/lastCommit",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileLastCommitResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetFlowTagGroupResponse GetFlowTagGroup(string organizationId, string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFlowTagGroupWithOptions(organizationId, id, headers, runtime);
        }

        public async Task<GetFlowTagGroupResponse> GetFlowTagGroupAsync(string organizationId, string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFlowTagGroupWithOptionsAsync(organizationId, id, headers, runtime);
        }

        public GetFlowTagGroupResponse GetFlowTagGroupWithOptions(string organizationId, string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowTagGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/flow/tagGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowTagGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFlowTagGroupResponse> GetFlowTagGroupWithOptionsAsync(string organizationId, string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowTagGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/flow/tagGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowTagGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetHostGroupResponse GetHostGroup(string organizationId, string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetHostGroupWithOptions(organizationId, id, headers, runtime);
        }

        public async Task<GetHostGroupResponse> GetHostGroupAsync(string organizationId, string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetHostGroupWithOptionsAsync(organizationId, id, headers, runtime);
        }

        public GetHostGroupResponse GetHostGroupWithOptions(string organizationId, string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHostGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/hostGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHostGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetHostGroupResponse> GetHostGroupWithOptionsAsync(string organizationId, string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHostGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/hostGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHostGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetOrganizationMemberResponse GetOrganizationMember(string organizationId, string accountId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetOrganizationMemberWithOptions(organizationId, accountId, headers, runtime);
        }

        public async Task<GetOrganizationMemberResponse> GetOrganizationMemberAsync(string organizationId, string accountId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetOrganizationMemberWithOptionsAsync(organizationId, accountId, headers, runtime);
        }

        public GetOrganizationMemberResponse GetOrganizationMemberWithOptions(string organizationId, string accountId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrganizationMember",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(accountId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizationMemberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetOrganizationMemberResponse> GetOrganizationMemberWithOptionsAsync(string organizationId, string accountId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrganizationMember",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(accountId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizationMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetPipelineResponse GetPipeline(string organizationId, string pipelineId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPipelineWithOptions(organizationId, pipelineId, headers, runtime);
        }

        public async Task<GetPipelineResponse> GetPipelineAsync(string organizationId, string pipelineId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPipelineWithOptionsAsync(organizationId, pipelineId, headers, runtime);
        }

        public GetPipelineResponse GetPipelineWithOptions(string organizationId, string pipelineId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipeline",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPipelineResponse> GetPipelineWithOptionsAsync(string organizationId, string pipelineId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipeline",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetPipelineArtifactUrlResponse GetPipelineArtifactUrl(string organizationId, GetPipelineArtifactUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPipelineArtifactUrlWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<GetPipelineArtifactUrlResponse> GetPipelineArtifactUrlAsync(string organizationId, GetPipelineArtifactUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPipelineArtifactUrlWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public GetPipelineArtifactUrlResponse GetPipelineArtifactUrlWithOptions(string organizationId, GetPipelineArtifactUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["filePath"] = request.FilePath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipelineArtifactUrl",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipeline/getArtifactDownloadUrl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineArtifactUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPipelineArtifactUrlResponse> GetPipelineArtifactUrlWithOptionsAsync(string organizationId, GetPipelineArtifactUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["filePath"] = request.FilePath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipelineArtifactUrl",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipeline/getArtifactDownloadUrl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineArtifactUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetPipelineEmasArtifactUrlResponse GetPipelineEmasArtifactUrl(string organizationId, string emasJobInstanceId, string md5, string pipelineId, string pipelineRunId, GetPipelineEmasArtifactUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPipelineEmasArtifactUrlWithOptions(organizationId, emasJobInstanceId, md5, pipelineId, pipelineRunId, request, headers, runtime);
        }

        public async Task<GetPipelineEmasArtifactUrlResponse> GetPipelineEmasArtifactUrlAsync(string organizationId, string emasJobInstanceId, string md5, string pipelineId, string pipelineRunId, GetPipelineEmasArtifactUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPipelineEmasArtifactUrlWithOptionsAsync(organizationId, emasJobInstanceId, md5, pipelineId, pipelineRunId, request, headers, runtime);
        }

        public GetPipelineEmasArtifactUrlResponse GetPipelineEmasArtifactUrlWithOptions(string organizationId, string emasJobInstanceId, string md5, string pipelineId, string pipelineRunId, GetPipelineEmasArtifactUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceConnectionId))
            {
                query["serviceConnectionId"] = request.ServiceConnectionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipelineEmasArtifactUrl",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/pipelineRun/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId) + "/emas/artifact/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(emasJobInstanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(md5),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineEmasArtifactUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPipelineEmasArtifactUrlResponse> GetPipelineEmasArtifactUrlWithOptionsAsync(string organizationId, string emasJobInstanceId, string md5, string pipelineId, string pipelineRunId, GetPipelineEmasArtifactUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceConnectionId))
            {
                query["serviceConnectionId"] = request.ServiceConnectionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipelineEmasArtifactUrl",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/pipelineRun/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId) + "/emas/artifact/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(emasJobInstanceId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(md5),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineEmasArtifactUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetPipelineGroupResponse GetPipelineGroup(string organizationId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPipelineGroupWithOptions(organizationId, groupId, headers, runtime);
        }

        public async Task<GetPipelineGroupResponse> GetPipelineGroupAsync(string organizationId, string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPipelineGroupWithOptionsAsync(organizationId, groupId, headers, runtime);
        }

        public GetPipelineGroupResponse GetPipelineGroupWithOptions(string organizationId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipelineGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelineGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPipelineGroupResponse> GetPipelineGroupWithOptionsAsync(string organizationId, string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipelineGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelineGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetPipelineRunResponse GetPipelineRun(string organizationId, string pipelineId, string pipelineRunId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPipelineRunWithOptions(organizationId, pipelineId, pipelineRunId, headers, runtime);
        }

        public async Task<GetPipelineRunResponse> GetPipelineRunAsync(string organizationId, string pipelineId, string pipelineRunId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPipelineRunWithOptionsAsync(organizationId, pipelineId, pipelineRunId, headers, runtime);
        }

        public GetPipelineRunResponse GetPipelineRunWithOptions(string organizationId, string pipelineId, string pipelineRunId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipelineRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/pipelineRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineRunResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPipelineRunResponse> GetPipelineRunWithOptionsAsync(string organizationId, string pipelineId, string pipelineRunId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipelineRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/pipelineRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetPipelineScanReportUrlResponse GetPipelineScanReportUrl(string organizationId, GetPipelineScanReportUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPipelineScanReportUrlWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<GetPipelineScanReportUrlResponse> GetPipelineScanReportUrlAsync(string organizationId, GetPipelineScanReportUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPipelineScanReportUrlWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public GetPipelineScanReportUrlResponse GetPipelineScanReportUrlWithOptions(string organizationId, GetPipelineScanReportUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportPath))
            {
                body["reportPath"] = request.ReportPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipelineScanReportUrl",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipeline/getPipelineScanReportUrl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineScanReportUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPipelineScanReportUrlResponse> GetPipelineScanReportUrlWithOptionsAsync(string organizationId, GetPipelineScanReportUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportPath))
            {
                body["reportPath"] = request.ReportPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipelineScanReportUrl",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipeline/getPipelineScanReportUrl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineScanReportUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetProjectInfoResponse GetProjectInfo(string organizationId, string projectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProjectInfoWithOptions(organizationId, projectId, headers, runtime);
        }

        public async Task<GetProjectInfoResponse> GetProjectInfoAsync(string organizationId, string projectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProjectInfoWithOptionsAsync(organizationId, projectId, headers, runtime);
        }

        public GetProjectInfoResponse GetProjectInfoWithOptions(string organizationId, string projectId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProjectInfo",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/project/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetProjectInfoResponse> GetProjectInfoWithOptionsAsync(string organizationId, string projectId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProjectInfo",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/project/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetProjectMemberResponse GetProjectMember(GetProjectMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProjectMemberWithOptions(request, headers, runtime);
        }

        public async Task<GetProjectMemberResponse> GetProjectMemberAsync(GetProjectMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProjectMemberWithOptionsAsync(request, headers, runtime);
        }

        public GetProjectMemberResponse GetProjectMemberWithOptions(GetProjectMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepositoryId))
            {
                query["repositoryId"] = request.RepositoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAliyunPk))
            {
                query["userAliyunPk"] = request.UserAliyunPk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProjectMember",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/member/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectMemberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetProjectMemberResponse> GetProjectMemberWithOptionsAsync(GetProjectMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepositoryId))
            {
                query["repositoryId"] = request.RepositoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAliyunPk))
            {
                query["userAliyunPk"] = request.UserAliyunPk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProjectMember",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/member/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetRepositoryResponse GetRepository(GetRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRepositoryWithOptions(request, headers, runtime);
        }

        public async Task<GetRepositoryResponse> GetRepositoryAsync(GetRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRepositoryWithOptionsAsync(request, headers, runtime);
        }

        public GetRepositoryResponse GetRepositoryWithOptions(GetRepositoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                query["identity"] = request.Identity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepository",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepositoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetRepositoryResponse> GetRepositoryWithOptionsAsync(GetRepositoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identity))
            {
                query["identity"] = request.Identity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepository",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRepositoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetSprintInfoResponse GetSprintInfo(string organizationId, string sprintId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSprintInfoWithOptions(organizationId, sprintId, headers, runtime);
        }

        public async Task<GetSprintInfoResponse> GetSprintInfoAsync(string organizationId, string sprintId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSprintInfoWithOptionsAsync(organizationId, sprintId, headers, runtime);
        }

        public GetSprintInfoResponse GetSprintInfoWithOptions(string organizationId, string sprintId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSprintInfo",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/sprints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sprintId) + "/getSprintinfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSprintInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetSprintInfoResponse> GetSprintInfoWithOptionsAsync(string organizationId, string sprintId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSprintInfo",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/sprints/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sprintId) + "/getSprintinfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSprintInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetVMDeployOrderResponse GetVMDeployOrder(string organizationId, string pipelineId, string deployOrderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetVMDeployOrderWithOptions(organizationId, pipelineId, deployOrderId, headers, runtime);
        }

        public async Task<GetVMDeployOrderResponse> GetVMDeployOrderAsync(string organizationId, string pipelineId, string deployOrderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetVMDeployOrderWithOptionsAsync(organizationId, pipelineId, deployOrderId, headers, runtime);
        }

        public GetVMDeployOrderResponse GetVMDeployOrderWithOptions(string organizationId, string pipelineId, string deployOrderId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVMDeployOrder",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/deploy/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVMDeployOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetVMDeployOrderResponse> GetVMDeployOrderWithOptionsAsync(string organizationId, string pipelineId, string deployOrderId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVMDeployOrder",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/deploy/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVMDeployOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetVariableGroupResponse GetVariableGroup(string organizationId, string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetVariableGroupWithOptions(organizationId, id, headers, runtime);
        }

        public async Task<GetVariableGroupResponse> GetVariableGroupAsync(string organizationId, string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetVariableGroupWithOptionsAsync(organizationId, id, headers, runtime);
        }

        public GetVariableGroupResponse GetVariableGroupWithOptions(string organizationId, string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVariableGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/variableGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVariableGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetVariableGroupResponse> GetVariableGroupWithOptionsAsync(string organizationId, string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVariableGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/variableGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVariableGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetWorkItemActivityResponse GetWorkItemActivity(string organizationId, string workitemId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetWorkItemActivityWithOptions(organizationId, workitemId, headers, runtime);
        }

        public async Task<GetWorkItemActivityResponse> GetWorkItemActivityAsync(string organizationId, string workitemId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetWorkItemActivityWithOptionsAsync(organizationId, workitemId, headers, runtime);
        }

        public GetWorkItemActivityResponse GetWorkItemActivityWithOptions(string organizationId, string workitemId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkItemActivity",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/workitems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workitemId) + "/getActivity",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkItemActivityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetWorkItemActivityResponse> GetWorkItemActivityWithOptionsAsync(string organizationId, string workitemId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkItemActivity",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/workitems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workitemId) + "/getActivity",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkItemActivityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetWorkItemInfoResponse GetWorkItemInfo(string organizationId, string workitemId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetWorkItemInfoWithOptions(organizationId, workitemId, headers, runtime);
        }

        public async Task<GetWorkItemInfoResponse> GetWorkItemInfoAsync(string organizationId, string workitemId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetWorkItemInfoWithOptionsAsync(organizationId, workitemId, headers, runtime);
        }

        public GetWorkItemInfoResponse GetWorkItemInfoWithOptions(string organizationId, string workitemId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkItemInfo",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/workitems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workitemId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkItemInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetWorkItemInfoResponse> GetWorkItemInfoWithOptionsAsync(string organizationId, string workitemId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkItemInfo",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/workitems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workitemId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkItemInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetWorkItemWorkFlowInfoResponse GetWorkItemWorkFlowInfo(string organizationId, string workitemId, GetWorkItemWorkFlowInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetWorkItemWorkFlowInfoWithOptions(organizationId, workitemId, request, headers, runtime);
        }

        public async Task<GetWorkItemWorkFlowInfoResponse> GetWorkItemWorkFlowInfoAsync(string organizationId, string workitemId, GetWorkItemWorkFlowInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetWorkItemWorkFlowInfoWithOptionsAsync(organizationId, workitemId, request, headers, runtime);
        }

        public GetWorkItemWorkFlowInfoResponse GetWorkItemWorkFlowInfoWithOptions(string organizationId, string workitemId, GetWorkItemWorkFlowInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationId))
            {
                query["configurationId"] = request.ConfigurationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkItemWorkFlowInfo",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/workitems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workitemId) + "/getWorkflowInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkItemWorkFlowInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetWorkItemWorkFlowInfoResponse> GetWorkItemWorkFlowInfoWithOptionsAsync(string organizationId, string workitemId, GetWorkItemWorkFlowInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationId))
            {
                query["configurationId"] = request.ConfigurationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkItemWorkFlowInfo",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/workitems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workitemId) + "/getWorkflowInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkItemWorkFlowInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetWorkspaceResponse GetWorkspace(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetWorkspaceWithOptions(workspaceId, headers, runtime);
        }

        public async Task<GetWorkspaceResponse> GetWorkspaceAsync(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetWorkspaceWithOptionsAsync(workspaceId, headers, runtime);
        }

        public GetWorkspaceResponse GetWorkspaceWithOptions(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspace",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/api/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetWorkspaceResponse> GetWorkspaceWithOptionsAsync(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspace",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/api/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public JoinPipelineGroupResponse JoinPipelineGroup(string organizationId, JoinPipelineGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return JoinPipelineGroupWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<JoinPipelineGroupResponse> JoinPipelineGroupAsync(string organizationId, JoinPipelineGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await JoinPipelineGroupWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public JoinPipelineGroupResponse JoinPipelineGroupWithOptions(string organizationId, JoinPipelineGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineIds))
            {
                query["pipelineIds"] = request.PipelineIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "JoinPipelineGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelineGroups/join",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<JoinPipelineGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<JoinPipelineGroupResponse> JoinPipelineGroupWithOptionsAsync(string organizationId, JoinPipelineGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineIds))
            {
                query["pipelineIds"] = request.PipelineIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "JoinPipelineGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelineGroups/join",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<JoinPipelineGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFlowTagGroupsResponse ListFlowTagGroups(string organizationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFlowTagGroupsWithOptions(organizationId, headers, runtime);
        }

        public async Task<ListFlowTagGroupsResponse> ListFlowTagGroupsAsync(string organizationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFlowTagGroupsWithOptionsAsync(organizationId, headers, runtime);
        }

        public ListFlowTagGroupsResponse ListFlowTagGroupsWithOptions(string organizationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowTagGroups",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/flow/tagGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowTagGroupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFlowTagGroupsResponse> ListFlowTagGroupsWithOptionsAsync(string organizationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowTagGroups",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/flow/tagGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowTagGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListHostGroupsResponse ListHostGroups(string organizationId, ListHostGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListHostGroupsWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<ListHostGroupsResponse> ListHostGroupsAsync(string organizationId, ListHostGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListHostGroupsWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public ListHostGroupsResponse ListHostGroupsWithOptions(string organizationId, ListHostGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndTime))
            {
                query["createEndTime"] = request.CreateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartTime))
            {
                query["createStartTime"] = request.CreateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorAccountIds))
            {
                query["creatorAccountIds"] = request.CreatorAccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageOrder))
            {
                query["pageOrder"] = request.PageOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSort))
            {
                query["pageSort"] = request.PageSort;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHostGroups",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/hostGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHostGroupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListHostGroupsResponse> ListHostGroupsWithOptionsAsync(string organizationId, ListHostGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndTime))
            {
                query["createEndTime"] = request.CreateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartTime))
            {
                query["createStartTime"] = request.CreateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorAccountIds))
            {
                query["creatorAccountIds"] = request.CreatorAccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageOrder))
            {
                query["pageOrder"] = request.PageOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSort))
            {
                query["pageSort"] = request.PageSort;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHostGroups",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/hostGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHostGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListOrganizationMembersResponse ListOrganizationMembers(string organizationId, ListOrganizationMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListOrganizationMembersWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<ListOrganizationMembersResponse> ListOrganizationMembersAsync(string organizationId, ListOrganizationMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListOrganizationMembersWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public ListOrganizationMembersResponse ListOrganizationMembersWithOptions(string organizationId, ListOrganizationMembersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternUid))
            {
                query["externUid"] = request.ExternUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JoinTimeFrom))
            {
                query["joinTimeFrom"] = request.JoinTimeFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JoinTimeTo))
            {
                query["joinTimeTo"] = request.JoinTimeTo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationMemberName))
            {
                query["organizationMemberName"] = request.OrganizationMemberName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["state"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrganizationMembers",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrganizationMembersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListOrganizationMembersResponse> ListOrganizationMembersWithOptionsAsync(string organizationId, ListOrganizationMembersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternUid))
            {
                query["externUid"] = request.ExternUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JoinTimeFrom))
            {
                query["joinTimeFrom"] = request.JoinTimeFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JoinTimeTo))
            {
                query["joinTimeTo"] = request.JoinTimeTo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationMemberName))
            {
                query["organizationMemberName"] = request.OrganizationMemberName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["state"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrganizationMembers",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrganizationMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListPipelineGroupPipelinesResponse ListPipelineGroupPipelines(string organizationId, string groupId, ListPipelineGroupPipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPipelineGroupPipelinesWithOptions(organizationId, groupId, request, headers, runtime);
        }

        public async Task<ListPipelineGroupPipelinesResponse> ListPipelineGroupPipelinesAsync(string organizationId, string groupId, ListPipelineGroupPipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPipelineGroupPipelinesWithOptionsAsync(organizationId, groupId, request, headers, runtime);
        }

        public ListPipelineGroupPipelinesResponse ListPipelineGroupPipelinesWithOptions(string organizationId, string groupId, ListPipelineGroupPipelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndTime))
            {
                query["createEndTime"] = request.CreateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartTime))
            {
                query["createStartTime"] = request.CreateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteEndTime))
            {
                query["executeEndTime"] = request.ExecuteEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteStartTime))
            {
                query["executeStartTime"] = request.ExecuteStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineName))
            {
                query["pipelineName"] = request.PipelineName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultStatusList))
            {
                query["resultStatusList"] = request.ResultStatusList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelineGroupPipelines",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelineGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/pipelines",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelineGroupPipelinesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPipelineGroupPipelinesResponse> ListPipelineGroupPipelinesWithOptionsAsync(string organizationId, string groupId, ListPipelineGroupPipelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndTime))
            {
                query["createEndTime"] = request.CreateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartTime))
            {
                query["createStartTime"] = request.CreateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteEndTime))
            {
                query["executeEndTime"] = request.ExecuteEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteStartTime))
            {
                query["executeStartTime"] = request.ExecuteStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineName))
            {
                query["pipelineName"] = request.PipelineName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultStatusList))
            {
                query["resultStatusList"] = request.ResultStatusList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelineGroupPipelines",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelineGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/pipelines",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelineGroupPipelinesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListPipelineGroupsResponse ListPipelineGroups(string organizationId, ListPipelineGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPipelineGroupsWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<ListPipelineGroupsResponse> ListPipelineGroupsAsync(string organizationId, ListPipelineGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPipelineGroupsWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public ListPipelineGroupsResponse ListPipelineGroupsWithOptions(string organizationId, ListPipelineGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelineGroups",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelineGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelineGroupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPipelineGroupsResponse> ListPipelineGroupsWithOptionsAsync(string organizationId, ListPipelineGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelineGroups",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelineGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelineGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListPipelineJobHistorysResponse ListPipelineJobHistorys(string organizationId, string pipelineId, ListPipelineJobHistorysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPipelineJobHistorysWithOptions(organizationId, pipelineId, request, headers, runtime);
        }

        public async Task<ListPipelineJobHistorysResponse> ListPipelineJobHistorysAsync(string organizationId, string pipelineId, ListPipelineJobHistorysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPipelineJobHistorysWithOptionsAsync(organizationId, pipelineId, request, headers, runtime);
        }

        public ListPipelineJobHistorysResponse ListPipelineJobHistorysWithOptions(string organizationId, string pipelineId, ListPipelineJobHistorysRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelineJobHistorys",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/job/historys",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelineJobHistorysResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPipelineJobHistorysResponse> ListPipelineJobHistorysWithOptionsAsync(string organizationId, string pipelineId, ListPipelineJobHistorysRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelineJobHistorys",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/job/historys",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelineJobHistorysResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListPipelineJobsResponse ListPipelineJobs(string organizationId, string pipelineId, ListPipelineJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPipelineJobsWithOptions(organizationId, pipelineId, request, headers, runtime);
        }

        public async Task<ListPipelineJobsResponse> ListPipelineJobsAsync(string organizationId, string pipelineId, ListPipelineJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPipelineJobsWithOptionsAsync(organizationId, pipelineId, request, headers, runtime);
        }

        public ListPipelineJobsResponse ListPipelineJobsWithOptions(string organizationId, string pipelineId, ListPipelineJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelineJobs",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelineJobsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPipelineJobsResponse> ListPipelineJobsWithOptionsAsync(string organizationId, string pipelineId, ListPipelineJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelineJobs",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelineJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListPipelineRunsResponse ListPipelineRuns(string organizationId, string pipelineId, ListPipelineRunsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPipelineRunsWithOptions(organizationId, pipelineId, request, headers, runtime);
        }

        public async Task<ListPipelineRunsResponse> ListPipelineRunsAsync(string organizationId, string pipelineId, ListPipelineRunsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPipelineRunsWithOptionsAsync(organizationId, pipelineId, request, headers, runtime);
        }

        public ListPipelineRunsResponse ListPipelineRunsWithOptions(string organizationId, string pipelineId, ListPipelineRunsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerMode))
            {
                query["triggerMode"] = request.TriggerMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelineRuns",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/pipelineRuns",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelineRunsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPipelineRunsResponse> ListPipelineRunsWithOptionsAsync(string organizationId, string pipelineId, ListPipelineRunsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerMode))
            {
                query["triggerMode"] = request.TriggerMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelineRuns",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/pipelineRuns",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelineRunsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListPipelinesResponse ListPipelines(string organizationId, ListPipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPipelinesWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<ListPipelinesResponse> ListPipelinesAsync(string organizationId, ListPipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPipelinesWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public ListPipelinesResponse ListPipelinesWithOptions(string organizationId, ListPipelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndTime))
            {
                query["createEndTime"] = request.CreateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartTime))
            {
                query["createStartTime"] = request.CreateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorAccountIds))
            {
                query["creatorAccountIds"] = request.CreatorAccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteAccountIds))
            {
                query["executeAccountIds"] = request.ExecuteAccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteEndTime))
            {
                query["executeEndTime"] = request.ExecuteEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteStartTime))
            {
                query["executeStartTime"] = request.ExecuteStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineName))
            {
                query["pipelineName"] = request.PipelineName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                query["statusList"] = request.StatusList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelines",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelinesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPipelinesResponse> ListPipelinesWithOptionsAsync(string organizationId, ListPipelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndTime))
            {
                query["createEndTime"] = request.CreateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartTime))
            {
                query["createStartTime"] = request.CreateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorAccountIds))
            {
                query["creatorAccountIds"] = request.CreatorAccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteAccountIds))
            {
                query["executeAccountIds"] = request.ExecuteAccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteEndTime))
            {
                query["executeEndTime"] = request.ExecuteEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteStartTime))
            {
                query["executeStartTime"] = request.ExecuteStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineName))
            {
                query["pipelineName"] = request.PipelineName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                query["statusList"] = request.StatusList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelines",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelinesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListProjectMembersResponse ListProjectMembers(string organizationId, string projectId, ListProjectMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProjectMembersWithOptions(organizationId, projectId, request, headers, runtime);
        }

        public async Task<ListProjectMembersResponse> ListProjectMembersAsync(string organizationId, string projectId, ListProjectMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProjectMembersWithOptionsAsync(organizationId, projectId, request, headers, runtime);
        }

        public ListProjectMembersResponse ListProjectMembersWithOptions(string organizationId, string projectId, ListProjectMembersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["targetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjectMembers",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/listMembers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectMembersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListProjectMembersResponse> ListProjectMembersWithOptionsAsync(string organizationId, string projectId, ListProjectMembersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["targetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjectMembers",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/listMembers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListProjectTemplatesResponse ListProjectTemplates(string organizationId, ListProjectTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProjectTemplatesWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<ListProjectTemplatesResponse> ListProjectTemplatesAsync(string organizationId, ListProjectTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProjectTemplatesWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public ListProjectTemplatesResponse ListProjectTemplatesWithOptions(string organizationId, ListProjectTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjectTemplates",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/projects/listTemplates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectTemplatesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListProjectTemplatesResponse> ListProjectTemplatesWithOptionsAsync(string organizationId, ListProjectTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjectTemplates",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/projects/listTemplates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListProjectWorkitemTypesResponse ListProjectWorkitemTypes(string organizationId, string projectId, ListProjectWorkitemTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProjectWorkitemTypesWithOptions(organizationId, projectId, request, headers, runtime);
        }

        public async Task<ListProjectWorkitemTypesResponse> ListProjectWorkitemTypesAsync(string organizationId, string projectId, ListProjectWorkitemTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProjectWorkitemTypesWithOptionsAsync(organizationId, projectId, request, headers, runtime);
        }

        public ListProjectWorkitemTypesResponse ListProjectWorkitemTypesWithOptions(string organizationId, string projectId, ListProjectWorkitemTypesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceType))
            {
                query["spaceType"] = request.SpaceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjectWorkitemTypes",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/getWorkitemType",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectWorkitemTypesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListProjectWorkitemTypesResponse> ListProjectWorkitemTypesWithOptionsAsync(string organizationId, string projectId, ListProjectWorkitemTypesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceType))
            {
                query["spaceType"] = request.SpaceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjectWorkitemTypes",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/getWorkitemType",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectWorkitemTypesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListProjectsResponse ListProjects(string organizationId, ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProjectsWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<ListProjectsResponse> ListProjectsAsync(string organizationId, ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProjectsWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public ListProjectsResponse ListProjectsWithOptions(string organizationId, ListProjectsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Conditions))
            {
                query["conditions"] = request.Conditions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraConditions))
            {
                query["extraConditions"] = request.ExtraConditions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
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
                Action = "ListProjects",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/listProjects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListProjectsResponse> ListProjectsWithOptionsAsync(string organizationId, ListProjectsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Conditions))
            {
                query["conditions"] = request.Conditions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraConditions))
            {
                query["extraConditions"] = request.ExtraConditions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
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
                Action = "ListProjects",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/listProjects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectsResponse>(await CallApiAsync(params_, req, runtime));
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
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Archived))
            {
                query["archived"] = request.Archived;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PerPage))
            {
                query["perPage"] = request.PerPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["sort"] = request.Sort;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositories",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/list",
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
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Archived))
            {
                query["archived"] = request.Archived;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PerPage))
            {
                query["perPage"] = request.PerPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Search))
            {
                query["search"] = request.Search;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["sort"] = request.Sort;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositories",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRepositoryCommitDiffResponse ListRepositoryCommitDiff(string repositoryId, string sha, ListRepositoryCommitDiffRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRepositoryCommitDiffWithOptions(repositoryId, sha, request, headers, runtime);
        }

        public async Task<ListRepositoryCommitDiffResponse> ListRepositoryCommitDiffAsync(string repositoryId, string sha, ListRepositoryCommitDiffRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRepositoryCommitDiffWithOptionsAsync(repositoryId, sha, request, headers, runtime);
        }

        public ListRepositoryCommitDiffResponse ListRepositoryCommitDiffWithOptions(string repositoryId, string sha, ListRepositoryCommitDiffRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextLine))
            {
                query["contextLine"] = request.ContextLine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryCommitDiff",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/commits/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sha) + "/diff",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryCommitDiffResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRepositoryCommitDiffResponse> ListRepositoryCommitDiffWithOptionsAsync(string repositoryId, string sha, ListRepositoryCommitDiffRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextLine))
            {
                query["contextLine"] = request.ContextLine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryCommitDiff",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/commits/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sha) + "/diff",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryCommitDiffResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRepositoryMemberWithInheritedResponse ListRepositoryMemberWithInherited(string repositoryId, ListRepositoryMemberWithInheritedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRepositoryMemberWithInheritedWithOptions(repositoryId, request, headers, runtime);
        }

        public async Task<ListRepositoryMemberWithInheritedResponse> ListRepositoryMemberWithInheritedAsync(string repositoryId, ListRepositoryMemberWithInheritedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRepositoryMemberWithInheritedWithOptionsAsync(repositoryId, request, headers, runtime);
        }

        public ListRepositoryMemberWithInheritedResponse ListRepositoryMemberWithInheritedWithOptions(string repositoryId, ListRepositoryMemberWithInheritedRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryMemberWithInherited",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/members/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryMemberWithInheritedResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRepositoryMemberWithInheritedResponse> ListRepositoryMemberWithInheritedWithOptionsAsync(string repositoryId, ListRepositoryMemberWithInheritedRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryMemberWithInherited",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/members/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryMemberWithInheritedResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRepositoryTreeResponse ListRepositoryTree(string repositoryId, ListRepositoryTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRepositoryTreeWithOptions(repositoryId, request, headers, runtime);
        }

        public async Task<ListRepositoryTreeResponse> ListRepositoryTreeAsync(string repositoryId, ListRepositoryTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRepositoryTreeWithOptionsAsync(repositoryId, request, headers, runtime);
        }

        public ListRepositoryTreeResponse ListRepositoryTreeWithOptions(string repositoryId, ListRepositoryTreeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefName))
            {
                query["refName"] = request.RefName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryTree",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/files/tree",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryTreeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRepositoryTreeResponse> ListRepositoryTreeWithOptionsAsync(string repositoryId, ListRepositoryTreeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefName))
            {
                query["refName"] = request.RefName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryTree",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/files/tree",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryTreeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRepositoryWebhookResponse ListRepositoryWebhook(string repositoryId, ListRepositoryWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRepositoryWebhookWithOptions(repositoryId, request, headers, runtime);
        }

        public async Task<ListRepositoryWebhookResponse> ListRepositoryWebhookAsync(string repositoryId, ListRepositoryWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRepositoryWebhookWithOptionsAsync(repositoryId, request, headers, runtime);
        }

        public ListRepositoryWebhookResponse ListRepositoryWebhookWithOptions(string repositoryId, ListRepositoryWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryWebhook",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/webhooks/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryWebhookResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRepositoryWebhookResponse> ListRepositoryWebhookWithOptionsAsync(string repositoryId, ListRepositoryWebhookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRepositoryWebhook",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/webhooks/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRepositoryWebhookResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListResourceMembersResponse ListResourceMembers(string organizationId, string resourceType, string resourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListResourceMembersWithOptions(organizationId, resourceType, resourceId, headers, runtime);
        }

        public async Task<ListResourceMembersResponse> ListResourceMembersAsync(string organizationId, string resourceType, string resourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListResourceMembersWithOptionsAsync(organizationId, resourceType, resourceId, headers, runtime);
        }

        public ListResourceMembersResponse ListResourceMembersWithOptions(string organizationId, string resourceType, string resourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceMembers",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceType) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceId) + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceMembersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListResourceMembersResponse> ListResourceMembersWithOptionsAsync(string organizationId, string resourceType, string resourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceMembers",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceType) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceId) + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListServiceConnectionsResponse ListServiceConnections(string organizationId, ListServiceConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServiceConnectionsWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<ListServiceConnectionsResponse> ListServiceConnectionsAsync(string organizationId, ListServiceConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServiceConnectionsWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public ListServiceConnectionsResponse ListServiceConnectionsWithOptions(string organizationId, ListServiceConnectionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SericeConnectionType))
            {
                query["sericeConnectionType"] = request.SericeConnectionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceConnections",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/serviceConnections",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceConnectionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListServiceConnectionsResponse> ListServiceConnectionsWithOptionsAsync(string organizationId, ListServiceConnectionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SericeConnectionType))
            {
                query["sericeConnectionType"] = request.SericeConnectionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceConnections",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/serviceConnections",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceConnectionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSprintsResponse ListSprints(string organizationId, ListSprintsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSprintsWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<ListSprintsResponse> ListSprintsAsync(string organizationId, ListSprintsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSprintsWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public ListSprintsResponse ListSprintsWithOptions(string organizationId, ListSprintsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceIdentifier))
            {
                query["spaceIdentifier"] = request.SpaceIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceType))
            {
                query["spaceType"] = request.SpaceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSprints",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/sprints/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSprintsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSprintsResponse> ListSprintsWithOptionsAsync(string organizationId, ListSprintsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceIdentifier))
            {
                query["spaceIdentifier"] = request.SpaceIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceType))
            {
                query["spaceType"] = request.SpaceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSprints",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/sprints/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSprintsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListVariableGroupsResponse ListVariableGroups(string organizationId, ListVariableGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListVariableGroupsWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<ListVariableGroupsResponse> ListVariableGroupsAsync(string organizationId, ListVariableGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListVariableGroupsWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public ListVariableGroupsResponse ListVariableGroupsWithOptions(string organizationId, ListVariableGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageOrder))
            {
                query["pageOrder"] = request.PageOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSort))
            {
                query["pageSort"] = request.PageSort;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVariableGroups",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/variableGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVariableGroupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListVariableGroupsResponse> ListVariableGroupsWithOptionsAsync(string organizationId, ListVariableGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageOrder))
            {
                query["pageOrder"] = request.PageOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSort))
            {
                query["pageSort"] = request.PageSort;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVariableGroups",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/variableGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVariableGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListWorkItemAllFieldsResponse ListWorkItemAllFields(string organizationId, ListWorkItemAllFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWorkItemAllFieldsWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<ListWorkItemAllFieldsResponse> ListWorkItemAllFieldsAsync(string organizationId, ListWorkItemAllFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWorkItemAllFieldsWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public ListWorkItemAllFieldsResponse ListWorkItemAllFieldsWithOptions(string organizationId, ListWorkItemAllFieldsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceIdentifier))
            {
                query["spaceIdentifier"] = request.SpaceIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceType))
            {
                query["spaceType"] = request.SpaceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkitemTypeIdentifier))
            {
                query["workitemTypeIdentifier"] = request.WorkitemTypeIdentifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkItemAllFields",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/workitems/fields/listAll",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkItemAllFieldsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListWorkItemAllFieldsResponse> ListWorkItemAllFieldsWithOptionsAsync(string organizationId, ListWorkItemAllFieldsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceIdentifier))
            {
                query["spaceIdentifier"] = request.SpaceIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceType))
            {
                query["spaceType"] = request.SpaceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkitemTypeIdentifier))
            {
                query["workitemTypeIdentifier"] = request.WorkitemTypeIdentifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkItemAllFields",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/workitems/fields/listAll",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkItemAllFieldsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListWorkItemWorkFlowStatusResponse ListWorkItemWorkFlowStatus(string organizationId, ListWorkItemWorkFlowStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWorkItemWorkFlowStatusWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<ListWorkItemWorkFlowStatusResponse> ListWorkItemWorkFlowStatusAsync(string organizationId, ListWorkItemWorkFlowStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWorkItemWorkFlowStatusWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public ListWorkItemWorkFlowStatusResponse ListWorkItemWorkFlowStatusWithOptions(string organizationId, ListWorkItemWorkFlowStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceIdentifier))
            {
                query["spaceIdentifier"] = request.SpaceIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceType))
            {
                query["spaceType"] = request.SpaceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkitemCategoryIdentifier))
            {
                query["workitemCategoryIdentifier"] = request.WorkitemCategoryIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkitemTypeIdentifier))
            {
                query["workitemTypeIdentifier"] = request.WorkitemTypeIdentifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkItemWorkFlowStatus",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/workitems/workflow/listWorkflowStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkItemWorkFlowStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListWorkItemWorkFlowStatusResponse> ListWorkItemWorkFlowStatusWithOptionsAsync(string organizationId, ListWorkItemWorkFlowStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceIdentifier))
            {
                query["spaceIdentifier"] = request.SpaceIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceType))
            {
                query["spaceType"] = request.SpaceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkitemCategoryIdentifier))
            {
                query["workitemCategoryIdentifier"] = request.WorkitemCategoryIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkitemTypeIdentifier))
            {
                query["workitemTypeIdentifier"] = request.WorkitemTypeIdentifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkItemWorkFlowStatus",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/workitems/workflow/listWorkflowStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkItemWorkFlowStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListWorkitemTimeResponse ListWorkitemTime(string organizationId, string workitemId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWorkitemTimeWithOptions(organizationId, workitemId, headers, runtime);
        }

        public async Task<ListWorkitemTimeResponse> ListWorkitemTimeAsync(string organizationId, string workitemId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWorkitemTimeWithOptionsAsync(organizationId, workitemId, headers, runtime);
        }

        public ListWorkitemTimeResponse ListWorkitemTimeWithOptions(string organizationId, string workitemId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkitemTime",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/workitems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workitemId) + "/time/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkitemTimeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListWorkitemTimeResponse> ListWorkitemTimeWithOptionsAsync(string organizationId, string workitemId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkitemTime",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/workitems/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workitemId) + "/time/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkitemTimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListWorkitemsResponse ListWorkitems(string organizationId, ListWorkitemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWorkitemsWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<ListWorkitemsResponse> ListWorkitemsAsync(string organizationId, ListWorkitemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWorkitemsWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public ListWorkitemsResponse ListWorkitemsWithOptions(string organizationId, ListWorkitemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Conditions))
            {
                query["conditions"] = request.Conditions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraConditions))
            {
                query["extraConditions"] = request.ExtraConditions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupCondition))
            {
                query["groupCondition"] = request.GroupCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["searchType"] = request.SearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceIdentifier))
            {
                query["spaceIdentifier"] = request.SpaceIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceType))
            {
                query["spaceType"] = request.SpaceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkitems",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/listWorkitems",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkitemsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListWorkitemsResponse> ListWorkitemsWithOptionsAsync(string organizationId, ListWorkitemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Conditions))
            {
                query["conditions"] = request.Conditions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraConditions))
            {
                query["extraConditions"] = request.ExtraConditions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupCondition))
            {
                query["groupCondition"] = request.GroupCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                query["searchType"] = request.SearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceIdentifier))
            {
                query["spaceIdentifier"] = request.SpaceIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceType))
            {
                query["spaceType"] = request.SpaceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkitems",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/listWorkitems",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkitemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWorkspacesWithOptions(request, headers, runtime);
        }

        public async Task<ListWorkspacesResponse> ListWorkspacesAsync(ListWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWorkspacesWithOptionsAsync(request, headers, runtime);
        }

        public ListWorkspacesResponse ListWorkspacesWithOptions(ListWorkspacesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWorkspacesShrinkRequest request = new ListWorkspacesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StatusList))
            {
                request.StatusListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StatusList, "statusList", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WorkspaceTemplateList))
            {
                request.WorkspaceTemplateListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WorkspaceTemplateList, "workspaceTemplateList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusListShrink))
            {
                query["statusList"] = request.StatusListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceTemplateListShrink))
            {
                query["workspaceTemplateList"] = request.WorkspaceTemplateListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaces",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/api/workspaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListWorkspacesResponse> ListWorkspacesWithOptionsAsync(ListWorkspacesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWorkspacesShrinkRequest request = new ListWorkspacesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StatusList))
            {
                request.StatusListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StatusList, "statusList", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WorkspaceTemplateList))
            {
                request.WorkspaceTemplateListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WorkspaceTemplateList, "workspaceTemplateList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusListShrink))
            {
                query["statusList"] = request.StatusListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceTemplateListShrink))
            {
                query["workspaceTemplateList"] = request.WorkspaceTemplateListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkspaces",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/api/workspaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkspacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public LogPipelineJobRunResponse LogPipelineJobRun(string organizationId, string pipelineId, string jobId, string pipelineRunId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return LogPipelineJobRunWithOptions(organizationId, pipelineId, jobId, pipelineRunId, headers, runtime);
        }

        public async Task<LogPipelineJobRunResponse> LogPipelineJobRunAsync(string organizationId, string pipelineId, string jobId, string pipelineRunId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await LogPipelineJobRunWithOptionsAsync(organizationId, pipelineId, jobId, pipelineRunId, headers, runtime);
        }

        public LogPipelineJobRunResponse LogPipelineJobRunWithOptions(string organizationId, string pipelineId, string jobId, string pipelineRunId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LogPipelineJobRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/pipelineRun/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId) + "/job/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<LogPipelineJobRunResponse>(CallApi(params_, req, runtime));
        }

        public async Task<LogPipelineJobRunResponse> LogPipelineJobRunWithOptionsAsync(string organizationId, string pipelineId, string jobId, string pipelineRunId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LogPipelineJobRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipeline/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/pipelineRun/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId) + "/job/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<LogPipelineJobRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        public LogVMDeployMachineResponse LogVMDeployMachine(string organizationId, string pipelineId, string deployOrderId, string machineSn)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return LogVMDeployMachineWithOptions(organizationId, pipelineId, deployOrderId, machineSn, headers, runtime);
        }

        public async Task<LogVMDeployMachineResponse> LogVMDeployMachineAsync(string organizationId, string pipelineId, string deployOrderId, string machineSn)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await LogVMDeployMachineWithOptionsAsync(organizationId, pipelineId, deployOrderId, machineSn, headers, runtime);
        }

        public LogVMDeployMachineResponse LogVMDeployMachineWithOptions(string organizationId, string pipelineId, string deployOrderId, string machineSn, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LogVMDeployMachine",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/deploy/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId) + "/machine/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(machineSn) + "/log",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<LogVMDeployMachineResponse>(CallApi(params_, req, runtime));
        }

        public async Task<LogVMDeployMachineResponse> LogVMDeployMachineWithOptionsAsync(string organizationId, string pipelineId, string deployOrderId, string machineSn, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LogVMDeployMachine",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/deploy/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId) + "/machine/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(machineSn) + "/log",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<LogVMDeployMachineResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PassPipelineValidateResponse PassPipelineValidate(string organizationId, string pipelineId, string pipelineRunId, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PassPipelineValidateWithOptions(organizationId, pipelineId, pipelineRunId, jobId, headers, runtime);
        }

        public async Task<PassPipelineValidateResponse> PassPipelineValidateAsync(string organizationId, string pipelineId, string pipelineRunId, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PassPipelineValidateWithOptionsAsync(organizationId, pipelineId, pipelineRunId, jobId, headers, runtime);
        }

        public PassPipelineValidateResponse PassPipelineValidateWithOptions(string organizationId, string pipelineId, string pipelineRunId, string jobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PassPipelineValidate",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/pipelineRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "/pass",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PassPipelineValidateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PassPipelineValidateResponse> PassPipelineValidateWithOptionsAsync(string organizationId, string pipelineId, string pipelineRunId, string jobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PassPipelineValidate",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/pipelineRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "/pass",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PassPipelineValidateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RefusePipelineValidateResponse RefusePipelineValidate(string organizationId, string pipelineId, string pipelineRunId, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RefusePipelineValidateWithOptions(organizationId, pipelineId, pipelineRunId, jobId, headers, runtime);
        }

        public async Task<RefusePipelineValidateResponse> RefusePipelineValidateAsync(string organizationId, string pipelineId, string pipelineRunId, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RefusePipelineValidateWithOptionsAsync(organizationId, pipelineId, pipelineRunId, jobId, headers, runtime);
        }

        public RefusePipelineValidateResponse RefusePipelineValidateWithOptions(string organizationId, string pipelineId, string pipelineRunId, string jobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefusePipelineValidate",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/pipelineRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "/refuse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefusePipelineValidateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RefusePipelineValidateResponse> RefusePipelineValidateWithOptionsAsync(string organizationId, string pipelineId, string pipelineRunId, string jobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefusePipelineValidate",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/pipelineRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "/refuse",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefusePipelineValidateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReleaseWorkspaceResponse ReleaseWorkspace(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReleaseWorkspaceWithOptions(workspaceId, headers, runtime);
        }

        public async Task<ReleaseWorkspaceResponse> ReleaseWorkspaceAsync(string workspaceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReleaseWorkspaceWithOptionsAsync(workspaceId, headers, runtime);
        }

        public ReleaseWorkspaceResponse ReleaseWorkspaceWithOptions(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseWorkspace",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/api/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/release",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReleaseWorkspaceResponse> ReleaseWorkspaceWithOptionsAsync(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseWorkspace",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/api/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/release",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ResetSshKeyResponse ResetSshKey(string organizationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResetSshKeyWithOptions(organizationId, headers, runtime);
        }

        public async Task<ResetSshKeyResponse> ResetSshKeyAsync(string organizationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResetSshKeyWithOptionsAsync(organizationId, headers, runtime);
        }

        public ResetSshKeyResponse ResetSshKeyWithOptions(string organizationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetSshKey",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/sshKey",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetSshKeyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ResetSshKeyResponse> ResetSshKeyWithOptionsAsync(string organizationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetSshKey",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/sshKey",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetSshKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ResumeVMDeployOrderResponse ResumeVMDeployOrder(string organizationId, string pipelineId, string deployOrderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResumeVMDeployOrderWithOptions(organizationId, pipelineId, deployOrderId, headers, runtime);
        }

        public async Task<ResumeVMDeployOrderResponse> ResumeVMDeployOrderAsync(string organizationId, string pipelineId, string deployOrderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResumeVMDeployOrderWithOptionsAsync(organizationId, pipelineId, deployOrderId, headers, runtime);
        }

        public ResumeVMDeployOrderResponse ResumeVMDeployOrderWithOptions(string organizationId, string pipelineId, string deployOrderId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeVMDeployOrder",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/deploy/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId) + "/resume",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeVMDeployOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ResumeVMDeployOrderResponse> ResumeVMDeployOrderWithOptionsAsync(string organizationId, string pipelineId, string deployOrderId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeVMDeployOrder",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/deploy/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId) + "/resume",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeVMDeployOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RetryPipelineJobRunResponse RetryPipelineJobRun(string organizationId, string pipelineId, string pipelineRunId, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RetryPipelineJobRunWithOptions(organizationId, pipelineId, pipelineRunId, jobId, headers, runtime);
        }

        public async Task<RetryPipelineJobRunResponse> RetryPipelineJobRunAsync(string organizationId, string pipelineId, string pipelineRunId, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RetryPipelineJobRunWithOptionsAsync(organizationId, pipelineId, pipelineRunId, jobId, headers, runtime);
        }

        public RetryPipelineJobRunResponse RetryPipelineJobRunWithOptions(string organizationId, string pipelineId, string pipelineRunId, string jobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryPipelineJobRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/pipelineRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryPipelineJobRunResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RetryPipelineJobRunResponse> RetryPipelineJobRunWithOptionsAsync(string organizationId, string pipelineId, string pipelineRunId, string jobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryPipelineJobRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/pipelineRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryPipelineJobRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RetryVMDeployMachineResponse RetryVMDeployMachine(string organizationId, string pipelineId, string deployOrderId, string machineSn)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RetryVMDeployMachineWithOptions(organizationId, pipelineId, deployOrderId, machineSn, headers, runtime);
        }

        public async Task<RetryVMDeployMachineResponse> RetryVMDeployMachineAsync(string organizationId, string pipelineId, string deployOrderId, string machineSn)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RetryVMDeployMachineWithOptionsAsync(organizationId, pipelineId, deployOrderId, machineSn, headers, runtime);
        }

        public RetryVMDeployMachineResponse RetryVMDeployMachineWithOptions(string organizationId, string pipelineId, string deployOrderId, string machineSn, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryVMDeployMachine",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/deploy/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId) + "/machine/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(machineSn) + "/retry",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryVMDeployMachineResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RetryVMDeployMachineResponse> RetryVMDeployMachineWithOptionsAsync(string organizationId, string pipelineId, string deployOrderId, string machineSn, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryVMDeployMachine",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/deploy/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId) + "/machine/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(machineSn) + "/retry",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryVMDeployMachineResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SkipPipelineJobRunResponse SkipPipelineJobRun(string organizationId, string pipelineId, string pipelineRunId, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SkipPipelineJobRunWithOptions(organizationId, pipelineId, pipelineRunId, jobId, headers, runtime);
        }

        public async Task<SkipPipelineJobRunResponse> SkipPipelineJobRunAsync(string organizationId, string pipelineId, string pipelineRunId, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SkipPipelineJobRunWithOptionsAsync(organizationId, pipelineId, pipelineRunId, jobId, headers, runtime);
        }

        public SkipPipelineJobRunResponse SkipPipelineJobRunWithOptions(string organizationId, string pipelineId, string pipelineRunId, string jobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SkipPipelineJobRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/pipelineRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "/skip",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SkipPipelineJobRunResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SkipPipelineJobRunResponse> SkipPipelineJobRunWithOptionsAsync(string organizationId, string pipelineId, string pipelineRunId, string jobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SkipPipelineJobRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/pipelineRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "/skip",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SkipPipelineJobRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SkipVMDeployMachineResponse SkipVMDeployMachine(string organizationId, string pipelineId, string deployOrderId, string machineSn)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SkipVMDeployMachineWithOptions(organizationId, pipelineId, deployOrderId, machineSn, headers, runtime);
        }

        public async Task<SkipVMDeployMachineResponse> SkipVMDeployMachineAsync(string organizationId, string pipelineId, string deployOrderId, string machineSn)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SkipVMDeployMachineWithOptionsAsync(organizationId, pipelineId, deployOrderId, machineSn, headers, runtime);
        }

        public SkipVMDeployMachineResponse SkipVMDeployMachineWithOptions(string organizationId, string pipelineId, string deployOrderId, string machineSn, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SkipVMDeployMachine",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/deploy/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId) + "/machine/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(machineSn) + "/skip",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SkipVMDeployMachineResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SkipVMDeployMachineResponse> SkipVMDeployMachineWithOptionsAsync(string organizationId, string pipelineId, string deployOrderId, string machineSn, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SkipVMDeployMachine",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/deploy/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId) + "/machine/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(machineSn) + "/skip",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SkipVMDeployMachineResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartPipelineRunResponse StartPipelineRun(string organizationId, string pipelineId, StartPipelineRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartPipelineRunWithOptions(organizationId, pipelineId, request, headers, runtime);
        }

        public async Task<StartPipelineRunResponse> StartPipelineRunAsync(string organizationId, string pipelineId, StartPipelineRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartPipelineRunWithOptionsAsync(organizationId, pipelineId, request, headers, runtime);
        }

        public StartPipelineRunResponse StartPipelineRunWithOptions(string organizationId, string pipelineId, StartPipelineRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartPipelineRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organizations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/run",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartPipelineRunResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartPipelineRunResponse> StartPipelineRunWithOptionsAsync(string organizationId, string pipelineId, StartPipelineRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartPipelineRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organizations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/run",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartPipelineRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopPipelineJobRunResponse StopPipelineJobRun(string organizationId, string pipelineId, string pipelineRunId, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopPipelineJobRunWithOptions(organizationId, pipelineId, pipelineRunId, jobId, headers, runtime);
        }

        public async Task<StopPipelineJobRunResponse> StopPipelineJobRunAsync(string organizationId, string pipelineId, string pipelineRunId, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopPipelineJobRunWithOptionsAsync(organizationId, pipelineId, pipelineRunId, jobId, headers, runtime);
        }

        public StopPipelineJobRunResponse StopPipelineJobRunWithOptions(string organizationId, string pipelineId, string pipelineRunId, string jobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopPipelineJobRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/pipelineRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopPipelineJobRunResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopPipelineJobRunResponse> StopPipelineJobRunWithOptionsAsync(string organizationId, string pipelineId, string pipelineRunId, string jobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopPipelineJobRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/pipelineRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopPipelineJobRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopPipelineRunResponse StopPipelineRun(string organizationId, string pipelineId, string pipelineRunId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopPipelineRunWithOptions(organizationId, pipelineId, pipelineRunId, headers, runtime);
        }

        public async Task<StopPipelineRunResponse> StopPipelineRunAsync(string organizationId, string pipelineId, string pipelineRunId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopPipelineRunWithOptionsAsync(organizationId, pipelineId, pipelineRunId, headers, runtime);
        }

        public StopPipelineRunResponse StopPipelineRunWithOptions(string organizationId, string pipelineId, string pipelineRunId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopPipelineRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/pipelineRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopPipelineRunResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopPipelineRunResponse> StopPipelineRunWithOptionsAsync(string organizationId, string pipelineId, string pipelineRunId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopPipelineRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/pipelineRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopPipelineRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopVMDeployOrderResponse StopVMDeployOrder(string organizationId, string pipelineId, string deployOrderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopVMDeployOrderWithOptions(organizationId, pipelineId, deployOrderId, headers, runtime);
        }

        public async Task<StopVMDeployOrderResponse> StopVMDeployOrderAsync(string organizationId, string pipelineId, string deployOrderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopVMDeployOrderWithOptionsAsync(organizationId, pipelineId, deployOrderId, headers, runtime);
        }

        public StopVMDeployOrderResponse StopVMDeployOrderWithOptions(string organizationId, string pipelineId, string deployOrderId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopVMDeployOrder",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/deploy/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopVMDeployOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopVMDeployOrderResponse> StopVMDeployOrderWithOptionsAsync(string organizationId, string pipelineId, string deployOrderId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopVMDeployOrder",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/deploy/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopVMDeployOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TriggerRepositoryMirrorSyncResponse TriggerRepositoryMirrorSync(string repositoryId, TriggerRepositoryMirrorSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TriggerRepositoryMirrorSyncWithOptions(repositoryId, request, headers, runtime);
        }

        public async Task<TriggerRepositoryMirrorSyncResponse> TriggerRepositoryMirrorSyncAsync(string repositoryId, TriggerRepositoryMirrorSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TriggerRepositoryMirrorSyncWithOptionsAsync(repositoryId, request, headers, runtime);
        }

        public TriggerRepositoryMirrorSyncResponse TriggerRepositoryMirrorSyncWithOptions(string repositoryId, TriggerRepositoryMirrorSyncRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                query["account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerRepositoryMirrorSync",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/mirror",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerRepositoryMirrorSyncResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TriggerRepositoryMirrorSyncResponse> TriggerRepositoryMirrorSyncWithOptionsAsync(string repositoryId, TriggerRepositoryMirrorSyncRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                query["account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerRepositoryMirrorSync",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/mirror",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerRepositoryMirrorSyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateFileResponse UpdateFile(string repositoryId, UpdateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFileWithOptions(repositoryId, request, headers, runtime);
        }

        public async Task<UpdateFileResponse> UpdateFileAsync(string repositoryId, UpdateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFileWithOptionsAsync(repositoryId, request, headers, runtime);
        }

        public UpdateFileResponse UpdateFileWithOptions(string repositoryId, UpdateFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                body["branchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommitMessage))
            {
                body["commitMessage"] = request.CommitMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Encoding))
            {
                body["encoding"] = request.Encoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPath))
            {
                body["newPath"] = request.NewPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldPath))
            {
                body["oldPath"] = request.OldPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFile",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/files/update",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateFileResponse> UpdateFileWithOptionsAsync(string repositoryId, UpdateFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                body["branchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommitMessage))
            {
                body["commitMessage"] = request.CommitMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Encoding))
            {
                body["encoding"] = request.Encoding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPath))
            {
                body["newPath"] = request.NewPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldPath))
            {
                body["oldPath"] = request.OldPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFile",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/files/update",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateFlowTagResponse UpdateFlowTag(string organizationId, string id, UpdateFlowTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFlowTagWithOptions(organizationId, id, request, headers, runtime);
        }

        public async Task<UpdateFlowTagResponse> UpdateFlowTagAsync(string organizationId, string id, UpdateFlowTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFlowTagWithOptionsAsync(organizationId, id, request, headers, runtime);
        }

        public UpdateFlowTagResponse UpdateFlowTagWithOptions(string organizationId, string id, UpdateFlowTagRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Color))
            {
                query["color"] = request.Color;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowTagGroupId))
            {
                query["flowTagGroupId"] = request.FlowTagGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFlowTag",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/flow/tags/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFlowTagResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateFlowTagResponse> UpdateFlowTagWithOptionsAsync(string organizationId, string id, UpdateFlowTagRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Color))
            {
                query["color"] = request.Color;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowTagGroupId))
            {
                query["flowTagGroupId"] = request.FlowTagGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFlowTag",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/flow/tags/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFlowTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateFlowTagGroupResponse UpdateFlowTagGroup(string organizationId, string id, UpdateFlowTagGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFlowTagGroupWithOptions(organizationId, id, request, headers, runtime);
        }

        public async Task<UpdateFlowTagGroupResponse> UpdateFlowTagGroupAsync(string organizationId, string id, UpdateFlowTagGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFlowTagGroupWithOptionsAsync(organizationId, id, request, headers, runtime);
        }

        public UpdateFlowTagGroupResponse UpdateFlowTagGroupWithOptions(string organizationId, string id, UpdateFlowTagGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFlowTagGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/flow/tagGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFlowTagGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateFlowTagGroupResponse> UpdateFlowTagGroupWithOptionsAsync(string organizationId, string id, UpdateFlowTagGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFlowTagGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/flow/tagGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFlowTagGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateHostGroupResponse UpdateHostGroup(string organizationId, string id, UpdateHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateHostGroupWithOptions(organizationId, id, request, headers, runtime);
        }

        public async Task<UpdateHostGroupResponse> UpdateHostGroupAsync(string organizationId, string id, UpdateHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateHostGroupWithOptionsAsync(organizationId, id, request, headers, runtime);
        }

        public UpdateHostGroupResponse UpdateHostGroupWithOptions(string organizationId, string id, UpdateHostGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunRegion))
            {
                body["aliyunRegion"] = request.AliyunRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsLabelKey))
            {
                body["ecsLabelKey"] = request.EcsLabelKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsLabelValue))
            {
                body["ecsLabelValue"] = request.EcsLabelValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsType))
            {
                body["ecsType"] = request.EcsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["envId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MachineInfos))
            {
                body["machineInfos"] = request.MachineInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceConnectionId))
            {
                body["serviceConnectionId"] = request.ServiceConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagIds))
            {
                body["tagIds"] = request.TagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHostGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/hostGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHostGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateHostGroupResponse> UpdateHostGroupWithOptionsAsync(string organizationId, string id, UpdateHostGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunRegion))
            {
                body["aliyunRegion"] = request.AliyunRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsLabelKey))
            {
                body["ecsLabelKey"] = request.EcsLabelKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsLabelValue))
            {
                body["ecsLabelValue"] = request.EcsLabelValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsType))
            {
                body["ecsType"] = request.EcsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["envId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MachineInfos))
            {
                body["machineInfos"] = request.MachineInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceConnectionId))
            {
                body["serviceConnectionId"] = request.ServiceConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagIds))
            {
                body["tagIds"] = request.TagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHostGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/hostGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHostGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdatePipelineBaseInfoResponse UpdatePipelineBaseInfo(string organizationId, string pipelineId, UpdatePipelineBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdatePipelineBaseInfoWithOptions(organizationId, pipelineId, request, headers, runtime);
        }

        public async Task<UpdatePipelineBaseInfoResponse> UpdatePipelineBaseInfoAsync(string organizationId, string pipelineId, UpdatePipelineBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdatePipelineBaseInfoWithOptionsAsync(organizationId, pipelineId, request, headers, runtime);
        }

        public UpdatePipelineBaseInfoResponse UpdatePipelineBaseInfoWithOptions(string organizationId, string pipelineId, UpdatePipelineBaseInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["envId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineName))
            {
                query["pipelineName"] = request.PipelineName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagList))
            {
                query["tagList"] = request.TagList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePipelineBaseInfo",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/baseInfo",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePipelineBaseInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdatePipelineBaseInfoResponse> UpdatePipelineBaseInfoWithOptionsAsync(string organizationId, string pipelineId, UpdatePipelineBaseInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                query["envId"] = request.EnvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineName))
            {
                query["pipelineName"] = request.PipelineName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagList))
            {
                query["tagList"] = request.TagList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePipelineBaseInfo",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId) + "/baseInfo",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePipelineBaseInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdatePipelineGroupResponse UpdatePipelineGroup(string organizationId, string groupId, UpdatePipelineGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdatePipelineGroupWithOptions(organizationId, groupId, request, headers, runtime);
        }

        public async Task<UpdatePipelineGroupResponse> UpdatePipelineGroupAsync(string organizationId, string groupId, UpdatePipelineGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdatePipelineGroupWithOptionsAsync(organizationId, groupId, request, headers, runtime);
        }

        public UpdatePipelineGroupResponse UpdatePipelineGroupWithOptions(string organizationId, string groupId, UpdatePipelineGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePipelineGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelineGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePipelineGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdatePipelineGroupResponse> UpdatePipelineGroupWithOptionsAsync(string organizationId, string groupId, UpdatePipelineGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePipelineGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/pipelineGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePipelineGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateProjectMemberResponse UpdateProjectMember(string organizationId, string projectId, UpdateProjectMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProjectMemberWithOptions(organizationId, projectId, request, headers, runtime);
        }

        public async Task<UpdateProjectMemberResponse> UpdateProjectMemberAsync(string organizationId, string projectId, UpdateProjectMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProjectMemberWithOptionsAsync(organizationId, projectId, request, headers, runtime);
        }

        public UpdateProjectMemberResponse UpdateProjectMemberWithOptions(string organizationId, string projectId, UpdateProjectMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIdentifier))
            {
                body["roleIdentifier"] = request.RoleIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetIdentifier))
            {
                body["targetIdentifier"] = request.TargetIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                body["targetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdentifier))
            {
                body["userIdentifier"] = request.UserIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                body["userType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProjectMember",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/updateMember",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectMemberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateProjectMemberResponse> UpdateProjectMemberWithOptionsAsync(string organizationId, string projectId, UpdateProjectMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIdentifier))
            {
                body["roleIdentifier"] = request.RoleIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetIdentifier))
            {
                body["targetIdentifier"] = request.TargetIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                body["targetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdentifier))
            {
                body["userIdentifier"] = request.UserIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                body["userType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProjectMember",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/updateMember",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateProtectedBranchesResponse UpdateProtectedBranches(string repositoryId, string id, UpdateProtectedBranchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProtectedBranchesWithOptions(repositoryId, id, request, headers, runtime);
        }

        public async Task<UpdateProtectedBranchesResponse> UpdateProtectedBranchesAsync(string repositoryId, string id, UpdateProtectedBranchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProtectedBranchesWithOptionsAsync(repositoryId, id, request, headers, runtime);
        }

        public UpdateProtectedBranchesResponse UpdateProtectedBranchesWithOptions(string repositoryId, string id, UpdateProtectedBranchesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowMergeRoles))
            {
                body["allowMergeRoles"] = request.AllowMergeRoles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowMergeUserIds))
            {
                body["allowMergeUserIds"] = request.AllowMergeUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowPushRoles))
            {
                body["allowPushRoles"] = request.AllowPushRoles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowPushUserIds))
            {
                body["allowPushUserIds"] = request.AllowPushUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Branch))
            {
                body["branch"] = request.Branch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergeRequestSetting.ToMap()))
            {
                body["mergeRequestSetting"] = request.MergeRequestSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TestSettingDTO.ToMap()))
            {
                body["testSettingDTO"] = request.TestSettingDTO;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProtectedBranches",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/protect_branches/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProtectedBranchesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateProtectedBranchesResponse> UpdateProtectedBranchesWithOptionsAsync(string repositoryId, string id, UpdateProtectedBranchesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowMergeRoles))
            {
                body["allowMergeRoles"] = request.AllowMergeRoles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowMergeUserIds))
            {
                body["allowMergeUserIds"] = request.AllowMergeUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowPushRoles))
            {
                body["allowPushRoles"] = request.AllowPushRoles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowPushUserIds))
            {
                body["allowPushUserIds"] = request.AllowPushUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Branch))
            {
                body["branch"] = request.Branch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergeRequestSetting.ToMap()))
            {
                body["mergeRequestSetting"] = request.MergeRequestSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TestSettingDTO.ToMap()))
            {
                body["testSettingDTO"] = request.TestSettingDTO;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProtectedBranches",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/protect_branches/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProtectedBranchesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateRepositoryResponse UpdateRepository(string repositoryId, UpdateRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateRepositoryWithOptions(repositoryId, request, headers, runtime);
        }

        public async Task<UpdateRepositoryResponse> UpdateRepositoryAsync(string repositoryId, UpdateRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateRepositoryWithOptionsAsync(repositoryId, request, headers, runtime);
        }

        public UpdateRepositoryResponse UpdateRepositoryWithOptions(string repositoryId, UpdateRepositoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminSettingLanguage))
            {
                body["adminSettingLanguage"] = request.AdminSettingLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Avatar))
            {
                body["avatar"] = request.Avatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildsEnabled))
            {
                body["buildsEnabled"] = request.BuildsEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckEmail))
            {
                body["checkEmail"] = request.CheckEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultBranch))
            {
                body["defaultBranch"] = request.DefaultBranch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssuesEnabled))
            {
                body["issuesEnabled"] = request.IssuesEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergeRequestsEnabled))
            {
                body["mergeRequestsEnabled"] = request.MergeRequestsEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenCloneDownloadControl))
            {
                body["openCloneDownloadControl"] = request.OpenCloneDownloadControl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectCloneDownloadMethodList))
            {
                body["projectCloneDownloadMethodList"] = request.ProjectCloneDownloadMethodList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectCloneDownloadRoleList))
            {
                body["projectCloneDownloadRoleList"] = request.ProjectCloneDownloadRoleList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnippetsEnabled))
            {
                body["snippetsEnabled"] = request.SnippetsEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisibilityLevel))
            {
                body["visibilityLevel"] = request.VisibilityLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WikiEnabled))
            {
                body["wikiEnabled"] = request.WikiEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRepository",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRepositoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateRepositoryResponse> UpdateRepositoryWithOptionsAsync(string repositoryId, UpdateRepositoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdminSettingLanguage))
            {
                body["adminSettingLanguage"] = request.AdminSettingLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Avatar))
            {
                body["avatar"] = request.Avatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildsEnabled))
            {
                body["buildsEnabled"] = request.BuildsEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckEmail))
            {
                body["checkEmail"] = request.CheckEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultBranch))
            {
                body["defaultBranch"] = request.DefaultBranch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssuesEnabled))
            {
                body["issuesEnabled"] = request.IssuesEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MergeRequestsEnabled))
            {
                body["mergeRequestsEnabled"] = request.MergeRequestsEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenCloneDownloadControl))
            {
                body["openCloneDownloadControl"] = request.OpenCloneDownloadControl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectCloneDownloadMethodList))
            {
                body["projectCloneDownloadMethodList"] = request.ProjectCloneDownloadMethodList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectCloneDownloadRoleList))
            {
                body["projectCloneDownloadRoleList"] = request.ProjectCloneDownloadRoleList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnippetsEnabled))
            {
                body["snippetsEnabled"] = request.SnippetsEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisibilityLevel))
            {
                body["visibilityLevel"] = request.VisibilityLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WikiEnabled))
            {
                body["wikiEnabled"] = request.WikiEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRepository",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRepositoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateRepositoryMemberResponse UpdateRepositoryMember(string repositoryId, string userId, UpdateRepositoryMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateRepositoryMemberWithOptions(repositoryId, userId, request, headers, runtime);
        }

        public async Task<UpdateRepositoryMemberResponse> UpdateRepositoryMemberAsync(string repositoryId, string userId, UpdateRepositoryMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateRepositoryMemberWithOptionsAsync(repositoryId, userId, request, headers, runtime);
        }

        public UpdateRepositoryMemberResponse UpdateRepositoryMemberWithOptions(string repositoryId, string userId, UpdateRepositoryMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLevel))
            {
                body["accessLevel"] = request.AccessLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireAt))
            {
                body["expireAt"] = request.ExpireAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberType))
            {
                body["memberType"] = request.MemberType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedId))
            {
                body["relatedId"] = request.RelatedId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedInfos))
            {
                body["relatedInfos"] = request.RelatedInfos;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRepositoryMember",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRepositoryMemberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateRepositoryMemberResponse> UpdateRepositoryMemberWithOptionsAsync(string repositoryId, string userId, UpdateRepositoryMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["accessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLevel))
            {
                body["accessLevel"] = request.AccessLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireAt))
            {
                body["expireAt"] = request.ExpireAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberType))
            {
                body["memberType"] = request.MemberType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedId))
            {
                body["relatedId"] = request.RelatedId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedInfos))
            {
                body["relatedInfos"] = request.RelatedInfos;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRepositoryMember",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/repository/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(repositoryId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRepositoryMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateResourceMemberResponse UpdateResourceMember(string organizationId, string resourceType, string resourceId, string accountId, UpdateResourceMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateResourceMemberWithOptions(organizationId, resourceType, resourceId, accountId, request, headers, runtime);
        }

        public async Task<UpdateResourceMemberResponse> UpdateResourceMemberAsync(string organizationId, string resourceType, string resourceId, string accountId, UpdateResourceMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateResourceMemberWithOptionsAsync(organizationId, resourceType, resourceId, accountId, request, headers, runtime);
        }

        public UpdateResourceMemberResponse UpdateResourceMemberWithOptions(string organizationId, string resourceType, string resourceId, string accountId, UpdateResourceMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["roleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourceMember",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceType) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(accountId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceMemberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateResourceMemberResponse> UpdateResourceMemberWithOptionsAsync(string organizationId, string resourceType, string resourceId, string accountId, UpdateResourceMemberRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["roleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourceMember",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceType) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceId) + "/members/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(accountId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateVariableGroupResponse UpdateVariableGroup(string organizationId, string id, UpdateVariableGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateVariableGroupWithOptions(organizationId, id, request, headers, runtime);
        }

        public async Task<UpdateVariableGroupResponse> UpdateVariableGroupAsync(string organizationId, string id, UpdateVariableGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateVariableGroupWithOptionsAsync(organizationId, id, request, headers, runtime);
        }

        public UpdateVariableGroupResponse UpdateVariableGroupWithOptions(string organizationId, string id, UpdateVariableGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVariableGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/variableGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVariableGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateVariableGroupResponse> UpdateVariableGroupWithOptionsAsync(string organizationId, string id, UpdateVariableGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVariableGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/variableGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVariableGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateWorkItemResponse UpdateWorkItem(string organizationId, UpdateWorkItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateWorkItemWithOptions(organizationId, request, headers, runtime);
        }

        public async Task<UpdateWorkItemResponse> UpdateWorkItemAsync(string organizationId, UpdateWorkItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateWorkItemWithOptionsAsync(organizationId, request, headers, runtime);
        }

        public UpdateWorkItemResponse UpdateWorkItemWithOptions(string organizationId, UpdateWorkItemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldType))
            {
                body["fieldType"] = request.FieldType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                body["identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyKey))
            {
                body["propertyKey"] = request.PropertyKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyValue))
            {
                body["propertyValue"] = request.PropertyValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkItem",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/workitems/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkItemResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateWorkItemResponse> UpdateWorkItemWithOptionsAsync(string organizationId, UpdateWorkItemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldType))
            {
                body["fieldType"] = request.FieldType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                body["identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyKey))
            {
                body["propertyKey"] = request.PropertyKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyValue))
            {
                body["propertyValue"] = request.PropertyValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWorkItem",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId) + "/workitems/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkItemResponse>(await CallApiAsync(params_, req, runtime));
        }

    }
}
