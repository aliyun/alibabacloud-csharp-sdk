// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.PaiRecService20221213.Models;

namespace AlibabaCloud.SDK.PaiRecService20221213
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("pairecservice", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>应用/发布指定的推荐引擎配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyEngineConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyEngineConfigResponse
        /// </returns>
        public ApplyEngineConfigResponse ApplyEngineConfigWithOptions(string EngineConfigId, ApplyEngineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyEngineConfig",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/engineconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(EngineConfigId) + "/action/apply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyEngineConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>应用/发布指定的推荐引擎配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyEngineConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyEngineConfigResponse
        /// </returns>
        public async Task<ApplyEngineConfigResponse> ApplyEngineConfigWithOptionsAsync(string EngineConfigId, ApplyEngineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyEngineConfig",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/engineconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(EngineConfigId) + "/action/apply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyEngineConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>应用/发布指定的推荐引擎配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyEngineConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyEngineConfigResponse
        /// </returns>
        public ApplyEngineConfigResponse ApplyEngineConfig(string EngineConfigId, ApplyEngineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ApplyEngineConfigWithOptions(EngineConfigId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>应用/发布指定的推荐引擎配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyEngineConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyEngineConfigResponse
        /// </returns>
        public async Task<ApplyEngineConfigResponse> ApplyEngineConfigAsync(string EngineConfigId, ApplyEngineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ApplyEngineConfigWithOptionsAsync(EngineConfigId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>特征一致性检查数据回流。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BackflowFeatureConsistencyCheckJobDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BackflowFeatureConsistencyCheckJobDataResponse
        /// </returns>
        public BackflowFeatureConsistencyCheckJobDataResponse BackflowFeatureConsistencyCheckJobDataWithOptions(BackflowFeatureConsistencyCheckJobDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureConsistencyCheckJobConfigId))
            {
                body["FeatureConsistencyCheckJobConfigId"] = request.FeatureConsistencyCheckJobConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemFeatures))
            {
                body["ItemFeatures"] = request.ItemFeatures;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogItemId))
            {
                body["LogItemId"] = request.LogItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRequestId))
            {
                body["LogRequestId"] = request.LogRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRequestTime))
            {
                body["LogRequestTime"] = request.LogRequestTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                body["LogUserId"] = request.LogUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneName))
            {
                body["SceneName"] = request.SceneName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scores))
            {
                body["Scores"] = request.Scores;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFeatures))
            {
                body["UserFeatures"] = request.UserFeatures;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BackflowFeatureConsistencyCheckJobData",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobs/action/backflowdata",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BackflowFeatureConsistencyCheckJobDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>特征一致性检查数据回流。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BackflowFeatureConsistencyCheckJobDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BackflowFeatureConsistencyCheckJobDataResponse
        /// </returns>
        public async Task<BackflowFeatureConsistencyCheckJobDataResponse> BackflowFeatureConsistencyCheckJobDataWithOptionsAsync(BackflowFeatureConsistencyCheckJobDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureConsistencyCheckJobConfigId))
            {
                body["FeatureConsistencyCheckJobConfigId"] = request.FeatureConsistencyCheckJobConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemFeatures))
            {
                body["ItemFeatures"] = request.ItemFeatures;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogItemId))
            {
                body["LogItemId"] = request.LogItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRequestId))
            {
                body["LogRequestId"] = request.LogRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRequestTime))
            {
                body["LogRequestTime"] = request.LogRequestTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                body["LogUserId"] = request.LogUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneName))
            {
                body["SceneName"] = request.SceneName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scores))
            {
                body["Scores"] = request.Scores;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFeatures))
            {
                body["UserFeatures"] = request.UserFeatures;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BackflowFeatureConsistencyCheckJobData",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobs/action/backflowdata",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BackflowFeatureConsistencyCheckJobDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>特征一致性检查数据回流。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BackflowFeatureConsistencyCheckJobDataRequest
        /// </param>
        /// 
        /// <returns>
        /// BackflowFeatureConsistencyCheckJobDataResponse
        /// </returns>
        public BackflowFeatureConsistencyCheckJobDataResponse BackflowFeatureConsistencyCheckJobData(BackflowFeatureConsistencyCheckJobDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BackflowFeatureConsistencyCheckJobDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>特征一致性检查数据回流。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BackflowFeatureConsistencyCheckJobDataRequest
        /// </param>
        /// 
        /// <returns>
        /// BackflowFeatureConsistencyCheckJobDataResponse
        /// </returns>
        public async Task<BackflowFeatureConsistencyCheckJobDataResponse> BackflowFeatureConsistencyCheckJobDataAsync(BackflowFeatureConsistencyCheckJobDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BackflowFeatureConsistencyCheckJobDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检测实例下配置的资源的连接状态。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckInstanceResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckInstanceResourcesResponse
        /// </returns>
        public CheckInstanceResourcesResponse CheckInstanceResourcesWithOptions(string InstanceId, CheckInstanceResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckInstanceResources",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/action/checkresources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckInstanceResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检测实例下配置的资源的连接状态。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckInstanceResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckInstanceResourcesResponse
        /// </returns>
        public async Task<CheckInstanceResourcesResponse> CheckInstanceResourcesWithOptionsAsync(string InstanceId, CheckInstanceResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckInstanceResources",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/action/checkresources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckInstanceResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检测实例下配置的资源的连接状态。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckInstanceResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckInstanceResourcesResponse
        /// </returns>
        public CheckInstanceResourcesResponse CheckInstanceResources(string InstanceId, CheckInstanceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CheckInstanceResourcesWithOptions(InstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>检测实例下配置的资源的连接状态。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckInstanceResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckInstanceResourcesResponse
        /// </returns>
        public async Task<CheckInstanceResourcesResponse> CheckInstanceResourcesAsync(string InstanceId, CheckInstanceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CheckInstanceResourcesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆指定的推荐引擎配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneEngineConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneEngineConfigResponse
        /// </returns>
        public CloneEngineConfigResponse CloneEngineConfigWithOptions(string EngineConfigId, CloneEngineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigValue))
            {
                body["ConfigValue"] = request.ConfigValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneEngineConfig",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/engineconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(EngineConfigId) + "/action/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneEngineConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆指定的推荐引擎配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneEngineConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneEngineConfigResponse
        /// </returns>
        public async Task<CloneEngineConfigResponse> CloneEngineConfigWithOptionsAsync(string EngineConfigId, CloneEngineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigValue))
            {
                body["ConfigValue"] = request.ConfigValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneEngineConfig",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/engineconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(EngineConfigId) + "/action/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneEngineConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆指定的推荐引擎配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneEngineConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CloneEngineConfigResponse
        /// </returns>
        public CloneEngineConfigResponse CloneEngineConfig(string EngineConfigId, CloneEngineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneEngineConfigWithOptions(EngineConfigId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆指定的推荐引擎配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneEngineConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CloneEngineConfigResponse
        /// </returns>
        public async Task<CloneEngineConfigResponse> CloneEngineConfigAsync(string EngineConfigId, CloneEngineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneEngineConfigWithOptionsAsync(EngineConfigId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆实验。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneExperimentResponse
        /// </returns>
        public CloneExperimentResponse CloneExperimentWithOptions(string ExperimentId, CloneExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneExperiment",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/action/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆实验。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneExperimentResponse
        /// </returns>
        public async Task<CloneExperimentResponse> CloneExperimentWithOptionsAsync(string ExperimentId, CloneExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneExperiment",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/action/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆实验。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// CloneExperimentResponse
        /// </returns>
        public CloneExperimentResponse CloneExperiment(string ExperimentId, CloneExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆实验。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// CloneExperimentResponse
        /// </returns>
        public async Task<CloneExperimentResponse> CloneExperimentAsync(string ExperimentId, CloneExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆实验组，并克隆实验组下的所有实验至新的实验组中。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneExperimentGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneExperimentGroupResponse
        /// </returns>
        public CloneExperimentGroupResponse CloneExperimentGroupWithOptions(string ExperimentGroupId, CloneExperimentGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayerId))
            {
                body["LayerId"] = request.LayerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneExperimentGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentGroupId) + "/action/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneExperimentGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆实验组，并克隆实验组下的所有实验至新的实验组中。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneExperimentGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneExperimentGroupResponse
        /// </returns>
        public async Task<CloneExperimentGroupResponse> CloneExperimentGroupWithOptionsAsync(string ExperimentGroupId, CloneExperimentGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayerId))
            {
                body["LayerId"] = request.LayerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneExperimentGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentGroupId) + "/action/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneExperimentGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆实验组，并克隆实验组下的所有实验至新的实验组中。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneExperimentGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CloneExperimentGroupResponse
        /// </returns>
        public CloneExperimentGroupResponse CloneExperimentGroup(string ExperimentGroupId, CloneExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneExperimentGroupWithOptions(ExperimentGroupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆实验组，并克隆实验组下的所有实验至新的实验组中。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneExperimentGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CloneExperimentGroupResponse
        /// </returns>
        public async Task<CloneExperimentGroupResponse> CloneExperimentGroupAsync(string ExperimentGroupId, CloneExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneExperimentGroupWithOptionsAsync(ExperimentGroupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆特征一致性检查配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneFeatureConsistencyCheckJobConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneFeatureConsistencyCheckJobConfigResponse
        /// </returns>
        public CloneFeatureConsistencyCheckJobConfigResponse CloneFeatureConsistencyCheckJobConfigWithOptions(string SourceFeatureConsistencyCheckJobConfigId, CloneFeatureConsistencyCheckJobConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneFeatureConsistencyCheckJobConfig",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SourceFeatureConsistencyCheckJobConfigId) + "/action/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneFeatureConsistencyCheckJobConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆特征一致性检查配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneFeatureConsistencyCheckJobConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneFeatureConsistencyCheckJobConfigResponse
        /// </returns>
        public async Task<CloneFeatureConsistencyCheckJobConfigResponse> CloneFeatureConsistencyCheckJobConfigWithOptionsAsync(string SourceFeatureConsistencyCheckJobConfigId, CloneFeatureConsistencyCheckJobConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneFeatureConsistencyCheckJobConfig",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SourceFeatureConsistencyCheckJobConfigId) + "/action/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneFeatureConsistencyCheckJobConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆特征一致性检查配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneFeatureConsistencyCheckJobConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CloneFeatureConsistencyCheckJobConfigResponse
        /// </returns>
        public CloneFeatureConsistencyCheckJobConfigResponse CloneFeatureConsistencyCheckJobConfig(string SourceFeatureConsistencyCheckJobConfigId, CloneFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneFeatureConsistencyCheckJobConfigWithOptions(SourceFeatureConsistencyCheckJobConfigId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆特征一致性检查配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneFeatureConsistencyCheckJobConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CloneFeatureConsistencyCheckJobConfigResponse
        /// </returns>
        public async Task<CloneFeatureConsistencyCheckJobConfigResponse> CloneFeatureConsistencyCheckJobConfigAsync(string SourceFeatureConsistencyCheckJobConfigId, CloneFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneFeatureConsistencyCheckJobConfigWithOptionsAsync(SourceFeatureConsistencyCheckJobConfigId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆实验室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneLaboratoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneLaboratoryResponse
        /// </returns>
        public CloneLaboratoryResponse CloneLaboratoryWithOptions(string LaboratoryId, CloneLaboratoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloneExperimentGroup))
            {
                body["CloneExperimentGroup"] = request.CloneExperimentGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneLaboratory",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/laboratories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LaboratoryId) + "/action/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneLaboratoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆实验室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneLaboratoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneLaboratoryResponse
        /// </returns>
        public async Task<CloneLaboratoryResponse> CloneLaboratoryWithOptionsAsync(string LaboratoryId, CloneLaboratoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloneExperimentGroup))
            {
                body["CloneExperimentGroup"] = request.CloneExperimentGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneLaboratory",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/laboratories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LaboratoryId) + "/action/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneLaboratoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆实验室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneLaboratoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CloneLaboratoryResponse
        /// </returns>
        public CloneLaboratoryResponse CloneLaboratory(string LaboratoryId, CloneLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneLaboratoryWithOptions(LaboratoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆实验室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneLaboratoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CloneLaboratoryResponse
        /// </returns>
        public async Task<CloneLaboratoryResponse> CloneLaboratoryAsync(string LaboratoryId, CloneLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneLaboratoryWithOptionsAsync(LaboratoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneTrafficControlTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneTrafficControlTaskResponse
        /// </returns>
        public CloneTrafficControlTaskResponse CloneTrafficControlTaskWithOptions(string TrafficControlTaskId, CloneTrafficControlTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneTrafficControlTask",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId) + "/action/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneTrafficControlTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneTrafficControlTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneTrafficControlTaskResponse
        /// </returns>
        public async Task<CloneTrafficControlTaskResponse> CloneTrafficControlTaskWithOptionsAsync(string TrafficControlTaskId, CloneTrafficControlTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneTrafficControlTask",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId) + "/action/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneTrafficControlTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneTrafficControlTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CloneTrafficControlTaskResponse
        /// </returns>
        public CloneTrafficControlTaskResponse CloneTrafficControlTask(string TrafficControlTaskId, CloneTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneTrafficControlTaskWithOptions(TrafficControlTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneTrafficControlTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CloneTrafficControlTaskResponse
        /// </returns>
        public async Task<CloneTrafficControlTaskResponse> CloneTrafficControlTaskAsync(string TrafficControlTaskId, CloneTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneTrafficControlTaskWithOptionsAsync(TrafficControlTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建AB test实验指标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateABMetricRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateABMetricResponse
        /// </returns>
        public CreateABMetricResponse CreateABMetricWithOptions(CreateABMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                body["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeftMetricId))
            {
                body["LeftMetricId"] = request.LeftMetricId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["Operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Realtime))
            {
                body["Realtime"] = request.Realtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultResourceId))
            {
                body["ResultResourceId"] = request.ResultResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightMetricId))
            {
                body["RightMetricId"] = request.RightMetricId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisticsCycle))
            {
                body["StatisticsCycle"] = request.StatisticsCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableMetaId))
            {
                body["TableMetaId"] = request.TableMetaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateABMetric",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/abmetrics",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateABMetricResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建AB test实验指标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateABMetricRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateABMetricResponse
        /// </returns>
        public async Task<CreateABMetricResponse> CreateABMetricWithOptionsAsync(CreateABMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                body["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeftMetricId))
            {
                body["LeftMetricId"] = request.LeftMetricId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["Operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Realtime))
            {
                body["Realtime"] = request.Realtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultResourceId))
            {
                body["ResultResourceId"] = request.ResultResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightMetricId))
            {
                body["RightMetricId"] = request.RightMetricId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisticsCycle))
            {
                body["StatisticsCycle"] = request.StatisticsCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableMetaId))
            {
                body["TableMetaId"] = request.TableMetaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateABMetric",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/abmetrics",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateABMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建AB test实验指标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateABMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateABMetricResponse
        /// </returns>
        public CreateABMetricResponse CreateABMetric(CreateABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateABMetricWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建AB test实验指标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateABMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateABMetricResponse
        /// </returns>
        public async Task<CreateABMetricResponse> CreateABMetricAsync(CreateABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateABMetricWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建指标组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateABMetricGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateABMetricGroupResponse
        /// </returns>
        public CreateABMetricGroupResponse CreateABMetricGroupWithOptions(CreateABMetricGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ABMetricIds))
            {
                body["ABMetricIds"] = request.ABMetricIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Realtime))
            {
                body["Realtime"] = request.Realtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateABMetricGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/abmetricgroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateABMetricGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建指标组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateABMetricGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateABMetricGroupResponse
        /// </returns>
        public async Task<CreateABMetricGroupResponse> CreateABMetricGroupWithOptionsAsync(CreateABMetricGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ABMetricIds))
            {
                body["ABMetricIds"] = request.ABMetricIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Realtime))
            {
                body["Realtime"] = request.Realtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateABMetricGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/abmetricgroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateABMetricGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建指标组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateABMetricGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateABMetricGroupResponse
        /// </returns>
        public CreateABMetricGroupResponse CreateABMetricGroup(CreateABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateABMetricGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建指标组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateABMetricGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateABMetricGroupResponse
        /// </returns>
        public async Task<CreateABMetricGroupResponse> CreateABMetricGroupAsync(CreateABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateABMetricGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建AB指标的计算任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCalculationJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCalculationJobsResponse
        /// </returns>
        public CreateCalculationJobsResponse CreateCalculationJobsWithOptions(CreateCalculationJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ABMetricIds))
            {
                body["ABMetricIds"] = request.ABMetricIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCalculationJobs",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/batch/calculationjobs/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCalculationJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建AB指标的计算任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCalculationJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCalculationJobsResponse
        /// </returns>
        public async Task<CreateCalculationJobsResponse> CreateCalculationJobsWithOptionsAsync(CreateCalculationJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ABMetricIds))
            {
                body["ABMetricIds"] = request.ABMetricIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCalculationJobs",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/batch/calculationjobs/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCalculationJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建AB指标的计算任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCalculationJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCalculationJobsResponse
        /// </returns>
        public CreateCalculationJobsResponse CreateCalculationJobs(CreateCalculationJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCalculationJobsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建AB指标的计算任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCalculationJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCalculationJobsResponse
        /// </returns>
        public async Task<CreateCalculationJobsResponse> CreateCalculationJobsAsync(CreateCalculationJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCalculationJobsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCrowdRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCrowdResponse
        /// </returns>
        public CreateCrowdResponse CreateCrowdWithOptions(CreateCrowdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCrowd",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCrowdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCrowdRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCrowdResponse
        /// </returns>
        public async Task<CreateCrowdResponse> CreateCrowdWithOptionsAsync(CreateCrowdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCrowd",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCrowdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCrowdRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCrowdResponse
        /// </returns>
        public CreateCrowdResponse CreateCrowd(CreateCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCrowdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCrowdRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCrowdResponse
        /// </returns>
        public async Task<CreateCrowdResponse> CreateCrowdAsync(CreateCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCrowdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建引擎配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEngineConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEngineConfigResponse
        /// </returns>
        public CreateEngineConfigResponse CreateEngineConfigWithOptions(CreateEngineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigValue))
            {
                body["ConfigValue"] = request.ConfigValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEngineConfig",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/engineconfigs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEngineConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建引擎配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEngineConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEngineConfigResponse
        /// </returns>
        public async Task<CreateEngineConfigResponse> CreateEngineConfigWithOptionsAsync(CreateEngineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigValue))
            {
                body["ConfigValue"] = request.ConfigValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEngineConfig",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/engineconfigs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEngineConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建引擎配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEngineConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEngineConfigResponse
        /// </returns>
        public CreateEngineConfigResponse CreateEngineConfig(CreateEngineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateEngineConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建引擎配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEngineConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEngineConfigResponse
        /// </returns>
        public async Task<CreateEngineConfigResponse> CreateEngineConfigAsync(CreateEngineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateEngineConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实验。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentResponse
        /// </returns>
        public CreateExperimentResponse CreateExperimentWithOptions(CreateExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugCrowdId))
            {
                body["DebugCrowdId"] = request.DebugCrowdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentGroupId))
            {
                body["ExperimentGroupId"] = request.ExperimentGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowPercent))
            {
                body["FlowPercent"] = request.FlowPercent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExperiment",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实验。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentResponse
        /// </returns>
        public async Task<CreateExperimentResponse> CreateExperimentWithOptionsAsync(CreateExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugCrowdId))
            {
                body["DebugCrowdId"] = request.DebugCrowdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentGroupId))
            {
                body["ExperimentGroupId"] = request.ExperimentGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowPercent))
            {
                body["FlowPercent"] = request.FlowPercent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExperiment",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实验。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentResponse
        /// </returns>
        public CreateExperimentResponse CreateExperiment(CreateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateExperimentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实验。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentResponse
        /// </returns>
        public async Task<CreateExperimentResponse> CreateExperimentAsync(CreateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateExperimentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实验组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentGroupResponse
        /// </returns>
        public CreateExperimentGroupResponse CreateExperimentGroupWithOptions(CreateExperimentGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdId))
            {
                body["CrowdId"] = request.CrowdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdTargetType))
            {
                body["CrowdTargetType"] = request.CrowdTargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugCrowdId))
            {
                body["DebugCrowdId"] = request.DebugCrowdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionTimeDuration))
            {
                body["DistributionTimeDuration"] = request.DistributionTimeDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionType))
            {
                body["DistributionType"] = request.DistributionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                body["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayerId))
            {
                body["LayerId"] = request.LayerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedAA))
            {
                body["NeedAA"] = request.NeedAA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RandomFlow))
            {
                body["RandomFlow"] = request.RandomFlow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedBuckets))
            {
                body["ReservedBuckets"] = request.ReservedBuckets;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExperimentGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentgroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExperimentGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实验组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentGroupResponse
        /// </returns>
        public async Task<CreateExperimentGroupResponse> CreateExperimentGroupWithOptionsAsync(CreateExperimentGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdId))
            {
                body["CrowdId"] = request.CrowdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdTargetType))
            {
                body["CrowdTargetType"] = request.CrowdTargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugCrowdId))
            {
                body["DebugCrowdId"] = request.DebugCrowdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionTimeDuration))
            {
                body["DistributionTimeDuration"] = request.DistributionTimeDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionType))
            {
                body["DistributionType"] = request.DistributionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                body["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayerId))
            {
                body["LayerId"] = request.LayerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedAA))
            {
                body["NeedAA"] = request.NeedAA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RandomFlow))
            {
                body["RandomFlow"] = request.RandomFlow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedBuckets))
            {
                body["ReservedBuckets"] = request.ReservedBuckets;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExperimentGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentgroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExperimentGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实验组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentGroupResponse
        /// </returns>
        public CreateExperimentGroupResponse CreateExperimentGroup(CreateExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateExperimentGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实验组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentGroupResponse
        /// </returns>
        public async Task<CreateExperimentGroupResponse> CreateExperimentGroupAsync(CreateExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateExperimentGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建特征一致性检查任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFeatureConsistencyCheckJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFeatureConsistencyCheckJobResponse
        /// </returns>
        public CreateFeatureConsistencyCheckJobResponse CreateFeatureConsistencyCheckJobWithOptions(CreateFeatureConsistencyCheckJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureConsistencyCheckJobConfigId))
            {
                body["FeatureConsistencyCheckJobConfigId"] = request.FeatureConsistencyCheckJobConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingDuration))
            {
                body["SamplingDuration"] = request.SamplingDuration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFeatureConsistencyCheckJob",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFeatureConsistencyCheckJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建特征一致性检查任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFeatureConsistencyCheckJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFeatureConsistencyCheckJobResponse
        /// </returns>
        public async Task<CreateFeatureConsistencyCheckJobResponse> CreateFeatureConsistencyCheckJobWithOptionsAsync(CreateFeatureConsistencyCheckJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureConsistencyCheckJobConfigId))
            {
                body["FeatureConsistencyCheckJobConfigId"] = request.FeatureConsistencyCheckJobConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingDuration))
            {
                body["SamplingDuration"] = request.SamplingDuration;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFeatureConsistencyCheckJob",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFeatureConsistencyCheckJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建特征一致性检查任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFeatureConsistencyCheckJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFeatureConsistencyCheckJobResponse
        /// </returns>
        public CreateFeatureConsistencyCheckJobResponse CreateFeatureConsistencyCheckJob(CreateFeatureConsistencyCheckJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFeatureConsistencyCheckJobWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建特征一致性检查任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFeatureConsistencyCheckJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFeatureConsistencyCheckJobResponse
        /// </returns>
        public async Task<CreateFeatureConsistencyCheckJobResponse> CreateFeatureConsistencyCheckJobAsync(CreateFeatureConsistencyCheckJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFeatureConsistencyCheckJobWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建特征一致性检查配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFeatureConsistencyCheckJobConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFeatureConsistencyCheckJobConfigResponse
        /// </returns>
        public CreateFeatureConsistencyCheckJobConfigResponse CreateFeatureConsistencyCheckJobConfigWithOptions(CreateFeatureConsistencyCheckJobConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompareFeature))
            {
                body["CompareFeature"] = request.CompareFeature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EasServiceName))
            {
                body["EasServiceName"] = request.EasServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EasyRecPackagePath))
            {
                body["EasyRecPackagePath"] = request.EasyRecPackagePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EasyRecVersion))
            {
                body["EasyRecVersion"] = request.EasyRecVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureDisplayExclude))
            {
                body["FeatureDisplayExclude"] = request.FeatureDisplayExclude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureLandingResourceId))
            {
                body["FeatureLandingResourceId"] = request.FeatureLandingResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeaturePriority))
            {
                body["FeaturePriority"] = request.FeaturePriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreItemId))
            {
                body["FeatureStoreItemId"] = request.FeatureStoreItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreModelId))
            {
                body["FeatureStoreModelId"] = request.FeatureStoreModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreProjectId))
            {
                body["FeatureStoreProjectId"] = request.FeatureStoreProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreProjectName))
            {
                body["FeatureStoreProjectName"] = request.FeatureStoreProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreSeqFeatureView))
            {
                body["FeatureStoreSeqFeatureView"] = request.FeatureStoreSeqFeatureView;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreUserId))
            {
                body["FeatureStoreUserId"] = request.FeatureStoreUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FgJarVersion))
            {
                body["FgJarVersion"] = request.FgJarVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FgJsonFileName))
            {
                body["FgJsonFileName"] = request.FgJsonFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateZip))
            {
                body["GenerateZip"] = request.GenerateZip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemIdField))
            {
                body["ItemIdField"] = request.ItemIdField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTable))
            {
                body["ItemTable"] = request.ItemTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTablePartitionField))
            {
                body["ItemTablePartitionField"] = request.ItemTablePartitionField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTablePartitionFieldFormat))
            {
                body["ItemTablePartitionFieldFormat"] = request.ItemTablePartitionFieldFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssResourceId))
            {
                body["OssResourceId"] = request.OssResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SampleRate))
            {
                body["SampleRate"] = request.SampleRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseFeatureStore))
            {
                body["UseFeatureStore"] = request.UseFeatureStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdField))
            {
                body["UserIdField"] = request.UserIdField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTable))
            {
                body["UserTable"] = request.UserTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTablePartitionField))
            {
                body["UserTablePartitionField"] = request.UserTablePartitionField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTablePartitionFieldFormat))
            {
                body["UserTablePartitionFieldFormat"] = request.UserTablePartitionFieldFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowName))
            {
                body["WorkflowName"] = request.WorkflowName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFeatureConsistencyCheckJobConfig",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobconfigs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFeatureConsistencyCheckJobConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建特征一致性检查配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFeatureConsistencyCheckJobConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFeatureConsistencyCheckJobConfigResponse
        /// </returns>
        public async Task<CreateFeatureConsistencyCheckJobConfigResponse> CreateFeatureConsistencyCheckJobConfigWithOptionsAsync(CreateFeatureConsistencyCheckJobConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompareFeature))
            {
                body["CompareFeature"] = request.CompareFeature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EasServiceName))
            {
                body["EasServiceName"] = request.EasServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EasyRecPackagePath))
            {
                body["EasyRecPackagePath"] = request.EasyRecPackagePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EasyRecVersion))
            {
                body["EasyRecVersion"] = request.EasyRecVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureDisplayExclude))
            {
                body["FeatureDisplayExclude"] = request.FeatureDisplayExclude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureLandingResourceId))
            {
                body["FeatureLandingResourceId"] = request.FeatureLandingResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeaturePriority))
            {
                body["FeaturePriority"] = request.FeaturePriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreItemId))
            {
                body["FeatureStoreItemId"] = request.FeatureStoreItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreModelId))
            {
                body["FeatureStoreModelId"] = request.FeatureStoreModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreProjectId))
            {
                body["FeatureStoreProjectId"] = request.FeatureStoreProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreProjectName))
            {
                body["FeatureStoreProjectName"] = request.FeatureStoreProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreSeqFeatureView))
            {
                body["FeatureStoreSeqFeatureView"] = request.FeatureStoreSeqFeatureView;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreUserId))
            {
                body["FeatureStoreUserId"] = request.FeatureStoreUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FgJarVersion))
            {
                body["FgJarVersion"] = request.FgJarVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FgJsonFileName))
            {
                body["FgJsonFileName"] = request.FgJsonFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateZip))
            {
                body["GenerateZip"] = request.GenerateZip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemIdField))
            {
                body["ItemIdField"] = request.ItemIdField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTable))
            {
                body["ItemTable"] = request.ItemTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTablePartitionField))
            {
                body["ItemTablePartitionField"] = request.ItemTablePartitionField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTablePartitionFieldFormat))
            {
                body["ItemTablePartitionFieldFormat"] = request.ItemTablePartitionFieldFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssResourceId))
            {
                body["OssResourceId"] = request.OssResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SampleRate))
            {
                body["SampleRate"] = request.SampleRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseFeatureStore))
            {
                body["UseFeatureStore"] = request.UseFeatureStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdField))
            {
                body["UserIdField"] = request.UserIdField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTable))
            {
                body["UserTable"] = request.UserTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTablePartitionField))
            {
                body["UserTablePartitionField"] = request.UserTablePartitionField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTablePartitionFieldFormat))
            {
                body["UserTablePartitionFieldFormat"] = request.UserTablePartitionFieldFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowName))
            {
                body["WorkflowName"] = request.WorkflowName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFeatureConsistencyCheckJobConfig",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobconfigs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFeatureConsistencyCheckJobConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建特征一致性检查配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFeatureConsistencyCheckJobConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFeatureConsistencyCheckJobConfigResponse
        /// </returns>
        public CreateFeatureConsistencyCheckJobConfigResponse CreateFeatureConsistencyCheckJobConfig(CreateFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFeatureConsistencyCheckJobConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建特征一致性检查配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFeatureConsistencyCheckJobConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFeatureConsistencyCheckJobConfigResponse
        /// </returns>
        public async Task<CreateFeatureConsistencyCheckJobConfigResponse> CreateFeatureConsistencyCheckJobConfigAsync(CreateFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFeatureConsistencyCheckJobConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为指定实例配置创建新的配置资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResourceResponse
        /// </returns>
        public CreateInstanceResourceResponse CreateInstanceResourceWithOptions(string InstanceId, CreateInstanceResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                body["Group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceResource",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/resources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为指定实例配置创建新的配置资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResourceResponse
        /// </returns>
        public async Task<CreateInstanceResourceResponse> CreateInstanceResourceWithOptionsAsync(string InstanceId, CreateInstanceResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                body["Group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceResource",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/resources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为指定实例配置创建新的配置资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResourceResponse
        /// </returns>
        public CreateInstanceResourceResponse CreateInstanceResource(string InstanceId, CreateInstanceResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceResourceWithOptions(InstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为指定实例配置创建新的配置资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResourceResponse
        /// </returns>
        public async Task<CreateInstanceResourceResponse> CreateInstanceResourceAsync(string InstanceId, CreateInstanceResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceResourceWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实验室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLaboratoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLaboratoryResponse
        /// </returns>
        public CreateLaboratoryResponse CreateLaboratoryWithOptions(CreateLaboratoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketCount))
            {
                body["BucketCount"] = request.BucketCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketType))
            {
                body["BucketType"] = request.BucketType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Buckets))
            {
                body["Buckets"] = request.Buckets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugCrowdId))
            {
                body["DebugCrowdId"] = request.DebugCrowdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                body["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLaboratory",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/laboratories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLaboratoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实验室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLaboratoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLaboratoryResponse
        /// </returns>
        public async Task<CreateLaboratoryResponse> CreateLaboratoryWithOptionsAsync(CreateLaboratoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketCount))
            {
                body["BucketCount"] = request.BucketCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketType))
            {
                body["BucketType"] = request.BucketType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Buckets))
            {
                body["Buckets"] = request.Buckets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugCrowdId))
            {
                body["DebugCrowdId"] = request.DebugCrowdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                body["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLaboratory",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/laboratories",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLaboratoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实验室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLaboratoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLaboratoryResponse
        /// </returns>
        public CreateLaboratoryResponse CreateLaboratory(CreateLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLaboratoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实验室</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLaboratoryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLaboratoryResponse
        /// </returns>
        public async Task<CreateLaboratoryResponse> CreateLaboratoryAsync(CreateLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLaboratoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建层。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLayerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLayerResponse
        /// </returns>
        public CreateLayerResponse CreateLayerWithOptions(CreateLayerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaboratoryId))
            {
                body["LaboratoryId"] = request.LaboratoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLayer",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/layers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLayerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建层。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLayerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLayerResponse
        /// </returns>
        public async Task<CreateLayerResponse> CreateLayerWithOptionsAsync(CreateLayerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaboratoryId))
            {
                body["LaboratoryId"] = request.LaboratoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLayer",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/layers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLayerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建层。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLayerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLayerResponse
        /// </returns>
        public CreateLayerResponse CreateLayer(CreateLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLayerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建层。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLayerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLayerResponse
        /// </returns>
        public async Task<CreateLayerResponse> CreateLayerAsync(CreateLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLayerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建参数。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateParamRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateParamResponse
        /// </returns>
        public CreateParamResponse CreateParamWithOptions(CreateParamRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateParam",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/params",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateParamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建参数。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateParamRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateParamResponse
        /// </returns>
        public async Task<CreateParamResponse> CreateParamWithOptionsAsync(CreateParamRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateParam",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/params",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateParamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建参数。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateParamRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateParamResponse
        /// </returns>
        public CreateParamResponse CreateParam(CreateParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateParamWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建参数。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateParamRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateParamResponse
        /// </returns>
        public async Task<CreateParamResponse> CreateParamAsync(CreateParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateParamWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建资源规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourceRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceRuleResponse
        /// </returns>
        public CreateResourceRuleResponse CreateResourceRuleWithOptions(CreateResourceRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricOperationType))
            {
                body["MetricOperationType"] = request.MetricOperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricPullInfo))
            {
                body["MetricPullInfo"] = request.MetricPullInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricPullPeriod))
            {
                body["MetricPullPeriod"] = request.MetricPullPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleComputingDefinition))
            {
                body["RuleComputingDefinition"] = request.RuleComputingDefinition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleItems))
            {
                body["RuleItems"] = request.RuleItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceRule",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resourcerules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建资源规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourceRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceRuleResponse
        /// </returns>
        public async Task<CreateResourceRuleResponse> CreateResourceRuleWithOptionsAsync(CreateResourceRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricOperationType))
            {
                body["MetricOperationType"] = request.MetricOperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricPullInfo))
            {
                body["MetricPullInfo"] = request.MetricPullInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricPullPeriod))
            {
                body["MetricPullPeriod"] = request.MetricPullPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleComputingDefinition))
            {
                body["RuleComputingDefinition"] = request.RuleComputingDefinition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleItems))
            {
                body["RuleItems"] = request.RuleItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceRule",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resourcerules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建资源规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourceRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceRuleResponse
        /// </returns>
        public CreateResourceRuleResponse CreateResourceRule(CreateResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateResourceRuleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建资源规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourceRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceRuleResponse
        /// </returns>
        public async Task<CreateResourceRuleResponse> CreateResourceRuleAsync(CreateResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateResourceRuleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建资源规则条目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourceRuleItemRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceRuleItemResponse
        /// </returns>
        public CreateResourceRuleItemResponse CreateResourceRuleItemWithOptions(string ResourceRuleId, CreateResourceRuleItemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxValue))
            {
                body["MaxValue"] = request.MaxValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinValue))
            {
                body["MinValue"] = request.MinValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceRuleItem",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resourcerules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceRuleId) + "/items",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceRuleItemResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建资源规则条目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourceRuleItemRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceRuleItemResponse
        /// </returns>
        public async Task<CreateResourceRuleItemResponse> CreateResourceRuleItemWithOptionsAsync(string ResourceRuleId, CreateResourceRuleItemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxValue))
            {
                body["MaxValue"] = request.MaxValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinValue))
            {
                body["MinValue"] = request.MinValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceRuleItem",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resourcerules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceRuleId) + "/items",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceRuleItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建资源规则条目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourceRuleItemRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceRuleItemResponse
        /// </returns>
        public CreateResourceRuleItemResponse CreateResourceRuleItem(string ResourceRuleId, CreateResourceRuleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateResourceRuleItemWithOptions(ResourceRuleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建资源规则条目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourceRuleItemRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceRuleItemResponse
        /// </returns>
        public async Task<CreateResourceRuleItemResponse> CreateResourceRuleItemAsync(string ResourceRuleId, CreateResourceRuleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateResourceRuleItemWithOptionsAsync(ResourceRuleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSceneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSceneResponse
        /// </returns>
        public CreateSceneResponse CreateSceneWithOptions(CreateSceneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flows))
            {
                body["Flows"] = request.Flows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScene",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/scenes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSceneResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSceneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSceneResponse
        /// </returns>
        public async Task<CreateSceneResponse> CreateSceneWithOptionsAsync(CreateSceneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flows))
            {
                body["Flows"] = request.Flows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScene",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/scenes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSceneResponse
        /// </returns>
        public CreateSceneResponse CreateScene(CreateSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSceneWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSceneResponse
        /// </returns>
        public async Task<CreateSceneResponse> CreateSceneAsync(CreateSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSceneWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在指定人群下创建子人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSubCrowdRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSubCrowdResponse
        /// </returns>
        public CreateSubCrowdResponse CreateSubCrowdWithOptions(string CrowdId, CreateSubCrowdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSubCrowd",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CrowdId) + "/subcrowds",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSubCrowdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在指定人群下创建子人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSubCrowdRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSubCrowdResponse
        /// </returns>
        public async Task<CreateSubCrowdResponse> CreateSubCrowdWithOptionsAsync(string CrowdId, CreateSubCrowdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                body["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSubCrowd",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CrowdId) + "/subcrowds",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSubCrowdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在指定人群下创建子人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSubCrowdRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSubCrowdResponse
        /// </returns>
        public CreateSubCrowdResponse CreateSubCrowd(string CrowdId, CreateSubCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSubCrowdWithOptions(CrowdId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在指定人群下创建子人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSubCrowdRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSubCrowdResponse
        /// </returns>
        public async Task<CreateSubCrowdResponse> CreateSubCrowdAsync(string CrowdId, CreateSubCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSubCrowdWithOptionsAsync(CrowdId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTableMetaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTableMetaResponse
        /// </returns>
        public CreateTableMetaResponse CreateTableMetaWithOptions(CreateTableMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Module))
            {
                body["Module"] = request.Module;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTableMeta",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tablemetas",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTableMetaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTableMetaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTableMetaResponse
        /// </returns>
        public async Task<CreateTableMetaResponse> CreateTableMetaWithOptionsAsync(CreateTableMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Module))
            {
                body["Module"] = request.Module;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTableMeta",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tablemetas",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTableMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTableMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTableMetaResponse
        /// </returns>
        public CreateTableMetaResponse CreateTableMeta(CreateTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTableMetaWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTableMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTableMetaResponse
        /// </returns>
        public async Task<CreateTableMetaResponse> CreateTableMetaAsync(CreateTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTableMetaWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrafficControlTargetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTrafficControlTargetResponse
        /// </returns>
        public CreateTrafficControlTargetResponse CreateTrafficControlTargetWithOptions(CreateTrafficControlTargetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Event))
            {
                body["Event"] = request.Event;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionArray))
            {
                body["ItemConditionArray"] = request.ItemConditionArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionExpress))
            {
                body["ItemConditionExpress"] = request.ItemConditionExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionType))
            {
                body["ItemConditionType"] = request.ItemConditionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewProductRegulation))
            {
                body["NewProductRegulation"] = request.NewProductRegulation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallName))
            {
                body["RecallName"] = request.RecallName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisPeriod))
            {
                body["StatisPeriod"] = request.StatisPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToleranceValue))
            {
                body["ToleranceValue"] = request.ToleranceValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficControlTaskId))
            {
                body["TrafficControlTaskId"] = request.TrafficControlTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrafficControlTarget",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltargets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrafficControlTargetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrafficControlTargetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTrafficControlTargetResponse
        /// </returns>
        public async Task<CreateTrafficControlTargetResponse> CreateTrafficControlTargetWithOptionsAsync(CreateTrafficControlTargetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Event))
            {
                body["Event"] = request.Event;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionArray))
            {
                body["ItemConditionArray"] = request.ItemConditionArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionExpress))
            {
                body["ItemConditionExpress"] = request.ItemConditionExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionType))
            {
                body["ItemConditionType"] = request.ItemConditionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewProductRegulation))
            {
                body["NewProductRegulation"] = request.NewProductRegulation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallName))
            {
                body["RecallName"] = request.RecallName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisPeriod))
            {
                body["StatisPeriod"] = request.StatisPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToleranceValue))
            {
                body["ToleranceValue"] = request.ToleranceValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficControlTaskId))
            {
                body["TrafficControlTaskId"] = request.TrafficControlTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrafficControlTarget",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltargets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrafficControlTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrafficControlTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTrafficControlTargetResponse
        /// </returns>
        public CreateTrafficControlTargetResponse CreateTrafficControlTarget(CreateTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTrafficControlTargetWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrafficControlTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTrafficControlTargetResponse
        /// </returns>
        public async Task<CreateTrafficControlTargetResponse> CreateTrafficControlTargetAsync(CreateTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTrafficControlTargetWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrafficControlTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTrafficControlTaskResponse
        /// </returns>
        public CreateTrafficControlTaskResponse CreateTrafficControlTaskWithOptions(CreateTrafficControlTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BehaviorTableMetaId))
            {
                body["BehaviorTableMetaId"] = request.BehaviorTableMetaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlGranularity))
            {
                body["ControlGranularity"] = request.ControlGranularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlLogic))
            {
                body["ControlLogic"] = request.ControlLogic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlType))
            {
                body["ControlType"] = request.ControlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionTime))
            {
                body["ExecutionTime"] = request.ExecutionTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionArray))
            {
                body["ItemConditionArray"] = request.ItemConditionArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionExpress))
            {
                body["ItemConditionExpress"] = request.ItemConditionExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionType))
            {
                body["ItemConditionType"] = request.ItemConditionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTableMetaId))
            {
                body["ItemTableMetaId"] = request.ItemTableMetaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisBehaviorConditionArray))
            {
                body["StatisBehaviorConditionArray"] = request.StatisBehaviorConditionArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisBehaviorConditionExpress))
            {
                body["StatisBehaviorConditionExpress"] = request.StatisBehaviorConditionExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisBehaviorConditionType))
            {
                body["StatisBehaviorConditionType"] = request.StatisBehaviorConditionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficControlTargets))
            {
                body["TrafficControlTargets"] = request.TrafficControlTargets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserConditionArray))
            {
                body["UserConditionArray"] = request.UserConditionArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserConditionExpress))
            {
                body["UserConditionExpress"] = request.UserConditionExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserConditionType))
            {
                body["UserConditionType"] = request.UserConditionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTableMetaId))
            {
                body["UserTableMetaId"] = request.UserTableMetaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrafficControlTask",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrafficControlTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrafficControlTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTrafficControlTaskResponse
        /// </returns>
        public async Task<CreateTrafficControlTaskResponse> CreateTrafficControlTaskWithOptionsAsync(CreateTrafficControlTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BehaviorTableMetaId))
            {
                body["BehaviorTableMetaId"] = request.BehaviorTableMetaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlGranularity))
            {
                body["ControlGranularity"] = request.ControlGranularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlLogic))
            {
                body["ControlLogic"] = request.ControlLogic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlType))
            {
                body["ControlType"] = request.ControlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionTime))
            {
                body["ExecutionTime"] = request.ExecutionTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionArray))
            {
                body["ItemConditionArray"] = request.ItemConditionArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionExpress))
            {
                body["ItemConditionExpress"] = request.ItemConditionExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionType))
            {
                body["ItemConditionType"] = request.ItemConditionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTableMetaId))
            {
                body["ItemTableMetaId"] = request.ItemTableMetaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisBehaviorConditionArray))
            {
                body["StatisBehaviorConditionArray"] = request.StatisBehaviorConditionArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisBehaviorConditionExpress))
            {
                body["StatisBehaviorConditionExpress"] = request.StatisBehaviorConditionExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisBehaviorConditionType))
            {
                body["StatisBehaviorConditionType"] = request.StatisBehaviorConditionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficControlTargets))
            {
                body["TrafficControlTargets"] = request.TrafficControlTargets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserConditionArray))
            {
                body["UserConditionArray"] = request.UserConditionArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserConditionExpress))
            {
                body["UserConditionExpress"] = request.UserConditionExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserConditionType))
            {
                body["UserConditionType"] = request.UserConditionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTableMetaId))
            {
                body["UserTableMetaId"] = request.UserTableMetaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrafficControlTask",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrafficControlTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrafficControlTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTrafficControlTaskResponse
        /// </returns>
        public CreateTrafficControlTaskResponse CreateTrafficControlTask(CreateTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTrafficControlTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTrafficControlTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTrafficControlTaskResponse
        /// </returns>
        public async Task<CreateTrafficControlTaskResponse> CreateTrafficControlTaskAsync(CreateTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTrafficControlTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对指定资源规则中的计算公式进行调试</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DebugResourceRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DebugResourceRuleResponse
        /// </returns>
        public DebugResourceRuleResponse DebugResourceRuleWithOptions(string ResourceRuleId, DebugResourceRuleRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DebugResourceRuleShrinkRequest request = new DebugResourceRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MetricInfo))
            {
                request.MetricInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MetricInfo, "MetricInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricInfoShrink))
            {
                query["MetricInfo"] = request.MetricInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DebugResourceRule",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resourcerules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceRuleId) + "/action/debug",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DebugResourceRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对指定资源规则中的计算公式进行调试</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DebugResourceRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DebugResourceRuleResponse
        /// </returns>
        public async Task<DebugResourceRuleResponse> DebugResourceRuleWithOptionsAsync(string ResourceRuleId, DebugResourceRuleRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DebugResourceRuleShrinkRequest request = new DebugResourceRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MetricInfo))
            {
                request.MetricInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MetricInfo, "MetricInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricInfoShrink))
            {
                query["MetricInfo"] = request.MetricInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DebugResourceRule",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resourcerules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceRuleId) + "/action/debug",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DebugResourceRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对指定资源规则中的计算公式进行调试</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DebugResourceRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DebugResourceRuleResponse
        /// </returns>
        public DebugResourceRuleResponse DebugResourceRule(string ResourceRuleId, DebugResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DebugResourceRuleWithOptions(ResourceRuleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对指定资源规则中的计算公式进行调试</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DebugResourceRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DebugResourceRuleResponse
        /// </returns>
        public async Task<DebugResourceRuleResponse> DebugResourceRuleAsync(string ResourceRuleId, DebugResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DebugResourceRuleWithOptionsAsync(ResourceRuleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定AB实验指标。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteABMetricRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteABMetricResponse
        /// </returns>
        public DeleteABMetricResponse DeleteABMetricWithOptions(string ABMetricId, DeleteABMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteABMetric",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/abmetrics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ABMetricId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteABMetricResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定AB实验指标。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteABMetricRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteABMetricResponse
        /// </returns>
        public async Task<DeleteABMetricResponse> DeleteABMetricWithOptionsAsync(string ABMetricId, DeleteABMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteABMetric",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/abmetrics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ABMetricId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteABMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定AB实验指标。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteABMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteABMetricResponse
        /// </returns>
        public DeleteABMetricResponse DeleteABMetric(string ABMetricId, DeleteABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteABMetricWithOptions(ABMetricId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定AB实验指标。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteABMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteABMetricResponse
        /// </returns>
        public async Task<DeleteABMetricResponse> DeleteABMetricAsync(string ABMetricId, DeleteABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteABMetricWithOptionsAsync(ABMetricId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除AB实验指标组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteABMetricGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteABMetricGroupResponse
        /// </returns>
        public DeleteABMetricGroupResponse DeleteABMetricGroupWithOptions(string ABMetricGroupId, DeleteABMetricGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteABMetricGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/abmetricgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ABMetricGroupId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteABMetricGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除AB实验指标组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteABMetricGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteABMetricGroupResponse
        /// </returns>
        public async Task<DeleteABMetricGroupResponse> DeleteABMetricGroupWithOptionsAsync(string ABMetricGroupId, DeleteABMetricGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteABMetricGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/abmetricgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ABMetricGroupId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteABMetricGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除AB实验指标组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteABMetricGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteABMetricGroupResponse
        /// </returns>
        public DeleteABMetricGroupResponse DeleteABMetricGroup(string ABMetricGroupId, DeleteABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteABMetricGroupWithOptions(ABMetricGroupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除AB实验指标组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteABMetricGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteABMetricGroupResponse
        /// </returns>
        public async Task<DeleteABMetricGroupResponse> DeleteABMetricGroupAsync(string ABMetricGroupId, DeleteABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteABMetricGroupWithOptionsAsync(ABMetricGroupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCrowdRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCrowdResponse
        /// </returns>
        public DeleteCrowdResponse DeleteCrowdWithOptions(string CrowdId, DeleteCrowdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCrowd",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CrowdId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCrowdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCrowdRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCrowdResponse
        /// </returns>
        public async Task<DeleteCrowdResponse> DeleteCrowdWithOptionsAsync(string CrowdId, DeleteCrowdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCrowd",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CrowdId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCrowdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCrowdRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCrowdResponse
        /// </returns>
        public DeleteCrowdResponse DeleteCrowd(string CrowdId, DeleteCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteCrowdWithOptions(CrowdId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCrowdRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCrowdResponse
        /// </returns>
        public async Task<DeleteCrowdResponse> DeleteCrowdAsync(string CrowdId, DeleteCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteCrowdWithOptionsAsync(CrowdId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定推荐引擎配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEngineConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEngineConfigResponse
        /// </returns>
        public DeleteEngineConfigResponse DeleteEngineConfigWithOptions(string EngineConfigId, DeleteEngineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEngineConfig",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/engineconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(EngineConfigId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEngineConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定推荐引擎配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEngineConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEngineConfigResponse
        /// </returns>
        public async Task<DeleteEngineConfigResponse> DeleteEngineConfigWithOptionsAsync(string EngineConfigId, DeleteEngineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEngineConfig",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/engineconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(EngineConfigId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEngineConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定推荐引擎配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEngineConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEngineConfigResponse
        /// </returns>
        public DeleteEngineConfigResponse DeleteEngineConfig(string EngineConfigId, DeleteEngineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteEngineConfigWithOptions(EngineConfigId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定推荐引擎配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEngineConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEngineConfigResponse
        /// </returns>
        public async Task<DeleteEngineConfigResponse> DeleteEngineConfigAsync(string EngineConfigId, DeleteEngineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteEngineConfigWithOptionsAsync(EngineConfigId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实验。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExperimentResponse
        /// </returns>
        public DeleteExperimentResponse DeleteExperimentWithOptions(string ExperimentId, DeleteExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExperiment",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实验。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExperimentResponse
        /// </returns>
        public async Task<DeleteExperimentResponse> DeleteExperimentWithOptionsAsync(string ExperimentId, DeleteExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExperiment",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实验。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteExperimentResponse
        /// </returns>
        public DeleteExperimentResponse DeleteExperiment(string ExperimentId, DeleteExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实验。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteExperimentResponse
        /// </returns>
        public async Task<DeleteExperimentResponse> DeleteExperimentAsync(string ExperimentId, DeleteExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定实验组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExperimentGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExperimentGroupResponse
        /// </returns>
        public DeleteExperimentGroupResponse DeleteExperimentGroupWithOptions(string ExperimentGroupId, DeleteExperimentGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExperimentGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentGroupId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExperimentGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定实验组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExperimentGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExperimentGroupResponse
        /// </returns>
        public async Task<DeleteExperimentGroupResponse> DeleteExperimentGroupWithOptionsAsync(string ExperimentGroupId, DeleteExperimentGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExperimentGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentGroupId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExperimentGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定实验组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExperimentGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteExperimentGroupResponse
        /// </returns>
        public DeleteExperimentGroupResponse DeleteExperimentGroup(string ExperimentGroupId, DeleteExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteExperimentGroupWithOptions(ExperimentGroupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定实验组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExperimentGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteExperimentGroupResponse
        /// </returns>
        public async Task<DeleteExperimentGroupResponse> DeleteExperimentGroupAsync(string ExperimentGroupId, DeleteExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteExperimentGroupWithOptionsAsync(ExperimentGroupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定实例下的指定配置资源。</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResourceResponse
        /// </returns>
        public DeleteInstanceResourceResponse DeleteInstanceResourceWithOptions(string InstanceId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceResource",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定实例下的指定配置资源。</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceResourceResponse
        /// </returns>
        public async Task<DeleteInstanceResourceResponse> DeleteInstanceResourceWithOptionsAsync(string InstanceId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceResource",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定实例下的指定配置资源。</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteInstanceResourceResponse
        /// </returns>
        public DeleteInstanceResourceResponse DeleteInstanceResource(string InstanceId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteInstanceResourceWithOptions(InstanceId, ResourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定实例下的指定配置资源。</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteInstanceResourceResponse
        /// </returns>
        public async Task<DeleteInstanceResourceResponse> DeleteInstanceResourceAsync(string InstanceId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteInstanceResourceWithOptionsAsync(InstanceId, ResourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实验室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLaboratoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLaboratoryResponse
        /// </returns>
        public DeleteLaboratoryResponse DeleteLaboratoryWithOptions(string LaboratoryId, DeleteLaboratoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLaboratory",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/laboratories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LaboratoryId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLaboratoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实验室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLaboratoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLaboratoryResponse
        /// </returns>
        public async Task<DeleteLaboratoryResponse> DeleteLaboratoryWithOptionsAsync(string LaboratoryId, DeleteLaboratoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLaboratory",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/laboratories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LaboratoryId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLaboratoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实验室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLaboratoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLaboratoryResponse
        /// </returns>
        public DeleteLaboratoryResponse DeleteLaboratory(string LaboratoryId, DeleteLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLaboratoryWithOptions(LaboratoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实验室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLaboratoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLaboratoryResponse
        /// </returns>
        public async Task<DeleteLaboratoryResponse> DeleteLaboratoryAsync(string LaboratoryId, DeleteLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteLaboratoryWithOptionsAsync(LaboratoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除层。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLayerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLayerResponse
        /// </returns>
        public DeleteLayerResponse DeleteLayerWithOptions(string LayerId, DeleteLayerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLayer",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LayerId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLayerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除层。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLayerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteLayerResponse
        /// </returns>
        public async Task<DeleteLayerResponse> DeleteLayerWithOptionsAsync(string LayerId, DeleteLayerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLayer",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LayerId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLayerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除层。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLayerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLayerResponse
        /// </returns>
        public DeleteLayerResponse DeleteLayer(string LayerId, DeleteLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLayerWithOptions(LayerId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除层。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteLayerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteLayerResponse
        /// </returns>
        public async Task<DeleteLayerResponse> DeleteLayerAsync(string LayerId, DeleteLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteLayerWithOptionsAsync(LayerId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定参数。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteParamRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteParamResponse
        /// </returns>
        public DeleteParamResponse DeleteParamWithOptions(string ParamId, DeleteParamRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteParam",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/params/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ParamId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteParamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定参数。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteParamRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteParamResponse
        /// </returns>
        public async Task<DeleteParamResponse> DeleteParamWithOptionsAsync(string ParamId, DeleteParamRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteParam",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/params/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ParamId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteParamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定参数。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteParamRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteParamResponse
        /// </returns>
        public DeleteParamResponse DeleteParam(string ParamId, DeleteParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteParamWithOptions(ParamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定参数。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteParamRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteParamResponse
        /// </returns>
        public async Task<DeleteParamResponse> DeleteParamAsync(string ParamId, DeleteParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteParamWithOptionsAsync(ParamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除资源规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteResourceRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceRuleResponse
        /// </returns>
        public DeleteResourceRuleResponse DeleteResourceRuleWithOptions(string ResourceRuleId, DeleteResourceRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceRule",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resourcerules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceRuleId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除资源规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteResourceRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceRuleResponse
        /// </returns>
        public async Task<DeleteResourceRuleResponse> DeleteResourceRuleWithOptionsAsync(string ResourceRuleId, DeleteResourceRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceRule",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resourcerules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceRuleId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除资源规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteResourceRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceRuleResponse
        /// </returns>
        public DeleteResourceRuleResponse DeleteResourceRule(string ResourceRuleId, DeleteResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteResourceRuleWithOptions(ResourceRuleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除资源规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteResourceRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceRuleResponse
        /// </returns>
        public async Task<DeleteResourceRuleResponse> DeleteResourceRuleAsync(string ResourceRuleId, DeleteResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteResourceRuleWithOptionsAsync(ResourceRuleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除资源规则条目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteResourceRuleItemRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceRuleItemResponse
        /// </returns>
        public DeleteResourceRuleItemResponse DeleteResourceRuleItemWithOptions(string ResourceRuleId, string ResourceRuleItemId, DeleteResourceRuleItemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceRuleItem",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resourcerules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceRuleId) + "/items/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceRuleItemId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceRuleItemResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除资源规则条目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteResourceRuleItemRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceRuleItemResponse
        /// </returns>
        public async Task<DeleteResourceRuleItemResponse> DeleteResourceRuleItemWithOptionsAsync(string ResourceRuleId, string ResourceRuleItemId, DeleteResourceRuleItemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceRuleItem",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resourcerules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceRuleId) + "/items/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceRuleItemId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceRuleItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除资源规则条目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteResourceRuleItemRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceRuleItemResponse
        /// </returns>
        public DeleteResourceRuleItemResponse DeleteResourceRuleItem(string ResourceRuleId, string ResourceRuleItemId, DeleteResourceRuleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteResourceRuleItemWithOptions(ResourceRuleId, ResourceRuleItemId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除资源规则条目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteResourceRuleItemRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceRuleItemResponse
        /// </returns>
        public async Task<DeleteResourceRuleItemResponse> DeleteResourceRuleItemAsync(string ResourceRuleId, string ResourceRuleItemId, DeleteResourceRuleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteResourceRuleItemWithOptionsAsync(ResourceRuleId, ResourceRuleItemId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSceneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSceneResponse
        /// </returns>
        public DeleteSceneResponse DeleteSceneWithOptions(string SceneId, DeleteSceneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScene",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SceneId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSceneResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSceneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSceneResponse
        /// </returns>
        public async Task<DeleteSceneResponse> DeleteSceneWithOptionsAsync(string SceneId, DeleteSceneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScene",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SceneId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSceneResponse
        /// </returns>
        public DeleteSceneResponse DeleteScene(string SceneId, DeleteSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSceneWithOptions(SceneId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSceneResponse
        /// </returns>
        public async Task<DeleteSceneResponse> DeleteSceneAsync(string SceneId, DeleteSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSceneWithOptionsAsync(SceneId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定人群下的指定子人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSubCrowdRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSubCrowdResponse
        /// </returns>
        public DeleteSubCrowdResponse DeleteSubCrowdWithOptions(string CrowdId, string SubCrowdId, DeleteSubCrowdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSubCrowd",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CrowdId) + "/subcrowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SubCrowdId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSubCrowdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定人群下的指定子人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSubCrowdRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSubCrowdResponse
        /// </returns>
        public async Task<DeleteSubCrowdResponse> DeleteSubCrowdWithOptionsAsync(string CrowdId, string SubCrowdId, DeleteSubCrowdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSubCrowd",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CrowdId) + "/subcrowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SubCrowdId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSubCrowdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定人群下的指定子人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSubCrowdRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSubCrowdResponse
        /// </returns>
        public DeleteSubCrowdResponse DeleteSubCrowd(string CrowdId, string SubCrowdId, DeleteSubCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSubCrowdWithOptions(CrowdId, SubCrowdId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定人群下的指定子人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSubCrowdRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSubCrowdResponse
        /// </returns>
        public async Task<DeleteSubCrowdResponse> DeleteSubCrowdAsync(string CrowdId, string SubCrowdId, DeleteSubCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSubCrowdWithOptionsAsync(CrowdId, SubCrowdId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTableMetaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTableMetaResponse
        /// </returns>
        public DeleteTableMetaResponse DeleteTableMetaWithOptions(string TableMetaId, DeleteTableMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTableMeta",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tablemetas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TableMetaId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTableMetaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTableMetaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTableMetaResponse
        /// </returns>
        public async Task<DeleteTableMetaResponse> DeleteTableMetaWithOptionsAsync(string TableMetaId, DeleteTableMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTableMeta",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tablemetas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TableMetaId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTableMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTableMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTableMetaResponse
        /// </returns>
        public DeleteTableMetaResponse DeleteTableMeta(string TableMetaId, DeleteTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTableMetaWithOptions(TableMetaId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTableMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTableMetaResponse
        /// </returns>
        public async Task<DeleteTableMetaResponse> DeleteTableMetaAsync(string TableMetaId, DeleteTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTableMetaWithOptionsAsync(TableMetaId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTrafficControlTargetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTrafficControlTargetResponse
        /// </returns>
        public DeleteTrafficControlTargetResponse DeleteTrafficControlTargetWithOptions(string TrafficControlTargetId, DeleteTrafficControlTargetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrafficControlTarget",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltargets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTargetId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTrafficControlTargetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTrafficControlTargetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTrafficControlTargetResponse
        /// </returns>
        public async Task<DeleteTrafficControlTargetResponse> DeleteTrafficControlTargetWithOptionsAsync(string TrafficControlTargetId, DeleteTrafficControlTargetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrafficControlTarget",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltargets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTargetId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTrafficControlTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTrafficControlTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTrafficControlTargetResponse
        /// </returns>
        public DeleteTrafficControlTargetResponse DeleteTrafficControlTarget(string TrafficControlTargetId, DeleteTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTrafficControlTargetWithOptions(TrafficControlTargetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTrafficControlTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTrafficControlTargetResponse
        /// </returns>
        public async Task<DeleteTrafficControlTargetResponse> DeleteTrafficControlTargetAsync(string TrafficControlTargetId, DeleteTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTrafficControlTargetWithOptionsAsync(TrafficControlTargetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定的流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTrafficControlTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTrafficControlTaskResponse
        /// </returns>
        public DeleteTrafficControlTaskResponse DeleteTrafficControlTaskWithOptions(string TrafficControlTaskId, DeleteTrafficControlTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrafficControlTask",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTrafficControlTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定的流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTrafficControlTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTrafficControlTaskResponse
        /// </returns>
        public async Task<DeleteTrafficControlTaskResponse> DeleteTrafficControlTaskWithOptionsAsync(string TrafficControlTaskId, DeleteTrafficControlTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrafficControlTask",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTrafficControlTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定的流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTrafficControlTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTrafficControlTaskResponse
        /// </returns>
        public DeleteTrafficControlTaskResponse DeleteTrafficControlTask(string TrafficControlTaskId, DeleteTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTrafficControlTaskWithOptions(TrafficControlTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定的流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTrafficControlTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTrafficControlTaskResponse
        /// </returns>
        public async Task<DeleteTrafficControlTaskResponse> DeleteTrafficControlTaskAsync(string TrafficControlTaskId, DeleteTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTrafficControlTaskWithOptionsAsync(TrafficControlTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>产生流量调控的相关代码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateTrafficControlTaskCodeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateTrafficControlTaskCodeResponse
        /// </returns>
        public GenerateTrafficControlTaskCodeResponse GenerateTrafficControlTaskCodeWithOptions(string TrafficControlTaskId, GenerateTrafficControlTaskCodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateTrafficControlTaskCode",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId) + "/action/generatecode",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateTrafficControlTaskCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>产生流量调控的相关代码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateTrafficControlTaskCodeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateTrafficControlTaskCodeResponse
        /// </returns>
        public async Task<GenerateTrafficControlTaskCodeResponse> GenerateTrafficControlTaskCodeWithOptionsAsync(string TrafficControlTaskId, GenerateTrafficControlTaskCodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateTrafficControlTaskCode",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId) + "/action/generatecode",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateTrafficControlTaskCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>产生流量调控的相关代码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateTrafficControlTaskCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateTrafficControlTaskCodeResponse
        /// </returns>
        public GenerateTrafficControlTaskCodeResponse GenerateTrafficControlTaskCode(string TrafficControlTaskId, GenerateTrafficControlTaskCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateTrafficControlTaskCodeWithOptions(TrafficControlTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>产生流量调控的相关代码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateTrafficControlTaskCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateTrafficControlTaskCodeResponse
        /// </returns>
        public async Task<GenerateTrafficControlTaskCodeResponse> GenerateTrafficControlTaskCodeAsync(string TrafficControlTaskId, GenerateTrafficControlTaskCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateTrafficControlTaskCodeWithOptionsAsync(TrafficControlTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>产生流量调控的相关召回配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateTrafficControlTaskConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateTrafficControlTaskConfigResponse
        /// </returns>
        public GenerateTrafficControlTaskConfigResponse GenerateTrafficControlTaskConfigWithOptions(string TrafficControlTaskId, GenerateTrafficControlTaskConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateTrafficControlTaskConfig",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId) + "/action/generateconfig",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateTrafficControlTaskConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>产生流量调控的相关召回配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateTrafficControlTaskConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateTrafficControlTaskConfigResponse
        /// </returns>
        public async Task<GenerateTrafficControlTaskConfigResponse> GenerateTrafficControlTaskConfigWithOptionsAsync(string TrafficControlTaskId, GenerateTrafficControlTaskConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateTrafficControlTaskConfig",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId) + "/action/generateconfig",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateTrafficControlTaskConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>产生流量调控的相关召回配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateTrafficControlTaskConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateTrafficControlTaskConfigResponse
        /// </returns>
        public GenerateTrafficControlTaskConfigResponse GenerateTrafficControlTaskConfig(string TrafficControlTaskId, GenerateTrafficControlTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateTrafficControlTaskConfigWithOptions(TrafficControlTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>产生流量调控的相关召回配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateTrafficControlTaskConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateTrafficControlTaskConfigResponse
        /// </returns>
        public async Task<GenerateTrafficControlTaskConfigResponse> GenerateTrafficControlTaskConfigAsync(string TrafficControlTaskId, GenerateTrafficControlTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateTrafficControlTaskConfigWithOptionsAsync(TrafficControlTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AB Test实验指标详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetABMetricRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetABMetricResponse
        /// </returns>
        public GetABMetricResponse GetABMetricWithOptions(string ABMetricId, GetABMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetABMetric",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/abmetrics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ABMetricId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetABMetricResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AB Test实验指标详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetABMetricRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetABMetricResponse
        /// </returns>
        public async Task<GetABMetricResponse> GetABMetricWithOptionsAsync(string ABMetricId, GetABMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetABMetric",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/abmetrics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ABMetricId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetABMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AB Test实验指标详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetABMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// GetABMetricResponse
        /// </returns>
        public GetABMetricResponse GetABMetric(string ABMetricId, GetABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetABMetricWithOptions(ABMetricId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AB Test实验指标详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetABMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// GetABMetricResponse
        /// </returns>
        public async Task<GetABMetricResponse> GetABMetricAsync(string ABMetricId, GetABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetABMetricWithOptionsAsync(ABMetricId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AB实验指标组详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetABMetricGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetABMetricGroupResponse
        /// </returns>
        public GetABMetricGroupResponse GetABMetricGroupWithOptions(string ABMetricGroupId, GetABMetricGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetABMetricGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/abmetricgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ABMetricGroupId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetABMetricGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AB实验指标组详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetABMetricGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetABMetricGroupResponse
        /// </returns>
        public async Task<GetABMetricGroupResponse> GetABMetricGroupWithOptionsAsync(string ABMetricGroupId, GetABMetricGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetABMetricGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/abmetricgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ABMetricGroupId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetABMetricGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AB实验指标组详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetABMetricGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetABMetricGroupResponse
        /// </returns>
        public GetABMetricGroupResponse GetABMetricGroup(string ABMetricGroupId, GetABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetABMetricGroupWithOptions(ABMetricGroupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AB实验指标组详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetABMetricGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetABMetricGroupResponse
        /// </returns>
        public async Task<GetABMetricGroupResponse> GetABMetricGroupAsync(string ABMetricGroupId, GetABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetABMetricGroupWithOptionsAsync(ABMetricGroupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定计算任务详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCalculationJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCalculationJobResponse
        /// </returns>
        public GetCalculationJobResponse GetCalculationJobWithOptions(string CalculationJobId, GetCalculationJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCalculationJob",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/calculationjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CalculationJobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCalculationJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定计算任务详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCalculationJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCalculationJobResponse
        /// </returns>
        public async Task<GetCalculationJobResponse> GetCalculationJobWithOptionsAsync(string CalculationJobId, GetCalculationJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCalculationJob",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/calculationjobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CalculationJobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCalculationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定计算任务详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCalculationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCalculationJobResponse
        /// </returns>
        public GetCalculationJobResponse GetCalculationJob(string CalculationJobId, GetCalculationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCalculationJobWithOptions(CalculationJobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定计算任务详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCalculationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCalculationJobResponse
        /// </returns>
        public async Task<GetCalculationJobResponse> GetCalculationJobAsync(string CalculationJobId, GetCalculationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCalculationJobWithOptionsAsync(CalculationJobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取引擎配置详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEngineConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEngineConfigResponse
        /// </returns>
        public GetEngineConfigResponse GetEngineConfigWithOptions(string EngineConfigId, GetEngineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEngineConfig",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/engineconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(EngineConfigId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEngineConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取引擎配置详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEngineConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEngineConfigResponse
        /// </returns>
        public async Task<GetEngineConfigResponse> GetEngineConfigWithOptionsAsync(string EngineConfigId, GetEngineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEngineConfig",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/engineconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(EngineConfigId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEngineConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取引擎配置详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEngineConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEngineConfigResponse
        /// </returns>
        public GetEngineConfigResponse GetEngineConfig(string EngineConfigId, GetEngineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEngineConfigWithOptions(EngineConfigId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取引擎配置详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEngineConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEngineConfigResponse
        /// </returns>
        public async Task<GetEngineConfigResponse> GetEngineConfigAsync(string EngineConfigId, GetEngineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEngineConfigWithOptionsAsync(EngineConfigId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentResponse
        /// </returns>
        public GetExperimentResponse GetExperimentWithOptions(string ExperimentId, GetExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperiment",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentResponse
        /// </returns>
        public async Task<GetExperimentResponse> GetExperimentWithOptionsAsync(string ExperimentId, GetExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperiment",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentResponse
        /// </returns>
        public GetExperimentResponse GetExperiment(string ExperimentId, GetExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentResponse
        /// </returns>
        public async Task<GetExperimentResponse> GetExperimentAsync(string ExperimentId, GetExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定实验组详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentGroupResponse
        /// </returns>
        public GetExperimentGroupResponse GetExperimentGroupWithOptions(string ExperimentGroupId, GetExperimentGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperimentGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentGroupId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定实验组详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentGroupResponse
        /// </returns>
        public async Task<GetExperimentGroupResponse> GetExperimentGroupWithOptionsAsync(string ExperimentGroupId, GetExperimentGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperimentGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentGroupId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定实验组详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentGroupResponse
        /// </returns>
        public GetExperimentGroupResponse GetExperimentGroup(string ExperimentGroupId, GetExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetExperimentGroupWithOptions(ExperimentGroupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定实验组详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentGroupResponse
        /// </returns>
        public async Task<GetExperimentGroupResponse> GetExperimentGroupAsync(string ExperimentGroupId, GetExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetExperimentGroupWithOptionsAsync(ExperimentGroupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检查任务详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFeatureConsistencyCheckJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFeatureConsistencyCheckJobResponse
        /// </returns>
        public GetFeatureConsistencyCheckJobResponse GetFeatureConsistencyCheckJobWithOptions(string FeatureConsistencyCheckJobId, GetFeatureConsistencyCheckJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFeatureConsistencyCheckJob",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureConsistencyCheckJobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFeatureConsistencyCheckJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检查任务详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFeatureConsistencyCheckJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFeatureConsistencyCheckJobResponse
        /// </returns>
        public async Task<GetFeatureConsistencyCheckJobResponse> GetFeatureConsistencyCheckJobWithOptionsAsync(string FeatureConsistencyCheckJobId, GetFeatureConsistencyCheckJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFeatureConsistencyCheckJob",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureConsistencyCheckJobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFeatureConsistencyCheckJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检查任务详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFeatureConsistencyCheckJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFeatureConsistencyCheckJobResponse
        /// </returns>
        public GetFeatureConsistencyCheckJobResponse GetFeatureConsistencyCheckJob(string FeatureConsistencyCheckJobId, GetFeatureConsistencyCheckJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFeatureConsistencyCheckJobWithOptions(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检查任务详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFeatureConsistencyCheckJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFeatureConsistencyCheckJobResponse
        /// </returns>
        public async Task<GetFeatureConsistencyCheckJobResponse> GetFeatureConsistencyCheckJobAsync(string FeatureConsistencyCheckJobId, GetFeatureConsistencyCheckJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFeatureConsistencyCheckJobWithOptionsAsync(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检测配置详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFeatureConsistencyCheckJobConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFeatureConsistencyCheckJobConfigResponse
        /// </returns>
        public GetFeatureConsistencyCheckJobConfigResponse GetFeatureConsistencyCheckJobConfigWithOptions(string FeatureConsistencyCheckJobConfigId, GetFeatureConsistencyCheckJobConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFeatureConsistencyCheckJobConfig",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureConsistencyCheckJobConfigId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFeatureConsistencyCheckJobConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检测配置详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFeatureConsistencyCheckJobConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFeatureConsistencyCheckJobConfigResponse
        /// </returns>
        public async Task<GetFeatureConsistencyCheckJobConfigResponse> GetFeatureConsistencyCheckJobConfigWithOptionsAsync(string FeatureConsistencyCheckJobConfigId, GetFeatureConsistencyCheckJobConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFeatureConsistencyCheckJobConfig",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureConsistencyCheckJobConfigId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFeatureConsistencyCheckJobConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检测配置详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFeatureConsistencyCheckJobConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFeatureConsistencyCheckJobConfigResponse
        /// </returns>
        public GetFeatureConsistencyCheckJobConfigResponse GetFeatureConsistencyCheckJobConfig(string FeatureConsistencyCheckJobConfigId, GetFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFeatureConsistencyCheckJobConfigWithOptions(FeatureConsistencyCheckJobConfigId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检测配置详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFeatureConsistencyCheckJobConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFeatureConsistencyCheckJobConfigResponse
        /// </returns>
        public async Task<GetFeatureConsistencyCheckJobConfigResponse> GetFeatureConsistencyCheckJobConfigAsync(string FeatureConsistencyCheckJobConfigId, GetFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFeatureConsistencyCheckJobConfigWithOptionsAsync(FeatureConsistencyCheckJobConfigId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定推荐全链路深度定制开发平台实例信息。</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public GetInstanceResponse GetInstanceWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定推荐全链路深度定制开发平台实例信息。</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public async Task<GetInstanceResponse> GetInstanceWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定推荐全链路深度定制开发平台实例信息。</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public GetInstanceResponse GetInstance(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceWithOptions(InstanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定推荐全链路深度定制开发平台实例信息。</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public async Task<GetInstanceResponse> GetInstanceAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceWithOptionsAsync(InstanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定实例下指定资源的详细信息。</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResourceResponse
        /// </returns>
        public GetInstanceResourceResponse GetInstanceResourceWithOptions(string InstanceId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceResource",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定实例下指定资源的详细信息。</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResourceResponse
        /// </returns>
        public async Task<GetInstanceResourceResponse> GetInstanceResourceWithOptionsAsync(string InstanceId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceResource",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定实例下指定资源的详细信息。</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetInstanceResourceResponse
        /// </returns>
        public GetInstanceResourceResponse GetInstanceResource(string InstanceId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceResourceWithOptions(InstanceId, ResourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定实例下指定资源的详细信息。</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetInstanceResourceResponse
        /// </returns>
        public async Task<GetInstanceResourceResponse> GetInstanceResourceAsync(string InstanceId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceResourceWithOptionsAsync(InstanceId, ResourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据源下指定表的详细信息。</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResourceTableResponse
        /// </returns>
        public GetInstanceResourceTableResponse GetInstanceResourceTableWithOptions(string InstanceId, string ResourceId, string TableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceResourceTable",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TableName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResourceTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据源下指定表的详细信息。</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResourceTableResponse
        /// </returns>
        public async Task<GetInstanceResourceTableResponse> GetInstanceResourceTableWithOptionsAsync(string InstanceId, string ResourceId, string TableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceResourceTable",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TableName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResourceTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据源下指定表的详细信息。</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetInstanceResourceTableResponse
        /// </returns>
        public GetInstanceResourceTableResponse GetInstanceResourceTable(string InstanceId, string ResourceId, string TableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceResourceTableWithOptions(InstanceId, ResourceId, TableName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据源下指定表的详细信息。</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetInstanceResourceTableResponse
        /// </returns>
        public async Task<GetInstanceResourceTableResponse> GetInstanceResourceTableAsync(string InstanceId, string ResourceId, string TableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceResourceTableWithOptionsAsync(InstanceId, ResourceId, TableName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验室详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLaboratoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLaboratoryResponse
        /// </returns>
        public GetLaboratoryResponse GetLaboratoryWithOptions(string LaboratoryId, GetLaboratoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLaboratory",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/laboratories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LaboratoryId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLaboratoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验室详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLaboratoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLaboratoryResponse
        /// </returns>
        public async Task<GetLaboratoryResponse> GetLaboratoryWithOptionsAsync(string LaboratoryId, GetLaboratoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLaboratory",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/laboratories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LaboratoryId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLaboratoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验室详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLaboratoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLaboratoryResponse
        /// </returns>
        public GetLaboratoryResponse GetLaboratory(string LaboratoryId, GetLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLaboratoryWithOptions(LaboratoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验室详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLaboratoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLaboratoryResponse
        /// </returns>
        public async Task<GetLaboratoryResponse> GetLaboratoryAsync(string LaboratoryId, GetLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLaboratoryWithOptionsAsync(LaboratoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取层详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLayerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLayerResponse
        /// </returns>
        public GetLayerResponse GetLayerWithOptions(string LayerId, GetLayerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLayer",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LayerId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLayerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取层详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLayerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLayerResponse
        /// </returns>
        public async Task<GetLayerResponse> GetLayerWithOptionsAsync(string LayerId, GetLayerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLayer",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LayerId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLayerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取层详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLayerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLayerResponse
        /// </returns>
        public GetLayerResponse GetLayer(string LayerId, GetLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLayerWithOptions(LayerId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取层详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLayerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLayerResponse
        /// </returns>
        public async Task<GetLayerResponse> GetLayerAsync(string LayerId, GetLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLayerWithOptionsAsync(LayerId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取资源规则详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceRuleResponse
        /// </returns>
        public GetResourceRuleResponse GetResourceRuleWithOptions(string ResourceRuleId, GetResourceRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceRule",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resourcerules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceRuleId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取资源规则详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceRuleResponse
        /// </returns>
        public async Task<GetResourceRuleResponse> GetResourceRuleWithOptionsAsync(string ResourceRuleId, GetResourceRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceRule",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resourcerules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceRuleId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取资源规则详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceRuleResponse
        /// </returns>
        public GetResourceRuleResponse GetResourceRule(string ResourceRuleId, GetResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetResourceRuleWithOptions(ResourceRuleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取资源规则详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceRuleResponse
        /// </returns>
        public async Task<GetResourceRuleResponse> GetResourceRuleAsync(string ResourceRuleId, GetResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetResourceRuleWithOptionsAsync(ResourceRuleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSceneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSceneResponse
        /// </returns>
        public GetSceneResponse GetSceneWithOptions(string SceneId, GetSceneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScene",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SceneId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSceneResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSceneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSceneResponse
        /// </returns>
        public async Task<GetSceneResponse> GetSceneWithOptionsAsync(string SceneId, GetSceneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScene",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SceneId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSceneResponse
        /// </returns>
        public GetSceneResponse GetScene(string SceneId, GetSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSceneWithOptions(SceneId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景详细信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSceneResponse
        /// </returns>
        public async Task<GetSceneResponse> GetSceneAsync(string SceneId, GetSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSceneWithOptionsAsync(SceneId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定人群下的指定子人群的详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubCrowdRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSubCrowdResponse
        /// </returns>
        public GetSubCrowdResponse GetSubCrowdWithOptions(string CrowdId, string SubCrowdId, GetSubCrowdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubCrowd",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CrowdId) + "/subcrowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SubCrowdId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubCrowdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定人群下的指定子人群的详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubCrowdRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSubCrowdResponse
        /// </returns>
        public async Task<GetSubCrowdResponse> GetSubCrowdWithOptionsAsync(string CrowdId, string SubCrowdId, GetSubCrowdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubCrowd",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CrowdId) + "/subcrowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SubCrowdId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubCrowdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定人群下的指定子人群的详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubCrowdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSubCrowdResponse
        /// </returns>
        public GetSubCrowdResponse GetSubCrowd(string CrowdId, string SubCrowdId, GetSubCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSubCrowdWithOptions(CrowdId, SubCrowdId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定人群下的指定子人群的详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSubCrowdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSubCrowdResponse
        /// </returns>
        public async Task<GetSubCrowdResponse> GetSubCrowdAsync(string CrowdId, string SubCrowdId, GetSubCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSubCrowdWithOptionsAsync(CrowdId, SubCrowdId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据表详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableMetaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTableMetaResponse
        /// </returns>
        public GetTableMetaResponse GetTableMetaWithOptions(string TableMetaId, GetTableMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableMeta",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tablemetas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TableMetaId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableMetaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据表详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableMetaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTableMetaResponse
        /// </returns>
        public async Task<GetTableMetaResponse> GetTableMetaWithOptionsAsync(string TableMetaId, GetTableMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableMeta",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tablemetas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TableMetaId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据表详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTableMetaResponse
        /// </returns>
        public GetTableMetaResponse GetTableMeta(string TableMetaId, GetTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTableMetaWithOptions(TableMetaId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据表详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTableMetaResponse
        /// </returns>
        public async Task<GetTableMetaResponse> GetTableMetaAsync(string TableMetaId, GetTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTableMetaWithOptionsAsync(TableMetaId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流量调控目标详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrafficControlTargetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTrafficControlTargetResponse
        /// </returns>
        public GetTrafficControlTargetResponse GetTrafficControlTargetWithOptions(string TrafficControlTargetId, GetTrafficControlTargetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrafficControlTarget",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltargets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTargetId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrafficControlTargetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流量调控目标详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrafficControlTargetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTrafficControlTargetResponse
        /// </returns>
        public async Task<GetTrafficControlTargetResponse> GetTrafficControlTargetWithOptionsAsync(string TrafficControlTargetId, GetTrafficControlTargetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrafficControlTarget",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltargets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTargetId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrafficControlTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流量调控目标详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrafficControlTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTrafficControlTargetResponse
        /// </returns>
        public GetTrafficControlTargetResponse GetTrafficControlTarget(string TrafficControlTargetId, GetTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTrafficControlTargetWithOptions(TrafficControlTargetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流量调控目标详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrafficControlTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTrafficControlTargetResponse
        /// </returns>
        public async Task<GetTrafficControlTargetResponse> GetTrafficControlTargetAsync(string TrafficControlTargetId, GetTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTrafficControlTargetWithOptionsAsync(TrafficControlTargetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流量调控任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrafficControlTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTrafficControlTaskResponse
        /// </returns>
        public GetTrafficControlTaskResponse GetTrafficControlTaskWithOptions(string TrafficControlTaskId, GetTrafficControlTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlTargetFilter))
            {
                query["ControlTargetFilter"] = request.ControlTargetFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["Version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrafficControlTask",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrafficControlTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流量调控任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrafficControlTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTrafficControlTaskResponse
        /// </returns>
        public async Task<GetTrafficControlTaskResponse> GetTrafficControlTaskWithOptionsAsync(string TrafficControlTaskId, GetTrafficControlTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlTargetFilter))
            {
                query["ControlTargetFilter"] = request.ControlTargetFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["Version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrafficControlTask",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrafficControlTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流量调控任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrafficControlTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTrafficControlTaskResponse
        /// </returns>
        public GetTrafficControlTaskResponse GetTrafficControlTask(string TrafficControlTaskId, GetTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTrafficControlTaskWithOptions(TrafficControlTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流量调控任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrafficControlTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTrafficControlTaskResponse
        /// </returns>
        public async Task<GetTrafficControlTaskResponse> GetTrafficControlTaskAsync(string TrafficControlTaskId, GetTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTrafficControlTaskWithOptionsAsync(TrafficControlTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流量调控任务的流量详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrafficControlTaskTrafficRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTrafficControlTaskTrafficResponse
        /// </returns>
        public GetTrafficControlTaskTrafficResponse GetTrafficControlTaskTrafficWithOptions(string TrafficControlTaskId, GetTrafficControlTaskTrafficRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrafficControlTaskTraffic",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId) + "/trafficinfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrafficControlTaskTrafficResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流量调控任务的流量详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrafficControlTaskTrafficRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTrafficControlTaskTrafficResponse
        /// </returns>
        public async Task<GetTrafficControlTaskTrafficResponse> GetTrafficControlTaskTrafficWithOptionsAsync(string TrafficControlTaskId, GetTrafficControlTaskTrafficRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrafficControlTaskTraffic",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId) + "/trafficinfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrafficControlTaskTrafficResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流量调控任务的流量详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrafficControlTaskTrafficRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTrafficControlTaskTrafficResponse
        /// </returns>
        public GetTrafficControlTaskTrafficResponse GetTrafficControlTaskTraffic(string TrafficControlTaskId, GetTrafficControlTaskTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTrafficControlTaskTrafficWithOptions(TrafficControlTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流量调控任务的流量详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTrafficControlTaskTrafficRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTrafficControlTaskTrafficResponse
        /// </returns>
        public async Task<GetTrafficControlTaskTrafficResponse> GetTrafficControlTaskTrafficAsync(string TrafficControlTaskId, GetTrafficControlTaskTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTrafficControlTaskTrafficWithOptionsAsync(TrafficControlTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AB Test实验指标组列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListABMetricGroupsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListABMetricGroupsResponse
        /// </returns>
        public ListABMetricGroupsResponse ListABMetricGroupsWithOptions(ListABMetricGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Realtime))
            {
                query["Realtime"] = request.Realtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListABMetricGroups",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/abmetricgroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListABMetricGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AB Test实验指标组列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListABMetricGroupsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListABMetricGroupsResponse
        /// </returns>
        public async Task<ListABMetricGroupsResponse> ListABMetricGroupsWithOptionsAsync(ListABMetricGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Realtime))
            {
                query["Realtime"] = request.Realtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListABMetricGroups",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/abmetricgroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListABMetricGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AB Test实验指标组列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListABMetricGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListABMetricGroupsResponse
        /// </returns>
        public ListABMetricGroupsResponse ListABMetricGroups(ListABMetricGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListABMetricGroupsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AB Test实验指标组列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListABMetricGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListABMetricGroupsResponse
        /// </returns>
        public async Task<ListABMetricGroupsResponse> ListABMetricGroupsAsync(ListABMetricGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListABMetricGroupsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AB Test实验指标列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListABMetricsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListABMetricsResponse
        /// </returns>
        public ListABMetricsResponse ListABMetricsWithOptions(ListABMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Realtime))
            {
                query["Realtime"] = request.Realtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableMetaId))
            {
                query["TableMetaId"] = request.TableMetaId;
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
                Action = "ListABMetrics",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/abmetrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListABMetricsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AB Test实验指标列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListABMetricsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListABMetricsResponse
        /// </returns>
        public async Task<ListABMetricsResponse> ListABMetricsWithOptionsAsync(ListABMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Realtime))
            {
                query["Realtime"] = request.Realtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableMetaId))
            {
                query["TableMetaId"] = request.TableMetaId;
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
                Action = "ListABMetrics",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/abmetrics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListABMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AB Test实验指标列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListABMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListABMetricsResponse
        /// </returns>
        public ListABMetricsResponse ListABMetrics(ListABMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListABMetricsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取AB Test实验指标列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListABMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListABMetricsResponse
        /// </returns>
        public async Task<ListABMetricsResponse> ListABMetricsAsync(ListABMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListABMetricsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取计算任务列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCalculationJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCalculationJobsResponse
        /// </returns>
        public ListCalculationJobsResponse ListCalculationJobsWithOptions(ListCalculationJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCalculationJobs",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/calculationjobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCalculationJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取计算任务列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCalculationJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCalculationJobsResponse
        /// </returns>
        public async Task<ListCalculationJobsResponse> ListCalculationJobsWithOptionsAsync(ListCalculationJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCalculationJobs",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/calculationjobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCalculationJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取计算任务列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCalculationJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCalculationJobsResponse
        /// </returns>
        public ListCalculationJobsResponse ListCalculationJobs(ListCalculationJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCalculationJobsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取计算任务列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCalculationJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCalculationJobsResponse
        /// </returns>
        public async Task<ListCalculationJobsResponse> ListCalculationJobsAsync(ListCalculationJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCalculationJobsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取人群下的所有用户。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCrowdUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCrowdUsersResponse
        /// </returns>
        public ListCrowdUsersResponse ListCrowdUsersWithOptions(string CrowdId, ListCrowdUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCrowdUsers",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CrowdId) + "/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCrowdUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取人群下的所有用户。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCrowdUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCrowdUsersResponse
        /// </returns>
        public async Task<ListCrowdUsersResponse> ListCrowdUsersWithOptionsAsync(string CrowdId, ListCrowdUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCrowdUsers",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CrowdId) + "/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCrowdUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取人群下的所有用户。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCrowdUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCrowdUsersResponse
        /// </returns>
        public ListCrowdUsersResponse ListCrowdUsers(string CrowdId, ListCrowdUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCrowdUsersWithOptions(CrowdId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取人群下的所有用户。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCrowdUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCrowdUsersResponse
        /// </returns>
        public async Task<ListCrowdUsersResponse> ListCrowdUsersAsync(string CrowdId, ListCrowdUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCrowdUsersWithOptionsAsync(CrowdId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取人群列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCrowdsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCrowdsResponse
        /// </returns>
        public ListCrowdsResponse ListCrowdsWithOptions(ListCrowdsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCrowds",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCrowdsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取人群列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCrowdsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCrowdsResponse
        /// </returns>
        public async Task<ListCrowdsResponse> ListCrowdsWithOptionsAsync(ListCrowdsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCrowds",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCrowdsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取人群列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCrowdsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCrowdsResponse
        /// </returns>
        public ListCrowdsResponse ListCrowds(ListCrowdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCrowdsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取人群列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCrowdsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCrowdsResponse
        /// </returns>
        public async Task<ListCrowdsResponse> ListCrowdsAsync(ListCrowdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCrowdsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取引擎配置列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEngineConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEngineConfigsResponse
        /// </returns>
        public ListEngineConfigsResponse ListEngineConfigsWithOptions(ListEngineConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["Version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEngineConfigs",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/engineconfigs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEngineConfigsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取引擎配置列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEngineConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEngineConfigsResponse
        /// </returns>
        public async Task<ListEngineConfigsResponse> ListEngineConfigsWithOptionsAsync(ListEngineConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["Version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEngineConfigs",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/engineconfigs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEngineConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取引擎配置列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEngineConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEngineConfigsResponse
        /// </returns>
        public ListEngineConfigsResponse ListEngineConfigs(ListEngineConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEngineConfigsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取引擎配置列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEngineConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEngineConfigsResponse
        /// </returns>
        public async Task<ListEngineConfigsResponse> ListEngineConfigsAsync(ListEngineConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEngineConfigsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验组列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExperimentGroupsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExperimentGroupsResponse
        /// </returns>
        public ListExperimentGroupsResponse ListExperimentGroupsWithOptions(ListExperimentGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayerId))
            {
                query["LayerId"] = request.LayerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeEnd))
            {
                query["TimeRangeEnd"] = request.TimeRangeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeStart))
            {
                query["TimeRangeStart"] = request.TimeRangeStart;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExperimentGroups",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentgroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExperimentGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验组列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExperimentGroupsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExperimentGroupsResponse
        /// </returns>
        public async Task<ListExperimentGroupsResponse> ListExperimentGroupsWithOptionsAsync(ListExperimentGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayerId))
            {
                query["LayerId"] = request.LayerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeEnd))
            {
                query["TimeRangeEnd"] = request.TimeRangeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeStart))
            {
                query["TimeRangeStart"] = request.TimeRangeStart;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExperimentGroups",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentgroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExperimentGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验组列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExperimentGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExperimentGroupsResponse
        /// </returns>
        public ListExperimentGroupsResponse ListExperimentGroups(ListExperimentGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListExperimentGroupsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验组列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExperimentGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExperimentGroupsResponse
        /// </returns>
        public async Task<ListExperimentGroupsResponse> ListExperimentGroupsAsync(ListExperimentGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListExperimentGroupsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExperimentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExperimentsResponse
        /// </returns>
        public ListExperimentsResponse ListExperimentsWithOptions(ListExperimentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentGroupId))
            {
                query["ExperimentGroupId"] = request.ExperimentGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExperiments",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExperimentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExperimentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExperimentsResponse
        /// </returns>
        public async Task<ListExperimentsResponse> ListExperimentsWithOptionsAsync(ListExperimentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentGroupId))
            {
                query["ExperimentGroupId"] = request.ExperimentGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExperiments",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExperimentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExperimentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExperimentsResponse
        /// </returns>
        public ListExperimentsResponse ListExperiments(ListExperimentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListExperimentsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExperimentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExperimentsResponse
        /// </returns>
        public async Task<ListExperimentsResponse> ListExperimentsAsync(ListExperimentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListExperimentsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检查配置列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFeatureConsistencyCheckJobConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFeatureConsistencyCheckJobConfigsResponse
        /// </returns>
        public ListFeatureConsistencyCheckJobConfigsResponse ListFeatureConsistencyCheckJobConfigsWithOptions(ListFeatureConsistencyCheckJobConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFeatureConsistencyCheckJobConfigs",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobconfigs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeatureConsistencyCheckJobConfigsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检查配置列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFeatureConsistencyCheckJobConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFeatureConsistencyCheckJobConfigsResponse
        /// </returns>
        public async Task<ListFeatureConsistencyCheckJobConfigsResponse> ListFeatureConsistencyCheckJobConfigsWithOptionsAsync(ListFeatureConsistencyCheckJobConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFeatureConsistencyCheckJobConfigs",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobconfigs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeatureConsistencyCheckJobConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检查配置列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFeatureConsistencyCheckJobConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFeatureConsistencyCheckJobConfigsResponse
        /// </returns>
        public ListFeatureConsistencyCheckJobConfigsResponse ListFeatureConsistencyCheckJobConfigs(ListFeatureConsistencyCheckJobConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFeatureConsistencyCheckJobConfigsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检查配置列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFeatureConsistencyCheckJobConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFeatureConsistencyCheckJobConfigsResponse
        /// </returns>
        public async Task<ListFeatureConsistencyCheckJobConfigsResponse> ListFeatureConsistencyCheckJobConfigsAsync(ListFeatureConsistencyCheckJobConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFeatureConsistencyCheckJobConfigsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检查任务的特征报表/比对结果。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFeatureConsistencyCheckJobFeatureReportsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFeatureConsistencyCheckJobFeatureReportsResponse
        /// </returns>
        public ListFeatureConsistencyCheckJobFeatureReportsResponse ListFeatureConsistencyCheckJobFeatureReportsWithOptions(string FeatureConsistencyCheckJobId, ListFeatureConsistencyCheckJobFeatureReportsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogItemId))
            {
                query["LogItemId"] = request.LogItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRequestId))
            {
                query["LogRequestId"] = request.LogRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                query["LogUserId"] = request.LogUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFeatureConsistencyCheckJobFeatureReports",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureConsistencyCheckJobId) + "/featurereports",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeatureConsistencyCheckJobFeatureReportsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检查任务的特征报表/比对结果。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFeatureConsistencyCheckJobFeatureReportsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFeatureConsistencyCheckJobFeatureReportsResponse
        /// </returns>
        public async Task<ListFeatureConsistencyCheckJobFeatureReportsResponse> ListFeatureConsistencyCheckJobFeatureReportsWithOptionsAsync(string FeatureConsistencyCheckJobId, ListFeatureConsistencyCheckJobFeatureReportsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogItemId))
            {
                query["LogItemId"] = request.LogItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRequestId))
            {
                query["LogRequestId"] = request.LogRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                query["LogUserId"] = request.LogUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFeatureConsistencyCheckJobFeatureReports",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureConsistencyCheckJobId) + "/featurereports",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeatureConsistencyCheckJobFeatureReportsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检查任务的特征报表/比对结果。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFeatureConsistencyCheckJobFeatureReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFeatureConsistencyCheckJobFeatureReportsResponse
        /// </returns>
        public ListFeatureConsistencyCheckJobFeatureReportsResponse ListFeatureConsistencyCheckJobFeatureReports(string FeatureConsistencyCheckJobId, ListFeatureConsistencyCheckJobFeatureReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFeatureConsistencyCheckJobFeatureReportsWithOptions(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检查任务的特征报表/比对结果。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFeatureConsistencyCheckJobFeatureReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFeatureConsistencyCheckJobFeatureReportsResponse
        /// </returns>
        public async Task<ListFeatureConsistencyCheckJobFeatureReportsResponse> ListFeatureConsistencyCheckJobFeatureReportsAsync(string FeatureConsistencyCheckJobId, ListFeatureConsistencyCheckJobFeatureReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFeatureConsistencyCheckJobFeatureReportsWithOptionsAsync(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检查任务分数报表/比对结果。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListFeatureConsistencyCheckJobScoreReportsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFeatureConsistencyCheckJobScoreReportsResponse
        /// </returns>
        public ListFeatureConsistencyCheckJobScoreReportsResponse ListFeatureConsistencyCheckJobScoreReportsWithOptions(string FeatureConsistencyCheckJobId, ListFeatureConsistencyCheckJobScoreReportsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListFeatureConsistencyCheckJobScoreReportsShrinkRequest request = new ListFeatureConsistencyCheckJobScoreReportsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExcludeRequestIds))
            {
                request.ExcludeRequestIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExcludeRequestIds, "ExcludeRequestIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeRequestIdsShrink))
            {
                query["ExcludeRequestIds"] = request.ExcludeRequestIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFeatureConsistencyCheckJobScoreReports",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureConsistencyCheckJobId) + "/scorereports",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeatureConsistencyCheckJobScoreReportsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检查任务分数报表/比对结果。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListFeatureConsistencyCheckJobScoreReportsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFeatureConsistencyCheckJobScoreReportsResponse
        /// </returns>
        public async Task<ListFeatureConsistencyCheckJobScoreReportsResponse> ListFeatureConsistencyCheckJobScoreReportsWithOptionsAsync(string FeatureConsistencyCheckJobId, ListFeatureConsistencyCheckJobScoreReportsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListFeatureConsistencyCheckJobScoreReportsShrinkRequest request = new ListFeatureConsistencyCheckJobScoreReportsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExcludeRequestIds))
            {
                request.ExcludeRequestIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExcludeRequestIds, "ExcludeRequestIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeRequestIdsShrink))
            {
                query["ExcludeRequestIds"] = request.ExcludeRequestIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFeatureConsistencyCheckJobScoreReports",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureConsistencyCheckJobId) + "/scorereports",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeatureConsistencyCheckJobScoreReportsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检查任务分数报表/比对结果。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFeatureConsistencyCheckJobScoreReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFeatureConsistencyCheckJobScoreReportsResponse
        /// </returns>
        public ListFeatureConsistencyCheckJobScoreReportsResponse ListFeatureConsistencyCheckJobScoreReports(string FeatureConsistencyCheckJobId, ListFeatureConsistencyCheckJobScoreReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFeatureConsistencyCheckJobScoreReportsWithOptions(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检查任务分数报表/比对结果。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFeatureConsistencyCheckJobScoreReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFeatureConsistencyCheckJobScoreReportsResponse
        /// </returns>
        public async Task<ListFeatureConsistencyCheckJobScoreReportsResponse> ListFeatureConsistencyCheckJobScoreReportsAsync(string FeatureConsistencyCheckJobId, ListFeatureConsistencyCheckJobScoreReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFeatureConsistencyCheckJobScoreReportsWithOptionsAsync(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检查任务列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFeatureConsistencyCheckJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFeatureConsistencyCheckJobsResponse
        /// </returns>
        public ListFeatureConsistencyCheckJobsResponse ListFeatureConsistencyCheckJobsWithOptions(ListFeatureConsistencyCheckJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFeatureConsistencyCheckJobs",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeatureConsistencyCheckJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检查任务列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFeatureConsistencyCheckJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFeatureConsistencyCheckJobsResponse
        /// </returns>
        public async Task<ListFeatureConsistencyCheckJobsResponse> ListFeatureConsistencyCheckJobsWithOptionsAsync(ListFeatureConsistencyCheckJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFeatureConsistencyCheckJobs",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFeatureConsistencyCheckJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检查任务列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFeatureConsistencyCheckJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFeatureConsistencyCheckJobsResponse
        /// </returns>
        public ListFeatureConsistencyCheckJobsResponse ListFeatureConsistencyCheckJobs(ListFeatureConsistencyCheckJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFeatureConsistencyCheckJobsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取特征一致性检查任务列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFeatureConsistencyCheckJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFeatureConsistencyCheckJobsResponse
        /// </returns>
        public async Task<ListFeatureConsistencyCheckJobsResponse> ListFeatureConsistencyCheckJobsAsync(ListFeatureConsistencyCheckJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFeatureConsistencyCheckJobsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实例下配置的资源列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceResourcesResponse
        /// </returns>
        public ListInstanceResourcesResponse ListInstanceResourcesWithOptions(string InstanceId, ListInstanceResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["Group"] = request.Group;
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
                Action = "ListInstanceResources",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/resources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实例下配置的资源列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceResourcesResponse
        /// </returns>
        public async Task<ListInstanceResourcesResponse> ListInstanceResourcesWithOptionsAsync(string InstanceId, ListInstanceResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["Group"] = request.Group;
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
                Action = "ListInstanceResources",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/resources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实例下配置的资源列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceResourcesResponse
        /// </returns>
        public ListInstanceResourcesResponse ListInstanceResources(string InstanceId, ListInstanceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstanceResourcesWithOptions(InstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实例下配置的资源列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceResourcesResponse
        /// </returns>
        public async Task<ListInstanceResourcesResponse> ListInstanceResourcesAsync(string InstanceId, ListInstanceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstanceResourcesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取推荐全链路深度定制开发平台实例信息列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
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
                Action = "ListInstances",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取推荐全链路深度定制开发平台实例信息列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
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
                Action = "ListInstances",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取推荐全链路深度定制开发平台实例信息列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstancesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取推荐全链路深度定制开发平台实例信息列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstancesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验室列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLaboratoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLaboratoriesResponse
        /// </returns>
        public ListLaboratoriesResponse ListLaboratoriesWithOptions(ListLaboratoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLaboratories",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/laboratories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLaboratoriesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验室列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLaboratoriesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLaboratoriesResponse
        /// </returns>
        public async Task<ListLaboratoriesResponse> ListLaboratoriesWithOptionsAsync(ListLaboratoriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLaboratories",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/laboratories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLaboratoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验室列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLaboratoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLaboratoriesResponse
        /// </returns>
        public ListLaboratoriesResponse ListLaboratories(ListLaboratoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLaboratoriesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验室列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLaboratoriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLaboratoriesResponse
        /// </returns>
        public async Task<ListLaboratoriesResponse> ListLaboratoriesAsync(ListLaboratoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLaboratoriesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取层列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLayersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLayersResponse
        /// </returns>
        public ListLayersResponse ListLayersWithOptions(ListLayersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaboratoryId))
            {
                query["LaboratoryId"] = request.LaboratoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLayers",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/layers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLayersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取层列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLayersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLayersResponse
        /// </returns>
        public async Task<ListLayersResponse> ListLayersWithOptionsAsync(ListLayersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaboratoryId))
            {
                query["LaboratoryId"] = request.LaboratoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLayers",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/layers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLayersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取层列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLayersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLayersResponse
        /// </returns>
        public ListLayersResponse ListLayers(ListLayersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLayersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取层列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLayersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLayersResponse
        /// </returns>
        public async Task<ListLayersResponse> ListLayersAsync(ListLayersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLayersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取参数列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListParamsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListParamsResponse
        /// </returns>
        public ListParamsResponse ListParamsWithOptions(ListParamsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListParams",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/params",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListParamsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取参数列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListParamsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListParamsResponse
        /// </returns>
        public async Task<ListParamsResponse> ListParamsWithOptionsAsync(ListParamsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListParams",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/params",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListParamsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取参数列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListParamsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListParamsResponse
        /// </returns>
        public ListParamsResponse ListParams(ListParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListParamsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取参数列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListParamsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListParamsResponse
        /// </returns>
        public async Task<ListParamsResponse> ListParamsAsync(ListParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListParamsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取资源规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceRulesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceRulesResponse
        /// </returns>
        public ListResourceRulesResponse ListResourceRulesWithOptions(ListResourceRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRuleId))
            {
                query["ResourceRuleId"] = request.ResourceRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRuleName))
            {
                query["ResourceRuleName"] = request.ResourceRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceRules",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resourcerules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取资源规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceRulesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceRulesResponse
        /// </returns>
        public async Task<ListResourceRulesResponse> ListResourceRulesWithOptionsAsync(ListResourceRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRuleId))
            {
                query["ResourceRuleId"] = request.ResourceRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRuleName))
            {
                query["ResourceRuleName"] = request.ResourceRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceRules",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resourcerules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取资源规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceRulesResponse
        /// </returns>
        public ListResourceRulesResponse ListResourceRules(ListResourceRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListResourceRulesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取资源规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceRulesResponse
        /// </returns>
        public async Task<ListResourceRulesResponse> ListResourceRulesAsync(ListResourceRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListResourceRulesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScenesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScenesResponse
        /// </returns>
        public ListScenesResponse ListScenesWithOptions(ListScenesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScenes",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/scenes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScenesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScenesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScenesResponse
        /// </returns>
        public async Task<ListScenesResponse> ListScenesWithOptionsAsync(ListScenesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScenes",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/scenes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScenesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScenesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScenesResponse
        /// </returns>
        public ListScenesResponse ListScenes(ListScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListScenesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取场景列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScenesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScenesResponse
        /// </returns>
        public async Task<ListScenesResponse> ListScenesAsync(ListScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListScenesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取人群下的所有子人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubCrowdsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSubCrowdsResponse
        /// </returns>
        public ListSubCrowdsResponse ListSubCrowdsWithOptions(string CrowdId, ListSubCrowdsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubCrowds",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CrowdId) + "/subcrowds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubCrowdsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取人群下的所有子人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubCrowdsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSubCrowdsResponse
        /// </returns>
        public async Task<ListSubCrowdsResponse> ListSubCrowdsWithOptionsAsync(string CrowdId, ListSubCrowdsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubCrowds",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CrowdId) + "/subcrowds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubCrowdsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取人群下的所有子人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubCrowdsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSubCrowdsResponse
        /// </returns>
        public ListSubCrowdsResponse ListSubCrowds(string CrowdId, ListSubCrowdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSubCrowdsWithOptions(CrowdId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取人群下的所有子人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubCrowdsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSubCrowdsResponse
        /// </returns>
        public async Task<ListSubCrowdsResponse> ListSubCrowdsAsync(string CrowdId, ListSubCrowdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSubCrowdsWithOptionsAsync(CrowdId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据表列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTableMetasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTableMetasResponse
        /// </returns>
        public ListTableMetasResponse ListTableMetasWithOptions(ListTableMetasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Module))
            {
                query["Module"] = request.Module;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListTableMetas",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tablemetas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTableMetasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据表列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTableMetasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTableMetasResponse
        /// </returns>
        public async Task<ListTableMetasResponse> ListTableMetasWithOptionsAsync(ListTableMetasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Module))
            {
                query["Module"] = request.Module;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListTableMetas",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tablemetas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTableMetasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据表列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTableMetasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTableMetasResponse
        /// </returns>
        public ListTableMetasResponse ListTableMetas(ListTableMetasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTableMetasWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据表列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTableMetasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTableMetasResponse
        /// </returns>
        public async Task<ListTableMetasResponse> ListTableMetasAsync(ListTableMetasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTableMetasWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流量调控任务流量变更的历史列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTrafficControlTargetTrafficHistoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTrafficControlTargetTrafficHistoryResponse
        /// </returns>
        public ListTrafficControlTargetTrafficHistoryResponse ListTrafficControlTargetTrafficHistoryWithOptions(string TrafficControlTargetId, ListTrafficControlTargetTrafficHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentGroupId))
            {
                query["ExperimentGroupId"] = request.ExperimentGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentId))
            {
                query["ExperimentId"] = request.ExperimentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrafficControlTargetTrafficHistory",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltargets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTargetId) + "/traffichistories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrafficControlTargetTrafficHistoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流量调控任务流量变更的历史列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTrafficControlTargetTrafficHistoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTrafficControlTargetTrafficHistoryResponse
        /// </returns>
        public async Task<ListTrafficControlTargetTrafficHistoryResponse> ListTrafficControlTargetTrafficHistoryWithOptionsAsync(string TrafficControlTargetId, ListTrafficControlTargetTrafficHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentGroupId))
            {
                query["ExperimentGroupId"] = request.ExperimentGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentId))
            {
                query["ExperimentId"] = request.ExperimentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrafficControlTargetTrafficHistory",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltargets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTargetId) + "/traffichistories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrafficControlTargetTrafficHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流量调控任务流量变更的历史列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTrafficControlTargetTrafficHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTrafficControlTargetTrafficHistoryResponse
        /// </returns>
        public ListTrafficControlTargetTrafficHistoryResponse ListTrafficControlTargetTrafficHistory(string TrafficControlTargetId, ListTrafficControlTargetTrafficHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTrafficControlTargetTrafficHistoryWithOptions(TrafficControlTargetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流量调控任务流量变更的历史列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTrafficControlTargetTrafficHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTrafficControlTargetTrafficHistoryResponse
        /// </returns>
        public async Task<ListTrafficControlTargetTrafficHistoryResponse> ListTrafficControlTargetTrafficHistoryAsync(string TrafficControlTargetId, ListTrafficControlTargetTrafficHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTrafficControlTargetTrafficHistoryWithOptionsAsync(TrafficControlTargetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流量调控列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTrafficControlTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTrafficControlTasksResponse
        /// </returns>
        public ListTrafficControlTasksResponse ListTrafficControlTasksWithOptions(ListTrafficControlTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlTargetFilter))
            {
                query["ControlTargetFilter"] = request.ControlTargetFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficControlTaskId))
            {
                query["TrafficControlTaskId"] = request.TrafficControlTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["Version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrafficControlTasks",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrafficControlTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流量调控列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTrafficControlTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTrafficControlTasksResponse
        /// </returns>
        public async Task<ListTrafficControlTasksResponse> ListTrafficControlTasksWithOptionsAsync(ListTrafficControlTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlTargetFilter))
            {
                query["ControlTargetFilter"] = request.ControlTargetFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                query["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficControlTaskId))
            {
                query["TrafficControlTaskId"] = request.TrafficControlTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["Version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrafficControlTasks",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrafficControlTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流量调控列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTrafficControlTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTrafficControlTasksResponse
        /// </returns>
        public ListTrafficControlTasksResponse ListTrafficControlTasks(ListTrafficControlTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTrafficControlTasksWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流量调控列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTrafficControlTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTrafficControlTasksResponse
        /// </returns>
        public async Task<ListTrafficControlTasksResponse> ListTrafficControlTasksAsync(ListTrafficControlTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTrafficControlTasksWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线实验。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OfflineExperimentResponse
        /// </returns>
        public OfflineExperimentResponse OfflineExperimentWithOptions(string ExperimentId, OfflineExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OfflineExperiment",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/action/offline",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线实验。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OfflineExperimentResponse
        /// </returns>
        public async Task<OfflineExperimentResponse> OfflineExperimentWithOptionsAsync(string ExperimentId, OfflineExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OfflineExperiment",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/action/offline",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线实验。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// OfflineExperimentResponse
        /// </returns>
        public OfflineExperimentResponse OfflineExperiment(string ExperimentId, OfflineExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OfflineExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线实验。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// OfflineExperimentResponse
        /// </returns>
        public async Task<OfflineExperimentResponse> OfflineExperimentAsync(string ExperimentId, OfflineExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OfflineExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线实验组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineExperimentGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OfflineExperimentGroupResponse
        /// </returns>
        public OfflineExperimentGroupResponse OfflineExperimentGroupWithOptions(string ExperimentGroupId, OfflineExperimentGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OfflineExperimentGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentGroupId) + "/action/offline",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineExperimentGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线实验组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineExperimentGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OfflineExperimentGroupResponse
        /// </returns>
        public async Task<OfflineExperimentGroupResponse> OfflineExperimentGroupWithOptionsAsync(string ExperimentGroupId, OfflineExperimentGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OfflineExperimentGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentGroupId) + "/action/offline",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineExperimentGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线实验组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineExperimentGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// OfflineExperimentGroupResponse
        /// </returns>
        public OfflineExperimentGroupResponse OfflineExperimentGroup(string ExperimentGroupId, OfflineExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OfflineExperimentGroupWithOptions(ExperimentGroupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线实验组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineExperimentGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// OfflineExperimentGroupResponse
        /// </returns>
        public async Task<OfflineExperimentGroupResponse> OfflineExperimentGroupAsync(string ExperimentGroupId, OfflineExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OfflineExperimentGroupWithOptionsAsync(ExperimentGroupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线实验室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineLaboratoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OfflineLaboratoryResponse
        /// </returns>
        public OfflineLaboratoryResponse OfflineLaboratoryWithOptions(string LaboratoryId, OfflineLaboratoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OfflineLaboratory",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/laboratories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LaboratoryId) + "/action/offline",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineLaboratoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线实验室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineLaboratoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OfflineLaboratoryResponse
        /// </returns>
        public async Task<OfflineLaboratoryResponse> OfflineLaboratoryWithOptionsAsync(string LaboratoryId, OfflineLaboratoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OfflineLaboratory",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/laboratories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LaboratoryId) + "/action/offline",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineLaboratoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线实验室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineLaboratoryRequest
        /// </param>
        /// 
        /// <returns>
        /// OfflineLaboratoryResponse
        /// </returns>
        public OfflineLaboratoryResponse OfflineLaboratory(string LaboratoryId, OfflineLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OfflineLaboratoryWithOptions(LaboratoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线实验室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineLaboratoryRequest
        /// </param>
        /// 
        /// <returns>
        /// OfflineLaboratoryResponse
        /// </returns>
        public async Task<OfflineLaboratoryResponse> OfflineLaboratoryAsync(string LaboratoryId, OfflineLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OfflineLaboratoryWithOptionsAsync(LaboratoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OnlineExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OnlineExperimentResponse
        /// </returns>
        public OnlineExperimentResponse OnlineExperimentWithOptions(string ExperimentId, OnlineExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnlineExperiment",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/action/online",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnlineExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OnlineExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OnlineExperimentResponse
        /// </returns>
        public async Task<OnlineExperimentResponse> OnlineExperimentWithOptionsAsync(string ExperimentId, OnlineExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnlineExperiment",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/action/online",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnlineExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OnlineExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// OnlineExperimentResponse
        /// </returns>
        public OnlineExperimentResponse OnlineExperiment(string ExperimentId, OnlineExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OnlineExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OnlineExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// OnlineExperimentResponse
        /// </returns>
        public async Task<OnlineExperimentResponse> OnlineExperimentAsync(string ExperimentId, OnlineExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OnlineExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线实验组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OnlineExperimentGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OnlineExperimentGroupResponse
        /// </returns>
        public OnlineExperimentGroupResponse OnlineExperimentGroupWithOptions(string ExperimentGroupId, OnlineExperimentGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnlineExperimentGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentGroupId) + "/action/online",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnlineExperimentGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线实验组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OnlineExperimentGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OnlineExperimentGroupResponse
        /// </returns>
        public async Task<OnlineExperimentGroupResponse> OnlineExperimentGroupWithOptionsAsync(string ExperimentGroupId, OnlineExperimentGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnlineExperimentGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentGroupId) + "/action/online",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnlineExperimentGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线实验组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OnlineExperimentGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// OnlineExperimentGroupResponse
        /// </returns>
        public OnlineExperimentGroupResponse OnlineExperimentGroup(string ExperimentGroupId, OnlineExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OnlineExperimentGroupWithOptions(ExperimentGroupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线实验组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OnlineExperimentGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// OnlineExperimentGroupResponse
        /// </returns>
        public async Task<OnlineExperimentGroupResponse> OnlineExperimentGroupAsync(string ExperimentGroupId, OnlineExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OnlineExperimentGroupWithOptionsAsync(ExperimentGroupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线实验室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OnlineLaboratoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OnlineLaboratoryResponse
        /// </returns>
        public OnlineLaboratoryResponse OnlineLaboratoryWithOptions(string LaboratoryId, OnlineLaboratoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnlineLaboratory",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/laboratories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LaboratoryId) + "/action/online",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnlineLaboratoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线实验室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OnlineLaboratoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OnlineLaboratoryResponse
        /// </returns>
        public async Task<OnlineLaboratoryResponse> OnlineLaboratoryWithOptionsAsync(string LaboratoryId, OnlineLaboratoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnlineLaboratory",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/laboratories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LaboratoryId) + "/action/online",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnlineLaboratoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线实验室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OnlineLaboratoryRequest
        /// </param>
        /// 
        /// <returns>
        /// OnlineLaboratoryResponse
        /// </returns>
        public OnlineLaboratoryResponse OnlineLaboratory(string LaboratoryId, OnlineLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OnlineLaboratoryWithOptions(LaboratoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线实验室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OnlineLaboratoryRequest
        /// </param>
        /// 
        /// <returns>
        /// OnlineLaboratoryResponse
        /// </returns>
        public async Task<OnlineLaboratoryResponse> OnlineLaboratoryAsync(string LaboratoryId, OnlineLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OnlineLaboratoryWithOptionsAsync(LaboratoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推全。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushAllExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushAllExperimentResponse
        /// </returns>
        public PushAllExperimentResponse PushAllExperimentWithOptions(string ExperimentId, PushAllExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushAllExperiment",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/action/pushall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushAllExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推全。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushAllExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushAllExperimentResponse
        /// </returns>
        public async Task<PushAllExperimentResponse> PushAllExperimentWithOptionsAsync(string ExperimentId, PushAllExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushAllExperiment",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/action/pushall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushAllExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推全。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushAllExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// PushAllExperimentResponse
        /// </returns>
        public PushAllExperimentResponse PushAllExperiment(string ExperimentId, PushAllExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PushAllExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推全。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushAllExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// PushAllExperimentResponse
        /// </returns>
        public async Task<PushAllExperimentResponse> PushAllExperimentAsync(string ExperimentId, PushAllExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PushAllExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送指标到指定资源规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PushResourceRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushResourceRuleResponse
        /// </returns>
        public PushResourceRuleResponse PushResourceRuleWithOptions(string ResourceRuleId, PushResourceRuleRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushResourceRuleShrinkRequest request = new PushResourceRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MetricInfo))
            {
                request.MetricInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MetricInfo, "MetricInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricInfoShrink))
            {
                query["MetricInfo"] = request.MetricInfoShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushResourceRule",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resourcerules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceRuleId) + "/action/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushResourceRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送指标到指定资源规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PushResourceRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushResourceRuleResponse
        /// </returns>
        public async Task<PushResourceRuleResponse> PushResourceRuleWithOptionsAsync(string ResourceRuleId, PushResourceRuleRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushResourceRuleShrinkRequest request = new PushResourceRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MetricInfo))
            {
                request.MetricInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MetricInfo, "MetricInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricInfoShrink))
            {
                query["MetricInfo"] = request.MetricInfoShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushResourceRule",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resourcerules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceRuleId) + "/action/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushResourceRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送指标到指定资源规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushResourceRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// PushResourceRuleResponse
        /// </returns>
        public PushResourceRuleResponse PushResourceRule(string ResourceRuleId, PushResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PushResourceRuleWithOptions(ResourceRuleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送指标到指定资源规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushResourceRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// PushResourceRuleResponse
        /// </returns>
        public async Task<PushResourceRuleResponse> PushResourceRuleAsync(string ResourceRuleId, PushResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PushResourceRuleWithOptionsAsync(ResourceRuleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseTrafficControlTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseTrafficControlTaskResponse
        /// </returns>
        public ReleaseTrafficControlTaskResponse ReleaseTrafficControlTaskWithOptions(string TrafficControlTaskId, ReleaseTrafficControlTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseTrafficControlTask",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId) + "/action/release",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseTrafficControlTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseTrafficControlTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseTrafficControlTaskResponse
        /// </returns>
        public async Task<ReleaseTrafficControlTaskResponse> ReleaseTrafficControlTaskWithOptionsAsync(string TrafficControlTaskId, ReleaseTrafficControlTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseTrafficControlTask",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId) + "/action/release",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseTrafficControlTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseTrafficControlTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseTrafficControlTaskResponse
        /// </returns>
        public ReleaseTrafficControlTaskResponse ReleaseTrafficControlTask(string TrafficControlTaskId, ReleaseTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReleaseTrafficControlTaskWithOptions(TrafficControlTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseTrafficControlTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseTrafficControlTaskResponse
        /// </returns>
        public async Task<ReleaseTrafficControlTaskResponse> ReleaseTrafficControlTaskAsync(string TrafficControlTaskId, ReleaseTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReleaseTrafficControlTaskWithOptionsAsync(TrafficControlTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对指标组进行报表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReportABMetricGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReportABMetricGroupResponse
        /// </returns>
        public ReportABMetricGroupResponse ReportABMetricGroupWithOptions(string ABMetricGroupId, ReportABMetricGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseExperimentId))
            {
                body["BaseExperimentId"] = request.BaseExperimentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DimensionFields))
            {
                body["DimensionFields"] = request.DimensionFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentGroupId))
            {
                body["ExperimentGroupId"] = request.ExperimentGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentIds))
            {
                body["ExperimentIds"] = request.ExperimentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                body["ReportType"] = request.ReportType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStatisticsMethod))
            {
                body["TimeStatisticsMethod"] = request.TimeStatisticsMethod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportABMetricGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/abmetricgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ABMetricGroupId) + "/action/report",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportABMetricGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对指标组进行报表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReportABMetricGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReportABMetricGroupResponse
        /// </returns>
        public async Task<ReportABMetricGroupResponse> ReportABMetricGroupWithOptionsAsync(string ABMetricGroupId, ReportABMetricGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseExperimentId))
            {
                body["BaseExperimentId"] = request.BaseExperimentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DimensionFields))
            {
                body["DimensionFields"] = request.DimensionFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentGroupId))
            {
                body["ExperimentGroupId"] = request.ExperimentGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentIds))
            {
                body["ExperimentIds"] = request.ExperimentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                body["ReportType"] = request.ReportType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStatisticsMethod))
            {
                body["TimeStatisticsMethod"] = request.TimeStatisticsMethod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportABMetricGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/abmetricgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ABMetricGroupId) + "/action/report",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportABMetricGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对指标组进行报表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReportABMetricGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ReportABMetricGroupResponse
        /// </returns>
        public ReportABMetricGroupResponse ReportABMetricGroup(string ABMetricGroupId, ReportABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReportABMetricGroupWithOptions(ABMetricGroupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>对指标组进行报表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReportABMetricGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ReportABMetricGroupResponse
        /// </returns>
        public async Task<ReportABMetricGroupResponse> ReportABMetricGroupAsync(string ABMetricGroupId, ReportABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReportABMetricGroupWithOptionsAsync(ABMetricGroupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拆分流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SplitTrafficControlTargetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SplitTrafficControlTargetResponse
        /// </returns>
        public SplitTrafficControlTargetResponse SplitTrafficControlTargetWithOptions(string TrafficControlTargetId, SplitTrafficControlTargetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetPoints))
            {
                body["SetPoints"] = request.SetPoints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetValues))
            {
                body["SetValues"] = request.SetValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePoints))
            {
                body["TimePoints"] = request.TimePoints;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SplitTrafficControlTarget",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltargets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTargetId) + "/action/split",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SplitTrafficControlTargetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拆分流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SplitTrafficControlTargetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SplitTrafficControlTargetResponse
        /// </returns>
        public async Task<SplitTrafficControlTargetResponse> SplitTrafficControlTargetWithOptionsAsync(string TrafficControlTargetId, SplitTrafficControlTargetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetPoints))
            {
                body["SetPoints"] = request.SetPoints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetValues))
            {
                body["SetValues"] = request.SetValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePoints))
            {
                body["TimePoints"] = request.TimePoints;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SplitTrafficControlTarget",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltargets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTargetId) + "/action/split",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SplitTrafficControlTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拆分流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SplitTrafficControlTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// SplitTrafficControlTargetResponse
        /// </returns>
        public SplitTrafficControlTargetResponse SplitTrafficControlTarget(string TrafficControlTargetId, SplitTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SplitTrafficControlTargetWithOptions(TrafficControlTargetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拆分流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SplitTrafficControlTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// SplitTrafficControlTargetResponse
        /// </returns>
        public async Task<SplitTrafficControlTargetResponse> SplitTrafficControlTargetAsync(string TrafficControlTargetId, SplitTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SplitTrafficControlTargetWithOptionsAsync(TrafficControlTargetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTrafficControlTargetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartTrafficControlTargetResponse
        /// </returns>
        public StartTrafficControlTargetResponse StartTrafficControlTargetWithOptions(string TrafficControlTargetId, StartTrafficControlTargetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartTrafficControlTarget",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltargets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTargetId) + "/action/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartTrafficControlTargetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTrafficControlTargetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartTrafficControlTargetResponse
        /// </returns>
        public async Task<StartTrafficControlTargetResponse> StartTrafficControlTargetWithOptionsAsync(string TrafficControlTargetId, StartTrafficControlTargetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartTrafficControlTarget",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltargets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTargetId) + "/action/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartTrafficControlTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTrafficControlTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// StartTrafficControlTargetResponse
        /// </returns>
        public StartTrafficControlTargetResponse StartTrafficControlTarget(string TrafficControlTargetId, StartTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartTrafficControlTargetWithOptions(TrafficControlTargetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTrafficControlTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// StartTrafficControlTargetResponse
        /// </returns>
        public async Task<StartTrafficControlTargetResponse> StartTrafficControlTargetAsync(string TrafficControlTargetId, StartTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartTrafficControlTargetWithOptionsAsync(TrafficControlTargetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTrafficControlTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartTrafficControlTaskResponse
        /// </returns>
        public StartTrafficControlTaskResponse StartTrafficControlTaskWithOptions(string TrafficControlTaskId, StartTrafficControlTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartTrafficControlTask",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId) + "/action/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartTrafficControlTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTrafficControlTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartTrafficControlTaskResponse
        /// </returns>
        public async Task<StartTrafficControlTaskResponse> StartTrafficControlTaskWithOptionsAsync(string TrafficControlTaskId, StartTrafficControlTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartTrafficControlTask",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId) + "/action/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartTrafficControlTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTrafficControlTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StartTrafficControlTaskResponse
        /// </returns>
        public StartTrafficControlTaskResponse StartTrafficControlTask(string TrafficControlTaskId, StartTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartTrafficControlTaskWithOptions(TrafficControlTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTrafficControlTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StartTrafficControlTaskResponse
        /// </returns>
        public async Task<StartTrafficControlTaskResponse> StartTrafficControlTaskAsync(string TrafficControlTaskId, StartTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartTrafficControlTaskWithOptionsAsync(TrafficControlTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopTrafficControlTargetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopTrafficControlTargetResponse
        /// </returns>
        public StopTrafficControlTargetResponse StopTrafficControlTargetWithOptions(string TrafficControlTargetId, StopTrafficControlTargetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopTrafficControlTarget",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltargets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTargetId) + "/action/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopTrafficControlTargetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopTrafficControlTargetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopTrafficControlTargetResponse
        /// </returns>
        public async Task<StopTrafficControlTargetResponse> StopTrafficControlTargetWithOptionsAsync(string TrafficControlTargetId, StopTrafficControlTargetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopTrafficControlTarget",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltargets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTargetId) + "/action/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopTrafficControlTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopTrafficControlTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// StopTrafficControlTargetResponse
        /// </returns>
        public StopTrafficControlTargetResponse StopTrafficControlTarget(string TrafficControlTargetId, StopTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopTrafficControlTargetWithOptions(TrafficControlTargetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopTrafficControlTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// StopTrafficControlTargetResponse
        /// </returns>
        public async Task<StopTrafficControlTargetResponse> StopTrafficControlTargetAsync(string TrafficControlTargetId, StopTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopTrafficControlTargetWithOptionsAsync(TrafficControlTargetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopTrafficControlTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopTrafficControlTaskResponse
        /// </returns>
        public StopTrafficControlTaskResponse StopTrafficControlTaskWithOptions(string TrafficControlTaskId, StopTrafficControlTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopTrafficControlTask",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId) + "/action/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopTrafficControlTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopTrafficControlTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopTrafficControlTaskResponse
        /// </returns>
        public async Task<StopTrafficControlTaskResponse> StopTrafficControlTaskWithOptionsAsync(string TrafficControlTaskId, StopTrafficControlTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopTrafficControlTask",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId) + "/action/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopTrafficControlTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopTrafficControlTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StopTrafficControlTaskResponse
        /// </returns>
        public StopTrafficControlTaskResponse StopTrafficControlTask(string TrafficControlTaskId, StopTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopTrafficControlTaskWithOptions(TrafficControlTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopTrafficControlTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StopTrafficControlTaskResponse
        /// </returns>
        public async Task<StopTrafficControlTaskResponse> StopTrafficControlTaskAsync(string TrafficControlTaskId, StopTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopTrafficControlTaskWithOptionsAsync(TrafficControlTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步特征一致性检测任务重放日志。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncFeatureConsistencyCheckJobReplayLogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncFeatureConsistencyCheckJobReplayLogResponse
        /// </returns>
        public SyncFeatureConsistencyCheckJobReplayLogResponse SyncFeatureConsistencyCheckJobReplayLogWithOptions(SyncFeatureConsistencyCheckJobReplayLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextFeatures))
            {
                body["ContextFeatures"] = request.ContextFeatures;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureConsistencyCheckJobConfigId))
            {
                body["FeatureConsistencyCheckJobConfigId"] = request.FeatureConsistencyCheckJobConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeneratedFeatures))
            {
                body["GeneratedFeatures"] = request.GeneratedFeatures;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogItemId))
            {
                body["LogItemId"] = request.LogItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRequestId))
            {
                body["LogRequestId"] = request.LogRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRequestTime))
            {
                body["LogRequestTime"] = request.LogRequestTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                body["LogUserId"] = request.LogUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RawFeatures))
            {
                body["RawFeatures"] = request.RawFeatures;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneName))
            {
                body["SceneName"] = request.SceneName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncFeatureConsistencyCheckJobReplayLog",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobs/action/syncreplaylog",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncFeatureConsistencyCheckJobReplayLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步特征一致性检测任务重放日志。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncFeatureConsistencyCheckJobReplayLogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncFeatureConsistencyCheckJobReplayLogResponse
        /// </returns>
        public async Task<SyncFeatureConsistencyCheckJobReplayLogResponse> SyncFeatureConsistencyCheckJobReplayLogWithOptionsAsync(SyncFeatureConsistencyCheckJobReplayLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContextFeatures))
            {
                body["ContextFeatures"] = request.ContextFeatures;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureConsistencyCheckJobConfigId))
            {
                body["FeatureConsistencyCheckJobConfigId"] = request.FeatureConsistencyCheckJobConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeneratedFeatures))
            {
                body["GeneratedFeatures"] = request.GeneratedFeatures;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogItemId))
            {
                body["LogItemId"] = request.LogItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRequestId))
            {
                body["LogRequestId"] = request.LogRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRequestTime))
            {
                body["LogRequestTime"] = request.LogRequestTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogUserId))
            {
                body["LogUserId"] = request.LogUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RawFeatures))
            {
                body["RawFeatures"] = request.RawFeatures;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneName))
            {
                body["SceneName"] = request.SceneName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncFeatureConsistencyCheckJobReplayLog",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobs/action/syncreplaylog",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncFeatureConsistencyCheckJobReplayLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步特征一致性检测任务重放日志。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncFeatureConsistencyCheckJobReplayLogRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncFeatureConsistencyCheckJobReplayLogResponse
        /// </returns>
        public SyncFeatureConsistencyCheckJobReplayLogResponse SyncFeatureConsistencyCheckJobReplayLog(SyncFeatureConsistencyCheckJobReplayLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SyncFeatureConsistencyCheckJobReplayLogWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步特征一致性检测任务重放日志。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncFeatureConsistencyCheckJobReplayLogRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncFeatureConsistencyCheckJobReplayLogResponse
        /// </returns>
        public async Task<SyncFeatureConsistencyCheckJobReplayLogResponse> SyncFeatureConsistencyCheckJobReplayLogAsync(SyncFeatureConsistencyCheckJobReplayLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SyncFeatureConsistencyCheckJobReplayLogWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消指定特征一致性检查正在运行中的任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateFeatureConsistencyCheckJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TerminateFeatureConsistencyCheckJobResponse
        /// </returns>
        public TerminateFeatureConsistencyCheckJobResponse TerminateFeatureConsistencyCheckJobWithOptions(string FeatureConsistencyCheckJobId, TerminateFeatureConsistencyCheckJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TerminateFeatureConsistencyCheckJob",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureConsistencyCheckJobId) + "/action/terminate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TerminateFeatureConsistencyCheckJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消指定特征一致性检查正在运行中的任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateFeatureConsistencyCheckJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TerminateFeatureConsistencyCheckJobResponse
        /// </returns>
        public async Task<TerminateFeatureConsistencyCheckJobResponse> TerminateFeatureConsistencyCheckJobWithOptionsAsync(string FeatureConsistencyCheckJobId, TerminateFeatureConsistencyCheckJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TerminateFeatureConsistencyCheckJob",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureConsistencyCheckJobId) + "/action/terminate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TerminateFeatureConsistencyCheckJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消指定特征一致性检查正在运行中的任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateFeatureConsistencyCheckJobRequest
        /// </param>
        /// 
        /// <returns>
        /// TerminateFeatureConsistencyCheckJobResponse
        /// </returns>
        public TerminateFeatureConsistencyCheckJobResponse TerminateFeatureConsistencyCheckJob(string FeatureConsistencyCheckJobId, TerminateFeatureConsistencyCheckJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TerminateFeatureConsistencyCheckJobWithOptions(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消指定特征一致性检查正在运行中的任务。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TerminateFeatureConsistencyCheckJobRequest
        /// </param>
        /// 
        /// <returns>
        /// TerminateFeatureConsistencyCheckJobResponse
        /// </returns>
        public async Task<TerminateFeatureConsistencyCheckJobResponse> TerminateFeatureConsistencyCheckJobAsync(string FeatureConsistencyCheckJobId, TerminateFeatureConsistencyCheckJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TerminateFeatureConsistencyCheckJobWithOptionsAsync(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新AB Test实验指标。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateABMetricRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateABMetricResponse
        /// </returns>
        public UpdateABMetricResponse UpdateABMetricWithOptions(string ABMetricId, UpdateABMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                body["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeftMetricId))
            {
                body["LeftMetricId"] = request.LeftMetricId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["Operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Realtime))
            {
                body["Realtime"] = request.Realtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultResourceId))
            {
                body["ResultResourceId"] = request.ResultResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightMetricId))
            {
                body["RightMetricId"] = request.RightMetricId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisticsCycle))
            {
                body["StatisticsCycle"] = request.StatisticsCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableMetaId))
            {
                body["TableMetaId"] = request.TableMetaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateABMetric",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/abmetrics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ABMetricId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateABMetricResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新AB Test实验指标。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateABMetricRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateABMetricResponse
        /// </returns>
        public async Task<UpdateABMetricResponse> UpdateABMetricWithOptionsAsync(string ABMetricId, UpdateABMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Definition))
            {
                body["Definition"] = request.Definition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeftMetricId))
            {
                body["LeftMetricId"] = request.LeftMetricId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["Operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Realtime))
            {
                body["Realtime"] = request.Realtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResultResourceId))
            {
                body["ResultResourceId"] = request.ResultResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightMetricId))
            {
                body["RightMetricId"] = request.RightMetricId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisticsCycle))
            {
                body["StatisticsCycle"] = request.StatisticsCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableMetaId))
            {
                body["TableMetaId"] = request.TableMetaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateABMetric",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/abmetrics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ABMetricId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateABMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新AB Test实验指标。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateABMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateABMetricResponse
        /// </returns>
        public UpdateABMetricResponse UpdateABMetric(string ABMetricId, UpdateABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateABMetricWithOptions(ABMetricId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新AB Test实验指标。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateABMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateABMetricResponse
        /// </returns>
        public async Task<UpdateABMetricResponse> UpdateABMetricAsync(string ABMetricId, UpdateABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateABMetricWithOptionsAsync(ABMetricId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新AB test实验指标组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateABMetricGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateABMetricGroupResponse
        /// </returns>
        public UpdateABMetricGroupResponse UpdateABMetricGroupWithOptions(string ABMetricGroupId, UpdateABMetricGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ABMetricIds))
            {
                body["ABMetricIds"] = request.ABMetricIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Realtime))
            {
                body["Realtime"] = request.Realtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateABMetricGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/abmetricgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ABMetricGroupId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateABMetricGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新AB test实验指标组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateABMetricGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateABMetricGroupResponse
        /// </returns>
        public async Task<UpdateABMetricGroupResponse> UpdateABMetricGroupWithOptionsAsync(string ABMetricGroupId, UpdateABMetricGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ABMetricIds))
            {
                body["ABMetricIds"] = request.ABMetricIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Realtime))
            {
                body["Realtime"] = request.Realtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateABMetricGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/abmetricgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ABMetricGroupId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateABMetricGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新AB test实验指标组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateABMetricGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateABMetricGroupResponse
        /// </returns>
        public UpdateABMetricGroupResponse UpdateABMetricGroup(string ABMetricGroupId, UpdateABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateABMetricGroupWithOptions(ABMetricGroupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新AB test实验指标组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateABMetricGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateABMetricGroupResponse
        /// </returns>
        public async Task<UpdateABMetricGroupResponse> UpdateABMetricGroupAsync(string ABMetricGroupId, UpdateABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateABMetricGroupWithOptionsAsync(ABMetricGroupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCrowdRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCrowdResponse
        /// </returns>
        public UpdateCrowdResponse UpdateCrowdWithOptions(string CrowdId, UpdateCrowdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCrowd",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CrowdId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCrowdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCrowdRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCrowdResponse
        /// </returns>
        public async Task<UpdateCrowdResponse> UpdateCrowdWithOptionsAsync(string CrowdId, UpdateCrowdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCrowd",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/crowds/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(CrowdId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCrowdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCrowdRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCrowdResponse
        /// </returns>
        public UpdateCrowdResponse UpdateCrowd(string CrowdId, UpdateCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateCrowdWithOptions(CrowdId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定人群。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCrowdRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCrowdResponse
        /// </returns>
        public async Task<UpdateCrowdResponse> UpdateCrowdAsync(string CrowdId, UpdateCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateCrowdWithOptionsAsync(CrowdId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新引擎配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEngineConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEngineConfigResponse
        /// </returns>
        public UpdateEngineConfigResponse UpdateEngineConfigWithOptions(string EngineConfigId, UpdateEngineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigValue))
            {
                body["ConfigValue"] = request.ConfigValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEngineConfig",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/engineconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(EngineConfigId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEngineConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新引擎配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEngineConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEngineConfigResponse
        /// </returns>
        public async Task<UpdateEngineConfigResponse> UpdateEngineConfigWithOptionsAsync(string EngineConfigId, UpdateEngineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigValue))
            {
                body["ConfigValue"] = request.ConfigValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEngineConfig",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/engineconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(EngineConfigId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEngineConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新引擎配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEngineConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEngineConfigResponse
        /// </returns>
        public UpdateEngineConfigResponse UpdateEngineConfig(string EngineConfigId, UpdateEngineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateEngineConfigWithOptions(EngineConfigId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新引擎配置。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEngineConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEngineConfigResponse
        /// </returns>
        public async Task<UpdateEngineConfigResponse> UpdateEngineConfigAsync(string EngineConfigId, UpdateEngineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateEngineConfigWithOptionsAsync(EngineConfigId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实验。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentResponse
        /// </returns>
        public UpdateExperimentResponse UpdateExperimentWithOptions(string ExperimentId, UpdateExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugCrowdId))
            {
                body["DebugCrowdId"] = request.DebugCrowdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowPercent))
            {
                body["FlowPercent"] = request.FlowPercent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExperiment",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实验。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentResponse
        /// </returns>
        public async Task<UpdateExperimentResponse> UpdateExperimentWithOptionsAsync(string ExperimentId, UpdateExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugCrowdId))
            {
                body["DebugCrowdId"] = request.DebugCrowdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowPercent))
            {
                body["FlowPercent"] = request.FlowPercent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExperiment",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实验。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentResponse
        /// </returns>
        public UpdateExperimentResponse UpdateExperiment(string ExperimentId, UpdateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实验。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentResponse
        /// </returns>
        public async Task<UpdateExperimentResponse> UpdateExperimentAsync(string ExperimentId, UpdateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定实验组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentGroupResponse
        /// </returns>
        public UpdateExperimentGroupResponse UpdateExperimentGroupWithOptions(string ExperimentGroupId, UpdateExperimentGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdId))
            {
                body["CrowdId"] = request.CrowdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdTargetType))
            {
                body["CrowdTargetType"] = request.CrowdTargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugCrowdId))
            {
                body["DebugCrowdId"] = request.DebugCrowdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionTimeDuration))
            {
                body["DistributionTimeDuration"] = request.DistributionTimeDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionType))
            {
                body["DistributionType"] = request.DistributionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                body["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayerId))
            {
                body["LayerId"] = request.LayerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedAA))
            {
                body["NeedAA"] = request.NeedAA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RandomFlow))
            {
                body["RandomFlow"] = request.RandomFlow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservcedBuckets))
            {
                body["ReservcedBuckets"] = request.ReservcedBuckets;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExperimentGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentGroupId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExperimentGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定实验组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentGroupResponse
        /// </returns>
        public async Task<UpdateExperimentGroupResponse> UpdateExperimentGroupWithOptionsAsync(string ExperimentGroupId, UpdateExperimentGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdId))
            {
                body["CrowdId"] = request.CrowdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrowdTargetType))
            {
                body["CrowdTargetType"] = request.CrowdTargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugCrowdId))
            {
                body["DebugCrowdId"] = request.DebugCrowdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionTimeDuration))
            {
                body["DistributionTimeDuration"] = request.DistributionTimeDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DistributionType))
            {
                body["DistributionType"] = request.DistributionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                body["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayerId))
            {
                body["LayerId"] = request.LayerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedAA))
            {
                body["NeedAA"] = request.NeedAA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RandomFlow))
            {
                body["RandomFlow"] = request.RandomFlow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservcedBuckets))
            {
                body["ReservcedBuckets"] = request.ReservcedBuckets;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExperimentGroup",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentgroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentGroupId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExperimentGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定实验组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentGroupResponse
        /// </returns>
        public UpdateExperimentGroupResponse UpdateExperimentGroup(string ExperimentGroupId, UpdateExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateExperimentGroupWithOptions(ExperimentGroupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定实验组。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentGroupResponse
        /// </returns>
        public async Task<UpdateExperimentGroupResponse> UpdateExperimentGroupAsync(string ExperimentGroupId, UpdateExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateExperimentGroupWithOptionsAsync(ExperimentGroupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新特征一致性检查配置信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFeatureConsistencyCheckJobConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFeatureConsistencyCheckJobConfigResponse
        /// </returns>
        public UpdateFeatureConsistencyCheckJobConfigResponse UpdateFeatureConsistencyCheckJobConfigWithOptions(string FeatureConsistencyCheckJobConfigId, UpdateFeatureConsistencyCheckJobConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompareFeature))
            {
                body["CompareFeature"] = request.CompareFeature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EasServiceName))
            {
                body["EasServiceName"] = request.EasServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EasyRecPackagePath))
            {
                body["EasyRecPackagePath"] = request.EasyRecPackagePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EasyRecVersion))
            {
                body["EasyRecVersion"] = request.EasyRecVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureDisplayExclude))
            {
                body["FeatureDisplayExclude"] = request.FeatureDisplayExclude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureLandingResourceId))
            {
                body["FeatureLandingResourceId"] = request.FeatureLandingResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeaturePriority))
            {
                body["FeaturePriority"] = request.FeaturePriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreItemId))
            {
                body["FeatureStoreItemId"] = request.FeatureStoreItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreModelId))
            {
                body["FeatureStoreModelId"] = request.FeatureStoreModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreProjectId))
            {
                body["FeatureStoreProjectId"] = request.FeatureStoreProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreProjectName))
            {
                body["FeatureStoreProjectName"] = request.FeatureStoreProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreSeqFeatureView))
            {
                body["FeatureStoreSeqFeatureView"] = request.FeatureStoreSeqFeatureView;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreUserId))
            {
                body["FeatureStoreUserId"] = request.FeatureStoreUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FgJarVersion))
            {
                body["FgJarVersion"] = request.FgJarVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FgJsonFileName))
            {
                body["FgJsonFileName"] = request.FgJsonFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateZip))
            {
                body["GenerateZip"] = request.GenerateZip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsUseFeatureStore))
            {
                body["IsUseFeatureStore"] = request.IsUseFeatureStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemIdField))
            {
                body["ItemIdField"] = request.ItemIdField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTable))
            {
                body["ItemTable"] = request.ItemTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTablePartitionField))
            {
                body["ItemTablePartitionField"] = request.ItemTablePartitionField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTablePartitionFieldFormat))
            {
                body["ItemTablePartitionFieldFormat"] = request.ItemTablePartitionFieldFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssResourceId))
            {
                body["OssResourceId"] = request.OssResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SampleRate))
            {
                body["SampleRate"] = request.SampleRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdField))
            {
                body["UserIdField"] = request.UserIdField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTable))
            {
                body["UserTable"] = request.UserTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTablePartitionField))
            {
                body["UserTablePartitionField"] = request.UserTablePartitionField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTablePartitionFieldFormat))
            {
                body["UserTablePartitionFieldFormat"] = request.UserTablePartitionFieldFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowName))
            {
                body["WorkflowName"] = request.WorkflowName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFeatureConsistencyCheckJobConfig",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureConsistencyCheckJobConfigId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFeatureConsistencyCheckJobConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新特征一致性检查配置信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFeatureConsistencyCheckJobConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFeatureConsistencyCheckJobConfigResponse
        /// </returns>
        public async Task<UpdateFeatureConsistencyCheckJobConfigResponse> UpdateFeatureConsistencyCheckJobConfigWithOptionsAsync(string FeatureConsistencyCheckJobConfigId, UpdateFeatureConsistencyCheckJobConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompareFeature))
            {
                body["CompareFeature"] = request.CompareFeature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EasServiceName))
            {
                body["EasServiceName"] = request.EasServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EasyRecPackagePath))
            {
                body["EasyRecPackagePath"] = request.EasyRecPackagePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EasyRecVersion))
            {
                body["EasyRecVersion"] = request.EasyRecVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureDisplayExclude))
            {
                body["FeatureDisplayExclude"] = request.FeatureDisplayExclude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureLandingResourceId))
            {
                body["FeatureLandingResourceId"] = request.FeatureLandingResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeaturePriority))
            {
                body["FeaturePriority"] = request.FeaturePriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreItemId))
            {
                body["FeatureStoreItemId"] = request.FeatureStoreItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreModelId))
            {
                body["FeatureStoreModelId"] = request.FeatureStoreModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreProjectId))
            {
                body["FeatureStoreProjectId"] = request.FeatureStoreProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreProjectName))
            {
                body["FeatureStoreProjectName"] = request.FeatureStoreProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreSeqFeatureView))
            {
                body["FeatureStoreSeqFeatureView"] = request.FeatureStoreSeqFeatureView;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureStoreUserId))
            {
                body["FeatureStoreUserId"] = request.FeatureStoreUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FgJarVersion))
            {
                body["FgJarVersion"] = request.FgJarVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FgJsonFileName))
            {
                body["FgJsonFileName"] = request.FgJsonFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateZip))
            {
                body["GenerateZip"] = request.GenerateZip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsUseFeatureStore))
            {
                body["IsUseFeatureStore"] = request.IsUseFeatureStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemIdField))
            {
                body["ItemIdField"] = request.ItemIdField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTable))
            {
                body["ItemTable"] = request.ItemTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTablePartitionField))
            {
                body["ItemTablePartitionField"] = request.ItemTablePartitionField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTablePartitionFieldFormat))
            {
                body["ItemTablePartitionFieldFormat"] = request.ItemTablePartitionFieldFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssResourceId))
            {
                body["OssResourceId"] = request.OssResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SampleRate))
            {
                body["SampleRate"] = request.SampleRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                body["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdField))
            {
                body["UserIdField"] = request.UserIdField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTable))
            {
                body["UserTable"] = request.UserTable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTablePartitionField))
            {
                body["UserTablePartitionField"] = request.UserTablePartitionField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTablePartitionFieldFormat))
            {
                body["UserTablePartitionFieldFormat"] = request.UserTablePartitionFieldFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowName))
            {
                body["WorkflowName"] = request.WorkflowName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFeatureConsistencyCheckJobConfig",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/featureconsistencycheck/jobconfigs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FeatureConsistencyCheckJobConfigId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFeatureConsistencyCheckJobConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新特征一致性检查配置信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFeatureConsistencyCheckJobConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFeatureConsistencyCheckJobConfigResponse
        /// </returns>
        public UpdateFeatureConsistencyCheckJobConfigResponse UpdateFeatureConsistencyCheckJobConfig(string FeatureConsistencyCheckJobConfigId, UpdateFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFeatureConsistencyCheckJobConfigWithOptions(FeatureConsistencyCheckJobConfigId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新特征一致性检查配置信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFeatureConsistencyCheckJobConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFeatureConsistencyCheckJobConfigResponse
        /// </returns>
        public async Task<UpdateFeatureConsistencyCheckJobConfigResponse> UpdateFeatureConsistencyCheckJobConfigAsync(string FeatureConsistencyCheckJobConfigId, UpdateFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFeatureConsistencyCheckJobConfigWithOptionsAsync(FeatureConsistencyCheckJobConfigId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定实例下指定资源的信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResourceResponse
        /// </returns>
        public UpdateInstanceResourceResponse UpdateInstanceResourceWithOptions(string InstanceId, string ResourceId, UpdateInstanceResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceResource",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定实例下指定资源的信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResourceResponse
        /// </returns>
        public async Task<UpdateInstanceResourceResponse> UpdateInstanceResourceWithOptionsAsync(string InstanceId, string ResourceId, UpdateInstanceResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uri))
            {
                body["Uri"] = request.Uri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceResource",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定实例下指定资源的信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResourceResponse
        /// </returns>
        public UpdateInstanceResourceResponse UpdateInstanceResource(string InstanceId, string ResourceId, UpdateInstanceResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateInstanceResourceWithOptions(InstanceId, ResourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新指定实例下指定资源的信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResourceResponse
        /// </returns>
        public async Task<UpdateInstanceResourceResponse> UpdateInstanceResourceAsync(string InstanceId, string ResourceId, UpdateInstanceResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateInstanceResourceWithOptionsAsync(InstanceId, ResourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实验室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLaboratoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLaboratoryResponse
        /// </returns>
        public UpdateLaboratoryResponse UpdateLaboratoryWithOptions(string LaboratoryId, UpdateLaboratoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketCount))
            {
                body["BucketCount"] = request.BucketCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketType))
            {
                body["BucketType"] = request.BucketType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Buckets))
            {
                body["Buckets"] = request.Buckets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugCrowdId))
            {
                body["DebugCrowdId"] = request.DebugCrowdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                body["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLaboratory",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/laboratories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LaboratoryId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLaboratoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实验室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLaboratoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLaboratoryResponse
        /// </returns>
        public async Task<UpdateLaboratoryResponse> UpdateLaboratoryWithOptionsAsync(string LaboratoryId, UpdateLaboratoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketCount))
            {
                body["BucketCount"] = request.BucketCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketType))
            {
                body["BucketType"] = request.BucketType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Buckets))
            {
                body["Buckets"] = request.Buckets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugCrowdId))
            {
                body["DebugCrowdId"] = request.DebugCrowdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DebugUsers))
            {
                body["DebugUsers"] = request.DebugUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                body["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLaboratory",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/laboratories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LaboratoryId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLaboratoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实验室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLaboratoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLaboratoryResponse
        /// </returns>
        public UpdateLaboratoryResponse UpdateLaboratory(string LaboratoryId, UpdateLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLaboratoryWithOptions(LaboratoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实验室。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLaboratoryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLaboratoryResponse
        /// </returns>
        public async Task<UpdateLaboratoryResponse> UpdateLaboratoryAsync(string LaboratoryId, UpdateLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLaboratoryWithOptionsAsync(LaboratoryId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新层。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLayerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLayerResponse
        /// </returns>
        public UpdateLayerResponse UpdateLayerWithOptions(string LayerId, UpdateLayerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLayer",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LayerId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLayerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新层。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLayerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateLayerResponse
        /// </returns>
        public async Task<UpdateLayerResponse> UpdateLayerWithOptionsAsync(string LayerId, UpdateLayerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLayer",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/layers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(LayerId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLayerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新层。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLayerRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLayerResponse
        /// </returns>
        public UpdateLayerResponse UpdateLayer(string LayerId, UpdateLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLayerWithOptions(LayerId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新层。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateLayerRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateLayerResponse
        /// </returns>
        public async Task<UpdateLayerResponse> UpdateLayerAsync(string LayerId, UpdateLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLayerWithOptionsAsync(LayerId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新参数。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateParamRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateParamResponse
        /// </returns>
        public UpdateParamResponse UpdateParamWithOptions(string ParamId, UpdateParamRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateParam",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/params/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ParamId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateParamResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新参数。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateParamRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateParamResponse
        /// </returns>
        public async Task<UpdateParamResponse> UpdateParamWithOptionsAsync(string ParamId, UpdateParamRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateParam",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/params/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ParamId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateParamResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新参数。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateParamRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateParamResponse
        /// </returns>
        public UpdateParamResponse UpdateParam(string ParamId, UpdateParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateParamWithOptions(ParamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新参数。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateParamRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateParamResponse
        /// </returns>
        public async Task<UpdateParamResponse> UpdateParamAsync(string ParamId, UpdateParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateParamWithOptionsAsync(ParamId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取资源规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceRuleResponse
        /// </returns>
        public UpdateResourceRuleResponse UpdateResourceRuleWithOptions(string ResourceRuleId, UpdateResourceRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricOperationType))
            {
                body["MetricOperationType"] = request.MetricOperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricPullInfo))
            {
                body["MetricPullInfo"] = request.MetricPullInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricPullPeriod))
            {
                body["MetricPullPeriod"] = request.MetricPullPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleComputingDefinition))
            {
                body["RuleComputingDefinition"] = request.RuleComputingDefinition;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourceRule",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resourcerules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceRuleId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取资源规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceRuleResponse
        /// </returns>
        public async Task<UpdateResourceRuleResponse> UpdateResourceRuleWithOptionsAsync(string ResourceRuleId, UpdateResourceRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricOperationType))
            {
                body["MetricOperationType"] = request.MetricOperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricPullInfo))
            {
                body["MetricPullInfo"] = request.MetricPullInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricPullPeriod))
            {
                body["MetricPullPeriod"] = request.MetricPullPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleComputingDefinition))
            {
                body["RuleComputingDefinition"] = request.RuleComputingDefinition;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourceRule",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resourcerules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceRuleId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取资源规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceRuleResponse
        /// </returns>
        public UpdateResourceRuleResponse UpdateResourceRule(string ResourceRuleId, UpdateResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateResourceRuleWithOptions(ResourceRuleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取资源规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceRuleResponse
        /// </returns>
        public async Task<UpdateResourceRuleResponse> UpdateResourceRuleAsync(string ResourceRuleId, UpdateResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateResourceRuleWithOptionsAsync(ResourceRuleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新资源规则条目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceRuleItemRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceRuleItemResponse
        /// </returns>
        public UpdateResourceRuleItemResponse UpdateResourceRuleItemWithOptions(string ResourceRuleId, string ResourceRuleItemId, UpdateResourceRuleItemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxValue))
            {
                body["MaxValue"] = request.MaxValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinValue))
            {
                body["MinValue"] = request.MinValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourceRuleItem",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resourcerules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceRuleId) + "/items/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceRuleItemId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceRuleItemResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新资源规则条目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceRuleItemRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceRuleItemResponse
        /// </returns>
        public async Task<UpdateResourceRuleItemResponse> UpdateResourceRuleItemWithOptionsAsync(string ResourceRuleId, string ResourceRuleItemId, UpdateResourceRuleItemRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxValue))
            {
                body["MaxValue"] = request.MaxValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinValue))
            {
                body["MinValue"] = request.MinValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourceRuleItem",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/resourcerules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceRuleId) + "/items/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceRuleItemId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceRuleItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新资源规则条目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceRuleItemRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceRuleItemResponse
        /// </returns>
        public UpdateResourceRuleItemResponse UpdateResourceRuleItem(string ResourceRuleId, string ResourceRuleItemId, UpdateResourceRuleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateResourceRuleItemWithOptions(ResourceRuleId, ResourceRuleItemId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新资源规则条目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceRuleItemRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceRuleItemResponse
        /// </returns>
        public async Task<UpdateResourceRuleItemResponse> UpdateResourceRuleItemAsync(string ResourceRuleId, string ResourceRuleItemId, UpdateResourceRuleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateResourceRuleItemWithOptionsAsync(ResourceRuleId, ResourceRuleItemId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSceneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSceneResponse
        /// </returns>
        public UpdateSceneResponse UpdateSceneWithOptions(string SceneId, UpdateSceneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flows))
            {
                body["Flows"] = request.Flows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateScene",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SceneId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSceneResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSceneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSceneResponse
        /// </returns>
        public async Task<UpdateSceneResponse> UpdateSceneWithOptionsAsync(string SceneId, UpdateSceneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flows))
            {
                body["Flows"] = request.Flows;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateScene",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/scenes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SceneId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSceneResponse
        /// </returns>
        public UpdateSceneResponse UpdateScene(string SceneId, UpdateSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSceneWithOptions(SceneId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新场景</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSceneResponse
        /// </returns>
        public async Task<UpdateSceneResponse> UpdateSceneAsync(string SceneId, UpdateSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSceneWithOptionsAsync(SceneId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据表详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTableMetaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTableMetaResponse
        /// </returns>
        public UpdateTableMetaResponse UpdateTableMetaWithOptions(string TableMetaId, UpdateTableMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Module))
            {
                body["Module"] = request.Module;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTableMeta",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tablemetas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TableMetaId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTableMetaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据表详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTableMetaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTableMetaResponse
        /// </returns>
        public async Task<UpdateTableMetaResponse> UpdateTableMetaWithOptionsAsync(string TableMetaId, UpdateTableMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["Fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Module))
            {
                body["Module"] = request.Module;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                body["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTableMeta",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tablemetas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TableMetaId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTableMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据表详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTableMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTableMetaResponse
        /// </returns>
        public UpdateTableMetaResponse UpdateTableMeta(string TableMetaId, UpdateTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTableMetaWithOptions(TableMetaId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据表详细信息。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTableMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTableMetaResponse
        /// </returns>
        public async Task<UpdateTableMetaResponse> UpdateTableMetaAsync(string TableMetaId, UpdateTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTableMetaWithOptionsAsync(TableMetaId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTrafficControlTargetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTrafficControlTargetResponse
        /// </returns>
        public UpdateTrafficControlTargetResponse UpdateTrafficControlTargetWithOptions(string TrafficControlTargetId, UpdateTrafficControlTargetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewParam3))
            {
                query["new-param-3"] = request.NewParam3;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Event))
            {
                body["Event"] = request.Event;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionArray))
            {
                body["ItemConditionArray"] = request.ItemConditionArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionExpress))
            {
                body["ItemConditionExpress"] = request.ItemConditionExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionType))
            {
                body["ItemConditionType"] = request.ItemConditionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewProductRegulation))
            {
                body["NewProductRegulation"] = request.NewProductRegulation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallName))
            {
                body["RecallName"] = request.RecallName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisPeriod))
            {
                body["StatisPeriod"] = request.StatisPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToleranceValue))
            {
                body["ToleranceValue"] = request.ToleranceValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrafficControlTarget",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltargets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTargetId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTrafficControlTargetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTrafficControlTargetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTrafficControlTargetResponse
        /// </returns>
        public async Task<UpdateTrafficControlTargetResponse> UpdateTrafficControlTargetWithOptionsAsync(string TrafficControlTargetId, UpdateTrafficControlTargetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewParam3))
            {
                query["new-param-3"] = request.NewParam3;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Event))
            {
                body["Event"] = request.Event;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionArray))
            {
                body["ItemConditionArray"] = request.ItemConditionArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionExpress))
            {
                body["ItemConditionExpress"] = request.ItemConditionExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionType))
            {
                body["ItemConditionType"] = request.ItemConditionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewProductRegulation))
            {
                body["NewProductRegulation"] = request.NewProductRegulation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallName))
            {
                body["RecallName"] = request.RecallName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisPeriod))
            {
                body["StatisPeriod"] = request.StatisPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToleranceValue))
            {
                body["ToleranceValue"] = request.ToleranceValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrafficControlTarget",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltargets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTargetId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTrafficControlTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTrafficControlTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTrafficControlTargetResponse
        /// </returns>
        public UpdateTrafficControlTargetResponse UpdateTrafficControlTarget(string TrafficControlTargetId, UpdateTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTrafficControlTargetWithOptions(TrafficControlTargetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流量调控目标</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTrafficControlTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTrafficControlTargetResponse
        /// </returns>
        public async Task<UpdateTrafficControlTargetResponse> UpdateTrafficControlTargetAsync(string TrafficControlTargetId, UpdateTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTrafficControlTargetWithOptionsAsync(TrafficControlTargetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTrafficControlTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTrafficControlTaskResponse
        /// </returns>
        public UpdateTrafficControlTaskResponse UpdateTrafficControlTaskWithOptions(string TrafficControlTaskId, UpdateTrafficControlTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BehaviorTableMetaId))
            {
                body["BehaviorTableMetaId"] = request.BehaviorTableMetaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlGranularity))
            {
                body["ControlGranularity"] = request.ControlGranularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlLogic))
            {
                body["ControlLogic"] = request.ControlLogic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlType))
            {
                body["ControlType"] = request.ControlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionTime))
            {
                body["ExecutionTime"] = request.ExecutionTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionArray))
            {
                body["ItemConditionArray"] = request.ItemConditionArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionExpress))
            {
                body["ItemConditionExpress"] = request.ItemConditionExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionType))
            {
                body["ItemConditionType"] = request.ItemConditionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTableMetaId))
            {
                body["ItemTableMetaId"] = request.ItemTableMetaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisBaeaviorConditionArray))
            {
                body["StatisBaeaviorConditionArray"] = request.StatisBaeaviorConditionArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisBehaviorConditionExpress))
            {
                body["StatisBehaviorConditionExpress"] = request.StatisBehaviorConditionExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisBehaviorConditionType))
            {
                body["StatisBehaviorConditionType"] = request.StatisBehaviorConditionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficControlTargets))
            {
                body["TrafficControlTargets"] = request.TrafficControlTargets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserConditionArray))
            {
                body["UserConditionArray"] = request.UserConditionArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserConditionExpress))
            {
                body["UserConditionExpress"] = request.UserConditionExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserConditionType))
            {
                body["UserConditionType"] = request.UserConditionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTableMetaId))
            {
                body["UserTableMetaId"] = request.UserTableMetaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrafficControlTask",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTrafficControlTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTrafficControlTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTrafficControlTaskResponse
        /// </returns>
        public async Task<UpdateTrafficControlTaskResponse> UpdateTrafficControlTaskWithOptionsAsync(string TrafficControlTaskId, UpdateTrafficControlTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BehaviorTableMetaId))
            {
                body["BehaviorTableMetaId"] = request.BehaviorTableMetaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlGranularity))
            {
                body["ControlGranularity"] = request.ControlGranularity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlLogic))
            {
                body["ControlLogic"] = request.ControlLogic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlType))
            {
                body["ControlType"] = request.ControlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutionTime))
            {
                body["ExecutionTime"] = request.ExecutionTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionArray))
            {
                body["ItemConditionArray"] = request.ItemConditionArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionExpress))
            {
                body["ItemConditionExpress"] = request.ItemConditionExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemConditionType))
            {
                body["ItemConditionType"] = request.ItemConditionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemTableMetaId))
            {
                body["ItemTableMetaId"] = request.ItemTableMetaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                body["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisBaeaviorConditionArray))
            {
                body["StatisBaeaviorConditionArray"] = request.StatisBaeaviorConditionArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisBehaviorConditionExpress))
            {
                body["StatisBehaviorConditionExpress"] = request.StatisBehaviorConditionExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisBehaviorConditionType))
            {
                body["StatisBehaviorConditionType"] = request.StatisBehaviorConditionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficControlTargets))
            {
                body["TrafficControlTargets"] = request.TrafficControlTargets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserConditionArray))
            {
                body["UserConditionArray"] = request.UserConditionArray;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserConditionExpress))
            {
                body["UserConditionExpress"] = request.UserConditionExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserConditionType))
            {
                body["UserConditionType"] = request.UserConditionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTableMetaId))
            {
                body["UserTableMetaId"] = request.UserTableMetaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrafficControlTask",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTrafficControlTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTrafficControlTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTrafficControlTaskResponse
        /// </returns>
        public UpdateTrafficControlTaskResponse UpdateTrafficControlTask(string TrafficControlTaskId, UpdateTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTrafficControlTaskWithOptions(TrafficControlTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流量调控任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTrafficControlTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTrafficControlTaskResponse
        /// </returns>
        public async Task<UpdateTrafficControlTaskResponse> UpdateTrafficControlTaskAsync(string TrafficControlTaskId, UpdateTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTrafficControlTaskWithOptionsAsync(TrafficControlTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流量调控任务的流量参数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTrafficControlTaskTrafficRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTrafficControlTaskTrafficResponse
        /// </returns>
        public UpdateTrafficControlTaskTrafficResponse UpdateTrafficControlTaskTrafficWithOptions(string TrafficControlTaskId, UpdateTrafficControlTaskTrafficRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewParam3))
            {
                query["new-param-3"] = request.NewParam3;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Traffics))
            {
                body["Traffics"] = request.Traffics;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrafficControlTaskTraffic",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId) + "/action/traffic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTrafficControlTaskTrafficResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流量调控任务的流量参数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTrafficControlTaskTrafficRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTrafficControlTaskTrafficResponse
        /// </returns>
        public async Task<UpdateTrafficControlTaskTrafficResponse> UpdateTrafficControlTaskTrafficWithOptionsAsync(string TrafficControlTaskId, UpdateTrafficControlTaskTrafficRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewParam3))
            {
                query["new-param-3"] = request.NewParam3;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Environment))
            {
                body["Environment"] = request.Environment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Traffics))
            {
                body["Traffics"] = request.Traffics;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrafficControlTaskTraffic",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId) + "/action/traffic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTrafficControlTaskTrafficResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流量调控任务的流量参数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTrafficControlTaskTrafficRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTrafficControlTaskTrafficResponse
        /// </returns>
        public UpdateTrafficControlTaskTrafficResponse UpdateTrafficControlTaskTraffic(string TrafficControlTaskId, UpdateTrafficControlTaskTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTrafficControlTaskTrafficWithOptions(TrafficControlTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流量调控任务的流量参数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTrafficControlTaskTrafficRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTrafficControlTaskTrafficResponse
        /// </returns>
        public async Task<UpdateTrafficControlTaskTrafficResponse> UpdateTrafficControlTaskTrafficAsync(string TrafficControlTaskId, UpdateTrafficControlTaskTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTrafficControlTaskTrafficWithOptionsAsync(TrafficControlTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadRecommendationDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadRecommendationDataResponse
        /// </returns>
        public UploadRecommendationDataResponse UploadRecommendationDataWithOptions(UploadRecommendationDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                body["DataType"] = request.DataType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadRecommendationData",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/recommendationdata/action/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadRecommendationDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadRecommendationDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadRecommendationDataResponse
        /// </returns>
        public async Task<UploadRecommendationDataResponse> UploadRecommendationDataWithOptionsAsync(UploadRecommendationDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                body["DataType"] = request.DataType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadRecommendationData",
                Version = "2022-12-13",
                Protocol = "HTTPS",
                Pathname = "/api/v1/recommendationdata/action/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadRecommendationDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadRecommendationDataRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadRecommendationDataResponse
        /// </returns>
        public UploadRecommendationDataResponse UploadRecommendationData(UploadRecommendationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UploadRecommendationDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadRecommendationDataRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadRecommendationDataResponse
        /// </returns>
        public async Task<UploadRecommendationDataResponse> UploadRecommendationDataAsync(UploadRecommendationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UploadRecommendationDataWithOptionsAsync(request, headers, runtime);
        }

    }
}
