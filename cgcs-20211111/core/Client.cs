// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.CGCS20211111.Models;

namespace AlibabaCloud.SDK.CGCS20211111
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cgcs", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 批量检查异常会话
         *
         * @param tmpReq BatchCheckSessionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchCheckSessionResponse
         */
        public BatchCheckSessionResponse BatchCheckSessionWithOptions(BatchCheckSessionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchCheckSessionShrinkRequest request = new BatchCheckSessionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Records))
            {
                request.RecordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Records, "Records", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordsShrink))
            {
                query["Records"] = request.RecordsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCheckSession",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCheckSessionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量检查异常会话
         *
         * @param tmpReq BatchCheckSessionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchCheckSessionResponse
         */
        public async Task<BatchCheckSessionResponse> BatchCheckSessionWithOptionsAsync(BatchCheckSessionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchCheckSessionShrinkRequest request = new BatchCheckSessionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Records))
            {
                request.RecordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Records, "Records", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordsShrink))
            {
                query["Records"] = request.RecordsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCheckSession",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCheckSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量检查异常会话
         *
         * @param request BatchCheckSessionRequest
         * @return BatchCheckSessionResponse
         */
        public BatchCheckSessionResponse BatchCheckSession(BatchCheckSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchCheckSessionWithOptions(request, runtime);
        }

        /**
         * @summary 批量检查异常会话
         *
         * @param request BatchCheckSessionRequest
         * @return BatchCheckSessionResponse
         */
        public async Task<BatchCheckSessionResponse> BatchCheckSessionAsync(BatchCheckSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchCheckSessionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 取消 session 资源预定任务
         *
         * @param request CancelReserveTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelReserveTaskResponse
         */
        public CancelReserveTaskResponse CancelReserveTaskWithOptions(CancelReserveTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelReserveTask",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelReserveTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 取消 session 资源预定任务
         *
         * @param request CancelReserveTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelReserveTaskResponse
         */
        public async Task<CancelReserveTaskResponse> CancelReserveTaskWithOptionsAsync(CancelReserveTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelReserveTask",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelReserveTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 取消 session 资源预定任务
         *
         * @param request CancelReserveTaskRequest
         * @return CancelReserveTaskResponse
         */
        public CancelReserveTaskResponse CancelReserveTask(CancelReserveTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelReserveTaskWithOptions(request, runtime);
        }

        /**
         * @summary 取消 session 资源预定任务
         *
         * @param request CancelReserveTaskRequest
         * @return CancelReserveTaskResponse
         */
        public async Task<CancelReserveTaskResponse> CancelReserveTaskAsync(CancelReserveTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelReserveTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交适配请求
         *
         * @param tmpReq CreateAdaptationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAdaptationResponse
         */
        public CreateAdaptationResponse CreateAdaptationWithOptions(CreateAdaptationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAdaptationShrinkRequest request = new CreateAdaptationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdaptTarget))
            {
                request.AdaptTargetShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdaptTarget, "AdaptTarget", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdaptTargetShrink))
            {
                body["AdaptTarget"] = request.AdaptTargetShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersionId))
            {
                body["AppVersionId"] = request.AppVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAdaptation",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAdaptationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 提交适配请求
         *
         * @param tmpReq CreateAdaptationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAdaptationResponse
         */
        public async Task<CreateAdaptationResponse> CreateAdaptationWithOptionsAsync(CreateAdaptationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAdaptationShrinkRequest request = new CreateAdaptationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdaptTarget))
            {
                request.AdaptTargetShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdaptTarget, "AdaptTarget", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdaptTargetShrink))
            {
                body["AdaptTarget"] = request.AdaptTargetShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersionId))
            {
                body["AppVersionId"] = request.AppVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAdaptation",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAdaptationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 提交适配请求
         *
         * @param request CreateAdaptationRequest
         * @return CreateAdaptationResponse
         */
        public CreateAdaptationResponse CreateAdaptation(CreateAdaptationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAdaptationWithOptions(request, runtime);
        }

        /**
         * @summary 提交适配请求
         *
         * @param request CreateAdaptationRequest
         * @return CreateAdaptationResponse
         */
        public async Task<CreateAdaptationResponse> CreateAdaptationAsync(CreateAdaptationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAdaptationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 应用创建服务
         *
         * @param request CreateAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppResponse
         */
        public CreateAppResponse CreateAppWithOptions(CreateAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["AppType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamingAppId))
            {
                body["StreamingAppId"] = request.StreamingAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamingSolution))
            {
                body["StreamingSolution"] = request.StreamingSolution;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApp",
                Version = "2021-11-11",
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

        /**
         * @summary 应用创建服务
         *
         * @param request CreateAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppResponse
         */
        public async Task<CreateAppResponse> CreateAppWithOptionsAsync(CreateAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["AppType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamingAppId))
            {
                body["StreamingAppId"] = request.StreamingAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamingSolution))
            {
                body["StreamingSolution"] = request.StreamingSolution;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApp",
                Version = "2021-11-11",
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

        /**
         * @summary 应用创建服务
         *
         * @param request CreateAppRequest
         * @return CreateAppResponse
         */
        public CreateAppResponse CreateApp(CreateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppWithOptions(request, runtime);
        }

        /**
         * @summary 应用创建服务
         *
         * @param request CreateAppRequest
         * @return CreateAppResponse
         */
        public async Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 增加实时生产资源的相关字段
         *
         * @param request CreateAppSessionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppSessionResponse
         */
        public CreateAppSessionResponse CreateAppSessionWithOptions(CreateAppSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdapterFileId))
            {
                query["AdapterFileId"] = request.AdapterFileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                query["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                query["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomSessionId))
            {
                query["CustomSessionId"] = request.CustomSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomUserId))
            {
                query["CustomUserId"] = request.CustomUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistrictId))
            {
                query["DistrictId"] = request.DistrictId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePostpaid))
            {
                query["EnablePostpaid"] = request.EnablePostpaid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartParameters))
            {
                query["StartParameters"] = request.StartParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemInfo))
            {
                query["SystemInfo"] = request.SystemInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppSession",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppSessionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 增加实时生产资源的相关字段
         *
         * @param request CreateAppSessionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppSessionResponse
         */
        public async Task<CreateAppSessionResponse> CreateAppSessionWithOptionsAsync(CreateAppSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdapterFileId))
            {
                query["AdapterFileId"] = request.AdapterFileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                query["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                query["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomSessionId))
            {
                query["CustomSessionId"] = request.CustomSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomUserId))
            {
                query["CustomUserId"] = request.CustomUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistrictId))
            {
                query["DistrictId"] = request.DistrictId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePostpaid))
            {
                query["EnablePostpaid"] = request.EnablePostpaid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartParameters))
            {
                query["StartParameters"] = request.StartParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemInfo))
            {
                query["SystemInfo"] = request.SystemInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppSession",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 增加实时生产资源的相关字段
         *
         * @param request CreateAppSessionRequest
         * @return CreateAppSessionResponse
         */
        public CreateAppSessionResponse CreateAppSession(CreateAppSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppSessionWithOptions(request, runtime);
        }

        /**
         * @summary 增加实时生产资源的相关字段
         *
         * @param request CreateAppSessionRequest
         * @return CreateAppSessionResponse
         */
        public async Task<CreateAppSessionResponse> CreateAppSessionAsync(CreateAppSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppSessionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量创建会话
         *
         * @param tmpReq CreateAppSessionBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppSessionBatchResponse
         */
        public CreateAppSessionBatchResponse CreateAppSessionBatchWithOptions(CreateAppSessionBatchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAppSessionBatchShrinkRequest request = new CreateAppSessionBatchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AppInfos))
            {
                request.AppInfosShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AppInfos, "AppInfos", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInfosShrink))
            {
                query["AppInfos"] = request.AppInfosShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomTaskId))
            {
                query["CustomTaskId"] = request.CustomTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppSessionBatch",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppSessionBatchResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量创建会话
         *
         * @param tmpReq CreateAppSessionBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppSessionBatchResponse
         */
        public async Task<CreateAppSessionBatchResponse> CreateAppSessionBatchWithOptionsAsync(CreateAppSessionBatchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAppSessionBatchShrinkRequest request = new CreateAppSessionBatchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AppInfos))
            {
                request.AppInfosShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AppInfos, "AppInfos", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInfosShrink))
            {
                query["AppInfos"] = request.AppInfosShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomTaskId))
            {
                query["CustomTaskId"] = request.CustomTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppSessionBatch",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppSessionBatchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量创建会话
         *
         * @param request CreateAppSessionBatchRequest
         * @return CreateAppSessionBatchResponse
         */
        public CreateAppSessionBatchResponse CreateAppSessionBatch(CreateAppSessionBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppSessionBatchWithOptions(request, runtime);
        }

        /**
         * @summary 批量创建会话
         *
         * @param request CreateAppSessionBatchRequest
         * @return CreateAppSessionBatchResponse
         */
        public async Task<CreateAppSessionBatchResponse> CreateAppSessionBatchAsync(CreateAppSessionBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppSessionBatchWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 同步批量创建多个会话
         *
         * @param tmpReq CreateAppSessionBatchSyncRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppSessionBatchSyncResponse
         */
        public CreateAppSessionBatchSyncResponse CreateAppSessionBatchSyncWithOptions(CreateAppSessionBatchSyncRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAppSessionBatchSyncShrinkRequest request = new CreateAppSessionBatchSyncShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AppInfos))
            {
                request.AppInfosShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AppInfos, "AppInfos", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInfosShrink))
            {
                query["AppInfos"] = request.AppInfosShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["BatchId"] = request.BatchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppSessionBatchSync",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppSessionBatchSyncResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 同步批量创建多个会话
         *
         * @param tmpReq CreateAppSessionBatchSyncRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppSessionBatchSyncResponse
         */
        public async Task<CreateAppSessionBatchSyncResponse> CreateAppSessionBatchSyncWithOptionsAsync(CreateAppSessionBatchSyncRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAppSessionBatchSyncShrinkRequest request = new CreateAppSessionBatchSyncShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AppInfos))
            {
                request.AppInfosShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AppInfos, "AppInfos", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInfosShrink))
            {
                query["AppInfos"] = request.AppInfosShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["BatchId"] = request.BatchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppSessionBatchSync",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppSessionBatchSyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 同步批量创建多个会话
         *
         * @param request CreateAppSessionBatchSyncRequest
         * @return CreateAppSessionBatchSyncResponse
         */
        public CreateAppSessionBatchSyncResponse CreateAppSessionBatchSync(CreateAppSessionBatchSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppSessionBatchSyncWithOptions(request, runtime);
        }

        /**
         * @summary 同步批量创建多个会话
         *
         * @param request CreateAppSessionBatchSyncRequest
         * @return CreateAppSessionBatchSyncResponse
         */
        public async Task<CreateAppSessionBatchSyncResponse> CreateAppSessionBatchSyncAsync(CreateAppSessionBatchSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppSessionBatchSyncWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 同步创建会话
         *
         * @param request CreateAppSessionSyncRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppSessionSyncResponse
         */
        public CreateAppSessionSyncResponse CreateAppSessionSyncWithOptions(CreateAppSessionSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdapterFileId))
            {
                query["AdapterFileId"] = request.AdapterFileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                query["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                query["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomSessionId))
            {
                query["CustomSessionId"] = request.CustomSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomUserId))
            {
                query["CustomUserId"] = request.CustomUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistrictId))
            {
                query["DistrictId"] = request.DistrictId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchRules))
            {
                query["MatchRules"] = request.MatchRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartParameters))
            {
                query["StartParameters"] = request.StartParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemInfo))
            {
                query["SystemInfo"] = request.SystemInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppSessionSync",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppSessionSyncResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 同步创建会话
         *
         * @param request CreateAppSessionSyncRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppSessionSyncResponse
         */
        public async Task<CreateAppSessionSyncResponse> CreateAppSessionSyncWithOptionsAsync(CreateAppSessionSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdapterFileId))
            {
                query["AdapterFileId"] = request.AdapterFileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                query["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIp))
            {
                query["ClientIp"] = request.ClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomSessionId))
            {
                query["CustomSessionId"] = request.CustomSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomUserId))
            {
                query["CustomUserId"] = request.CustomUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistrictId))
            {
                query["DistrictId"] = request.DistrictId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchRules))
            {
                query["MatchRules"] = request.MatchRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartParameters))
            {
                query["StartParameters"] = request.StartParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemInfo))
            {
                query["SystemInfo"] = request.SystemInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppSessionSync",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppSessionSyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 同步创建会话
         *
         * @param request CreateAppSessionSyncRequest
         * @return CreateAppSessionSyncResponse
         */
        public CreateAppSessionSyncResponse CreateAppSessionSync(CreateAppSessionSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppSessionSyncWithOptions(request, runtime);
        }

        /**
         * @summary 同步创建会话
         *
         * @param request CreateAppSessionSyncRequest
         * @return CreateAppSessionSyncResponse
         */
        public async Task<CreateAppSessionSyncResponse> CreateAppSessionSyncAsync(CreateAppSessionSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppSessionSyncWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 应用版本创建服务
         *
         * @param request CreateAppVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppVersionResponse
         */
        public CreateAppVersionResponse CreateAppVersionWithOptions(CreateAppVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersionName))
            {
                body["AppVersionName"] = request.AppVersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppVersion",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 应用版本创建服务
         *
         * @param request CreateAppVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppVersionResponse
         */
        public async Task<CreateAppVersionResponse> CreateAppVersionWithOptionsAsync(CreateAppVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersionName))
            {
                body["AppVersionName"] = request.AppVersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppVersion",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 应用版本创建服务
         *
         * @param request CreateAppVersionRequest
         * @return CreateAppVersionResponse
         */
        public CreateAppVersionResponse CreateAppVersion(CreateAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppVersionWithOptions(request, runtime);
        }

        /**
         * @summary 应用版本创建服务
         *
         * @param request CreateAppVersionRequest
         * @return CreateAppVersionResponse
         */
        public async Task<CreateAppVersionResponse> CreateAppVersionAsync(CreateAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppVersionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 预定session资源
         *
         * @param request CreateCapacityReservationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCapacityReservationResponse
         */
        public CreateCapacityReservationResponse CreateCapacityReservationWithOptions(CreateCapacityReservationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                body["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistrictId))
            {
                body["DistrictId"] = request.DistrictId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectResourceReadyTime))
            {
                body["ExpectResourceReadyTime"] = request.ExpectResourceReadyTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectSessionCapacity))
            {
                body["ExpectSessionCapacity"] = request.ExpectSessionCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCapacityReservation",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCapacityReservationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 预定session资源
         *
         * @param request CreateCapacityReservationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCapacityReservationResponse
         */
        public async Task<CreateCapacityReservationResponse> CreateCapacityReservationWithOptionsAsync(CreateCapacityReservationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                body["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistrictId))
            {
                body["DistrictId"] = request.DistrictId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectResourceReadyTime))
            {
                body["ExpectResourceReadyTime"] = request.ExpectResourceReadyTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectSessionCapacity))
            {
                body["ExpectSessionCapacity"] = request.ExpectSessionCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCapacityReservation",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCapacityReservationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 预定session资源
         *
         * @param request CreateCapacityReservationRequest
         * @return CreateCapacityReservationResponse
         */
        public CreateCapacityReservationResponse CreateCapacityReservation(CreateCapacityReservationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCapacityReservationWithOptions(request, runtime);
        }

        /**
         * @summary 预定session资源
         *
         * @param request CreateCapacityReservationRequest
         * @return CreateCapacityReservationResponse
         */
        public async Task<CreateCapacityReservationResponse> CreateCapacityReservationAsync(CreateCapacityReservationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCapacityReservationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 应用删除接口
         *
         * @param request DeleteAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppResponse
         */
        public DeleteAppResponse DeleteAppWithOptions(DeleteAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApp",
                Version = "2021-11-11",
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

        /**
         * @summary 应用删除接口
         *
         * @param request DeleteAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppResponse
         */
        public async Task<DeleteAppResponse> DeleteAppWithOptionsAsync(DeleteAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApp",
                Version = "2021-11-11",
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

        /**
         * @summary 应用删除接口
         *
         * @param request DeleteAppRequest
         * @return DeleteAppResponse
         */
        public DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppWithOptions(request, runtime);
        }

        /**
         * @summary 应用删除接口
         *
         * @param request DeleteAppRequest
         * @return DeleteAppResponse
         */
        public async Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 应用版本删除接口
         *
         * @param request DeleteAppVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppVersionResponse
         */
        public DeleteAppVersionResponse DeleteAppVersionWithOptions(DeleteAppVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersionId))
            {
                body["AppVersionId"] = request.AppVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppVersion",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 应用版本删除接口
         *
         * @param request DeleteAppVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppVersionResponse
         */
        public async Task<DeleteAppVersionResponse> DeleteAppVersionWithOptionsAsync(DeleteAppVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersionId))
            {
                body["AppVersionId"] = request.AppVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppVersion",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 应用版本删除接口
         *
         * @param request DeleteAppVersionRequest
         * @return DeleteAppVersionResponse
         */
        public DeleteAppVersionResponse DeleteAppVersion(DeleteAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppVersionWithOptions(request, runtime);
        }

        /**
         * @summary 应用版本删除接口
         *
         * @param request DeleteAppVersionRequest
         * @return DeleteAppVersionResponse
         */
        public async Task<DeleteAppVersionResponse> DeleteAppVersionAsync(DeleteAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppVersionWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeInstanceStatsInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceStatsInfoResponse
         */
        public DescribeInstanceStatsInfoResponse DescribeInstanceStatsInfoWithOptions(DescribeInstanceStatsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceStatsInfo",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceStatsInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeInstanceStatsInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceStatsInfoResponse
         */
        public async Task<DescribeInstanceStatsInfoResponse> DescribeInstanceStatsInfoWithOptionsAsync(DescribeInstanceStatsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceStatsInfo",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceStatsInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeInstanceStatsInfoRequest
         * @return DescribeInstanceStatsInfoResponse
         */
        public DescribeInstanceStatsInfoResponse DescribeInstanceStatsInfo(DescribeInstanceStatsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceStatsInfoWithOptions(request, runtime);
        }

        /**
         * @param request DescribeInstanceStatsInfoRequest
         * @return DescribeInstanceStatsInfoResponse
         */
        public async Task<DescribeInstanceStatsInfoResponse> DescribeInstanceStatsInfoAsync(DescribeInstanceStatsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceStatsInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取适配申请详情
         *
         * @param request GetAdaptationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAdaptationResponse
         */
        public GetAdaptationResponse GetAdaptationWithOptions(GetAdaptationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdaptApplyId))
            {
                body["AdaptApplyId"] = request.AdaptApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersionId))
            {
                body["AppVersionId"] = request.AppVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAdaptation",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdaptationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取适配申请详情
         *
         * @param request GetAdaptationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAdaptationResponse
         */
        public async Task<GetAdaptationResponse> GetAdaptationWithOptionsAsync(GetAdaptationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdaptApplyId))
            {
                body["AdaptApplyId"] = request.AdaptApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersionId))
            {
                body["AppVersionId"] = request.AppVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAdaptation",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAdaptationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取适配申请详情
         *
         * @param request GetAdaptationRequest
         * @return GetAdaptationResponse
         */
        public GetAdaptationResponse GetAdaptation(GetAdaptationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAdaptationWithOptions(request, runtime);
        }

        /**
         * @summary 获取适配申请详情
         *
         * @param request GetAdaptationRequest
         * @return GetAdaptationResponse
         */
        public async Task<GetAdaptationResponse> GetAdaptationAsync(GetAdaptationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAdaptationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 应用详情接口
         *
         * @param request GetAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppResponse
         */
        public GetAppResponse GetAppWithOptions(GetAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApp",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 应用详情接口
         *
         * @param request GetAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppResponse
         */
        public async Task<GetAppResponse> GetAppWithOptionsAsync(GetAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApp",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 应用详情接口
         *
         * @param request GetAppRequest
         * @return GetAppResponse
         */
        public GetAppResponse GetApp(GetAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAppWithOptions(request, runtime);
        }

        /**
         * @summary 应用详情接口
         *
         * @param request GetAppRequest
         * @return GetAppResponse
         */
        public async Task<GetAppResponse> GetAppAsync(GetAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAppWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询会话并发数
         *
         * @param request GetAppCcuRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppCcuResponse
         */
        public GetAppCcuResponse GetAppCcuWithOptions(GetAppCcuRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppCcu",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppCcuResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询会话并发数
         *
         * @param request GetAppCcuRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppCcuResponse
         */
        public async Task<GetAppCcuResponse> GetAppCcuWithOptionsAsync(GetAppCcuRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppCcu",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppCcuResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询会话并发数
         *
         * @param request GetAppCcuRequest
         * @return GetAppCcuResponse
         */
        public GetAppCcuResponse GetAppCcu(GetAppCcuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAppCcuWithOptions(request, runtime);
        }

        /**
         * @summary 查询会话并发数
         *
         * @param request GetAppCcuRequest
         * @return GetAppCcuResponse
         */
        public async Task<GetAppCcuResponse> GetAppCcuAsync(GetAppCcuRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAppCcuWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取App会话信息
         *
         * @param request GetAppSessionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppSessionResponse
         */
        public GetAppSessionResponse GetAppSessionWithOptions(GetAppSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomSessionId))
            {
                query["CustomSessionId"] = request.CustomSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformSessionId))
            {
                query["PlatformSessionId"] = request.PlatformSessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppSession",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppSessionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取App会话信息
         *
         * @param request GetAppSessionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppSessionResponse
         */
        public async Task<GetAppSessionResponse> GetAppSessionWithOptionsAsync(GetAppSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomSessionId))
            {
                query["CustomSessionId"] = request.CustomSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformSessionId))
            {
                query["PlatformSessionId"] = request.PlatformSessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppSession",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取App会话信息
         *
         * @param request GetAppSessionRequest
         * @return GetAppSessionResponse
         */
        public GetAppSessionResponse GetAppSession(GetAppSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAppSessionWithOptions(request, runtime);
        }

        /**
         * @summary 获取App会话信息
         *
         * @param request GetAppSessionRequest
         * @return GetAppSessionResponse
         */
        public async Task<GetAppSessionResponse> GetAppSessionAsync(GetAppSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAppSessionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 应用版本详情接口
         *
         * @param request GetAppVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppVersionResponse
         */
        public GetAppVersionResponse GetAppVersionWithOptions(GetAppVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersionId))
            {
                body["AppVersionId"] = request.AppVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppVersion",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 应用版本详情接口
         *
         * @param request GetAppVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppVersionResponse
         */
        public async Task<GetAppVersionResponse> GetAppVersionWithOptionsAsync(GetAppVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersionId))
            {
                body["AppVersionId"] = request.AppVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppVersion",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 应用版本详情接口
         *
         * @param request GetAppVersionRequest
         * @return GetAppVersionResponse
         */
        public GetAppVersionResponse GetAppVersion(GetAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAppVersionWithOptions(request, runtime);
        }

        /**
         * @summary 应用版本详情接口
         *
         * @param request GetAppVersionRequest
         * @return GetAppVersionResponse
         */
        public async Task<GetAppVersionResponse> GetAppVersionAsync(GetAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAppVersionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询 session 会话容量信息
         *
         * @param request GetCapacityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCapacityResponse
         */
        public GetCapacityResponse GetCapacityWithOptions(GetCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                body["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistrictId))
            {
                body["DistrictId"] = request.DistrictId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCapacity",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCapacityResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询 session 会话容量信息
         *
         * @param request GetCapacityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCapacityResponse
         */
        public async Task<GetCapacityResponse> GetCapacityWithOptionsAsync(GetCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                body["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistrictId))
            {
                body["DistrictId"] = request.DistrictId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCapacity",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCapacityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询 session 会话容量信息
         *
         * @param request GetCapacityRequest
         * @return GetCapacityResponse
         */
        public GetCapacityResponse GetCapacity(GetCapacityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCapacityWithOptions(request, runtime);
        }

        /**
         * @summary 查询 session 会话容量信息
         *
         * @param request GetCapacityRequest
         * @return GetCapacityResponse
         */
        public async Task<GetCapacityResponse> GetCapacityAsync(GetCapacityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCapacityWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询预定任务的详情信息
         *
         * @param request GetReserveTaskDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetReserveTaskDetailResponse
         */
        public GetReserveTaskDetailResponse GetReserveTaskDetailWithOptions(GetReserveTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetReserveTaskDetail",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReserveTaskDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询预定任务的详情信息
         *
         * @param request GetReserveTaskDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetReserveTaskDetailResponse
         */
        public async Task<GetReserveTaskDetailResponse> GetReserveTaskDetailWithOptionsAsync(GetReserveTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetReserveTaskDetail",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReserveTaskDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询预定任务的详情信息
         *
         * @param request GetReserveTaskDetailRequest
         * @return GetReserveTaskDetailResponse
         */
        public GetReserveTaskDetailResponse GetReserveTaskDetail(GetReserveTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetReserveTaskDetailWithOptions(request, runtime);
        }

        /**
         * @summary 查询预定任务的详情信息
         *
         * @param request GetReserveTaskDetailRequest
         * @return GetReserveTaskDetailResponse
         */
        public async Task<GetReserveTaskDetailResponse> GetReserveTaskDetailAsync(GetReserveTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetReserveTaskDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询公网ip
         *
         * @param request GetResourcePublicIPsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourcePublicIPsResponse
         */
        public GetResourcePublicIPsResponse GetResourcePublicIPsWithOptions(GetResourcePublicIPsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourcePublicIPs",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourcePublicIPsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询公网ip
         *
         * @param request GetResourcePublicIPsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourcePublicIPsResponse
         */
        public async Task<GetResourcePublicIPsResponse> GetResourcePublicIPsWithOptionsAsync(GetResourcePublicIPsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourcePublicIPs",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourcePublicIPsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询公网ip
         *
         * @param request GetResourcePublicIPsRequest
         * @return GetResourcePublicIPsResponse
         */
        public GetResourcePublicIPsResponse GetResourcePublicIPs(GetResourcePublicIPsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourcePublicIPsWithOptions(request, runtime);
        }

        /**
         * @summary 查询公网ip
         *
         * @param request GetResourcePublicIPsRequest
         * @return GetResourcePublicIPsResponse
         */
        public async Task<GetResourcePublicIPsResponse> GetResourcePublicIPsAsync(GetResourcePublicIPsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourcePublicIPsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 应用列表接口
         *
         * @param request ListAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAppResponse
         */
        public ListAppResponse ListAppWithOptions(ListAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySearch))
            {
                body["KeySearch"] = request.KeySearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApp",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 应用列表接口
         *
         * @param request ListAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAppResponse
         */
        public async Task<ListAppResponse> ListAppWithOptionsAsync(ListAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySearch))
            {
                body["KeySearch"] = request.KeySearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApp",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 应用列表接口
         *
         * @param request ListAppRequest
         * @return ListAppResponse
         */
        public ListAppResponse ListApp(ListAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppWithOptions(request, runtime);
        }

        /**
         * @summary 应用列表接口
         *
         * @param request ListAppRequest
         * @return ListAppResponse
         */
        public async Task<ListAppResponse> ListAppAsync(ListAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询App会话
         *
         * @param request ListAppSessionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAppSessionsResponse
         */
        public ListAppSessionsResponse ListAppSessionsWithOptions(ListAppSessionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomSessionIds))
            {
                query["CustomSessionIds"] = request.CustomSessionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformSessionIds))
            {
                query["PlatformSessionIds"] = request.PlatformSessionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppSessions",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppSessionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询App会话
         *
         * @param request ListAppSessionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAppSessionsResponse
         */
        public async Task<ListAppSessionsResponse> ListAppSessionsWithOptionsAsync(ListAppSessionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomSessionIds))
            {
                query["CustomSessionIds"] = request.CustomSessionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformSessionIds))
            {
                query["PlatformSessionIds"] = request.PlatformSessionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppSessions",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppSessionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询App会话
         *
         * @param request ListAppSessionsRequest
         * @return ListAppSessionsResponse
         */
        public ListAppSessionsResponse ListAppSessions(ListAppSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppSessionsWithOptions(request, runtime);
        }

        /**
         * @summary 查询App会话
         *
         * @param request ListAppSessionsRequest
         * @return ListAppSessionsResponse
         */
        public async Task<ListAppSessionsResponse> ListAppSessionsAsync(ListAppSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppSessionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 应用版本列表接口
         *
         * @param request ListAppVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAppVersionResponse
         */
        public ListAppVersionResponse ListAppVersionWithOptions(ListAppVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppVersion",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 应用版本列表接口
         *
         * @param request ListAppVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAppVersionResponse
         */
        public async Task<ListAppVersionResponse> ListAppVersionWithOptionsAsync(ListAppVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppVersion",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 应用版本列表接口
         *
         * @param request ListAppVersionRequest
         * @return ListAppVersionResponse
         */
        public ListAppVersionResponse ListAppVersion(ListAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppVersionWithOptions(request, runtime);
        }

        /**
         * @summary 应用版本列表接口
         *
         * @param request ListAppVersionRequest
         * @return ListAppVersionResponse
         */
        public async Task<ListAppVersionResponse> ListAppVersionAsync(ListAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppVersionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询GCS实例列表
         *
         * @param request ListInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstancesResponse
         */
        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询GCS实例列表
         *
         * @param request ListInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstancesResponse
         */
        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询GCS实例列表
         *
         * @param request ListInstancesRequest
         * @return ListInstancesResponse
         */
        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancesWithOptions(request, runtime);
        }

        /**
         * @summary 查询GCS实例列表
         *
         * @param request ListInstancesRequest
         * @return ListInstancesResponse
         */
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 应用修改服务
         *
         * @param request ModifyAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAppResponse
         */
        public ModifyAppResponse ModifyAppWithOptions(ModifyAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyApp",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 应用修改服务
         *
         * @param request ModifyAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAppResponse
         */
        public async Task<ModifyAppResponse> ModifyAppWithOptionsAsync(ModifyAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyApp",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 应用修改服务
         *
         * @param request ModifyAppRequest
         * @return ModifyAppResponse
         */
        public ModifyAppResponse ModifyApp(ModifyAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppWithOptions(request, runtime);
        }

        /**
         * @summary 应用修改服务
         *
         * @param request ModifyAppRequest
         * @return ModifyAppResponse
         */
        public async Task<ModifyAppResponse> ModifyAppAsync(ModifyAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 应用版本修改服务
         *
         * @param request ModifyAppVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAppVersionResponse
         */
        public ModifyAppVersionResponse ModifyAppVersionWithOptions(ModifyAppVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersionId))
            {
                body["AppVersionId"] = request.AppVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersionName))
            {
                body["AppVersionName"] = request.AppVersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppVersion",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 应用版本修改服务
         *
         * @param request ModifyAppVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyAppVersionResponse
         */
        public async Task<ModifyAppVersionResponse> ModifyAppVersionWithOptionsAsync(ModifyAppVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersionId))
            {
                body["AppVersionId"] = request.AppVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersionName))
            {
                body["AppVersionName"] = request.AppVersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppVersion",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 应用版本修改服务
         *
         * @param request ModifyAppVersionRequest
         * @return ModifyAppVersionResponse
         */
        public ModifyAppVersionResponse ModifyAppVersion(ModifyAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppVersionWithOptions(request, runtime);
        }

        /**
         * @summary 应用版本修改服务
         *
         * @param request ModifyAppVersionRequest
         * @return ModifyAppVersionResponse
         */
        public async Task<ModifyAppVersionResponse> ModifyAppVersionAsync(ModifyAppVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppVersionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 释放 session 资源预定的资源
         *
         * @param request ReleaseCapacityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseCapacityResponse
         */
        public ReleaseCapacityResponse ReleaseCapacityWithOptions(ReleaseCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                body["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistrictId))
            {
                body["DistrictId"] = request.DistrictId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectReleaseSessionCapacity))
            {
                body["ExpectReleaseSessionCapacity"] = request.ExpectReleaseSessionCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseCapacity",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseCapacityResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 释放 session 资源预定的资源
         *
         * @param request ReleaseCapacityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseCapacityResponse
         */
        public async Task<ReleaseCapacityResponse> ReleaseCapacityWithOptionsAsync(ReleaseCapacityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                body["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistrictId))
            {
                body["DistrictId"] = request.DistrictId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectReleaseSessionCapacity))
            {
                body["ExpectReleaseSessionCapacity"] = request.ExpectReleaseSessionCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseCapacity",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseCapacityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 释放 session 资源预定的资源
         *
         * @param request ReleaseCapacityRequest
         * @return ReleaseCapacityResponse
         */
        public ReleaseCapacityResponse ReleaseCapacity(ReleaseCapacityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseCapacityWithOptions(request, runtime);
        }

        /**
         * @summary 释放 session 资源预定的资源
         *
         * @param request ReleaseCapacityRequest
         * @return ReleaseCapacityResponse
         */
        public async Task<ReleaseCapacityResponse> ReleaseCapacityAsync(ReleaseCapacityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseCapacityWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据资源批次号释放 session 资源预定的资源
         *
         * @param request ReleaseCapacityByBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseCapacityByBatchResponse
         */
        public ReleaseCapacityByBatchResponse ReleaseCapacityByBatchWithOptions(ReleaseCapacityByBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResBatchId))
            {
                body["ResBatchId"] = request.ResBatchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseCapacityByBatch",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseCapacityByBatchResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 根据资源批次号释放 session 资源预定的资源
         *
         * @param request ReleaseCapacityByBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseCapacityByBatchResponse
         */
        public async Task<ReleaseCapacityByBatchResponse> ReleaseCapacityByBatchWithOptionsAsync(ReleaseCapacityByBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResBatchId))
            {
                body["ResBatchId"] = request.ResBatchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseCapacityByBatch",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseCapacityByBatchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 根据资源批次号释放 session 资源预定的资源
         *
         * @param request ReleaseCapacityByBatchRequest
         * @return ReleaseCapacityByBatchResponse
         */
        public ReleaseCapacityByBatchResponse ReleaseCapacityByBatch(ReleaseCapacityByBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseCapacityByBatchWithOptions(request, runtime);
        }

        /**
         * @summary 根据资源批次号释放 session 资源预定的资源
         *
         * @param request ReleaseCapacityByBatchRequest
         * @return ReleaseCapacityByBatchResponse
         */
        public async Task<ReleaseCapacityByBatchResponse> ReleaseCapacityByBatchAsync(ReleaseCapacityByBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseCapacityByBatchWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 退订GCS实例
         *
         * @param request ReleaseInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseInstancesResponse
         */
        public ReleaseInstancesResponse ReleaseInstancesWithOptions(ReleaseInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistrictId))
            {
                body["DistrictId"] = request.DistrictId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseInstances",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 退订GCS实例
         *
         * @param request ReleaseInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseInstancesResponse
         */
        public async Task<ReleaseInstancesResponse> ReleaseInstancesWithOptionsAsync(ReleaseInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistrictId))
            {
                body["DistrictId"] = request.DistrictId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseInstances",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 退订GCS实例
         *
         * @param request ReleaseInstancesRequest
         * @return ReleaseInstancesResponse
         */
        public ReleaseInstancesResponse ReleaseInstances(ReleaseInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseInstancesWithOptions(request, runtime);
        }

        /**
         * @summary 退订GCS实例
         *
         * @param request ReleaseInstancesRequest
         * @return ReleaseInstancesResponse
         */
        public async Task<ReleaseInstancesResponse> ReleaseInstancesAsync(ReleaseInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 预定GCS实例
         *
         * @param request ReserveInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReserveInstancesResponse
         */
        public ReserveInstancesResponse ReserveInstancesWithOptions(ReserveInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistrictId))
            {
                body["DistrictId"] = request.DistrictId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReserveInstances",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReserveInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 预定GCS实例
         *
         * @param request ReserveInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReserveInstancesResponse
         */
        public async Task<ReserveInstancesResponse> ReserveInstancesWithOptionsAsync(ReserveInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistrictId))
            {
                body["DistrictId"] = request.DistrictId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReserveInstances",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReserveInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 预定GCS实例
         *
         * @param request ReserveInstancesRequest
         * @return ReserveInstancesResponse
         */
        public ReserveInstancesResponse ReserveInstances(ReserveInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReserveInstancesWithOptions(request, runtime);
        }

        /**
         * @summary 预定GCS实例
         *
         * @param request ReserveInstancesRequest
         * @return ReserveInstancesResponse
         */
        public async Task<ReserveInstancesResponse> ReserveInstancesAsync(ReserveInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReserveInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 发送业务能力变更结果回调
         *
         * @param request SendBizCocChangeCallbackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendBizCocChangeCallbackResponse
         */
        public SendBizCocChangeCallbackResponse SendBizCocChangeCallbackWithOptions(SendBizCocChangeCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformSessionId))
            {
                query["PlatformSessionId"] = request.PlatformSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Result))
            {
                query["Result"] = request.Result;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendBizCocChangeCallback",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendBizCocChangeCallbackResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 发送业务能力变更结果回调
         *
         * @param request SendBizCocChangeCallbackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendBizCocChangeCallbackResponse
         */
        public async Task<SendBizCocChangeCallbackResponse> SendBizCocChangeCallbackWithOptionsAsync(SendBizCocChangeCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformSessionId))
            {
                query["PlatformSessionId"] = request.PlatformSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Result))
            {
                query["Result"] = request.Result;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendBizCocChangeCallback",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendBizCocChangeCallbackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 发送业务能力变更结果回调
         *
         * @param request SendBizCocChangeCallbackRequest
         * @return SendBizCocChangeCallbackResponse
         */
        public SendBizCocChangeCallbackResponse SendBizCocChangeCallback(SendBizCocChangeCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendBizCocChangeCallbackWithOptions(request, runtime);
        }

        /**
         * @summary 发送业务能力变更结果回调
         *
         * @param request SendBizCocChangeCallbackRequest
         * @return SendBizCocChangeCallbackResponse
         */
        public async Task<SendBizCocChangeCallbackResponse> SendBizCocChangeCallbackAsync(SendBizCocChangeCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendBizCocChangeCallbackWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 停止App会话
         *
         * @param tmpReq StopAppSessionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopAppSessionResponse
         */
        public StopAppSessionResponse StopAppSessionWithOptions(StopAppSessionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StopAppSessionShrinkRequest request = new StopAppSessionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StopParam))
            {
                request.StopParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StopParam, "StopParam", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomSessionId))
            {
                query["CustomSessionId"] = request.CustomSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformSessionId))
            {
                query["PlatformSessionId"] = request.PlatformSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopParamShrink))
            {
                query["StopParam"] = request.StopParamShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopAppSession",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopAppSessionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 停止App会话
         *
         * @param tmpReq StopAppSessionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopAppSessionResponse
         */
        public async Task<StopAppSessionResponse> StopAppSessionWithOptionsAsync(StopAppSessionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StopAppSessionShrinkRequest request = new StopAppSessionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StopParam))
            {
                request.StopParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StopParam, "StopParam", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomSessionId))
            {
                query["CustomSessionId"] = request.CustomSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformSessionId))
            {
                query["PlatformSessionId"] = request.PlatformSessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopParamShrink))
            {
                query["StopParam"] = request.StopParamShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopAppSession",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopAppSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 停止App会话
         *
         * @param request StopAppSessionRequest
         * @return StopAppSessionResponse
         */
        public StopAppSessionResponse StopAppSession(StopAppSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopAppSessionWithOptions(request, runtime);
        }

        /**
         * @summary 停止App会话
         *
         * @param request StopAppSessionRequest
         * @return StopAppSessionResponse
         */
        public async Task<StopAppSessionResponse> StopAppSessionAsync(StopAppSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopAppSessionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量停止会话接口
         *
         * @param tmpReq StopAppSessionBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopAppSessionBatchResponse
         */
        public StopAppSessionBatchResponse StopAppSessionBatchWithOptions(StopAppSessionBatchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StopAppSessionBatchShrinkRequest request = new StopAppSessionBatchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StopParam))
            {
                request.StopParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StopParam, "StopParam", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                query["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["BatchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopParamShrink))
            {
                query["StopParam"] = request.StopParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopAppSessionBatch",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopAppSessionBatchResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量停止会话接口
         *
         * @param tmpReq StopAppSessionBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopAppSessionBatchResponse
         */
        public async Task<StopAppSessionBatchResponse> StopAppSessionBatchWithOptionsAsync(StopAppSessionBatchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StopAppSessionBatchShrinkRequest request = new StopAppSessionBatchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StopParam))
            {
                request.StopParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StopParam, "StopParam", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                query["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchId))
            {
                query["BatchId"] = request.BatchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopParamShrink))
            {
                query["StopParam"] = request.StopParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopAppSessionBatch",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopAppSessionBatchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量停止会话接口
         *
         * @param request StopAppSessionBatchRequest
         * @return StopAppSessionBatchResponse
         */
        public StopAppSessionBatchResponse StopAppSessionBatch(StopAppSessionBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopAppSessionBatchWithOptions(request, runtime);
        }

        /**
         * @summary 批量停止会话接口
         *
         * @param request StopAppSessionBatchRequest
         * @return StopAppSessionBatchResponse
         */
        public async Task<StopAppSessionBatchResponse> StopAppSessionBatchAsync(StopAppSessionBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopAppSessionBatchWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新会话状态
         *
         * @param request UpdateSessionBizStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSessionBizStatusResponse
         */
        public UpdateSessionBizStatusResponse UpdateSessionBizStatusWithOptions(UpdateSessionBizStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizStatus))
            {
                query["BizStatus"] = request.BizStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformSessionId))
            {
                query["PlatformSessionId"] = request.PlatformSessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSessionBizStatus",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSessionBizStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新会话状态
         *
         * @param request UpdateSessionBizStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSessionBizStatusResponse
         */
        public async Task<UpdateSessionBizStatusResponse> UpdateSessionBizStatusWithOptionsAsync(UpdateSessionBizStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizStatus))
            {
                query["BizStatus"] = request.BizStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformSessionId))
            {
                query["PlatformSessionId"] = request.PlatformSessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSessionBizStatus",
                Version = "2021-11-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSessionBizStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新会话状态
         *
         * @param request UpdateSessionBizStatusRequest
         * @return UpdateSessionBizStatusResponse
         */
        public UpdateSessionBizStatusResponse UpdateSessionBizStatus(UpdateSessionBizStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSessionBizStatusWithOptions(request, runtime);
        }

        /**
         * @summary 更新会话状态
         *
         * @param request UpdateSessionBizStatusRequest
         * @return UpdateSessionBizStatusResponse
         */
        public async Task<UpdateSessionBizStatusResponse> UpdateSessionBizStatusAsync(UpdateSessionBizStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSessionBizStatusWithOptionsAsync(request, runtime);
        }

    }
}
