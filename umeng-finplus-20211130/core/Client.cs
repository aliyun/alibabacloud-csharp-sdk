// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Umeng_finplus20211130.Models;

namespace AlibabaCloud.SDK.Umeng_finplus20211130
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("umeng-finplus", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CancelComputeTaskByBcIdResponse CancelComputeTaskByBcIdWithOptions(CancelComputeTaskByBcIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BcId))
            {
                query["bcId"] = request.BcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelComputeTaskByBcId",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/cancelComputeTaskByBcId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelComputeTaskByBcIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelComputeTaskByBcIdResponse> CancelComputeTaskByBcIdWithOptionsAsync(CancelComputeTaskByBcIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BcId))
            {
                query["bcId"] = request.BcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelComputeTaskByBcId",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/cancelComputeTaskByBcId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelComputeTaskByBcIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelComputeTaskByBcIdResponse CancelComputeTaskByBcId(CancelComputeTaskByBcIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelComputeTaskByBcIdWithOptions(request, headers, runtime);
        }

        public async Task<CancelComputeTaskByBcIdResponse> CancelComputeTaskByBcIdAsync(CancelComputeTaskByBcIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelComputeTaskByBcIdWithOptionsAsync(request, headers, runtime);
        }

        public CreateComputeTaskByDataSetIdResponse CreateComputeTaskByDataSetIdWithOptions(CreateComputeTaskByDataSetIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchInfoForm))
            {
                body["BatchInfoForm"] = request.BatchInfoForm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remarks))
            {
                body["Remarks"] = request.Remarks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateComputeTaskByDataSetId",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/createComputeTaskByDataSetId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateComputeTaskByDataSetIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateComputeTaskByDataSetIdResponse> CreateComputeTaskByDataSetIdWithOptionsAsync(CreateComputeTaskByDataSetIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchInfoForm))
            {
                body["BatchInfoForm"] = request.BatchInfoForm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remarks))
            {
                body["Remarks"] = request.Remarks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateComputeTaskByDataSetId",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/createComputeTaskByDataSetId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateComputeTaskByDataSetIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateComputeTaskByDataSetIdResponse CreateComputeTaskByDataSetId(CreateComputeTaskByDataSetIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateComputeTaskByDataSetIdWithOptions(request, headers, runtime);
        }

        public async Task<CreateComputeTaskByDataSetIdResponse> CreateComputeTaskByDataSetIdAsync(CreateComputeTaskByDataSetIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateComputeTaskByDataSetIdWithOptionsAsync(request, headers, runtime);
        }

        public CreateComputeTaskByMultiDataSetIdResponse CreateComputeTaskByMultiDataSetIdWithOptions(CreateComputeTaskByMultiDataSetIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetIds))
            {
                body["dataSetIds"] = request.DataSetIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remarks))
            {
                body["remarks"] = request.Remarks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateComputeTaskByMultiDataSetId",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/createComputeTaskByMultiDataSetId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateComputeTaskByMultiDataSetIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateComputeTaskByMultiDataSetIdResponse> CreateComputeTaskByMultiDataSetIdWithOptionsAsync(CreateComputeTaskByMultiDataSetIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetIds))
            {
                body["dataSetIds"] = request.DataSetIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remarks))
            {
                body["remarks"] = request.Remarks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateComputeTaskByMultiDataSetId",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/createComputeTaskByMultiDataSetId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateComputeTaskByMultiDataSetIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateComputeTaskByMultiDataSetIdResponse CreateComputeTaskByMultiDataSetId(CreateComputeTaskByMultiDataSetIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateComputeTaskByMultiDataSetIdWithOptions(request, headers, runtime);
        }

        public async Task<CreateComputeTaskByMultiDataSetIdResponse> CreateComputeTaskByMultiDataSetIdAsync(CreateComputeTaskByMultiDataSetIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateComputeTaskByMultiDataSetIdWithOptionsAsync(request, headers, runtime);
        }

        public GetAvailableDataSetListResponse GetAvailableDataSetListWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAvailableDataSetList",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/getAvailableDataSetList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAvailableDataSetListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAvailableDataSetListResponse> GetAvailableDataSetListWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAvailableDataSetList",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/getAvailableDataSetList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAvailableDataSetListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAvailableDataSetListResponse GetAvailableDataSetList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAvailableDataSetListWithOptions(headers, runtime);
        }

        public async Task<GetAvailableDataSetListResponse> GetAvailableDataSetListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAvailableDataSetListWithOptionsAsync(headers, runtime);
        }

        public GetComputeResultResponse GetComputeResultWithOptions(GetComputeResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BcId))
            {
                query["bcId"] = request.BcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetComputeResult",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/getComputeTaskResult",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetComputeResultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetComputeResultResponse> GetComputeResultWithOptionsAsync(GetComputeResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BcId))
            {
                query["bcId"] = request.BcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetComputeResult",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/getComputeTaskResult",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetComputeResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetComputeResultResponse GetComputeResult(GetComputeResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetComputeResultWithOptions(request, headers, runtime);
        }

        public async Task<GetComputeResultResponse> GetComputeResultAsync(GetComputeResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetComputeResultWithOptionsAsync(request, headers, runtime);
        }

        public GetDataSetStatusResponse GetDataSetStatusWithOptions(GetDataSetStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetId))
            {
                query["dataSetId"] = request.DataSetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataSetStatus",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/getDataSetStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataSetStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDataSetStatusResponse> GetDataSetStatusWithOptionsAsync(GetDataSetStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetId))
            {
                query["dataSetId"] = request.DataSetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataSetStatus",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/getDataSetStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataSetStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDataSetStatusResponse GetDataSetStatus(GetDataSetStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDataSetStatusWithOptions(request, headers, runtime);
        }

        public async Task<GetDataSetStatusResponse> GetDataSetStatusAsync(GetDataSetStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDataSetStatusWithOptionsAsync(request, headers, runtime);
        }

        public GetDataSetStsAKResponse GetDataSetStsAKWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataSetStsAK",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/getDataSetStsAk",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataSetStsAKResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDataSetStsAKResponse> GetDataSetStsAKWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataSetStsAK",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/getDataSetStsAk",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataSetStsAKResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDataSetStsAKResponse GetDataSetStsAK()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDataSetStsAKWithOptions(headers, runtime);
        }

        public async Task<GetDataSetStsAKResponse> GetDataSetStsAKAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDataSetStsAKWithOptionsAsync(headers, runtime);
        }

        public SubmitDataSetTaskResponse SubmitDataSetTaskWithOptions(SubmitDataSetTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetType))
            {
                body["dataSetType"] = request.DataSetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdType))
            {
                body["idType"] = request.IdType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssFileName))
            {
                body["ossFileName"] = request.OssFileName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDataSetTask",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/submitDataSetTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDataSetTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitDataSetTaskResponse> SubmitDataSetTaskWithOptionsAsync(SubmitDataSetTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSetType))
            {
                body["dataSetType"] = request.DataSetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdType))
            {
                body["idType"] = request.IdType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssFileName))
            {
                body["ossFileName"] = request.OssFileName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDataSetTask",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/submitDataSetTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDataSetTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitDataSetTaskResponse SubmitDataSetTask(SubmitDataSetTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SubmitDataSetTaskWithOptions(request, headers, runtime);
        }

        public async Task<SubmitDataSetTaskResponse> SubmitDataSetTaskAsync(SubmitDataSetTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SubmitDataSetTaskWithOptionsAsync(request, headers, runtime);
        }

        public CancelYydTaskByBcIdResponse CancelYydTaskByBcIdWithOptions(CancelYydTaskByBcIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BcId))
            {
                query["bcId"] = request.BcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "cancelYydTaskByBcId",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/yyd/task/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelYydTaskByBcIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelYydTaskByBcIdResponse> CancelYydTaskByBcIdWithOptionsAsync(CancelYydTaskByBcIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BcId))
            {
                query["bcId"] = request.BcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "cancelYydTaskByBcId",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/yyd/task/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelYydTaskByBcIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelYydTaskByBcIdResponse CancelYydTaskByBcId(CancelYydTaskByBcIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelYydTaskByBcIdWithOptions(request, headers, runtime);
        }

        public async Task<CancelYydTaskByBcIdResponse> CancelYydTaskByBcIdAsync(CancelYydTaskByBcIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelYydTaskByBcIdWithOptionsAsync(request, headers, runtime);
        }

        public CreateYydComputeTaskResponse CreateYydComputeTaskWithOptions(CreateYydComputeTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remarks))
            {
                body["Remarks"] = request.Remarks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "createYydComputeTask",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/yyd/task/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateYydComputeTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateYydComputeTaskResponse> CreateYydComputeTaskWithOptionsAsync(CreateYydComputeTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["DatasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remarks))
            {
                body["Remarks"] = request.Remarks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "createYydComputeTask",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/yyd/task/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateYydComputeTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateYydComputeTaskResponse CreateYydComputeTask(CreateYydComputeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateYydComputeTaskWithOptions(request, headers, runtime);
        }

        public async Task<CreateYydComputeTaskResponse> CreateYydComputeTaskAsync(CreateYydComputeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateYydComputeTaskWithOptionsAsync(request, headers, runtime);
        }

        public CreateYydDataSetResponse CreateYydDataSetWithOptions(CreateYydDataSetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssFileName))
            {
                body["ossFileName"] = request.OssFileName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "createYydDataSet",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/yyd/dataset/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateYydDataSetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateYydDataSetResponse> CreateYydDataSetWithOptionsAsync(CreateYydDataSetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssFileName))
            {
                body["ossFileName"] = request.OssFileName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "createYydDataSet",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/yyd/dataset/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateYydDataSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateYydDataSetResponse CreateYydDataSet(CreateYydDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateYydDataSetWithOptions(request, headers, runtime);
        }

        public async Task<CreateYydDataSetResponse> CreateYydDataSetAsync(CreateYydDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateYydDataSetWithOptionsAsync(request, headers, runtime);
        }

        public ListYydComputeTaskListResponse ListYydComputeTaskListWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "listYydComputeTaskList",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/yyd/task/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListYydComputeTaskListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListYydComputeTaskListResponse> ListYydComputeTaskListWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "listYydComputeTaskList",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/yyd/task/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListYydComputeTaskListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListYydComputeTaskListResponse ListYydComputeTaskList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListYydComputeTaskListWithOptions(headers, runtime);
        }

        public async Task<ListYydComputeTaskListResponse> ListYydComputeTaskListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListYydComputeTaskListWithOptionsAsync(headers, runtime);
        }

        public ListYydDataSetResponse ListYydDataSetWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "listYydDataSet",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/yyd/dataset/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListYydDataSetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListYydDataSetResponse> ListYydDataSetWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "listYydDataSet",
                Version = "2021-11-30",
                Protocol = "HTTPS",
                Pathname = "/batch_compute/yyd/dataset/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListYydDataSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListYydDataSetResponse ListYydDataSet()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListYydDataSetWithOptions(headers, runtime);
        }

        public async Task<ListYydDataSetResponse> ListYydDataSetAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListYydDataSetWithOptionsAsync(headers, runtime);
        }

    }
}
