// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Airec20181012.Models;

namespace AlibabaCloud.SDK.Airec20181012
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("airec", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AttachDatasetResponse AttachDataset(string InstanceId, string VersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AttachDatasetWithOptions(InstanceId, VersionId, headers, runtime);
        }

        public async Task<AttachDatasetResponse> AttachDatasetAsync(string InstanceId, string VersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AttachDatasetWithOptionsAsync(InstanceId, VersionId, headers, runtime);
        }

        public AttachDatasetResponse AttachDatasetWithOptions(string InstanceId, string VersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<AttachDatasetResponse>(DoROARequest("AttachDataset", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/dataSets/{VersionId}/actions/current", "json", req, runtime));
        }

        public async Task<AttachDatasetResponse> AttachDatasetWithOptionsAsync(string InstanceId, string VersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<AttachDatasetResponse>(await DoROARequestAsync("AttachDataset", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/dataSets/{VersionId}/actions/current", "json", req, runtime));
        }

        public CreateDiversifyResponse CreateDiversify(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDiversifyWithOptions(InstanceId, headers, runtime);
        }

        public async Task<CreateDiversifyResponse> CreateDiversifyAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDiversifyWithOptionsAsync(InstanceId, headers, runtime);
        }

        public CreateDiversifyResponse CreateDiversifyWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CreateDiversifyResponse>(DoROARequest("CreateDiversify", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/diversifies", "json", req, runtime));
        }

        public async Task<CreateDiversifyResponse> CreateDiversifyWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CreateDiversifyResponse>(await DoROARequestAsync("CreateDiversify", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/diversifies", "json", req, runtime));
        }

        public CreateInstanceResponse CreateInstance()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceWithOptions(headers, runtime);
        }

        public async Task<CreateInstanceResponse> CreateInstanceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceWithOptionsAsync(headers, runtime);
        }

        public CreateInstanceResponse CreateInstanceWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CreateInstanceResponse>(DoROARequest("CreateInstance", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances", "json", req, runtime));
        }

        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await DoROARequestAsync("CreateInstance", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances", "json", req, runtime));
        }

        public CreateMixResponse CreateMix(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMixWithOptions(InstanceId, headers, runtime);
        }

        public async Task<CreateMixResponse> CreateMixAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMixWithOptionsAsync(InstanceId, headers, runtime);
        }

        public CreateMixResponse CreateMixWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CreateMixResponse>(DoROARequest("CreateMix", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/mixes", "json", req, runtime));
        }

        public async Task<CreateMixResponse> CreateMixWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CreateMixResponse>(await DoROARequestAsync("CreateMix", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/mixes", "json", req, runtime));
        }

        public CreateRuleResponse CreateRule(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRuleWithOptions(InstanceId, headers, runtime);
        }

        public async Task<CreateRuleResponse> CreateRuleAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRuleWithOptionsAsync(InstanceId, headers, runtime);
        }

        public CreateRuleResponse CreateRuleWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CreateRuleResponse>(DoROARequest("CreateRule", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/rules", "json", req, runtime));
        }

        public async Task<CreateRuleResponse> CreateRuleWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CreateRuleResponse>(await DoROARequestAsync("CreateRule", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/rules", "json", req, runtime));
        }

        public CreateSceneResponse CreateScene(string InstanceId, CreateSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSceneWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<CreateSceneResponse> CreateSceneAsync(string InstanceId, CreateSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSceneWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public CreateSceneResponse CreateSceneWithOptions(string InstanceId, CreateSceneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateSceneResponse>(DoROARequest("CreateScene", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/scenes", "json", req, runtime));
        }

        public async Task<CreateSceneResponse> CreateSceneWithOptionsAsync(string InstanceId, CreateSceneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateSceneResponse>(await DoROARequestAsync("CreateScene", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/scenes", "json", req, runtime));
        }

        public DeleteDataSetResponse DeleteDataSet(string InstanceId, string VersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDataSetWithOptions(InstanceId, VersionId, headers, runtime);
        }

        public async Task<DeleteDataSetResponse> DeleteDataSetAsync(string InstanceId, string VersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDataSetWithOptionsAsync(InstanceId, VersionId, headers, runtime);
        }

        public DeleteDataSetResponse DeleteDataSetWithOptions(string InstanceId, string VersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteDataSetResponse>(DoROARequest("DeleteDataSet", "2018-10-12", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId + "/dataSets/{VersionId}", "json", req, runtime));
        }

        public async Task<DeleteDataSetResponse> DeleteDataSetWithOptionsAsync(string InstanceId, string VersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteDataSetResponse>(await DoROARequestAsync("DeleteDataSet", "2018-10-12", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId + "/dataSets/{VersionId}", "json", req, runtime));
        }

        public DeleteDiversifyResponse DeleteDiversify(string InstanceId, string Name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDiversifyWithOptions(InstanceId, Name, headers, runtime);
        }

        public async Task<DeleteDiversifyResponse> DeleteDiversifyAsync(string InstanceId, string Name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDiversifyWithOptionsAsync(InstanceId, Name, headers, runtime);
        }

        public DeleteDiversifyResponse DeleteDiversifyWithOptions(string InstanceId, string Name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteDiversifyResponse>(DoROARequest("DeleteDiversify", "2018-10-12", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId + "/diversifies/{Name}", "json", req, runtime));
        }

        public async Task<DeleteDiversifyResponse> DeleteDiversifyWithOptionsAsync(string InstanceId, string Name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteDiversifyResponse>(await DoROARequestAsync("DeleteDiversify", "2018-10-12", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId + "/diversifies/{Name}", "json", req, runtime));
        }

        public DeleteMixResponse DeleteMix(string InstanceId, string Name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMixWithOptions(InstanceId, Name, headers, runtime);
        }

        public async Task<DeleteMixResponse> DeleteMixAsync(string InstanceId, string Name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMixWithOptionsAsync(InstanceId, Name, headers, runtime);
        }

        public DeleteMixResponse DeleteMixWithOptions(string InstanceId, string Name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteMixResponse>(DoROARequest("DeleteMix", "2018-10-12", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId + "/mixes/{Name}", "json", req, runtime));
        }

        public async Task<DeleteMixResponse> DeleteMixWithOptionsAsync(string InstanceId, string Name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteMixResponse>(await DoROARequestAsync("DeleteMix", "2018-10-12", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId + "/mixes/{Name}", "json", req, runtime));
        }

        public DeleteSceneResponse DeleteScene(string InstanceId, string SceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSceneWithOptions(InstanceId, SceneId, headers, runtime);
        }

        public async Task<DeleteSceneResponse> DeleteSceneAsync(string InstanceId, string SceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSceneWithOptionsAsync(InstanceId, SceneId, headers, runtime);
        }

        public DeleteSceneResponse DeleteSceneWithOptions(string InstanceId, string SceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteSceneResponse>(DoROARequest("DeleteScene", "2018-10-12", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId + "/scenes/{SceneId}", "json", req, runtime));
        }

        public async Task<DeleteSceneResponse> DeleteSceneWithOptionsAsync(string InstanceId, string SceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteSceneResponse>(await DoROARequestAsync("DeleteScene", "2018-10-12", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId + "/scenes/{SceneId}", "json", req, runtime));
        }

        public DescribeDataSetMessageResponse DescribeDataSetMessage(string InstanceId, string VersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeDataSetMessageWithOptions(InstanceId, VersionId, headers, runtime);
        }

        public async Task<DescribeDataSetMessageResponse> DescribeDataSetMessageAsync(string InstanceId, string VersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeDataSetMessageWithOptionsAsync(InstanceId, VersionId, headers, runtime);
        }

        public DescribeDataSetMessageResponse DescribeDataSetMessageWithOptions(string InstanceId, string VersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeDataSetMessageResponse>(DoROARequest("DescribeDataSetMessage", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dataSets/{VersionId}/messages", "json", req, runtime));
        }

        public async Task<DescribeDataSetMessageResponse> DescribeDataSetMessageWithOptionsAsync(string InstanceId, string VersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeDataSetMessageResponse>(await DoROARequestAsync("DescribeDataSetMessage", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dataSets/{VersionId}/messages", "json", req, runtime));
        }

        public DescribeDataSetReportResponse DescribeDataSetReport(string InstanceId, string VersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeDataSetReportWithOptions(InstanceId, VersionId, headers, runtime);
        }

        public async Task<DescribeDataSetReportResponse> DescribeDataSetReportAsync(string InstanceId, string VersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeDataSetReportWithOptionsAsync(InstanceId, VersionId, headers, runtime);
        }

        public DescribeDataSetReportResponse DescribeDataSetReportWithOptions(string InstanceId, string VersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeDataSetReportResponse>(DoROARequest("DescribeDataSetReport", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dataSets/{VersionId}/report", "json", req, runtime));
        }

        public async Task<DescribeDataSetReportResponse> DescribeDataSetReportWithOptionsAsync(string InstanceId, string VersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeDataSetReportResponse>(await DoROARequestAsync("DescribeDataSetReport", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dataSets/{VersionId}/report", "json", req, runtime));
        }

        public DescribeDiversifyResponse DescribeDiversify(string InstanceId, string Name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeDiversifyWithOptions(InstanceId, Name, headers, runtime);
        }

        public async Task<DescribeDiversifyResponse> DescribeDiversifyAsync(string InstanceId, string Name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeDiversifyWithOptionsAsync(InstanceId, Name, headers, runtime);
        }

        public DescribeDiversifyResponse DescribeDiversifyWithOptions(string InstanceId, string Name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeDiversifyResponse>(DoROARequest("DescribeDiversify", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/diversifies/{Name}", "json", req, runtime));
        }

        public async Task<DescribeDiversifyResponse> DescribeDiversifyWithOptionsAsync(string InstanceId, string Name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeDiversifyResponse>(await DoROARequestAsync("DescribeDiversify", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/diversifies/{Name}", "json", req, runtime));
        }

        public DescribeExposureSettingsResponse DescribeExposureSettings(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeExposureSettingsWithOptions(InstanceId, headers, runtime);
        }

        public async Task<DescribeExposureSettingsResponse> DescribeExposureSettingsAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeExposureSettingsWithOptionsAsync(InstanceId, headers, runtime);
        }

        public DescribeExposureSettingsResponse DescribeExposureSettingsWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeExposureSettingsResponse>(DoROARequest("DescribeExposureSettings", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/exposure-settings", "json", req, runtime));
        }

        public async Task<DescribeExposureSettingsResponse> DescribeExposureSettingsWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeExposureSettingsResponse>(await DoROARequestAsync("DescribeExposureSettings", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/exposure-settings", "json", req, runtime));
        }

        public DescribeInstanceResponse DescribeInstance(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeInstanceWithOptions(InstanceId, headers, runtime);
        }

        public async Task<DescribeInstanceResponse> DescribeInstanceAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeInstanceWithOptionsAsync(InstanceId, headers, runtime);
        }

        public DescribeInstanceResponse DescribeInstanceWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(DoROARequest("DescribeInstance", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId, "json", req, runtime));
        }

        public async Task<DescribeInstanceResponse> DescribeInstanceWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(await DoROARequestAsync("DescribeInstance", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId, "json", req, runtime));
        }

        public DescribeMixResponse DescribeMix(string InstanceId, string Name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeMixWithOptions(InstanceId, Name, headers, runtime);
        }

        public async Task<DescribeMixResponse> DescribeMixAsync(string InstanceId, string Name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeMixWithOptionsAsync(InstanceId, Name, headers, runtime);
        }

        public DescribeMixResponse DescribeMixWithOptions(string InstanceId, string Name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeMixResponse>(DoROARequest("DescribeMix", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/mixes/{Name}", "json", req, runtime));
        }

        public async Task<DescribeMixResponse> DescribeMixWithOptionsAsync(string InstanceId, string Name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeMixResponse>(await DoROARequestAsync("DescribeMix", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/mixes/{Name}", "json", req, runtime));
        }

        public DescribeQuotaResponse DescribeQuota(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeQuotaWithOptions(InstanceId, headers, runtime);
        }

        public async Task<DescribeQuotaResponse> DescribeQuotaAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeQuotaWithOptionsAsync(InstanceId, headers, runtime);
        }

        public DescribeQuotaResponse DescribeQuotaWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeQuotaResponse>(DoROARequest("DescribeQuota", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/quota", "json", req, runtime));
        }

        public async Task<DescribeQuotaResponse> DescribeQuotaWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeQuotaResponse>(await DoROARequestAsync("DescribeQuota", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/quota", "json", req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRegionsWithOptions(request, headers, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRegionsWithOptionsAsync(request, headers, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoROARequest("DescribeRegions", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/configurations/regions", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoROARequestAsync("DescribeRegions", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/configurations/regions", "json", req, runtime));
        }

        public DescribeRuleResponse DescribeRule(string InstanceId, string RuleId, DescribeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRuleWithOptions(InstanceId, RuleId, request, headers, runtime);
        }

        public async Task<DescribeRuleResponse> DescribeRuleAsync(string InstanceId, string RuleId, DescribeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRuleWithOptionsAsync(InstanceId, RuleId, request, headers, runtime);
        }

        public DescribeRuleResponse DescribeRuleWithOptions(string InstanceId, string RuleId, DescribeRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeRuleResponse>(DoROARequest("DescribeRule", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/rules/{RuleId}", "json", req, runtime));
        }

        public async Task<DescribeRuleResponse> DescribeRuleWithOptionsAsync(string InstanceId, string RuleId, DescribeRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeRuleResponse>(await DoROARequestAsync("DescribeRule", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/rules/{RuleId}", "json", req, runtime));
        }

        public DescribeSceneResponse DescribeScene(string InstanceId, string SceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSceneWithOptions(InstanceId, SceneId, headers, runtime);
        }

        public async Task<DescribeSceneResponse> DescribeSceneAsync(string InstanceId, string SceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSceneWithOptionsAsync(InstanceId, SceneId, headers, runtime);
        }

        public DescribeSceneResponse DescribeSceneWithOptions(string InstanceId, string SceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeSceneResponse>(DoROARequest("DescribeScene", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/scenes/{SceneId}", "json", req, runtime));
        }

        public async Task<DescribeSceneResponse> DescribeSceneWithOptionsAsync(string InstanceId, string SceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeSceneResponse>(await DoROARequestAsync("DescribeScene", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/scenes/{SceneId}", "json", req, runtime));
        }

        public DescribeSceneThroughputResponse DescribeSceneThroughput(string InstanceId, string SceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSceneThroughputWithOptions(InstanceId, SceneId, headers, runtime);
        }

        public async Task<DescribeSceneThroughputResponse> DescribeSceneThroughputAsync(string InstanceId, string SceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSceneThroughputWithOptionsAsync(InstanceId, SceneId, headers, runtime);
        }

        public DescribeSceneThroughputResponse DescribeSceneThroughputWithOptions(string InstanceId, string SceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeSceneThroughputResponse>(DoROARequest("DescribeSceneThroughput", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/scenes/{SceneId}/throughput", "json", req, runtime));
        }

        public async Task<DescribeSceneThroughputResponse> DescribeSceneThroughputWithOptionsAsync(string InstanceId, string SceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeSceneThroughputResponse>(await DoROARequestAsync("DescribeSceneThroughput", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/scenes/{SceneId}/throughput", "json", req, runtime));
        }

        public DescribeSyncReportDetailResponse DescribeSyncReportDetail(string InstanceId, DescribeSyncReportDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSyncReportDetailWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<DescribeSyncReportDetailResponse> DescribeSyncReportDetailAsync(string InstanceId, DescribeSyncReportDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSyncReportDetailWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public DescribeSyncReportDetailResponse DescribeSyncReportDetailWithOptions(string InstanceId, DescribeSyncReportDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LevelType))
            {
                query["LevelType"] = request.LevelType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeSyncReportDetailResponse>(DoROARequest("DescribeSyncReportDetail", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/sync-reports/detail", "json", req, runtime));
        }

        public async Task<DescribeSyncReportDetailResponse> DescribeSyncReportDetailWithOptionsAsync(string InstanceId, DescribeSyncReportDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LevelType))
            {
                query["LevelType"] = request.LevelType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeSyncReportDetailResponse>(await DoROARequestAsync("DescribeSyncReportDetail", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/sync-reports/detail", "json", req, runtime));
        }

        public DescribeSyncReportOutliersResponse DescribeSyncReportOutliers(string InstanceId, DescribeSyncReportOutliersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSyncReportOutliersWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<DescribeSyncReportOutliersResponse> DescribeSyncReportOutliersAsync(string InstanceId, DescribeSyncReportOutliersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSyncReportOutliersWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public DescribeSyncReportOutliersResponse DescribeSyncReportOutliersWithOptions(string InstanceId, DescribeSyncReportOutliersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LevelType))
            {
                query["LevelType"] = request.LevelType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeSyncReportOutliersResponse>(DoROARequest("DescribeSyncReportOutliers", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/sync-reports/outliers", "json", req, runtime));
        }

        public async Task<DescribeSyncReportOutliersResponse> DescribeSyncReportOutliersWithOptionsAsync(string InstanceId, DescribeSyncReportOutliersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LevelType))
            {
                query["LevelType"] = request.LevelType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeSyncReportOutliersResponse>(await DoROARequestAsync("DescribeSyncReportOutliers", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/sync-reports/outliers", "json", req, runtime));
        }

        public DescribeUserMetricsResponse DescribeUserMetrics(string InstanceId, DescribeUserMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeUserMetricsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<DescribeUserMetricsResponse> DescribeUserMetricsAsync(string InstanceId, DescribeUserMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeUserMetricsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public DescribeUserMetricsResponse DescribeUserMetricsWithOptions(string InstanceId, DescribeUserMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeUserMetricsResponse>(DoROARequest("DescribeUserMetrics", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/metrics", "json", req, runtime));
        }

        public async Task<DescribeUserMetricsResponse> DescribeUserMetricsWithOptionsAsync(string InstanceId, DescribeUserMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeUserMetricsResponse>(await DoROARequestAsync("DescribeUserMetrics", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/metrics", "json", req, runtime));
        }

        public DowngradeInstanceResponse DowngradeInstance(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DowngradeInstanceWithOptions(InstanceId, headers, runtime);
        }

        public async Task<DowngradeInstanceResponse> DowngradeInstanceAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DowngradeInstanceWithOptionsAsync(InstanceId, headers, runtime);
        }

        public DowngradeInstanceResponse DowngradeInstanceWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DowngradeInstanceResponse>(DoROARequest("DowngradeInstance", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/downgrade", "json", req, runtime));
        }

        public async Task<DowngradeInstanceResponse> DowngradeInstanceWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DowngradeInstanceResponse>(await DoROARequestAsync("DowngradeInstance", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/downgrade", "json", req, runtime));
        }

        public ListDashboardResponse ListDashboard(string InstanceId, ListDashboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDashboardWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListDashboardResponse> ListDashboardAsync(string InstanceId, ListDashboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDashboardWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListDashboardResponse ListDashboardWithOptions(string InstanceId, ListDashboardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceId))
            {
                query["TraceId"] = request.TraceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListDashboardResponse>(DoROARequest("ListDashboard", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dashboard/statistics", "json", req, runtime));
        }

        public async Task<ListDashboardResponse> ListDashboardWithOptionsAsync(string InstanceId, ListDashboardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceId))
            {
                query["TraceId"] = request.TraceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListDashboardResponse>(await DoROARequestAsync("ListDashboard", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dashboard/statistics", "json", req, runtime));
        }

        public ListDashboardDetailsResponse ListDashboardDetails(string InstanceId, ListDashboardDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDashboardDetailsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListDashboardDetailsResponse> ListDashboardDetailsAsync(string InstanceId, ListDashboardDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDashboardDetailsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListDashboardDetailsResponse ListDashboardDetailsWithOptions(string InstanceId, ListDashboardDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceIds))
            {
                query["TraceIds"] = request.TraceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneIds))
            {
                query["SceneIds"] = request.SceneIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListDashboardDetailsResponse>(DoROARequest("ListDashboardDetails", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dashboard/details", "json", req, runtime));
        }

        public async Task<ListDashboardDetailsResponse> ListDashboardDetailsWithOptionsAsync(string InstanceId, ListDashboardDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceIds))
            {
                query["TraceIds"] = request.TraceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneIds))
            {
                query["SceneIds"] = request.SceneIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListDashboardDetailsResponse>(await DoROARequestAsync("ListDashboardDetails", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dashboard/details", "json", req, runtime));
        }

        public ListDashboardDetailsFlowsResponse ListDashboardDetailsFlows(string InstanceId, ListDashboardDetailsFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDashboardDetailsFlowsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListDashboardDetailsFlowsResponse> ListDashboardDetailsFlowsAsync(string InstanceId, ListDashboardDetailsFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDashboardDetailsFlowsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListDashboardDetailsFlowsResponse ListDashboardDetailsFlowsWithOptions(string InstanceId, ListDashboardDetailsFlowsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceIds))
            {
                query["TraceIds"] = request.TraceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneIds))
            {
                query["SceneIds"] = request.SceneIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListDashboardDetailsFlowsResponse>(DoROARequest("ListDashboardDetailsFlows", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dashboard/details/flows", "json", req, runtime));
        }

        public async Task<ListDashboardDetailsFlowsResponse> ListDashboardDetailsFlowsWithOptionsAsync(string InstanceId, ListDashboardDetailsFlowsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceIds))
            {
                query["TraceIds"] = request.TraceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneIds))
            {
                query["SceneIds"] = request.SceneIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListDashboardDetailsFlowsResponse>(await DoROARequestAsync("ListDashboardDetailsFlows", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dashboard/details/flows", "json", req, runtime));
        }

        public ListDashboardMetricsResponse ListDashboardMetrics(string InstanceId, ListDashboardMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDashboardMetricsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListDashboardMetricsResponse> ListDashboardMetricsAsync(string InstanceId, ListDashboardMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDashboardMetricsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListDashboardMetricsResponse ListDashboardMetricsWithOptions(string InstanceId, ListDashboardMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListDashboardMetricsResponse>(DoROARequest("ListDashboardMetrics", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dashboard/metrics", "json", req, runtime));
        }

        public async Task<ListDashboardMetricsResponse> ListDashboardMetricsWithOptionsAsync(string InstanceId, ListDashboardMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListDashboardMetricsResponse>(await DoROARequestAsync("ListDashboardMetrics", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dashboard/metrics", "json", req, runtime));
        }

        public ListDashboardMetricsFlowsResponse ListDashboardMetricsFlows(string InstanceId, ListDashboardMetricsFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDashboardMetricsFlowsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListDashboardMetricsFlowsResponse> ListDashboardMetricsFlowsAsync(string InstanceId, ListDashboardMetricsFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDashboardMetricsFlowsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListDashboardMetricsFlowsResponse ListDashboardMetricsFlowsWithOptions(string InstanceId, ListDashboardMetricsFlowsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListDashboardMetricsFlowsResponse>(DoROARequest("ListDashboardMetricsFlows", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dashboard/metrics/flows", "json", req, runtime));
        }

        public async Task<ListDashboardMetricsFlowsResponse> ListDashboardMetricsFlowsWithOptionsAsync(string InstanceId, ListDashboardMetricsFlowsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListDashboardMetricsFlowsResponse>(await DoROARequestAsync("ListDashboardMetricsFlows", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dashboard/metrics/flows", "json", req, runtime));
        }

        public ListDashboardParametersResponse ListDashboardParameters(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDashboardParametersWithOptions(InstanceId, headers, runtime);
        }

        public async Task<ListDashboardParametersResponse> ListDashboardParametersAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDashboardParametersWithOptionsAsync(InstanceId, headers, runtime);
        }

        public ListDashboardParametersResponse ListDashboardParametersWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListDashboardParametersResponse>(DoROARequest("ListDashboardParameters", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dashboard/parameters", "json", req, runtime));
        }

        public async Task<ListDashboardParametersResponse> ListDashboardParametersWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListDashboardParametersResponse>(await DoROARequestAsync("ListDashboardParameters", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dashboard/parameters", "json", req, runtime));
        }

        public ListDashboardUidResponse ListDashboardUid(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDashboardUidWithOptions(InstanceId, headers, runtime);
        }

        public async Task<ListDashboardUidResponse> ListDashboardUidAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDashboardUidWithOptionsAsync(InstanceId, headers, runtime);
        }

        public ListDashboardUidResponse ListDashboardUidWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListDashboardUidResponse>(DoROARequest("ListDashboardUid", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dashboard/uid", "json", req, runtime));
        }

        public async Task<ListDashboardUidResponse> ListDashboardUidWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListDashboardUidResponse>(await DoROARequestAsync("ListDashboardUid", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dashboard/uid", "json", req, runtime));
        }

        public ListDataSetResponse ListDataSet(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataSetWithOptions(InstanceId, headers, runtime);
        }

        public async Task<ListDataSetResponse> ListDataSetAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataSetWithOptionsAsync(InstanceId, headers, runtime);
        }

        public ListDataSetResponse ListDataSetWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListDataSetResponse>(DoROARequest("ListDataSet", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dataSets", "json", req, runtime));
        }

        public async Task<ListDataSetResponse> ListDataSetWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListDataSetResponse>(await DoROARequestAsync("ListDataSet", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dataSets", "json", req, runtime));
        }

        public ListDataSourceResponse ListDataSource(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataSourceWithOptions(InstanceId, headers, runtime);
        }

        public async Task<ListDataSourceResponse> ListDataSourceAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataSourceWithOptionsAsync(InstanceId, headers, runtime);
        }

        public ListDataSourceResponse ListDataSourceWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListDataSourceResponse>(DoROARequest("ListDataSource", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dataSources", "json", req, runtime));
        }

        public async Task<ListDataSourceResponse> ListDataSourceWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListDataSourceResponse>(await DoROARequestAsync("ListDataSource", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dataSources", "json", req, runtime));
        }

        public ListDiversifyResponse ListDiversify(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDiversifyWithOptions(InstanceId, headers, runtime);
        }

        public async Task<ListDiversifyResponse> ListDiversifyAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDiversifyWithOptionsAsync(InstanceId, headers, runtime);
        }

        public ListDiversifyResponse ListDiversifyWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListDiversifyResponse>(DoROARequest("ListDiversify", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/diversifies", "json", req, runtime));
        }

        public async Task<ListDiversifyResponse> ListDiversifyWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListDiversifyResponse>(await DoROARequestAsync("ListDiversify", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/diversifies", "json", req, runtime));
        }

        public ListInstanceResponse ListInstance(ListInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstanceWithOptions(request, headers, runtime);
        }

        public async Task<ListInstanceResponse> ListInstanceAsync(ListInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstanceWithOptionsAsync(request, headers, runtime);
        }

        public ListInstanceResponse ListInstanceWithOptions(ListInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredTime))
            {
                query["ExpiredTime"] = request.ExpiredTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListInstanceResponse>(DoROARequest("ListInstance", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances", "json", req, runtime));
        }

        public async Task<ListInstanceResponse> ListInstanceWithOptionsAsync(ListInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredTime))
            {
                query["ExpiredTime"] = request.ExpiredTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListInstanceResponse>(await DoROARequestAsync("ListInstance", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances", "json", req, runtime));
        }

        public ListInstanceTaskResponse ListInstanceTask(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstanceTaskWithOptions(InstanceId, headers, runtime);
        }

        public async Task<ListInstanceTaskResponse> ListInstanceTaskAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstanceTaskWithOptionsAsync(InstanceId, headers, runtime);
        }

        public ListInstanceTaskResponse ListInstanceTaskWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListInstanceTaskResponse>(DoROARequest("ListInstanceTask", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/tasks", "json", req, runtime));
        }

        public async Task<ListInstanceTaskResponse> ListInstanceTaskWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListInstanceTaskResponse>(await DoROARequestAsync("ListInstanceTask", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/tasks", "json", req, runtime));
        }

        public ListItemsResponse ListItems(string InstanceId, ListItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListItemsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListItemsResponse> ListItemsAsync(string InstanceId, ListItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListItemsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListItemsResponse ListItemsWithOptions(string InstanceId, ListItemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListItemsResponse>(DoROARequest("ListItems", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/items/actions/list", "json", req, runtime));
        }

        public async Task<ListItemsResponse> ListItemsWithOptionsAsync(string InstanceId, ListItemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListItemsResponse>(await DoROARequestAsync("ListItems", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/items/actions/list", "json", req, runtime));
        }

        public ListLogsResponse ListLogs(string InstanceId, ListLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLogsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListLogsResponse> ListLogsAsync(string InstanceId, ListLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLogsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListLogsResponse ListLogsWithOptions(string InstanceId, ListLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryParams))
            {
                query["QueryParams"] = request.QueryParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListLogsResponse>(DoROARequest("ListLogs", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/logs", "json", req, runtime));
        }

        public async Task<ListLogsResponse> ListLogsWithOptionsAsync(string InstanceId, ListLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryParams))
            {
                query["QueryParams"] = request.QueryParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListLogsResponse>(await DoROARequestAsync("ListLogs", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/logs", "json", req, runtime));
        }

        public ListMixResponse ListMix(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMixWithOptions(InstanceId, headers, runtime);
        }

        public async Task<ListMixResponse> ListMixAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMixWithOptionsAsync(InstanceId, headers, runtime);
        }

        public ListMixResponse ListMixWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListMixResponse>(DoROARequest("ListMix", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/mixes", "json", req, runtime));
        }

        public async Task<ListMixResponse> ListMixWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListMixResponse>(await DoROARequestAsync("ListMix", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/mixes", "json", req, runtime));
        }

        public ListRuleConditionsResponse ListRuleConditions(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRuleConditionsWithOptions(InstanceId, headers, runtime);
        }

        public async Task<ListRuleConditionsResponse> ListRuleConditionsAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRuleConditionsWithOptionsAsync(InstanceId, headers, runtime);
        }

        public ListRuleConditionsResponse ListRuleConditionsWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListRuleConditionsResponse>(DoROARequest("ListRuleConditions", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/rule-conditions", "json", req, runtime));
        }

        public async Task<ListRuleConditionsResponse> ListRuleConditionsWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListRuleConditionsResponse>(await DoROARequestAsync("ListRuleConditions", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/rule-conditions", "json", req, runtime));
        }

        public ListRulesResponse ListRules(string InstanceId, ListRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRulesWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListRulesResponse> ListRulesAsync(string InstanceId, ListRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRulesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListRulesResponse ListRulesWithOptions(string InstanceId, ListRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListRulesResponse>(DoROARequest("ListRules", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/rules", "json", req, runtime));
        }

        public async Task<ListRulesResponse> ListRulesWithOptionsAsync(string InstanceId, ListRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListRulesResponse>(await DoROARequestAsync("ListRules", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/rules", "json", req, runtime));
        }

        public ListRuleTasksResponse ListRuleTasks(string InstanceId, ListRuleTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRuleTasksWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListRuleTasksResponse> ListRuleTasksAsync(string InstanceId, ListRuleTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRuleTasksWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListRuleTasksResponse ListRuleTasksWithOptions(string InstanceId, ListRuleTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListRuleTasksResponse>(DoROARequest("ListRuleTasks", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/rule-tasks", "json", req, runtime));
        }

        public async Task<ListRuleTasksResponse> ListRuleTasksWithOptionsAsync(string InstanceId, ListRuleTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListRuleTasksResponse>(await DoROARequestAsync("ListRuleTasks", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/rule-tasks", "json", req, runtime));
        }

        public ListSceneItemsResponse ListSceneItems(string InstanceId, string SceneId, ListSceneItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSceneItemsWithOptions(InstanceId, SceneId, request, headers, runtime);
        }

        public async Task<ListSceneItemsResponse> ListSceneItemsAsync(string InstanceId, string SceneId, ListSceneItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSceneItemsWithOptionsAsync(InstanceId, SceneId, request, headers, runtime);
        }

        public ListSceneItemsResponse ListSceneItemsWithOptions(string InstanceId, string SceneId, ListSceneItemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationRuleId))
            {
                query["OperationRuleId"] = request.OperationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectionRuleId))
            {
                query["SelectionRuleId"] = request.SelectionRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewType))
            {
                query["PreviewType"] = request.PreviewType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCount))
            {
                query["QueryCount"] = request.QueryCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListSceneItemsResponse>(DoROARequest("ListSceneItems", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/scenes/{SceneId}/items", "json", req, runtime));
        }

        public async Task<ListSceneItemsResponse> ListSceneItemsWithOptionsAsync(string InstanceId, string SceneId, ListSceneItemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationRuleId))
            {
                query["OperationRuleId"] = request.OperationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectionRuleId))
            {
                query["SelectionRuleId"] = request.SelectionRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewType))
            {
                query["PreviewType"] = request.PreviewType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCount))
            {
                query["QueryCount"] = request.QueryCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListSceneItemsResponse>(await DoROARequestAsync("ListSceneItems", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/scenes/{SceneId}/items", "json", req, runtime));
        }

        public ListScenesResponse ListScenes(string InstanceId, ListScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListScenesWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListScenesResponse> ListScenesAsync(string InstanceId, ListScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListScenesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListScenesResponse ListScenesWithOptions(string InstanceId, ListScenesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListScenesResponse>(DoROARequest("ListScenes", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/scenes", "json", req, runtime));
        }

        public async Task<ListScenesResponse> ListScenesWithOptionsAsync(string InstanceId, ListScenesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListScenesResponse>(await DoROARequestAsync("ListScenes", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/scenes", "json", req, runtime));
        }

        public ListUmengAppkeysResponse ListUmengAppkeys()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUmengAppkeysWithOptions(headers, runtime);
        }

        public async Task<ListUmengAppkeysResponse> ListUmengAppkeysAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUmengAppkeysWithOptionsAsync(headers, runtime);
        }

        public ListUmengAppkeysResponse ListUmengAppkeysWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListUmengAppkeysResponse>(DoROARequest("ListUmengAppkeys", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/umeng/appkeys", "json", req, runtime));
        }

        public async Task<ListUmengAppkeysResponse> ListUmengAppkeysWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListUmengAppkeysResponse>(await DoROARequestAsync("ListUmengAppkeys", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/umeng/appkeys", "json", req, runtime));
        }

        public ModifyDataSourceResponse ModifyDataSource(string InstanceId, string TableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyDataSourceWithOptions(InstanceId, TableName, headers, runtime);
        }

        public async Task<ModifyDataSourceResponse> ModifyDataSourceAsync(string InstanceId, string TableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyDataSourceWithOptionsAsync(InstanceId, TableName, headers, runtime);
        }

        public ModifyDataSourceResponse ModifyDataSourceWithOptions(string InstanceId, string TableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ModifyDataSourceResponse>(DoROARequest("ModifyDataSource", "2018-10-12", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/dataSources/{TableName}", "json", req, runtime));
        }

        public async Task<ModifyDataSourceResponse> ModifyDataSourceWithOptionsAsync(string InstanceId, string TableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ModifyDataSourceResponse>(await DoROARequestAsync("ModifyDataSource", "2018-10-12", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/dataSources/{TableName}", "json", req, runtime));
        }

        public ModifyDiversifyResponse ModifyDiversify(string InstanceId, string Name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyDiversifyWithOptions(InstanceId, Name, headers, runtime);
        }

        public async Task<ModifyDiversifyResponse> ModifyDiversifyAsync(string InstanceId, string Name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyDiversifyWithOptionsAsync(InstanceId, Name, headers, runtime);
        }

        public ModifyDiversifyResponse ModifyDiversifyWithOptions(string InstanceId, string Name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ModifyDiversifyResponse>(DoROARequest("ModifyDiversify", "2018-10-12", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/diversifies/{Name}", "json", req, runtime));
        }

        public async Task<ModifyDiversifyResponse> ModifyDiversifyWithOptionsAsync(string InstanceId, string Name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ModifyDiversifyResponse>(await DoROARequestAsync("ModifyDiversify", "2018-10-12", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/diversifies/{Name}", "json", req, runtime));
        }

        public ModifyExposureSettingsResponse ModifyExposureSettings(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyExposureSettingsWithOptions(InstanceId, headers, runtime);
        }

        public async Task<ModifyExposureSettingsResponse> ModifyExposureSettingsAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyExposureSettingsWithOptionsAsync(InstanceId, headers, runtime);
        }

        public ModifyExposureSettingsResponse ModifyExposureSettingsWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ModifyExposureSettingsResponse>(DoROARequest("ModifyExposureSettings", "2018-10-12", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/exposure-settings", "json", req, runtime));
        }

        public async Task<ModifyExposureSettingsResponse> ModifyExposureSettingsWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ModifyExposureSettingsResponse>(await DoROARequestAsync("ModifyExposureSettings", "2018-10-12", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/exposure-settings", "json", req, runtime));
        }

        public ModifyInstanceResponse ModifyInstance(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyInstanceWithOptions(InstanceId, headers, runtime);
        }

        public async Task<ModifyInstanceResponse> ModifyInstanceAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyInstanceWithOptionsAsync(InstanceId, headers, runtime);
        }

        public ModifyInstanceResponse ModifyInstanceWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ModifyInstanceResponse>(DoROARequest("ModifyInstance", "2018-10-12", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId, "json", req, runtime));
        }

        public async Task<ModifyInstanceResponse> ModifyInstanceWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ModifyInstanceResponse>(await DoROARequestAsync("ModifyInstance", "2018-10-12", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId, "json", req, runtime));
        }

        public ModifyItemsResponse ModifyItems(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyItemsWithOptions(InstanceId, headers, runtime);
        }

        public async Task<ModifyItemsResponse> ModifyItemsAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyItemsWithOptionsAsync(InstanceId, headers, runtime);
        }

        public ModifyItemsResponse ModifyItemsWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ModifyItemsResponse>(DoROARequest("ModifyItems", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/items", "json", req, runtime));
        }

        public async Task<ModifyItemsResponse> ModifyItemsWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ModifyItemsResponse>(await DoROARequestAsync("ModifyItems", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/items", "json", req, runtime));
        }

        public ModifyMixResponse ModifyMix(string InstanceId, string Name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyMixWithOptions(InstanceId, Name, headers, runtime);
        }

        public async Task<ModifyMixResponse> ModifyMixAsync(string InstanceId, string Name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyMixWithOptionsAsync(InstanceId, Name, headers, runtime);
        }

        public ModifyMixResponse ModifyMixWithOptions(string InstanceId, string Name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ModifyMixResponse>(DoROARequest("ModifyMix", "2018-10-12", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/mixes/{Name}", "json", req, runtime));
        }

        public async Task<ModifyMixResponse> ModifyMixWithOptionsAsync(string InstanceId, string Name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ModifyMixResponse>(await DoROARequestAsync("ModifyMix", "2018-10-12", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/mixes/{Name}", "json", req, runtime));
        }

        public ModifyRuleResponse ModifyRule(string InstanceId, string RuleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyRuleWithOptions(InstanceId, RuleId, headers, runtime);
        }

        public async Task<ModifyRuleResponse> ModifyRuleAsync(string InstanceId, string RuleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyRuleWithOptionsAsync(InstanceId, RuleId, headers, runtime);
        }

        public ModifyRuleResponse ModifyRuleWithOptions(string InstanceId, string RuleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ModifyRuleResponse>(DoROARequest("ModifyRule", "2018-10-12", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/rules/{RuleId}", "json", req, runtime));
        }

        public async Task<ModifyRuleResponse> ModifyRuleWithOptionsAsync(string InstanceId, string RuleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ModifyRuleResponse>(await DoROARequestAsync("ModifyRule", "2018-10-12", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/rules/{RuleId}", "json", req, runtime));
        }

        public ModifySceneResponse ModifyScene(string InstanceId, string SceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifySceneWithOptions(InstanceId, SceneId, headers, runtime);
        }

        public async Task<ModifySceneResponse> ModifySceneAsync(string InstanceId, string SceneId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifySceneWithOptionsAsync(InstanceId, SceneId, headers, runtime);
        }

        public ModifySceneResponse ModifySceneWithOptions(string InstanceId, string SceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ModifySceneResponse>(DoROARequest("ModifyScene", "2018-10-12", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/scenes/{SceneId}", "json", req, runtime));
        }

        public async Task<ModifySceneResponse> ModifySceneWithOptionsAsync(string InstanceId, string SceneId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ModifySceneResponse>(await DoROARequestAsync("ModifyScene", "2018-10-12", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/scenes/{SceneId}", "json", req, runtime));
        }

        public PublishRuleResponse PublishRule(string InstanceId, string RuleId, PublishRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishRuleWithOptions(InstanceId, RuleId, request, headers, runtime);
        }

        public async Task<PublishRuleResponse> PublishRuleAsync(string InstanceId, string RuleId, PublishRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishRuleWithOptionsAsync(InstanceId, RuleId, request, headers, runtime);
        }

        public PublishRuleResponse PublishRuleWithOptions(string InstanceId, string RuleId, PublishRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
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
            return TeaModel.ToObject<PublishRuleResponse>(DoROARequest("PublishRule", "2018-10-12", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/rules/{RuleId}/actions/publish", "json", req, runtime));
        }

        public async Task<PublishRuleResponse> PublishRuleWithOptionsAsync(string InstanceId, string RuleId, PublishRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                query["RuleType"] = request.RuleType;
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
            return TeaModel.ToObject<PublishRuleResponse>(await DoROARequestAsync("PublishRule", "2018-10-12", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/rules/{RuleId}/actions/publish", "json", req, runtime));
        }

        public PushDocumentResponse PushDocument(string InstanceId, string TableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PushDocumentWithOptions(InstanceId, TableName, headers, runtime);
        }

        public async Task<PushDocumentResponse> PushDocumentAsync(string InstanceId, string TableName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PushDocumentWithOptionsAsync(InstanceId, TableName, headers, runtime);
        }

        public PushDocumentResponse PushDocumentWithOptions(string InstanceId, string TableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<PushDocumentResponse>(DoROARequest("PushDocument", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/tables/{TableName}/actions/bulk", "json", req, runtime));
        }

        public async Task<PushDocumentResponse> PushDocumentWithOptionsAsync(string InstanceId, string TableName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<PushDocumentResponse>(await DoROARequestAsync("PushDocument", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/tables/{TableName}/actions/bulk", "json", req, runtime));
        }

        public PushInterventionResponse PushIntervention(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PushInterventionWithOptions(InstanceId, headers, runtime);
        }

        public async Task<PushInterventionResponse> PushInterventionAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PushInterventionWithOptionsAsync(InstanceId, headers, runtime);
        }

        public PushInterventionResponse PushInterventionWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<PushInterventionResponse>(DoROARequest("PushIntervention", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/intervene", "json", req, runtime));
        }

        public async Task<PushInterventionResponse> PushInterventionWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<PushInterventionResponse>(await DoROARequestAsync("PushIntervention", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/intervene", "json", req, runtime));
        }

        public QueryDataMessageResponse QueryDataMessage(string InstanceId, string Table, QueryDataMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryDataMessageWithOptions(InstanceId, Table, request, headers, runtime);
        }

        public async Task<QueryDataMessageResponse> QueryDataMessageAsync(string InstanceId, string Table, QueryDataMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryDataMessageWithOptionsAsync(InstanceId, Table, request, headers, runtime);
        }

        public QueryDataMessageResponse QueryDataMessageWithOptions(string InstanceId, string Table, QueryDataMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmdType))
            {
                query["CmdType"] = request.CmdType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemType))
            {
                query["ItemType"] = request.ItemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceId))
            {
                query["TraceId"] = request.TraceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BhvType))
            {
                query["BhvType"] = request.BhvType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageSource))
            {
                query["MessageSource"] = request.MessageSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryDataMessageResponse>(DoROARequest("QueryDataMessage", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/tables/{Table}/data-message", "json", req, runtime));
        }

        public async Task<QueryDataMessageResponse> QueryDataMessageWithOptionsAsync(string InstanceId, string Table, QueryDataMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmdType))
            {
                query["CmdType"] = request.CmdType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemType))
            {
                query["ItemType"] = request.ItemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceId))
            {
                query["TraceId"] = request.TraceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BhvType))
            {
                query["BhvType"] = request.BhvType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageSource))
            {
                query["MessageSource"] = request.MessageSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryDataMessageResponse>(await DoROARequestAsync("QueryDataMessage", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/tables/{Table}/data-message", "json", req, runtime));
        }

        public QueryDataMessageStatisticsResponse QueryDataMessageStatistics(string InstanceId, string Table, QueryDataMessageStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryDataMessageStatisticsWithOptions(InstanceId, Table, request, headers, runtime);
        }

        public async Task<QueryDataMessageStatisticsResponse> QueryDataMessageStatisticsAsync(string InstanceId, string Table, QueryDataMessageStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryDataMessageStatisticsWithOptionsAsync(InstanceId, Table, request, headers, runtime);
        }

        public QueryDataMessageStatisticsResponse QueryDataMessageStatisticsWithOptions(string InstanceId, string Table, QueryDataMessageStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmdType))
            {
                query["CmdType"] = request.CmdType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemType))
            {
                query["ItemType"] = request.ItemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceId))
            {
                query["TraceId"] = request.TraceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BhvType))
            {
                query["BhvType"] = request.BhvType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageSource))
            {
                query["MessageSource"] = request.MessageSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryDataMessageStatisticsResponse>(DoROARequest("QueryDataMessageStatistics", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/tables/{Table}/data-message-statistics", "json", req, runtime));
        }

        public async Task<QueryDataMessageStatisticsResponse> QueryDataMessageStatisticsWithOptionsAsync(string InstanceId, string Table, QueryDataMessageStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CmdType))
            {
                query["CmdType"] = request.CmdType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemType))
            {
                query["ItemType"] = request.ItemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TraceId))
            {
                query["TraceId"] = request.TraceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BhvType))
            {
                query["BhvType"] = request.BhvType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageSource))
            {
                query["MessageSource"] = request.MessageSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryDataMessageStatisticsResponse>(await DoROARequestAsync("QueryDataMessageStatistics", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/tables/{Table}/data-message-statistics", "json", req, runtime));
        }

        public QueryExceptionHistoryResponse QueryExceptionHistory(string InstanceId, QueryExceptionHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryExceptionHistoryWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<QueryExceptionHistoryResponse> QueryExceptionHistoryAsync(string InstanceId, QueryExceptionHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryExceptionHistoryWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public QueryExceptionHistoryResponse QueryExceptionHistoryWithOptions(string InstanceId, QueryExceptionHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
            return TeaModel.ToObject<QueryExceptionHistoryResponse>(DoROARequest("QueryExceptionHistory", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/sync-reports/exception-history", "json", req, runtime));
        }

        public async Task<QueryExceptionHistoryResponse> QueryExceptionHistoryWithOptionsAsync(string InstanceId, QueryExceptionHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
            return TeaModel.ToObject<QueryExceptionHistoryResponse>(await DoROARequestAsync("QueryExceptionHistory", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/sync-reports/exception-history", "json", req, runtime));
        }

        public QueryRawDataResponse QueryRawData(string InstanceId, string Table, QueryRawDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryRawDataWithOptions(InstanceId, Table, request, headers, runtime);
        }

        public async Task<QueryRawDataResponse> QueryRawDataAsync(string InstanceId, string Table, QueryRawDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryRawDataWithOptionsAsync(InstanceId, Table, request, headers, runtime);
        }

        public QueryRawDataResponse QueryRawDataWithOptions(string InstanceId, string Table, QueryRawDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemType))
            {
                query["ItemType"] = request.ItemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryRawDataResponse>(DoROARequest("QueryRawData", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/tables/{Table}/raw-data", "json", req, runtime));
        }

        public async Task<QueryRawDataResponse> QueryRawDataWithOptionsAsync(string InstanceId, string Table, QueryRawDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["ItemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemType))
            {
                query["ItemType"] = request.ItemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryRawDataResponse>(await DoROARequestAsync("QueryRawData", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/tables/{Table}/raw-data", "json", req, runtime));
        }

        public QuerySingleAggregationReportResponse QuerySingleAggregationReport(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QuerySingleAggregationReportWithOptions(InstanceId, headers, runtime);
        }

        public async Task<QuerySingleAggregationReportResponse> QuerySingleAggregationReportAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QuerySingleAggregationReportWithOptionsAsync(InstanceId, headers, runtime);
        }

        public QuerySingleAggregationReportResponse QuerySingleAggregationReportWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<QuerySingleAggregationReportResponse>(DoROARequest("QuerySingleAggregationReport", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/sync-reports/single-aggregation-report", "json", req, runtime));
        }

        public async Task<QuerySingleAggregationReportResponse> QuerySingleAggregationReportWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<QuerySingleAggregationReportResponse>(await DoROARequestAsync("QuerySingleAggregationReport", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/sync-reports/single-aggregation-report", "json", req, runtime));
        }

        public QuerySingleReportResponse QuerySingleReport(string InstanceId, QuerySingleReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QuerySingleReportWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<QuerySingleReportResponse> QuerySingleReportAsync(string InstanceId, QuerySingleReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QuerySingleReportWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public QuerySingleReportResponse QuerySingleReportWithOptions(string InstanceId, QuerySingleReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                query["ReportType"] = request.ReportType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QuerySingleReportResponse>(DoROARequest("QuerySingleReport", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/sync-reports/single-report", "json", req, runtime));
        }

        public async Task<QuerySingleReportResponse> QuerySingleReportWithOptionsAsync(string InstanceId, QuerySingleReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                query["ReportType"] = request.ReportType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QuerySingleReportResponse>(await DoROARequestAsync("QuerySingleReport", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/sync-reports/single-report", "json", req, runtime));
        }

        public QuerySyncReportAggregationResponse QuerySyncReportAggregation(string InstanceId, QuerySyncReportAggregationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QuerySyncReportAggregationWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<QuerySyncReportAggregationResponse> QuerySyncReportAggregationAsync(string InstanceId, QuerySyncReportAggregationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QuerySyncReportAggregationWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public QuerySyncReportAggregationResponse QuerySyncReportAggregationWithOptions(string InstanceId, QuerySyncReportAggregationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QuerySyncReportAggregationResponse>(DoROARequest("QuerySyncReportAggregation", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/sync-reports/aggregation", "json", req, runtime));
        }

        public async Task<QuerySyncReportAggregationResponse> QuerySyncReportAggregationWithOptionsAsync(string InstanceId, QuerySyncReportAggregationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QuerySyncReportAggregationResponse>(await DoROARequestAsync("QuerySyncReportAggregation", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/sync-reports/aggregation", "json", req, runtime));
        }

        public RecommendResponse Recommend(string InstanceId, RecommendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RecommendHeaders headers = new RecommendHeaders();
            return RecommendWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<RecommendResponse> RecommendAsync(string InstanceId, RecommendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RecommendHeaders headers = new RecommendHeaders();
            return await RecommendWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public RecommendResponse RecommendWithOptions(string InstanceId, RecommendRequest request, RecommendHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imei))
            {
                query["Imei"] = request.Imei;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnCount))
            {
                query["ReturnCount"] = request.ReturnCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Items))
            {
                query["Items"] = request.Items;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.RegionId))
            {
                realHeaders["RegionId"] = headers.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<RecommendResponse>(DoROARequest("Recommend", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/actions/recommend", "json", req, runtime));
        }

        public async Task<RecommendResponse> RecommendWithOptionsAsync(string InstanceId, RecommendRequest request, RecommendHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Imei))
            {
                query["Imei"] = request.Imei;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnCount))
            {
                query["ReturnCount"] = request.ReturnCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Items))
            {
                query["Items"] = request.Items;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.RegionId))
            {
                realHeaders["RegionId"] = headers.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<RecommendResponse>(await DoROARequestAsync("Recommend", "2018-10-12", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/actions/recommend", "json", req, runtime));
        }

        public RunInstanceResponse RunInstance(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunInstanceWithOptions(InstanceId, headers, runtime);
        }

        public async Task<RunInstanceResponse> RunInstanceAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunInstanceWithOptionsAsync(InstanceId, headers, runtime);
        }

        public RunInstanceResponse RunInstanceWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<RunInstanceResponse>(DoROARequest("RunInstance", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/import", "json", req, runtime));
        }

        public async Task<RunInstanceResponse> RunInstanceWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<RunInstanceResponse>(await DoROARequestAsync("RunInstance", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/import", "json", req, runtime));
        }

        public StopDataSetResponse StopDataSet(string InstanceId, string VersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopDataSetWithOptions(InstanceId, VersionId, headers, runtime);
        }

        public async Task<StopDataSetResponse> StopDataSetAsync(string InstanceId, string VersionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopDataSetWithOptionsAsync(InstanceId, VersionId, headers, runtime);
        }

        public StopDataSetResponse StopDataSetWithOptions(string InstanceId, string VersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<StopDataSetResponse>(DoROARequest("StopDataSet", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/dataSets/{VersionId}/actions/stop", "json", req, runtime));
        }

        public async Task<StopDataSetResponse> StopDataSetWithOptionsAsync(string InstanceId, string VersionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<StopDataSetResponse>(await DoROARequestAsync("StopDataSet", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/dataSets/{VersionId}/actions/stop", "json", req, runtime));
        }

        public UpgradeInstanceResponse UpgradeInstance(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpgradeInstanceWithOptions(InstanceId, headers, runtime);
        }

        public async Task<UpgradeInstanceResponse> UpgradeInstanceAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpgradeInstanceWithOptionsAsync(InstanceId, headers, runtime);
        }

        public UpgradeInstanceResponse UpgradeInstanceWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<UpgradeInstanceResponse>(DoROARequest("UpgradeInstance", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/upgrade", "json", req, runtime));
        }

        public async Task<UpgradeInstanceResponse> UpgradeInstanceWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<UpgradeInstanceResponse>(await DoROARequestAsync("UpgradeInstance", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/upgrade", "json", req, runtime));
        }

        public ValidateInstanceResponse ValidateInstance(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ValidateInstanceWithOptions(InstanceId, headers, runtime);
        }

        public async Task<ValidateInstanceResponse> ValidateInstanceAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ValidateInstanceWithOptionsAsync(InstanceId, headers, runtime);
        }

        public ValidateInstanceResponse ValidateInstanceWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ValidateInstanceResponse>(DoROARequest("ValidateInstance", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/validate", "json", req, runtime));
        }

        public async Task<ValidateInstanceResponse> ValidateInstanceWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ValidateInstanceResponse>(await DoROARequestAsync("ValidateInstance", "2018-10-12", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/validate", "json", req, runtime));
        }

    }
}
