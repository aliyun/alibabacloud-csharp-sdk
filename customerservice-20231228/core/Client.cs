// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.CustomerService20231228.Models;

namespace AlibabaCloud.SDK.CustomerService20231228
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("customerservice", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public GetDownloadUrlResponse GetDownloadUrlWithOptions(GetDownloadUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileKey))
            {
                body["fileKey"] = request.FileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeOrderApplyCode))
            {
                body["freeOrderApplyCode"] = request.FreeOrderApplyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDownloadUrl",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/file/getDownloadUrl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDownloadUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDownloadUrlResponse> GetDownloadUrlWithOptionsAsync(GetDownloadUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileKey))
            {
                body["fileKey"] = request.FileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeOrderApplyCode))
            {
                body["freeOrderApplyCode"] = request.FreeOrderApplyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDownloadUrl",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/file/getDownloadUrl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDownloadUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDownloadUrlResponse GetDownloadUrl(GetDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDownloadUrlWithOptions(request, headers, runtime);
        }

        public async Task<GetDownloadUrlResponse> GetDownloadUrlAsync(GetDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDownloadUrlWithOptionsAsync(request, headers, runtime);
        }

        public GetEnterpriseSupportPlanDetailResponse GetEnterpriseSupportPlanDetailWithOptions(GetEnterpriseSupportPlanDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeOrderApplyCodes))
            {
                body["freeOrderApplyCodes"] = request.FreeOrderApplyCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderIds))
            {
                body["orderIds"] = request.OrderIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnterpriseSupportPlanDetail",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/enterpriseSupport/getEnterpriseSupportPlanDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnterpriseSupportPlanDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetEnterpriseSupportPlanDetailResponse> GetEnterpriseSupportPlanDetailWithOptionsAsync(GetEnterpriseSupportPlanDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeOrderApplyCodes))
            {
                body["freeOrderApplyCodes"] = request.FreeOrderApplyCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderIds))
            {
                body["orderIds"] = request.OrderIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnterpriseSupportPlanDetail",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/enterpriseSupport/getEnterpriseSupportPlanDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnterpriseSupportPlanDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetEnterpriseSupportPlanDetailResponse GetEnterpriseSupportPlanDetail(GetEnterpriseSupportPlanDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEnterpriseSupportPlanDetailWithOptions(request, headers, runtime);
        }

        public async Task<GetEnterpriseSupportPlanDetailResponse> GetEnterpriseSupportPlanDetailAsync(GetEnterpriseSupportPlanDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEnterpriseSupportPlanDetailWithOptionsAsync(request, headers, runtime);
        }

        public GetPreViewUrlResponse GetPreViewUrlWithOptions(GetPreViewUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyCode))
            {
                body["applyCode"] = request.ApplyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileKey))
            {
                body["fileKey"] = request.FileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPreViewUrl",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/file/getPreViewUrl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPreViewUrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPreViewUrlResponse> GetPreViewUrlWithOptionsAsync(GetPreViewUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyCode))
            {
                body["applyCode"] = request.ApplyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileKey))
            {
                body["fileKey"] = request.FileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPreViewUrl",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/file/getPreViewUrl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPreViewUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetPreViewUrlResponse GetPreViewUrl(GetPreViewUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPreViewUrlWithOptions(request, headers, runtime);
        }

        public async Task<GetPreViewUrlResponse> GetPreViewUrlAsync(GetPreViewUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPreViewUrlWithOptionsAsync(request, headers, runtime);
        }

        public GetServiceDetailResponse GetServiceDetailWithOptions(GetServiceDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyCode))
            {
                body["applyCode"] = request.ApplyCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceDetail",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/expert/service/getServiceDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetServiceDetailResponse> GetServiceDetailWithOptionsAsync(GetServiceDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyCode))
            {
                body["applyCode"] = request.ApplyCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceDetail",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/expert/service/getServiceDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetServiceDetailResponse GetServiceDetail(GetServiceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceDetailWithOptions(request, headers, runtime);
        }

        public async Task<GetServiceDetailResponse> GetServiceDetailAsync(GetServiceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceDetailWithOptionsAsync(request, headers, runtime);
        }

        public GetYunQiTaskByRecordIdResponse GetYunQiTaskByRecordIdWithOptions(GetYunQiTaskByRecordIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["recordId"] = request.RecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetYunQiTaskByRecordId",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/record/getYunQiTaskByRecordId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetYunQiTaskByRecordIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetYunQiTaskByRecordIdResponse> GetYunQiTaskByRecordIdWithOptionsAsync(GetYunQiTaskByRecordIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["recordId"] = request.RecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetYunQiTaskByRecordId",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/record/getYunQiTaskByRecordId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetYunQiTaskByRecordIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetYunQiTaskByRecordIdResponse GetYunQiTaskByRecordId(GetYunQiTaskByRecordIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetYunQiTaskByRecordIdWithOptions(request, headers, runtime);
        }

        public async Task<GetYunQiTaskByRecordIdResponse> GetYunQiTaskByRecordIdAsync(GetYunQiTaskByRecordIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetYunQiTaskByRecordIdWithOptionsAsync(request, headers, runtime);
        }

        public ListDocsGroupByYearResponse ListDocsGroupByYearWithOptions(ListDocsGroupByYearRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyCodes))
            {
                body["applyCodes"] = request.ApplyCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileNameKeyword))
            {
                body["fileNameKeyword"] = request.FileNameKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderIds))
            {
                body["orderIds"] = request.OrderIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDocsGroupByYear",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/file/listDocsGroupByYear",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDocsGroupByYearResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDocsGroupByYearResponse> ListDocsGroupByYearWithOptionsAsync(ListDocsGroupByYearRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyCodes))
            {
                body["applyCodes"] = request.ApplyCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileNameKeyword))
            {
                body["fileNameKeyword"] = request.FileNameKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderIds))
            {
                body["orderIds"] = request.OrderIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDocsGroupByYear",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/file/listDocsGroupByYear",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDocsGroupByYearResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDocsGroupByYearResponse ListDocsGroupByYear(ListDocsGroupByYearRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDocsGroupByYearWithOptions(request, headers, runtime);
        }

        public async Task<ListDocsGroupByYearResponse> ListDocsGroupByYearAsync(ListDocsGroupByYearRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDocsGroupByYearWithOptionsAsync(request, headers, runtime);
        }

        public ListEnterpriseSupportPlanResponse ListEnterpriseSupportPlanWithOptions(ListEnterpriseSupportPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnterpriseSupportPlan",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/enterpriseSupport/listEnterpriseSupportPlan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnterpriseSupportPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListEnterpriseSupportPlanResponse> ListEnterpriseSupportPlanWithOptionsAsync(ListEnterpriseSupportPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnterpriseSupportPlan",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/enterpriseSupport/listEnterpriseSupportPlan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnterpriseSupportPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListEnterpriseSupportPlanResponse ListEnterpriseSupportPlan(ListEnterpriseSupportPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEnterpriseSupportPlanWithOptions(request, headers, runtime);
        }

        public async Task<ListEnterpriseSupportPlanResponse> ListEnterpriseSupportPlanAsync(ListEnterpriseSupportPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEnterpriseSupportPlanWithOptionsAsync(request, headers, runtime);
        }

        public ListEnterpriseSupportPlanSimpleResponse ListEnterpriseSupportPlanSimpleWithOptions(ListEnterpriseSupportPlanSimpleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnterpriseSupportPlanSimple",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/enterpriseSupport/listEnterpriseSupportPlanSimple",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnterpriseSupportPlanSimpleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListEnterpriseSupportPlanSimpleResponse> ListEnterpriseSupportPlanSimpleWithOptionsAsync(ListEnterpriseSupportPlanSimpleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnterpriseSupportPlanSimple",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/enterpriseSupport/listEnterpriseSupportPlanSimple",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnterpriseSupportPlanSimpleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListEnterpriseSupportPlanSimpleResponse ListEnterpriseSupportPlanSimple(ListEnterpriseSupportPlanSimpleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEnterpriseSupportPlanSimpleWithOptions(request, headers, runtime);
        }

        public async Task<ListEnterpriseSupportPlanSimpleResponse> ListEnterpriseSupportPlanSimpleAsync(ListEnterpriseSupportPlanSimpleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEnterpriseSupportPlanSimpleWithOptionsAsync(request, headers, runtime);
        }

        public ListServiceApplyResponse ListServiceApplyWithOptions(ListServiceApplyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyType))
            {
                body["applyType"] = request.ApplyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceApply",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/expert/service/listServiceApply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceApplyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListServiceApplyResponse> ListServiceApplyWithOptionsAsync(ListServiceApplyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyType))
            {
                body["applyType"] = request.ApplyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceApply",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/expert/service/listServiceApply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceApplyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListServiceApplyResponse ListServiceApply(ListServiceApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServiceApplyWithOptions(request, headers, runtime);
        }

        public async Task<ListServiceApplyResponse> ListServiceApplyAsync(ListServiceApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServiceApplyWithOptionsAsync(request, headers, runtime);
        }

        public ListYunQiTaskByUidResponse ListYunQiTaskByUidWithOptions(ListYunQiTaskByUidRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                body["createTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                body["createTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeOrderApplyCodes))
            {
                body["freeOrderApplyCodes"] = request.FreeOrderApplyCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeOrderApplyIds))
            {
                body["freeOrderApplyIds"] = request.FreeOrderApplyIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderIds))
            {
                body["orderIds"] = request.OrderIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                body["statusList"] = request.StatusList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListYunQiTaskByUid",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/record/listYunQiTaskByUid",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListYunQiTaskByUidResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListYunQiTaskByUidResponse> ListYunQiTaskByUidWithOptionsAsync(ListYunQiTaskByUidRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                body["createTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                body["createTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeOrderApplyCodes))
            {
                body["freeOrderApplyCodes"] = request.FreeOrderApplyCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeOrderApplyIds))
            {
                body["freeOrderApplyIds"] = request.FreeOrderApplyIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderIds))
            {
                body["orderIds"] = request.OrderIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                body["statusList"] = request.StatusList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListYunQiTaskByUid",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/record/listYunQiTaskByUid",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListYunQiTaskByUidResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListYunQiTaskByUidResponse ListYunQiTaskByUid(ListYunQiTaskByUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListYunQiTaskByUidWithOptions(request, headers, runtime);
        }

        public async Task<ListYunQiTaskByUidResponse> ListYunQiTaskByUidAsync(ListYunQiTaskByUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListYunQiTaskByUidWithOptionsAsync(request, headers, runtime);
        }

        public MarkFileReadedResponse MarkFileReadedWithOptions(MarkFileReadedRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyCode))
            {
                body["applyCode"] = request.ApplyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MarkFileReaded",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/file/markFileReaded",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MarkFileReadedResponse>(CallApi(params_, req, runtime));
        }

        public async Task<MarkFileReadedResponse> MarkFileReadedWithOptionsAsync(MarkFileReadedRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyCode))
            {
                body["applyCode"] = request.ApplyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MarkFileReaded",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/file/markFileReaded",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MarkFileReadedResponse>(await CallApiAsync(params_, req, runtime));
        }

        public MarkFileReadedResponse MarkFileReaded(MarkFileReadedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return MarkFileReadedWithOptions(request, headers, runtime);
        }

        public async Task<MarkFileReadedResponse> MarkFileReadedAsync(MarkFileReadedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await MarkFileReadedWithOptionsAsync(request, headers, runtime);
        }

    }
}
