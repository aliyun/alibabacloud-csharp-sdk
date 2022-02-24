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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/flow/tags",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/flow/tags",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/flow/tagGroups",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/flow/tagGroups",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/projects/createProject",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/projects/createProject",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(await CallApiAsync(params_, req, runtime));
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/sprints/create",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/sprints/create",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/workitems/create",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/workitems/create",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowTag",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/flow/tags/" + id,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowTag",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/flow/tags/" + id,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowTagGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/flow/tagGroups/" + id,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowTagGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/flow/tagGroups/" + id,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/projects/delete",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/projects/delete",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectResponse>(await CallApiAsync(params_, req, runtime));
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            fieldId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fieldId);
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
                Pathname = "/organization/" + organizationId + "/fields/" + fieldId + "/getCustomOption",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            fieldId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fieldId);
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
                Pathname = "/organization/" + organizationId + "/fields/" + fieldId + "/getCustomOption",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomFieldOptionResponse>(await CallApiAsync(params_, req, runtime));
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowTagGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/flow/tagGroups/" + id,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowTagGroup",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/flow/tagGroups/" + id,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/pipeline/getArtifactDownloadUrl",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/pipeline/getArtifactDownloadUrl",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            emasJobInstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(emasJobInstanceId);
            md5 = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(md5);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            pipelineRunId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId);
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
                Pathname = "/organization/" + organizationId + "/pipeline/" + pipelineId + "/pipelineRun/" + pipelineRunId + "/emas/artifact/" + emasJobInstanceId + "/" + md5,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            emasJobInstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(emasJobInstanceId);
            md5 = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(md5);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            pipelineRunId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineRunId);
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
                Pathname = "/organization/" + organizationId + "/pipeline/" + pipelineId + "/pipelineRun/" + pipelineRunId + "/emas/artifact/" + emasJobInstanceId + "/" + md5,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPipelineEmasArtifactUrlResponse>(await CallApiAsync(params_, req, runtime));
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/pipeline/getPipelineScanReportUrl",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/pipeline/getPipelineScanReportUrl",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            projectId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProjectInfo",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/project/" + projectId,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            projectId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProjectInfo",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/project/" + projectId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectInfoResponse>(await CallApiAsync(params_, req, runtime));
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            sprintId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sprintId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSprintInfo",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/sprints/" + sprintId + "/getSprintinfo",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            sprintId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sprintId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSprintInfo",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/sprints/" + sprintId + "/getSprintinfo",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            workitemId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workitemId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkItemActivity",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/workitems/" + workitemId + "/getActivity",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            workitemId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workitemId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkItemActivity",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/workitems/" + workitemId + "/getActivity",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            workitemId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workitemId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkItemInfo",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/workitems/" + workitemId,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            workitemId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workitemId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkItemInfo",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/workitems/" + workitemId,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            workitemId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workitemId);
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
                Pathname = "/organization/" + organizationId + "/workitems/" + workitemId + "/getWorkflowInfo",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            workitemId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workitemId);
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
                Pathname = "/organization/" + organizationId + "/workitems/" + workitemId + "/getWorkflowInfo",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowTagGroups",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/flow/tagGroups",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowTagGroups",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/flow/tagGroups",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
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
                Pathname = "/organization/" + organizationId + "/pipeline/" + pipelineId + "/job/historys",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
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
                Pathname = "/organization/" + organizationId + "/pipeline/" + pipelineId + "/job/historys",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
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
                Pathname = "/organization/" + organizationId + "/pipeline/" + pipelineId + "/jobs",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
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
                Pathname = "/organization/" + organizationId + "/pipeline/" + pipelineId + "/jobs",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            projectId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId);
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
                Pathname = "/organization/" + organizationId + "/projects/" + projectId + "/listMembers",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            projectId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId);
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
                Pathname = "/organization/" + organizationId + "/projects/" + projectId + "/listMembers",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/projects/listTemplates",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/projects/listTemplates",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            projectId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId);
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
                Pathname = "/organization/" + organizationId + "/projects/" + projectId + "/getWorkitemType",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            projectId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId);
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
                Pathname = "/organization/" + organizationId + "/projects/" + projectId + "/getWorkitemType",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/listProjects",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/listProjects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectsResponse>(await CallApiAsync(params_, req, runtime));
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
                Pathname = "/organization/" + organizationId + "/sprints/list",
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
                Pathname = "/organization/" + organizationId + "/sprints/list",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/workitems/fields/listAll",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/workitems/fields/listAll",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/workitems/workflow/listWorkflowStatus",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/workitems/workflow/listWorkflowStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkItemWorkFlowStatusResponse>(await CallApiAsync(params_, req, runtime));
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
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
                Action = "ListWorkitems",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/listWorkitems",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
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
                Action = "ListWorkitems",
                Version = "2021-06-25",
                Protocol = "HTTPS",
                Pathname = "/organization/" + organizationId + "/listWorkitems",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
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
                Pathname = "/organization/" + organizationId + "/flow/tags/" + id,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
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
                Pathname = "/organization/" + organizationId + "/flow/tags/" + id,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
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
                Pathname = "/organization/" + organizationId + "/flow/tagGroups/" + id,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
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
                Pathname = "/organization/" + organizationId + "/flow/tagGroups/" + id,
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
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
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/baseInfo",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
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
                Pathname = "/organization/" + organizationId + "/pipelines/" + pipelineId + "/baseInfo",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePipelineBaseInfoResponse>(await CallApiAsync(params_, req, runtime));
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            projectId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId);
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
                Pathname = "/organization/" + organizationId + "/projects/" + projectId + "/updateMember",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            projectId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId);
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
                Pathname = "/organization/" + organizationId + "/projects/" + projectId + "/updateMember",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectMemberResponse>(await CallApiAsync(params_, req, runtime));
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/workitems/update",
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
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
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
                Pathname = "/organization/" + organizationId + "/workitems/update",
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
