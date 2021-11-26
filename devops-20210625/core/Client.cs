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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/hostGroups",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/hostGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHostGroupResponse>(await CallApiAsync(params_, req, runtime));
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            resourceType = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceType);
            resourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceId);
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
                Pathname = "/organization/" + organizationId + "/" + resourceType + "/" + resourceId + "/members",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            resourceType = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceType);
            resourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceId);
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
                Pathname = "/organization/" + organizationId + "/" + resourceType + "/" + resourceId + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceMemberResponse>(await CallApiAsync(params_, req, runtime));
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSshKey",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/sshKey",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSshKey",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/sshKey",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/variableGroups",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/variableGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVariableGroupResponse>(await CallApiAsync(params_, req, runtime));
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHostGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/hostGroups/" + id,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHostGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/hostGroups/" + id,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePipeline",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePipeline",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePipelineResponse>(await CallApiAsync(params_, req, runtime));
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            resourceType = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceType);
            resourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceId);
            accountId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(accountId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceMember",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/" + resourceType + "/" + resourceId + "/members/" + accountId,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            resourceType = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceType);
            resourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceId);
            accountId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(accountId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceMember",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/" + resourceType + "/" + resourceId + "/members/" + accountId,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVariableGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/variableGroups/" + id,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVariableGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/variableGroups/" + id,
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
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FrozenWorkspace",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/api/workspaces/" + workspaceId + "/frozen",
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
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FrozenWorkspace",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/api/workspaces/" + workspaceId + "/frozen",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FrozenWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHostGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/hostGroups/" + id,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHostGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/hostGroups/" + id,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            accountId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(accountId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrganizationMember",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/members/" + accountId,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            accountId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(accountId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrganizationMember",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/members/" + accountId,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipeline",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipeline",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineResponse>(await CallApiAsync(params_, req, runtime));
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            pipelineRunId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipelineRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            pipelineRunId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipelineRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineRunResponse>(await CallApiAsync(params_, req, runtime));
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            deployOrderId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVMDeployOrder",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/deploy/" + deployOrderId,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            deployOrderId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVMDeployOrder",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/deploy/" + deployOrderId,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVariableGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/variableGroups/" + id,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVariableGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/variableGroups/" + id,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVariableGroupResponse>(await CallApiAsync(params_, req, runtime));
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
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspace",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/api/workspaces/" + workspaceId,
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
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkspace",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/api/workspaces/" + workspaceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/hostGroups",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/hostGroups",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/members",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrganizationMembersResponse>(await CallApiAsync(params_, req, runtime));
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
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
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
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
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/pipelines",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/pipelines",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPipelinesResponse>(await CallApiAsync(params_, req, runtime));
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            resourceType = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceType);
            resourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceMembers",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/" + resourceType + "/" + resourceId + "/members",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            resourceType = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceType);
            resourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceMembers",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/" + resourceType + "/" + resourceId + "/members",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/serviceConnections",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/serviceConnections",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceConnectionsResponse>(await CallApiAsync(params_, req, runtime));
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/variableGroups",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/variableGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVariableGroupsResponse>(await CallApiAsync(params_, req, runtime));
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            jobId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId);
            pipelineRunId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LogPipelineJobRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipeline/" + pipelineId + "/pipelineRun/" + pipelineRunId + "/job/" + jobId + "/logs",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            jobId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId);
            pipelineRunId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LogPipelineJobRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipeline/" + pipelineId + "/pipelineRun/" + pipelineRunId + "/job/" + jobId + "/logs",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            deployOrderId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId);
            machineSn = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(machineSn);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LogVMDeployMachine",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/deploy/" + deployOrderId + "/machine/" + machineSn + "/log",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            deployOrderId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId);
            machineSn = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(machineSn);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LogVMDeployMachine",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/deploy/" + deployOrderId + "/machine/" + machineSn + "/log",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            pipelineRunId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId);
            jobId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PassPipelineValidate",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId + "/jobs/" + jobId + "/pass",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            pipelineRunId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId);
            jobId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PassPipelineValidate",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId + "/jobs/" + jobId + "/pass",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            pipelineRunId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId);
            jobId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefusePipelineValidate",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId + "/jobs/" + jobId + "/refuse",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            pipelineRunId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId);
            jobId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefusePipelineValidate",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId + "/jobs/" + jobId + "/refuse",
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
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseWorkspace",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/api/workspaces/" + workspaceId + "/release",
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
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseWorkspace",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/api/workspaces/" + workspaceId + "/release",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetSshKey",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/sshKey",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetSshKey",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/sshKey",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            deployOrderId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeVMDeployOrder",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/deploy/" + deployOrderId + "/resume",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            deployOrderId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeVMDeployOrder",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/deploy/" + deployOrderId + "/resume",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            pipelineRunId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId);
            jobId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryPipelineJobRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId + "/jobs/" + jobId,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            pipelineRunId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId);
            jobId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryPipelineJobRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId + "/jobs/" + jobId,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            deployOrderId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId);
            machineSn = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(machineSn);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryVMDeployMachine",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/deploy/" + deployOrderId + "/machine/" + machineSn + "/retry",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            deployOrderId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId);
            machineSn = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(machineSn);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryVMDeployMachine",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/deploy/" + deployOrderId + "/machine/" + machineSn + "/retry",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            pipelineRunId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId);
            jobId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SkipPipelineJobRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId + "/jobs/" + jobId + "/skip",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            pipelineRunId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId);
            jobId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SkipPipelineJobRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId + "/jobs/" + jobId + "/skip",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            deployOrderId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId);
            machineSn = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(machineSn);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SkipVMDeployMachine",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/deploy/" + deployOrderId + "/machine/" + machineSn + "/skip",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            deployOrderId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId);
            machineSn = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(machineSn);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SkipVMDeployMachine",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/deploy/" + deployOrderId + "/machine/" + machineSn + "/skip",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
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
                Pathname = "/organizations/" + organizationId + "/pipelines/" + pipelineId + "/run",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
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
                Pathname = "/organizations/" + organizationId + "/pipelines/" + pipelineId + "/run",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            pipelineRunId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId);
            jobId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopPipelineJobRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId + "/jobs/" + jobId + "/stop",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            pipelineRunId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId);
            jobId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopPipelineJobRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId + "/jobs/" + jobId + "/stop",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            pipelineRunId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopPipelineRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId + "/stop",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            pipelineRunId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopPipelineRun",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId + "/stop",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            deployOrderId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopVMDeployOrder",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/deploy/" + deployOrderId + "/stop",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            deployOrderId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deployOrderId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopVMDeployOrder",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/deploy/" + deployOrderId + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopVMDeployOrderResponse>(await CallApiAsync(params_, req, runtime));
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
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
                Pathname = "/organization/" + organizationId + "/hostGroups/" + id,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
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
                Pathname = "/organization/" + organizationId + "/hostGroups/" + id,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHostGroupResponse>(await CallApiAsync(params_, req, runtime));
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            resourceType = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceType);
            resourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceId);
            accountId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(accountId);
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
                Pathname = "/organization/" + organizationId + "/" + resourceType + "/" + resourceId + "/members/" + accountId,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            resourceType = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceType);
            resourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(resourceId);
            accountId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(accountId);
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
                Pathname = "/organization/" + organizationId + "/" + resourceType + "/" + resourceId + "/members/" + accountId,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
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
                Pathname = "/organization/" + organizationId + "/variableGroups/" + id,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
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
                Pathname = "/organization/" + organizationId + "/variableGroups/" + id,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVariableGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

    }
}
