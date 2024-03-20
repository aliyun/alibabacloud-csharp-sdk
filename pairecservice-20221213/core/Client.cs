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

        public BackflowFeatureConsistencyCheckJobDataResponse BackflowFeatureConsistencyCheckJobData(BackflowFeatureConsistencyCheckJobDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BackflowFeatureConsistencyCheckJobDataWithOptions(request, headers, runtime);
        }

        public async Task<BackflowFeatureConsistencyCheckJobDataResponse> BackflowFeatureConsistencyCheckJobDataAsync(BackflowFeatureConsistencyCheckJobDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BackflowFeatureConsistencyCheckJobDataWithOptionsAsync(request, headers, runtime);
        }

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

        public CheckInstanceResourcesResponse CheckInstanceResources(string InstanceId, CheckInstanceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CheckInstanceResourcesWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<CheckInstanceResourcesResponse> CheckInstanceResourcesAsync(string InstanceId, CheckInstanceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CheckInstanceResourcesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

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

        public CloneExperimentResponse CloneExperiment(string ExperimentId, CloneExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        public async Task<CloneExperimentResponse> CloneExperimentAsync(string ExperimentId, CloneExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

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

        public CloneExperimentGroupResponse CloneExperimentGroup(string ExperimentGroupId, CloneExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneExperimentGroupWithOptions(ExperimentGroupId, request, headers, runtime);
        }

        public async Task<CloneExperimentGroupResponse> CloneExperimentGroupAsync(string ExperimentGroupId, CloneExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneExperimentGroupWithOptionsAsync(ExperimentGroupId, request, headers, runtime);
        }

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

        public CloneFeatureConsistencyCheckJobConfigResponse CloneFeatureConsistencyCheckJobConfig(string SourceFeatureConsistencyCheckJobConfigId, CloneFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneFeatureConsistencyCheckJobConfigWithOptions(SourceFeatureConsistencyCheckJobConfigId, request, headers, runtime);
        }

        public async Task<CloneFeatureConsistencyCheckJobConfigResponse> CloneFeatureConsistencyCheckJobConfigAsync(string SourceFeatureConsistencyCheckJobConfigId, CloneFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneFeatureConsistencyCheckJobConfigWithOptionsAsync(SourceFeatureConsistencyCheckJobConfigId, request, headers, runtime);
        }

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

        public CloneLaboratoryResponse CloneLaboratory(string LaboratoryId, CloneLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneLaboratoryWithOptions(LaboratoryId, request, headers, runtime);
        }

        public async Task<CloneLaboratoryResponse> CloneLaboratoryAsync(string LaboratoryId, CloneLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneLaboratoryWithOptionsAsync(LaboratoryId, request, headers, runtime);
        }

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

        public CreateABMetricResponse CreateABMetric(CreateABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateABMetricWithOptions(request, headers, runtime);
        }

        public async Task<CreateABMetricResponse> CreateABMetricAsync(CreateABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateABMetricWithOptionsAsync(request, headers, runtime);
        }

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

        public CreateABMetricGroupResponse CreateABMetricGroup(CreateABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateABMetricGroupWithOptions(request, headers, runtime);
        }

        public async Task<CreateABMetricGroupResponse> CreateABMetricGroupAsync(CreateABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateABMetricGroupWithOptionsAsync(request, headers, runtime);
        }

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

        public CreateCalculationJobsResponse CreateCalculationJobs(CreateCalculationJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCalculationJobsWithOptions(request, headers, runtime);
        }

        public async Task<CreateCalculationJobsResponse> CreateCalculationJobsAsync(CreateCalculationJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCalculationJobsWithOptionsAsync(request, headers, runtime);
        }

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

        public CreateCrowdResponse CreateCrowd(CreateCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCrowdWithOptions(request, headers, runtime);
        }

        public async Task<CreateCrowdResponse> CreateCrowdAsync(CreateCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCrowdWithOptionsAsync(request, headers, runtime);
        }

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

        public CreateExperimentResponse CreateExperiment(CreateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateExperimentWithOptions(request, headers, runtime);
        }

        public async Task<CreateExperimentResponse> CreateExperimentAsync(CreateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateExperimentWithOptionsAsync(request, headers, runtime);
        }

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

        public CreateExperimentGroupResponse CreateExperimentGroup(CreateExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateExperimentGroupWithOptions(request, headers, runtime);
        }

        public async Task<CreateExperimentGroupResponse> CreateExperimentGroupAsync(CreateExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateExperimentGroupWithOptionsAsync(request, headers, runtime);
        }

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

        public CreateFeatureConsistencyCheckJobResponse CreateFeatureConsistencyCheckJob(CreateFeatureConsistencyCheckJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFeatureConsistencyCheckJobWithOptions(request, headers, runtime);
        }

        public async Task<CreateFeatureConsistencyCheckJobResponse> CreateFeatureConsistencyCheckJobAsync(CreateFeatureConsistencyCheckJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFeatureConsistencyCheckJobWithOptionsAsync(request, headers, runtime);
        }

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

        public CreateFeatureConsistencyCheckJobConfigResponse CreateFeatureConsistencyCheckJobConfig(CreateFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFeatureConsistencyCheckJobConfigWithOptions(request, headers, runtime);
        }

        public async Task<CreateFeatureConsistencyCheckJobConfigResponse> CreateFeatureConsistencyCheckJobConfigAsync(CreateFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFeatureConsistencyCheckJobConfigWithOptionsAsync(request, headers, runtime);
        }

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

        public CreateInstanceResourceResponse CreateInstanceResource(string InstanceId, CreateInstanceResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceResourceWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<CreateInstanceResourceResponse> CreateInstanceResourceAsync(string InstanceId, CreateInstanceResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceResourceWithOptionsAsync(InstanceId, request, headers, runtime);
        }

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

        public CreateLaboratoryResponse CreateLaboratory(CreateLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLaboratoryWithOptions(request, headers, runtime);
        }

        public async Task<CreateLaboratoryResponse> CreateLaboratoryAsync(CreateLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLaboratoryWithOptionsAsync(request, headers, runtime);
        }

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

        public CreateLayerResponse CreateLayer(CreateLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLayerWithOptions(request, headers, runtime);
        }

        public async Task<CreateLayerResponse> CreateLayerAsync(CreateLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLayerWithOptionsAsync(request, headers, runtime);
        }

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

        public CreateParamResponse CreateParam(CreateParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateParamWithOptions(request, headers, runtime);
        }

        public async Task<CreateParamResponse> CreateParamAsync(CreateParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateParamWithOptionsAsync(request, headers, runtime);
        }

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

        public CreateSceneResponse CreateScene(CreateSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSceneWithOptions(request, headers, runtime);
        }

        public async Task<CreateSceneResponse> CreateSceneAsync(CreateSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSceneWithOptionsAsync(request, headers, runtime);
        }

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

        public CreateSubCrowdResponse CreateSubCrowd(string CrowdId, CreateSubCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSubCrowdWithOptions(CrowdId, request, headers, runtime);
        }

        public async Task<CreateSubCrowdResponse> CreateSubCrowdAsync(string CrowdId, CreateSubCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSubCrowdWithOptionsAsync(CrowdId, request, headers, runtime);
        }

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

        public CreateTableMetaResponse CreateTableMeta(CreateTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTableMetaWithOptions(request, headers, runtime);
        }

        public async Task<CreateTableMetaResponse> CreateTableMetaAsync(CreateTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTableMetaWithOptionsAsync(request, headers, runtime);
        }

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

        public DeleteABMetricResponse DeleteABMetric(string ABMetricId, DeleteABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteABMetricWithOptions(ABMetricId, request, headers, runtime);
        }

        public async Task<DeleteABMetricResponse> DeleteABMetricAsync(string ABMetricId, DeleteABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteABMetricWithOptionsAsync(ABMetricId, request, headers, runtime);
        }

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

        public DeleteABMetricGroupResponse DeleteABMetricGroup(string ABMetricGroupId, DeleteABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteABMetricGroupWithOptions(ABMetricGroupId, request, headers, runtime);
        }

        public async Task<DeleteABMetricGroupResponse> DeleteABMetricGroupAsync(string ABMetricGroupId, DeleteABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteABMetricGroupWithOptionsAsync(ABMetricGroupId, request, headers, runtime);
        }

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

        public DeleteCrowdResponse DeleteCrowd(string CrowdId, DeleteCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteCrowdWithOptions(CrowdId, request, headers, runtime);
        }

        public async Task<DeleteCrowdResponse> DeleteCrowdAsync(string CrowdId, DeleteCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteCrowdWithOptionsAsync(CrowdId, request, headers, runtime);
        }

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

        public DeleteExperimentResponse DeleteExperiment(string ExperimentId, DeleteExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        public async Task<DeleteExperimentResponse> DeleteExperimentAsync(string ExperimentId, DeleteExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

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

        public DeleteExperimentGroupResponse DeleteExperimentGroup(string ExperimentGroupId, DeleteExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteExperimentGroupWithOptions(ExperimentGroupId, request, headers, runtime);
        }

        public async Task<DeleteExperimentGroupResponse> DeleteExperimentGroupAsync(string ExperimentGroupId, DeleteExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteExperimentGroupWithOptionsAsync(ExperimentGroupId, request, headers, runtime);
        }

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

        public DeleteInstanceResourceResponse DeleteInstanceResource(string InstanceId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteInstanceResourceWithOptions(InstanceId, ResourceId, headers, runtime);
        }

        public async Task<DeleteInstanceResourceResponse> DeleteInstanceResourceAsync(string InstanceId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteInstanceResourceWithOptionsAsync(InstanceId, ResourceId, headers, runtime);
        }

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

        public DeleteLaboratoryResponse DeleteLaboratory(string LaboratoryId, DeleteLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLaboratoryWithOptions(LaboratoryId, request, headers, runtime);
        }

        public async Task<DeleteLaboratoryResponse> DeleteLaboratoryAsync(string LaboratoryId, DeleteLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteLaboratoryWithOptionsAsync(LaboratoryId, request, headers, runtime);
        }

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

        public DeleteLayerResponse DeleteLayer(string LayerId, DeleteLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLayerWithOptions(LayerId, request, headers, runtime);
        }

        public async Task<DeleteLayerResponse> DeleteLayerAsync(string LayerId, DeleteLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteLayerWithOptionsAsync(LayerId, request, headers, runtime);
        }

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

        public DeleteParamResponse DeleteParam(string ParamId, DeleteParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteParamWithOptions(ParamId, request, headers, runtime);
        }

        public async Task<DeleteParamResponse> DeleteParamAsync(string ParamId, DeleteParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteParamWithOptionsAsync(ParamId, request, headers, runtime);
        }

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

        public DeleteSceneResponse DeleteScene(string SceneId, DeleteSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSceneWithOptions(SceneId, request, headers, runtime);
        }

        public async Task<DeleteSceneResponse> DeleteSceneAsync(string SceneId, DeleteSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSceneWithOptionsAsync(SceneId, request, headers, runtime);
        }

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

        public DeleteSubCrowdResponse DeleteSubCrowd(string CrowdId, string SubCrowdId, DeleteSubCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSubCrowdWithOptions(CrowdId, SubCrowdId, request, headers, runtime);
        }

        public async Task<DeleteSubCrowdResponse> DeleteSubCrowdAsync(string CrowdId, string SubCrowdId, DeleteSubCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSubCrowdWithOptionsAsync(CrowdId, SubCrowdId, request, headers, runtime);
        }

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

        public DeleteTableMetaResponse DeleteTableMeta(string TableMetaId, DeleteTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTableMetaWithOptions(TableMetaId, request, headers, runtime);
        }

        public async Task<DeleteTableMetaResponse> DeleteTableMetaAsync(string TableMetaId, DeleteTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTableMetaWithOptionsAsync(TableMetaId, request, headers, runtime);
        }

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

        public GetABMetricResponse GetABMetric(string ABMetricId, GetABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetABMetricWithOptions(ABMetricId, request, headers, runtime);
        }

        public async Task<GetABMetricResponse> GetABMetricAsync(string ABMetricId, GetABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetABMetricWithOptionsAsync(ABMetricId, request, headers, runtime);
        }

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

        public GetABMetricGroupResponse GetABMetricGroup(string ABMetricGroupId, GetABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetABMetricGroupWithOptions(ABMetricGroupId, request, headers, runtime);
        }

        public async Task<GetABMetricGroupResponse> GetABMetricGroupAsync(string ABMetricGroupId, GetABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetABMetricGroupWithOptionsAsync(ABMetricGroupId, request, headers, runtime);
        }

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

        public GetCalculationJobResponse GetCalculationJob(string CalculationJobId, GetCalculationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCalculationJobWithOptions(CalculationJobId, request, headers, runtime);
        }

        public async Task<GetCalculationJobResponse> GetCalculationJobAsync(string CalculationJobId, GetCalculationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCalculationJobWithOptionsAsync(CalculationJobId, request, headers, runtime);
        }

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

        public GetExperimentResponse GetExperiment(string ExperimentId, GetExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        public async Task<GetExperimentResponse> GetExperimentAsync(string ExperimentId, GetExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

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

        public GetExperimentGroupResponse GetExperimentGroup(string ExperimentGroupId, GetExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetExperimentGroupWithOptions(ExperimentGroupId, request, headers, runtime);
        }

        public async Task<GetExperimentGroupResponse> GetExperimentGroupAsync(string ExperimentGroupId, GetExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetExperimentGroupWithOptionsAsync(ExperimentGroupId, request, headers, runtime);
        }

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

        public GetFeatureConsistencyCheckJobResponse GetFeatureConsistencyCheckJob(string FeatureConsistencyCheckJobId, GetFeatureConsistencyCheckJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFeatureConsistencyCheckJobWithOptions(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

        public async Task<GetFeatureConsistencyCheckJobResponse> GetFeatureConsistencyCheckJobAsync(string FeatureConsistencyCheckJobId, GetFeatureConsistencyCheckJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFeatureConsistencyCheckJobWithOptionsAsync(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

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

        public GetFeatureConsistencyCheckJobConfigResponse GetFeatureConsistencyCheckJobConfig(string FeatureConsistencyCheckJobConfigId, GetFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFeatureConsistencyCheckJobConfigWithOptions(FeatureConsistencyCheckJobConfigId, request, headers, runtime);
        }

        public async Task<GetFeatureConsistencyCheckJobConfigResponse> GetFeatureConsistencyCheckJobConfigAsync(string FeatureConsistencyCheckJobConfigId, GetFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFeatureConsistencyCheckJobConfigWithOptionsAsync(FeatureConsistencyCheckJobConfigId, request, headers, runtime);
        }

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

        public GetInstanceResponse GetInstance(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceWithOptions(InstanceId, headers, runtime);
        }

        public async Task<GetInstanceResponse> GetInstanceAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceWithOptionsAsync(InstanceId, headers, runtime);
        }

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

        public GetInstanceResourceResponse GetInstanceResource(string InstanceId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceResourceWithOptions(InstanceId, ResourceId, headers, runtime);
        }

        public async Task<GetInstanceResourceResponse> GetInstanceResourceAsync(string InstanceId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceResourceWithOptionsAsync(InstanceId, ResourceId, headers, runtime);
        }

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

        public GetInstanceResourceTableResponse GetInstanceResourceTable(string InstanceId, string ResourceId, string TableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceResourceTableWithOptions(InstanceId, ResourceId, TableName, headers, runtime);
        }

        public async Task<GetInstanceResourceTableResponse> GetInstanceResourceTableAsync(string InstanceId, string ResourceId, string TableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceResourceTableWithOptionsAsync(InstanceId, ResourceId, TableName, headers, runtime);
        }

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

        public GetLaboratoryResponse GetLaboratory(string LaboratoryId, GetLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLaboratoryWithOptions(LaboratoryId, request, headers, runtime);
        }

        public async Task<GetLaboratoryResponse> GetLaboratoryAsync(string LaboratoryId, GetLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLaboratoryWithOptionsAsync(LaboratoryId, request, headers, runtime);
        }

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

        public GetLayerResponse GetLayer(string LayerId, GetLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLayerWithOptions(LayerId, request, headers, runtime);
        }

        public async Task<GetLayerResponse> GetLayerAsync(string LayerId, GetLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLayerWithOptionsAsync(LayerId, request, headers, runtime);
        }

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

        public GetSceneResponse GetScene(string SceneId, GetSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSceneWithOptions(SceneId, request, headers, runtime);
        }

        public async Task<GetSceneResponse> GetSceneAsync(string SceneId, GetSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSceneWithOptionsAsync(SceneId, request, headers, runtime);
        }

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

        public GetSubCrowdResponse GetSubCrowd(string CrowdId, string SubCrowdId, GetSubCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSubCrowdWithOptions(CrowdId, SubCrowdId, request, headers, runtime);
        }

        public async Task<GetSubCrowdResponse> GetSubCrowdAsync(string CrowdId, string SubCrowdId, GetSubCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSubCrowdWithOptionsAsync(CrowdId, SubCrowdId, request, headers, runtime);
        }

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

        public GetTableMetaResponse GetTableMeta(string TableMetaId, GetTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTableMetaWithOptions(TableMetaId, request, headers, runtime);
        }

        public async Task<GetTableMetaResponse> GetTableMetaAsync(string TableMetaId, GetTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTableMetaWithOptionsAsync(TableMetaId, request, headers, runtime);
        }

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

        public ListABMetricGroupsResponse ListABMetricGroups(ListABMetricGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListABMetricGroupsWithOptions(request, headers, runtime);
        }

        public async Task<ListABMetricGroupsResponse> ListABMetricGroupsAsync(ListABMetricGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListABMetricGroupsWithOptionsAsync(request, headers, runtime);
        }

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

        public ListABMetricsResponse ListABMetrics(ListABMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListABMetricsWithOptions(request, headers, runtime);
        }

        public async Task<ListABMetricsResponse> ListABMetricsAsync(ListABMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListABMetricsWithOptionsAsync(request, headers, runtime);
        }

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

        public ListCalculationJobsResponse ListCalculationJobs(ListCalculationJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCalculationJobsWithOptions(request, headers, runtime);
        }

        public async Task<ListCalculationJobsResponse> ListCalculationJobsAsync(ListCalculationJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCalculationJobsWithOptionsAsync(request, headers, runtime);
        }

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

        public ListCrowdUsersResponse ListCrowdUsers(string CrowdId, ListCrowdUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCrowdUsersWithOptions(CrowdId, request, headers, runtime);
        }

        public async Task<ListCrowdUsersResponse> ListCrowdUsersAsync(string CrowdId, ListCrowdUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCrowdUsersWithOptionsAsync(CrowdId, request, headers, runtime);
        }

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

        public ListCrowdsResponse ListCrowds(ListCrowdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCrowdsWithOptions(request, headers, runtime);
        }

        public async Task<ListCrowdsResponse> ListCrowdsAsync(ListCrowdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCrowdsWithOptionsAsync(request, headers, runtime);
        }

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

        public ListExperimentGroupsResponse ListExperimentGroups(ListExperimentGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListExperimentGroupsWithOptions(request, headers, runtime);
        }

        public async Task<ListExperimentGroupsResponse> ListExperimentGroupsAsync(ListExperimentGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListExperimentGroupsWithOptionsAsync(request, headers, runtime);
        }

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

        public ListExperimentsResponse ListExperiments(ListExperimentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListExperimentsWithOptions(request, headers, runtime);
        }

        public async Task<ListExperimentsResponse> ListExperimentsAsync(ListExperimentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListExperimentsWithOptionsAsync(request, headers, runtime);
        }

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

        public ListFeatureConsistencyCheckJobConfigsResponse ListFeatureConsistencyCheckJobConfigs(ListFeatureConsistencyCheckJobConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFeatureConsistencyCheckJobConfigsWithOptions(request, headers, runtime);
        }

        public async Task<ListFeatureConsistencyCheckJobConfigsResponse> ListFeatureConsistencyCheckJobConfigsAsync(ListFeatureConsistencyCheckJobConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFeatureConsistencyCheckJobConfigsWithOptionsAsync(request, headers, runtime);
        }

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

        public ListFeatureConsistencyCheckJobFeatureReportsResponse ListFeatureConsistencyCheckJobFeatureReports(string FeatureConsistencyCheckJobId, ListFeatureConsistencyCheckJobFeatureReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFeatureConsistencyCheckJobFeatureReportsWithOptions(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

        public async Task<ListFeatureConsistencyCheckJobFeatureReportsResponse> ListFeatureConsistencyCheckJobFeatureReportsAsync(string FeatureConsistencyCheckJobId, ListFeatureConsistencyCheckJobFeatureReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFeatureConsistencyCheckJobFeatureReportsWithOptionsAsync(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

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

        public ListFeatureConsistencyCheckJobScoreReportsResponse ListFeatureConsistencyCheckJobScoreReports(string FeatureConsistencyCheckJobId, ListFeatureConsistencyCheckJobScoreReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFeatureConsistencyCheckJobScoreReportsWithOptions(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

        public async Task<ListFeatureConsistencyCheckJobScoreReportsResponse> ListFeatureConsistencyCheckJobScoreReportsAsync(string FeatureConsistencyCheckJobId, ListFeatureConsistencyCheckJobScoreReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFeatureConsistencyCheckJobScoreReportsWithOptionsAsync(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

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

        public ListFeatureConsistencyCheckJobsResponse ListFeatureConsistencyCheckJobs(ListFeatureConsistencyCheckJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFeatureConsistencyCheckJobsWithOptions(request, headers, runtime);
        }

        public async Task<ListFeatureConsistencyCheckJobsResponse> ListFeatureConsistencyCheckJobsAsync(ListFeatureConsistencyCheckJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFeatureConsistencyCheckJobsWithOptionsAsync(request, headers, runtime);
        }

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

        public ListInstanceResourcesResponse ListInstanceResources(string InstanceId, ListInstanceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstanceResourcesWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListInstanceResourcesResponse> ListInstanceResourcesAsync(string InstanceId, ListInstanceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstanceResourcesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

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

        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstancesWithOptions(request, headers, runtime);
        }

        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstancesWithOptionsAsync(request, headers, runtime);
        }

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

        public ListLaboratoriesResponse ListLaboratories(ListLaboratoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLaboratoriesWithOptions(request, headers, runtime);
        }

        public async Task<ListLaboratoriesResponse> ListLaboratoriesAsync(ListLaboratoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLaboratoriesWithOptionsAsync(request, headers, runtime);
        }

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

        public ListLayersResponse ListLayers(ListLayersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLayersWithOptions(request, headers, runtime);
        }

        public async Task<ListLayersResponse> ListLayersAsync(ListLayersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLayersWithOptionsAsync(request, headers, runtime);
        }

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

        public ListParamsResponse ListParams(ListParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListParamsWithOptions(request, headers, runtime);
        }

        public async Task<ListParamsResponse> ListParamsAsync(ListParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListParamsWithOptionsAsync(request, headers, runtime);
        }

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

        public ListScenesResponse ListScenes(ListScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListScenesWithOptions(request, headers, runtime);
        }

        public async Task<ListScenesResponse> ListScenesAsync(ListScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListScenesWithOptionsAsync(request, headers, runtime);
        }

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

        public ListSubCrowdsResponse ListSubCrowds(string CrowdId, ListSubCrowdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSubCrowdsWithOptions(CrowdId, request, headers, runtime);
        }

        public async Task<ListSubCrowdsResponse> ListSubCrowdsAsync(string CrowdId, ListSubCrowdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSubCrowdsWithOptionsAsync(CrowdId, request, headers, runtime);
        }

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

        public ListTableMetasResponse ListTableMetas(ListTableMetasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTableMetasWithOptions(request, headers, runtime);
        }

        public async Task<ListTableMetasResponse> ListTableMetasAsync(ListTableMetasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTableMetasWithOptionsAsync(request, headers, runtime);
        }

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

        public OfflineExperimentResponse OfflineExperiment(string ExperimentId, OfflineExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OfflineExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        public async Task<OfflineExperimentResponse> OfflineExperimentAsync(string ExperimentId, OfflineExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OfflineExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

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

        public OfflineExperimentGroupResponse OfflineExperimentGroup(string ExperimentGroupId, OfflineExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OfflineExperimentGroupWithOptions(ExperimentGroupId, request, headers, runtime);
        }

        public async Task<OfflineExperimentGroupResponse> OfflineExperimentGroupAsync(string ExperimentGroupId, OfflineExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OfflineExperimentGroupWithOptionsAsync(ExperimentGroupId, request, headers, runtime);
        }

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

        public OfflineLaboratoryResponse OfflineLaboratory(string LaboratoryId, OfflineLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OfflineLaboratoryWithOptions(LaboratoryId, request, headers, runtime);
        }

        public async Task<OfflineLaboratoryResponse> OfflineLaboratoryAsync(string LaboratoryId, OfflineLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OfflineLaboratoryWithOptionsAsync(LaboratoryId, request, headers, runtime);
        }

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

        public OnlineExperimentResponse OnlineExperiment(string ExperimentId, OnlineExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OnlineExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        public async Task<OnlineExperimentResponse> OnlineExperimentAsync(string ExperimentId, OnlineExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OnlineExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

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

        public OnlineExperimentGroupResponse OnlineExperimentGroup(string ExperimentGroupId, OnlineExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OnlineExperimentGroupWithOptions(ExperimentGroupId, request, headers, runtime);
        }

        public async Task<OnlineExperimentGroupResponse> OnlineExperimentGroupAsync(string ExperimentGroupId, OnlineExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OnlineExperimentGroupWithOptionsAsync(ExperimentGroupId, request, headers, runtime);
        }

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

        public OnlineLaboratoryResponse OnlineLaboratory(string LaboratoryId, OnlineLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OnlineLaboratoryWithOptions(LaboratoryId, request, headers, runtime);
        }

        public async Task<OnlineLaboratoryResponse> OnlineLaboratoryAsync(string LaboratoryId, OnlineLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OnlineLaboratoryWithOptionsAsync(LaboratoryId, request, headers, runtime);
        }

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

        public PushAllExperimentResponse PushAllExperiment(string ExperimentId, PushAllExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PushAllExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        public async Task<PushAllExperimentResponse> PushAllExperimentAsync(string ExperimentId, PushAllExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PushAllExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

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

        public ReportABMetricGroupResponse ReportABMetricGroup(string ABMetricGroupId, ReportABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReportABMetricGroupWithOptions(ABMetricGroupId, request, headers, runtime);
        }

        public async Task<ReportABMetricGroupResponse> ReportABMetricGroupAsync(string ABMetricGroupId, ReportABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReportABMetricGroupWithOptionsAsync(ABMetricGroupId, request, headers, runtime);
        }

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

        public SyncFeatureConsistencyCheckJobReplayLogResponse SyncFeatureConsistencyCheckJobReplayLog(SyncFeatureConsistencyCheckJobReplayLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SyncFeatureConsistencyCheckJobReplayLogWithOptions(request, headers, runtime);
        }

        public async Task<SyncFeatureConsistencyCheckJobReplayLogResponse> SyncFeatureConsistencyCheckJobReplayLogAsync(SyncFeatureConsistencyCheckJobReplayLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SyncFeatureConsistencyCheckJobReplayLogWithOptionsAsync(request, headers, runtime);
        }

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

        public TerminateFeatureConsistencyCheckJobResponse TerminateFeatureConsistencyCheckJob(string FeatureConsistencyCheckJobId, TerminateFeatureConsistencyCheckJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TerminateFeatureConsistencyCheckJobWithOptions(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

        public async Task<TerminateFeatureConsistencyCheckJobResponse> TerminateFeatureConsistencyCheckJobAsync(string FeatureConsistencyCheckJobId, TerminateFeatureConsistencyCheckJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TerminateFeatureConsistencyCheckJobWithOptionsAsync(FeatureConsistencyCheckJobId, request, headers, runtime);
        }

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

        public UpdateABMetricResponse UpdateABMetric(string ABMetricId, UpdateABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateABMetricWithOptions(ABMetricId, request, headers, runtime);
        }

        public async Task<UpdateABMetricResponse> UpdateABMetricAsync(string ABMetricId, UpdateABMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateABMetricWithOptionsAsync(ABMetricId, request, headers, runtime);
        }

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

        public UpdateABMetricGroupResponse UpdateABMetricGroup(string ABMetricGroupId, UpdateABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateABMetricGroupWithOptions(ABMetricGroupId, request, headers, runtime);
        }

        public async Task<UpdateABMetricGroupResponse> UpdateABMetricGroupAsync(string ABMetricGroupId, UpdateABMetricGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateABMetricGroupWithOptionsAsync(ABMetricGroupId, request, headers, runtime);
        }

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

        public UpdateCrowdResponse UpdateCrowd(string CrowdId, UpdateCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateCrowdWithOptions(CrowdId, request, headers, runtime);
        }

        public async Task<UpdateCrowdResponse> UpdateCrowdAsync(string CrowdId, UpdateCrowdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateCrowdWithOptionsAsync(CrowdId, request, headers, runtime);
        }

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

        public UpdateExperimentResponse UpdateExperiment(string ExperimentId, UpdateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        public async Task<UpdateExperimentResponse> UpdateExperimentAsync(string ExperimentId, UpdateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

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

        public UpdateExperimentGroupResponse UpdateExperimentGroup(string ExperimentGroupId, UpdateExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateExperimentGroupWithOptions(ExperimentGroupId, request, headers, runtime);
        }

        public async Task<UpdateExperimentGroupResponse> UpdateExperimentGroupAsync(string ExperimentGroupId, UpdateExperimentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateExperimentGroupWithOptionsAsync(ExperimentGroupId, request, headers, runtime);
        }

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

        public UpdateFeatureConsistencyCheckJobConfigResponse UpdateFeatureConsistencyCheckJobConfig(string FeatureConsistencyCheckJobConfigId, UpdateFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFeatureConsistencyCheckJobConfigWithOptions(FeatureConsistencyCheckJobConfigId, request, headers, runtime);
        }

        public async Task<UpdateFeatureConsistencyCheckJobConfigResponse> UpdateFeatureConsistencyCheckJobConfigAsync(string FeatureConsistencyCheckJobConfigId, UpdateFeatureConsistencyCheckJobConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFeatureConsistencyCheckJobConfigWithOptionsAsync(FeatureConsistencyCheckJobConfigId, request, headers, runtime);
        }

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

        public UpdateInstanceResourceResponse UpdateInstanceResource(string InstanceId, string ResourceId, UpdateInstanceResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateInstanceResourceWithOptions(InstanceId, ResourceId, request, headers, runtime);
        }

        public async Task<UpdateInstanceResourceResponse> UpdateInstanceResourceAsync(string InstanceId, string ResourceId, UpdateInstanceResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateInstanceResourceWithOptionsAsync(InstanceId, ResourceId, request, headers, runtime);
        }

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

        public UpdateLaboratoryResponse UpdateLaboratory(string LaboratoryId, UpdateLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLaboratoryWithOptions(LaboratoryId, request, headers, runtime);
        }

        public async Task<UpdateLaboratoryResponse> UpdateLaboratoryAsync(string LaboratoryId, UpdateLaboratoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLaboratoryWithOptionsAsync(LaboratoryId, request, headers, runtime);
        }

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

        public UpdateLayerResponse UpdateLayer(string LayerId, UpdateLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLayerWithOptions(LayerId, request, headers, runtime);
        }

        public async Task<UpdateLayerResponse> UpdateLayerAsync(string LayerId, UpdateLayerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLayerWithOptionsAsync(LayerId, request, headers, runtime);
        }

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

        public UpdateParamResponse UpdateParam(string ParamId, UpdateParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateParamWithOptions(ParamId, request, headers, runtime);
        }

        public async Task<UpdateParamResponse> UpdateParamAsync(string ParamId, UpdateParamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateParamWithOptionsAsync(ParamId, request, headers, runtime);
        }

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

        public UpdateSceneResponse UpdateScene(string SceneId, UpdateSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSceneWithOptions(SceneId, request, headers, runtime);
        }

        public async Task<UpdateSceneResponse> UpdateSceneAsync(string SceneId, UpdateSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSceneWithOptionsAsync(SceneId, request, headers, runtime);
        }

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

        public UpdateTableMetaResponse UpdateTableMeta(string TableMetaId, UpdateTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTableMetaWithOptions(TableMetaId, request, headers, runtime);
        }

        public async Task<UpdateTableMetaResponse> UpdateTableMetaAsync(string TableMetaId, UpdateTableMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTableMetaWithOptionsAsync(TableMetaId, request, headers, runtime);
        }

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

        public UploadRecommendationDataResponse UploadRecommendationData(UploadRecommendationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UploadRecommendationDataWithOptions(request, headers, runtime);
        }

        public async Task<UploadRecommendationDataResponse> UploadRecommendationDataAsync(UploadRecommendationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UploadRecommendationDataWithOptionsAsync(request, headers, runtime);
        }

    }
}
