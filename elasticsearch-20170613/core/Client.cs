// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Elasticsearch20170613.Models;

namespace AlibabaCloud.SDK.Elasticsearch20170613
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-2-pop", "elasticsearch.aliyuncs.com"},
                {"cn-beijing-finance-1", "elasticsearch.aliyuncs.com"},
                {"cn-beijing-finance-pop", "elasticsearch.aliyuncs.com"},
                {"cn-beijing-gov-1", "elasticsearch.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "elasticsearch.aliyuncs.com"},
                {"cn-chengdu", "elasticsearch.aliyuncs.com"},
                {"cn-edge-1", "elasticsearch.aliyuncs.com"},
                {"cn-fujian", "elasticsearch.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "elasticsearch.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "elasticsearch.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "elasticsearch.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "elasticsearch.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "elasticsearch.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "elasticsearch.aliyuncs.com"},
                {"cn-hangzhou-test-306", "elasticsearch.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "elasticsearch.aliyuncs.com"},
                {"cn-huhehaote", "elasticsearch.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "elasticsearch.aliyuncs.com"},
                {"cn-qingdao-nebula", "elasticsearch.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "elasticsearch.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "elasticsearch.aliyuncs.com"},
                {"cn-shanghai-inner", "elasticsearch.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "elasticsearch.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "elasticsearch.aliyuncs.com"},
                {"cn-shenzhen-inner", "elasticsearch.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "elasticsearch.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "elasticsearch.aliyuncs.com"},
                {"cn-wuhan", "elasticsearch.aliyuncs.com"},
                {"cn-wulanchabu", "elasticsearch.aliyuncs.com"},
                {"cn-yushanfang", "elasticsearch.aliyuncs.com"},
                {"cn-zhangbei", "elasticsearch.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "elasticsearch.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "elasticsearch.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "elasticsearch.aliyuncs.com"},
                {"eu-west-1-oxs", "elasticsearch.aliyuncs.com"},
                {"me-east-1", "elasticsearch.aliyuncs.com"},
                {"rus-west-1-pop", "elasticsearch.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("elasticsearch", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ActivateZonesResponse ActivateZones(string InstanceId, ActivateZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ActivateZonesWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ActivateZonesResponse> ActivateZonesAsync(string InstanceId, ActivateZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ActivateZonesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ActivateZonesResponse ActivateZonesWithOptions(string InstanceId, ActivateZonesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ActivateZonesResponse>(DoROARequest("ActivateZones", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/recover-zones", "json", req, runtime));
        }

        public async Task<ActivateZonesResponse> ActivateZonesWithOptionsAsync(string InstanceId, ActivateZonesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ActivateZonesResponse>(await DoROARequestAsync("ActivateZones", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/recover-zones", "json", req, runtime));
        }

        public AddConnectableClusterResponse AddConnectableCluster(string InstanceId, AddConnectableClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddConnectableClusterWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<AddConnectableClusterResponse> AddConnectableClusterAsync(string InstanceId, AddConnectableClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddConnectableClusterWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public AddConnectableClusterResponse AddConnectableClusterWithOptions(string InstanceId, AddConnectableClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<AddConnectableClusterResponse>(DoROARequest("AddConnectableCluster", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/connected-clusters", "json", req, runtime));
        }

        public async Task<AddConnectableClusterResponse> AddConnectableClusterWithOptionsAsync(string InstanceId, AddConnectableClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<AddConnectableClusterResponse>(await DoROARequestAsync("AddConnectableCluster", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/connected-clusters", "json", req, runtime));
        }

        public AddSnapshotRepoResponse AddSnapshotRepo(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddSnapshotRepoWithOptions(InstanceId, headers, runtime);
        }

        public async Task<AddSnapshotRepoResponse> AddSnapshotRepoAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddSnapshotRepoWithOptionsAsync(InstanceId, headers, runtime);
        }

        public AddSnapshotRepoResponse AddSnapshotRepoWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<AddSnapshotRepoResponse>(DoROARequest("AddSnapshotRepo", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/snapshot-repos", "json", req, runtime));
        }

        public async Task<AddSnapshotRepoResponse> AddSnapshotRepoWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<AddSnapshotRepoResponse>(await DoROARequestAsync("AddSnapshotRepo", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/snapshot-repos", "json", req, runtime));
        }

        public CancelDeletionResponse CancelDeletion(string InstanceId, CancelDeletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelDeletionWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<CancelDeletionResponse> CancelDeletionAsync(string InstanceId, CancelDeletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelDeletionWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public CancelDeletionResponse CancelDeletionWithOptions(string InstanceId, CancelDeletionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CancelDeletionResponse>(DoROARequest("CancelDeletion", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/cancel-deletion", "json", req, runtime));
        }

        public async Task<CancelDeletionResponse> CancelDeletionWithOptionsAsync(string InstanceId, CancelDeletionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CancelDeletionResponse>(await DoROARequestAsync("CancelDeletion", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/cancel-deletion", "json", req, runtime));
        }

        public CancelLogstashDeletionResponse CancelLogstashDeletion(string InstanceId, CancelLogstashDeletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelLogstashDeletionWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<CancelLogstashDeletionResponse> CancelLogstashDeletionAsync(string InstanceId, CancelLogstashDeletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelLogstashDeletionWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public CancelLogstashDeletionResponse CancelLogstashDeletionWithOptions(string InstanceId, CancelLogstashDeletionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CancelLogstashDeletionResponse>(DoROARequest("CancelLogstashDeletion", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/actions/cancel-deletion", "json", req, runtime));
        }

        public async Task<CancelLogstashDeletionResponse> CancelLogstashDeletionWithOptionsAsync(string InstanceId, CancelLogstashDeletionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CancelLogstashDeletionResponse>(await DoROARequestAsync("CancelLogstashDeletion", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/actions/cancel-deletion", "json", req, runtime));
        }

        public CancelTaskResponse CancelTask(string InstanceId, CancelTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelTaskWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<CancelTaskResponse> CancelTaskAsync(string InstanceId, CancelTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelTaskWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public CancelTaskResponse CancelTaskWithOptions(string InstanceId, CancelTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CancelTaskResponse>(DoROARequest("CancelTask", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/cancel-task", "json", req, runtime));
        }

        public async Task<CancelTaskResponse> CancelTaskWithOptionsAsync(string InstanceId, CancelTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CancelTaskResponse>(await DoROARequestAsync("CancelTask", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/cancel-task", "json", req, runtime));
        }

        public CloseDiagnosisResponse CloseDiagnosis(string InstanceId, CloseDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloseDiagnosisWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<CloseDiagnosisResponse> CloseDiagnosisAsync(string InstanceId, CloseDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloseDiagnosisWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public CloseDiagnosisResponse CloseDiagnosisWithOptions(string InstanceId, CloseDiagnosisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CloseDiagnosisResponse>(DoROARequest("CloseDiagnosis", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/diagnosis/instances/" + InstanceId + "/actions/close-diagnosis", "json", req, runtime));
        }

        public async Task<CloseDiagnosisResponse> CloseDiagnosisWithOptionsAsync(string InstanceId, CloseDiagnosisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CloseDiagnosisResponse>(await DoROARequestAsync("CloseDiagnosis", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/diagnosis/instances/" + InstanceId + "/actions/close-diagnosis", "json", req, runtime));
        }

        public CloseHttpsResponse CloseHttps(string InstanceId, CloseHttpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloseHttpsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<CloseHttpsResponse> CloseHttpsAsync(string InstanceId, CloseHttpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloseHttpsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public CloseHttpsResponse CloseHttpsWithOptions(string InstanceId, CloseHttpsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CloseHttpsResponse>(DoROARequest("CloseHttps", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/close-https", "json", req, runtime));
        }

        public async Task<CloseHttpsResponse> CloseHttpsWithOptionsAsync(string InstanceId, CloseHttpsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CloseHttpsResponse>(await DoROARequestAsync("CloseHttps", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/close-https", "json", req, runtime));
        }

        public CloseManagedIndexResponse CloseManagedIndex(string InstanceId, string Index, CloseManagedIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloseManagedIndexWithOptions(InstanceId, Index, request, headers, runtime);
        }

        public async Task<CloseManagedIndexResponse> CloseManagedIndexAsync(string InstanceId, string Index, CloseManagedIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloseManagedIndexWithOptionsAsync(InstanceId, Index, request, headers, runtime);
        }

        public CloseManagedIndexResponse CloseManagedIndexWithOptions(string InstanceId, string Index, CloseManagedIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Index = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Index);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CloseManagedIndexResponse>(DoROARequest("CloseManagedIndex", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/indices/" + Index + "/close-managed", "json", req, runtime));
        }

        public async Task<CloseManagedIndexResponse> CloseManagedIndexWithOptionsAsync(string InstanceId, string Index, CloseManagedIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Index = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Index);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CloseManagedIndexResponse>(await DoROARequestAsync("CloseManagedIndex", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/indices/" + Index + "/close-managed", "json", req, runtime));
        }

        public CreateCollectorResponse CreateCollector(CreateCollectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCollectorWithOptions(request, headers, runtime);
        }

        public async Task<CreateCollectorResponse> CreateCollectorAsync(CreateCollectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCollectorWithOptionsAsync(request, headers, runtime);
        }

        public CreateCollectorResponse CreateCollectorWithOptions(CreateCollectorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateCollectorResponse>(DoROARequest("CreateCollector", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/collectors", "json", req, runtime));
        }

        public async Task<CreateCollectorResponse> CreateCollectorWithOptionsAsync(CreateCollectorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateCollectorResponse>(await DoROARequestAsync("CreateCollector", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/collectors", "json", req, runtime));
        }

        public CreateDataStreamResponse CreateDataStream(string InstanceId, CreateDataStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDataStreamWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<CreateDataStreamResponse> CreateDataStreamAsync(string InstanceId, CreateDataStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDataStreamWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public CreateDataStreamResponse CreateDataStreamWithOptions(string InstanceId, CreateDataStreamRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateDataStreamResponse>(DoROARequest("CreateDataStream", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/data-streams", "json", req, runtime));
        }

        public async Task<CreateDataStreamResponse> CreateDataStreamWithOptionsAsync(string InstanceId, CreateDataStreamRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateDataStreamResponse>(await DoROARequestAsync("CreateDataStream", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/data-streams", "json", req, runtime));
        }

        public CreateDataTasksResponse CreateDataTasks(string InstanceId, CreateDataTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDataTasksWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<CreateDataTasksResponse> CreateDataTasksAsync(string InstanceId, CreateDataTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDataTasksWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public CreateDataTasksResponse CreateDataTasksWithOptions(string InstanceId, CreateDataTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateDataTasksResponse>(DoROARequest("CreateDataTasks", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/data-task", "json", req, runtime));
        }

        public async Task<CreateDataTasksResponse> CreateDataTasksWithOptionsAsync(string InstanceId, CreateDataTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateDataTasksResponse>(await DoROARequestAsync("CreateDataTasks", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/data-task", "json", req, runtime));
        }

        public CreateILMPolicyResponse CreateILMPolicy(string InstanceId, CreateILMPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateILMPolicyWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<CreateILMPolicyResponse> CreateILMPolicyAsync(string InstanceId, CreateILMPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateILMPolicyWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public CreateILMPolicyResponse CreateILMPolicyWithOptions(string InstanceId, CreateILMPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateILMPolicyResponse>(DoROARequest("CreateILMPolicy", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/ilm-policies", "json", req, runtime));
        }

        public async Task<CreateILMPolicyResponse> CreateILMPolicyWithOptionsAsync(string InstanceId, CreateILMPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateILMPolicyResponse>(await DoROARequestAsync("CreateILMPolicy", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/ilm-policies", "json", req, runtime));
        }

        public CreateIndexTemplateResponse CreateIndexTemplate(string InstanceId, CreateIndexTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIndexTemplateWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<CreateIndexTemplateResponse> CreateIndexTemplateAsync(string InstanceId, CreateIndexTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIndexTemplateWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public CreateIndexTemplateResponse CreateIndexTemplateWithOptions(string InstanceId, CreateIndexTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateIndexTemplateResponse>(DoROARequest("CreateIndexTemplate", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/index-templates", "json", req, runtime));
        }

        public async Task<CreateIndexTemplateResponse> CreateIndexTemplateWithOptionsAsync(string InstanceId, CreateIndexTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateIndexTemplateResponse>(await DoROARequestAsync("CreateIndexTemplate", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/index-templates", "json", req, runtime));
        }

        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceWithOptions(request, headers, runtime);
        }

        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceWithOptionsAsync(request, headers, runtime);
        }

        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateInstanceResponse>(DoROARequest("createInstance", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances", "json", req, runtime));
        }

        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await DoROARequestAsync("createInstance", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances", "json", req, runtime));
        }

        public CreateLogstashResponse CreateLogstash(CreateLogstashRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLogstashWithOptions(request, headers, runtime);
        }

        public async Task<CreateLogstashResponse> CreateLogstashAsync(CreateLogstashRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLogstashWithOptionsAsync(request, headers, runtime);
        }

        public CreateLogstashResponse CreateLogstashWithOptions(CreateLogstashRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateLogstashResponse>(DoROARequest("CreateLogstash", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes", "json", req, runtime));
        }

        public async Task<CreateLogstashResponse> CreateLogstashWithOptionsAsync(CreateLogstashRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateLogstashResponse>(await DoROARequestAsync("CreateLogstash", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes", "json", req, runtime));
        }

        public CreatePipelinesResponse CreatePipelines(string InstanceId, CreatePipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePipelinesWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<CreatePipelinesResponse> CreatePipelinesAsync(string InstanceId, CreatePipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePipelinesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public CreatePipelinesResponse CreatePipelinesWithOptions(string InstanceId, CreatePipelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Trigger))
            {
                query["trigger"] = request.Trigger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreatePipelinesResponse>(DoROARequest("CreatePipelines", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/pipelines", "json", req, runtime));
        }

        public async Task<CreatePipelinesResponse> CreatePipelinesWithOptionsAsync(string InstanceId, CreatePipelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Trigger))
            {
                query["trigger"] = request.Trigger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreatePipelinesResponse>(await DoROARequestAsync("CreatePipelines", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/pipelines", "json", req, runtime));
        }

        public CreateSnapshotResponse CreateSnapshot(string InstanceId, CreateSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSnapshotWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<CreateSnapshotResponse> CreateSnapshotAsync(string InstanceId, CreateSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSnapshotWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public CreateSnapshotResponse CreateSnapshotWithOptions(string InstanceId, CreateSnapshotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateSnapshotResponse>(DoROARequest("CreateSnapshot", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/snapshots", "json", req, runtime));
        }

        public async Task<CreateSnapshotResponse> CreateSnapshotWithOptionsAsync(string InstanceId, CreateSnapshotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateSnapshotResponse>(await DoROARequestAsync("CreateSnapshot", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/snapshots", "json", req, runtime));
        }

        public CreateVpcEndpointResponse CreateVpcEndpoint(string InstanceId, CreateVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateVpcEndpointWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<CreateVpcEndpointResponse> CreateVpcEndpointAsync(string InstanceId, CreateVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateVpcEndpointWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public CreateVpcEndpointResponse CreateVpcEndpointWithOptions(string InstanceId, CreateVpcEndpointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateVpcEndpointResponse>(DoROARequest("CreateVpcEndpoint", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/vpc-endpoints", "json", req, runtime));
        }

        public async Task<CreateVpcEndpointResponse> CreateVpcEndpointWithOptionsAsync(string InstanceId, CreateVpcEndpointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CreateVpcEndpointResponse>(await DoROARequestAsync("CreateVpcEndpoint", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/vpc-endpoints", "json", req, runtime));
        }

        public DeactivateZonesResponse DeactivateZones(string InstanceId, DeactivateZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeactivateZonesWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<DeactivateZonesResponse> DeactivateZonesAsync(string InstanceId, DeactivateZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeactivateZonesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public DeactivateZonesResponse DeactivateZonesWithOptions(string InstanceId, DeactivateZonesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeactivateZonesResponse>(DoROARequest("DeactivateZones", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/down-zones", "json", req, runtime));
        }

        public async Task<DeactivateZonesResponse> DeactivateZonesWithOptionsAsync(string InstanceId, DeactivateZonesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeactivateZonesResponse>(await DoROARequestAsync("DeactivateZones", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/down-zones", "json", req, runtime));
        }

        public DeleteCollectorResponse DeleteCollector(string ResId, DeleteCollectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteCollectorWithOptions(ResId, request, headers, runtime);
        }

        public async Task<DeleteCollectorResponse> DeleteCollectorAsync(string ResId, DeleteCollectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteCollectorWithOptionsAsync(ResId, request, headers, runtime);
        }

        public DeleteCollectorResponse DeleteCollectorWithOptions(string ResId, DeleteCollectorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ResId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteCollectorResponse>(DoROARequest("DeleteCollector", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/collectors/" + ResId, "json", req, runtime));
        }

        public async Task<DeleteCollectorResponse> DeleteCollectorWithOptionsAsync(string ResId, DeleteCollectorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ResId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteCollectorResponse>(await DoROARequestAsync("DeleteCollector", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/collectors/" + ResId, "json", req, runtime));
        }

        public DeleteConnectedClusterResponse DeleteConnectedCluster(string InstanceId, DeleteConnectedClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConnectedClusterWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<DeleteConnectedClusterResponse> DeleteConnectedClusterAsync(string InstanceId, DeleteConnectedClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConnectedClusterWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public DeleteConnectedClusterResponse DeleteConnectedClusterWithOptions(string InstanceId, DeleteConnectedClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectedInstanceId))
            {
                query["connectedInstanceId"] = request.ConnectedInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteConnectedClusterResponse>(DoROARequest("DeleteConnectedCluster", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId + "/connected-clusters", "json", req, runtime));
        }

        public async Task<DeleteConnectedClusterResponse> DeleteConnectedClusterWithOptionsAsync(string InstanceId, DeleteConnectedClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectedInstanceId))
            {
                query["connectedInstanceId"] = request.ConnectedInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteConnectedClusterResponse>(await DoROARequestAsync("DeleteConnectedCluster", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId + "/connected-clusters", "json", req, runtime));
        }

        public DeleteDataStreamResponse DeleteDataStream(string InstanceId, string DataStream, DeleteDataStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDataStreamWithOptions(InstanceId, DataStream, request, headers, runtime);
        }

        public async Task<DeleteDataStreamResponse> DeleteDataStreamAsync(string InstanceId, string DataStream, DeleteDataStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDataStreamWithOptionsAsync(InstanceId, DataStream, request, headers, runtime);
        }

        public DeleteDataStreamResponse DeleteDataStreamWithOptions(string InstanceId, string DataStream, DeleteDataStreamRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            DataStream = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DataStream);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteDataStreamResponse>(DoROARequest("DeleteDataStream", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId + "/data-streams/" + DataStream, "json", req, runtime));
        }

        public async Task<DeleteDataStreamResponse> DeleteDataStreamWithOptionsAsync(string InstanceId, string DataStream, DeleteDataStreamRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            DataStream = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DataStream);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteDataStreamResponse>(await DoROARequestAsync("DeleteDataStream", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId + "/data-streams/" + DataStream, "json", req, runtime));
        }

        public DeleteDataTaskResponse DeleteDataTask(string InstanceId, DeleteDataTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDataTaskWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<DeleteDataTaskResponse> DeleteDataTaskAsync(string InstanceId, DeleteDataTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDataTaskWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public DeleteDataTaskResponse DeleteDataTaskWithOptions(string InstanceId, DeleteDataTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteDataTaskResponse>(DoROARequest("DeleteDataTask", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId + "/data-task", "json", req, runtime));
        }

        public async Task<DeleteDataTaskResponse> DeleteDataTaskWithOptionsAsync(string InstanceId, DeleteDataTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteDataTaskResponse>(await DoROARequestAsync("DeleteDataTask", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId + "/data-task", "json", req, runtime));
        }

        public DeleteILMPolicyResponse DeleteILMPolicy(string InstanceId, string PolicyName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteILMPolicyWithOptions(InstanceId, PolicyName, headers, runtime);
        }

        public async Task<DeleteILMPolicyResponse> DeleteILMPolicyAsync(string InstanceId, string PolicyName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteILMPolicyWithOptionsAsync(InstanceId, PolicyName, headers, runtime);
        }

        public DeleteILMPolicyResponse DeleteILMPolicyWithOptions(string InstanceId, string PolicyName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            PolicyName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(PolicyName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteILMPolicyResponse>(DoROARequest("DeleteILMPolicy", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId + "/ilm-policies/" + PolicyName, "json", req, runtime));
        }

        public async Task<DeleteILMPolicyResponse> DeleteILMPolicyWithOptionsAsync(string InstanceId, string PolicyName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            PolicyName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(PolicyName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteILMPolicyResponse>(await DoROARequestAsync("DeleteILMPolicy", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId + "/ilm-policies/" + PolicyName, "json", req, runtime));
        }

        public DeleteIndexTemplateResponse DeleteIndexTemplate(string InstanceId, string IndexTemplate)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIndexTemplateWithOptions(InstanceId, IndexTemplate, headers, runtime);
        }

        public async Task<DeleteIndexTemplateResponse> DeleteIndexTemplateAsync(string InstanceId, string IndexTemplate)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIndexTemplateWithOptionsAsync(InstanceId, IndexTemplate, headers, runtime);
        }

        public DeleteIndexTemplateResponse DeleteIndexTemplateWithOptions(string InstanceId, string IndexTemplate, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            IndexTemplate = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(IndexTemplate);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteIndexTemplateResponse>(DoROARequest("DeleteIndexTemplate", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId + "/index-templates/" + IndexTemplate, "json", req, runtime));
        }

        public async Task<DeleteIndexTemplateResponse> DeleteIndexTemplateWithOptionsAsync(string InstanceId, string IndexTemplate, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            IndexTemplate = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(IndexTemplate);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteIndexTemplateResponse>(await DoROARequestAsync("DeleteIndexTemplate", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId + "/index-templates/" + IndexTemplate, "json", req, runtime));
        }

        public DeleteInstanceResponse DeleteInstance(string InstanceId, DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteInstanceWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(string InstanceId, DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteInstanceWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public DeleteInstanceResponse DeleteInstanceWithOptions(string InstanceId, DeleteInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteType))
            {
                query["deleteType"] = request.DeleteType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(DoROARequest("DeleteInstance", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId, "json", req, runtime));
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(string InstanceId, DeleteInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteType))
            {
                query["deleteType"] = request.DeleteType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await DoROARequestAsync("DeleteInstance", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId, "json", req, runtime));
        }

        public DeleteLogstashResponse DeleteLogstash(string InstanceId, DeleteLogstashRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLogstashWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<DeleteLogstashResponse> DeleteLogstashAsync(string InstanceId, DeleteLogstashRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteLogstashWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public DeleteLogstashResponse DeleteLogstashWithOptions(string InstanceId, DeleteLogstashRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteType))
            {
                query["deleteType"] = request.DeleteType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteLogstashResponse>(DoROARequest("DeleteLogstash", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/logstashes/" + InstanceId, "json", req, runtime));
        }

        public async Task<DeleteLogstashResponse> DeleteLogstashWithOptionsAsync(string InstanceId, DeleteLogstashRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteType))
            {
                query["deleteType"] = request.DeleteType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteLogstashResponse>(await DoROARequestAsync("DeleteLogstash", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/logstashes/" + InstanceId, "json", req, runtime));
        }

        public DeletePipelinesResponse DeletePipelines(string InstanceId, DeletePipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePipelinesWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<DeletePipelinesResponse> DeletePipelinesAsync(string InstanceId, DeletePipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePipelinesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public DeletePipelinesResponse DeletePipelinesWithOptions(string InstanceId, DeletePipelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineIds))
            {
                query["pipelineIds"] = request.PipelineIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeletePipelinesResponse>(DoROARequest("DeletePipelines", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/logstashes/" + InstanceId + "/pipelines", "json", req, runtime));
        }

        public async Task<DeletePipelinesResponse> DeletePipelinesWithOptionsAsync(string InstanceId, DeletePipelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineIds))
            {
                query["pipelineIds"] = request.PipelineIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeletePipelinesResponse>(await DoROARequestAsync("DeletePipelines", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/logstashes/" + InstanceId + "/pipelines", "json", req, runtime));
        }

        public DeleteSnapshotRepoResponse DeleteSnapshotRepo(string InstanceId, DeleteSnapshotRepoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSnapshotRepoWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<DeleteSnapshotRepoResponse> DeleteSnapshotRepoAsync(string InstanceId, DeleteSnapshotRepoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSnapshotRepoWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public DeleteSnapshotRepoResponse DeleteSnapshotRepoWithOptions(string InstanceId, DeleteSnapshotRepoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoPath))
            {
                query["repoPath"] = request.RepoPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteSnapshotRepoResponse>(DoROARequest("DeleteSnapshotRepo", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId + "/snapshot-repos", "json", req, runtime));
        }

        public async Task<DeleteSnapshotRepoResponse> DeleteSnapshotRepoWithOptionsAsync(string InstanceId, DeleteSnapshotRepoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepoPath))
            {
                query["repoPath"] = request.RepoPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteSnapshotRepoResponse>(await DoROARequestAsync("DeleteSnapshotRepo", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId + "/snapshot-repos", "json", req, runtime));
        }

        public DeleteVpcEndpointResponse DeleteVpcEndpoint(string InstanceId, string EndpointId, DeleteVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteVpcEndpointWithOptions(InstanceId, EndpointId, request, headers, runtime);
        }

        public async Task<DeleteVpcEndpointResponse> DeleteVpcEndpointAsync(string InstanceId, string EndpointId, DeleteVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteVpcEndpointWithOptionsAsync(InstanceId, EndpointId, request, headers, runtime);
        }

        public DeleteVpcEndpointResponse DeleteVpcEndpointWithOptions(string InstanceId, string EndpointId, DeleteVpcEndpointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            EndpointId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(EndpointId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteVpcEndpointResponse>(DoROARequest("DeleteVpcEndpoint", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId + "/vpc-endpoints/" + EndpointId, "json", req, runtime));
        }

        public async Task<DeleteVpcEndpointResponse> DeleteVpcEndpointWithOptionsAsync(string InstanceId, string EndpointId, DeleteVpcEndpointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            EndpointId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(EndpointId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteVpcEndpointResponse>(await DoROARequestAsync("DeleteVpcEndpoint", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/instances/" + InstanceId + "/vpc-endpoints/" + EndpointId, "json", req, runtime));
        }

        public DescribeAckOperatorResponse DescribeAckOperator(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAckOperatorWithOptions(ClusterId, headers, runtime);
        }

        public async Task<DescribeAckOperatorResponse> DescribeAckOperatorAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAckOperatorWithOptionsAsync(ClusterId, headers, runtime);
        }

        public DescribeAckOperatorResponse DescribeAckOperatorWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeAckOperatorResponse>(DoROARequest("DescribeAckOperator", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/ack-clusters/" + ClusterId + "/operator", "json", req, runtime));
        }

        public async Task<DescribeAckOperatorResponse> DescribeAckOperatorWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeAckOperatorResponse>(await DoROARequestAsync("DescribeAckOperator", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/ack-clusters/" + ClusterId + "/operator", "json", req, runtime));
        }

        public DescribeCollectorResponse DescribeCollector(string ResId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeCollectorWithOptions(ResId, headers, runtime);
        }

        public async Task<DescribeCollectorResponse> DescribeCollectorAsync(string ResId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeCollectorWithOptionsAsync(ResId, headers, runtime);
        }

        public DescribeCollectorResponse DescribeCollectorWithOptions(string ResId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ResId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeCollectorResponse>(DoROARequest("DescribeCollector", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/collectors/" + ResId, "json", req, runtime));
        }

        public async Task<DescribeCollectorResponse> DescribeCollectorWithOptionsAsync(string ResId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ResId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeCollectorResponse>(await DoROARequestAsync("DescribeCollector", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/collectors/" + ResId, "json", req, runtime));
        }

        public DescribeConnectableClustersResponse DescribeConnectableClusters(string InstanceId, DescribeConnectableClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeConnectableClustersWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<DescribeConnectableClustersResponse> DescribeConnectableClustersAsync(string InstanceId, DescribeConnectableClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeConnectableClustersWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public DescribeConnectableClustersResponse DescribeConnectableClustersWithOptions(string InstanceId, DescribeConnectableClustersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlreadySetItems))
            {
                query["alreadySetItems"] = request.AlreadySetItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeConnectableClustersResponse>(DoROARequest("DescribeConnectableClusters", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/connectable-clusters", "json", req, runtime));
        }

        public async Task<DescribeConnectableClustersResponse> DescribeConnectableClustersWithOptionsAsync(string InstanceId, DescribeConnectableClustersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlreadySetItems))
            {
                query["alreadySetItems"] = request.AlreadySetItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeConnectableClustersResponse>(await DoROARequestAsync("DescribeConnectableClusters", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/connectable-clusters", "json", req, runtime));
        }

        public DescribeDiagnoseReportResponse DescribeDiagnoseReport(string InstanceId, string ReportId, DescribeDiagnoseReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeDiagnoseReportWithOptions(InstanceId, ReportId, request, headers, runtime);
        }

        public async Task<DescribeDiagnoseReportResponse> DescribeDiagnoseReportAsync(string InstanceId, string ReportId, DescribeDiagnoseReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeDiagnoseReportWithOptionsAsync(InstanceId, ReportId, request, headers, runtime);
        }

        public DescribeDiagnoseReportResponse DescribeDiagnoseReportWithOptions(string InstanceId, string ReportId, DescribeDiagnoseReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            ReportId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ReportId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeDiagnoseReportResponse>(DoROARequest("DescribeDiagnoseReport", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/diagnosis/instances/" + InstanceId + "/reports/" + ReportId, "json", req, runtime));
        }

        public async Task<DescribeDiagnoseReportResponse> DescribeDiagnoseReportWithOptionsAsync(string InstanceId, string ReportId, DescribeDiagnoseReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            ReportId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ReportId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeDiagnoseReportResponse>(await DoROARequestAsync("DescribeDiagnoseReport", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/diagnosis/instances/" + InstanceId + "/reports/" + ReportId, "json", req, runtime));
        }

        public DescribeDiagnosisSettingsResponse DescribeDiagnosisSettings(string InstanceId, DescribeDiagnosisSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeDiagnosisSettingsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<DescribeDiagnosisSettingsResponse> DescribeDiagnosisSettingsAsync(string InstanceId, DescribeDiagnosisSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeDiagnosisSettingsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public DescribeDiagnosisSettingsResponse DescribeDiagnosisSettingsWithOptions(string InstanceId, DescribeDiagnosisSettingsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeDiagnosisSettingsResponse>(DoROARequest("DescribeDiagnosisSettings", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/diagnosis/instances/" + InstanceId + "/settings", "json", req, runtime));
        }

        public async Task<DescribeDiagnosisSettingsResponse> DescribeDiagnosisSettingsWithOptionsAsync(string InstanceId, DescribeDiagnosisSettingsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeDiagnosisSettingsResponse>(await DoROARequestAsync("DescribeDiagnosisSettings", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/diagnosis/instances/" + InstanceId + "/settings", "json", req, runtime));
        }

        public DescribeElasticsearchHealthResponse DescribeElasticsearchHealth(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeElasticsearchHealthWithOptions(InstanceId, headers, runtime);
        }

        public async Task<DescribeElasticsearchHealthResponse> DescribeElasticsearchHealthAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeElasticsearchHealthWithOptionsAsync(InstanceId, headers, runtime);
        }

        public DescribeElasticsearchHealthResponse DescribeElasticsearchHealthWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeElasticsearchHealthResponse>(DoROARequest("DescribeElasticsearchHealth", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/elasticsearch-health", "json", req, runtime));
        }

        public async Task<DescribeElasticsearchHealthResponse> DescribeElasticsearchHealthWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeElasticsearchHealthResponse>(await DoROARequestAsync("DescribeElasticsearchHealth", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/elasticsearch-health", "json", req, runtime));
        }

        public DescribeILMPolicyResponse DescribeILMPolicy(string InstanceId, string PolicyName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeILMPolicyWithOptions(InstanceId, PolicyName, headers, runtime);
        }

        public async Task<DescribeILMPolicyResponse> DescribeILMPolicyAsync(string InstanceId, string PolicyName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeILMPolicyWithOptionsAsync(InstanceId, PolicyName, headers, runtime);
        }

        public DescribeILMPolicyResponse DescribeILMPolicyWithOptions(string InstanceId, string PolicyName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            PolicyName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(PolicyName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeILMPolicyResponse>(DoROARequest("DescribeILMPolicy", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/ilm-policies/" + PolicyName, "json", req, runtime));
        }

        public async Task<DescribeILMPolicyResponse> DescribeILMPolicyWithOptionsAsync(string InstanceId, string PolicyName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            PolicyName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(PolicyName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeILMPolicyResponse>(await DoROARequestAsync("DescribeILMPolicy", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/ilm-policies/" + PolicyName, "json", req, runtime));
        }

        public DescribeIndexTemplateResponse DescribeIndexTemplate(string InstanceId, string IndexTemplate)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeIndexTemplateWithOptions(InstanceId, IndexTemplate, headers, runtime);
        }

        public async Task<DescribeIndexTemplateResponse> DescribeIndexTemplateAsync(string InstanceId, string IndexTemplate)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeIndexTemplateWithOptionsAsync(InstanceId, IndexTemplate, headers, runtime);
        }

        public DescribeIndexTemplateResponse DescribeIndexTemplateWithOptions(string InstanceId, string IndexTemplate, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            IndexTemplate = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(IndexTemplate);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeIndexTemplateResponse>(DoROARequest("DescribeIndexTemplate", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/index-templates/" + IndexTemplate, "json", req, runtime));
        }

        public async Task<DescribeIndexTemplateResponse> DescribeIndexTemplateWithOptionsAsync(string InstanceId, string IndexTemplate, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            IndexTemplate = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(IndexTemplate);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeIndexTemplateResponse>(await DoROARequestAsync("DescribeIndexTemplate", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/index-templates/" + IndexTemplate, "json", req, runtime));
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
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(DoROARequest("DescribeInstance", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId, "json", req, runtime));
        }

        public async Task<DescribeInstanceResponse> DescribeInstanceWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(await DoROARequestAsync("DescribeInstance", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId, "json", req, runtime));
        }

        public DescribeKibanaSettingsResponse DescribeKibanaSettings(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeKibanaSettingsWithOptions(InstanceId, headers, runtime);
        }

        public async Task<DescribeKibanaSettingsResponse> DescribeKibanaSettingsAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeKibanaSettingsWithOptionsAsync(InstanceId, headers, runtime);
        }

        public DescribeKibanaSettingsResponse DescribeKibanaSettingsWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeKibanaSettingsResponse>(DoROARequest("DescribeKibanaSettings", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/kibana-settings", "json", req, runtime));
        }

        public async Task<DescribeKibanaSettingsResponse> DescribeKibanaSettingsWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeKibanaSettingsResponse>(await DoROARequestAsync("DescribeKibanaSettings", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/kibana-settings", "json", req, runtime));
        }

        public DescribeLogstashResponse DescribeLogstash(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeLogstashWithOptions(InstanceId, headers, runtime);
        }

        public async Task<DescribeLogstashResponse> DescribeLogstashAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeLogstashWithOptionsAsync(InstanceId, headers, runtime);
        }

        public DescribeLogstashResponse DescribeLogstashWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeLogstashResponse>(DoROARequest("DescribeLogstash", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/logstashes/" + InstanceId, "json", req, runtime));
        }

        public async Task<DescribeLogstashResponse> DescribeLogstashWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeLogstashResponse>(await DoROARequestAsync("DescribeLogstash", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/logstashes/" + InstanceId, "json", req, runtime));
        }

        public DescribePipelineResponse DescribePipeline(string InstanceId, string PipelineId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribePipelineWithOptions(InstanceId, PipelineId, headers, runtime);
        }

        public async Task<DescribePipelineResponse> DescribePipelineAsync(string InstanceId, string PipelineId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribePipelineWithOptionsAsync(InstanceId, PipelineId, headers, runtime);
        }

        public DescribePipelineResponse DescribePipelineWithOptions(string InstanceId, string PipelineId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            PipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(PipelineId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribePipelineResponse>(DoROARequest("DescribePipeline", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/logstashes/" + InstanceId + "/pipelines/" + PipelineId, "json", req, runtime));
        }

        public async Task<DescribePipelineResponse> DescribePipelineWithOptionsAsync(string InstanceId, string PipelineId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            PipelineId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(PipelineId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribePipelineResponse>(await DoROARequestAsync("DescribePipeline", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/logstashes/" + InstanceId + "/pipelines/" + PipelineId, "json", req, runtime));
        }

        public DescribePipelineManagementConfigResponse DescribePipelineManagementConfig(string InstanceId, DescribePipelineManagementConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribePipelineManagementConfigWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<DescribePipelineManagementConfigResponse> DescribePipelineManagementConfigAsync(string InstanceId, DescribePipelineManagementConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribePipelineManagementConfigWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public DescribePipelineManagementConfigResponse DescribePipelineManagementConfigWithOptions(string InstanceId, DescribePipelineManagementConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribePipelineManagementConfigResponse>(DoROARequest("DescribePipelineManagementConfig", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/logstashes/" + InstanceId + "/pipeline-management-config", "json", req, runtime));
        }

        public async Task<DescribePipelineManagementConfigResponse> DescribePipelineManagementConfigWithOptionsAsync(string InstanceId, DescribePipelineManagementConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribePipelineManagementConfigResponse>(await DoROARequestAsync("DescribePipelineManagementConfig", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/logstashes/" + InstanceId + "/pipeline-management-config", "json", req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRegionsWithOptions(headers, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRegionsWithOptionsAsync(headers, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoROARequest("DescribeRegions", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/regions", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoROARequestAsync("DescribeRegions", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/regions", "json", req, runtime));
        }

        public DescribeSnapshotSettingResponse DescribeSnapshotSetting(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSnapshotSettingWithOptions(InstanceId, headers, runtime);
        }

        public async Task<DescribeSnapshotSettingResponse> DescribeSnapshotSettingAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSnapshotSettingWithOptionsAsync(InstanceId, headers, runtime);
        }

        public DescribeSnapshotSettingResponse DescribeSnapshotSettingWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeSnapshotSettingResponse>(DoROARequest("DescribeSnapshotSetting", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/snapshot-setting", "json", req, runtime));
        }

        public async Task<DescribeSnapshotSettingResponse> DescribeSnapshotSettingWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeSnapshotSettingResponse>(await DoROARequestAsync("DescribeSnapshotSetting", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/snapshot-setting", "json", req, runtime));
        }

        public DescribeTemplatesResponse DescribeTemplates(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeTemplatesWithOptions(InstanceId, headers, runtime);
        }

        public async Task<DescribeTemplatesResponse> DescribeTemplatesAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeTemplatesWithOptionsAsync(InstanceId, headers, runtime);
        }

        public DescribeTemplatesResponse DescribeTemplatesWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeTemplatesResponse>(DoROARequest("DescribeTemplates", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/templates", "json", req, runtime));
        }

        public async Task<DescribeTemplatesResponse> DescribeTemplatesWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeTemplatesResponse>(await DoROARequestAsync("DescribeTemplates", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/templates", "json", req, runtime));
        }

        public DescribeXpackMonitorConfigResponse DescribeXpackMonitorConfig(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeXpackMonitorConfigWithOptions(InstanceId, headers, runtime);
        }

        public async Task<DescribeXpackMonitorConfigResponse> DescribeXpackMonitorConfigAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeXpackMonitorConfigWithOptionsAsync(InstanceId, headers, runtime);
        }

        public DescribeXpackMonitorConfigResponse DescribeXpackMonitorConfigWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeXpackMonitorConfigResponse>(DoROARequest("DescribeXpackMonitorConfig", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/logstashes/" + InstanceId + "/xpack-monitor-config", "json", req, runtime));
        }

        public async Task<DescribeXpackMonitorConfigResponse> DescribeXpackMonitorConfigWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeXpackMonitorConfigResponse>(await DoROARequestAsync("DescribeXpackMonitorConfig", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/logstashes/" + InstanceId + "/xpack-monitor-config", "json", req, runtime));
        }

        public DiagnoseInstanceResponse DiagnoseInstance(string InstanceId, DiagnoseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DiagnoseInstanceWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<DiagnoseInstanceResponse> DiagnoseInstanceAsync(string InstanceId, DiagnoseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DiagnoseInstanceWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public DiagnoseInstanceResponse DiagnoseInstanceWithOptions(string InstanceId, DiagnoseInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DiagnoseInstanceResponse>(DoROARequest("DiagnoseInstance", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/diagnosis/instances/" + InstanceId + "/actions/diagnose", "json", req, runtime));
        }

        public async Task<DiagnoseInstanceResponse> DiagnoseInstanceWithOptionsAsync(string InstanceId, DiagnoseInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DiagnoseInstanceResponse>(await DoROARequestAsync("DiagnoseInstance", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/diagnosis/instances/" + InstanceId + "/actions/diagnose", "json", req, runtime));
        }

        public EstimatedLogstashRestartTimeResponse EstimatedLogstashRestartTime(string InstanceId, EstimatedLogstashRestartTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EstimatedLogstashRestartTimeWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<EstimatedLogstashRestartTimeResponse> EstimatedLogstashRestartTimeAsync(string InstanceId, EstimatedLogstashRestartTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EstimatedLogstashRestartTimeWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public EstimatedLogstashRestartTimeResponse EstimatedLogstashRestartTimeWithOptions(string InstanceId, EstimatedLogstashRestartTimeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<EstimatedLogstashRestartTimeResponse>(DoROARequest("EstimatedLogstashRestartTime", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/estimated-time/restart-time", "json", req, runtime));
        }

        public async Task<EstimatedLogstashRestartTimeResponse> EstimatedLogstashRestartTimeWithOptionsAsync(string InstanceId, EstimatedLogstashRestartTimeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<EstimatedLogstashRestartTimeResponse>(await DoROARequestAsync("EstimatedLogstashRestartTime", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/estimated-time/restart-time", "json", req, runtime));
        }

        public EstimatedRestartTimeResponse EstimatedRestartTime(string InstanceId, EstimatedRestartTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EstimatedRestartTimeWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<EstimatedRestartTimeResponse> EstimatedRestartTimeAsync(string InstanceId, EstimatedRestartTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EstimatedRestartTimeWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public EstimatedRestartTimeResponse EstimatedRestartTimeWithOptions(string InstanceId, EstimatedRestartTimeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<EstimatedRestartTimeResponse>(DoROARequest("EstimatedRestartTime", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/estimated-time/restart-time", "json", req, runtime));
        }

        public async Task<EstimatedRestartTimeResponse> EstimatedRestartTimeWithOptionsAsync(string InstanceId, EstimatedRestartTimeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<EstimatedRestartTimeResponse>(await DoROARequestAsync("EstimatedRestartTime", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/estimated-time/restart-time", "json", req, runtime));
        }

        public GetClusterDataInformationResponse GetClusterDataInformation()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetClusterDataInformationWithOptions(headers, runtime);
        }

        public async Task<GetClusterDataInformationResponse> GetClusterDataInformationAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetClusterDataInformationWithOptionsAsync(headers, runtime);
        }

        public GetClusterDataInformationResponse GetClusterDataInformationWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetClusterDataInformationResponse>(DoROARequest("GetClusterDataInformation", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/cluster/data-information", "json", req, runtime));
        }

        public async Task<GetClusterDataInformationResponse> GetClusterDataInformationWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetClusterDataInformationResponse>(await DoROARequestAsync("GetClusterDataInformation", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/cluster/data-information", "json", req, runtime));
        }

        public GetElastictaskResponse GetElastictask(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetElastictaskWithOptions(InstanceId, headers, runtime);
        }

        public async Task<GetElastictaskResponse> GetElastictaskAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetElastictaskWithOptionsAsync(InstanceId, headers, runtime);
        }

        public GetElastictaskResponse GetElastictaskWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetElastictaskResponse>(DoROARequest("GetElastictask", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/elastic-task", "json", req, runtime));
        }

        public async Task<GetElastictaskResponse> GetElastictaskWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetElastictaskResponse>(await DoROARequestAsync("GetElastictask", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/elastic-task", "json", req, runtime));
        }

        public GetEmonGrafanaAlertsResponse GetEmonGrafanaAlerts(string ProjectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEmonGrafanaAlertsWithOptions(ProjectId, headers, runtime);
        }

        public async Task<GetEmonGrafanaAlertsResponse> GetEmonGrafanaAlertsAsync(string ProjectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEmonGrafanaAlertsWithOptionsAsync(ProjectId, headers, runtime);
        }

        public GetEmonGrafanaAlertsResponse GetEmonGrafanaAlertsWithOptions(string ProjectId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ProjectId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetEmonGrafanaAlertsResponse>(DoROARequest("GetEmonGrafanaAlerts", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/emon/projects/" + ProjectId + "/grafana/proxy/api/alerts", "json", req, runtime));
        }

        public async Task<GetEmonGrafanaAlertsResponse> GetEmonGrafanaAlertsWithOptionsAsync(string ProjectId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ProjectId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetEmonGrafanaAlertsResponse>(await DoROARequestAsync("GetEmonGrafanaAlerts", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/emon/projects/" + ProjectId + "/grafana/proxy/api/alerts", "json", req, runtime));
        }

        public GetEmonGrafanaDashboardsResponse GetEmonGrafanaDashboards(string ProjectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEmonGrafanaDashboardsWithOptions(ProjectId, headers, runtime);
        }

        public async Task<GetEmonGrafanaDashboardsResponse> GetEmonGrafanaDashboardsAsync(string ProjectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEmonGrafanaDashboardsWithOptionsAsync(ProjectId, headers, runtime);
        }

        public GetEmonGrafanaDashboardsResponse GetEmonGrafanaDashboardsWithOptions(string ProjectId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ProjectId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetEmonGrafanaDashboardsResponse>(DoROARequest("GetEmonGrafanaDashboards", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/emon/projects/" + ProjectId + "/grafana/proxy/api/search", "json", req, runtime));
        }

        public async Task<GetEmonGrafanaDashboardsResponse> GetEmonGrafanaDashboardsWithOptionsAsync(string ProjectId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ProjectId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetEmonGrafanaDashboardsResponse>(await DoROARequestAsync("GetEmonGrafanaDashboards", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/emon/projects/" + ProjectId + "/grafana/proxy/api/search", "json", req, runtime));
        }

        public GetEmonMonitorDataResponse GetEmonMonitorData(string ProjectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEmonMonitorDataWithOptions(ProjectId, headers, runtime);
        }

        public async Task<GetEmonMonitorDataResponse> GetEmonMonitorDataAsync(string ProjectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEmonMonitorDataWithOptionsAsync(ProjectId, headers, runtime);
        }

        public GetEmonMonitorDataResponse GetEmonMonitorDataWithOptions(string ProjectId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ProjectId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetEmonMonitorDataResponse>(DoROARequest("GetEmonMonitorData", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/emon/projects/" + ProjectId + "/metrics/query", "json", req, runtime));
        }

        public async Task<GetEmonMonitorDataResponse> GetEmonMonitorDataWithOptionsAsync(string ProjectId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ProjectId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetEmonMonitorDataResponse>(await DoROARequestAsync("GetEmonMonitorData", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/emon/projects/" + ProjectId + "/metrics/query", "json", req, runtime));
        }

        public GetRegionConfigurationResponse GetRegionConfiguration(GetRegionConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRegionConfigurationWithOptions(request, headers, runtime);
        }

        public async Task<GetRegionConfigurationResponse> GetRegionConfigurationAsync(GetRegionConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRegionConfigurationWithOptionsAsync(request, headers, runtime);
        }

        public GetRegionConfigurationResponse GetRegionConfigurationWithOptions(GetRegionConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["zoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetRegionConfigurationResponse>(DoROARequest("GetRegionConfiguration", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/region", "json", req, runtime));
        }

        public async Task<GetRegionConfigurationResponse> GetRegionConfigurationWithOptionsAsync(GetRegionConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["zoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetRegionConfigurationResponse>(await DoROARequestAsync("GetRegionConfiguration", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/region", "json", req, runtime));
        }

        public GetSuggestShrinkableNodesResponse GetSuggestShrinkableNodes(string InstanceId, GetSuggestShrinkableNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSuggestShrinkableNodesWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<GetSuggestShrinkableNodesResponse> GetSuggestShrinkableNodesAsync(string InstanceId, GetSuggestShrinkableNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSuggestShrinkableNodesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public GetSuggestShrinkableNodesResponse GetSuggestShrinkableNodesWithOptions(string InstanceId, GetSuggestShrinkableNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeType))
            {
                query["nodeType"] = request.NodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreStatus))
            {
                query["ignoreStatus"] = request.IgnoreStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetSuggestShrinkableNodesResponse>(DoROARequest("GetSuggestShrinkableNodes", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/suggest-shrinkable-nodes", "json", req, runtime));
        }

        public async Task<GetSuggestShrinkableNodesResponse> GetSuggestShrinkableNodesWithOptionsAsync(string InstanceId, GetSuggestShrinkableNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeType))
            {
                query["nodeType"] = request.NodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreStatus))
            {
                query["ignoreStatus"] = request.IgnoreStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetSuggestShrinkableNodesResponse>(await DoROARequestAsync("GetSuggestShrinkableNodes", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/suggest-shrinkable-nodes", "json", req, runtime));
        }

        public GetTransferableNodesResponse GetTransferableNodes(string InstanceId, GetTransferableNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTransferableNodesWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<GetTransferableNodesResponse> GetTransferableNodesAsync(string InstanceId, GetTransferableNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTransferableNodesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public GetTransferableNodesResponse GetTransferableNodesWithOptions(string InstanceId, GetTransferableNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeType))
            {
                query["nodeType"] = request.NodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["count"] = request.Count;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetTransferableNodesResponse>(DoROARequest("GetTransferableNodes", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/transferable-nodes", "json", req, runtime));
        }

        public async Task<GetTransferableNodesResponse> GetTransferableNodesWithOptionsAsync(string InstanceId, GetTransferableNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeType))
            {
                query["nodeType"] = request.NodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["count"] = request.Count;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetTransferableNodesResponse>(await DoROARequestAsync("GetTransferableNodes", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/transferable-nodes", "json", req, runtime));
        }

        public InitializeOperationRoleResponse InitializeOperationRole(InitializeOperationRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InitializeOperationRoleWithOptions(request, headers, runtime);
        }

        public async Task<InitializeOperationRoleResponse> InitializeOperationRoleAsync(InitializeOperationRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InitializeOperationRoleWithOptionsAsync(request, headers, runtime);
        }

        public InitializeOperationRoleResponse InitializeOperationRoleWithOptions(InitializeOperationRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InitializeOperationRoleResponse>(DoROARequest("InitializeOperationRole", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/user/slr", "json", req, runtime));
        }

        public async Task<InitializeOperationRoleResponse> InitializeOperationRoleWithOptionsAsync(InitializeOperationRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InitializeOperationRoleResponse>(await DoROARequestAsync("InitializeOperationRole", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/user/slr", "json", req, runtime));
        }

        public InstallAckOperatorResponse InstallAckOperator(string ClusterId, InstallAckOperatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InstallAckOperatorWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<InstallAckOperatorResponse> InstallAckOperatorAsync(string ClusterId, InstallAckOperatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InstallAckOperatorWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public InstallAckOperatorResponse InstallAckOperatorWithOptions(string ClusterId, InstallAckOperatorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InstallAckOperatorResponse>(DoROARequest("InstallAckOperator", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/ack-clusters/" + ClusterId + "/operator", "json", req, runtime));
        }

        public async Task<InstallAckOperatorResponse> InstallAckOperatorWithOptionsAsync(string ClusterId, InstallAckOperatorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InstallAckOperatorResponse>(await DoROARequestAsync("InstallAckOperator", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/ack-clusters/" + ClusterId + "/operator", "json", req, runtime));
        }

        public InstallKibanaSystemPluginResponse InstallKibanaSystemPlugin(string InstanceId, InstallKibanaSystemPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InstallKibanaSystemPluginWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<InstallKibanaSystemPluginResponse> InstallKibanaSystemPluginAsync(string InstanceId, InstallKibanaSystemPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InstallKibanaSystemPluginWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public InstallKibanaSystemPluginResponse InstallKibanaSystemPluginWithOptions(string InstanceId, InstallKibanaSystemPluginRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InstallKibanaSystemPluginResponse>(DoROARequest("InstallKibanaSystemPlugin", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/kibana-plugins/system/actions/install", "json", req, runtime));
        }

        public async Task<InstallKibanaSystemPluginResponse> InstallKibanaSystemPluginWithOptionsAsync(string InstanceId, InstallKibanaSystemPluginRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InstallKibanaSystemPluginResponse>(await DoROARequestAsync("InstallKibanaSystemPlugin", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/kibana-plugins/system/actions/install", "json", req, runtime));
        }

        public InstallLogstashSystemPluginResponse InstallLogstashSystemPlugin(string InstanceId, InstallLogstashSystemPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InstallLogstashSystemPluginWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<InstallLogstashSystemPluginResponse> InstallLogstashSystemPluginAsync(string InstanceId, InstallLogstashSystemPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InstallLogstashSystemPluginWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public InstallLogstashSystemPluginResponse InstallLogstashSystemPluginWithOptions(string InstanceId, InstallLogstashSystemPluginRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InstallLogstashSystemPluginResponse>(DoROARequest("InstallLogstashSystemPlugin", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/plugins/system/actions/install", "json", req, runtime));
        }

        public async Task<InstallLogstashSystemPluginResponse> InstallLogstashSystemPluginWithOptionsAsync(string InstanceId, InstallLogstashSystemPluginRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InstallLogstashSystemPluginResponse>(await DoROARequestAsync("InstallLogstashSystemPlugin", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/plugins/system/actions/install", "json", req, runtime));
        }

        public InstallSystemPluginResponse InstallSystemPlugin(string InstanceId, InstallSystemPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InstallSystemPluginWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<InstallSystemPluginResponse> InstallSystemPluginAsync(string InstanceId, InstallSystemPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InstallSystemPluginWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public InstallSystemPluginResponse InstallSystemPluginWithOptions(string InstanceId, InstallSystemPluginRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InstallSystemPluginResponse>(DoROARequest("InstallSystemPlugin", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/plugins/system/actions/install", "json", req, runtime));
        }

        public async Task<InstallSystemPluginResponse> InstallSystemPluginWithOptionsAsync(string InstanceId, InstallSystemPluginRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InstallSystemPluginResponse>(await DoROARequestAsync("InstallSystemPlugin", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/plugins/system/actions/install", "json", req, runtime));
        }

        public InstallUserPluginsResponse InstallUserPlugins(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InstallUserPluginsWithOptions(InstanceId, headers, runtime);
        }

        public async Task<InstallUserPluginsResponse> InstallUserPluginsAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InstallUserPluginsWithOptionsAsync(InstanceId, headers, runtime);
        }

        public InstallUserPluginsResponse InstallUserPluginsWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<InstallUserPluginsResponse>(DoROARequest("InstallUserPlugins", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/plugins/user/actions/install", "json", req, runtime));
        }

        public async Task<InstallUserPluginsResponse> InstallUserPluginsWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<InstallUserPluginsResponse>(await DoROARequestAsync("InstallUserPlugins", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/plugins/user/actions/install", "json", req, runtime));
        }

        public InterruptElasticsearchTaskResponse InterruptElasticsearchTask(string InstanceId, InterruptElasticsearchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InterruptElasticsearchTaskWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<InterruptElasticsearchTaskResponse> InterruptElasticsearchTaskAsync(string InstanceId, InterruptElasticsearchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InterruptElasticsearchTaskWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public InterruptElasticsearchTaskResponse InterruptElasticsearchTaskWithOptions(string InstanceId, InterruptElasticsearchTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InterruptElasticsearchTaskResponse>(DoROARequest("InterruptElasticsearchTask", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/interrupt", "json", req, runtime));
        }

        public async Task<InterruptElasticsearchTaskResponse> InterruptElasticsearchTaskWithOptionsAsync(string InstanceId, InterruptElasticsearchTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InterruptElasticsearchTaskResponse>(await DoROARequestAsync("InterruptElasticsearchTask", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/interrupt", "json", req, runtime));
        }

        public InterruptLogstashTaskResponse InterruptLogstashTask(string InstanceId, InterruptLogstashTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InterruptLogstashTaskWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<InterruptLogstashTaskResponse> InterruptLogstashTaskAsync(string InstanceId, InterruptLogstashTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InterruptLogstashTaskWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public InterruptLogstashTaskResponse InterruptLogstashTaskWithOptions(string InstanceId, InterruptLogstashTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InterruptLogstashTaskResponse>(DoROARequest("InterruptLogstashTask", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/actions/interrupt", "json", req, runtime));
        }

        public async Task<InterruptLogstashTaskResponse> InterruptLogstashTaskWithOptionsAsync(string InstanceId, InterruptLogstashTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<InterruptLogstashTaskResponse>(await DoROARequestAsync("InterruptLogstashTask", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/actions/interrupt", "json", req, runtime));
        }

        public ListAckClustersResponse ListAckClusters(ListAckClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAckClustersWithOptions(request, headers, runtime);
        }

        public async Task<ListAckClustersResponse> ListAckClustersAsync(ListAckClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAckClustersWithOptionsAsync(request, headers, runtime);
        }

        public ListAckClustersResponse ListAckClustersWithOptions(ListAckClustersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["vpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListAckClustersResponse>(DoROARequest("ListAckClusters", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/ack-clusters", "json", req, runtime));
        }

        public async Task<ListAckClustersResponse> ListAckClustersWithOptionsAsync(ListAckClustersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["vpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListAckClustersResponse>(await DoROARequestAsync("ListAckClusters", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/ack-clusters", "json", req, runtime));
        }

        public ListAckNamespacesResponse ListAckNamespaces(string ClusterId, ListAckNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAckNamespacesWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<ListAckNamespacesResponse> ListAckNamespacesAsync(string ClusterId, ListAckNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAckNamespacesWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public ListAckNamespacesResponse ListAckNamespacesWithOptions(string ClusterId, ListAckNamespacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListAckNamespacesResponse>(DoROARequest("ListAckNamespaces", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/ack-clusters/" + ClusterId + "/namespaces", "json", req, runtime));
        }

        public async Task<ListAckNamespacesResponse> ListAckNamespacesWithOptionsAsync(string ClusterId, ListAckNamespacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListAckNamespacesResponse>(await DoROARequestAsync("ListAckNamespaces", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/ack-clusters/" + ClusterId + "/namespaces", "json", req, runtime));
        }

        public ListAllNodeResponse ListAllNode(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAllNodeWithOptions(InstanceId, headers, runtime);
        }

        public async Task<ListAllNodeResponse> ListAllNodeAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAllNodeWithOptionsAsync(InstanceId, headers, runtime);
        }

        public ListAllNodeResponse ListAllNodeWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListAllNodeResponse>(DoROARequest("ListAllNode", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/nodes", "json", req, runtime));
        }

        public async Task<ListAllNodeResponse> ListAllNodeWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListAllNodeResponse>(await DoROARequestAsync("ListAllNode", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/nodes", "json", req, runtime));
        }

        public ListAlternativeSnapshotReposResponse ListAlternativeSnapshotRepos(string InstanceId, ListAlternativeSnapshotReposRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAlternativeSnapshotReposWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListAlternativeSnapshotReposResponse> ListAlternativeSnapshotReposAsync(string InstanceId, ListAlternativeSnapshotReposRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAlternativeSnapshotReposWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListAlternativeSnapshotReposResponse ListAlternativeSnapshotReposWithOptions(string InstanceId, ListAlternativeSnapshotReposRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlreadySetItems))
            {
                query["alreadySetItems"] = request.AlreadySetItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListAlternativeSnapshotReposResponse>(DoROARequest("ListAlternativeSnapshotRepos", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/alternative-snapshot-repos", "json", req, runtime));
        }

        public async Task<ListAlternativeSnapshotReposResponse> ListAlternativeSnapshotReposWithOptionsAsync(string InstanceId, ListAlternativeSnapshotReposRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlreadySetItems))
            {
                query["alreadySetItems"] = request.AlreadySetItems;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListAlternativeSnapshotReposResponse>(await DoROARequestAsync("ListAlternativeSnapshotRepos", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/alternative-snapshot-repos", "json", req, runtime));
        }

        public ListAvailableEsInstanceIdsResponse ListAvailableEsInstanceIds(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAvailableEsInstanceIdsWithOptions(InstanceId, headers, runtime);
        }

        public async Task<ListAvailableEsInstanceIdsResponse> ListAvailableEsInstanceIdsAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAvailableEsInstanceIdsWithOptionsAsync(InstanceId, headers, runtime);
        }

        public ListAvailableEsInstanceIdsResponse ListAvailableEsInstanceIdsWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListAvailableEsInstanceIdsResponse>(DoROARequest("ListAvailableEsInstanceIds", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/logstashes/" + InstanceId + "/available-elasticsearch-for-centralized-management", "json", req, runtime));
        }

        public async Task<ListAvailableEsInstanceIdsResponse> ListAvailableEsInstanceIdsWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListAvailableEsInstanceIdsResponse>(await DoROARequestAsync("ListAvailableEsInstanceIds", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/logstashes/" + InstanceId + "/available-elasticsearch-for-centralized-management", "json", req, runtime));
        }

        public ListCollectorsResponse ListCollectors(ListCollectorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCollectorsWithOptions(request, headers, runtime);
        }

        public async Task<ListCollectorsResponse> ListCollectorsAsync(ListCollectorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCollectorsWithOptionsAsync(request, headers, runtime);
        }

        public ListCollectorsResponse ListCollectorsWithOptions(ListCollectorsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResId))
            {
                query["resId"] = request.ResId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["sourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListCollectorsResponse>(DoROARequest("ListCollectors", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/collectors", "json", req, runtime));
        }

        public async Task<ListCollectorsResponse> ListCollectorsWithOptionsAsync(ListCollectorsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResId))
            {
                query["resId"] = request.ResId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["sourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListCollectorsResponse>(await DoROARequestAsync("ListCollectors", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/collectors", "json", req, runtime));
        }

        public ListConnectedClustersResponse ListConnectedClusters(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConnectedClustersWithOptions(InstanceId, headers, runtime);
        }

        public async Task<ListConnectedClustersResponse> ListConnectedClustersAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConnectedClustersWithOptionsAsync(InstanceId, headers, runtime);
        }

        public ListConnectedClustersResponse ListConnectedClustersWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListConnectedClustersResponse>(DoROARequest("ListConnectedClusters", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/connected-clusters", "json", req, runtime));
        }

        public async Task<ListConnectedClustersResponse> ListConnectedClustersWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListConnectedClustersResponse>(await DoROARequestAsync("ListConnectedClusters", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/connected-clusters", "json", req, runtime));
        }

        public ListDataStreamsResponse ListDataStreams(string InstanceId, ListDataStreamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataStreamsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListDataStreamsResponse> ListDataStreamsAsync(string InstanceId, ListDataStreamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataStreamsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListDataStreamsResponse ListDataStreamsWithOptions(string InstanceId, ListDataStreamsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsManaged))
            {
                query["isManaged"] = request.IsManaged;
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
            return TeaModel.ToObject<ListDataStreamsResponse>(DoROARequest("ListDataStreams", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/data-streams", "json", req, runtime));
        }

        public async Task<ListDataStreamsResponse> ListDataStreamsWithOptionsAsync(string InstanceId, ListDataStreamsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsManaged))
            {
                query["isManaged"] = request.IsManaged;
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
            return TeaModel.ToObject<ListDataStreamsResponse>(await DoROARequestAsync("ListDataStreams", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/data-streams", "json", req, runtime));
        }

        public ListDataTasksResponse ListDataTasks(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataTasksWithOptions(InstanceId, headers, runtime);
        }

        public async Task<ListDataTasksResponse> ListDataTasksAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataTasksWithOptionsAsync(InstanceId, headers, runtime);
        }

        public ListDataTasksResponse ListDataTasksWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListDataTasksResponse>(DoROARequest("ListDataTasks", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/data-task", "json", req, runtime));
        }

        public async Task<ListDataTasksResponse> ListDataTasksWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListDataTasksResponse>(await DoROARequestAsync("ListDataTasks", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/data-task", "json", req, runtime));
        }

        public ListDefaultCollectorConfigurationsResponse ListDefaultCollectorConfigurations(ListDefaultCollectorConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDefaultCollectorConfigurationsWithOptions(request, headers, runtime);
        }

        public async Task<ListDefaultCollectorConfigurationsResponse> ListDefaultCollectorConfigurationsAsync(ListDefaultCollectorConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDefaultCollectorConfigurationsWithOptionsAsync(request, headers, runtime);
        }

        public ListDefaultCollectorConfigurationsResponse ListDefaultCollectorConfigurationsWithOptions(ListDefaultCollectorConfigurationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResType))
            {
                query["resType"] = request.ResType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResVersion))
            {
                query["resVersion"] = request.ResVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["sourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListDefaultCollectorConfigurationsResponse>(DoROARequest("ListDefaultCollectorConfigurations", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/beats/default-configurations", "json", req, runtime));
        }

        public async Task<ListDefaultCollectorConfigurationsResponse> ListDefaultCollectorConfigurationsWithOptionsAsync(ListDefaultCollectorConfigurationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResType))
            {
                query["resType"] = request.ResType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResVersion))
            {
                query["resVersion"] = request.ResVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["sourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListDefaultCollectorConfigurationsResponse>(await DoROARequestAsync("ListDefaultCollectorConfigurations", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/beats/default-configurations", "json", req, runtime));
        }

        public ListDiagnoseIndicesResponse ListDiagnoseIndices(string InstanceId, ListDiagnoseIndicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDiagnoseIndicesWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListDiagnoseIndicesResponse> ListDiagnoseIndicesAsync(string InstanceId, ListDiagnoseIndicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDiagnoseIndicesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListDiagnoseIndicesResponse ListDiagnoseIndicesWithOptions(string InstanceId, ListDiagnoseIndicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListDiagnoseIndicesResponse>(DoROARequest("ListDiagnoseIndices", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/diagnosis/instances/" + InstanceId + "/indices", "json", req, runtime));
        }

        public async Task<ListDiagnoseIndicesResponse> ListDiagnoseIndicesWithOptionsAsync(string InstanceId, ListDiagnoseIndicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListDiagnoseIndicesResponse>(await DoROARequestAsync("ListDiagnoseIndices", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/diagnosis/instances/" + InstanceId + "/indices", "json", req, runtime));
        }

        public ListDiagnoseReportResponse ListDiagnoseReport(string InstanceId, ListDiagnoseReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDiagnoseReportWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListDiagnoseReportResponse> ListDiagnoseReportAsync(string InstanceId, ListDiagnoseReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDiagnoseReportWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListDiagnoseReportResponse ListDiagnoseReportWithOptions(string InstanceId, ListDiagnoseReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                query["detail"] = request.Detail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Trigger))
            {
                query["trigger"] = request.Trigger;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListDiagnoseReportResponse>(DoROARequest("ListDiagnoseReport", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/diagnosis/instances/" + InstanceId + "/reports", "json", req, runtime));
        }

        public async Task<ListDiagnoseReportResponse> ListDiagnoseReportWithOptionsAsync(string InstanceId, ListDiagnoseReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                query["detail"] = request.Detail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Trigger))
            {
                query["trigger"] = request.Trigger;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListDiagnoseReportResponse>(await DoROARequestAsync("ListDiagnoseReport", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/diagnosis/instances/" + InstanceId + "/reports", "json", req, runtime));
        }

        public ListDiagnoseReportIdsResponse ListDiagnoseReportIds(string InstanceId, ListDiagnoseReportIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDiagnoseReportIdsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListDiagnoseReportIdsResponse> ListDiagnoseReportIdsAsync(string InstanceId, ListDiagnoseReportIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDiagnoseReportIdsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListDiagnoseReportIdsResponse ListDiagnoseReportIdsWithOptions(string InstanceId, ListDiagnoseReportIdsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Trigger))
            {
                query["trigger"] = request.Trigger;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListDiagnoseReportIdsResponse>(DoROARequest("ListDiagnoseReportIds", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/diagnosis/instances/" + InstanceId + "/report-ids", "json", req, runtime));
        }

        public async Task<ListDiagnoseReportIdsResponse> ListDiagnoseReportIdsWithOptionsAsync(string InstanceId, ListDiagnoseReportIdsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Trigger))
            {
                query["trigger"] = request.Trigger;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListDiagnoseReportIdsResponse>(await DoROARequestAsync("ListDiagnoseReportIds", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/diagnosis/instances/" + InstanceId + "/report-ids", "json", req, runtime));
        }

        public ListDictInformationResponse ListDictInformation(string InstanceId, ListDictInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDictInformationWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListDictInformationResponse> ListDictInformationAsync(string InstanceId, ListDictInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDictInformationWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListDictInformationResponse ListDictInformationWithOptions(string InstanceId, ListDictInformationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                query["bucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnalyzerType))
            {
                query["analyzerType"] = request.AnalyzerType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListDictInformationResponse>(DoROARequest("ListDictInformation", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dict/_info", "json", req, runtime));
        }

        public async Task<ListDictInformationResponse> ListDictInformationWithOptionsAsync(string InstanceId, ListDictInformationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BucketName))
            {
                query["bucketName"] = request.BucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnalyzerType))
            {
                query["analyzerType"] = request.AnalyzerType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListDictInformationResponse>(await DoROARequestAsync("ListDictInformation", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dict/_info", "json", req, runtime));
        }

        public ListDictsResponse ListDicts(string InstanceId, ListDictsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDictsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListDictsResponse> ListDictsAsync(string InstanceId, ListDictsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDictsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListDictsResponse ListDictsWithOptions(string InstanceId, ListDictsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnalyzerType))
            {
                query["analyzerType"] = request.AnalyzerType;
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
            return TeaModel.ToObject<ListDictsResponse>(DoROARequest("ListDicts", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dicts", "json", req, runtime));
        }

        public async Task<ListDictsResponse> ListDictsWithOptionsAsync(string InstanceId, ListDictsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnalyzerType))
            {
                query["analyzerType"] = request.AnalyzerType;
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
            return TeaModel.ToObject<ListDictsResponse>(await DoROARequestAsync("ListDicts", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/dicts", "json", req, runtime));
        }

        public ListEcsInstancesResponse ListEcsInstances(ListEcsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEcsInstancesWithOptions(request, headers, runtime);
        }

        public async Task<ListEcsInstancesResponse> ListEcsInstancesAsync(ListEcsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEcsInstancesWithOptionsAsync(request, headers, runtime);
        }

        public ListEcsInstancesResponse ListEcsInstancesWithOptions(ListEcsInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceIds))
            {
                query["ecsInstanceIds"] = request.EcsInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceName))
            {
                query["ecsInstanceName"] = request.EcsInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["vpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListEcsInstancesResponse>(DoROARequest("ListEcsInstances", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/ecs", "json", req, runtime));
        }

        public async Task<ListEcsInstancesResponse> ListEcsInstancesWithOptionsAsync(ListEcsInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceIds))
            {
                query["ecsInstanceIds"] = request.EcsInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceName))
            {
                query["ecsInstanceName"] = request.EcsInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["vpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListEcsInstancesResponse>(await DoROARequestAsync("ListEcsInstances", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/ecs", "json", req, runtime));
        }

        public ListExtendfilesResponse ListExtendfiles(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListExtendfilesWithOptions(InstanceId, headers, runtime);
        }

        public async Task<ListExtendfilesResponse> ListExtendfilesAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListExtendfilesWithOptionsAsync(InstanceId, headers, runtime);
        }

        public ListExtendfilesResponse ListExtendfilesWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListExtendfilesResponse>(DoROARequest("ListExtendfiles", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/logstashes/" + InstanceId + "/extendfiles", "json", req, runtime));
        }

        public async Task<ListExtendfilesResponse> ListExtendfilesWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListExtendfilesResponse>(await DoROARequestAsync("ListExtendfiles", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/logstashes/" + InstanceId + "/extendfiles", "json", req, runtime));
        }

        public ListILMPoliciesResponse ListILMPolicies(string InstanceId, ListILMPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListILMPoliciesWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListILMPoliciesResponse> ListILMPoliciesAsync(string InstanceId, ListILMPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListILMPoliciesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListILMPoliciesResponse ListILMPoliciesWithOptions(string InstanceId, ListILMPoliciesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["policyName"] = request.PolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListILMPoliciesResponse>(DoROARequest("ListILMPolicies", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/ilm-policies", "json", req, runtime));
        }

        public async Task<ListILMPoliciesResponse> ListILMPoliciesWithOptionsAsync(string InstanceId, ListILMPoliciesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["policyName"] = request.PolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListILMPoliciesResponse>(await DoROARequestAsync("ListILMPolicies", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/ilm-policies", "json", req, runtime));
        }

        public ListIndexTemplatesResponse ListIndexTemplates(string InstanceId, ListIndexTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIndexTemplatesWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListIndexTemplatesResponse> ListIndexTemplatesAsync(string InstanceId, ListIndexTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIndexTemplatesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListIndexTemplatesResponse ListIndexTemplatesWithOptions(string InstanceId, ListIndexTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexTemplate))
            {
                query["indexTemplate"] = request.IndexTemplate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListIndexTemplatesResponse>(DoROARequest("ListIndexTemplates", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/index-templates", "json", req, runtime));
        }

        public async Task<ListIndexTemplatesResponse> ListIndexTemplatesWithOptionsAsync(string InstanceId, ListIndexTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IndexTemplate))
            {
                query["indexTemplate"] = request.IndexTemplate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListIndexTemplatesResponse>(await DoROARequestAsync("ListIndexTemplates", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/index-templates", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EsVersion))
            {
                query["esVersion"] = request.EsVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["vpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["zoneId"] = request.ZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["paymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceCategory))
            {
                query["instanceCategory"] = request.InstanceCategory;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListInstanceResponse>(DoROARequest("ListInstance", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EsVersion))
            {
                query["esVersion"] = request.EsVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["vpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["zoneId"] = request.ZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["paymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceCategory))
            {
                query["instanceCategory"] = request.InstanceCategory;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListInstanceResponse>(await DoROARequestAsync("ListInstance", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances", "json", req, runtime));
        }

        public ListInstanceIndicesResponse ListInstanceIndices(string InstanceId, ListInstanceIndicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstanceIndicesWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListInstanceIndicesResponse> ListInstanceIndicesAsync(string InstanceId, ListInstanceIndicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstanceIndicesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListInstanceIndicesResponse ListInstanceIndicesWithOptions(string InstanceId, ListInstanceIndicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["all"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsManaged))
            {
                query["isManaged"] = request.IsManaged;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListInstanceIndicesResponse>(DoROARequest("ListInstanceIndices", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/indices", "json", req, runtime));
        }

        public async Task<ListInstanceIndicesResponse> ListInstanceIndicesWithOptionsAsync(string InstanceId, ListInstanceIndicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["all"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsManaged))
            {
                query["isManaged"] = request.IsManaged;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListInstanceIndicesResponse>(await DoROARequestAsync("ListInstanceIndices", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/indices", "json", req, runtime));
        }

        public ListKibanaPluginsResponse ListKibanaPlugins(string InstanceId, ListKibanaPluginsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListKibanaPluginsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListKibanaPluginsResponse> ListKibanaPluginsAsync(string InstanceId, ListKibanaPluginsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListKibanaPluginsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListKibanaPluginsResponse ListKibanaPluginsWithOptions(string InstanceId, ListKibanaPluginsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListKibanaPluginsResponse>(DoROARequest("ListKibanaPlugins", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/kibana-plugins", "json", req, runtime));
        }

        public async Task<ListKibanaPluginsResponse> ListKibanaPluginsWithOptionsAsync(string InstanceId, ListKibanaPluginsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListKibanaPluginsResponse>(await DoROARequestAsync("ListKibanaPlugins", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/kibana-plugins", "json", req, runtime));
        }

        public ListLogstashResponse ListLogstash(ListLogstashRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLogstashWithOptions(request, headers, runtime);
        }

        public async Task<ListLogstashResponse> ListLogstashAsync(ListLogstashRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLogstashWithOptionsAsync(request, headers, runtime);
        }

        public ListLogstashResponse ListLogstashWithOptions(ListLogstashRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["ownerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListLogstashResponse>(DoROARequest("ListLogstash", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/logstashes", "json", req, runtime));
        }

        public async Task<ListLogstashResponse> ListLogstashWithOptionsAsync(ListLogstashRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["ownerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListLogstashResponse>(await DoROARequestAsync("ListLogstash", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/logstashes", "json", req, runtime));
        }

        public ListLogstashLogResponse ListLogstashLog(string InstanceId, ListLogstashLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLogstashLogWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListLogstashLogResponse> ListLogstashLogAsync(string InstanceId, ListLogstashLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLogstashLogWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListLogstashLogResponse ListLogstashLogWithOptions(string InstanceId, ListLogstashLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["beginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListLogstashLogResponse>(DoROARequest("ListLogstashLog", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/logstashes/" + InstanceId + "/search-log", "json", req, runtime));
        }

        public async Task<ListLogstashLogResponse> ListLogstashLogWithOptionsAsync(string InstanceId, ListLogstashLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["beginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListLogstashLogResponse>(await DoROARequestAsync("ListLogstashLog", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/logstashes/" + InstanceId + "/search-log", "json", req, runtime));
        }

        public ListLogstashPluginsResponse ListLogstashPlugins(string InstanceId, ListLogstashPluginsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLogstashPluginsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListLogstashPluginsResponse> ListLogstashPluginsAsync(string InstanceId, ListLogstashPluginsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLogstashPluginsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListLogstashPluginsResponse ListLogstashPluginsWithOptions(string InstanceId, ListLogstashPluginsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListLogstashPluginsResponse>(DoROARequest("ListLogstashPlugins", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/logstashes/" + InstanceId + "/plugins", "json", req, runtime));
        }

        public async Task<ListLogstashPluginsResponse> ListLogstashPluginsWithOptionsAsync(string InstanceId, ListLogstashPluginsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListLogstashPluginsResponse>(await DoROARequestAsync("ListLogstashPlugins", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/logstashes/" + InstanceId + "/plugins", "json", req, runtime));
        }

        public ListNodesResponse ListNodes(string ResId, ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListNodesWithOptions(ResId, request, headers, runtime);
        }

        public async Task<ListNodesResponse> ListNodesAsync(string ResId, ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListNodesWithOptionsAsync(ResId, request, headers, runtime);
        }

        public ListNodesResponse ListNodesWithOptions(string ResId, ListNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ResId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceIds))
            {
                query["ecsInstanceIds"] = request.EcsInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceName))
            {
                query["ecsInstanceName"] = request.EcsInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListNodesResponse>(DoROARequest("ListNodes", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/collectors/" + ResId + "/nodes", "json", req, runtime));
        }

        public async Task<ListNodesResponse> ListNodesWithOptionsAsync(string ResId, ListNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ResId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceIds))
            {
                query["ecsInstanceIds"] = request.EcsInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceName))
            {
                query["ecsInstanceName"] = request.EcsInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListNodesResponse>(await DoROARequestAsync("ListNodes", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/collectors/" + ResId + "/nodes", "json", req, runtime));
        }

        public ListPipelineResponse ListPipeline(string InstanceId, ListPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPipelineWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListPipelineResponse> ListPipelineAsync(string InstanceId, ListPipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPipelineWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListPipelineResponse ListPipelineWithOptions(string InstanceId, ListPipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["pipelineId"] = request.PipelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListPipelineResponse>(DoROARequest("ListPipeline", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/logstashes/" + InstanceId + "/pipelines", "json", req, runtime));
        }

        public async Task<ListPipelineResponse> ListPipelineWithOptionsAsync(string InstanceId, ListPipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["pipelineId"] = request.PipelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListPipelineResponse>(await DoROARequestAsync("ListPipeline", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/logstashes/" + InstanceId + "/pipelines", "json", req, runtime));
        }

        public ListPipelineIdsResponse ListPipelineIds(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPipelineIdsWithOptions(InstanceId, headers, runtime);
        }

        public async Task<ListPipelineIdsResponse> ListPipelineIdsAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPipelineIdsWithOptionsAsync(InstanceId, headers, runtime);
        }

        public ListPipelineIdsResponse ListPipelineIdsWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListPipelineIdsResponse>(DoROARequest("ListPipelineIds", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/pipeline-ids", "json", req, runtime));
        }

        public async Task<ListPipelineIdsResponse> ListPipelineIdsWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListPipelineIdsResponse>(await DoROARequestAsync("ListPipelineIds", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/pipeline-ids", "json", req, runtime));
        }

        public ListPluginsResponse ListPlugins(string InstanceId, ListPluginsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPluginsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListPluginsResponse> ListPluginsAsync(string InstanceId, ListPluginsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPluginsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListPluginsResponse ListPluginsWithOptions(string InstanceId, ListPluginsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListPluginsResponse>(DoROARequest("ListPlugins", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/plugins", "json", req, runtime));
        }

        public async Task<ListPluginsResponse> ListPluginsWithOptionsAsync(string InstanceId, ListPluginsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListPluginsResponse>(await DoROARequestAsync("ListPlugins", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/plugins", "json", req, runtime));
        }

        public ListSearchLogResponse ListSearchLog(string InstanceId, ListSearchLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSearchLogWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListSearchLogResponse> ListSearchLogAsync(string InstanceId, ListSearchLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSearchLogWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListSearchLogResponse ListSearchLogWithOptions(string InstanceId, ListSearchLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["beginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListSearchLogResponse>(DoROARequest("ListSearchLog", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/search-log", "json", req, runtime));
        }

        public async Task<ListSearchLogResponse> ListSearchLogWithOptionsAsync(string InstanceId, ListSearchLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["beginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListSearchLogResponse>(await DoROARequestAsync("ListSearchLog", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/search-log", "json", req, runtime));
        }

        public ListShardRecoveriesResponse ListShardRecoveries(string InstanceId, ListShardRecoveriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListShardRecoveriesWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListShardRecoveriesResponse> ListShardRecoveriesAsync(string InstanceId, ListShardRecoveriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListShardRecoveriesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListShardRecoveriesResponse ListShardRecoveriesWithOptions(string InstanceId, ListShardRecoveriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveOnly))
            {
                query["activeOnly"] = request.ActiveOnly;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListShardRecoveriesResponse>(DoROARequest("ListShardRecoveries", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/cat-recovery", "json", req, runtime));
        }

        public async Task<ListShardRecoveriesResponse> ListShardRecoveriesWithOptionsAsync(string InstanceId, ListShardRecoveriesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveOnly))
            {
                query["activeOnly"] = request.ActiveOnly;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListShardRecoveriesResponse>(await DoROARequestAsync("ListShardRecoveries", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/cat-recovery", "json", req, runtime));
        }

        public ListSnapshotReposByInstanceIdResponse ListSnapshotReposByInstanceId(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSnapshotReposByInstanceIdWithOptions(InstanceId, headers, runtime);
        }

        public async Task<ListSnapshotReposByInstanceIdResponse> ListSnapshotReposByInstanceIdAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSnapshotReposByInstanceIdWithOptionsAsync(InstanceId, headers, runtime);
        }

        public ListSnapshotReposByInstanceIdResponse ListSnapshotReposByInstanceIdWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListSnapshotReposByInstanceIdResponse>(DoROARequest("ListSnapshotReposByInstanceId", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/snapshot-repos", "json", req, runtime));
        }

        public async Task<ListSnapshotReposByInstanceIdResponse> ListSnapshotReposByInstanceIdWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ListSnapshotReposByInstanceIdResponse>(await DoROARequestAsync("ListSnapshotReposByInstanceId", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/snapshot-repos", "json", req, runtime));
        }

        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTagResourcesWithOptions(request, headers, runtime);
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTagResourcesWithOptionsAsync(request, headers, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoROARequest("ListTagResources", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/tags", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoROARequestAsync("ListTagResources", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/tags", "json", req, runtime));
        }

        public ListTagsResponse ListTags(ListTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTagsWithOptions(request, headers, runtime);
        }

        public async Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTagsWithOptionsAsync(request, headers, runtime);
        }

        public ListTagsResponse ListTagsWithOptions(ListTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListTagsResponse>(DoROARequest("ListTags", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/tags/all-tags", "json", req, runtime));
        }

        public async Task<ListTagsResponse> ListTagsWithOptionsAsync(ListTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListTagsResponse>(await DoROARequestAsync("ListTags", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/tags/all-tags", "json", req, runtime));
        }

        public ListVpcEndpointsResponse ListVpcEndpoints(string InstanceId, ListVpcEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListVpcEndpointsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ListVpcEndpointsResponse> ListVpcEndpointsAsync(string InstanceId, ListVpcEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListVpcEndpointsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ListVpcEndpointsResponse ListVpcEndpointsWithOptions(string InstanceId, ListVpcEndpointsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListVpcEndpointsResponse>(DoROARequest("ListVpcEndpoints", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/vpc-endpoints", "json", req, runtime));
        }

        public async Task<ListVpcEndpointsResponse> ListVpcEndpointsWithOptionsAsync(string InstanceId, ListVpcEndpointsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["page"] = request.Page;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListVpcEndpointsResponse>(await DoROARequestAsync("ListVpcEndpoints", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/vpc-endpoints", "json", req, runtime));
        }

        public MigrateToOtherZoneResponse MigrateToOtherZone(string InstanceId, MigrateToOtherZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return MigrateToOtherZoneWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<MigrateToOtherZoneResponse> MigrateToOtherZoneAsync(string InstanceId, MigrateToOtherZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await MigrateToOtherZoneWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public MigrateToOtherZoneResponse MigrateToOtherZoneWithOptions(string InstanceId, MigrateToOtherZoneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<MigrateToOtherZoneResponse>(DoROARequest("MigrateToOtherZone", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/migrate-zones", "json", req, runtime));
        }

        public async Task<MigrateToOtherZoneResponse> MigrateToOtherZoneWithOptionsAsync(string InstanceId, MigrateToOtherZoneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<MigrateToOtherZoneResponse>(await DoROARequestAsync("MigrateToOtherZone", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/migrate-zones", "json", req, runtime));
        }

        public ModifyDeployMachineResponse ModifyDeployMachine(string ResId, ModifyDeployMachineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyDeployMachineWithOptions(ResId, request, headers, runtime);
        }

        public async Task<ModifyDeployMachineResponse> ModifyDeployMachineAsync(string ResId, ModifyDeployMachineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyDeployMachineWithOptionsAsync(ResId, request, headers, runtime);
        }

        public ModifyDeployMachineResponse ModifyDeployMachineWithOptions(string ResId, ModifyDeployMachineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ResId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ModifyDeployMachineResponse>(DoROARequest("ModifyDeployMachine", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/collectors/" + ResId + "/actions/modify-deploy-machines", "json", req, runtime));
        }

        public async Task<ModifyDeployMachineResponse> ModifyDeployMachineWithOptionsAsync(string ResId, ModifyDeployMachineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ResId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ModifyDeployMachineResponse>(await DoROARequestAsync("ModifyDeployMachine", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/collectors/" + ResId + "/actions/modify-deploy-machines", "json", req, runtime));
        }

        public ModifyElastictaskResponse ModifyElastictask(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyElastictaskWithOptions(InstanceId, headers, runtime);
        }

        public async Task<ModifyElastictaskResponse> ModifyElastictaskAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyElastictaskWithOptionsAsync(InstanceId, headers, runtime);
        }

        public ModifyElastictaskResponse ModifyElastictaskWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ModifyElastictaskResponse>(DoROARequest("ModifyElastictask", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/elastic-task", "json", req, runtime));
        }

        public async Task<ModifyElastictaskResponse> ModifyElastictaskWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ModifyElastictaskResponse>(await DoROARequestAsync("ModifyElastictask", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/elastic-task", "json", req, runtime));
        }

        public ModifyInstanceMaintainTimeResponse ModifyInstanceMaintainTime(string InstanceId, ModifyInstanceMaintainTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyInstanceMaintainTimeWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ModifyInstanceMaintainTimeResponse> ModifyInstanceMaintainTimeAsync(string InstanceId, ModifyInstanceMaintainTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyInstanceMaintainTimeWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ModifyInstanceMaintainTimeResponse ModifyInstanceMaintainTimeWithOptions(string InstanceId, ModifyInstanceMaintainTimeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ModifyInstanceMaintainTimeResponse>(DoROARequest("ModifyInstanceMaintainTime", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/modify-maintaintime", "json", req, runtime));
        }

        public async Task<ModifyInstanceMaintainTimeResponse> ModifyInstanceMaintainTimeWithOptionsAsync(string InstanceId, ModifyInstanceMaintainTimeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ModifyInstanceMaintainTimeResponse>(await DoROARequestAsync("ModifyInstanceMaintainTime", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/modify-maintaintime", "json", req, runtime));
        }

        public ModifyWhiteIpsResponse ModifyWhiteIps(string InstanceId, ModifyWhiteIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyWhiteIpsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ModifyWhiteIpsResponse> ModifyWhiteIpsAsync(string InstanceId, ModifyWhiteIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyWhiteIpsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ModifyWhiteIpsResponse ModifyWhiteIpsWithOptions(string InstanceId, ModifyWhiteIpsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeType))
            {
                body["nodeType"] = request.NodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                body["networkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMode))
            {
                body["modifyMode"] = request.ModifyMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteIpList))
            {
                body["whiteIpList"] = request.WhiteIpList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteIpGroup.ToMap()))
            {
                body["whiteIpGroup"] = request.WhiteIpGroup;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ModifyWhiteIpsResponse>(DoROARequestWithForm("ModifyWhiteIps", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/modify-white-ips", "json", req, runtime));
        }

        public async Task<ModifyWhiteIpsResponse> ModifyWhiteIpsWithOptionsAsync(string InstanceId, ModifyWhiteIpsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeType))
            {
                body["nodeType"] = request.NodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                body["networkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMode))
            {
                body["modifyMode"] = request.ModifyMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteIpList))
            {
                body["whiteIpList"] = request.WhiteIpList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteIpGroup.ToMap()))
            {
                body["whiteIpGroup"] = request.WhiteIpGroup;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ModifyWhiteIpsResponse>(await DoROARequestWithFormAsync("ModifyWhiteIps", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/modify-white-ips", "json", req, runtime));
        }

        public MoveResourceGroupResponse MoveResourceGroup(string InstanceId, MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return MoveResourceGroupWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<MoveResourceGroupResponse> MoveResourceGroupAsync(string InstanceId, MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await MoveResourceGroupWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public MoveResourceGroupResponse MoveResourceGroupWithOptions(string InstanceId, MoveResourceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(DoROARequest("MoveResourceGroup", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/resourcegroup", "json", req, runtime));
        }

        public async Task<MoveResourceGroupResponse> MoveResourceGroupWithOptionsAsync(string InstanceId, MoveResourceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(await DoROARequestAsync("MoveResourceGroup", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/resourcegroup", "json", req, runtime));
        }

        public OpenDiagnosisResponse OpenDiagnosis(string InstanceId, OpenDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OpenDiagnosisWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<OpenDiagnosisResponse> OpenDiagnosisAsync(string InstanceId, OpenDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OpenDiagnosisWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public OpenDiagnosisResponse OpenDiagnosisWithOptions(string InstanceId, OpenDiagnosisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<OpenDiagnosisResponse>(DoROARequest("OpenDiagnosis", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/diagnosis/instances/" + InstanceId + "/actions/open-diagnosis", "json", req, runtime));
        }

        public async Task<OpenDiagnosisResponse> OpenDiagnosisWithOptionsAsync(string InstanceId, OpenDiagnosisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<OpenDiagnosisResponse>(await DoROARequestAsync("OpenDiagnosis", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/diagnosis/instances/" + InstanceId + "/actions/open-diagnosis", "json", req, runtime));
        }

        public OpenHttpsResponse OpenHttps(string InstanceId, OpenHttpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OpenHttpsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<OpenHttpsResponse> OpenHttpsAsync(string InstanceId, OpenHttpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OpenHttpsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public OpenHttpsResponse OpenHttpsWithOptions(string InstanceId, OpenHttpsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<OpenHttpsResponse>(DoROARequest("OpenHttps", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/open-https", "json", req, runtime));
        }

        public async Task<OpenHttpsResponse> OpenHttpsWithOptionsAsync(string InstanceId, OpenHttpsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<OpenHttpsResponse>(await DoROARequestAsync("OpenHttps", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/open-https", "json", req, runtime));
        }

        public PostEmonTryAlarmRuleResponse PostEmonTryAlarmRule(string ProjectId, string AlarmGroupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PostEmonTryAlarmRuleWithOptions(ProjectId, AlarmGroupId, headers, runtime);
        }

        public async Task<PostEmonTryAlarmRuleResponse> PostEmonTryAlarmRuleAsync(string ProjectId, string AlarmGroupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PostEmonTryAlarmRuleWithOptionsAsync(ProjectId, AlarmGroupId, headers, runtime);
        }

        public PostEmonTryAlarmRuleResponse PostEmonTryAlarmRuleWithOptions(string ProjectId, string AlarmGroupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ProjectId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId);
            AlarmGroupId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlarmGroupId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<PostEmonTryAlarmRuleResponse>(DoROARequest("PostEmonTryAlarmRule", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/emon/projects/" + ProjectId + "/alarm-groups/" + AlarmGroupId + "/alarm-rules/_test", "json", req, runtime));
        }

        public async Task<PostEmonTryAlarmRuleResponse> PostEmonTryAlarmRuleWithOptionsAsync(string ProjectId, string AlarmGroupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ProjectId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ProjectId);
            AlarmGroupId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AlarmGroupId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<PostEmonTryAlarmRuleResponse>(await DoROARequestAsync("PostEmonTryAlarmRule", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/emon/projects/" + ProjectId + "/alarm-groups/" + AlarmGroupId + "/alarm-rules/_test", "json", req, runtime));
        }

        public RecommendTemplatesResponse RecommendTemplates(string InstanceId, RecommendTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RecommendTemplatesWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<RecommendTemplatesResponse> RecommendTemplatesAsync(string InstanceId, RecommendTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RecommendTemplatesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public RecommendTemplatesResponse RecommendTemplatesWithOptions(string InstanceId, RecommendTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsageScenario))
            {
                query["usageScenario"] = request.UsageScenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<RecommendTemplatesResponse>(DoROARequest("RecommendTemplates", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/recommended-templates", "json", req, runtime));
        }

        public async Task<RecommendTemplatesResponse> RecommendTemplatesWithOptionsAsync(string InstanceId, RecommendTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsageScenario))
            {
                query["usageScenario"] = request.UsageScenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<RecommendTemplatesResponse>(await DoROARequestAsync("RecommendTemplates", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/instances/" + InstanceId + "/recommended-templates", "json", req, runtime));
        }

        public ReinstallCollectorResponse ReinstallCollector(string ResId, ReinstallCollectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReinstallCollectorWithOptions(ResId, request, headers, runtime);
        }

        public async Task<ReinstallCollectorResponse> ReinstallCollectorAsync(string ResId, ReinstallCollectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReinstallCollectorWithOptionsAsync(ResId, request, headers, runtime);
        }

        public ReinstallCollectorResponse ReinstallCollectorWithOptions(string ResId, ReinstallCollectorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ResId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ReinstallCollectorResponse>(DoROARequest("ReinstallCollector", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/collectors/" + ResId + "/actions/reinstall", "json", req, runtime));
        }

        public async Task<ReinstallCollectorResponse> ReinstallCollectorWithOptionsAsync(string ResId, ReinstallCollectorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ResId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ReinstallCollectorResponse>(await DoROARequestAsync("ReinstallCollector", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/collectors/" + ResId + "/actions/reinstall", "json", req, runtime));
        }

        public RenewInstanceResponse RenewInstance(string InstanceId, RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RenewInstanceWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<RenewInstanceResponse> RenewInstanceAsync(string InstanceId, RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RenewInstanceWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public RenewInstanceResponse RenewInstanceWithOptions(string InstanceId, RenewInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<RenewInstanceResponse>(DoROARequest("RenewInstance", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/renew", "json", req, runtime));
        }

        public async Task<RenewInstanceResponse> RenewInstanceWithOptionsAsync(string InstanceId, RenewInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<RenewInstanceResponse>(await DoROARequestAsync("RenewInstance", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/renew", "json", req, runtime));
        }

        public RenewLogstashResponse RenewLogstash(string InstanceId, RenewLogstashRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RenewLogstashWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<RenewLogstashResponse> RenewLogstashAsync(string InstanceId, RenewLogstashRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RenewLogstashWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public RenewLogstashResponse RenewLogstashWithOptions(string InstanceId, RenewLogstashRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<RenewLogstashResponse>(DoROARequest("RenewLogstash", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/actions/renew", "json", req, runtime));
        }

        public async Task<RenewLogstashResponse> RenewLogstashWithOptionsAsync(string InstanceId, RenewLogstashRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<RenewLogstashResponse>(await DoROARequestAsync("RenewLogstash", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/actions/renew", "json", req, runtime));
        }

        public RestartCollectorResponse RestartCollector(string ResId, RestartCollectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestartCollectorWithOptions(ResId, request, headers, runtime);
        }

        public async Task<RestartCollectorResponse> RestartCollectorAsync(string ResId, RestartCollectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestartCollectorWithOptionsAsync(ResId, request, headers, runtime);
        }

        public RestartCollectorResponse RestartCollectorWithOptions(string ResId, RestartCollectorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ResId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<RestartCollectorResponse>(DoROARequest("RestartCollector", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/collectors/" + ResId + "/actions/restart", "json", req, runtime));
        }

        public async Task<RestartCollectorResponse> RestartCollectorWithOptionsAsync(string ResId, RestartCollectorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ResId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<RestartCollectorResponse>(await DoROARequestAsync("RestartCollector", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/collectors/" + ResId + "/actions/restart", "json", req, runtime));
        }

        public RestartInstanceResponse RestartInstance(string InstanceId, RestartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestartInstanceWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<RestartInstanceResponse> RestartInstanceAsync(string InstanceId, RestartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestartInstanceWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public RestartInstanceResponse RestartInstanceWithOptions(string InstanceId, RestartInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<RestartInstanceResponse>(DoROARequest("RestartInstance", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/restart", "json", req, runtime));
        }

        public async Task<RestartInstanceResponse> RestartInstanceWithOptionsAsync(string InstanceId, RestartInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<RestartInstanceResponse>(await DoROARequestAsync("RestartInstance", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/restart", "json", req, runtime));
        }

        public RestartLogstashResponse RestartLogstash(string InstanceId, RestartLogstashRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestartLogstashWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<RestartLogstashResponse> RestartLogstashAsync(string InstanceId, RestartLogstashRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestartLogstashWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public RestartLogstashResponse RestartLogstashWithOptions(string InstanceId, RestartLogstashRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<RestartLogstashResponse>(DoROARequest("RestartLogstash", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/actions/restart", "json", req, runtime));
        }

        public async Task<RestartLogstashResponse> RestartLogstashWithOptionsAsync(string InstanceId, RestartLogstashRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<RestartLogstashResponse>(await DoROARequestAsync("RestartLogstash", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/actions/restart", "json", req, runtime));
        }

        public ResumeElasticsearchTaskResponse ResumeElasticsearchTask(string InstanceId, ResumeElasticsearchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResumeElasticsearchTaskWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ResumeElasticsearchTaskResponse> ResumeElasticsearchTaskAsync(string InstanceId, ResumeElasticsearchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResumeElasticsearchTaskWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ResumeElasticsearchTaskResponse ResumeElasticsearchTaskWithOptions(string InstanceId, ResumeElasticsearchTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ResumeElasticsearchTaskResponse>(DoROARequest("ResumeElasticsearchTask", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/resume", "json", req, runtime));
        }

        public async Task<ResumeElasticsearchTaskResponse> ResumeElasticsearchTaskWithOptionsAsync(string InstanceId, ResumeElasticsearchTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ResumeElasticsearchTaskResponse>(await DoROARequestAsync("ResumeElasticsearchTask", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/resume", "json", req, runtime));
        }

        public ResumeLogstashTaskResponse ResumeLogstashTask(string InstanceId, ResumeLogstashTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResumeLogstashTaskWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ResumeLogstashTaskResponse> ResumeLogstashTaskAsync(string InstanceId, ResumeLogstashTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResumeLogstashTaskWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ResumeLogstashTaskResponse ResumeLogstashTaskWithOptions(string InstanceId, ResumeLogstashTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ResumeLogstashTaskResponse>(DoROARequest("ResumeLogstashTask", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/actions/resume", "json", req, runtime));
        }

        public async Task<ResumeLogstashTaskResponse> ResumeLogstashTaskWithOptionsAsync(string InstanceId, ResumeLogstashTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ResumeLogstashTaskResponse>(await DoROARequestAsync("ResumeLogstashTask", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/actions/resume", "json", req, runtime));
        }

        public RolloverDataStreamResponse RolloverDataStream(string InstanceId, string DataStream, RolloverDataStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RolloverDataStreamWithOptions(InstanceId, DataStream, request, headers, runtime);
        }

        public async Task<RolloverDataStreamResponse> RolloverDataStreamAsync(string InstanceId, string DataStream, RolloverDataStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RolloverDataStreamWithOptionsAsync(InstanceId, DataStream, request, headers, runtime);
        }

        public RolloverDataStreamResponse RolloverDataStreamWithOptions(string InstanceId, string DataStream, RolloverDataStreamRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            DataStream = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DataStream);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<RolloverDataStreamResponse>(DoROARequest("RolloverDataStream", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/data-streams/" + DataStream + "/rollover", "json", req, runtime));
        }

        public async Task<RolloverDataStreamResponse> RolloverDataStreamWithOptionsAsync(string InstanceId, string DataStream, RolloverDataStreamRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            DataStream = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DataStream);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<RolloverDataStreamResponse>(await DoROARequestAsync("RolloverDataStream", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/data-streams/" + DataStream + "/rollover", "json", req, runtime));
        }

        public RunPipelinesResponse RunPipelines(string InstanceId, RunPipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunPipelinesWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<RunPipelinesResponse> RunPipelinesAsync(string InstanceId, RunPipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunPipelinesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public RunPipelinesResponse RunPipelinesWithOptions(string InstanceId, RunPipelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<RunPipelinesResponse>(DoROARequest("RunPipelines", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/pipelines/action/run", "json", req, runtime));
        }

        public async Task<RunPipelinesResponse> RunPipelinesWithOptionsAsync(string InstanceId, RunPipelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<RunPipelinesResponse>(await DoROARequestAsync("RunPipelines", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/pipelines/action/run", "json", req, runtime));
        }

        public ShrinkNodeResponse ShrinkNode(string InstanceId, ShrinkNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ShrinkNodeWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ShrinkNodeResponse> ShrinkNodeAsync(string InstanceId, ShrinkNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ShrinkNodeWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ShrinkNodeResponse ShrinkNodeWithOptions(string InstanceId, ShrinkNodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeType))
            {
                query["nodeType"] = request.NodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreStatus))
            {
                query["ignoreStatus"] = request.IgnoreStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ShrinkNodeResponse>(DoROARequest("ShrinkNode", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/shrink", "json", req, runtime));
        }

        public async Task<ShrinkNodeResponse> ShrinkNodeWithOptionsAsync(string InstanceId, ShrinkNodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeType))
            {
                query["nodeType"] = request.NodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreStatus))
            {
                query["ignoreStatus"] = request.IgnoreStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ShrinkNodeResponse>(await DoROARequestAsync("ShrinkNode", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/shrink", "json", req, runtime));
        }

        public StartCollectorResponse StartCollector(string ResId, StartCollectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartCollectorWithOptions(ResId, request, headers, runtime);
        }

        public async Task<StartCollectorResponse> StartCollectorAsync(string ResId, StartCollectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartCollectorWithOptionsAsync(ResId, request, headers, runtime);
        }

        public StartCollectorResponse StartCollectorWithOptions(string ResId, StartCollectorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ResId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<StartCollectorResponse>(DoROARequest("StartCollector", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/collectors/" + ResId + "/actions/start", "json", req, runtime));
        }

        public async Task<StartCollectorResponse> StartCollectorWithOptionsAsync(string ResId, StartCollectorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ResId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<StartCollectorResponse>(await DoROARequestAsync("StartCollector", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/collectors/" + ResId + "/actions/start", "json", req, runtime));
        }

        public StopCollectorResponse StopCollector(string ResId, StopCollectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopCollectorWithOptions(ResId, request, headers, runtime);
        }

        public async Task<StopCollectorResponse> StopCollectorAsync(string ResId, StopCollectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopCollectorWithOptionsAsync(ResId, request, headers, runtime);
        }

        public StopCollectorResponse StopCollectorWithOptions(string ResId, StopCollectorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ResId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<StopCollectorResponse>(DoROARequest("StopCollector", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/collectors/" + ResId + "/actions/stop", "json", req, runtime));
        }

        public async Task<StopCollectorResponse> StopCollectorWithOptionsAsync(string ResId, StopCollectorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ResId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<StopCollectorResponse>(await DoROARequestAsync("StopCollector", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/collectors/" + ResId + "/actions/stop", "json", req, runtime));
        }

        public StopPipelinesResponse StopPipelines(string InstanceId, StopPipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopPipelinesWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<StopPipelinesResponse> StopPipelinesAsync(string InstanceId, StopPipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopPipelinesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public StopPipelinesResponse StopPipelinesWithOptions(string InstanceId, StopPipelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<StopPipelinesResponse>(DoROARequest("StopPipelines", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/pipelines/action/stop", "json", req, runtime));
        }

        public async Task<StopPipelinesResponse> StopPipelinesWithOptionsAsync(string InstanceId, StopPipelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<StopPipelinesResponse>(await DoROARequestAsync("StopPipelines", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/pipelines/action/stop", "json", req, runtime));
        }

        public TagResourcesResponse TagResources()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TagResourcesWithOptions(headers, runtime);
        }

        public async Task<TagResourcesResponse> TagResourcesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TagResourcesWithOptionsAsync(headers, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoROARequest("TagResources", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/tags", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoROARequestAsync("TagResources", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/tags", "json", req, runtime));
        }

        public TransferNodeResponse TransferNode(string InstanceId, TransferNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TransferNodeWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<TransferNodeResponse> TransferNodeAsync(string InstanceId, TransferNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TransferNodeWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public TransferNodeResponse TransferNodeWithOptions(string InstanceId, TransferNodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeType))
            {
                query["nodeType"] = request.NodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<TransferNodeResponse>(DoROARequest("TransferNode", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/transfer", "json", req, runtime));
        }

        public async Task<TransferNodeResponse> TransferNodeWithOptionsAsync(string InstanceId, TransferNodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeType))
            {
                query["nodeType"] = request.NodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<TransferNodeResponse>(await DoROARequestAsync("TransferNode", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/transfer", "json", req, runtime));
        }

        public TriggerNetworkResponse TriggerNetwork(string InstanceId, TriggerNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TriggerNetworkWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<TriggerNetworkResponse> TriggerNetworkAsync(string InstanceId, TriggerNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TriggerNetworkWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public TriggerNetworkResponse TriggerNetworkWithOptions(string InstanceId, TriggerNetworkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeType))
            {
                body["nodeType"] = request.NodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                body["networkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                body["actionType"] = request.ActionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<TriggerNetworkResponse>(DoROARequestWithForm("TriggerNetwork", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/network-trigger", "json", req, runtime));
        }

        public async Task<TriggerNetworkResponse> TriggerNetworkWithOptionsAsync(string InstanceId, TriggerNetworkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeType))
            {
                body["nodeType"] = request.NodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                body["networkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                body["actionType"] = request.ActionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<TriggerNetworkResponse>(await DoROARequestWithFormAsync("TriggerNetwork", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/network-trigger", "json", req, runtime));
        }

        public UninstallKibanaPluginResponse UninstallKibanaPlugin(string InstanceId, UninstallKibanaPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UninstallKibanaPluginWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UninstallKibanaPluginResponse> UninstallKibanaPluginAsync(string InstanceId, UninstallKibanaPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UninstallKibanaPluginWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UninstallKibanaPluginResponse UninstallKibanaPluginWithOptions(string InstanceId, UninstallKibanaPluginRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UninstallKibanaPluginResponse>(DoROARequest("UninstallKibanaPlugin", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/kibana-plugins/actions/uninstall", "json", req, runtime));
        }

        public async Task<UninstallKibanaPluginResponse> UninstallKibanaPluginWithOptionsAsync(string InstanceId, UninstallKibanaPluginRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UninstallKibanaPluginResponse>(await DoROARequestAsync("UninstallKibanaPlugin", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/kibana-plugins/actions/uninstall", "json", req, runtime));
        }

        public UninstallLogstashPluginResponse UninstallLogstashPlugin(string InstanceId, UninstallLogstashPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UninstallLogstashPluginWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UninstallLogstashPluginResponse> UninstallLogstashPluginAsync(string InstanceId, UninstallLogstashPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UninstallLogstashPluginWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UninstallLogstashPluginResponse UninstallLogstashPluginWithOptions(string InstanceId, UninstallLogstashPluginRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UninstallLogstashPluginResponse>(DoROARequest("UninstallLogstashPlugin", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/plugins/actions/uninstall", "json", req, runtime));
        }

        public async Task<UninstallLogstashPluginResponse> UninstallLogstashPluginWithOptionsAsync(string InstanceId, UninstallLogstashPluginRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UninstallLogstashPluginResponse>(await DoROARequestAsync("UninstallLogstashPlugin", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/plugins/actions/uninstall", "json", req, runtime));
        }

        public UninstallPluginResponse UninstallPlugin(string InstanceId, UninstallPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UninstallPluginWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UninstallPluginResponse> UninstallPluginAsync(string InstanceId, UninstallPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UninstallPluginWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UninstallPluginResponse UninstallPluginWithOptions(string InstanceId, UninstallPluginRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UninstallPluginResponse>(DoROARequest("UninstallPlugin", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/plugins/actions/uninstall", "json", req, runtime));
        }

        public async Task<UninstallPluginResponse> UninstallPluginWithOptionsAsync(string InstanceId, UninstallPluginRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UninstallPluginResponse>(await DoROARequestAsync("UninstallPlugin", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/plugins/actions/uninstall", "json", req, runtime));
        }

        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UntagResourcesWithOptions(request, headers, runtime);
        }

        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UntagResourcesWithOptionsAsync(request, headers, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["TagKeys"] = request.TagKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(DoROARequest("UntagResources", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/tags", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["TagKeys"] = request.TagKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoROARequestAsync("UntagResources", "2017-06-13", "HTTPS", "DELETE", "AK", "/openapi/tags", "json", req, runtime));
        }

        public UpdateAdminPasswordResponse UpdateAdminPassword(string InstanceId, UpdateAdminPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAdminPasswordWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateAdminPasswordResponse> UpdateAdminPasswordAsync(string InstanceId, UpdateAdminPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAdminPasswordWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateAdminPasswordResponse UpdateAdminPasswordWithOptions(string InstanceId, UpdateAdminPasswordRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateAdminPasswordResponse>(DoROARequest("UpdateAdminPassword", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/admin-pwd", "json", req, runtime));
        }

        public async Task<UpdateAdminPasswordResponse> UpdateAdminPasswordWithOptionsAsync(string InstanceId, UpdateAdminPasswordRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateAdminPasswordResponse>(await DoROARequestAsync("UpdateAdminPassword", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/admin-pwd", "json", req, runtime));
        }

        public UpdateAdvancedSettingResponse UpdateAdvancedSetting(string InstanceId, UpdateAdvancedSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAdvancedSettingWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateAdvancedSettingResponse> UpdateAdvancedSettingAsync(string InstanceId, UpdateAdvancedSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAdvancedSettingWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateAdvancedSettingResponse UpdateAdvancedSettingWithOptions(string InstanceId, UpdateAdvancedSettingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateAdvancedSettingResponse>(DoROARequest("UpdateAdvancedSetting", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/update-advanced-setting", "json", req, runtime));
        }

        public async Task<UpdateAdvancedSettingResponse> UpdateAdvancedSettingWithOptionsAsync(string InstanceId, UpdateAdvancedSettingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateAdvancedSettingResponse>(await DoROARequestAsync("UpdateAdvancedSetting", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/update-advanced-setting", "json", req, runtime));
        }

        public UpdateAliwsDictResponse UpdateAliwsDict(string InstanceId, UpdateAliwsDictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAliwsDictWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateAliwsDictResponse> UpdateAliwsDictAsync(string InstanceId, UpdateAliwsDictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAliwsDictWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateAliwsDictResponse UpdateAliwsDictWithOptions(string InstanceId, UpdateAliwsDictRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateAliwsDictResponse>(DoROARequest("UpdateAliwsDict", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/aliws-dict", "json", req, runtime));
        }

        public async Task<UpdateAliwsDictResponse> UpdateAliwsDictWithOptionsAsync(string InstanceId, UpdateAliwsDictRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateAliwsDictResponse>(await DoROARequestAsync("UpdateAliwsDict", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/aliws-dict", "json", req, runtime));
        }

        public UpdateBlackIpsResponse UpdateBlackIps(string InstanceId, UpdateBlackIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateBlackIpsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateBlackIpsResponse> UpdateBlackIpsAsync(string InstanceId, UpdateBlackIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateBlackIpsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateBlackIpsResponse UpdateBlackIpsWithOptions(string InstanceId, UpdateBlackIpsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EsIPBlacklist))
            {
                body["esIPBlacklist"] = request.EsIPBlacklist;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateBlackIpsResponse>(DoROARequestWithForm("UpdateBlackIps", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/black-ips", "json", req, runtime));
        }

        public async Task<UpdateBlackIpsResponse> UpdateBlackIpsWithOptionsAsync(string InstanceId, UpdateBlackIpsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EsIPBlacklist))
            {
                body["esIPBlacklist"] = request.EsIPBlacklist;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateBlackIpsResponse>(await DoROARequestWithFormAsync("UpdateBlackIps", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/black-ips", "json", req, runtime));
        }

        public UpdateCollectorResponse UpdateCollector(string ResId, UpdateCollectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateCollectorWithOptions(ResId, request, headers, runtime);
        }

        public async Task<UpdateCollectorResponse> UpdateCollectorAsync(string ResId, UpdateCollectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateCollectorWithOptionsAsync(ResId, request, headers, runtime);
        }

        public UpdateCollectorResponse UpdateCollectorWithOptions(string ResId, UpdateCollectorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ResId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateCollectorResponse>(DoROARequest("UpdateCollector", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/collectors/" + ResId, "json", req, runtime));
        }

        public async Task<UpdateCollectorResponse> UpdateCollectorWithOptionsAsync(string ResId, UpdateCollectorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ResId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateCollectorResponse>(await DoROARequestAsync("UpdateCollector", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/collectors/" + ResId, "json", req, runtime));
        }

        public UpdateCollectorNameResponse UpdateCollectorName(string ResId, UpdateCollectorNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateCollectorNameWithOptions(ResId, request, headers, runtime);
        }

        public async Task<UpdateCollectorNameResponse> UpdateCollectorNameAsync(string ResId, UpdateCollectorNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateCollectorNameWithOptionsAsync(ResId, request, headers, runtime);
        }

        public UpdateCollectorNameResponse UpdateCollectorNameWithOptions(string ResId, UpdateCollectorNameRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ResId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateCollectorNameResponse>(DoROARequest("UpdateCollectorName", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/collectors/" + ResId + "/actions/rename", "json", req, runtime));
        }

        public async Task<UpdateCollectorNameResponse> UpdateCollectorNameWithOptionsAsync(string ResId, UpdateCollectorNameRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ResId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateCollectorNameResponse>(await DoROARequestAsync("UpdateCollectorName", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/collectors/" + ResId + "/actions/rename", "json", req, runtime));
        }

        public UpdateDescriptionResponse UpdateDescription(string InstanceId, UpdateDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDescriptionWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateDescriptionResponse> UpdateDescriptionAsync(string InstanceId, UpdateDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDescriptionWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateDescriptionResponse UpdateDescriptionWithOptions(string InstanceId, UpdateDescriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateDescriptionResponse>(DoROARequestWithForm("UpdateDescription", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/description", "json", req, runtime));
        }

        public async Task<UpdateDescriptionResponse> UpdateDescriptionWithOptionsAsync(string InstanceId, UpdateDescriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateDescriptionResponse>(await DoROARequestWithFormAsync("UpdateDescription", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/description", "json", req, runtime));
        }

        public UpdateDiagnosisSettingsResponse UpdateDiagnosisSettings(string InstanceId, UpdateDiagnosisSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDiagnosisSettingsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateDiagnosisSettingsResponse> UpdateDiagnosisSettingsAsync(string InstanceId, UpdateDiagnosisSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDiagnosisSettingsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateDiagnosisSettingsResponse UpdateDiagnosisSettingsWithOptions(string InstanceId, UpdateDiagnosisSettingsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateDiagnosisSettingsResponse>(DoROARequest("UpdateDiagnosisSettings", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/diagnosis/instances/" + InstanceId + "/settings", "json", req, runtime));
        }

        public async Task<UpdateDiagnosisSettingsResponse> UpdateDiagnosisSettingsWithOptionsAsync(string InstanceId, UpdateDiagnosisSettingsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateDiagnosisSettingsResponse>(await DoROARequestAsync("UpdateDiagnosisSettings", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/diagnosis/instances/" + InstanceId + "/settings", "json", req, runtime));
        }

        public UpdateDictResponse UpdateDict(string InstanceId, UpdateDictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDictWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateDictResponse> UpdateDictAsync(string InstanceId, UpdateDictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDictWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateDictResponse UpdateDictWithOptions(string InstanceId, UpdateDictRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateDictResponse>(DoROARequest("UpdateDict", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/dict", "json", req, runtime));
        }

        public async Task<UpdateDictResponse> UpdateDictWithOptionsAsync(string InstanceId, UpdateDictRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateDictResponse>(await DoROARequestAsync("UpdateDict", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/dict", "json", req, runtime));
        }

        public UpdateExtendConfigResponse UpdateExtendConfig(string InstanceId, UpdateExtendConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateExtendConfigWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateExtendConfigResponse> UpdateExtendConfigAsync(string InstanceId, UpdateExtendConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateExtendConfigWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateExtendConfigResponse UpdateExtendConfigWithOptions(string InstanceId, UpdateExtendConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateExtendConfigResponse>(DoROARequest("UpdateExtendConfig", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/extend-configs/actions/update", "json", req, runtime));
        }

        public async Task<UpdateExtendConfigResponse> UpdateExtendConfigWithOptionsAsync(string InstanceId, UpdateExtendConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateExtendConfigResponse>(await DoROARequestAsync("UpdateExtendConfig", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/extend-configs/actions/update", "json", req, runtime));
        }

        public UpdateExtendfilesResponse UpdateExtendfiles(string InstanceId, UpdateExtendfilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateExtendfilesWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateExtendfilesResponse> UpdateExtendfilesAsync(string InstanceId, UpdateExtendfilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateExtendfilesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateExtendfilesResponse UpdateExtendfilesWithOptions(string InstanceId, UpdateExtendfilesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateExtendfilesResponse>(DoROARequest("UpdateExtendfiles", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/logstashes/" + InstanceId + "/extendfiles", "json", req, runtime));
        }

        public async Task<UpdateExtendfilesResponse> UpdateExtendfilesWithOptionsAsync(string InstanceId, UpdateExtendfilesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateExtendfilesResponse>(await DoROARequestAsync("UpdateExtendfiles", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/logstashes/" + InstanceId + "/extendfiles", "json", req, runtime));
        }

        public UpdateHotIkDictsResponse UpdateHotIkDicts(string InstanceId, UpdateHotIkDictsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateHotIkDictsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateHotIkDictsResponse> UpdateHotIkDictsAsync(string InstanceId, UpdateHotIkDictsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateHotIkDictsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateHotIkDictsResponse UpdateHotIkDictsWithOptions(string InstanceId, UpdateHotIkDictsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateHotIkDictsResponse>(DoROARequest("UpdateHotIkDicts", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/ik-hot-dict", "json", req, runtime));
        }

        public async Task<UpdateHotIkDictsResponse> UpdateHotIkDictsWithOptionsAsync(string InstanceId, UpdateHotIkDictsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateHotIkDictsResponse>(await DoROARequestAsync("UpdateHotIkDicts", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/ik-hot-dict", "json", req, runtime));
        }

        public UpdateILMPolicyResponse UpdateILMPolicy(string InstanceId, string PolicyName, UpdateILMPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateILMPolicyWithOptions(InstanceId, PolicyName, request, headers, runtime);
        }

        public async Task<UpdateILMPolicyResponse> UpdateILMPolicyAsync(string InstanceId, string PolicyName, UpdateILMPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateILMPolicyWithOptionsAsync(InstanceId, PolicyName, request, headers, runtime);
        }

        public UpdateILMPolicyResponse UpdateILMPolicyWithOptions(string InstanceId, string PolicyName, UpdateILMPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            PolicyName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(PolicyName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateILMPolicyResponse>(DoROARequest("UpdateILMPolicy", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/ilm-policies/" + PolicyName, "json", req, runtime));
        }

        public async Task<UpdateILMPolicyResponse> UpdateILMPolicyWithOptionsAsync(string InstanceId, string PolicyName, UpdateILMPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            PolicyName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(PolicyName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateILMPolicyResponse>(await DoROARequestAsync("UpdateILMPolicy", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/ilm-policies/" + PolicyName, "json", req, runtime));
        }

        public UpdateIndexTemplateResponse UpdateIndexTemplate(string InstanceId, string IndexTemplate, UpdateIndexTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateIndexTemplateWithOptions(InstanceId, IndexTemplate, request, headers, runtime);
        }

        public async Task<UpdateIndexTemplateResponse> UpdateIndexTemplateAsync(string InstanceId, string IndexTemplate, UpdateIndexTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateIndexTemplateWithOptionsAsync(InstanceId, IndexTemplate, request, headers, runtime);
        }

        public UpdateIndexTemplateResponse UpdateIndexTemplateWithOptions(string InstanceId, string IndexTemplate, UpdateIndexTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            IndexTemplate = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(IndexTemplate);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateIndexTemplateResponse>(DoROARequest("UpdateIndexTemplate", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/index-templates/" + IndexTemplate, "json", req, runtime));
        }

        public async Task<UpdateIndexTemplateResponse> UpdateIndexTemplateWithOptionsAsync(string InstanceId, string IndexTemplate, UpdateIndexTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            IndexTemplate = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(IndexTemplate);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateIndexTemplateResponse>(await DoROARequestAsync("UpdateIndexTemplate", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/index-templates/" + IndexTemplate, "json", req, runtime));
        }

        public UpdateInstanceResponse UpdateInstance(string InstanceId, UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateInstanceWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateInstanceResponse> UpdateInstanceAsync(string InstanceId, UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateInstanceWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateInstanceResponse UpdateInstanceWithOptions(string InstanceId, UpdateInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreStatus))
            {
                query["ignoreStatus"] = request.IgnoreStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderActionType))
            {
                query["orderActionType"] = request.OrderActionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateInstanceResponse>(DoROARequest("UpdateInstance", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId, "json", req, runtime));
        }

        public async Task<UpdateInstanceResponse> UpdateInstanceWithOptionsAsync(string InstanceId, UpdateInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreStatus))
            {
                query["ignoreStatus"] = request.IgnoreStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderActionType))
            {
                query["orderActionType"] = request.OrderActionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateInstanceResponse>(await DoROARequestAsync("UpdateInstance", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId, "json", req, runtime));
        }

        public UpdateInstanceChargeTypeResponse UpdateInstanceChargeType(string InstanceId, UpdateInstanceChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateInstanceChargeTypeWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateInstanceChargeTypeResponse> UpdateInstanceChargeTypeAsync(string InstanceId, UpdateInstanceChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateInstanceChargeTypeWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateInstanceChargeTypeResponse UpdateInstanceChargeTypeWithOptions(string InstanceId, UpdateInstanceChargeTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateInstanceChargeTypeResponse>(DoROARequest("UpdateInstanceChargeType", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/convert-pay-type", "json", req, runtime));
        }

        public async Task<UpdateInstanceChargeTypeResponse> UpdateInstanceChargeTypeWithOptionsAsync(string InstanceId, UpdateInstanceChargeTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateInstanceChargeTypeResponse>(await DoROARequestAsync("UpdateInstanceChargeType", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/convert-pay-type", "json", req, runtime));
        }

        public UpdateInstanceSettingsResponse UpdateInstanceSettings(string InstanceId, UpdateInstanceSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateInstanceSettingsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateInstanceSettingsResponse> UpdateInstanceSettingsAsync(string InstanceId, UpdateInstanceSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateInstanceSettingsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateInstanceSettingsResponse UpdateInstanceSettingsWithOptions(string InstanceId, UpdateInstanceSettingsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateInstanceSettingsResponse>(DoROARequest("UpdateInstanceSettings", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/instance-settings", "json", req, runtime));
        }

        public async Task<UpdateInstanceSettingsResponse> UpdateInstanceSettingsWithOptionsAsync(string InstanceId, UpdateInstanceSettingsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateInstanceSettingsResponse>(await DoROARequestAsync("UpdateInstanceSettings", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/instance-settings", "json", req, runtime));
        }

        public UpdateKibanaSettingsResponse UpdateKibanaSettings(string InstanceId, UpdateKibanaSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateKibanaSettingsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateKibanaSettingsResponse> UpdateKibanaSettingsAsync(string InstanceId, UpdateKibanaSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateKibanaSettingsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateKibanaSettingsResponse UpdateKibanaSettingsWithOptions(string InstanceId, UpdateKibanaSettingsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateKibanaSettingsResponse>(DoROARequest("UpdateKibanaSettings", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/update-kibana-settings", "json", req, runtime));
        }

        public async Task<UpdateKibanaSettingsResponse> UpdateKibanaSettingsWithOptionsAsync(string InstanceId, UpdateKibanaSettingsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateKibanaSettingsResponse>(await DoROARequestAsync("UpdateKibanaSettings", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/update-kibana-settings", "json", req, runtime));
        }

        public UpdateKibanaWhiteIpsResponse UpdateKibanaWhiteIps(string InstanceId, UpdateKibanaWhiteIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateKibanaWhiteIpsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateKibanaWhiteIpsResponse> UpdateKibanaWhiteIpsAsync(string InstanceId, UpdateKibanaWhiteIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateKibanaWhiteIpsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateKibanaWhiteIpsResponse UpdateKibanaWhiteIpsWithOptions(string InstanceId, UpdateKibanaWhiteIpsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMode))
            {
                query["modifyMode"] = request.ModifyMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateKibanaWhiteIpsResponse>(DoROARequest("UpdateKibanaWhiteIps", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/kibana-white-ips", "json", req, runtime));
        }

        public async Task<UpdateKibanaWhiteIpsResponse> UpdateKibanaWhiteIpsWithOptionsAsync(string InstanceId, UpdateKibanaWhiteIpsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMode))
            {
                query["modifyMode"] = request.ModifyMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateKibanaWhiteIpsResponse>(await DoROARequestAsync("UpdateKibanaWhiteIps", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/kibana-white-ips", "json", req, runtime));
        }

        public UpdateLogstashResponse UpdateLogstash(string InstanceId, UpdateLogstashRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLogstashWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateLogstashResponse> UpdateLogstashAsync(string InstanceId, UpdateLogstashRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLogstashWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateLogstashResponse UpdateLogstashWithOptions(string InstanceId, UpdateLogstashRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateLogstashResponse>(DoROARequest("UpdateLogstash", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/logstashes/" + InstanceId, "json", req, runtime));
        }

        public async Task<UpdateLogstashResponse> UpdateLogstashWithOptionsAsync(string InstanceId, UpdateLogstashRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateLogstashResponse>(await DoROARequestAsync("UpdateLogstash", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/logstashes/" + InstanceId, "json", req, runtime));
        }

        public UpdateLogstashChargeTypeResponse UpdateLogstashChargeType(string InstanceId, UpdateLogstashChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLogstashChargeTypeWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateLogstashChargeTypeResponse> UpdateLogstashChargeTypeAsync(string InstanceId, UpdateLogstashChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLogstashChargeTypeWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateLogstashChargeTypeResponse UpdateLogstashChargeTypeWithOptions(string InstanceId, UpdateLogstashChargeTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateLogstashChargeTypeResponse>(DoROARequest("UpdateLogstashChargeType", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/actions/convert-pay-type", "json", req, runtime));
        }

        public async Task<UpdateLogstashChargeTypeResponse> UpdateLogstashChargeTypeWithOptionsAsync(string InstanceId, UpdateLogstashChargeTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateLogstashChargeTypeResponse>(await DoROARequestAsync("UpdateLogstashChargeType", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/actions/convert-pay-type", "json", req, runtime));
        }

        public UpdateLogstashDescriptionResponse UpdateLogstashDescription(string InstanceId, UpdateLogstashDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLogstashDescriptionWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateLogstashDescriptionResponse> UpdateLogstashDescriptionAsync(string InstanceId, UpdateLogstashDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLogstashDescriptionWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateLogstashDescriptionResponse UpdateLogstashDescriptionWithOptions(string InstanceId, UpdateLogstashDescriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateLogstashDescriptionResponse>(DoROARequest("UpdateLogstashDescription", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/description", "json", req, runtime));
        }

        public async Task<UpdateLogstashDescriptionResponse> UpdateLogstashDescriptionWithOptionsAsync(string InstanceId, UpdateLogstashDescriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateLogstashDescriptionResponse>(await DoROARequestAsync("UpdateLogstashDescription", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/description", "json", req, runtime));
        }

        public UpdateLogstashSettingsResponse UpdateLogstashSettings(string InstanceId, UpdateLogstashSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLogstashSettingsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateLogstashSettingsResponse> UpdateLogstashSettingsAsync(string InstanceId, UpdateLogstashSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLogstashSettingsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateLogstashSettingsResponse UpdateLogstashSettingsWithOptions(string InstanceId, UpdateLogstashSettingsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateLogstashSettingsResponse>(DoROARequest("UpdateLogstashSettings", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/instance-settings", "json", req, runtime));
        }

        public async Task<UpdateLogstashSettingsResponse> UpdateLogstashSettingsWithOptionsAsync(string InstanceId, UpdateLogstashSettingsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateLogstashSettingsResponse>(await DoROARequestAsync("UpdateLogstashSettings", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/instance-settings", "json", req, runtime));
        }

        public UpdatePipelineManagementConfigResponse UpdatePipelineManagementConfig(string InstanceId, UpdatePipelineManagementConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdatePipelineManagementConfigWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdatePipelineManagementConfigResponse> UpdatePipelineManagementConfigAsync(string InstanceId, UpdatePipelineManagementConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdatePipelineManagementConfigWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdatePipelineManagementConfigResponse UpdatePipelineManagementConfigWithOptions(string InstanceId, UpdatePipelineManagementConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdatePipelineManagementConfigResponse>(DoROARequest("UpdatePipelineManagementConfig", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/pipeline-management-config", "json", req, runtime));
        }

        public async Task<UpdatePipelineManagementConfigResponse> UpdatePipelineManagementConfigWithOptionsAsync(string InstanceId, UpdatePipelineManagementConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdatePipelineManagementConfigResponse>(await DoROARequestAsync("UpdatePipelineManagementConfig", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/pipeline-management-config", "json", req, runtime));
        }

        public UpdatePipelinesResponse UpdatePipelines(string InstanceId, UpdatePipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdatePipelinesWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdatePipelinesResponse> UpdatePipelinesAsync(string InstanceId, UpdatePipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdatePipelinesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdatePipelinesResponse UpdatePipelinesWithOptions(string InstanceId, UpdatePipelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Trigger))
            {
                query["trigger"] = request.Trigger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdatePipelinesResponse>(DoROARequest("UpdatePipelines", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/logstashes/" + InstanceId + "/pipelines", "json", req, runtime));
        }

        public async Task<UpdatePipelinesResponse> UpdatePipelinesWithOptionsAsync(string InstanceId, UpdatePipelinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Trigger))
            {
                query["trigger"] = request.Trigger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdatePipelinesResponse>(await DoROARequestAsync("UpdatePipelines", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/logstashes/" + InstanceId + "/pipelines", "json", req, runtime));
        }

        public UpdatePrivateNetworkWhiteIpsResponse UpdatePrivateNetworkWhiteIps(string InstanceId, UpdatePrivateNetworkWhiteIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdatePrivateNetworkWhiteIpsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdatePrivateNetworkWhiteIpsResponse> UpdatePrivateNetworkWhiteIpsAsync(string InstanceId, UpdatePrivateNetworkWhiteIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdatePrivateNetworkWhiteIpsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdatePrivateNetworkWhiteIpsResponse UpdatePrivateNetworkWhiteIpsWithOptions(string InstanceId, UpdatePrivateNetworkWhiteIpsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMode))
            {
                query["modifyMode"] = request.ModifyMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdatePrivateNetworkWhiteIpsResponse>(DoROARequest("UpdatePrivateNetworkWhiteIps", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/private-network-white-ips", "json", req, runtime));
        }

        public async Task<UpdatePrivateNetworkWhiteIpsResponse> UpdatePrivateNetworkWhiteIpsWithOptionsAsync(string InstanceId, UpdatePrivateNetworkWhiteIpsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMode))
            {
                query["modifyMode"] = request.ModifyMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdatePrivateNetworkWhiteIpsResponse>(await DoROARequestAsync("UpdatePrivateNetworkWhiteIps", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/private-network-white-ips", "json", req, runtime));
        }

        public UpdatePublicNetworkResponse UpdatePublicNetwork(string InstanceId, UpdatePublicNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdatePublicNetworkWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdatePublicNetworkResponse> UpdatePublicNetworkAsync(string InstanceId, UpdatePublicNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdatePublicNetworkWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdatePublicNetworkResponse UpdatePublicNetworkWithOptions(string InstanceId, UpdatePublicNetworkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdatePublicNetworkResponse>(DoROARequest("UpdatePublicNetwork", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/public-network", "json", req, runtime));
        }

        public async Task<UpdatePublicNetworkResponse> UpdatePublicNetworkWithOptionsAsync(string InstanceId, UpdatePublicNetworkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdatePublicNetworkResponse>(await DoROARequestAsync("UpdatePublicNetwork", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/public-network", "json", req, runtime));
        }

        public UpdatePublicWhiteIpsResponse UpdatePublicWhiteIps(string InstanceId, UpdatePublicWhiteIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdatePublicWhiteIpsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdatePublicWhiteIpsResponse> UpdatePublicWhiteIpsAsync(string InstanceId, UpdatePublicWhiteIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdatePublicWhiteIpsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdatePublicWhiteIpsResponse UpdatePublicWhiteIpsWithOptions(string InstanceId, UpdatePublicWhiteIpsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMode))
            {
                query["modifyMode"] = request.ModifyMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdatePublicWhiteIpsResponse>(DoROARequest("UpdatePublicWhiteIps", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/public-white-ips", "json", req, runtime));
        }

        public async Task<UpdatePublicWhiteIpsResponse> UpdatePublicWhiteIpsWithOptionsAsync(string InstanceId, UpdatePublicWhiteIpsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMode))
            {
                query["modifyMode"] = request.ModifyMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdatePublicWhiteIpsResponse>(await DoROARequestAsync("UpdatePublicWhiteIps", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/public-white-ips", "json", req, runtime));
        }

        public UpdateReadWritePolicyResponse UpdateReadWritePolicy(string InstanceId, UpdateReadWritePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateReadWritePolicyWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateReadWritePolicyResponse> UpdateReadWritePolicyAsync(string InstanceId, UpdateReadWritePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateReadWritePolicyWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateReadWritePolicyResponse UpdateReadWritePolicyWithOptions(string InstanceId, UpdateReadWritePolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateReadWritePolicyResponse>(DoROARequest("UpdateReadWritePolicy", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/update-read-write-policy", "json", req, runtime));
        }

        public async Task<UpdateReadWritePolicyResponse> UpdateReadWritePolicyWithOptionsAsync(string InstanceId, UpdateReadWritePolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateReadWritePolicyResponse>(await DoROARequestAsync("UpdateReadWritePolicy", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/update-read-write-policy", "json", req, runtime));
        }

        public UpdateSnapshotSettingResponse UpdateSnapshotSetting(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSnapshotSettingWithOptions(InstanceId, headers, runtime);
        }

        public async Task<UpdateSnapshotSettingResponse> UpdateSnapshotSettingAsync(string InstanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSnapshotSettingWithOptionsAsync(InstanceId, headers, runtime);
        }

        public UpdateSnapshotSettingResponse UpdateSnapshotSettingWithOptions(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<UpdateSnapshotSettingResponse>(DoROARequest("UpdateSnapshotSetting", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/snapshot-setting", "json", req, runtime));
        }

        public async Task<UpdateSnapshotSettingResponse> UpdateSnapshotSettingWithOptionsAsync(string InstanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<UpdateSnapshotSettingResponse>(await DoROARequestAsync("UpdateSnapshotSetting", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/snapshot-setting", "json", req, runtime));
        }

        public UpdateSynonymsDictsResponse UpdateSynonymsDicts(string InstanceId, UpdateSynonymsDictsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSynonymsDictsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateSynonymsDictsResponse> UpdateSynonymsDictsAsync(string InstanceId, UpdateSynonymsDictsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSynonymsDictsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateSynonymsDictsResponse UpdateSynonymsDictsWithOptions(string InstanceId, UpdateSynonymsDictsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateSynonymsDictsResponse>(DoROARequest("UpdateSynonymsDicts", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/synonymsDict", "json", req, runtime));
        }

        public async Task<UpdateSynonymsDictsResponse> UpdateSynonymsDictsWithOptionsAsync(string InstanceId, UpdateSynonymsDictsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateSynonymsDictsResponse>(await DoROARequestAsync("UpdateSynonymsDicts", "2017-06-13", "HTTPS", "PUT", "AK", "/openapi/instances/" + InstanceId + "/synonymsDict", "json", req, runtime));
        }

        public UpdateTemplateResponse UpdateTemplate(string InstanceId, string TemplateName, UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTemplateWithOptions(InstanceId, TemplateName, request, headers, runtime);
        }

        public async Task<UpdateTemplateResponse> UpdateTemplateAsync(string InstanceId, string TemplateName, UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTemplateWithOptionsAsync(InstanceId, TemplateName, request, headers, runtime);
        }

        public UpdateTemplateResponse UpdateTemplateWithOptions(string InstanceId, string TemplateName, UpdateTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            TemplateName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(DoROARequest("UpdateTemplate", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/templates/" + TemplateName, "json", req, runtime));
        }

        public async Task<UpdateTemplateResponse> UpdateTemplateWithOptionsAsync(string InstanceId, string TemplateName, UpdateTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            TemplateName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(await DoROARequestAsync("UpdateTemplate", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/templates/" + TemplateName, "json", req, runtime));
        }

        public UpdateWhiteIpsResponse UpdateWhiteIps(string InstanceId, UpdateWhiteIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateWhiteIpsWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateWhiteIpsResponse> UpdateWhiteIpsAsync(string InstanceId, UpdateWhiteIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateWhiteIpsWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateWhiteIpsResponse UpdateWhiteIpsWithOptions(string InstanceId, UpdateWhiteIpsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMode))
            {
                query["modifyMode"] = request.ModifyMode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EsIPWhitelist))
            {
                body["esIPWhitelist"] = request.EsIPWhitelist;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteIpGroup.ToMap()))
            {
                body["whiteIpGroup"] = request.WhiteIpGroup;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateWhiteIpsResponse>(DoROARequestWithForm("UpdateWhiteIps", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/white-ips", "json", req, runtime));
        }

        public async Task<UpdateWhiteIpsResponse> UpdateWhiteIpsWithOptionsAsync(string InstanceId, UpdateWhiteIpsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMode))
            {
                query["modifyMode"] = request.ModifyMode;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EsIPWhitelist))
            {
                body["esIPWhitelist"] = request.EsIPWhitelist;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteIpGroup.ToMap()))
            {
                body["whiteIpGroup"] = request.WhiteIpGroup;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateWhiteIpsResponse>(await DoROARequestWithFormAsync("UpdateWhiteIps", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/white-ips", "json", req, runtime));
        }

        public UpdateXpackMonitorConfigResponse UpdateXpackMonitorConfig(string InstanceId, UpdateXpackMonitorConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateXpackMonitorConfigWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpdateXpackMonitorConfigResponse> UpdateXpackMonitorConfigAsync(string InstanceId, UpdateXpackMonitorConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateXpackMonitorConfigWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpdateXpackMonitorConfigResponse UpdateXpackMonitorConfigWithOptions(string InstanceId, UpdateXpackMonitorConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateXpackMonitorConfigResponse>(DoROARequest("UpdateXpackMonitorConfig", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/xpack-monitor-config", "json", req, runtime));
        }

        public async Task<UpdateXpackMonitorConfigResponse> UpdateXpackMonitorConfigWithOptionsAsync(string InstanceId, UpdateXpackMonitorConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateXpackMonitorConfigResponse>(await DoROARequestAsync("UpdateXpackMonitorConfig", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/xpack-monitor-config", "json", req, runtime));
        }

        public UpgradeEngineVersionResponse UpgradeEngineVersion(string InstanceId, UpgradeEngineVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpgradeEngineVersionWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<UpgradeEngineVersionResponse> UpgradeEngineVersionAsync(string InstanceId, UpgradeEngineVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpgradeEngineVersionWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public UpgradeEngineVersionResponse UpgradeEngineVersionWithOptions(string InstanceId, UpgradeEngineVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpgradeEngineVersionResponse>(DoROARequestWithForm("UpgradeEngineVersion", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/upgrade-version", "json", req, runtime));
        }

        public async Task<UpgradeEngineVersionResponse> UpgradeEngineVersionWithOptionsAsync(string InstanceId, UpgradeEngineVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["dryRun"] = request.DryRun;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpgradeEngineVersionResponse>(await DoROARequestWithFormAsync("UpgradeEngineVersion", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/actions/upgrade-version", "json", req, runtime));
        }

        public ValidateConnectionResponse ValidateConnection(string InstanceId, ValidateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ValidateConnectionWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ValidateConnectionResponse> ValidateConnectionAsync(string InstanceId, ValidateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ValidateConnectionWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ValidateConnectionResponse ValidateConnectionWithOptions(string InstanceId, ValidateConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ValidateConnectionResponse>(DoROARequest("ValidateConnection", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/validate-connection", "json", req, runtime));
        }

        public async Task<ValidateConnectionResponse> ValidateConnectionWithOptionsAsync(string InstanceId, ValidateConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ValidateConnectionResponse>(await DoROARequestAsync("ValidateConnection", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/logstashes/" + InstanceId + "/validate-connection", "json", req, runtime));
        }

        public ValidateShrinkNodesResponse ValidateShrinkNodes(string InstanceId, ValidateShrinkNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ValidateShrinkNodesWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ValidateShrinkNodesResponse> ValidateShrinkNodesAsync(string InstanceId, ValidateShrinkNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ValidateShrinkNodesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ValidateShrinkNodesResponse ValidateShrinkNodesWithOptions(string InstanceId, ValidateShrinkNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeType))
            {
                query["nodeType"] = request.NodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreStatus))
            {
                query["ignoreStatus"] = request.IgnoreStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ValidateShrinkNodesResponse>(DoROARequest("ValidateShrinkNodes", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/validate-shrink-nodes", "json", req, runtime));
        }

        public async Task<ValidateShrinkNodesResponse> ValidateShrinkNodesWithOptionsAsync(string InstanceId, ValidateShrinkNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeType))
            {
                query["nodeType"] = request.NodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreStatus))
            {
                query["ignoreStatus"] = request.IgnoreStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ValidateShrinkNodesResponse>(await DoROARequestAsync("ValidateShrinkNodes", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/validate-shrink-nodes", "json", req, runtime));
        }

        public ValidateSlrPermissionResponse ValidateSlrPermission(ValidateSlrPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ValidateSlrPermissionWithOptions(request, headers, runtime);
        }

        public async Task<ValidateSlrPermissionResponse> ValidateSlrPermissionAsync(ValidateSlrPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ValidateSlrPermissionWithOptionsAsync(request, headers, runtime);
        }

        public ValidateSlrPermissionResponse ValidateSlrPermissionWithOptions(ValidateSlrPermissionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rolename))
            {
                query["rolename"] = request.Rolename;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ValidateSlrPermissionResponse>(DoROARequest("ValidateSlrPermission", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/user/servicerolepermission", "json", req, runtime));
        }

        public async Task<ValidateSlrPermissionResponse> ValidateSlrPermissionWithOptionsAsync(ValidateSlrPermissionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rolename))
            {
                query["rolename"] = request.Rolename;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ValidateSlrPermissionResponse>(await DoROARequestAsync("ValidateSlrPermission", "2017-06-13", "HTTPS", "GET", "AK", "/openapi/user/servicerolepermission", "json", req, runtime));
        }

        public ValidateTransferableNodesResponse ValidateTransferableNodes(string InstanceId, ValidateTransferableNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ValidateTransferableNodesWithOptions(InstanceId, request, headers, runtime);
        }

        public async Task<ValidateTransferableNodesResponse> ValidateTransferableNodesAsync(string InstanceId, ValidateTransferableNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ValidateTransferableNodesWithOptionsAsync(InstanceId, request, headers, runtime);
        }

        public ValidateTransferableNodesResponse ValidateTransferableNodesWithOptions(string InstanceId, ValidateTransferableNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeType))
            {
                query["nodeType"] = request.NodeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ValidateTransferableNodesResponse>(DoROARequest("ValidateTransferableNodes", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/validate-transfer-nodes", "json", req, runtime));
        }

        public async Task<ValidateTransferableNodesResponse> ValidateTransferableNodesWithOptionsAsync(string InstanceId, ValidateTransferableNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            InstanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeType))
            {
                query["nodeType"] = request.NodeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ValidateTransferableNodesResponse>(await DoROARequestAsync("ValidateTransferableNodes", "2017-06-13", "HTTPS", "POST", "AK", "/openapi/instances/" + InstanceId + "/validate-transfer-nodes", "json", req, runtime));
        }

    }
}
