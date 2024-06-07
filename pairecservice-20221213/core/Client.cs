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

        /**
         * @summary 特征一致性检查数据回流。
         *
         * @param request BackflowFeatureConsistencyCheckJobDataRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return BackflowFeatureConsistencyCheckJobDataResponse
         */
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

        /**
         * @summary 特征一致性检查数据回流。
         *
         * @param request BackflowFeatureConsistencyCheckJobDataRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return BackflowFeatureConsistencyCheckJobDataResponse
         */
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

        /**
         * @summary 特征一致性检查数据回流。
         *
         * @param request BackflowFeatureConsistencyCheckJobDataRequest
         * @return BackflowFeatureConsistencyCheckJobDataResponse
         */
        public BackflowFeatureConsistencyCheckJobDataResponse BackflowFeatureConsistencyCheckJobData(BackflowFeatureConsistencyCheckJobDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BackflowFeatureConsistencyCheckJobDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 特征一致性检查数据回流。
         *
         * @param request BackflowFeatureConsistencyCheckJobDataRequest
         * @return BackflowFeatureConsistencyCheckJobDataResponse
         */
        public async Task<BackflowFeatureConsistencyCheckJobDataResponse> BackflowFeatureConsistencyCheckJobDataAsync(BackflowFeatureConsistencyCheckJobDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BackflowFeatureConsistencyCheckJobDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 检测实例下配置的资源的连接状态。
         *
         * @param request CheckInstanceResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckInstanceResourcesResponse
         */
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

        /**
         * @summary 检测实例下配置的资源的连接状态。
         *
         * @param request CheckInstanceResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckInstanceResourcesResponse
         */
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

        /**
         * @summary 检测实例下配置的资源的连接状态。
         *
         * @param request CheckInstanceResourcesRequest
         * @return CheckInstanceResourcesResponse
         */
        public CheckInstanceResourcesResponse CheckInstanceResources(string InstanceId, CheckInstanceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CheckInstanceResourcesWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 检测实例下配置的资源的连接状态。
         *
         * @param request CheckInstanceResourcesRequest
         * @return CheckInstanceResourcesResponse
         */
        public async Task<CheckInstanceResourcesResponse> CheckInstanceResourcesAsync(string InstanceId, CheckInstanceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CheckInstanceResourcesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 克隆实验。
         *
         * @param request CloneExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloneExperimentResponse
         */
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

        /**
         * @summary 克隆实验。
         *
         * @param request CloneExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloneExperimentResponse
         */
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

        /**
         * @summary 克隆实验。
         *
         * @param request CloneExperimentRequest
         * @return CloneExperimentResponse
         */
        public CloneExperimentResponse CloneExperiment(string ExperimentId, CloneExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary 克隆实验。
         *
         * @param request CloneExperimentRequest
         * @return CloneExperimentResponse
         */
        public async Task<CloneExperimentResponse> CloneExperimentAsync(string ExperimentId, CloneExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary 克隆实验组，并克隆实验组下的所有实验至新的实验组中。
         *
         * @param request CloneExperimentGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloneExperimentGroupResponse
         */
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

        /**
         * @summary 克隆实验组，并克隆实验组下的所有实验至新的实验组中。
         *
         * @param request CloneExperimentGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloneExperimentGroupResponse
         */
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

        /**
         * @summary 克隆实验组，并克隆实验组下的所有实验至新的实验组中。
         *
         * @param request CloneExperimentGroupRequest
         * @return CloneExperimentGroupResponse
         */
        public CloneExperimentGroupResponse CloneExperimentGroup(string ExperimentGroupId, CloneExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneExperimentGroupWithOptions(ExperimentGroupId, request, headers, runtime);
        }

        /**
         * @summary 克隆实验组，并克隆实验组下的所有实验至新的实验组中。
         *
         * @param request CloneExperimentGroupRequest
         * @return CloneExperimentGroupResponse
         */
        public async Task<CloneExperimentGroupResponse> CloneExperimentGroupAsync(string ExperimentGroupId, CloneExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneExperimentGroupWithOptionsAsync(ExperimentGroupId, request, headers, runtime);
        }

        /**
         * @summary 克隆特征一致性检查配置。
         *
         * @param request CloneFeatureConsistencyCheckJobConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloneFeatureConsistencyCheckJobConfigResponse
         */
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

        /**
         * @summary 克隆特征一致性检查配置。
         *
         * @param request CloneFeatureConsistencyCheckJobConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloneFeatureConsistencyCheckJobConfigResponse
         */
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

        /**
         * @summary 克隆特征一致性检查配置。
         *
         * @param request CloneFeatureConsistencyCheckJobConfigRequest
         * @return CloneFeatureConsistencyCheckJobConfigResponse
         */
        public CloneFeatureConsistencyCheckJobConfigResponse CloneFeatureConsistencyCheckJobConfig(string SourceFeatureConsistencyCheckJobConfigId, CloneFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneFeatureConsistencyCheckJobConfigWithOptions(SourceFeatureConsistencyCheckJobConfigId, request, headers, runtime);
        }

        /**
         * @summary 克隆特征一致性检查配置。
         *
         * @param request CloneFeatureConsistencyCheckJobConfigRequest
         * @return CloneFeatureConsistencyCheckJobConfigResponse
         */
        public async Task<CloneFeatureConsistencyCheckJobConfigResponse> CloneFeatureConsistencyCheckJobConfigAsync(string SourceFeatureConsistencyCheckJobConfigId, CloneFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneFeatureConsistencyCheckJobConfigWithOptionsAsync(SourceFeatureConsistencyCheckJobConfigId, request, headers, runtime);
        }

        /**
         * @summary 克隆实验室。
         *
         * @param request CloneLaboratoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloneLaboratoryResponse
         */
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

        /**
         * @summary 克隆实验室。
         *
         * @param request CloneLaboratoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloneLaboratoryResponse
         */
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

        /**
         * @summary 克隆实验室。
         *
         * @param request CloneLaboratoryRequest
         * @return CloneLaboratoryResponse
         */
        public CloneLaboratoryResponse CloneLaboratory(string LaboratoryId, CloneLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneLaboratoryWithOptions(LaboratoryId, request, headers, runtime);
        }

        /**
         * @summary 克隆实验室。
         *
         * @param request CloneLaboratoryRequest
         * @return CloneLaboratoryResponse
         */
        public async Task<CloneLaboratoryResponse> CloneLaboratoryAsync(string LaboratoryId, CloneLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneLaboratoryWithOptionsAsync(LaboratoryId, request, headers, runtime);
        }

        /**
         * @summary 克隆流量调控任务
         *
         * @param request CloneTrafficControlTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloneTrafficControlTaskResponse
         */
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

        /**
         * @summary 克隆流量调控任务
         *
         * @param request CloneTrafficControlTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloneTrafficControlTaskResponse
         */
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

        /**
         * @summary 克隆流量调控任务
         *
         * @param request CloneTrafficControlTaskRequest
         * @return CloneTrafficControlTaskResponse
         */
        public CloneTrafficControlTaskResponse CloneTrafficControlTask(string TrafficControlTaskId, CloneTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneTrafficControlTaskWithOptions(TrafficControlTaskId, request, headers, runtime);
        }

        /**
         * @summary 克隆流量调控任务
         *
         * @param request CloneTrafficControlTaskRequest
         * @return CloneTrafficControlTaskResponse
         */
        public async Task<CloneTrafficControlTaskResponse> CloneTrafficControlTaskAsync(string TrafficControlTaskId, CloneTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneTrafficControlTaskWithOptionsAsync(TrafficControlTaskId, request, headers, runtime);
        }

        /**
         * @summary 创建AB test实验指标
         *
         * @param request CreateABMetricRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateABMetricResponse
         */
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

        /**
         * @summary 创建AB test实验指标
         *
         * @param request CreateABMetricRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateABMetricResponse
         */
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

        /**
         * @summary 创建AB test实验指标
         *
         * @param request CreateABMetricRequest
         * @return CreateABMetricResponse
         */
        public CreateABMetricResponse CreateABMetric(CreateABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateABMetricWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建AB test实验指标
         *
         * @param request CreateABMetricRequest
         * @return CreateABMetricResponse
         */
        public async Task<CreateABMetricResponse> CreateABMetricAsync(CreateABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateABMetricWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建指标组
         *
         * @param request CreateABMetricGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateABMetricGroupResponse
         */
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

        /**
         * @summary 创建指标组
         *
         * @param request CreateABMetricGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateABMetricGroupResponse
         */
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

        /**
         * @summary 创建指标组
         *
         * @param request CreateABMetricGroupRequest
         * @return CreateABMetricGroupResponse
         */
        public CreateABMetricGroupResponse CreateABMetricGroup(CreateABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateABMetricGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建指标组
         *
         * @param request CreateABMetricGroupRequest
         * @return CreateABMetricGroupResponse
         */
        public async Task<CreateABMetricGroupResponse> CreateABMetricGroupAsync(CreateABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateABMetricGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建AB指标的计算任务。
         *
         * @param request CreateCalculationJobsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCalculationJobsResponse
         */
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

        /**
         * @summary 创建AB指标的计算任务。
         *
         * @param request CreateCalculationJobsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCalculationJobsResponse
         */
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

        /**
         * @summary 创建AB指标的计算任务。
         *
         * @param request CreateCalculationJobsRequest
         * @return CreateCalculationJobsResponse
         */
        public CreateCalculationJobsResponse CreateCalculationJobs(CreateCalculationJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCalculationJobsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建AB指标的计算任务。
         *
         * @param request CreateCalculationJobsRequest
         * @return CreateCalculationJobsResponse
         */
        public async Task<CreateCalculationJobsResponse> CreateCalculationJobsAsync(CreateCalculationJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCalculationJobsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建人群。
         *
         * @param request CreateCrowdRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCrowdResponse
         */
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

        /**
         * @summary 创建人群。
         *
         * @param request CreateCrowdRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCrowdResponse
         */
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

        /**
         * @summary 创建人群。
         *
         * @param request CreateCrowdRequest
         * @return CreateCrowdResponse
         */
        public CreateCrowdResponse CreateCrowd(CreateCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCrowdWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建人群。
         *
         * @param request CreateCrowdRequest
         * @return CreateCrowdResponse
         */
        public async Task<CreateCrowdResponse> CreateCrowdAsync(CreateCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCrowdWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建实验。
         *
         * @param request CreateExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateExperimentResponse
         */
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

        /**
         * @summary 创建实验。
         *
         * @param request CreateExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateExperimentResponse
         */
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

        /**
         * @summary 创建实验。
         *
         * @param request CreateExperimentRequest
         * @return CreateExperimentResponse
         */
        public CreateExperimentResponse CreateExperiment(CreateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateExperimentWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建实验。
         *
         * @param request CreateExperimentRequest
         * @return CreateExperimentResponse
         */
        public async Task<CreateExperimentResponse> CreateExperimentAsync(CreateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateExperimentWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建实验组。
         *
         * @param request CreateExperimentGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateExperimentGroupResponse
         */
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

        /**
         * @summary 创建实验组。
         *
         * @param request CreateExperimentGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateExperimentGroupResponse
         */
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

        /**
         * @summary 创建实验组。
         *
         * @param request CreateExperimentGroupRequest
         * @return CreateExperimentGroupResponse
         */
        public CreateExperimentGroupResponse CreateExperimentGroup(CreateExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateExperimentGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建实验组。
         *
         * @param request CreateExperimentGroupRequest
         * @return CreateExperimentGroupResponse
         */
        public async Task<CreateExperimentGroupResponse> CreateExperimentGroupAsync(CreateExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateExperimentGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建特征一致性检查任务。
         *
         * @param request CreateFeatureConsistencyCheckJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFeatureConsistencyCheckJobResponse
         */
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

        /**
         * @summary 创建特征一致性检查任务。
         *
         * @param request CreateFeatureConsistencyCheckJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFeatureConsistencyCheckJobResponse
         */
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

        /**
         * @summary 创建特征一致性检查任务。
         *
         * @param request CreateFeatureConsistencyCheckJobRequest
         * @return CreateFeatureConsistencyCheckJobResponse
         */
        public CreateFeatureConsistencyCheckJobResponse CreateFeatureConsistencyCheckJob(CreateFeatureConsistencyCheckJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFeatureConsistencyCheckJobWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建特征一致性检查任务。
         *
         * @param request CreateFeatureConsistencyCheckJobRequest
         * @return CreateFeatureConsistencyCheckJobResponse
         */
        public async Task<CreateFeatureConsistencyCheckJobResponse> CreateFeatureConsistencyCheckJobAsync(CreateFeatureConsistencyCheckJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFeatureConsistencyCheckJobWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建特征一致性检查配置。
         *
         * @param request CreateFeatureConsistencyCheckJobConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFeatureConsistencyCheckJobConfigResponse
         */
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

        /**
         * @summary 创建特征一致性检查配置。
         *
         * @param request CreateFeatureConsistencyCheckJobConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFeatureConsistencyCheckJobConfigResponse
         */
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

        /**
         * @summary 创建特征一致性检查配置。
         *
         * @param request CreateFeatureConsistencyCheckJobConfigRequest
         * @return CreateFeatureConsistencyCheckJobConfigResponse
         */
        public CreateFeatureConsistencyCheckJobConfigResponse CreateFeatureConsistencyCheckJobConfig(CreateFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFeatureConsistencyCheckJobConfigWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建特征一致性检查配置。
         *
         * @param request CreateFeatureConsistencyCheckJobConfigRequest
         * @return CreateFeatureConsistencyCheckJobConfigResponse
         */
        public async Task<CreateFeatureConsistencyCheckJobConfigResponse> CreateFeatureConsistencyCheckJobConfigAsync(CreateFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFeatureConsistencyCheckJobConfigWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 为指定实例配置创建新的配置资源
         *
         * @param request CreateInstanceResourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceResourceResponse
         */
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

        /**
         * @summary 为指定实例配置创建新的配置资源
         *
         * @param request CreateInstanceResourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceResourceResponse
         */
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

        /**
         * @summary 为指定实例配置创建新的配置资源
         *
         * @param request CreateInstanceResourceRequest
         * @return CreateInstanceResourceResponse
         */
        public CreateInstanceResourceResponse CreateInstanceResource(string InstanceId, CreateInstanceResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceResourceWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 为指定实例配置创建新的配置资源
         *
         * @param request CreateInstanceResourceRequest
         * @return CreateInstanceResourceResponse
         */
        public async Task<CreateInstanceResourceResponse> CreateInstanceResourceAsync(string InstanceId, CreateInstanceResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceResourceWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 创建实验室
         *
         * @param request CreateLaboratoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLaboratoryResponse
         */
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

        /**
         * @summary 创建实验室
         *
         * @param request CreateLaboratoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLaboratoryResponse
         */
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

        /**
         * @summary 创建实验室
         *
         * @param request CreateLaboratoryRequest
         * @return CreateLaboratoryResponse
         */
        public CreateLaboratoryResponse CreateLaboratory(CreateLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLaboratoryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建实验室
         *
         * @param request CreateLaboratoryRequest
         * @return CreateLaboratoryResponse
         */
        public async Task<CreateLaboratoryResponse> CreateLaboratoryAsync(CreateLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLaboratoryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建层。
         *
         * @param request CreateLayerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLayerResponse
         */
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

        /**
         * @summary 创建层。
         *
         * @param request CreateLayerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLayerResponse
         */
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

        /**
         * @summary 创建层。
         *
         * @param request CreateLayerRequest
         * @return CreateLayerResponse
         */
        public CreateLayerResponse CreateLayer(CreateLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLayerWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建层。
         *
         * @param request CreateLayerRequest
         * @return CreateLayerResponse
         */
        public async Task<CreateLayerResponse> CreateLayerAsync(CreateLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLayerWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建参数。
         *
         * @param request CreateParamRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateParamResponse
         */
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

        /**
         * @summary 创建参数。
         *
         * @param request CreateParamRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateParamResponse
         */
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

        /**
         * @summary 创建参数。
         *
         * @param request CreateParamRequest
         * @return CreateParamResponse
         */
        public CreateParamResponse CreateParam(CreateParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateParamWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建参数。
         *
         * @param request CreateParamRequest
         * @return CreateParamResponse
         */
        public async Task<CreateParamResponse> CreateParamAsync(CreateParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateParamWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建资源规则
         *
         * @param request CreateResourceRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateResourceRuleResponse
         */
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

        /**
         * @summary 创建资源规则
         *
         * @param request CreateResourceRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateResourceRuleResponse
         */
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

        /**
         * @summary 创建资源规则
         *
         * @param request CreateResourceRuleRequest
         * @return CreateResourceRuleResponse
         */
        public CreateResourceRuleResponse CreateResourceRule(CreateResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateResourceRuleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建资源规则
         *
         * @param request CreateResourceRuleRequest
         * @return CreateResourceRuleResponse
         */
        public async Task<CreateResourceRuleResponse> CreateResourceRuleAsync(CreateResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateResourceRuleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建资源规则条目
         *
         * @param request CreateResourceRuleItemRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateResourceRuleItemResponse
         */
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

        /**
         * @summary 创建资源规则条目
         *
         * @param request CreateResourceRuleItemRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateResourceRuleItemResponse
         */
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

        /**
         * @summary 创建资源规则条目
         *
         * @param request CreateResourceRuleItemRequest
         * @return CreateResourceRuleItemResponse
         */
        public CreateResourceRuleItemResponse CreateResourceRuleItem(string ResourceRuleId, CreateResourceRuleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateResourceRuleItemWithOptions(ResourceRuleId, request, headers, runtime);
        }

        /**
         * @summary 创建资源规则条目
         *
         * @param request CreateResourceRuleItemRequest
         * @return CreateResourceRuleItemResponse
         */
        public async Task<CreateResourceRuleItemResponse> CreateResourceRuleItemAsync(string ResourceRuleId, CreateResourceRuleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateResourceRuleItemWithOptionsAsync(ResourceRuleId, request, headers, runtime);
        }

        /**
         * @summary 创建场景
         *
         * @param request CreateSceneRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSceneResponse
         */
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

        /**
         * @summary 创建场景
         *
         * @param request CreateSceneRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSceneResponse
         */
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

        /**
         * @summary 创建场景
         *
         * @param request CreateSceneRequest
         * @return CreateSceneResponse
         */
        public CreateSceneResponse CreateScene(CreateSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSceneWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建场景
         *
         * @param request CreateSceneRequest
         * @return CreateSceneResponse
         */
        public async Task<CreateSceneResponse> CreateSceneAsync(CreateSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSceneWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 在指定人群下创建子人群。
         *
         * @param request CreateSubCrowdRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSubCrowdResponse
         */
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

        /**
         * @summary 在指定人群下创建子人群。
         *
         * @param request CreateSubCrowdRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSubCrowdResponse
         */
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

        /**
         * @summary 在指定人群下创建子人群。
         *
         * @param request CreateSubCrowdRequest
         * @return CreateSubCrowdResponse
         */
        public CreateSubCrowdResponse CreateSubCrowd(string CrowdId, CreateSubCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSubCrowdWithOptions(CrowdId, request, headers, runtime);
        }

        /**
         * @summary 在指定人群下创建子人群。
         *
         * @param request CreateSubCrowdRequest
         * @return CreateSubCrowdResponse
         */
        public async Task<CreateSubCrowdResponse> CreateSubCrowdAsync(string CrowdId, CreateSubCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSubCrowdWithOptionsAsync(CrowdId, request, headers, runtime);
        }

        /**
         * @summary 创建数据表。
         *
         * @param request CreateTableMetaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTableMetaResponse
         */
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

        /**
         * @summary 创建数据表。
         *
         * @param request CreateTableMetaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTableMetaResponse
         */
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

        /**
         * @summary 创建数据表。
         *
         * @param request CreateTableMetaRequest
         * @return CreateTableMetaResponse
         */
        public CreateTableMetaResponse CreateTableMeta(CreateTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTableMetaWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建数据表。
         *
         * @param request CreateTableMetaRequest
         * @return CreateTableMetaResponse
         */
        public async Task<CreateTableMetaResponse> CreateTableMetaAsync(CreateTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTableMetaWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建流量调控目标
         *
         * @param request CreateTrafficControlTargetRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTrafficControlTargetResponse
         */
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

        /**
         * @summary 创建流量调控目标
         *
         * @param request CreateTrafficControlTargetRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTrafficControlTargetResponse
         */
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

        /**
         * @summary 创建流量调控目标
         *
         * @param request CreateTrafficControlTargetRequest
         * @return CreateTrafficControlTargetResponse
         */
        public CreateTrafficControlTargetResponse CreateTrafficControlTarget(CreateTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTrafficControlTargetWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建流量调控目标
         *
         * @param request CreateTrafficControlTargetRequest
         * @return CreateTrafficControlTargetResponse
         */
        public async Task<CreateTrafficControlTargetResponse> CreateTrafficControlTargetAsync(CreateTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTrafficControlTargetWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建流量调控任务
         *
         * @param request CreateTrafficControlTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTrafficControlTaskResponse
         */
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

        /**
         * @summary 创建流量调控任务
         *
         * @param request CreateTrafficControlTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTrafficControlTaskResponse
         */
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

        /**
         * @summary 创建流量调控任务
         *
         * @param request CreateTrafficControlTaskRequest
         * @return CreateTrafficControlTaskResponse
         */
        public CreateTrafficControlTaskResponse CreateTrafficControlTask(CreateTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTrafficControlTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建流量调控任务
         *
         * @param request CreateTrafficControlTaskRequest
         * @return CreateTrafficControlTaskResponse
         */
        public async Task<CreateTrafficControlTaskResponse> CreateTrafficControlTaskAsync(CreateTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTrafficControlTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 对指定资源规则中的计算公式进行调试
         *
         * @param tmpReq DebugResourceRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DebugResourceRuleResponse
         */
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

        /**
         * @summary 对指定资源规则中的计算公式进行调试
         *
         * @param tmpReq DebugResourceRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DebugResourceRuleResponse
         */
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

        /**
         * @summary 对指定资源规则中的计算公式进行调试
         *
         * @param request DebugResourceRuleRequest
         * @return DebugResourceRuleResponse
         */
        public DebugResourceRuleResponse DebugResourceRule(string ResourceRuleId, DebugResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DebugResourceRuleWithOptions(ResourceRuleId, request, headers, runtime);
        }

        /**
         * @summary 对指定资源规则中的计算公式进行调试
         *
         * @param request DebugResourceRuleRequest
         * @return DebugResourceRuleResponse
         */
        public async Task<DebugResourceRuleResponse> DebugResourceRuleAsync(string ResourceRuleId, DebugResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DebugResourceRuleWithOptionsAsync(ResourceRuleId, request, headers, runtime);
        }

        /**
         * @summary 删除指定AB实验指标。
         *
         * @param request DeleteABMetricRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteABMetricResponse
         */
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

        /**
         * @summary 删除指定AB实验指标。
         *
         * @param request DeleteABMetricRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteABMetricResponse
         */
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

        /**
         * @summary 删除指定AB实验指标。
         *
         * @param request DeleteABMetricRequest
         * @return DeleteABMetricResponse
         */
        public DeleteABMetricResponse DeleteABMetric(string ABMetricId, DeleteABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteABMetricWithOptions(ABMetricId, request, headers, runtime);
        }

        /**
         * @summary 删除指定AB实验指标。
         *
         * @param request DeleteABMetricRequest
         * @return DeleteABMetricResponse
         */
        public async Task<DeleteABMetricResponse> DeleteABMetricAsync(string ABMetricId, DeleteABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteABMetricWithOptionsAsync(ABMetricId, request, headers, runtime);
        }

        /**
         * @summary 删除AB实验指标组。
         *
         * @param request DeleteABMetricGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteABMetricGroupResponse
         */
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

        /**
         * @summary 删除AB实验指标组。
         *
         * @param request DeleteABMetricGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteABMetricGroupResponse
         */
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

        /**
         * @summary 删除AB实验指标组。
         *
         * @param request DeleteABMetricGroupRequest
         * @return DeleteABMetricGroupResponse
         */
        public DeleteABMetricGroupResponse DeleteABMetricGroup(string ABMetricGroupId, DeleteABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteABMetricGroupWithOptions(ABMetricGroupId, request, headers, runtime);
        }

        /**
         * @summary 删除AB实验指标组。
         *
         * @param request DeleteABMetricGroupRequest
         * @return DeleteABMetricGroupResponse
         */
        public async Task<DeleteABMetricGroupResponse> DeleteABMetricGroupAsync(string ABMetricGroupId, DeleteABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteABMetricGroupWithOptionsAsync(ABMetricGroupId, request, headers, runtime);
        }

        /**
         * @summary 删除指定人群。
         *
         * @param request DeleteCrowdRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCrowdResponse
         */
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

        /**
         * @summary 删除指定人群。
         *
         * @param request DeleteCrowdRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCrowdResponse
         */
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

        /**
         * @summary 删除指定人群。
         *
         * @param request DeleteCrowdRequest
         * @return DeleteCrowdResponse
         */
        public DeleteCrowdResponse DeleteCrowd(string CrowdId, DeleteCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteCrowdWithOptions(CrowdId, request, headers, runtime);
        }

        /**
         * @summary 删除指定人群。
         *
         * @param request DeleteCrowdRequest
         * @return DeleteCrowdResponse
         */
        public async Task<DeleteCrowdResponse> DeleteCrowdAsync(string CrowdId, DeleteCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteCrowdWithOptionsAsync(CrowdId, request, headers, runtime);
        }

        /**
         * @summary 删除实验。
         *
         * @param request DeleteExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteExperimentResponse
         */
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

        /**
         * @summary 删除实验。
         *
         * @param request DeleteExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteExperimentResponse
         */
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

        /**
         * @summary 删除实验。
         *
         * @param request DeleteExperimentRequest
         * @return DeleteExperimentResponse
         */
        public DeleteExperimentResponse DeleteExperiment(string ExperimentId, DeleteExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary 删除实验。
         *
         * @param request DeleteExperimentRequest
         * @return DeleteExperimentResponse
         */
        public async Task<DeleteExperimentResponse> DeleteExperimentAsync(string ExperimentId, DeleteExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary 删除指定实验组。
         *
         * @param request DeleteExperimentGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteExperimentGroupResponse
         */
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

        /**
         * @summary 删除指定实验组。
         *
         * @param request DeleteExperimentGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteExperimentGroupResponse
         */
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

        /**
         * @summary 删除指定实验组。
         *
         * @param request DeleteExperimentGroupRequest
         * @return DeleteExperimentGroupResponse
         */
        public DeleteExperimentGroupResponse DeleteExperimentGroup(string ExperimentGroupId, DeleteExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteExperimentGroupWithOptions(ExperimentGroupId, request, headers, runtime);
        }

        /**
         * @summary 删除指定实验组。
         *
         * @param request DeleteExperimentGroupRequest
         * @return DeleteExperimentGroupResponse
         */
        public async Task<DeleteExperimentGroupResponse> DeleteExperimentGroupAsync(string ExperimentGroupId, DeleteExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteExperimentGroupWithOptionsAsync(ExperimentGroupId, request, headers, runtime);
        }

        /**
         * @summary 删除指定实例下的指定配置资源。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceResourceResponse
         */
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

        /**
         * @summary 删除指定实例下的指定配置资源。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceResourceResponse
         */
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

        /**
         * @summary 删除指定实例下的指定配置资源。
         *
         * @return DeleteInstanceResourceResponse
         */
        public DeleteInstanceResourceResponse DeleteInstanceResource(string InstanceId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteInstanceResourceWithOptions(InstanceId, ResourceId, headers, runtime);
        }

        /**
         * @summary 删除指定实例下的指定配置资源。
         *
         * @return DeleteInstanceResourceResponse
         */
        public async Task<DeleteInstanceResourceResponse> DeleteInstanceResourceAsync(string InstanceId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteInstanceResourceWithOptionsAsync(InstanceId, ResourceId, headers, runtime);
        }

        /**
         * @summary 删除实验室。
         *
         * @param request DeleteLaboratoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLaboratoryResponse
         */
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

        /**
         * @summary 删除实验室。
         *
         * @param request DeleteLaboratoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLaboratoryResponse
         */
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

        /**
         * @summary 删除实验室。
         *
         * @param request DeleteLaboratoryRequest
         * @return DeleteLaboratoryResponse
         */
        public DeleteLaboratoryResponse DeleteLaboratory(string LaboratoryId, DeleteLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLaboratoryWithOptions(LaboratoryId, request, headers, runtime);
        }

        /**
         * @summary 删除实验室。
         *
         * @param request DeleteLaboratoryRequest
         * @return DeleteLaboratoryResponse
         */
        public async Task<DeleteLaboratoryResponse> DeleteLaboratoryAsync(string LaboratoryId, DeleteLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteLaboratoryWithOptionsAsync(LaboratoryId, request, headers, runtime);
        }

        /**
         * @summary 删除层。
         *
         * @param request DeleteLayerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLayerResponse
         */
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

        /**
         * @summary 删除层。
         *
         * @param request DeleteLayerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLayerResponse
         */
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

        /**
         * @summary 删除层。
         *
         * @param request DeleteLayerRequest
         * @return DeleteLayerResponse
         */
        public DeleteLayerResponse DeleteLayer(string LayerId, DeleteLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLayerWithOptions(LayerId, request, headers, runtime);
        }

        /**
         * @summary 删除层。
         *
         * @param request DeleteLayerRequest
         * @return DeleteLayerResponse
         */
        public async Task<DeleteLayerResponse> DeleteLayerAsync(string LayerId, DeleteLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteLayerWithOptionsAsync(LayerId, request, headers, runtime);
        }

        /**
         * @summary 删除指定参数。
         *
         * @param request DeleteParamRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteParamResponse
         */
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

        /**
         * @summary 删除指定参数。
         *
         * @param request DeleteParamRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteParamResponse
         */
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

        /**
         * @summary 删除指定参数。
         *
         * @param request DeleteParamRequest
         * @return DeleteParamResponse
         */
        public DeleteParamResponse DeleteParam(string ParamId, DeleteParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteParamWithOptions(ParamId, request, headers, runtime);
        }

        /**
         * @summary 删除指定参数。
         *
         * @param request DeleteParamRequest
         * @return DeleteParamResponse
         */
        public async Task<DeleteParamResponse> DeleteParamAsync(string ParamId, DeleteParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteParamWithOptionsAsync(ParamId, request, headers, runtime);
        }

        /**
         * @summary 删除资源规则
         *
         * @param request DeleteResourceRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteResourceRuleResponse
         */
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

        /**
         * @summary 删除资源规则
         *
         * @param request DeleteResourceRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteResourceRuleResponse
         */
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

        /**
         * @summary 删除资源规则
         *
         * @param request DeleteResourceRuleRequest
         * @return DeleteResourceRuleResponse
         */
        public DeleteResourceRuleResponse DeleteResourceRule(string ResourceRuleId, DeleteResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteResourceRuleWithOptions(ResourceRuleId, request, headers, runtime);
        }

        /**
         * @summary 删除资源规则
         *
         * @param request DeleteResourceRuleRequest
         * @return DeleteResourceRuleResponse
         */
        public async Task<DeleteResourceRuleResponse> DeleteResourceRuleAsync(string ResourceRuleId, DeleteResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteResourceRuleWithOptionsAsync(ResourceRuleId, request, headers, runtime);
        }

        /**
         * @summary 删除资源规则条目
         *
         * @param request DeleteResourceRuleItemRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteResourceRuleItemResponse
         */
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

        /**
         * @summary 删除资源规则条目
         *
         * @param request DeleteResourceRuleItemRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteResourceRuleItemResponse
         */
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

        /**
         * @summary 删除资源规则条目
         *
         * @param request DeleteResourceRuleItemRequest
         * @return DeleteResourceRuleItemResponse
         */
        public DeleteResourceRuleItemResponse DeleteResourceRuleItem(string ResourceRuleId, string ResourceRuleItemId, DeleteResourceRuleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteResourceRuleItemWithOptions(ResourceRuleId, ResourceRuleItemId, request, headers, runtime);
        }

        /**
         * @summary 删除资源规则条目
         *
         * @param request DeleteResourceRuleItemRequest
         * @return DeleteResourceRuleItemResponse
         */
        public async Task<DeleteResourceRuleItemResponse> DeleteResourceRuleItemAsync(string ResourceRuleId, string ResourceRuleItemId, DeleteResourceRuleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteResourceRuleItemWithOptionsAsync(ResourceRuleId, ResourceRuleItemId, request, headers, runtime);
        }

        /**
         * @summary 删除场景
         *
         * @param request DeleteSceneRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSceneResponse
         */
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

        /**
         * @summary 删除场景
         *
         * @param request DeleteSceneRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSceneResponse
         */
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

        /**
         * @summary 删除场景
         *
         * @param request DeleteSceneRequest
         * @return DeleteSceneResponse
         */
        public DeleteSceneResponse DeleteScene(string SceneId, DeleteSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSceneWithOptions(SceneId, request, headers, runtime);
        }

        /**
         * @summary 删除场景
         *
         * @param request DeleteSceneRequest
         * @return DeleteSceneResponse
         */
        public async Task<DeleteSceneResponse> DeleteSceneAsync(string SceneId, DeleteSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSceneWithOptionsAsync(SceneId, request, headers, runtime);
        }

        /**
         * @summary 删除指定人群下的指定子人群。
         *
         * @param request DeleteSubCrowdRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSubCrowdResponse
         */
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

        /**
         * @summary 删除指定人群下的指定子人群。
         *
         * @param request DeleteSubCrowdRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSubCrowdResponse
         */
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

        /**
         * @summary 删除指定人群下的指定子人群。
         *
         * @param request DeleteSubCrowdRequest
         * @return DeleteSubCrowdResponse
         */
        public DeleteSubCrowdResponse DeleteSubCrowd(string CrowdId, string SubCrowdId, DeleteSubCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSubCrowdWithOptions(CrowdId, SubCrowdId, request, headers, runtime);
        }

        /**
         * @summary 删除指定人群下的指定子人群。
         *
         * @param request DeleteSubCrowdRequest
         * @return DeleteSubCrowdResponse
         */
        public async Task<DeleteSubCrowdResponse> DeleteSubCrowdAsync(string CrowdId, string SubCrowdId, DeleteSubCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSubCrowdWithOptionsAsync(CrowdId, SubCrowdId, request, headers, runtime);
        }

        /**
         * @summary 删除数据表。
         *
         * @param request DeleteTableMetaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTableMetaResponse
         */
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

        /**
         * @summary 删除数据表。
         *
         * @param request DeleteTableMetaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTableMetaResponse
         */
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

        /**
         * @summary 删除数据表。
         *
         * @param request DeleteTableMetaRequest
         * @return DeleteTableMetaResponse
         */
        public DeleteTableMetaResponse DeleteTableMeta(string TableMetaId, DeleteTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTableMetaWithOptions(TableMetaId, request, headers, runtime);
        }

        /**
         * @summary 删除数据表。
         *
         * @param request DeleteTableMetaRequest
         * @return DeleteTableMetaResponse
         */
        public async Task<DeleteTableMetaResponse> DeleteTableMetaAsync(string TableMetaId, DeleteTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTableMetaWithOptionsAsync(TableMetaId, request, headers, runtime);
        }

        /**
         * @summary 更新流量调控目标
         *
         * @param request DeleteTrafficControlTargetRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTrafficControlTargetResponse
         */
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

        /**
         * @summary 更新流量调控目标
         *
         * @param request DeleteTrafficControlTargetRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTrafficControlTargetResponse
         */
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

        /**
         * @summary 更新流量调控目标
         *
         * @param request DeleteTrafficControlTargetRequest
         * @return DeleteTrafficControlTargetResponse
         */
        public DeleteTrafficControlTargetResponse DeleteTrafficControlTarget(string TrafficControlTargetId, DeleteTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTrafficControlTargetWithOptions(TrafficControlTargetId, request, headers, runtime);
        }

        /**
         * @summary 更新流量调控目标
         *
         * @param request DeleteTrafficControlTargetRequest
         * @return DeleteTrafficControlTargetResponse
         */
        public async Task<DeleteTrafficControlTargetResponse> DeleteTrafficControlTargetAsync(string TrafficControlTargetId, DeleteTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTrafficControlTargetWithOptionsAsync(TrafficControlTargetId, request, headers, runtime);
        }

        /**
         * @summary 删除指定的流量调控任务
         *
         * @param request DeleteTrafficControlTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTrafficControlTaskResponse
         */
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

        /**
         * @summary 删除指定的流量调控任务
         *
         * @param request DeleteTrafficControlTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTrafficControlTaskResponse
         */
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

        /**
         * @summary 删除指定的流量调控任务
         *
         * @param request DeleteTrafficControlTaskRequest
         * @return DeleteTrafficControlTaskResponse
         */
        public DeleteTrafficControlTaskResponse DeleteTrafficControlTask(string TrafficControlTaskId, DeleteTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTrafficControlTaskWithOptions(TrafficControlTaskId, request, headers, runtime);
        }

        /**
         * @summary 删除指定的流量调控任务
         *
         * @param request DeleteTrafficControlTaskRequest
         * @return DeleteTrafficControlTaskResponse
         */
        public async Task<DeleteTrafficControlTaskResponse> DeleteTrafficControlTaskAsync(string TrafficControlTaskId, DeleteTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTrafficControlTaskWithOptionsAsync(TrafficControlTaskId, request, headers, runtime);
        }

        /**
         * @summary 产生流量调控的相关代码
         *
         * @param request GenerateTrafficControlTaskCodeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateTrafficControlTaskCodeResponse
         */
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
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId) + "/action/code",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateTrafficControlTaskCodeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 产生流量调控的相关代码
         *
         * @param request GenerateTrafficControlTaskCodeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateTrafficControlTaskCodeResponse
         */
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
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId) + "/action/code",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateTrafficControlTaskCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 产生流量调控的相关代码
         *
         * @param request GenerateTrafficControlTaskCodeRequest
         * @return GenerateTrafficControlTaskCodeResponse
         */
        public GenerateTrafficControlTaskCodeResponse GenerateTrafficControlTaskCode(string TrafficControlTaskId, GenerateTrafficControlTaskCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateTrafficControlTaskCodeWithOptions(TrafficControlTaskId, request, headers, runtime);
        }

        /**
         * @summary 产生流量调控的相关代码
         *
         * @param request GenerateTrafficControlTaskCodeRequest
         * @return GenerateTrafficControlTaskCodeResponse
         */
        public async Task<GenerateTrafficControlTaskCodeResponse> GenerateTrafficControlTaskCodeAsync(string TrafficControlTaskId, GenerateTrafficControlTaskCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateTrafficControlTaskCodeWithOptionsAsync(TrafficControlTaskId, request, headers, runtime);
        }

        /**
         * @summary 产生流量调控的相关召回配置
         *
         * @param request GenerateTrafficControlTaskConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateTrafficControlTaskConfigResponse
         */
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
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId) + "/action/config",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateTrafficControlTaskConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 产生流量调控的相关召回配置
         *
         * @param request GenerateTrafficControlTaskConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateTrafficControlTaskConfigResponse
         */
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
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId) + "/action/config",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateTrafficControlTaskConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 产生流量调控的相关召回配置
         *
         * @param request GenerateTrafficControlTaskConfigRequest
         * @return GenerateTrafficControlTaskConfigResponse
         */
        public GenerateTrafficControlTaskConfigResponse GenerateTrafficControlTaskConfig(string TrafficControlTaskId, GenerateTrafficControlTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateTrafficControlTaskConfigWithOptions(TrafficControlTaskId, request, headers, runtime);
        }

        /**
         * @summary 产生流量调控的相关召回配置
         *
         * @param request GenerateTrafficControlTaskConfigRequest
         * @return GenerateTrafficControlTaskConfigResponse
         */
        public async Task<GenerateTrafficControlTaskConfigResponse> GenerateTrafficControlTaskConfigAsync(string TrafficControlTaskId, GenerateTrafficControlTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateTrafficControlTaskConfigWithOptionsAsync(TrafficControlTaskId, request, headers, runtime);
        }

        /**
         * @summary 获取AB Test实验指标详细信息。
         *
         * @param request GetABMetricRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetABMetricResponse
         */
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

        /**
         * @summary 获取AB Test实验指标详细信息。
         *
         * @param request GetABMetricRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetABMetricResponse
         */
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

        /**
         * @summary 获取AB Test实验指标详细信息。
         *
         * @param request GetABMetricRequest
         * @return GetABMetricResponse
         */
        public GetABMetricResponse GetABMetric(string ABMetricId, GetABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetABMetricWithOptions(ABMetricId, request, headers, runtime);
        }

        /**
         * @summary 获取AB Test实验指标详细信息。
         *
         * @param request GetABMetricRequest
         * @return GetABMetricResponse
         */
        public async Task<GetABMetricResponse> GetABMetricAsync(string ABMetricId, GetABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetABMetricWithOptionsAsync(ABMetricId, request, headers, runtime);
        }

        /**
         * @summary 获取AB实验指标组详细信息。
         *
         * @param request GetABMetricGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetABMetricGroupResponse
         */
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

        /**
         * @summary 获取AB实验指标组详细信息。
         *
         * @param request GetABMetricGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetABMetricGroupResponse
         */
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

        /**
         * @summary 获取AB实验指标组详细信息。
         *
         * @param request GetABMetricGroupRequest
         * @return GetABMetricGroupResponse
         */
        public GetABMetricGroupResponse GetABMetricGroup(string ABMetricGroupId, GetABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetABMetricGroupWithOptions(ABMetricGroupId, request, headers, runtime);
        }

        /**
         * @summary 获取AB实验指标组详细信息。
         *
         * @param request GetABMetricGroupRequest
         * @return GetABMetricGroupResponse
         */
        public async Task<GetABMetricGroupResponse> GetABMetricGroupAsync(string ABMetricGroupId, GetABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetABMetricGroupWithOptionsAsync(ABMetricGroupId, request, headers, runtime);
        }

        /**
         * @summary 获取指定计算任务详细信息。
         *
         * @param request GetCalculationJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCalculationJobResponse
         */
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

        /**
         * @summary 获取指定计算任务详细信息。
         *
         * @param request GetCalculationJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCalculationJobResponse
         */
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

        /**
         * @summary 获取指定计算任务详细信息。
         *
         * @param request GetCalculationJobRequest
         * @return GetCalculationJobResponse
         */
        public GetCalculationJobResponse GetCalculationJob(string CalculationJobId, GetCalculationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCalculationJobWithOptions(CalculationJobId, request, headers, runtime);
        }

        /**
         * @summary 获取指定计算任务详细信息。
         *
         * @param request GetCalculationJobRequest
         * @return GetCalculationJobResponse
         */
        public async Task<GetCalculationJobResponse> GetCalculationJobAsync(string CalculationJobId, GetCalculationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCalculationJobWithOptionsAsync(CalculationJobId, request, headers, runtime);
        }

        /**
         * @summary 获取实验详细信息。
         *
         * @param request GetExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetExperimentResponse
         */
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

        /**
         * @summary 获取实验详细信息。
         *
         * @param request GetExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetExperimentResponse
         */
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

        /**
         * @summary 获取实验详细信息。
         *
         * @param request GetExperimentRequest
         * @return GetExperimentResponse
         */
        public GetExperimentResponse GetExperiment(string ExperimentId, GetExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary 获取实验详细信息。
         *
         * @param request GetExperimentRequest
         * @return GetExperimentResponse
         */
        public async Task<GetExperimentResponse> GetExperimentAsync(string ExperimentId, GetExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary 获取指定实验组详细信息。
         *
         * @param request GetExperimentGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetExperimentGroupResponse
         */
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

        /**
         * @summary 获取指定实验组详细信息。
         *
         * @param request GetExperimentGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetExperimentGroupResponse
         */
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

        /**
         * @summary 获取指定实验组详细信息。
         *
         * @param request GetExperimentGroupRequest
         * @return GetExperimentGroupResponse
         */
        public GetExperimentGroupResponse GetExperimentGroup(string ExperimentGroupId, GetExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetExperimentGroupWithOptions(ExperimentGroupId, request, headers, runtime);
        }

        /**
         * @summary 获取指定实验组详细信息。
         *
         * @param request GetExperimentGroupRequest
         * @return GetExperimentGroupResponse
         */
        public async Task<GetExperimentGroupResponse> GetExperimentGroupAsync(string ExperimentGroupId, GetExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetExperimentGroupWithOptionsAsync(ExperimentGroupId, request, headers, runtime);
        }

        /**
         * @summary 获取特征一致性检查任务详细信息。
         *
         * @param request GetFeatureConsistencyCheckJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFeatureConsistencyCheckJobResponse
         */
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

        /**
         * @summary 获取特征一致性检查任务详细信息。
         *
         * @param request GetFeatureConsistencyCheckJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFeatureConsistencyCheckJobResponse
         */
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

        /**
         * @summary 获取特征一致性检查任务详细信息。
         *
         * @param request GetFeatureConsistencyCheckJobRequest
         * @return GetFeatureConsistencyCheckJobResponse
         */
        public GetFeatureConsistencyCheckJobResponse GetFeatureConsistencyCheckJob(string FeatureConsistencyCheckJobId, GetFeatureConsistencyCheckJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFeatureConsistencyCheckJobWithOptions(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

        /**
         * @summary 获取特征一致性检查任务详细信息。
         *
         * @param request GetFeatureConsistencyCheckJobRequest
         * @return GetFeatureConsistencyCheckJobResponse
         */
        public async Task<GetFeatureConsistencyCheckJobResponse> GetFeatureConsistencyCheckJobAsync(string FeatureConsistencyCheckJobId, GetFeatureConsistencyCheckJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFeatureConsistencyCheckJobWithOptionsAsync(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

        /**
         * @summary 获取特征一致性检测配置详情。
         *
         * @param request GetFeatureConsistencyCheckJobConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFeatureConsistencyCheckJobConfigResponse
         */
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

        /**
         * @summary 获取特征一致性检测配置详情。
         *
         * @param request GetFeatureConsistencyCheckJobConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFeatureConsistencyCheckJobConfigResponse
         */
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

        /**
         * @summary 获取特征一致性检测配置详情。
         *
         * @param request GetFeatureConsistencyCheckJobConfigRequest
         * @return GetFeatureConsistencyCheckJobConfigResponse
         */
        public GetFeatureConsistencyCheckJobConfigResponse GetFeatureConsistencyCheckJobConfig(string FeatureConsistencyCheckJobConfigId, GetFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFeatureConsistencyCheckJobConfigWithOptions(FeatureConsistencyCheckJobConfigId, request, headers, runtime);
        }

        /**
         * @summary 获取特征一致性检测配置详情。
         *
         * @param request GetFeatureConsistencyCheckJobConfigRequest
         * @return GetFeatureConsistencyCheckJobConfigResponse
         */
        public async Task<GetFeatureConsistencyCheckJobConfigResponse> GetFeatureConsistencyCheckJobConfigAsync(string FeatureConsistencyCheckJobConfigId, GetFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFeatureConsistencyCheckJobConfigWithOptionsAsync(FeatureConsistencyCheckJobConfigId, request, headers, runtime);
        }

        /**
         * @summary 获取指定推荐全链路深度定制开发平台实例信息。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceResponse
         */
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

        /**
         * @summary 获取指定推荐全链路深度定制开发平台实例信息。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceResponse
         */
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

        /**
         * @summary 获取指定推荐全链路深度定制开发平台实例信息。
         *
         * @return GetInstanceResponse
         */
        public GetInstanceResponse GetInstance(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceWithOptions(InstanceId, headers, runtime);
        }

        /**
         * @summary 获取指定推荐全链路深度定制开发平台实例信息。
         *
         * @return GetInstanceResponse
         */
        public async Task<GetInstanceResponse> GetInstanceAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceWithOptionsAsync(InstanceId, headers, runtime);
        }

        /**
         * @summary 获取指定实例下指定资源的详细信息。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceResourceResponse
         */
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

        /**
         * @summary 获取指定实例下指定资源的详细信息。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceResourceResponse
         */
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

        /**
         * @summary 获取指定实例下指定资源的详细信息。
         *
         * @return GetInstanceResourceResponse
         */
        public GetInstanceResourceResponse GetInstanceResource(string InstanceId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceResourceWithOptions(InstanceId, ResourceId, headers, runtime);
        }

        /**
         * @summary 获取指定实例下指定资源的详细信息。
         *
         * @return GetInstanceResourceResponse
         */
        public async Task<GetInstanceResourceResponse> GetInstanceResourceAsync(string InstanceId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceResourceWithOptionsAsync(InstanceId, ResourceId, headers, runtime);
        }

        /**
         * @summary 获取数据源下指定表的详细信息。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceResourceTableResponse
         */
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

        /**
         * @summary 获取数据源下指定表的详细信息。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceResourceTableResponse
         */
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

        /**
         * @summary 获取数据源下指定表的详细信息。
         *
         * @return GetInstanceResourceTableResponse
         */
        public GetInstanceResourceTableResponse GetInstanceResourceTable(string InstanceId, string ResourceId, string TableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceResourceTableWithOptions(InstanceId, ResourceId, TableName, headers, runtime);
        }

        /**
         * @summary 获取数据源下指定表的详细信息。
         *
         * @return GetInstanceResourceTableResponse
         */
        public async Task<GetInstanceResourceTableResponse> GetInstanceResourceTableAsync(string InstanceId, string ResourceId, string TableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceResourceTableWithOptionsAsync(InstanceId, ResourceId, TableName, headers, runtime);
        }

        /**
         * @summary 获取实验室详细信息。
         *
         * @param request GetLaboratoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLaboratoryResponse
         */
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

        /**
         * @summary 获取实验室详细信息。
         *
         * @param request GetLaboratoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLaboratoryResponse
         */
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

        /**
         * @summary 获取实验室详细信息。
         *
         * @param request GetLaboratoryRequest
         * @return GetLaboratoryResponse
         */
        public GetLaboratoryResponse GetLaboratory(string LaboratoryId, GetLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLaboratoryWithOptions(LaboratoryId, request, headers, runtime);
        }

        /**
         * @summary 获取实验室详细信息。
         *
         * @param request GetLaboratoryRequest
         * @return GetLaboratoryResponse
         */
        public async Task<GetLaboratoryResponse> GetLaboratoryAsync(string LaboratoryId, GetLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLaboratoryWithOptionsAsync(LaboratoryId, request, headers, runtime);
        }

        /**
         * @summary 获取层详细信息。
         *
         * @param request GetLayerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLayerResponse
         */
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

        /**
         * @summary 获取层详细信息。
         *
         * @param request GetLayerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLayerResponse
         */
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

        /**
         * @summary 获取层详细信息。
         *
         * @param request GetLayerRequest
         * @return GetLayerResponse
         */
        public GetLayerResponse GetLayer(string LayerId, GetLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLayerWithOptions(LayerId, request, headers, runtime);
        }

        /**
         * @summary 获取层详细信息。
         *
         * @param request GetLayerRequest
         * @return GetLayerResponse
         */
        public async Task<GetLayerResponse> GetLayerAsync(string LayerId, GetLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLayerWithOptionsAsync(LayerId, request, headers, runtime);
        }

        /**
         * @summary 获取资源规则详细信息
         *
         * @param request GetResourceRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourceRuleResponse
         */
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

        /**
         * @summary 获取资源规则详细信息
         *
         * @param request GetResourceRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourceRuleResponse
         */
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

        /**
         * @summary 获取资源规则详细信息
         *
         * @param request GetResourceRuleRequest
         * @return GetResourceRuleResponse
         */
        public GetResourceRuleResponse GetResourceRule(string ResourceRuleId, GetResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetResourceRuleWithOptions(ResourceRuleId, request, headers, runtime);
        }

        /**
         * @summary 获取资源规则详细信息
         *
         * @param request GetResourceRuleRequest
         * @return GetResourceRuleResponse
         */
        public async Task<GetResourceRuleResponse> GetResourceRuleAsync(string ResourceRuleId, GetResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetResourceRuleWithOptionsAsync(ResourceRuleId, request, headers, runtime);
        }

        /**
         * @summary 获取场景详细信息
         *
         * @param request GetSceneRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSceneResponse
         */
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

        /**
         * @summary 获取场景详细信息
         *
         * @param request GetSceneRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSceneResponse
         */
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

        /**
         * @summary 获取场景详细信息
         *
         * @param request GetSceneRequest
         * @return GetSceneResponse
         */
        public GetSceneResponse GetScene(string SceneId, GetSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSceneWithOptions(SceneId, request, headers, runtime);
        }

        /**
         * @summary 获取场景详细信息
         *
         * @param request GetSceneRequest
         * @return GetSceneResponse
         */
        public async Task<GetSceneResponse> GetSceneAsync(string SceneId, GetSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSceneWithOptionsAsync(SceneId, request, headers, runtime);
        }

        /**
         * @summary 获取指定人群下的指定子人群的详细信息。
         *
         * @param request GetSubCrowdRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSubCrowdResponse
         */
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

        /**
         * @summary 获取指定人群下的指定子人群的详细信息。
         *
         * @param request GetSubCrowdRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSubCrowdResponse
         */
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

        /**
         * @summary 获取指定人群下的指定子人群的详细信息。
         *
         * @param request GetSubCrowdRequest
         * @return GetSubCrowdResponse
         */
        public GetSubCrowdResponse GetSubCrowd(string CrowdId, string SubCrowdId, GetSubCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSubCrowdWithOptions(CrowdId, SubCrowdId, request, headers, runtime);
        }

        /**
         * @summary 获取指定人群下的指定子人群的详细信息。
         *
         * @param request GetSubCrowdRequest
         * @return GetSubCrowdResponse
         */
        public async Task<GetSubCrowdResponse> GetSubCrowdAsync(string CrowdId, string SubCrowdId, GetSubCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSubCrowdWithOptionsAsync(CrowdId, SubCrowdId, request, headers, runtime);
        }

        /**
         * @summary 获取数据表详细信息。
         *
         * @param request GetTableMetaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTableMetaResponse
         */
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

        /**
         * @summary 获取数据表详细信息。
         *
         * @param request GetTableMetaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTableMetaResponse
         */
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

        /**
         * @summary 获取数据表详细信息。
         *
         * @param request GetTableMetaRequest
         * @return GetTableMetaResponse
         */
        public GetTableMetaResponse GetTableMeta(string TableMetaId, GetTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTableMetaWithOptions(TableMetaId, request, headers, runtime);
        }

        /**
         * @summary 获取数据表详细信息。
         *
         * @param request GetTableMetaRequest
         * @return GetTableMetaResponse
         */
        public async Task<GetTableMetaResponse> GetTableMetaAsync(string TableMetaId, GetTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTableMetaWithOptionsAsync(TableMetaId, request, headers, runtime);
        }

        /**
         * @summary 获取流量调控目标详情
         *
         * @param request GetTrafficControlTargetRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTrafficControlTargetResponse
         */
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

        /**
         * @summary 获取流量调控目标详情
         *
         * @param request GetTrafficControlTargetRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTrafficControlTargetResponse
         */
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

        /**
         * @summary 获取流量调控目标详情
         *
         * @param request GetTrafficControlTargetRequest
         * @return GetTrafficControlTargetResponse
         */
        public GetTrafficControlTargetResponse GetTrafficControlTarget(string TrafficControlTargetId, GetTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTrafficControlTargetWithOptions(TrafficControlTargetId, request, headers, runtime);
        }

        /**
         * @summary 获取流量调控目标详情
         *
         * @param request GetTrafficControlTargetRequest
         * @return GetTrafficControlTargetResponse
         */
        public async Task<GetTrafficControlTargetResponse> GetTrafficControlTargetAsync(string TrafficControlTargetId, GetTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTrafficControlTargetWithOptionsAsync(TrafficControlTargetId, request, headers, runtime);
        }

        /**
         * @summary 获取流量调控任务详情
         *
         * @param request GetTrafficControlTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTrafficControlTaskResponse
         */
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

        /**
         * @summary 获取流量调控任务详情
         *
         * @param request GetTrafficControlTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTrafficControlTaskResponse
         */
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

        /**
         * @summary 获取流量调控任务详情
         *
         * @param request GetTrafficControlTaskRequest
         * @return GetTrafficControlTaskResponse
         */
        public GetTrafficControlTaskResponse GetTrafficControlTask(string TrafficControlTaskId, GetTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTrafficControlTaskWithOptions(TrafficControlTaskId, request, headers, runtime);
        }

        /**
         * @summary 获取流量调控任务详情
         *
         * @param request GetTrafficControlTaskRequest
         * @return GetTrafficControlTaskResponse
         */
        public async Task<GetTrafficControlTaskResponse> GetTrafficControlTaskAsync(string TrafficControlTaskId, GetTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTrafficControlTaskWithOptionsAsync(TrafficControlTaskId, request, headers, runtime);
        }

        /**
         * @summary 获取流量调控任务的流量详情
         *
         * @param request GetTrafficControlTaskTrafficRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTrafficControlTaskTrafficResponse
         */
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
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId) + "/action/traffic",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrafficControlTaskTrafficResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取流量调控任务的流量详情
         *
         * @param request GetTrafficControlTaskTrafficRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTrafficControlTaskTrafficResponse
         */
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
                Pathname = "/api/v1/trafficcontroltasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTaskId) + "/action/traffic",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrafficControlTaskTrafficResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取流量调控任务的流量详情
         *
         * @param request GetTrafficControlTaskTrafficRequest
         * @return GetTrafficControlTaskTrafficResponse
         */
        public GetTrafficControlTaskTrafficResponse GetTrafficControlTaskTraffic(string TrafficControlTaskId, GetTrafficControlTaskTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTrafficControlTaskTrafficWithOptions(TrafficControlTaskId, request, headers, runtime);
        }

        /**
         * @summary 获取流量调控任务的流量详情
         *
         * @param request GetTrafficControlTaskTrafficRequest
         * @return GetTrafficControlTaskTrafficResponse
         */
        public async Task<GetTrafficControlTaskTrafficResponse> GetTrafficControlTaskTrafficAsync(string TrafficControlTaskId, GetTrafficControlTaskTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTrafficControlTaskTrafficWithOptionsAsync(TrafficControlTaskId, request, headers, runtime);
        }

        /**
         * @summary 获取AB Test实验指标组列表。
         *
         * @param request ListABMetricGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListABMetricGroupsResponse
         */
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

        /**
         * @summary 获取AB Test实验指标组列表。
         *
         * @param request ListABMetricGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListABMetricGroupsResponse
         */
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

        /**
         * @summary 获取AB Test实验指标组列表。
         *
         * @param request ListABMetricGroupsRequest
         * @return ListABMetricGroupsResponse
         */
        public ListABMetricGroupsResponse ListABMetricGroups(ListABMetricGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListABMetricGroupsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取AB Test实验指标组列表。
         *
         * @param request ListABMetricGroupsRequest
         * @return ListABMetricGroupsResponse
         */
        public async Task<ListABMetricGroupsResponse> ListABMetricGroupsAsync(ListABMetricGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListABMetricGroupsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取AB Test实验指标列表。
         *
         * @param request ListABMetricsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListABMetricsResponse
         */
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

        /**
         * @summary 获取AB Test实验指标列表。
         *
         * @param request ListABMetricsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListABMetricsResponse
         */
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

        /**
         * @summary 获取AB Test实验指标列表。
         *
         * @param request ListABMetricsRequest
         * @return ListABMetricsResponse
         */
        public ListABMetricsResponse ListABMetrics(ListABMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListABMetricsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取AB Test实验指标列表。
         *
         * @param request ListABMetricsRequest
         * @return ListABMetricsResponse
         */
        public async Task<ListABMetricsResponse> ListABMetricsAsync(ListABMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListABMetricsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取计算任务列表。
         *
         * @param request ListCalculationJobsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCalculationJobsResponse
         */
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

        /**
         * @summary 获取计算任务列表。
         *
         * @param request ListCalculationJobsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCalculationJobsResponse
         */
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

        /**
         * @summary 获取计算任务列表。
         *
         * @param request ListCalculationJobsRequest
         * @return ListCalculationJobsResponse
         */
        public ListCalculationJobsResponse ListCalculationJobs(ListCalculationJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCalculationJobsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取计算任务列表。
         *
         * @param request ListCalculationJobsRequest
         * @return ListCalculationJobsResponse
         */
        public async Task<ListCalculationJobsResponse> ListCalculationJobsAsync(ListCalculationJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCalculationJobsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取人群下的所有用户。
         *
         * @param request ListCrowdUsersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCrowdUsersResponse
         */
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

        /**
         * @summary 获取人群下的所有用户。
         *
         * @param request ListCrowdUsersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCrowdUsersResponse
         */
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

        /**
         * @summary 获取人群下的所有用户。
         *
         * @param request ListCrowdUsersRequest
         * @return ListCrowdUsersResponse
         */
        public ListCrowdUsersResponse ListCrowdUsers(string CrowdId, ListCrowdUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCrowdUsersWithOptions(CrowdId, request, headers, runtime);
        }

        /**
         * @summary 获取人群下的所有用户。
         *
         * @param request ListCrowdUsersRequest
         * @return ListCrowdUsersResponse
         */
        public async Task<ListCrowdUsersResponse> ListCrowdUsersAsync(string CrowdId, ListCrowdUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCrowdUsersWithOptionsAsync(CrowdId, request, headers, runtime);
        }

        /**
         * @summary 获取人群列表。
         *
         * @param request ListCrowdsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCrowdsResponse
         */
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

        /**
         * @summary 获取人群列表。
         *
         * @param request ListCrowdsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCrowdsResponse
         */
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

        /**
         * @summary 获取人群列表。
         *
         * @param request ListCrowdsRequest
         * @return ListCrowdsResponse
         */
        public ListCrowdsResponse ListCrowds(ListCrowdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCrowdsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取人群列表。
         *
         * @param request ListCrowdsRequest
         * @return ListCrowdsResponse
         */
        public async Task<ListCrowdsResponse> ListCrowdsAsync(ListCrowdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCrowdsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取实验组列表。
         *
         * @param request ListExperimentGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListExperimentGroupsResponse
         */
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

        /**
         * @summary 获取实验组列表。
         *
         * @param request ListExperimentGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListExperimentGroupsResponse
         */
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

        /**
         * @summary 获取实验组列表。
         *
         * @param request ListExperimentGroupsRequest
         * @return ListExperimentGroupsResponse
         */
        public ListExperimentGroupsResponse ListExperimentGroups(ListExperimentGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListExperimentGroupsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取实验组列表。
         *
         * @param request ListExperimentGroupsRequest
         * @return ListExperimentGroupsResponse
         */
        public async Task<ListExperimentGroupsResponse> ListExperimentGroupsAsync(ListExperimentGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListExperimentGroupsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取实验列表。
         *
         * @param request ListExperimentsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListExperimentsResponse
         */
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

        /**
         * @summary 获取实验列表。
         *
         * @param request ListExperimentsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListExperimentsResponse
         */
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

        /**
         * @summary 获取实验列表。
         *
         * @param request ListExperimentsRequest
         * @return ListExperimentsResponse
         */
        public ListExperimentsResponse ListExperiments(ListExperimentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListExperimentsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取实验列表。
         *
         * @param request ListExperimentsRequest
         * @return ListExperimentsResponse
         */
        public async Task<ListExperimentsResponse> ListExperimentsAsync(ListExperimentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListExperimentsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取特征一致性检查配置列表。
         *
         * @param request ListFeatureConsistencyCheckJobConfigsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFeatureConsistencyCheckJobConfigsResponse
         */
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

        /**
         * @summary 获取特征一致性检查配置列表。
         *
         * @param request ListFeatureConsistencyCheckJobConfigsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFeatureConsistencyCheckJobConfigsResponse
         */
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

        /**
         * @summary 获取特征一致性检查配置列表。
         *
         * @param request ListFeatureConsistencyCheckJobConfigsRequest
         * @return ListFeatureConsistencyCheckJobConfigsResponse
         */
        public ListFeatureConsistencyCheckJobConfigsResponse ListFeatureConsistencyCheckJobConfigs(ListFeatureConsistencyCheckJobConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFeatureConsistencyCheckJobConfigsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取特征一致性检查配置列表。
         *
         * @param request ListFeatureConsistencyCheckJobConfigsRequest
         * @return ListFeatureConsistencyCheckJobConfigsResponse
         */
        public async Task<ListFeatureConsistencyCheckJobConfigsResponse> ListFeatureConsistencyCheckJobConfigsAsync(ListFeatureConsistencyCheckJobConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFeatureConsistencyCheckJobConfigsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取特征一致性检查任务的特征报表/比对结果。
         *
         * @param request ListFeatureConsistencyCheckJobFeatureReportsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFeatureConsistencyCheckJobFeatureReportsResponse
         */
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

        /**
         * @summary 获取特征一致性检查任务的特征报表/比对结果。
         *
         * @param request ListFeatureConsistencyCheckJobFeatureReportsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFeatureConsistencyCheckJobFeatureReportsResponse
         */
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

        /**
         * @summary 获取特征一致性检查任务的特征报表/比对结果。
         *
         * @param request ListFeatureConsistencyCheckJobFeatureReportsRequest
         * @return ListFeatureConsistencyCheckJobFeatureReportsResponse
         */
        public ListFeatureConsistencyCheckJobFeatureReportsResponse ListFeatureConsistencyCheckJobFeatureReports(string FeatureConsistencyCheckJobId, ListFeatureConsistencyCheckJobFeatureReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFeatureConsistencyCheckJobFeatureReportsWithOptions(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

        /**
         * @summary 获取特征一致性检查任务的特征报表/比对结果。
         *
         * @param request ListFeatureConsistencyCheckJobFeatureReportsRequest
         * @return ListFeatureConsistencyCheckJobFeatureReportsResponse
         */
        public async Task<ListFeatureConsistencyCheckJobFeatureReportsResponse> ListFeatureConsistencyCheckJobFeatureReportsAsync(string FeatureConsistencyCheckJobId, ListFeatureConsistencyCheckJobFeatureReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFeatureConsistencyCheckJobFeatureReportsWithOptionsAsync(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

        /**
         * @summary 获取特征一致性检查任务分数报表/比对结果。
         *
         * @param tmpReq ListFeatureConsistencyCheckJobScoreReportsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFeatureConsistencyCheckJobScoreReportsResponse
         */
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

        /**
         * @summary 获取特征一致性检查任务分数报表/比对结果。
         *
         * @param tmpReq ListFeatureConsistencyCheckJobScoreReportsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFeatureConsistencyCheckJobScoreReportsResponse
         */
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

        /**
         * @summary 获取特征一致性检查任务分数报表/比对结果。
         *
         * @param request ListFeatureConsistencyCheckJobScoreReportsRequest
         * @return ListFeatureConsistencyCheckJobScoreReportsResponse
         */
        public ListFeatureConsistencyCheckJobScoreReportsResponse ListFeatureConsistencyCheckJobScoreReports(string FeatureConsistencyCheckJobId, ListFeatureConsistencyCheckJobScoreReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFeatureConsistencyCheckJobScoreReportsWithOptions(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

        /**
         * @summary 获取特征一致性检查任务分数报表/比对结果。
         *
         * @param request ListFeatureConsistencyCheckJobScoreReportsRequest
         * @return ListFeatureConsistencyCheckJobScoreReportsResponse
         */
        public async Task<ListFeatureConsistencyCheckJobScoreReportsResponse> ListFeatureConsistencyCheckJobScoreReportsAsync(string FeatureConsistencyCheckJobId, ListFeatureConsistencyCheckJobScoreReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFeatureConsistencyCheckJobScoreReportsWithOptionsAsync(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

        /**
         * @summary 获取特征一致性检查任务列表。
         *
         * @param request ListFeatureConsistencyCheckJobsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFeatureConsistencyCheckJobsResponse
         */
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

        /**
         * @summary 获取特征一致性检查任务列表。
         *
         * @param request ListFeatureConsistencyCheckJobsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFeatureConsistencyCheckJobsResponse
         */
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

        /**
         * @summary 获取特征一致性检查任务列表。
         *
         * @param request ListFeatureConsistencyCheckJobsRequest
         * @return ListFeatureConsistencyCheckJobsResponse
         */
        public ListFeatureConsistencyCheckJobsResponse ListFeatureConsistencyCheckJobs(ListFeatureConsistencyCheckJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFeatureConsistencyCheckJobsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取特征一致性检查任务列表。
         *
         * @param request ListFeatureConsistencyCheckJobsRequest
         * @return ListFeatureConsistencyCheckJobsResponse
         */
        public async Task<ListFeatureConsistencyCheckJobsResponse> ListFeatureConsistencyCheckJobsAsync(ListFeatureConsistencyCheckJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFeatureConsistencyCheckJobsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取实例下配置的资源列表。
         *
         * @param request ListInstanceResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstanceResourcesResponse
         */
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

        /**
         * @summary 获取实例下配置的资源列表。
         *
         * @param request ListInstanceResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstanceResourcesResponse
         */
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

        /**
         * @summary 获取实例下配置的资源列表。
         *
         * @param request ListInstanceResourcesRequest
         * @return ListInstanceResourcesResponse
         */
        public ListInstanceResourcesResponse ListInstanceResources(string InstanceId, ListInstanceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstanceResourcesWithOptions(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 获取实例下配置的资源列表。
         *
         * @param request ListInstanceResourcesRequest
         * @return ListInstanceResourcesResponse
         */
        public async Task<ListInstanceResourcesResponse> ListInstanceResourcesAsync(string InstanceId, ListInstanceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstanceResourcesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        /**
         * @summary 获取推荐全链路深度定制开发平台实例信息列表。
         *
         * @param request ListInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstancesResponse
         */
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

        /**
         * @summary 获取推荐全链路深度定制开发平台实例信息列表。
         *
         * @param request ListInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstancesResponse
         */
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

        /**
         * @summary 获取推荐全链路深度定制开发平台实例信息列表。
         *
         * @param request ListInstancesRequest
         * @return ListInstancesResponse
         */
        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstancesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取推荐全链路深度定制开发平台实例信息列表。
         *
         * @param request ListInstancesRequest
         * @return ListInstancesResponse
         */
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstancesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取实验室列表。
         *
         * @param request ListLaboratoriesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLaboratoriesResponse
         */
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

        /**
         * @summary 获取实验室列表。
         *
         * @param request ListLaboratoriesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLaboratoriesResponse
         */
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

        /**
         * @summary 获取实验室列表。
         *
         * @param request ListLaboratoriesRequest
         * @return ListLaboratoriesResponse
         */
        public ListLaboratoriesResponse ListLaboratories(ListLaboratoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLaboratoriesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取实验室列表。
         *
         * @param request ListLaboratoriesRequest
         * @return ListLaboratoriesResponse
         */
        public async Task<ListLaboratoriesResponse> ListLaboratoriesAsync(ListLaboratoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLaboratoriesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取层列表。
         *
         * @param request ListLayersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLayersResponse
         */
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

        /**
         * @summary 获取层列表。
         *
         * @param request ListLayersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLayersResponse
         */
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

        /**
         * @summary 获取层列表。
         *
         * @param request ListLayersRequest
         * @return ListLayersResponse
         */
        public ListLayersResponse ListLayers(ListLayersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLayersWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取层列表。
         *
         * @param request ListLayersRequest
         * @return ListLayersResponse
         */
        public async Task<ListLayersResponse> ListLayersAsync(ListLayersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLayersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取参数列表。
         *
         * @param request ListParamsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListParamsResponse
         */
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

        /**
         * @summary 获取参数列表。
         *
         * @param request ListParamsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListParamsResponse
         */
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

        /**
         * @summary 获取参数列表。
         *
         * @param request ListParamsRequest
         * @return ListParamsResponse
         */
        public ListParamsResponse ListParams(ListParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListParamsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取参数列表。
         *
         * @param request ListParamsRequest
         * @return ListParamsResponse
         */
        public async Task<ListParamsResponse> ListParamsAsync(ListParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListParamsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取资源规则列表
         *
         * @param request ListResourceRulesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResourceRulesResponse
         */
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

        /**
         * @summary 获取资源规则列表
         *
         * @param request ListResourceRulesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResourceRulesResponse
         */
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

        /**
         * @summary 获取资源规则列表
         *
         * @param request ListResourceRulesRequest
         * @return ListResourceRulesResponse
         */
        public ListResourceRulesResponse ListResourceRules(ListResourceRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListResourceRulesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取资源规则列表
         *
         * @param request ListResourceRulesRequest
         * @return ListResourceRulesResponse
         */
        public async Task<ListResourceRulesResponse> ListResourceRulesAsync(ListResourceRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListResourceRulesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取场景列表
         *
         * @param request ListScenesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListScenesResponse
         */
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

        /**
         * @summary 获取场景列表
         *
         * @param request ListScenesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListScenesResponse
         */
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

        /**
         * @summary 获取场景列表
         *
         * @param request ListScenesRequest
         * @return ListScenesResponse
         */
        public ListScenesResponse ListScenes(ListScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListScenesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取场景列表
         *
         * @param request ListScenesRequest
         * @return ListScenesResponse
         */
        public async Task<ListScenesResponse> ListScenesAsync(ListScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListScenesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取人群下的所有子人群。
         *
         * @param request ListSubCrowdsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSubCrowdsResponse
         */
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

        /**
         * @summary 获取人群下的所有子人群。
         *
         * @param request ListSubCrowdsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSubCrowdsResponse
         */
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

        /**
         * @summary 获取人群下的所有子人群。
         *
         * @param request ListSubCrowdsRequest
         * @return ListSubCrowdsResponse
         */
        public ListSubCrowdsResponse ListSubCrowds(string CrowdId, ListSubCrowdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSubCrowdsWithOptions(CrowdId, request, headers, runtime);
        }

        /**
         * @summary 获取人群下的所有子人群。
         *
         * @param request ListSubCrowdsRequest
         * @return ListSubCrowdsResponse
         */
        public async Task<ListSubCrowdsResponse> ListSubCrowdsAsync(string CrowdId, ListSubCrowdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSubCrowdsWithOptionsAsync(CrowdId, request, headers, runtime);
        }

        /**
         * @summary 获取数据表列表。
         *
         * @param request ListTableMetasRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTableMetasResponse
         */
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

        /**
         * @summary 获取数据表列表。
         *
         * @param request ListTableMetasRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTableMetasResponse
         */
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

        /**
         * @summary 获取数据表列表。
         *
         * @param request ListTableMetasRequest
         * @return ListTableMetasResponse
         */
        public ListTableMetasResponse ListTableMetas(ListTableMetasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTableMetasWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取数据表列表。
         *
         * @param request ListTableMetasRequest
         * @return ListTableMetasResponse
         */
        public async Task<ListTableMetasResponse> ListTableMetasAsync(ListTableMetasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTableMetasWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取流量调控任务流量变更的历史列表
         *
         * @param request ListTrafficControlTargetTrafficHistoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrafficControlTargetTrafficHistoryResponse
         */
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
                Pathname = "/api/v1/trafficcontroltargets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTargetId) + "/action/traffichistory",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrafficControlTargetTrafficHistoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取流量调控任务流量变更的历史列表
         *
         * @param request ListTrafficControlTargetTrafficHistoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrafficControlTargetTrafficHistoryResponse
         */
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
                Pathname = "/api/v1/trafficcontroltargets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TrafficControlTargetId) + "/action/traffichistory",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrafficControlTargetTrafficHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取流量调控任务流量变更的历史列表
         *
         * @param request ListTrafficControlTargetTrafficHistoryRequest
         * @return ListTrafficControlTargetTrafficHistoryResponse
         */
        public ListTrafficControlTargetTrafficHistoryResponse ListTrafficControlTargetTrafficHistory(string TrafficControlTargetId, ListTrafficControlTargetTrafficHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTrafficControlTargetTrafficHistoryWithOptions(TrafficControlTargetId, request, headers, runtime);
        }

        /**
         * @summary 获取流量调控任务流量变更的历史列表
         *
         * @param request ListTrafficControlTargetTrafficHistoryRequest
         * @return ListTrafficControlTargetTrafficHistoryResponse
         */
        public async Task<ListTrafficControlTargetTrafficHistoryResponse> ListTrafficControlTargetTrafficHistoryAsync(string TrafficControlTargetId, ListTrafficControlTargetTrafficHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTrafficControlTargetTrafficHistoryWithOptionsAsync(TrafficControlTargetId, request, headers, runtime);
        }

        /**
         * @summary 获取流量调控列表
         *
         * @param request ListTrafficControlTasksRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrafficControlTasksResponse
         */
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

        /**
         * @summary 获取流量调控列表
         *
         * @param request ListTrafficControlTasksRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrafficControlTasksResponse
         */
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

        /**
         * @summary 获取流量调控列表
         *
         * @param request ListTrafficControlTasksRequest
         * @return ListTrafficControlTasksResponse
         */
        public ListTrafficControlTasksResponse ListTrafficControlTasks(ListTrafficControlTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTrafficControlTasksWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取流量调控列表
         *
         * @param request ListTrafficControlTasksRequest
         * @return ListTrafficControlTasksResponse
         */
        public async Task<ListTrafficControlTasksResponse> ListTrafficControlTasksAsync(ListTrafficControlTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTrafficControlTasksWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 上线实验。
         *
         * @param request OfflineExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return OfflineExperimentResponse
         */
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

        /**
         * @summary 上线实验。
         *
         * @param request OfflineExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return OfflineExperimentResponse
         */
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

        /**
         * @summary 上线实验。
         *
         * @param request OfflineExperimentRequest
         * @return OfflineExperimentResponse
         */
        public OfflineExperimentResponse OfflineExperiment(string ExperimentId, OfflineExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OfflineExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary 上线实验。
         *
         * @param request OfflineExperimentRequest
         * @return OfflineExperimentResponse
         */
        public async Task<OfflineExperimentResponse> OfflineExperimentAsync(string ExperimentId, OfflineExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OfflineExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary 下线实验组。
         *
         * @param request OfflineExperimentGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return OfflineExperimentGroupResponse
         */
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

        /**
         * @summary 下线实验组。
         *
         * @param request OfflineExperimentGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return OfflineExperimentGroupResponse
         */
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

        /**
         * @summary 下线实验组。
         *
         * @param request OfflineExperimentGroupRequest
         * @return OfflineExperimentGroupResponse
         */
        public OfflineExperimentGroupResponse OfflineExperimentGroup(string ExperimentGroupId, OfflineExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OfflineExperimentGroupWithOptions(ExperimentGroupId, request, headers, runtime);
        }

        /**
         * @summary 下线实验组。
         *
         * @param request OfflineExperimentGroupRequest
         * @return OfflineExperimentGroupResponse
         */
        public async Task<OfflineExperimentGroupResponse> OfflineExperimentGroupAsync(string ExperimentGroupId, OfflineExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OfflineExperimentGroupWithOptionsAsync(ExperimentGroupId, request, headers, runtime);
        }

        /**
         * @summary 下线实验室。
         *
         * @param request OfflineLaboratoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return OfflineLaboratoryResponse
         */
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

        /**
         * @summary 下线实验室。
         *
         * @param request OfflineLaboratoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return OfflineLaboratoryResponse
         */
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

        /**
         * @summary 下线实验室。
         *
         * @param request OfflineLaboratoryRequest
         * @return OfflineLaboratoryResponse
         */
        public OfflineLaboratoryResponse OfflineLaboratory(string LaboratoryId, OfflineLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OfflineLaboratoryWithOptions(LaboratoryId, request, headers, runtime);
        }

        /**
         * @summary 下线实验室。
         *
         * @param request OfflineLaboratoryRequest
         * @return OfflineLaboratoryResponse
         */
        public async Task<OfflineLaboratoryResponse> OfflineLaboratoryAsync(string LaboratoryId, OfflineLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OfflineLaboratoryWithOptionsAsync(LaboratoryId, request, headers, runtime);
        }

        /**
         * @summary 上线实验
         *
         * @param request OnlineExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return OnlineExperimentResponse
         */
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

        /**
         * @summary 上线实验
         *
         * @param request OnlineExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return OnlineExperimentResponse
         */
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

        /**
         * @summary 上线实验
         *
         * @param request OnlineExperimentRequest
         * @return OnlineExperimentResponse
         */
        public OnlineExperimentResponse OnlineExperiment(string ExperimentId, OnlineExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OnlineExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary 上线实验
         *
         * @param request OnlineExperimentRequest
         * @return OnlineExperimentResponse
         */
        public async Task<OnlineExperimentResponse> OnlineExperimentAsync(string ExperimentId, OnlineExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OnlineExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary 上线实验组。
         *
         * @param request OnlineExperimentGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return OnlineExperimentGroupResponse
         */
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

        /**
         * @summary 上线实验组。
         *
         * @param request OnlineExperimentGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return OnlineExperimentGroupResponse
         */
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

        /**
         * @summary 上线实验组。
         *
         * @param request OnlineExperimentGroupRequest
         * @return OnlineExperimentGroupResponse
         */
        public OnlineExperimentGroupResponse OnlineExperimentGroup(string ExperimentGroupId, OnlineExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OnlineExperimentGroupWithOptions(ExperimentGroupId, request, headers, runtime);
        }

        /**
         * @summary 上线实验组。
         *
         * @param request OnlineExperimentGroupRequest
         * @return OnlineExperimentGroupResponse
         */
        public async Task<OnlineExperimentGroupResponse> OnlineExperimentGroupAsync(string ExperimentGroupId, OnlineExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OnlineExperimentGroupWithOptionsAsync(ExperimentGroupId, request, headers, runtime);
        }

        /**
         * @summary 上线实验室。
         *
         * @param request OnlineLaboratoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return OnlineLaboratoryResponse
         */
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

        /**
         * @summary 上线实验室。
         *
         * @param request OnlineLaboratoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return OnlineLaboratoryResponse
         */
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

        /**
         * @summary 上线实验室。
         *
         * @param request OnlineLaboratoryRequest
         * @return OnlineLaboratoryResponse
         */
        public OnlineLaboratoryResponse OnlineLaboratory(string LaboratoryId, OnlineLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OnlineLaboratoryWithOptions(LaboratoryId, request, headers, runtime);
        }

        /**
         * @summary 上线实验室。
         *
         * @param request OnlineLaboratoryRequest
         * @return OnlineLaboratoryResponse
         */
        public async Task<OnlineLaboratoryResponse> OnlineLaboratoryAsync(string LaboratoryId, OnlineLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OnlineLaboratoryWithOptionsAsync(LaboratoryId, request, headers, runtime);
        }

        /**
         * @summary 推全。
         *
         * @param request PushAllExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushAllExperimentResponse
         */
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

        /**
         * @summary 推全。
         *
         * @param request PushAllExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushAllExperimentResponse
         */
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

        /**
         * @summary 推全。
         *
         * @param request PushAllExperimentRequest
         * @return PushAllExperimentResponse
         */
        public PushAllExperimentResponse PushAllExperiment(string ExperimentId, PushAllExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PushAllExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary 推全。
         *
         * @param request PushAllExperimentRequest
         * @return PushAllExperimentResponse
         */
        public async Task<PushAllExperimentResponse> PushAllExperimentAsync(string ExperimentId, PushAllExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PushAllExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary 推送指标到指定资源规则
         *
         * @param tmpReq PushResourceRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushResourceRuleResponse
         */
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

        /**
         * @summary 推送指标到指定资源规则
         *
         * @param tmpReq PushResourceRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushResourceRuleResponse
         */
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

        /**
         * @summary 推送指标到指定资源规则
         *
         * @param request PushResourceRuleRequest
         * @return PushResourceRuleResponse
         */
        public PushResourceRuleResponse PushResourceRule(string ResourceRuleId, PushResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PushResourceRuleWithOptions(ResourceRuleId, request, headers, runtime);
        }

        /**
         * @summary 推送指标到指定资源规则
         *
         * @param request PushResourceRuleRequest
         * @return PushResourceRuleResponse
         */
        public async Task<PushResourceRuleResponse> PushResourceRuleAsync(string ResourceRuleId, PushResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PushResourceRuleWithOptionsAsync(ResourceRuleId, request, headers, runtime);
        }

        /**
         * @summary 发布流量调控任务
         *
         * @param request ReleaseTrafficControlTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseTrafficControlTaskResponse
         */
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

        /**
         * @summary 发布流量调控任务
         *
         * @param request ReleaseTrafficControlTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseTrafficControlTaskResponse
         */
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

        /**
         * @summary 发布流量调控任务
         *
         * @param request ReleaseTrafficControlTaskRequest
         * @return ReleaseTrafficControlTaskResponse
         */
        public ReleaseTrafficControlTaskResponse ReleaseTrafficControlTask(string TrafficControlTaskId, ReleaseTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReleaseTrafficControlTaskWithOptions(TrafficControlTaskId, request, headers, runtime);
        }

        /**
         * @summary 发布流量调控任务
         *
         * @param request ReleaseTrafficControlTaskRequest
         * @return ReleaseTrafficControlTaskResponse
         */
        public async Task<ReleaseTrafficControlTaskResponse> ReleaseTrafficControlTaskAsync(string TrafficControlTaskId, ReleaseTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReleaseTrafficControlTaskWithOptionsAsync(TrafficControlTaskId, request, headers, runtime);
        }

        /**
         * @summary 对指标组进行报表。
         *
         * @param request ReportABMetricGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReportABMetricGroupResponse
         */
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

        /**
         * @summary 对指标组进行报表。
         *
         * @param request ReportABMetricGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReportABMetricGroupResponse
         */
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

        /**
         * @summary 对指标组进行报表。
         *
         * @param request ReportABMetricGroupRequest
         * @return ReportABMetricGroupResponse
         */
        public ReportABMetricGroupResponse ReportABMetricGroup(string ABMetricGroupId, ReportABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReportABMetricGroupWithOptions(ABMetricGroupId, request, headers, runtime);
        }

        /**
         * @summary 对指标组进行报表。
         *
         * @param request ReportABMetricGroupRequest
         * @return ReportABMetricGroupResponse
         */
        public async Task<ReportABMetricGroupResponse> ReportABMetricGroupAsync(string ABMetricGroupId, ReportABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReportABMetricGroupWithOptionsAsync(ABMetricGroupId, request, headers, runtime);
        }

        /**
         * @summary 拆分流量调控目标
         *
         * @param request SplitTrafficControlTargetRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SplitTrafficControlTargetResponse
         */
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

        /**
         * @summary 拆分流量调控目标
         *
         * @param request SplitTrafficControlTargetRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SplitTrafficControlTargetResponse
         */
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

        /**
         * @summary 拆分流量调控目标
         *
         * @param request SplitTrafficControlTargetRequest
         * @return SplitTrafficControlTargetResponse
         */
        public SplitTrafficControlTargetResponse SplitTrafficControlTarget(string TrafficControlTargetId, SplitTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SplitTrafficControlTargetWithOptions(TrafficControlTargetId, request, headers, runtime);
        }

        /**
         * @summary 拆分流量调控目标
         *
         * @param request SplitTrafficControlTargetRequest
         * @return SplitTrafficControlTargetResponse
         */
        public async Task<SplitTrafficControlTargetResponse> SplitTrafficControlTargetAsync(string TrafficControlTargetId, SplitTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SplitTrafficControlTargetWithOptionsAsync(TrafficControlTargetId, request, headers, runtime);
        }

        /**
         * @summary 开启流量调控目标
         *
         * @param request StartTrafficControlTargetRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartTrafficControlTargetResponse
         */
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

        /**
         * @summary 开启流量调控目标
         *
         * @param request StartTrafficControlTargetRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartTrafficControlTargetResponse
         */
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

        /**
         * @summary 开启流量调控目标
         *
         * @param request StartTrafficControlTargetRequest
         * @return StartTrafficControlTargetResponse
         */
        public StartTrafficControlTargetResponse StartTrafficControlTarget(string TrafficControlTargetId, StartTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartTrafficControlTargetWithOptions(TrafficControlTargetId, request, headers, runtime);
        }

        /**
         * @summary 开启流量调控目标
         *
         * @param request StartTrafficControlTargetRequest
         * @return StartTrafficControlTargetResponse
         */
        public async Task<StartTrafficControlTargetResponse> StartTrafficControlTargetAsync(string TrafficControlTargetId, StartTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartTrafficControlTargetWithOptionsAsync(TrafficControlTargetId, request, headers, runtime);
        }

        /**
         * @summary 开启流量调控任务
         *
         * @param request StartTrafficControlTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartTrafficControlTaskResponse
         */
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

        /**
         * @summary 开启流量调控任务
         *
         * @param request StartTrafficControlTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartTrafficControlTaskResponse
         */
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

        /**
         * @summary 开启流量调控任务
         *
         * @param request StartTrafficControlTaskRequest
         * @return StartTrafficControlTaskResponse
         */
        public StartTrafficControlTaskResponse StartTrafficControlTask(string TrafficControlTaskId, StartTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartTrafficControlTaskWithOptions(TrafficControlTaskId, request, headers, runtime);
        }

        /**
         * @summary 开启流量调控任务
         *
         * @param request StartTrafficControlTaskRequest
         * @return StartTrafficControlTaskResponse
         */
        public async Task<StartTrafficControlTaskResponse> StartTrafficControlTaskAsync(string TrafficControlTaskId, StartTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartTrafficControlTaskWithOptionsAsync(TrafficControlTaskId, request, headers, runtime);
        }

        /**
         * @summary 停止流量调控目标
         *
         * @param request StopTrafficControlTargetRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopTrafficControlTargetResponse
         */
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

        /**
         * @summary 停止流量调控目标
         *
         * @param request StopTrafficControlTargetRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopTrafficControlTargetResponse
         */
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

        /**
         * @summary 停止流量调控目标
         *
         * @param request StopTrafficControlTargetRequest
         * @return StopTrafficControlTargetResponse
         */
        public StopTrafficControlTargetResponse StopTrafficControlTarget(string TrafficControlTargetId, StopTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopTrafficControlTargetWithOptions(TrafficControlTargetId, request, headers, runtime);
        }

        /**
         * @summary 停止流量调控目标
         *
         * @param request StopTrafficControlTargetRequest
         * @return StopTrafficControlTargetResponse
         */
        public async Task<StopTrafficControlTargetResponse> StopTrafficControlTargetAsync(string TrafficControlTargetId, StopTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopTrafficControlTargetWithOptionsAsync(TrafficControlTargetId, request, headers, runtime);
        }

        /**
         * @summary 停止流量调控任务
         *
         * @param request StopTrafficControlTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopTrafficControlTaskResponse
         */
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

        /**
         * @summary 停止流量调控任务
         *
         * @param request StopTrafficControlTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopTrafficControlTaskResponse
         */
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

        /**
         * @summary 停止流量调控任务
         *
         * @param request StopTrafficControlTaskRequest
         * @return StopTrafficControlTaskResponse
         */
        public StopTrafficControlTaskResponse StopTrafficControlTask(string TrafficControlTaskId, StopTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopTrafficControlTaskWithOptions(TrafficControlTaskId, request, headers, runtime);
        }

        /**
         * @summary 停止流量调控任务
         *
         * @param request StopTrafficControlTaskRequest
         * @return StopTrafficControlTaskResponse
         */
        public async Task<StopTrafficControlTaskResponse> StopTrafficControlTaskAsync(string TrafficControlTaskId, StopTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopTrafficControlTaskWithOptionsAsync(TrafficControlTaskId, request, headers, runtime);
        }

        /**
         * @summary 同步特征一致性检测任务重放日志。
         *
         * @param request SyncFeatureConsistencyCheckJobReplayLogRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncFeatureConsistencyCheckJobReplayLogResponse
         */
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

        /**
         * @summary 同步特征一致性检测任务重放日志。
         *
         * @param request SyncFeatureConsistencyCheckJobReplayLogRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncFeatureConsistencyCheckJobReplayLogResponse
         */
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

        /**
         * @summary 同步特征一致性检测任务重放日志。
         *
         * @param request SyncFeatureConsistencyCheckJobReplayLogRequest
         * @return SyncFeatureConsistencyCheckJobReplayLogResponse
         */
        public SyncFeatureConsistencyCheckJobReplayLogResponse SyncFeatureConsistencyCheckJobReplayLog(SyncFeatureConsistencyCheckJobReplayLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SyncFeatureConsistencyCheckJobReplayLogWithOptions(request, headers, runtime);
        }

        /**
         * @summary 同步特征一致性检测任务重放日志。
         *
         * @param request SyncFeatureConsistencyCheckJobReplayLogRequest
         * @return SyncFeatureConsistencyCheckJobReplayLogResponse
         */
        public async Task<SyncFeatureConsistencyCheckJobReplayLogResponse> SyncFeatureConsistencyCheckJobReplayLogAsync(SyncFeatureConsistencyCheckJobReplayLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SyncFeatureConsistencyCheckJobReplayLogWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 取消指定特征一致性检查正在运行中的任务。
         *
         * @param request TerminateFeatureConsistencyCheckJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TerminateFeatureConsistencyCheckJobResponse
         */
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

        /**
         * @summary 取消指定特征一致性检查正在运行中的任务。
         *
         * @param request TerminateFeatureConsistencyCheckJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TerminateFeatureConsistencyCheckJobResponse
         */
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

        /**
         * @summary 取消指定特征一致性检查正在运行中的任务。
         *
         * @param request TerminateFeatureConsistencyCheckJobRequest
         * @return TerminateFeatureConsistencyCheckJobResponse
         */
        public TerminateFeatureConsistencyCheckJobResponse TerminateFeatureConsistencyCheckJob(string FeatureConsistencyCheckJobId, TerminateFeatureConsistencyCheckJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TerminateFeatureConsistencyCheckJobWithOptions(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

        /**
         * @summary 取消指定特征一致性检查正在运行中的任务。
         *
         * @param request TerminateFeatureConsistencyCheckJobRequest
         * @return TerminateFeatureConsistencyCheckJobResponse
         */
        public async Task<TerminateFeatureConsistencyCheckJobResponse> TerminateFeatureConsistencyCheckJobAsync(string FeatureConsistencyCheckJobId, TerminateFeatureConsistencyCheckJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TerminateFeatureConsistencyCheckJobWithOptionsAsync(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

        /**
         * @summary 更新AB Test实验指标。
         *
         * @param request UpdateABMetricRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateABMetricResponse
         */
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

        /**
         * @summary 更新AB Test实验指标。
         *
         * @param request UpdateABMetricRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateABMetricResponse
         */
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

        /**
         * @summary 更新AB Test实验指标。
         *
         * @param request UpdateABMetricRequest
         * @return UpdateABMetricResponse
         */
        public UpdateABMetricResponse UpdateABMetric(string ABMetricId, UpdateABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateABMetricWithOptions(ABMetricId, request, headers, runtime);
        }

        /**
         * @summary 更新AB Test实验指标。
         *
         * @param request UpdateABMetricRequest
         * @return UpdateABMetricResponse
         */
        public async Task<UpdateABMetricResponse> UpdateABMetricAsync(string ABMetricId, UpdateABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateABMetricWithOptionsAsync(ABMetricId, request, headers, runtime);
        }

        /**
         * @summary 更新AB test实验指标组。
         *
         * @param request UpdateABMetricGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateABMetricGroupResponse
         */
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

        /**
         * @summary 更新AB test实验指标组。
         *
         * @param request UpdateABMetricGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateABMetricGroupResponse
         */
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

        /**
         * @summary 更新AB test实验指标组。
         *
         * @param request UpdateABMetricGroupRequest
         * @return UpdateABMetricGroupResponse
         */
        public UpdateABMetricGroupResponse UpdateABMetricGroup(string ABMetricGroupId, UpdateABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateABMetricGroupWithOptions(ABMetricGroupId, request, headers, runtime);
        }

        /**
         * @summary 更新AB test实验指标组。
         *
         * @param request UpdateABMetricGroupRequest
         * @return UpdateABMetricGroupResponse
         */
        public async Task<UpdateABMetricGroupResponse> UpdateABMetricGroupAsync(string ABMetricGroupId, UpdateABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateABMetricGroupWithOptionsAsync(ABMetricGroupId, request, headers, runtime);
        }

        /**
         * @summary 更新指定人群。
         *
         * @param request UpdateCrowdRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCrowdResponse
         */
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

        /**
         * @summary 更新指定人群。
         *
         * @param request UpdateCrowdRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCrowdResponse
         */
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

        /**
         * @summary 更新指定人群。
         *
         * @param request UpdateCrowdRequest
         * @return UpdateCrowdResponse
         */
        public UpdateCrowdResponse UpdateCrowd(string CrowdId, UpdateCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateCrowdWithOptions(CrowdId, request, headers, runtime);
        }

        /**
         * @summary 更新指定人群。
         *
         * @param request UpdateCrowdRequest
         * @return UpdateCrowdResponse
         */
        public async Task<UpdateCrowdResponse> UpdateCrowdAsync(string CrowdId, UpdateCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateCrowdWithOptionsAsync(CrowdId, request, headers, runtime);
        }

        /**
         * @summary 更新实验。
         *
         * @param request UpdateExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateExperimentResponse
         */
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

        /**
         * @summary 更新实验。
         *
         * @param request UpdateExperimentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateExperimentResponse
         */
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

        /**
         * @summary 更新实验。
         *
         * @param request UpdateExperimentRequest
         * @return UpdateExperimentResponse
         */
        public UpdateExperimentResponse UpdateExperiment(string ExperimentId, UpdateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary 更新实验。
         *
         * @param request UpdateExperimentRequest
         * @return UpdateExperimentResponse
         */
        public async Task<UpdateExperimentResponse> UpdateExperimentAsync(string ExperimentId, UpdateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /**
         * @summary 更新指定实验组。
         *
         * @param request UpdateExperimentGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateExperimentGroupResponse
         */
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

        /**
         * @summary 更新指定实验组。
         *
         * @param request UpdateExperimentGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateExperimentGroupResponse
         */
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

        /**
         * @summary 更新指定实验组。
         *
         * @param request UpdateExperimentGroupRequest
         * @return UpdateExperimentGroupResponse
         */
        public UpdateExperimentGroupResponse UpdateExperimentGroup(string ExperimentGroupId, UpdateExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateExperimentGroupWithOptions(ExperimentGroupId, request, headers, runtime);
        }

        /**
         * @summary 更新指定实验组。
         *
         * @param request UpdateExperimentGroupRequest
         * @return UpdateExperimentGroupResponse
         */
        public async Task<UpdateExperimentGroupResponse> UpdateExperimentGroupAsync(string ExperimentGroupId, UpdateExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateExperimentGroupWithOptionsAsync(ExperimentGroupId, request, headers, runtime);
        }

        /**
         * @summary 更新特征一致性检查配置信息。
         *
         * @param request UpdateFeatureConsistencyCheckJobConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFeatureConsistencyCheckJobConfigResponse
         */
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

        /**
         * @summary 更新特征一致性检查配置信息。
         *
         * @param request UpdateFeatureConsistencyCheckJobConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFeatureConsistencyCheckJobConfigResponse
         */
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

        /**
         * @summary 更新特征一致性检查配置信息。
         *
         * @param request UpdateFeatureConsistencyCheckJobConfigRequest
         * @return UpdateFeatureConsistencyCheckJobConfigResponse
         */
        public UpdateFeatureConsistencyCheckJobConfigResponse UpdateFeatureConsistencyCheckJobConfig(string FeatureConsistencyCheckJobConfigId, UpdateFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFeatureConsistencyCheckJobConfigWithOptions(FeatureConsistencyCheckJobConfigId, request, headers, runtime);
        }

        /**
         * @summary 更新特征一致性检查配置信息。
         *
         * @param request UpdateFeatureConsistencyCheckJobConfigRequest
         * @return UpdateFeatureConsistencyCheckJobConfigResponse
         */
        public async Task<UpdateFeatureConsistencyCheckJobConfigResponse> UpdateFeatureConsistencyCheckJobConfigAsync(string FeatureConsistencyCheckJobConfigId, UpdateFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFeatureConsistencyCheckJobConfigWithOptionsAsync(FeatureConsistencyCheckJobConfigId, request, headers, runtime);
        }

        /**
         * @summary 更新指定实例下指定资源的信息。
         *
         * @param request UpdateInstanceResourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceResourceResponse
         */
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

        /**
         * @summary 更新指定实例下指定资源的信息。
         *
         * @param request UpdateInstanceResourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceResourceResponse
         */
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

        /**
         * @summary 更新指定实例下指定资源的信息。
         *
         * @param request UpdateInstanceResourceRequest
         * @return UpdateInstanceResourceResponse
         */
        public UpdateInstanceResourceResponse UpdateInstanceResource(string InstanceId, string ResourceId, UpdateInstanceResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateInstanceResourceWithOptions(InstanceId, ResourceId, request, headers, runtime);
        }

        /**
         * @summary 更新指定实例下指定资源的信息。
         *
         * @param request UpdateInstanceResourceRequest
         * @return UpdateInstanceResourceResponse
         */
        public async Task<UpdateInstanceResourceResponse> UpdateInstanceResourceAsync(string InstanceId, string ResourceId, UpdateInstanceResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateInstanceResourceWithOptionsAsync(InstanceId, ResourceId, request, headers, runtime);
        }

        /**
         * @summary 更新实验室。
         *
         * @param request UpdateLaboratoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLaboratoryResponse
         */
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

        /**
         * @summary 更新实验室。
         *
         * @param request UpdateLaboratoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLaboratoryResponse
         */
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

        /**
         * @summary 更新实验室。
         *
         * @param request UpdateLaboratoryRequest
         * @return UpdateLaboratoryResponse
         */
        public UpdateLaboratoryResponse UpdateLaboratory(string LaboratoryId, UpdateLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLaboratoryWithOptions(LaboratoryId, request, headers, runtime);
        }

        /**
         * @summary 更新实验室。
         *
         * @param request UpdateLaboratoryRequest
         * @return UpdateLaboratoryResponse
         */
        public async Task<UpdateLaboratoryResponse> UpdateLaboratoryAsync(string LaboratoryId, UpdateLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLaboratoryWithOptionsAsync(LaboratoryId, request, headers, runtime);
        }

        /**
         * @summary 更新层。
         *
         * @param request UpdateLayerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLayerResponse
         */
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

        /**
         * @summary 更新层。
         *
         * @param request UpdateLayerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLayerResponse
         */
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

        /**
         * @summary 更新层。
         *
         * @param request UpdateLayerRequest
         * @return UpdateLayerResponse
         */
        public UpdateLayerResponse UpdateLayer(string LayerId, UpdateLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLayerWithOptions(LayerId, request, headers, runtime);
        }

        /**
         * @summary 更新层。
         *
         * @param request UpdateLayerRequest
         * @return UpdateLayerResponse
         */
        public async Task<UpdateLayerResponse> UpdateLayerAsync(string LayerId, UpdateLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLayerWithOptionsAsync(LayerId, request, headers, runtime);
        }

        /**
         * @summary 更新参数。
         *
         * @param request UpdateParamRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateParamResponse
         */
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

        /**
         * @summary 更新参数。
         *
         * @param request UpdateParamRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateParamResponse
         */
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

        /**
         * @summary 更新参数。
         *
         * @param request UpdateParamRequest
         * @return UpdateParamResponse
         */
        public UpdateParamResponse UpdateParam(string ParamId, UpdateParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateParamWithOptions(ParamId, request, headers, runtime);
        }

        /**
         * @summary 更新参数。
         *
         * @param request UpdateParamRequest
         * @return UpdateParamResponse
         */
        public async Task<UpdateParamResponse> UpdateParamAsync(string ParamId, UpdateParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateParamWithOptionsAsync(ParamId, request, headers, runtime);
        }

        /**
         * @summary 获取资源规则列表
         *
         * @param request UpdateResourceRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResourceRuleResponse
         */
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

        /**
         * @summary 获取资源规则列表
         *
         * @param request UpdateResourceRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResourceRuleResponse
         */
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

        /**
         * @summary 获取资源规则列表
         *
         * @param request UpdateResourceRuleRequest
         * @return UpdateResourceRuleResponse
         */
        public UpdateResourceRuleResponse UpdateResourceRule(string ResourceRuleId, UpdateResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateResourceRuleWithOptions(ResourceRuleId, request, headers, runtime);
        }

        /**
         * @summary 获取资源规则列表
         *
         * @param request UpdateResourceRuleRequest
         * @return UpdateResourceRuleResponse
         */
        public async Task<UpdateResourceRuleResponse> UpdateResourceRuleAsync(string ResourceRuleId, UpdateResourceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateResourceRuleWithOptionsAsync(ResourceRuleId, request, headers, runtime);
        }

        /**
         * @summary 更新资源规则条目
         *
         * @param request UpdateResourceRuleItemRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResourceRuleItemResponse
         */
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

        /**
         * @summary 更新资源规则条目
         *
         * @param request UpdateResourceRuleItemRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResourceRuleItemResponse
         */
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

        /**
         * @summary 更新资源规则条目
         *
         * @param request UpdateResourceRuleItemRequest
         * @return UpdateResourceRuleItemResponse
         */
        public UpdateResourceRuleItemResponse UpdateResourceRuleItem(string ResourceRuleId, string ResourceRuleItemId, UpdateResourceRuleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateResourceRuleItemWithOptions(ResourceRuleId, ResourceRuleItemId, request, headers, runtime);
        }

        /**
         * @summary 更新资源规则条目
         *
         * @param request UpdateResourceRuleItemRequest
         * @return UpdateResourceRuleItemResponse
         */
        public async Task<UpdateResourceRuleItemResponse> UpdateResourceRuleItemAsync(string ResourceRuleId, string ResourceRuleItemId, UpdateResourceRuleItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateResourceRuleItemWithOptionsAsync(ResourceRuleId, ResourceRuleItemId, request, headers, runtime);
        }

        /**
         * @summary 更新场景
         *
         * @param request UpdateSceneRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSceneResponse
         */
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

        /**
         * @summary 更新场景
         *
         * @param request UpdateSceneRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSceneResponse
         */
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

        /**
         * @summary 更新场景
         *
         * @param request UpdateSceneRequest
         * @return UpdateSceneResponse
         */
        public UpdateSceneResponse UpdateScene(string SceneId, UpdateSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSceneWithOptions(SceneId, request, headers, runtime);
        }

        /**
         * @summary 更新场景
         *
         * @param request UpdateSceneRequest
         * @return UpdateSceneResponse
         */
        public async Task<UpdateSceneResponse> UpdateSceneAsync(string SceneId, UpdateSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSceneWithOptionsAsync(SceneId, request, headers, runtime);
        }

        /**
         * @summary 获取数据表详细信息。
         *
         * @param request UpdateTableMetaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTableMetaResponse
         */
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

        /**
         * @summary 获取数据表详细信息。
         *
         * @param request UpdateTableMetaRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTableMetaResponse
         */
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

        /**
         * @summary 获取数据表详细信息。
         *
         * @param request UpdateTableMetaRequest
         * @return UpdateTableMetaResponse
         */
        public UpdateTableMetaResponse UpdateTableMeta(string TableMetaId, UpdateTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTableMetaWithOptions(TableMetaId, request, headers, runtime);
        }

        /**
         * @summary 获取数据表详细信息。
         *
         * @param request UpdateTableMetaRequest
         * @return UpdateTableMetaResponse
         */
        public async Task<UpdateTableMetaResponse> UpdateTableMetaAsync(string TableMetaId, UpdateTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTableMetaWithOptionsAsync(TableMetaId, request, headers, runtime);
        }

        /**
         * @summary 更新流量调控目标
         *
         * @param request UpdateTrafficControlTargetRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTrafficControlTargetResponse
         */
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

        /**
         * @summary 更新流量调控目标
         *
         * @param request UpdateTrafficControlTargetRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTrafficControlTargetResponse
         */
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

        /**
         * @summary 更新流量调控目标
         *
         * @param request UpdateTrafficControlTargetRequest
         * @return UpdateTrafficControlTargetResponse
         */
        public UpdateTrafficControlTargetResponse UpdateTrafficControlTarget(string TrafficControlTargetId, UpdateTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTrafficControlTargetWithOptions(TrafficControlTargetId, request, headers, runtime);
        }

        /**
         * @summary 更新流量调控目标
         *
         * @param request UpdateTrafficControlTargetRequest
         * @return UpdateTrafficControlTargetResponse
         */
        public async Task<UpdateTrafficControlTargetResponse> UpdateTrafficControlTargetAsync(string TrafficControlTargetId, UpdateTrafficControlTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTrafficControlTargetWithOptionsAsync(TrafficControlTargetId, request, headers, runtime);
        }

        /**
         * @summary 更新流量调控任务
         *
         * @param request UpdateTrafficControlTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTrafficControlTaskResponse
         */
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

        /**
         * @summary 更新流量调控任务
         *
         * @param request UpdateTrafficControlTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTrafficControlTaskResponse
         */
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

        /**
         * @summary 更新流量调控任务
         *
         * @param request UpdateTrafficControlTaskRequest
         * @return UpdateTrafficControlTaskResponse
         */
        public UpdateTrafficControlTaskResponse UpdateTrafficControlTask(string TrafficControlTaskId, UpdateTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTrafficControlTaskWithOptions(TrafficControlTaskId, request, headers, runtime);
        }

        /**
         * @summary 更新流量调控任务
         *
         * @param request UpdateTrafficControlTaskRequest
         * @return UpdateTrafficControlTaskResponse
         */
        public async Task<UpdateTrafficControlTaskResponse> UpdateTrafficControlTaskAsync(string TrafficControlTaskId, UpdateTrafficControlTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTrafficControlTaskWithOptionsAsync(TrafficControlTaskId, request, headers, runtime);
        }

        /**
         * @summary 更新流量调控任务的流量参数
         *
         * @param request UpdateTrafficControlTaskTrafficRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTrafficControlTaskTrafficResponse
         */
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

        /**
         * @summary 更新流量调控任务的流量参数
         *
         * @param request UpdateTrafficControlTaskTrafficRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTrafficControlTaskTrafficResponse
         */
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

        /**
         * @summary 更新流量调控任务的流量参数
         *
         * @param request UpdateTrafficControlTaskTrafficRequest
         * @return UpdateTrafficControlTaskTrafficResponse
         */
        public UpdateTrafficControlTaskTrafficResponse UpdateTrafficControlTaskTraffic(string TrafficControlTaskId, UpdateTrafficControlTaskTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTrafficControlTaskTrafficWithOptions(TrafficControlTaskId, request, headers, runtime);
        }

        /**
         * @summary 更新流量调控任务的流量参数
         *
         * @param request UpdateTrafficControlTaskTrafficRequest
         * @return UpdateTrafficControlTaskTrafficResponse
         */
        public async Task<UpdateTrafficControlTaskTrafficResponse> UpdateTrafficControlTaskTrafficAsync(string TrafficControlTaskId, UpdateTrafficControlTaskTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTrafficControlTaskTrafficWithOptionsAsync(TrafficControlTaskId, request, headers, runtime);
        }

        /**
         * @summary 上传数据
         *
         * @param request UploadRecommendationDataRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadRecommendationDataResponse
         */
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

        /**
         * @summary 上传数据
         *
         * @param request UploadRecommendationDataRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadRecommendationDataResponse
         */
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

        /**
         * @summary 上传数据
         *
         * @param request UploadRecommendationDataRequest
         * @return UploadRecommendationDataResponse
         */
        public UploadRecommendationDataResponse UploadRecommendationData(UploadRecommendationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UploadRecommendationDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary 上传数据
         *
         * @param request UploadRecommendationDataRequest
         * @return UploadRecommendationDataResponse
         */
        public async Task<UploadRecommendationDataResponse> UploadRecommendationDataAsync(UploadRecommendationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UploadRecommendationDataWithOptionsAsync(request, headers, runtime);
        }

    }
}
