// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.SchedulerX320240624.Models;

namespace AlibabaCloud.SDK.SchedulerX320240624
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("schedulerx3", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppResponse
        /// </returns>
        public CreateAppResponse CreateAppWithOptions(CreateAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                body["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableLog))
            {
                body["EnableLog"] = request.EnableLog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                body["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApp",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppResponse
        /// </returns>
        public async Task<CreateAppResponse> CreateAppWithOptionsAsync(CreateAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                body["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableLog))
            {
                body["EnableLog"] = request.EnableLog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                body["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApp",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppResponse
        /// </returns>
        public CreateAppResponse CreateApp(CreateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppResponse
        /// </returns>
        public async Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建集群</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateClusterResponse
        /// </returns>
        public CreateClusterResponse CreateClusterWithOptions(CreateClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateClusterShrinkRequest request = new CreateClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VSwitches))
            {
                request.VSwitchesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VSwitches, "VSwitches", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                body["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterSpec))
            {
                body["ClusterSpec"] = request.ClusterSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                body["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchesShrink))
            {
                body["VSwitches"] = request.VSwitchesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCluster",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建集群</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateClusterResponse
        /// </returns>
        public async Task<CreateClusterResponse> CreateClusterWithOptionsAsync(CreateClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateClusterShrinkRequest request = new CreateClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VSwitches))
            {
                request.VSwitchesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VSwitches, "VSwitches", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                body["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterSpec))
            {
                body["ClusterSpec"] = request.ClusterSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                body["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchesShrink))
            {
                body["VSwitches"] = request.VSwitchesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCluster",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateClusterResponse
        /// </returns>
        public CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClusterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateClusterResponse
        /// </returns>
        public async Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClusterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateJobResponse
        /// </returns>
        public CreateJobResponse CreateJobWithOptions(CreateJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateJobShrinkRequest request = new CreateJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NoticeConfig))
            {
                request.NoticeConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NoticeConfig, "NoticeConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NoticeContacts))
            {
                request.NoticeContactsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NoticeContacts, "NoticeContacts", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttemptInterval))
            {
                body["AttemptInterval"] = request.AttemptInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Calendar))
            {
                body["Calendar"] = request.Calendar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildJobId))
            {
                body["ChildJobId"] = request.ChildJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorBlockStrategy))
            {
                body["ExecutorBlockStrategy"] = request.ExecutorBlockStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobHandler))
            {
                body["JobHandler"] = request.JobHandler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                body["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttempt))
            {
                body["MaxAttempt"] = request.MaxAttempt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                body["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeConfigShrink))
            {
                body["NoticeConfig"] = request.NoticeConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeContactsShrink))
            {
                body["NoticeContacts"] = request.NoticeContactsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteStrategy))
            {
                body["RouteStrategy"] = request.RouteStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Script))
            {
                body["Script"] = request.Script;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeExpression))
            {
                body["TimeExpression"] = request.TimeExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeType))
            {
                body["TimeType"] = request.TimeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                body["Timezone"] = request.Timezone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJob",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateJobResponse
        /// </returns>
        public async Task<CreateJobResponse> CreateJobWithOptionsAsync(CreateJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateJobShrinkRequest request = new CreateJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NoticeConfig))
            {
                request.NoticeConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NoticeConfig, "NoticeConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NoticeContacts))
            {
                request.NoticeContactsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NoticeContacts, "NoticeContacts", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttemptInterval))
            {
                body["AttemptInterval"] = request.AttemptInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Calendar))
            {
                body["Calendar"] = request.Calendar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildJobId))
            {
                body["ChildJobId"] = request.ChildJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorBlockStrategy))
            {
                body["ExecutorBlockStrategy"] = request.ExecutorBlockStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobHandler))
            {
                body["JobHandler"] = request.JobHandler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                body["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttempt))
            {
                body["MaxAttempt"] = request.MaxAttempt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                body["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeConfigShrink))
            {
                body["NoticeConfig"] = request.NoticeConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeContactsShrink))
            {
                body["NoticeContacts"] = request.NoticeContactsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteStrategy))
            {
                body["RouteStrategy"] = request.RouteStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Script))
            {
                body["Script"] = request.Script;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeExpression))
            {
                body["TimeExpression"] = request.TimeExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeType))
            {
                body["TimeType"] = request.TimeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                body["Timezone"] = request.Timezone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJob",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateJobResponse
        /// </returns>
        public CreateJobResponse CreateJob(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateJobResponse
        /// </returns>
        public async Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除应用分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppResponse
        /// </returns>
        public DeleteAppResponse DeleteAppWithOptions(DeleteAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApp",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除应用分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppResponse
        /// </returns>
        public async Task<DeleteAppResponse> DeleteAppWithOptionsAsync(DeleteAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApp",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除应用分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppResponse
        /// </returns>
        public DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除应用分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppResponse
        /// </returns>
        public async Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>释放删除集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteClusterResponse
        /// </returns>
        public DeleteClusterResponse DeleteClusterWithOptions(DeleteClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCluster",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClusterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>释放删除集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteClusterResponse
        /// </returns>
        public async Task<DeleteClusterResponse> DeleteClusterWithOptionsAsync(DeleteClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCluster",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>释放删除集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteClusterResponse
        /// </returns>
        public DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClusterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>释放删除集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteClusterResponse
        /// </returns>
        public async Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClusterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteJobsResponse
        /// </returns>
        public DeleteJobsResponse DeleteJobsWithOptions(DeleteJobsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteJobsShrinkRequest request = new DeleteJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobIds))
            {
                request.JobIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobIds, "JobIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIdsShrink))
            {
                body["JobIds"] = request.JobIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJobs",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteJobsResponse
        /// </returns>
        public async Task<DeleteJobsResponse> DeleteJobsWithOptionsAsync(DeleteJobsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteJobsShrinkRequest request = new DeleteJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobIds))
            {
                request.JobIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobIds, "JobIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIdsShrink))
            {
                body["JobIds"] = request.JobIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJobs",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteJobsResponse
        /// </returns>
        public DeleteJobsResponse DeleteJobs(DeleteJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteJobsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteJobsResponse
        /// </returns>
        public async Task<DeleteJobsResponse> DeleteJobsAsync(DeleteJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteJobsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量导出任务信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ExportJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportJobsResponse
        /// </returns>
        public ExportJobsResponse ExportJobsWithOptions(ExportJobsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExportJobsShrinkRequest request = new ExportJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobIds))
            {
                request.JobIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobIds, "JobIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportJobType))
            {
                body["ExportJobType"] = request.ExportJobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIdsShrink))
            {
                body["JobIds"] = request.JobIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportJobs",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "byte",
            };
            return TeaModel.ToObject<ExportJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量导出任务信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ExportJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportJobsResponse
        /// </returns>
        public async Task<ExportJobsResponse> ExportJobsWithOptionsAsync(ExportJobsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExportJobsShrinkRequest request = new ExportJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobIds))
            {
                request.JobIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobIds, "JobIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportJobType))
            {
                body["ExportJobType"] = request.ExportJobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIdsShrink))
            {
                body["JobIds"] = request.JobIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportJobs",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "byte",
            };
            return TeaModel.ToObject<ExportJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量导出任务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportJobsResponse
        /// </returns>
        public ExportJobsResponse ExportJobs(ExportJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportJobsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量导出任务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportJobsResponse
        /// </returns>
        public async Task<ExportJobsResponse> ExportJobsAsync(ExportJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportJobsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取集群详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetClusterResponse
        /// </returns>
        public GetClusterResponse GetClusterWithOptions(GetClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCluster",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClusterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取集群详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetClusterResponse
        /// </returns>
        public async Task<GetClusterResponse> GetClusterWithOptionsAsync(GetClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCluster",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取集群详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// GetClusterResponse
        /// </returns>
        public GetClusterResponse GetCluster(GetClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetClusterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取集群详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// GetClusterResponse
        /// </returns>
        public async Task<GetClusterResponse> GetClusterAsync(GetClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetClusterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定机器信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDesigateInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDesigateInfoResponse
        /// </returns>
        public GetDesigateInfoResponse GetDesigateInfoWithOptions(GetDesigateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDesigateInfo",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDesigateInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定机器信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDesigateInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDesigateInfoResponse
        /// </returns>
        public async Task<GetDesigateInfoResponse> GetDesigateInfoWithOptionsAsync(GetDesigateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDesigateInfo",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDesigateInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定机器信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDesigateInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDesigateInfoResponse
        /// </returns>
        public GetDesigateInfoResponse GetDesigateInfo(GetDesigateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDesigateInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定机器信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDesigateInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDesigateInfoResponse
        /// </returns>
        public async Task<GetDesigateInfoResponse> GetDesigateInfoAsync(GetDesigateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDesigateInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务执行的详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobExecutionResponse
        /// </returns>
        public GetJobExecutionResponse GetJobExecutionWithOptions(GetJobExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobExecutionId))
            {
                query["JobExecutionId"] = request.JobExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MseSessionId))
            {
                query["MseSessionId"] = request.MseSessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobExecution",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobExecutionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务执行的详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobExecutionResponse
        /// </returns>
        public async Task<GetJobExecutionResponse> GetJobExecutionWithOptionsAsync(GetJobExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobExecutionId))
            {
                query["JobExecutionId"] = request.JobExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MseSessionId))
            {
                query["MseSessionId"] = request.MseSessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobExecution",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobExecutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务执行的详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobExecutionResponse
        /// </returns>
        public GetJobExecutionResponse GetJobExecution(GetJobExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobExecutionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务执行的详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobExecutionResponse
        /// </returns>
        public async Task<GetJobExecutionResponse> GetJobExecutionAsync(GetJobExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobExecutionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务执行的详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobExecutionProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobExecutionProgressResponse
        /// </returns>
        public GetJobExecutionProgressResponse GetJobExecutionProgressWithOptions(GetJobExecutionProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobExecutionProgress",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobExecutionProgressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务执行的详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobExecutionProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobExecutionProgressResponse
        /// </returns>
        public async Task<GetJobExecutionProgressResponse> GetJobExecutionProgressWithOptionsAsync(GetJobExecutionProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobExecutionProgress",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobExecutionProgressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务执行的详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobExecutionProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobExecutionProgressResponse
        /// </returns>
        public GetJobExecutionProgressResponse GetJobExecutionProgress(GetJobExecutionProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobExecutionProgressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务执行的详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobExecutionProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobExecutionProgressResponse
        /// </returns>
        public async Task<GetJobExecutionProgressResponse> GetJobExecutionProgressAsync(GetJobExecutionProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobExecutionProgressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLogResponse
        /// </returns>
        public GetLogResponse GetLogWithOptions(GetLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLog",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLogResponse
        /// </returns>
        public async Task<GetLogResponse> GetLogWithOptionsAsync(GetLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLog",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLogResponse
        /// </returns>
        public GetLogResponse GetLog(GetLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLogResponse
        /// </returns>
        public async Task<GetLogResponse> GetLogAsync(GetLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导入日历</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportCalendarRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportCalendarResponse
        /// </returns>
        public ImportCalendarResponse ImportCalendarWithOptions(ImportCalendarRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Months))
            {
                body["Months"] = request.Months;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["Year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportCalendar",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportCalendarResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导入日历</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportCalendarRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportCalendarResponse
        /// </returns>
        public async Task<ImportCalendarResponse> ImportCalendarWithOptionsAsync(ImportCalendarRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Months))
            {
                body["Months"] = request.Months;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["Year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportCalendar",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportCalendarResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导入日历</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportCalendarRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportCalendarResponse
        /// </returns>
        public ImportCalendarResponse ImportCalendar(ImportCalendarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportCalendarWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>导入日历</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportCalendarRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportCalendarResponse
        /// </returns>
        public async Task<ImportCalendarResponse> ImportCalendarAsync(ImportCalendarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportCalendarWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量导入任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportJobsResponse
        /// </returns>
        public ImportJobsResponse ImportJobsWithOptions(ImportJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCreateApp))
            {
                body["AutoCreateApp"] = request.AutoCreateApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overwrite))
            {
                body["Overwrite"] = request.Overwrite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportJobs",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量导入任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportJobsResponse
        /// </returns>
        public async Task<ImportJobsResponse> ImportJobsWithOptionsAsync(ImportJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCreateApp))
            {
                body["AutoCreateApp"] = request.AutoCreateApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overwrite))
            {
                body["Overwrite"] = request.Overwrite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportJobs",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量导入任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportJobsResponse
        /// </returns>
        public ImportJobsResponse ImportJobs(ImportJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportJobsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量导入任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImportJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportJobsResponse
        /// </returns>
        public async Task<ImportJobsResponse> ImportJobsAsync(ImportJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportJobsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取报警事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlarmEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlarmEventResponse
        /// </returns>
        public ListAlarmEventResponse ListAlarmEventWithOptions(ListAlarmEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAlarmEvent",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlarmEventResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取报警事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlarmEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAlarmEventResponse
        /// </returns>
        public async Task<ListAlarmEventResponse> ListAlarmEventWithOptionsAsync(ListAlarmEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAlarmEvent",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlarmEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取报警事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlarmEventRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlarmEventResponse
        /// </returns>
        public ListAlarmEventResponse ListAlarmEvent(ListAlarmEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAlarmEventWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取报警事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAlarmEventRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAlarmEventResponse
        /// </returns>
        public async Task<ListAlarmEventResponse> ListAlarmEventAsync(ListAlarmEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAlarmEventWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用名字列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppNamesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppNamesResponse
        /// </returns>
        public ListAppNamesResponse ListAppNamesWithOptions(ListAppNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppNames",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppNamesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用名字列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppNamesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppNamesResponse
        /// </returns>
        public async Task<ListAppNamesResponse> ListAppNamesWithOptionsAsync(ListAppNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppNames",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppNamesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用名字列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppNamesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppNamesResponse
        /// </returns>
        public ListAppNamesResponse ListAppNames(ListAppNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppNamesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用名字列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppNamesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppNamesResponse
        /// </returns>
        public async Task<ListAppNamesResponse> ListAppNamesAsync(ListAppNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppNamesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppsResponse
        /// </returns>
        public ListAppsResponse ListAppsWithOptions(ListAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApps",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAppsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppsResponse
        /// </returns>
        public async Task<ListAppsResponse> ListAppsWithOptionsAsync(ListAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApps",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppsResponse
        /// </returns>
        public ListAppsResponse ListApps(ListAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListAppsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppsResponse
        /// </returns>
        public async Task<ListAppsResponse> ListAppsAsync(ListAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日历名字列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCalendarNamesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCalendarNamesResponse
        /// </returns>
        public ListCalendarNamesResponse ListCalendarNamesWithOptions(ListCalendarNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCalendarNames",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCalendarNamesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日历名字列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCalendarNamesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCalendarNamesResponse
        /// </returns>
        public async Task<ListCalendarNamesResponse> ListCalendarNamesWithOptionsAsync(ListCalendarNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCalendarNames",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCalendarNamesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日历名字列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCalendarNamesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCalendarNamesResponse
        /// </returns>
        public ListCalendarNamesResponse ListCalendarNames(ListCalendarNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCalendarNamesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取日历名字列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCalendarNamesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCalendarNamesResponse
        /// </returns>
        public async Task<ListCalendarNamesResponse> ListCalendarNamesAsync(ListCalendarNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCalendarNamesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClustersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClustersResponse
        /// </returns>
        public ListClustersResponse ListClustersWithOptions(ListClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusters",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClustersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClustersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClustersResponse
        /// </returns>
        public async Task<ListClustersResponse> ListClustersWithOptionsAsync(ListClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusters",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClustersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClustersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListClustersResponse
        /// </returns>
        public ListClustersResponse ListClusters(ListClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClustersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClustersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListClustersResponse
        /// </returns>
        public async Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClustersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Executor列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExecutorsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExecutorsResponse
        /// </returns>
        public ListExecutorsResponse ListExecutorsWithOptions(ListExecutorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExecutors",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExecutorsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Executor列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExecutorsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExecutorsResponse
        /// </returns>
        public async Task<ListExecutorsResponse> ListExecutorsWithOptionsAsync(ListExecutorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExecutors",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExecutorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Executor列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExecutorsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExecutorsResponse
        /// </returns>
        public ListExecutorsResponse ListExecutors(ListExecutorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExecutorsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Executor列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExecutorsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExecutorsResponse
        /// </returns>
        public async Task<ListExecutorsResponse> ListExecutorsAsync(ListExecutorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExecutorsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobExecutionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobExecutionsResponse
        /// </returns>
        public ListJobExecutionsResponse ListJobExecutionsWithOptions(ListJobExecutionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobExecutions",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobExecutionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobExecutionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobExecutionsResponse
        /// </returns>
        public async Task<ListJobExecutionsResponse> ListJobExecutionsWithOptionsAsync(ListJobExecutionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobExecutions",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobExecutionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobExecutionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobExecutionsResponse
        /// </returns>
        public ListJobExecutionsResponse ListJobExecutions(ListJobExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJobExecutionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobExecutionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobExecutionsResponse
        /// </returns>
        public async Task<ListJobExecutionsResponse> ListJobExecutionsAsync(ListJobExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJobExecutionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public ListJobsResponse ListJobsWithOptions(ListJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public async Task<ListJobsResponse> ListJobsWithOptionsAsync(ListJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public ListJobsResponse ListJobs(ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJobsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public async Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJobsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取executor的label列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLablesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLablesResponse
        /// </returns>
        public ListLablesResponse ListLablesWithOptions(ListLablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLables",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLablesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取executor的label列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLablesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLablesResponse
        /// </returns>
        public async Task<ListLablesResponse> ListLablesWithOptionsAsync(ListLablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLables",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取executor的label列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLablesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLablesResponse
        /// </returns>
        public ListLablesResponse ListLables(ListLablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLablesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取executor的label列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLablesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLablesResponse
        /// </returns>
        public async Task<ListLablesResponse> ListLablesAsync(ListLablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLablesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取可用区列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRegionZoneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRegionZoneResponse
        /// </returns>
        public ListRegionZoneResponse ListRegionZoneWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegionZone",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionZoneResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取可用区列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRegionZoneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRegionZoneResponse
        /// </returns>
        public async Task<ListRegionZoneResponse> ListRegionZoneWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegionZone",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionZoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取可用区列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListRegionZoneResponse
        /// </returns>
        public ListRegionZoneResponse ListRegionZone()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRegionZoneWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取可用区列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListRegionZoneResponse
        /// </returns>
        public async Task<ListRegionZoneResponse> ListRegionZoneAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRegionZoneWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有region列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public ListRegionsResponse ListRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有region列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public async Task<ListRegionsResponse> ListRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有region列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public ListRegionsResponse ListRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRegionsWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有region列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public async Task<ListRegionsResponse> ListRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRegionsWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询调度事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduleEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScheduleEventResponse
        /// </returns>
        public ListScheduleEventResponse ListScheduleEventWithOptions(ListScheduleEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScheduleEvent",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScheduleEventResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询调度事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduleEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScheduleEventResponse
        /// </returns>
        public async Task<ListScheduleEventResponse> ListScheduleEventWithOptionsAsync(ListScheduleEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScheduleEvent",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScheduleEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询调度事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduleEventRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScheduleEventResponse
        /// </returns>
        public ListScheduleEventResponse ListScheduleEvent(ListScheduleEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScheduleEventWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询调度事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduleEventRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScheduleEventResponse
        /// </returns>
        public async Task<ListScheduleEventResponse> ListScheduleEventAsync(ListScheduleEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScheduleEventWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定时间类型和表达式未来5次调度时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduleTimesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScheduleTimesResponse
        /// </returns>
        public ListScheduleTimesResponse ListScheduleTimesWithOptions(ListScheduleTimesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScheduleTimes",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScheduleTimesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定时间类型和表达式未来5次调度时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduleTimesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScheduleTimesResponse
        /// </returns>
        public async Task<ListScheduleTimesResponse> ListScheduleTimesWithOptionsAsync(ListScheduleTimesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScheduleTimes",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScheduleTimesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定时间类型和表达式未来5次调度时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduleTimesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScheduleTimesResponse
        /// </returns>
        public ListScheduleTimesResponse ListScheduleTimes(ListScheduleTimesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScheduleTimesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定时间类型和表达式未来5次调度时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduleTimesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScheduleTimesResponse
        /// </returns>
        public async Task<ListScheduleTimesResponse> ListScheduleTimesAsync(ListScheduleTimesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScheduleTimesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定执行器</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// OperateDesignateExecutorsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateDesignateExecutorsResponse
        /// </returns>
        public OperateDesignateExecutorsResponse OperateDesignateExecutorsWithOptions(OperateDesignateExecutorsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            OperateDesignateExecutorsShrinkRequest request = new OperateDesignateExecutorsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AddressList))
            {
                request.AddressListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AddressList, "AddressList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressListShrink))
            {
                body["AddressList"] = request.AddressListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesignateType))
            {
                body["DesignateType"] = request.DesignateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Transferable))
            {
                body["Transferable"] = request.Transferable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateDesignateExecutors",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateDesignateExecutorsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定执行器</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// OperateDesignateExecutorsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateDesignateExecutorsResponse
        /// </returns>
        public async Task<OperateDesignateExecutorsResponse> OperateDesignateExecutorsWithOptionsAsync(OperateDesignateExecutorsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            OperateDesignateExecutorsShrinkRequest request = new OperateDesignateExecutorsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AddressList))
            {
                request.AddressListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AddressList, "AddressList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressListShrink))
            {
                body["AddressList"] = request.AddressListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesignateType))
            {
                body["DesignateType"] = request.DesignateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Transferable))
            {
                body["Transferable"] = request.Transferable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateDesignateExecutors",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateDesignateExecutorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定执行器</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateDesignateExecutorsRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateDesignateExecutorsResponse
        /// </returns>
        public OperateDesignateExecutorsResponse OperateDesignateExecutors(OperateDesignateExecutorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateDesignateExecutorsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>指定执行器</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateDesignateExecutorsRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateDesignateExecutorsResponse
        /// </returns>
        public async Task<OperateDesignateExecutorsResponse> OperateDesignateExecutorsAsync(OperateDesignateExecutorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateDesignateExecutorsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量禁用任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// OperateDisableJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateDisableJobsResponse
        /// </returns>
        public OperateDisableJobsResponse OperateDisableJobsWithOptions(OperateDisableJobsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            OperateDisableJobsShrinkRequest request = new OperateDisableJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobIds))
            {
                request.JobIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobIds, "JobIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIdsShrink))
            {
                body["JobIds"] = request.JobIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateDisableJobs",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateDisableJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量禁用任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// OperateDisableJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateDisableJobsResponse
        /// </returns>
        public async Task<OperateDisableJobsResponse> OperateDisableJobsWithOptionsAsync(OperateDisableJobsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            OperateDisableJobsShrinkRequest request = new OperateDisableJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobIds))
            {
                request.JobIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobIds, "JobIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIdsShrink))
            {
                body["JobIds"] = request.JobIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateDisableJobs",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateDisableJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量禁用任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateDisableJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateDisableJobsResponse
        /// </returns>
        public OperateDisableJobsResponse OperateDisableJobs(OperateDisableJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateDisableJobsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量禁用任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateDisableJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateDisableJobsResponse
        /// </returns>
        public async Task<OperateDisableJobsResponse> OperateDisableJobsAsync(OperateDisableJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateDisableJobsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量启用任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// OperateEnableJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateEnableJobsResponse
        /// </returns>
        public OperateEnableJobsResponse OperateEnableJobsWithOptions(OperateEnableJobsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            OperateEnableJobsShrinkRequest request = new OperateEnableJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobIds))
            {
                request.JobIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobIds, "JobIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIdsShrink))
            {
                body["JobIds"] = request.JobIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateEnableJobs",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateEnableJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量启用任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// OperateEnableJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateEnableJobsResponse
        /// </returns>
        public async Task<OperateEnableJobsResponse> OperateEnableJobsWithOptionsAsync(OperateEnableJobsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            OperateEnableJobsShrinkRequest request = new OperateEnableJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobIds))
            {
                request.JobIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobIds, "JobIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIdsShrink))
            {
                body["JobIds"] = request.JobIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateEnableJobs",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateEnableJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量启用任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateEnableJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateEnableJobsResponse
        /// </returns>
        public OperateEnableJobsResponse OperateEnableJobs(OperateEnableJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateEnableJobsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量启用任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateEnableJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateEnableJobsResponse
        /// </returns>
        public async Task<OperateEnableJobsResponse> OperateEnableJobsAsync(OperateEnableJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateEnableJobsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行一次任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateExecuteJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateExecuteJobResponse
        /// </returns>
        public OperateExecuteJobResponse OperateExecuteJobWithOptions(OperateExecuteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceParameters))
            {
                body["InstanceParameters"] = request.InstanceParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Worker))
            {
                body["Worker"] = request.Worker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateExecuteJob",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateExecuteJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行一次任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateExecuteJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateExecuteJobResponse
        /// </returns>
        public async Task<OperateExecuteJobResponse> OperateExecuteJobWithOptionsAsync(OperateExecuteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceParameters))
            {
                body["InstanceParameters"] = request.InstanceParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Worker))
            {
                body["Worker"] = request.Worker;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateExecuteJob",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateExecuteJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行一次任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateExecuteJobRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateExecuteJobResponse
        /// </returns>
        public OperateExecuteJobResponse OperateExecuteJob(OperateExecuteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateExecuteJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行一次任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateExecuteJobRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateExecuteJobResponse
        /// </returns>
        public async Task<OperateExecuteJobResponse> OperateExecuteJobAsync(OperateExecuteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateExecuteJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重刷任务历史数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateRerunJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateRerunJobResponse
        /// </returns>
        public OperateRerunJobResponse OperateRerunJobWithOptions(OperateRerunJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTime))
            {
                query["DataTime"] = request.DataTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateRerunJob",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateRerunJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重刷任务历史数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateRerunJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateRerunJobResponse
        /// </returns>
        public async Task<OperateRerunJobResponse> OperateRerunJobWithOptionsAsync(OperateRerunJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTime))
            {
                query["DataTime"] = request.DataTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateRerunJob",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateRerunJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重刷任务历史数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateRerunJobRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateRerunJobResponse
        /// </returns>
        public OperateRerunJobResponse OperateRerunJob(OperateRerunJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateRerunJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重刷任务历史数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateRerunJobRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateRerunJobResponse
        /// </returns>
        public async Task<OperateRerunJobResponse> OperateRerunJobAsync(OperateRerunJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateRerunJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重跑失败的任务实例</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// OperateRetryJobExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateRetryJobExecutionResponse
        /// </returns>
        public OperateRetryJobExecutionResponse OperateRetryJobExecutionWithOptions(OperateRetryJobExecutionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            OperateRetryJobExecutionShrinkRequest request = new OperateRetryJobExecutionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskList))
            {
                request.TaskListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskList, "TaskList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobExecutionId))
            {
                query["JobExecutionId"] = request.JobExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskListShrink))
            {
                query["TaskList"] = request.TaskListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateRetryJobExecution",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateRetryJobExecutionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重跑失败的任务实例</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// OperateRetryJobExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateRetryJobExecutionResponse
        /// </returns>
        public async Task<OperateRetryJobExecutionResponse> OperateRetryJobExecutionWithOptionsAsync(OperateRetryJobExecutionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            OperateRetryJobExecutionShrinkRequest request = new OperateRetryJobExecutionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskList))
            {
                request.TaskListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskList, "TaskList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobExecutionId))
            {
                query["JobExecutionId"] = request.JobExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskListShrink))
            {
                query["TaskList"] = request.TaskListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateRetryJobExecution",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateRetryJobExecutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重跑失败的任务实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateRetryJobExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateRetryJobExecutionResponse
        /// </returns>
        public OperateRetryJobExecutionResponse OperateRetryJobExecution(OperateRetryJobExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateRetryJobExecutionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重跑失败的任务实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateRetryJobExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateRetryJobExecutionResponse
        /// </returns>
        public async Task<OperateRetryJobExecutionResponse> OperateRetryJobExecutionAsync(OperateRetryJobExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateRetryJobExecutionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止正在运行的任务实例</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// OperateStopJobExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateStopJobExecutionResponse
        /// </returns>
        public OperateStopJobExecutionResponse OperateStopJobExecutionWithOptions(OperateStopJobExecutionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            OperateStopJobExecutionShrinkRequest request = new OperateStopJobExecutionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskList))
            {
                request.TaskListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskList, "TaskList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobExecutionId))
            {
                query["JobExecutionId"] = request.JobExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskListShrink))
            {
                query["TaskList"] = request.TaskListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateStopJobExecution",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateStopJobExecutionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止正在运行的任务实例</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// OperateStopJobExecutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateStopJobExecutionResponse
        /// </returns>
        public async Task<OperateStopJobExecutionResponse> OperateStopJobExecutionWithOptionsAsync(OperateStopJobExecutionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            OperateStopJobExecutionShrinkRequest request = new OperateStopJobExecutionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskList))
            {
                request.TaskListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskList, "TaskList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobExecutionId))
            {
                query["JobExecutionId"] = request.JobExecutionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskListShrink))
            {
                query["TaskList"] = request.TaskListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateStopJobExecution",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateStopJobExecutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止正在运行的任务实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateStopJobExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateStopJobExecutionResponse
        /// </returns>
        public OperateStopJobExecutionResponse OperateStopJobExecution(OperateStopJobExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateStopJobExecutionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止正在运行的任务实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateStopJobExecutionRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateStopJobExecutionResponse
        /// </returns>
        public async Task<OperateStopJobExecutionResponse> OperateStopJobExecutionAsync(OperateStopJobExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateStopJobExecutionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新应用分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAppResponse
        /// </returns>
        public UpdateAppResponse UpdateAppWithOptions(UpdateAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                body["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableLog))
            {
                body["EnableLog"] = request.EnableLog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                body["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApp",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新应用分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAppResponse
        /// </returns>
        public async Task<UpdateAppResponse> UpdateAppWithOptionsAsync(UpdateAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                body["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableLog))
            {
                body["EnableLog"] = request.EnableLog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                body["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApp",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新应用分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAppRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAppResponse
        /// </returns>
        public UpdateAppResponse UpdateApp(UpdateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新应用分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAppRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAppResponse
        /// </returns>
        public async Task<UpdateAppResponse> UpdateAppAsync(UpdateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAppWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateClusterResponse
        /// </returns>
        public UpdateClusterResponse UpdateClusterWithOptions(UpdateClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCluster",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateClusterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateClusterResponse
        /// </returns>
        public async Task<UpdateClusterResponse> UpdateClusterWithOptionsAsync(UpdateClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCluster",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateClusterResponse
        /// </returns>
        public UpdateClusterResponse UpdateCluster(UpdateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateClusterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新集群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateClusterResponse
        /// </returns>
        public async Task<UpdateClusterResponse> UpdateClusterAsync(UpdateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateClusterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新任务信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateJobResponse
        /// </returns>
        public UpdateJobResponse UpdateJobWithOptions(UpdateJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateJobShrinkRequest request = new UpdateJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NoticeConfig))
            {
                request.NoticeConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NoticeConfig, "NoticeConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NoticeContacts))
            {
                request.NoticeContactsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NoticeContacts, "NoticeContacts", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttemptInterval))
            {
                body["AttemptInterval"] = request.AttemptInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Calendar))
            {
                body["Calendar"] = request.Calendar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildJobId))
            {
                body["ChildJobId"] = request.ChildJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorBlockStrategy))
            {
                body["ExecutorBlockStrategy"] = request.ExecutorBlockStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobHandler))
            {
                body["JobHandler"] = request.JobHandler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttempt))
            {
                body["MaxAttempt"] = request.MaxAttempt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                body["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeConfigShrink))
            {
                body["NoticeConfig"] = request.NoticeConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeContactsShrink))
            {
                body["NoticeContacts"] = request.NoticeContactsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteStrategy))
            {
                body["RouteStrategy"] = request.RouteStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Script))
            {
                body["Script"] = request.Script;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeExpression))
            {
                body["TimeExpression"] = request.TimeExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeType))
            {
                body["TimeType"] = request.TimeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                body["Timezone"] = request.Timezone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateJob",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新任务信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateJobResponse
        /// </returns>
        public async Task<UpdateJobResponse> UpdateJobWithOptionsAsync(UpdateJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateJobShrinkRequest request = new UpdateJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NoticeConfig))
            {
                request.NoticeConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NoticeConfig, "NoticeConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NoticeContacts))
            {
                request.NoticeContactsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NoticeContacts, "NoticeContacts", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttemptInterval))
            {
                body["AttemptInterval"] = request.AttemptInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Calendar))
            {
                body["Calendar"] = request.Calendar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildJobId))
            {
                body["ChildJobId"] = request.ChildJobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorBlockStrategy))
            {
                body["ExecutorBlockStrategy"] = request.ExecutorBlockStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobHandler))
            {
                body["JobHandler"] = request.JobHandler;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttempt))
            {
                body["MaxAttempt"] = request.MaxAttempt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConcurrency))
            {
                body["MaxConcurrency"] = request.MaxConcurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeConfigShrink))
            {
                body["NoticeConfig"] = request.NoticeConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeContactsShrink))
            {
                body["NoticeContacts"] = request.NoticeContactsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteStrategy))
            {
                body["RouteStrategy"] = request.RouteStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Script))
            {
                body["Script"] = request.Script;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeExpression))
            {
                body["TimeExpression"] = request.TimeExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeType))
            {
                body["TimeType"] = request.TimeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                body["Timezone"] = request.Timezone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateJob",
                Version = "2024-06-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新任务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateJobRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateJobResponse
        /// </returns>
        public UpdateJobResponse UpdateJob(UpdateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新任务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateJobRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateJobResponse
        /// </returns>
        public async Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateJobWithOptionsAsync(request, runtime);
        }

    }
}
