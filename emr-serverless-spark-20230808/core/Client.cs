// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Emr_serverless_spark20230808.Models;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("emr-serverless-spark", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 取消jobRun作业
         *
         * @param request CancelJobRunRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelJobRunResponse
         */
        public CancelJobRunResponse CancelJobRunWithOptions(string workspaceId, string jobRunId, CancelJobRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelJobRun",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/jobRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobRunId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelJobRunResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 取消jobRun作业
         *
         * @param request CancelJobRunRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelJobRunResponse
         */
        public async Task<CancelJobRunResponse> CancelJobRunWithOptionsAsync(string workspaceId, string jobRunId, CancelJobRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelJobRun",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/jobRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobRunId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelJobRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 取消jobRun作业
         *
         * @param request CancelJobRunRequest
         * @return CancelJobRunResponse
         */
        public CancelJobRunResponse CancelJobRun(string workspaceId, string jobRunId, CancelJobRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelJobRunWithOptions(workspaceId, jobRunId, request, headers, runtime);
        }

        /**
         * @summary 取消jobRun作业
         *
         * @param request CancelJobRunRequest
         * @return CancelJobRunResponse
         */
        public async Task<CancelJobRunResponse> CancelJobRunAsync(string workspaceId, string jobRunId, CancelJobRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelJobRunWithOptionsAsync(workspaceId, jobRunId, request, headers, runtime);
        }

        /**
         * @summary 获取任务
         *
         * @param request GetJobRunRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobRunResponse
         */
        public GetJobRunResponse GetJobRunWithOptions(string workspaceId, string jobRunId, GetJobRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobRun",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/jobRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobRunId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobRunResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取任务
         *
         * @param request GetJobRunRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetJobRunResponse
         */
        public async Task<GetJobRunResponse> GetJobRunWithOptionsAsync(string workspaceId, string jobRunId, GetJobRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobRun",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/jobRuns/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobRunId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取任务
         *
         * @param request GetJobRunRequest
         * @return GetJobRunResponse
         */
        public GetJobRunResponse GetJobRun(string workspaceId, string jobRunId, GetJobRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetJobRunWithOptions(workspaceId, jobRunId, request, headers, runtime);
        }

        /**
         * @summary 获取任务
         *
         * @param request GetJobRunRequest
         * @return GetJobRunResponse
         */
        public async Task<GetJobRunResponse> GetJobRunAsync(string workspaceId, string jobRunId, GetJobRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetJobRunWithOptionsAsync(workspaceId, jobRunId, request, headers, runtime);
        }

        /**
         * @summary 查询run列表
         *
         * @param tmpReq ListJobRunsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListJobRunsResponse
         */
        public ListJobRunsResponse ListJobRunsWithOptions(string workspaceId, ListJobRunsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListJobRunsShrinkRequest request = new ListJobRunsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EndTime))
            {
                request.EndTimeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EndTime, "endTime", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StartTime))
            {
                request.StartTimeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StartTime, "startTime", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.States))
            {
                request.StatesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.States, "states", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeShrink))
            {
                query["endTime"] = request.EndTimeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobRunId))
            {
                query["jobRunId"] = request.JobRunId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceQueueId))
            {
                query["resourceQueueId"] = request.ResourceQueueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeShrink))
            {
                query["startTime"] = request.StartTimeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatesShrink))
            {
                query["states"] = request.StatesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobRuns",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/jobRuns",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobRunsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询run列表
         *
         * @param tmpReq ListJobRunsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListJobRunsResponse
         */
        public async Task<ListJobRunsResponse> ListJobRunsWithOptionsAsync(string workspaceId, ListJobRunsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListJobRunsShrinkRequest request = new ListJobRunsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EndTime))
            {
                request.EndTimeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EndTime, "endTime", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StartTime))
            {
                request.StartTimeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StartTime, "startTime", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.States))
            {
                request.StatesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.States, "states", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeShrink))
            {
                query["endTime"] = request.EndTimeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobRunId))
            {
                query["jobRunId"] = request.JobRunId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceQueueId))
            {
                query["resourceQueueId"] = request.ResourceQueueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeShrink))
            {
                query["startTime"] = request.StartTimeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatesShrink))
            {
                query["states"] = request.StatesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobRuns",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/jobRuns",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobRunsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询run列表
         *
         * @param request ListJobRunsRequest
         * @return ListJobRunsResponse
         */
        public ListJobRunsResponse ListJobRuns(string workspaceId, ListJobRunsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListJobRunsWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 查询run列表
         *
         * @param request ListJobRunsRequest
         * @return ListJobRunsResponse
         */
        public async Task<ListJobRunsResponse> ListJobRunsAsync(string workspaceId, ListJobRunsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListJobRunsWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 启动作业
         *
         * @param request StartJobRunRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartJobRunResponse
         */
        public StartJobRunResponse StartJobRunWithOptions(string workspaceId, StartJobRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeType))
            {
                body["codeType"] = request.CodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationOverrides))
            {
                body["configurationOverrides"] = request.ConfigurationOverrides;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionTimeoutSeconds))
            {
                body["executionTimeoutSeconds"] = request.ExecutionTimeoutSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobDriver))
            {
                body["jobDriver"] = request.JobDriver;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["jobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersion))
            {
                body["releaseVersion"] = request.ReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceQueueId))
            {
                body["resourceQueueId"] = request.ResourceQueueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartJobRun",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/jobRuns",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartJobRunResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 启动作业
         *
         * @param request StartJobRunRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartJobRunResponse
         */
        public async Task<StartJobRunResponse> StartJobRunWithOptionsAsync(string workspaceId, StartJobRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeType))
            {
                body["codeType"] = request.CodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigurationOverrides))
            {
                body["configurationOverrides"] = request.ConfigurationOverrides;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionTimeoutSeconds))
            {
                body["executionTimeoutSeconds"] = request.ExecutionTimeoutSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobDriver))
            {
                body["jobDriver"] = request.JobDriver;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["jobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersion))
            {
                body["releaseVersion"] = request.ReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceQueueId))
            {
                body["resourceQueueId"] = request.ResourceQueueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartJobRun",
                Version = "2023-08-08",
                Protocol = "HTTPS",
                Pathname = "/api/v1/workspaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/jobRuns",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartJobRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 启动作业
         *
         * @param request StartJobRunRequest
         * @return StartJobRunResponse
         */
        public StartJobRunResponse StartJobRun(string workspaceId, StartJobRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartJobRunWithOptions(workspaceId, request, headers, runtime);
        }

        /**
         * @summary 启动作业
         *
         * @param request StartJobRunRequest
         * @return StartJobRunResponse
         */
        public async Task<StartJobRunResponse> StartJobRunAsync(string workspaceId, StartJobRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartJobRunWithOptionsAsync(workspaceId, request, headers, runtime);
        }

    }
}
