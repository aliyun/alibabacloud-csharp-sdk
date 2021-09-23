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
            return TeaModel.ToObject<RetryPipelineJobRunResponse>(DoROARequest("RetryPipelineJobRun", "2021-06-25", "HTTPS", "PUT", "AK", "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId + "/jobs/" + jobId, "json", req, runtime));
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
            return TeaModel.ToObject<RetryPipelineJobRunResponse>(await DoROARequestAsync("RetryPipelineJobRun", "2021-06-25", "HTTPS", "PUT", "AK", "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId + "/jobs/" + jobId, "json", req, runtime));
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
            return TeaModel.ToObject<ListResourceMembersResponse>(DoROARequest("ListResourceMembers", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/" + resourceType + "/" + resourceId + "/members", "json", req, runtime));
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
            return TeaModel.ToObject<ListResourceMembersResponse>(await DoROARequestAsync("ListResourceMembers", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/" + resourceType + "/" + resourceId + "/members", "json", req, runtime));
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
            return TeaModel.ToObject<GetHostGroupResponse>(DoROARequest("GetHostGroup", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/hostGroups/" + id, "json", req, runtime));
        }

        public async Task<GetHostGroupResponse> GetHostGroupWithOptionsAsync(string organizationId, string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetHostGroupResponse>(await DoROARequestAsync("GetHostGroup", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/hostGroups/" + id, "json", req, runtime));
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
            return TeaModel.ToObject<GetVariableGroupResponse>(DoROARequest("GetVariableGroup", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/variableGroups/" + id, "json", req, runtime));
        }

        public async Task<GetVariableGroupResponse> GetVariableGroupWithOptionsAsync(string organizationId, string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetVariableGroupResponse>(await DoROARequestAsync("GetVariableGroup", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/variableGroups/" + id, "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineName))
            {
                query["pipelineName"] = request.PipelineName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorAccountIds))
            {
                query["creatorAccountIds"] = request.CreatorAccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteAccountIds))
            {
                query["executeAccountIds"] = request.ExecuteAccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                query["statusList"] = request.StatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartTime))
            {
                query["createStartTime"] = request.CreateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndTime))
            {
                query["createEndTime"] = request.CreateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteStartTime))
            {
                query["executeStartTime"] = request.ExecuteStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteEndTime))
            {
                query["executeEndTime"] = request.ExecuteEndTime;
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
            return TeaModel.ToObject<ListPipelinesResponse>(DoROARequest("ListPipelines", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/pipelines", "json", req, runtime));
        }

        public async Task<ListPipelinesResponse> ListPipelinesWithOptionsAsync(string organizationId, ListPipelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineName))
            {
                query["pipelineName"] = request.PipelineName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorAccountIds))
            {
                query["creatorAccountIds"] = request.CreatorAccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteAccountIds))
            {
                query["executeAccountIds"] = request.ExecuteAccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                query["statusList"] = request.StatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartTime))
            {
                query["createStartTime"] = request.CreateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndTime))
            {
                query["createEndTime"] = request.CreateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteStartTime))
            {
                query["executeStartTime"] = request.ExecuteStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteEndTime))
            {
                query["executeEndTime"] = request.ExecuteEndTime;
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
            return TeaModel.ToObject<ListPipelinesResponse>(await DoROARequestAsync("ListPipelines", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/pipelines", "json", req, runtime));
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
            return TeaModel.ToObject<UpdateResourceMemberResponse>(DoROARequestWithForm("UpdateResourceMember", "2021-06-25", "HTTPS", "PUT", "AK", "/organization/" + organizationId + "/" + resourceType + "/" + resourceId + "/members/" + accountId, "json", req, runtime));
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
            return TeaModel.ToObject<UpdateResourceMemberResponse>(await DoROARequestWithFormAsync("UpdateResourceMember", "2021-06-25", "HTTPS", "PUT", "AK", "/organization/" + organizationId + "/" + resourceType + "/" + resourceId + "/members/" + accountId, "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
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
            return TeaModel.ToObject<UpdateVariableGroupResponse>(DoROARequestWithForm("UpdateVariableGroup", "2021-06-25", "HTTPS", "PUT", "AK", "/organization/" + organizationId + "/variableGroups/" + id, "json", req, runtime));
        }

        public async Task<UpdateVariableGroupResponse> UpdateVariableGroupWithOptionsAsync(string organizationId, string id, UpdateVariableGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
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
            return TeaModel.ToObject<UpdateVariableGroupResponse>(await DoROARequestWithFormAsync("UpdateVariableGroup", "2021-06-25", "HTTPS", "PUT", "AK", "/organization/" + organizationId + "/variableGroups/" + id, "json", req, runtime));
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
            return TeaModel.ToObject<DeleteResourceMemberResponse>(DoROARequest("DeleteResourceMember", "2021-06-25", "HTTPS", "DELETE", "AK", "/organization/" + organizationId + "/" + resourceType + "/" + resourceId + "/members/" + accountId, "json", req, runtime));
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
            return TeaModel.ToObject<DeleteResourceMemberResponse>(await DoROARequestAsync("DeleteResourceMember", "2021-06-25", "HTTPS", "DELETE", "AK", "/organization/" + organizationId + "/" + resourceType + "/" + resourceId + "/members/" + accountId, "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartTime))
            {
                query["createStartTime"] = request.CreateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndTime))
            {
                query["createEndTime"] = request.CreateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorAccountIds))
            {
                query["creatorAccountIds"] = request.CreatorAccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSort))
            {
                query["pageSort"] = request.PageSort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageOrder))
            {
                query["pageOrder"] = request.PageOrder;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListHostGroupsResponse>(DoROARequest("ListHostGroups", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/hostGroups", "json", req, runtime));
        }

        public async Task<ListHostGroupsResponse> ListHostGroupsWithOptionsAsync(string organizationId, ListHostGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartTime))
            {
                query["createStartTime"] = request.CreateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndTime))
            {
                query["createEndTime"] = request.CreateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorAccountIds))
            {
                query["creatorAccountIds"] = request.CreatorAccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSort))
            {
                query["pageSort"] = request.PageSort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageOrder))
            {
                query["pageOrder"] = request.PageOrder;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListHostGroupsResponse>(await DoROARequestAsync("ListHostGroups", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/hostGroups", "json", req, runtime));
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
            return TeaModel.ToObject<ResetSshKeyResponse>(DoROARequest("ResetSshKey", "2021-06-25", "HTTPS", "PUT", "AK", "/organization/" + organizationId + "/sshKey", "json", req, runtime));
        }

        public async Task<ResetSshKeyResponse> ResetSshKeyWithOptionsAsync(string organizationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ResetSshKeyResponse>(await DoROARequestAsync("ResetSshKey", "2021-06-25", "HTTPS", "PUT", "AK", "/organization/" + organizationId + "/sshKey", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceTemplate))
            {
                body["workspaceTemplate"] = request.WorkspaceTemplate;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reuse))
            {
                body["reuse"] = request.Reuse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdentifier))
            {
                body["resourceIdentifier"] = request.ResourceIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestFrom))
            {
                body["requestFrom"] = request.RequestFrom;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(DoROARequestWithForm("CreateWorkspace", "2021-06-25", "HTTPS", "POST", "AK", "/api/workspaces", "json", req, runtime));
        }

        public async Task<CreateWorkspaceResponse> CreateWorkspaceWithOptionsAsync(CreateWorkspaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceTemplate))
            {
                body["workspaceTemplate"] = request.WorkspaceTemplate;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reuse))
            {
                body["reuse"] = request.Reuse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdentifier))
            {
                body["resourceIdentifier"] = request.ResourceIdentifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestFrom))
            {
                body["requestFrom"] = request.RequestFrom;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateWorkspaceResponse>(await DoROARequestWithFormAsync("CreateWorkspace", "2021-06-25", "HTTPS", "POST", "AK", "/api/workspaces", "json", req, runtime));
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
            return TeaModel.ToObject<ListServiceConnectionsResponse>(DoROARequest("ListServiceConnections", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/serviceConnections", "json", req, runtime));
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
            return TeaModel.ToObject<ListServiceConnectionsResponse>(await DoROARequestAsync("ListServiceConnections", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/serviceConnections", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["envId"] = request.EnvId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsType))
            {
                body["ecsType"] = request.EcsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsLabelKey))
            {
                body["ecsLabelKey"] = request.EcsLabelKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsLabelValue))
            {
                body["ecsLabelValue"] = request.EcsLabelValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunRegion))
            {
                body["aliyunRegion"] = request.AliyunRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MachineInfos))
            {
                body["machineInfos"] = request.MachineInfos;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateHostGroupResponse>(DoROARequestWithForm("CreateHostGroup", "2021-06-25", "HTTPS", "POST", "AK", "/organization/" + organizationId + "/hostGroups", "json", req, runtime));
        }

        public async Task<CreateHostGroupResponse> CreateHostGroupWithOptionsAsync(string organizationId, CreateHostGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["envId"] = request.EnvId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsType))
            {
                body["ecsType"] = request.EcsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsLabelKey))
            {
                body["ecsLabelKey"] = request.EcsLabelKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsLabelValue))
            {
                body["ecsLabelValue"] = request.EcsLabelValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunRegion))
            {
                body["aliyunRegion"] = request.AliyunRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MachineInfos))
            {
                body["machineInfos"] = request.MachineInfos;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateHostGroupResponse>(await DoROARequestWithFormAsync("CreateHostGroup", "2021-06-25", "HTTPS", "POST", "AK", "/organization/" + organizationId + "/hostGroups", "json", req, runtime));
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
            return TeaModel.ToObject<StopPipelineRunResponse>(DoROARequest("StopPipelineRun", "2021-06-25", "HTTPS", "PUT", "AK", "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId + "/stop", "json", req, runtime));
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
            return TeaModel.ToObject<StopPipelineRunResponse>(await DoROARequestAsync("StopPipelineRun", "2021-06-25", "HTTPS", "PUT", "AK", "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId + "/stop", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["envId"] = request.EnvId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsType))
            {
                body["ecsType"] = request.EcsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsLabelKey))
            {
                body["ecsLabelKey"] = request.EcsLabelKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsLabelValue))
            {
                body["ecsLabelValue"] = request.EcsLabelValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunRegion))
            {
                body["aliyunRegion"] = request.AliyunRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MachineInfos))
            {
                body["machineInfos"] = request.MachineInfos;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateHostGroupResponse>(DoROARequestWithForm("UpdateHostGroup", "2021-06-25", "HTTPS", "PUT", "AK", "/organization/" + organizationId + "/hostGroups/" + id, "json", req, runtime));
        }

        public async Task<UpdateHostGroupResponse> UpdateHostGroupWithOptionsAsync(string organizationId, string id, UpdateHostGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvId))
            {
                body["envId"] = request.EnvId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsType))
            {
                body["ecsType"] = request.EcsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsLabelKey))
            {
                body["ecsLabelKey"] = request.EcsLabelKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsLabelValue))
            {
                body["ecsLabelValue"] = request.EcsLabelValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunRegion))
            {
                body["aliyunRegion"] = request.AliyunRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MachineInfos))
            {
                body["machineInfos"] = request.MachineInfos;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateHostGroupResponse>(await DoROARequestWithFormAsync("UpdateHostGroup", "2021-06-25", "HTTPS", "PUT", "AK", "/organization/" + organizationId + "/hostGroups/" + id, "json", req, runtime));
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
            return TeaModel.ToObject<CreateResourceMemberResponse>(DoROARequestWithForm("CreateResourceMember", "2021-06-25", "HTTPS", "POST", "AK", "/organization/" + organizationId + "/" + resourceType + "/" + resourceId + "/members", "json", req, runtime));
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
            return TeaModel.ToObject<CreateResourceMemberResponse>(await DoROARequestWithFormAsync("CreateResourceMember", "2021-06-25", "HTTPS", "POST", "AK", "/organization/" + organizationId + "/" + resourceType + "/" + resourceId + "/members", "json", req, runtime));
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
            return TeaModel.ToObject<SkipPipelineJobRunResponse>(DoROARequest("SkipPipelineJobRun", "2021-06-25", "HTTPS", "PUT", "AK", "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId + "/jobs/" + jobId + "/skip", "json", req, runtime));
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
            return TeaModel.ToObject<SkipPipelineJobRunResponse>(await DoROARequestAsync("SkipPipelineJobRun", "2021-06-25", "HTTPS", "PUT", "AK", "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId + "/jobs/" + jobId + "/skip", "json", req, runtime));
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
            return TeaModel.ToObject<GetOrganizationMemberResponse>(DoROARequest("GetOrganizationMember", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/members/" + accountId, "json", req, runtime));
        }

        public async Task<GetOrganizationMemberResponse> GetOrganizationMemberWithOptionsAsync(string organizationId, string accountId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            accountId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(accountId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetOrganizationMemberResponse>(await DoROARequestAsync("GetOrganizationMember", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/members/" + accountId, "json", req, runtime));
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
            return TeaModel.ToObject<StopPipelineJobRunResponse>(DoROARequest("StopPipelineJobRun", "2021-06-25", "HTTPS", "PUT", "AK", "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId + "/jobs/" + jobId + "/stop", "json", req, runtime));
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
            return TeaModel.ToObject<StopPipelineJobRunResponse>(await DoROARequestAsync("StopPipelineJobRun", "2021-06-25", "HTTPS", "PUT", "AK", "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId + "/jobs/" + jobId + "/stop", "json", req, runtime));
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
            return TeaModel.ToObject<StartPipelineRunResponse>(DoROARequestWithForm("StartPipelineRun", "2021-06-25", "HTTPS", "POST", "AK", "/organizations/" + organizationId + "/pipelines/" + pipelineId + "/run", "json", req, runtime));
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
            return TeaModel.ToObject<StartPipelineRunResponse>(await DoROARequestWithFormAsync("StartPipelineRun", "2021-06-25", "HTTPS", "POST", "AK", "/organizations/" + organizationId + "/pipelines/" + pipelineId + "/run", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
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
            return TeaModel.ToObject<ListWorkspacesResponse>(DoROARequest("ListWorkspaces", "2021-06-25", "HTTPS", "GET", "AK", "/api/workspaces", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
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
            return TeaModel.ToObject<ListWorkspacesResponse>(await DoROARequestAsync("ListWorkspaces", "2021-06-25", "HTTPS", "GET", "AK", "/api/workspaces", "json", req, runtime));
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
            return TeaModel.ToObject<GetPipelineRunResponse>(DoROARequest("GetPipelineRun", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId, "json", req, runtime));
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
            return TeaModel.ToObject<GetPipelineRunResponse>(await DoROARequestAsync("GetPipelineRun", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns/" + pipelineRunId, "json", req, runtime));
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
            return TeaModel.ToObject<GetPipelineResponse>(DoROARequest("GetPipeline", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/pipelines/" + pipelineId, "json", req, runtime));
        }

        public async Task<GetPipelineResponse> GetPipelineWithOptionsAsync(string organizationId, string pipelineId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetPipelineResponse>(await DoROARequestAsync("GetPipeline", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/pipelines/" + pipelineId, "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
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
            return TeaModel.ToObject<CreateVariableGroupResponse>(DoROARequestWithForm("CreateVariableGroup", "2021-06-25", "HTTPS", "POST", "AK", "/organization/" + organizationId + "/variableGroups", "json", req, runtime));
        }

        public async Task<CreateVariableGroupResponse> CreateVariableGroupWithOptionsAsync(string organizationId, CreateVariableGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
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
            return TeaModel.ToObject<CreateVariableGroupResponse>(await DoROARequestWithFormAsync("CreateVariableGroup", "2021-06-25", "HTTPS", "POST", "AK", "/organization/" + organizationId + "/variableGroups", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteVariableGroupResponse>(DoROARequest("DeleteVariableGroup", "2021-06-25", "HTTPS", "DELETE", "AK", "/organization/" + organizationId + "/variableGroups/" + id, "json", req, runtime));
        }

        public async Task<DeleteVariableGroupResponse> DeleteVariableGroupWithOptionsAsync(string organizationId, string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteVariableGroupResponse>(await DoROARequestAsync("DeleteVariableGroup", "2021-06-25", "HTTPS", "DELETE", "AK", "/organization/" + organizationId + "/variableGroups/" + id, "json", req, runtime));
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
            return TeaModel.ToObject<GetWorkspaceResponse>(DoROARequest("GetWorkspace", "2021-06-25", "HTTPS", "GET", "AK", "/api/workspaces/" + workspaceId, "json", req, runtime));
        }

        public async Task<GetWorkspaceResponse> GetWorkspaceWithOptionsAsync(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetWorkspaceResponse>(await DoROARequestAsync("GetWorkspace", "2021-06-25", "HTTPS", "GET", "AK", "/api/workspaces/" + workspaceId, "json", req, runtime));
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
            return TeaModel.ToObject<CreateSshKeyResponse>(DoROARequest("CreateSshKey", "2021-06-25", "HTTPS", "POST", "AK", "/organization/" + organizationId + "/sshKey", "json", req, runtime));
        }

        public async Task<CreateSshKeyResponse> CreateSshKeyWithOptionsAsync(string organizationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CreateSshKeyResponse>(await DoROARequestAsync("CreateSshKey", "2021-06-25", "HTTPS", "POST", "AK", "/organization/" + organizationId + "/sshKey", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteHostGroupResponse>(DoROARequest("DeleteHostGroup", "2021-06-25", "HTTPS", "DELETE", "AK", "/organization/" + organizationId + "/hostGroups/" + id, "json", req, runtime));
        }

        public async Task<DeleteHostGroupResponse> DeleteHostGroupWithOptionsAsync(string organizationId, string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteHostGroupResponse>(await DoROARequestAsync("DeleteHostGroup", "2021-06-25", "HTTPS", "DELETE", "AK", "/organization/" + organizationId + "/hostGroups/" + id, "json", req, runtime));
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
            return TeaModel.ToObject<ReleaseWorkspaceResponse>(DoROARequest("ReleaseWorkspace", "2021-06-25", "HTTPS", "DELETE", "AK", "/api/workspaces/" + workspaceId + "/release", "json", req, runtime));
        }

        public async Task<ReleaseWorkspaceResponse> ReleaseWorkspaceWithOptionsAsync(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ReleaseWorkspaceResponse>(await DoROARequestAsync("ReleaseWorkspace", "2021-06-25", "HTTPS", "DELETE", "AK", "/api/workspaces/" + workspaceId + "/release", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationMemberName))
            {
                query["organizationMemberName"] = request.OrganizationMemberName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternUid))
            {
                query["externUid"] = request.ExternUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["state"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JoinTimeFrom))
            {
                query["joinTimeFrom"] = request.JoinTimeFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JoinTimeTo))
            {
                query["joinTimeTo"] = request.JoinTimeTo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListOrganizationMembersResponse>(DoROARequest("ListOrganizationMembers", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/members", "json", req, runtime));
        }

        public async Task<ListOrganizationMembersResponse> ListOrganizationMembersWithOptionsAsync(string organizationId, ListOrganizationMembersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationMemberName))
            {
                query["organizationMemberName"] = request.OrganizationMemberName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternUid))
            {
                query["externUid"] = request.ExternUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["state"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JoinTimeFrom))
            {
                query["joinTimeFrom"] = request.JoinTimeFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JoinTimeTo))
            {
                query["joinTimeTo"] = request.JoinTimeTo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListOrganizationMembersResponse>(await DoROARequestAsync("ListOrganizationMembers", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/members", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSort))
            {
                query["pageSort"] = request.PageSort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageOrder))
            {
                query["pageOrder"] = request.PageOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListVariableGroupsResponse>(DoROARequest("ListVariableGroups", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/variableGroups", "json", req, runtime));
        }

        public async Task<ListVariableGroupsResponse> ListVariableGroupsWithOptionsAsync(string organizationId, ListVariableGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSort))
            {
                query["pageSort"] = request.PageSort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageOrder))
            {
                query["pageOrder"] = request.PageOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListVariableGroupsResponse>(await DoROARequestAsync("ListVariableGroups", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/variableGroups", "json", req, runtime));
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
            return TeaModel.ToObject<DeletePipelineResponse>(DoROARequest("DeletePipeline", "2021-06-25", "HTTPS", "DELETE", "AK", "/organization/" + organizationId + "/pipelines/" + pipelineId, "json", req, runtime));
        }

        public async Task<DeletePipelineResponse> DeletePipelineWithOptionsAsync(string organizationId, string pipelineId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeletePipelineResponse>(await DoROARequestAsync("DeletePipeline", "2021-06-25", "HTTPS", "DELETE", "AK", "/organization/" + organizationId + "/pipelines/" + pipelineId, "json", req, runtime));
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
            return TeaModel.ToObject<FrozenWorkspaceResponse>(DoROARequest("FrozenWorkspace", "2021-06-25", "HTTPS", "PUT", "AK", "/api/workspaces/" + workspaceId + "/frozen", "json", req, runtime));
        }

        public async Task<FrozenWorkspaceResponse> FrozenWorkspaceWithOptionsAsync(string workspaceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            workspaceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<FrozenWorkspaceResponse>(await DoROARequestAsync("FrozenWorkspace", "2021-06-25", "HTTPS", "PUT", "AK", "/api/workspaces/" + workspaceId + "/frozen", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
            return TeaModel.ToObject<ListPipelineRunsResponse>(DoROARequest("ListPipelineRuns", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns", "json", req, runtime));
        }

        public async Task<ListPipelineRunsResponse> ListPipelineRunsWithOptionsAsync(string organizationId, string pipelineId, ListPipelineRunsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            organizationId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(organizationId);
            pipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(pipelineId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
            return TeaModel.ToObject<ListPipelineRunsResponse>(await DoROARequestAsync("ListPipelineRuns", "2021-06-25", "HTTPS", "GET", "AK", "/organization/" + organizationId + "/pipelines/" + pipelineId + "/pipelineRuns", "json", req, runtime));
        }

    }
}
