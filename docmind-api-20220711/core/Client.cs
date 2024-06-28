// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Docmind_api20220711.Models;

namespace AlibabaCloud.SDK.Docmind_api20220711
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "docmind-api.aliyuncs.com"},
                {"ap-northeast-2-pop", "docmind-api.aliyuncs.com"},
                {"ap-south-1", "docmind-api.aliyuncs.com"},
                {"ap-southeast-1", "docmind-api.aliyuncs.com"},
                {"ap-southeast-2", "docmind-api.aliyuncs.com"},
                {"ap-southeast-3", "docmind-api.aliyuncs.com"},
                {"ap-southeast-5", "docmind-api.aliyuncs.com"},
                {"cn-beijing", "docmind-api.aliyuncs.com"},
                {"cn-beijing-finance-1", "docmind-api.aliyuncs.com"},
                {"cn-beijing-finance-pop", "docmind-api.aliyuncs.com"},
                {"cn-beijing-gov-1", "docmind-api.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "docmind-api.aliyuncs.com"},
                {"cn-chengdu", "docmind-api.aliyuncs.com"},
                {"cn-edge-1", "docmind-api.aliyuncs.com"},
                {"cn-fujian", "docmind-api.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "docmind-api.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "docmind-api.aliyuncs.com"},
                {"cn-hangzhou-finance", "docmind-api.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "docmind-api.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "docmind-api.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "docmind-api.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "docmind-api.aliyuncs.com"},
                {"cn-hangzhou-test-306", "docmind-api.aliyuncs.com"},
                {"cn-hongkong", "docmind-api.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "docmind-api.aliyuncs.com"},
                {"cn-huhehaote", "docmind-api.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "docmind-api.aliyuncs.com"},
                {"cn-north-2-gov-1", "docmind-api.aliyuncs.com"},
                {"cn-qingdao", "docmind-api.aliyuncs.com"},
                {"cn-qingdao-nebula", "docmind-api.aliyuncs.com"},
                {"cn-shanghai", "docmind-api.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "docmind-api.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "docmind-api.aliyuncs.com"},
                {"cn-shanghai-finance-1", "docmind-api.aliyuncs.com"},
                {"cn-shanghai-inner", "docmind-api.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "docmind-api.aliyuncs.com"},
                {"cn-shenzhen", "docmind-api.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "docmind-api.aliyuncs.com"},
                {"cn-shenzhen-inner", "docmind-api.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "docmind-api.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "docmind-api.aliyuncs.com"},
                {"cn-wuhan", "docmind-api.aliyuncs.com"},
                {"cn-wulanchabu", "docmind-api.aliyuncs.com"},
                {"cn-yushanfang", "docmind-api.aliyuncs.com"},
                {"cn-zhangbei", "docmind-api.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "docmind-api.aliyuncs.com"},
                {"cn-zhangjiakou", "docmind-api.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "docmind-api.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "docmind-api.aliyuncs.com"},
                {"eu-central-1", "docmind-api.aliyuncs.com"},
                {"eu-west-1", "docmind-api.aliyuncs.com"},
                {"eu-west-1-oxs", "docmind-api.aliyuncs.com"},
                {"me-east-1", "docmind-api.aliyuncs.com"},
                {"rus-west-1-pop", "docmind-api.aliyuncs.com"},
                {"us-east-1", "docmind-api.aliyuncs.com"},
                {"us-west-1", "docmind-api.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("docmind-api", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 整票识别
         *
         * @param tmpReq AyncTradeDocumentPackageExtractSmartAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AyncTradeDocumentPackageExtractSmartAppResponse
         */
        public AyncTradeDocumentPackageExtractSmartAppResponse AyncTradeDocumentPackageExtractSmartAppWithOptions(AyncTradeDocumentPackageExtractSmartAppRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AyncTradeDocumentPackageExtractSmartAppShrinkRequest request = new AyncTradeDocumentPackageExtractSmartAppShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomExtractionRange))
            {
                request.CustomExtractionRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomExtractionRange, "CustomExtractionRange", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomExtractionRangeShrink))
            {
                query["CustomExtractionRange"] = request.CustomExtractionRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                query["Option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AyncTradeDocumentPackageExtractSmartApp",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AyncTradeDocumentPackageExtractSmartAppResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 整票识别
         *
         * @param tmpReq AyncTradeDocumentPackageExtractSmartAppRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AyncTradeDocumentPackageExtractSmartAppResponse
         */
        public async Task<AyncTradeDocumentPackageExtractSmartAppResponse> AyncTradeDocumentPackageExtractSmartAppWithOptionsAsync(AyncTradeDocumentPackageExtractSmartAppRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AyncTradeDocumentPackageExtractSmartAppShrinkRequest request = new AyncTradeDocumentPackageExtractSmartAppShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomExtractionRange))
            {
                request.CustomExtractionRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomExtractionRange, "CustomExtractionRange", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomExtractionRangeShrink))
            {
                query["CustomExtractionRange"] = request.CustomExtractionRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                query["Option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AyncTradeDocumentPackageExtractSmartApp",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AyncTradeDocumentPackageExtractSmartAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 整票识别
         *
         * @param request AyncTradeDocumentPackageExtractSmartAppRequest
         * @return AyncTradeDocumentPackageExtractSmartAppResponse
         */
        public AyncTradeDocumentPackageExtractSmartAppResponse AyncTradeDocumentPackageExtractSmartApp(AyncTradeDocumentPackageExtractSmartAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AyncTradeDocumentPackageExtractSmartAppWithOptions(request, runtime);
        }

        /**
         * @summary 整票识别
         *
         * @param request AyncTradeDocumentPackageExtractSmartAppRequest
         * @return AyncTradeDocumentPackageExtractSmartAppResponse
         */
        public async Task<AyncTradeDocumentPackageExtractSmartAppResponse> AyncTradeDocumentPackageExtractSmartAppAsync(AyncTradeDocumentPackageExtractSmartAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AyncTradeDocumentPackageExtractSmartAppWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 文档智能解析结果查询
         *
         * @param request GetDocStructureResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocStructureResultResponse
         */
        public GetDocStructureResultResponse GetDocStructureResultWithOptions(GetDocStructureResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageStrategy))
            {
                query["ImageStrategy"] = request.ImageStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevealMarkdown))
            {
                query["RevealMarkdown"] = request.RevealMarkdown;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocStructureResult",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocStructureResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 文档智能解析结果查询
         *
         * @param request GetDocStructureResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocStructureResultResponse
         */
        public async Task<GetDocStructureResultResponse> GetDocStructureResultWithOptionsAsync(GetDocStructureResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageStrategy))
            {
                query["ImageStrategy"] = request.ImageStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevealMarkdown))
            {
                query["RevealMarkdown"] = request.RevealMarkdown;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocStructureResult",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocStructureResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 文档智能解析结果查询
         *
         * @param request GetDocStructureResultRequest
         * @return GetDocStructureResultResponse
         */
        public GetDocStructureResultResponse GetDocStructureResult(GetDocStructureResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDocStructureResultWithOptions(request, runtime);
        }

        /**
         * @summary 文档智能解析结果查询
         *
         * @param request GetDocStructureResultRequest
         * @return GetDocStructureResultResponse
         */
        public async Task<GetDocStructureResultResponse> GetDocStructureResultAsync(GetDocStructureResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDocStructureResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 文档对比结果查询
         *
         * @param request GetDocumentCompareResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocumentCompareResultResponse
         */
        public GetDocumentCompareResultResponse GetDocumentCompareResultWithOptions(GetDocumentCompareResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentCompareResult",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentCompareResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 文档对比结果查询
         *
         * @param request GetDocumentCompareResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocumentCompareResultResponse
         */
        public async Task<GetDocumentCompareResultResponse> GetDocumentCompareResultWithOptionsAsync(GetDocumentCompareResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentCompareResult",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentCompareResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 文档对比结果查询
         *
         * @param request GetDocumentCompareResultRequest
         * @return GetDocumentCompareResultResponse
         */
        public GetDocumentCompareResultResponse GetDocumentCompareResult(GetDocumentCompareResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDocumentCompareResultWithOptions(request, runtime);
        }

        /**
         * @summary 文档对比结果查询
         *
         * @param request GetDocumentCompareResultRequest
         * @return GetDocumentCompareResultResponse
         */
        public async Task<GetDocumentCompareResultResponse> GetDocumentCompareResultAsync(GetDocumentCompareResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDocumentCompareResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 文档转换结果查询
         *
         * @param request GetDocumentConvertResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocumentConvertResultResponse
         */
        public GetDocumentConvertResultResponse GetDocumentConvertResultWithOptions(GetDocumentConvertResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentConvertResult",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentConvertResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 文档转换结果查询
         *
         * @param request GetDocumentConvertResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocumentConvertResultResponse
         */
        public async Task<GetDocumentConvertResultResponse> GetDocumentConvertResultWithOptionsAsync(GetDocumentConvertResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentConvertResult",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentConvertResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 文档转换结果查询
         *
         * @param request GetDocumentConvertResultRequest
         * @return GetDocumentConvertResultResponse
         */
        public GetDocumentConvertResultResponse GetDocumentConvertResult(GetDocumentConvertResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDocumentConvertResultWithOptions(request, runtime);
        }

        /**
         * @summary 文档转换结果查询
         *
         * @param request GetDocumentConvertResultRequest
         * @return GetDocumentConvertResultResponse
         */
        public async Task<GetDocumentConvertResultResponse> GetDocumentConvertResultAsync(GetDocumentConvertResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDocumentConvertResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 文档抽取结果查询
         *
         * @param request GetDocumentExtractResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocumentExtractResultResponse
         */
        public GetDocumentExtractResultResponse GetDocumentExtractResultWithOptions(GetDocumentExtractResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentExtractResult",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentExtractResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 文档抽取结果查询
         *
         * @param request GetDocumentExtractResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocumentExtractResultResponse
         */
        public async Task<GetDocumentExtractResultResponse> GetDocumentExtractResultWithOptionsAsync(GetDocumentExtractResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentExtractResult",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentExtractResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 文档抽取结果查询
         *
         * @param request GetDocumentExtractResultRequest
         * @return GetDocumentExtractResultResponse
         */
        public GetDocumentExtractResultResponse GetDocumentExtractResult(GetDocumentExtractResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDocumentExtractResultWithOptions(request, runtime);
        }

        /**
         * @summary 文档抽取结果查询
         *
         * @param request GetDocumentExtractResultRequest
         * @return GetDocumentExtractResultResponse
         */
        public async Task<GetDocumentExtractResultResponse> GetDocumentExtractResultAsync(GetDocumentExtractResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDocumentExtractResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary openmind
         *
         * @param request GetPageNumRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPageNumResponse
         */
        public GetPageNumResponse GetPageNumWithOptions(GetPageNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPageNum",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPageNumResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary openmind
         *
         * @param request GetPageNumRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPageNumResponse
         */
        public async Task<GetPageNumResponse> GetPageNumWithOptionsAsync(GetPageNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPageNum",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPageNumResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary openmind
         *
         * @param request GetPageNumRequest
         * @return GetPageNumResponse
         */
        public GetPageNumResponse GetPageNum(GetPageNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPageNumWithOptions(request, runtime);
        }

        /**
         * @summary openmind
         *
         * @param request GetPageNumRequest
         * @return GetPageNumResponse
         */
        public async Task<GetPageNumResponse> GetPageNumAsync(GetPageNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPageNumWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 表格智能解析结果查询
         *
         * @param request GetTableUnderstandingResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTableUnderstandingResultResponse
         */
        public GetTableUnderstandingResultResponse GetTableUnderstandingResultWithOptions(GetTableUnderstandingResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableUnderstandingResult",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableUnderstandingResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 表格智能解析结果查询
         *
         * @param request GetTableUnderstandingResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTableUnderstandingResultResponse
         */
        public async Task<GetTableUnderstandingResultResponse> GetTableUnderstandingResultWithOptionsAsync(GetTableUnderstandingResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableUnderstandingResult",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableUnderstandingResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 表格智能解析结果查询
         *
         * @param request GetTableUnderstandingResultRequest
         * @return GetTableUnderstandingResultResponse
         */
        public GetTableUnderstandingResultResponse GetTableUnderstandingResult(GetTableUnderstandingResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTableUnderstandingResultWithOptions(request, runtime);
        }

        /**
         * @summary 表格智能解析结果查询
         *
         * @param request GetTableUnderstandingResultRequest
         * @return GetTableUnderstandingResultResponse
         */
        public async Task<GetTableUnderstandingResultResponse> GetTableUnderstandingResultAsync(GetTableUnderstandingResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTableUnderstandingResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 图片转excel
         *
         * @param tmpReq SubmitConvertImageToExcelJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitConvertImageToExcelJobResponse
         */
        public SubmitConvertImageToExcelJobResponse SubmitConvertImageToExcelJobWithOptions(SubmitConvertImageToExcelJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitConvertImageToExcelJobShrinkRequest request = new SubmitConvertImageToExcelJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageNames))
            {
                request.ImageNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageNames, "ImageNames", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageUrls))
            {
                request.ImageUrlsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageUrls, "ImageUrls", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceMergeExcel))
            {
                query["ForceMergeExcel"] = request.ForceMergeExcel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNameExtension))
            {
                query["ImageNameExtension"] = request.ImageNameExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNamesShrink))
            {
                query["ImageNames"] = request.ImageNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlsShrink))
            {
                query["ImageUrls"] = request.ImageUrlsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitConvertImageToExcelJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitConvertImageToExcelJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 图片转excel
         *
         * @param tmpReq SubmitConvertImageToExcelJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitConvertImageToExcelJobResponse
         */
        public async Task<SubmitConvertImageToExcelJobResponse> SubmitConvertImageToExcelJobWithOptionsAsync(SubmitConvertImageToExcelJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitConvertImageToExcelJobShrinkRequest request = new SubmitConvertImageToExcelJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageNames))
            {
                request.ImageNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageNames, "ImageNames", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageUrls))
            {
                request.ImageUrlsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageUrls, "ImageUrls", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceMergeExcel))
            {
                query["ForceMergeExcel"] = request.ForceMergeExcel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNameExtension))
            {
                query["ImageNameExtension"] = request.ImageNameExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNamesShrink))
            {
                query["ImageNames"] = request.ImageNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlsShrink))
            {
                query["ImageUrls"] = request.ImageUrlsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitConvertImageToExcelJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitConvertImageToExcelJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 图片转excel
         *
         * @param request SubmitConvertImageToExcelJobRequest
         * @return SubmitConvertImageToExcelJobResponse
         */
        public SubmitConvertImageToExcelJobResponse SubmitConvertImageToExcelJob(SubmitConvertImageToExcelJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitConvertImageToExcelJobWithOptions(request, runtime);
        }

        /**
         * @summary 图片转excel
         *
         * @param request SubmitConvertImageToExcelJobRequest
         * @return SubmitConvertImageToExcelJobResponse
         */
        public async Task<SubmitConvertImageToExcelJobResponse> SubmitConvertImageToExcelJobAsync(SubmitConvertImageToExcelJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitConvertImageToExcelJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 图片转markdown
         *
         * @param tmpReq SubmitConvertImageToMarkdownJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitConvertImageToMarkdownJobResponse
         */
        public SubmitConvertImageToMarkdownJobResponse SubmitConvertImageToMarkdownJobWithOptions(SubmitConvertImageToMarkdownJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitConvertImageToMarkdownJobShrinkRequest request = new SubmitConvertImageToMarkdownJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageNames))
            {
                request.ImageNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageNames, "ImageNames", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageUrls))
            {
                request.ImageUrlsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageUrls, "ImageUrls", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNameExtension))
            {
                query["ImageNameExtension"] = request.ImageNameExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNamesShrink))
            {
                query["ImageNames"] = request.ImageNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlsShrink))
            {
                query["ImageUrls"] = request.ImageUrlsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitConvertImageToMarkdownJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitConvertImageToMarkdownJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 图片转markdown
         *
         * @param tmpReq SubmitConvertImageToMarkdownJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitConvertImageToMarkdownJobResponse
         */
        public async Task<SubmitConvertImageToMarkdownJobResponse> SubmitConvertImageToMarkdownJobWithOptionsAsync(SubmitConvertImageToMarkdownJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitConvertImageToMarkdownJobShrinkRequest request = new SubmitConvertImageToMarkdownJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageNames))
            {
                request.ImageNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageNames, "ImageNames", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageUrls))
            {
                request.ImageUrlsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageUrls, "ImageUrls", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNameExtension))
            {
                query["ImageNameExtension"] = request.ImageNameExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNamesShrink))
            {
                query["ImageNames"] = request.ImageNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlsShrink))
            {
                query["ImageUrls"] = request.ImageUrlsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitConvertImageToMarkdownJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitConvertImageToMarkdownJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 图片转markdown
         *
         * @param request SubmitConvertImageToMarkdownJobRequest
         * @return SubmitConvertImageToMarkdownJobResponse
         */
        public SubmitConvertImageToMarkdownJobResponse SubmitConvertImageToMarkdownJob(SubmitConvertImageToMarkdownJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitConvertImageToMarkdownJobWithOptions(request, runtime);
        }

        /**
         * @summary 图片转markdown
         *
         * @param request SubmitConvertImageToMarkdownJobRequest
         * @return SubmitConvertImageToMarkdownJobResponse
         */
        public async Task<SubmitConvertImageToMarkdownJobResponse> SubmitConvertImageToMarkdownJobAsync(SubmitConvertImageToMarkdownJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitConvertImageToMarkdownJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 图片转pdf
         *
         * @param tmpReq SubmitConvertImageToPdfJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitConvertImageToPdfJobResponse
         */
        public SubmitConvertImageToPdfJobResponse SubmitConvertImageToPdfJobWithOptions(SubmitConvertImageToPdfJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitConvertImageToPdfJobShrinkRequest request = new SubmitConvertImageToPdfJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageNames))
            {
                request.ImageNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageNames, "ImageNames", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageUrls))
            {
                request.ImageUrlsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageUrls, "ImageUrls", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNameExtension))
            {
                query["ImageNameExtension"] = request.ImageNameExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNamesShrink))
            {
                query["ImageNames"] = request.ImageNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlsShrink))
            {
                query["ImageUrls"] = request.ImageUrlsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitConvertImageToPdfJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitConvertImageToPdfJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 图片转pdf
         *
         * @param tmpReq SubmitConvertImageToPdfJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitConvertImageToPdfJobResponse
         */
        public async Task<SubmitConvertImageToPdfJobResponse> SubmitConvertImageToPdfJobWithOptionsAsync(SubmitConvertImageToPdfJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitConvertImageToPdfJobShrinkRequest request = new SubmitConvertImageToPdfJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageNames))
            {
                request.ImageNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageNames, "ImageNames", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageUrls))
            {
                request.ImageUrlsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageUrls, "ImageUrls", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNameExtension))
            {
                query["ImageNameExtension"] = request.ImageNameExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNamesShrink))
            {
                query["ImageNames"] = request.ImageNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlsShrink))
            {
                query["ImageUrls"] = request.ImageUrlsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitConvertImageToPdfJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitConvertImageToPdfJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 图片转pdf
         *
         * @param request SubmitConvertImageToPdfJobRequest
         * @return SubmitConvertImageToPdfJobResponse
         */
        public SubmitConvertImageToPdfJobResponse SubmitConvertImageToPdfJob(SubmitConvertImageToPdfJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitConvertImageToPdfJobWithOptions(request, runtime);
        }

        /**
         * @summary 图片转pdf
         *
         * @param request SubmitConvertImageToPdfJobRequest
         * @return SubmitConvertImageToPdfJobResponse
         */
        public async Task<SubmitConvertImageToPdfJobResponse> SubmitConvertImageToPdfJobAsync(SubmitConvertImageToPdfJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitConvertImageToPdfJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 图片转word
         *
         * @param tmpReq SubmitConvertImageToWordJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitConvertImageToWordJobResponse
         */
        public SubmitConvertImageToWordJobResponse SubmitConvertImageToWordJobWithOptions(SubmitConvertImageToWordJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitConvertImageToWordJobShrinkRequest request = new SubmitConvertImageToWordJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageNames))
            {
                request.ImageNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageNames, "ImageNames", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageUrls))
            {
                request.ImageUrlsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageUrls, "ImageUrls", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNameExtension))
            {
                query["ImageNameExtension"] = request.ImageNameExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNamesShrink))
            {
                query["ImageNames"] = request.ImageNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlsShrink))
            {
                query["ImageUrls"] = request.ImageUrlsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitConvertImageToWordJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitConvertImageToWordJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 图片转word
         *
         * @param tmpReq SubmitConvertImageToWordJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitConvertImageToWordJobResponse
         */
        public async Task<SubmitConvertImageToWordJobResponse> SubmitConvertImageToWordJobWithOptionsAsync(SubmitConvertImageToWordJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitConvertImageToWordJobShrinkRequest request = new SubmitConvertImageToWordJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageNames))
            {
                request.ImageNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageNames, "ImageNames", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageUrls))
            {
                request.ImageUrlsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageUrls, "ImageUrls", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNameExtension))
            {
                query["ImageNameExtension"] = request.ImageNameExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNamesShrink))
            {
                query["ImageNames"] = request.ImageNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlsShrink))
            {
                query["ImageUrls"] = request.ImageUrlsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitConvertImageToWordJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitConvertImageToWordJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 图片转word
         *
         * @param request SubmitConvertImageToWordJobRequest
         * @return SubmitConvertImageToWordJobResponse
         */
        public SubmitConvertImageToWordJobResponse SubmitConvertImageToWordJob(SubmitConvertImageToWordJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitConvertImageToWordJobWithOptions(request, runtime);
        }

        /**
         * @summary 图片转word
         *
         * @param request SubmitConvertImageToWordJobRequest
         * @return SubmitConvertImageToWordJobResponse
         */
        public async Task<SubmitConvertImageToWordJobResponse> SubmitConvertImageToWordJobAsync(SubmitConvertImageToWordJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitConvertImageToWordJobWithOptionsAsync(request, runtime);
        }

        /**
         * @summary pdf转excel
         *
         * @param request SubmitConvertPdfToExcelJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitConvertPdfToExcelJobResponse
         */
        public SubmitConvertPdfToExcelJobResponse SubmitConvertPdfToExcelJobWithOptions(SubmitConvertPdfToExcelJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceExportInnerImage))
            {
                query["ForceExportInnerImage"] = request.ForceExportInnerImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceMergeExcel))
            {
                query["ForceMergeExcel"] = request.ForceMergeExcel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitConvertPdfToExcelJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitConvertPdfToExcelJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary pdf转excel
         *
         * @param request SubmitConvertPdfToExcelJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitConvertPdfToExcelJobResponse
         */
        public async Task<SubmitConvertPdfToExcelJobResponse> SubmitConvertPdfToExcelJobWithOptionsAsync(SubmitConvertPdfToExcelJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceExportInnerImage))
            {
                query["ForceExportInnerImage"] = request.ForceExportInnerImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceMergeExcel))
            {
                query["ForceMergeExcel"] = request.ForceMergeExcel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitConvertPdfToExcelJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitConvertPdfToExcelJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary pdf转excel
         *
         * @param request SubmitConvertPdfToExcelJobRequest
         * @return SubmitConvertPdfToExcelJobResponse
         */
        public SubmitConvertPdfToExcelJobResponse SubmitConvertPdfToExcelJob(SubmitConvertPdfToExcelJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitConvertPdfToExcelJobWithOptions(request, runtime);
        }

        /**
         * @summary pdf转excel
         *
         * @param request SubmitConvertPdfToExcelJobRequest
         * @return SubmitConvertPdfToExcelJobResponse
         */
        public async Task<SubmitConvertPdfToExcelJobResponse> SubmitConvertPdfToExcelJobAsync(SubmitConvertPdfToExcelJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitConvertPdfToExcelJobWithOptionsAsync(request, runtime);
        }

        public SubmitConvertPdfToExcelJobResponse SubmitConvertPdfToExcelJobAdvance(SubmitConvertPdfToExcelJobAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "docmind-api",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SubmitConvertPdfToExcelJobRequest submitConvertPdfToExcelJobReq = new SubmitConvertPdfToExcelJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, submitConvertPdfToExcelJobReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                submitConvertPdfToExcelJobReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            SubmitConvertPdfToExcelJobResponse submitConvertPdfToExcelJobResp = SubmitConvertPdfToExcelJobWithOptions(submitConvertPdfToExcelJobReq, runtime);
            return submitConvertPdfToExcelJobResp;
        }

        public async Task<SubmitConvertPdfToExcelJobResponse> SubmitConvertPdfToExcelJobAdvanceAsync(SubmitConvertPdfToExcelJobAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "docmind-api",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SubmitConvertPdfToExcelJobRequest submitConvertPdfToExcelJobReq = new SubmitConvertPdfToExcelJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, submitConvertPdfToExcelJobReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                submitConvertPdfToExcelJobReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            SubmitConvertPdfToExcelJobResponse submitConvertPdfToExcelJobResp = await SubmitConvertPdfToExcelJobWithOptionsAsync(submitConvertPdfToExcelJobReq, runtime);
            return submitConvertPdfToExcelJobResp;
        }

        /**
         * @summary pdf转图片
         *
         * @param request SubmitConvertPdfToImageJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitConvertPdfToImageJobResponse
         */
        public SubmitConvertPdfToImageJobResponse SubmitConvertPdfToImageJobWithOptions(SubmitConvertPdfToImageJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitConvertPdfToImageJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitConvertPdfToImageJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary pdf转图片
         *
         * @param request SubmitConvertPdfToImageJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitConvertPdfToImageJobResponse
         */
        public async Task<SubmitConvertPdfToImageJobResponse> SubmitConvertPdfToImageJobWithOptionsAsync(SubmitConvertPdfToImageJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitConvertPdfToImageJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitConvertPdfToImageJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary pdf转图片
         *
         * @param request SubmitConvertPdfToImageJobRequest
         * @return SubmitConvertPdfToImageJobResponse
         */
        public SubmitConvertPdfToImageJobResponse SubmitConvertPdfToImageJob(SubmitConvertPdfToImageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitConvertPdfToImageJobWithOptions(request, runtime);
        }

        /**
         * @summary pdf转图片
         *
         * @param request SubmitConvertPdfToImageJobRequest
         * @return SubmitConvertPdfToImageJobResponse
         */
        public async Task<SubmitConvertPdfToImageJobResponse> SubmitConvertPdfToImageJobAsync(SubmitConvertPdfToImageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitConvertPdfToImageJobWithOptionsAsync(request, runtime);
        }

        public SubmitConvertPdfToImageJobResponse SubmitConvertPdfToImageJobAdvance(SubmitConvertPdfToImageJobAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "docmind-api",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SubmitConvertPdfToImageJobRequest submitConvertPdfToImageJobReq = new SubmitConvertPdfToImageJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, submitConvertPdfToImageJobReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                submitConvertPdfToImageJobReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            SubmitConvertPdfToImageJobResponse submitConvertPdfToImageJobResp = SubmitConvertPdfToImageJobWithOptions(submitConvertPdfToImageJobReq, runtime);
            return submitConvertPdfToImageJobResp;
        }

        public async Task<SubmitConvertPdfToImageJobResponse> SubmitConvertPdfToImageJobAdvanceAsync(SubmitConvertPdfToImageJobAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "docmind-api",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SubmitConvertPdfToImageJobRequest submitConvertPdfToImageJobReq = new SubmitConvertPdfToImageJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, submitConvertPdfToImageJobReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                submitConvertPdfToImageJobReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            SubmitConvertPdfToImageJobResponse submitConvertPdfToImageJobResp = await SubmitConvertPdfToImageJobWithOptionsAsync(submitConvertPdfToImageJobReq, runtime);
            return submitConvertPdfToImageJobResp;
        }

        /**
         * @summary pdf转markdown
         *
         * @param request SubmitConvertPdfToMarkdownJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitConvertPdfToMarkdownJobResponse
         */
        public SubmitConvertPdfToMarkdownJobResponse SubmitConvertPdfToMarkdownJobWithOptions(SubmitConvertPdfToMarkdownJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitConvertPdfToMarkdownJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitConvertPdfToMarkdownJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary pdf转markdown
         *
         * @param request SubmitConvertPdfToMarkdownJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitConvertPdfToMarkdownJobResponse
         */
        public async Task<SubmitConvertPdfToMarkdownJobResponse> SubmitConvertPdfToMarkdownJobWithOptionsAsync(SubmitConvertPdfToMarkdownJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitConvertPdfToMarkdownJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitConvertPdfToMarkdownJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary pdf转markdown
         *
         * @param request SubmitConvertPdfToMarkdownJobRequest
         * @return SubmitConvertPdfToMarkdownJobResponse
         */
        public SubmitConvertPdfToMarkdownJobResponse SubmitConvertPdfToMarkdownJob(SubmitConvertPdfToMarkdownJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitConvertPdfToMarkdownJobWithOptions(request, runtime);
        }

        /**
         * @summary pdf转markdown
         *
         * @param request SubmitConvertPdfToMarkdownJobRequest
         * @return SubmitConvertPdfToMarkdownJobResponse
         */
        public async Task<SubmitConvertPdfToMarkdownJobResponse> SubmitConvertPdfToMarkdownJobAsync(SubmitConvertPdfToMarkdownJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitConvertPdfToMarkdownJobWithOptionsAsync(request, runtime);
        }

        public SubmitConvertPdfToMarkdownJobResponse SubmitConvertPdfToMarkdownJobAdvance(SubmitConvertPdfToMarkdownJobAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "docmind-api",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SubmitConvertPdfToMarkdownJobRequest submitConvertPdfToMarkdownJobReq = new SubmitConvertPdfToMarkdownJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, submitConvertPdfToMarkdownJobReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                submitConvertPdfToMarkdownJobReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            SubmitConvertPdfToMarkdownJobResponse submitConvertPdfToMarkdownJobResp = SubmitConvertPdfToMarkdownJobWithOptions(submitConvertPdfToMarkdownJobReq, runtime);
            return submitConvertPdfToMarkdownJobResp;
        }

        public async Task<SubmitConvertPdfToMarkdownJobResponse> SubmitConvertPdfToMarkdownJobAdvanceAsync(SubmitConvertPdfToMarkdownJobAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "docmind-api",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SubmitConvertPdfToMarkdownJobRequest submitConvertPdfToMarkdownJobReq = new SubmitConvertPdfToMarkdownJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, submitConvertPdfToMarkdownJobReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                submitConvertPdfToMarkdownJobReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            SubmitConvertPdfToMarkdownJobResponse submitConvertPdfToMarkdownJobResp = await SubmitConvertPdfToMarkdownJobWithOptionsAsync(submitConvertPdfToMarkdownJobReq, runtime);
            return submitConvertPdfToMarkdownJobResp;
        }

        /**
         * @summary pdf转word
         *
         * @param request SubmitConvertPdfToWordJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitConvertPdfToWordJobResponse
         */
        public SubmitConvertPdfToWordJobResponse SubmitConvertPdfToWordJobWithOptions(SubmitConvertPdfToWordJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceExportInnerImage))
            {
                query["ForceExportInnerImage"] = request.ForceExportInnerImage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitConvertPdfToWordJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitConvertPdfToWordJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary pdf转word
         *
         * @param request SubmitConvertPdfToWordJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitConvertPdfToWordJobResponse
         */
        public async Task<SubmitConvertPdfToWordJobResponse> SubmitConvertPdfToWordJobWithOptionsAsync(SubmitConvertPdfToWordJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceExportInnerImage))
            {
                query["ForceExportInnerImage"] = request.ForceExportInnerImage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitConvertPdfToWordJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitConvertPdfToWordJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary pdf转word
         *
         * @param request SubmitConvertPdfToWordJobRequest
         * @return SubmitConvertPdfToWordJobResponse
         */
        public SubmitConvertPdfToWordJobResponse SubmitConvertPdfToWordJob(SubmitConvertPdfToWordJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitConvertPdfToWordJobWithOptions(request, runtime);
        }

        /**
         * @summary pdf转word
         *
         * @param request SubmitConvertPdfToWordJobRequest
         * @return SubmitConvertPdfToWordJobResponse
         */
        public async Task<SubmitConvertPdfToWordJobResponse> SubmitConvertPdfToWordJobAsync(SubmitConvertPdfToWordJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitConvertPdfToWordJobWithOptionsAsync(request, runtime);
        }

        public SubmitConvertPdfToWordJobResponse SubmitConvertPdfToWordJobAdvance(SubmitConvertPdfToWordJobAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "docmind-api",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SubmitConvertPdfToWordJobRequest submitConvertPdfToWordJobReq = new SubmitConvertPdfToWordJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, submitConvertPdfToWordJobReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                submitConvertPdfToWordJobReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            SubmitConvertPdfToWordJobResponse submitConvertPdfToWordJobResp = SubmitConvertPdfToWordJobWithOptions(submitConvertPdfToWordJobReq, runtime);
            return submitConvertPdfToWordJobResp;
        }

        public async Task<SubmitConvertPdfToWordJobResponse> SubmitConvertPdfToWordJobAdvanceAsync(SubmitConvertPdfToWordJobAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "docmind-api",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SubmitConvertPdfToWordJobRequest submitConvertPdfToWordJobReq = new SubmitConvertPdfToWordJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, submitConvertPdfToWordJobReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                submitConvertPdfToWordJobReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            SubmitConvertPdfToWordJobResponse submitConvertPdfToWordJobResp = await SubmitConvertPdfToWordJobWithOptionsAsync(submitConvertPdfToWordJobReq, runtime);
            return submitConvertPdfToWordJobResp;
        }

        /**
         * @summary 电子解析
         *
         * @param request SubmitDigitalDocStructureJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitDigitalDocStructureJobResponse
         */
        public SubmitDigitalDocStructureJobResponse SubmitDigitalDocStructureJobWithOptions(SubmitDigitalDocStructureJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileNameExtension))
            {
                query["FileNameExtension"] = request.FileNameExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageStrategy))
            {
                query["ImageStrategy"] = request.ImageStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevealMarkdown))
            {
                query["RevealMarkdown"] = request.RevealMarkdown;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDigitalDocStructureJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDigitalDocStructureJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 电子解析
         *
         * @param request SubmitDigitalDocStructureJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitDigitalDocStructureJobResponse
         */
        public async Task<SubmitDigitalDocStructureJobResponse> SubmitDigitalDocStructureJobWithOptionsAsync(SubmitDigitalDocStructureJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileNameExtension))
            {
                query["FileNameExtension"] = request.FileNameExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageStrategy))
            {
                query["ImageStrategy"] = request.ImageStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevealMarkdown))
            {
                query["RevealMarkdown"] = request.RevealMarkdown;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDigitalDocStructureJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDigitalDocStructureJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 电子解析
         *
         * @param request SubmitDigitalDocStructureJobRequest
         * @return SubmitDigitalDocStructureJobResponse
         */
        public SubmitDigitalDocStructureJobResponse SubmitDigitalDocStructureJob(SubmitDigitalDocStructureJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitDigitalDocStructureJobWithOptions(request, runtime);
        }

        /**
         * @summary 电子解析
         *
         * @param request SubmitDigitalDocStructureJobRequest
         * @return SubmitDigitalDocStructureJobResponse
         */
        public async Task<SubmitDigitalDocStructureJobResponse> SubmitDigitalDocStructureJobAsync(SubmitDigitalDocStructureJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitDigitalDocStructureJobWithOptionsAsync(request, runtime);
        }

        public SubmitDigitalDocStructureJobResponse SubmitDigitalDocStructureJobAdvance(SubmitDigitalDocStructureJobAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "docmind-api",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SubmitDigitalDocStructureJobRequest submitDigitalDocStructureJobReq = new SubmitDigitalDocStructureJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, submitDigitalDocStructureJobReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                submitDigitalDocStructureJobReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            SubmitDigitalDocStructureJobResponse submitDigitalDocStructureJobResp = SubmitDigitalDocStructureJobWithOptions(submitDigitalDocStructureJobReq, runtime);
            return submitDigitalDocStructureJobResp;
        }

        public async Task<SubmitDigitalDocStructureJobResponse> SubmitDigitalDocStructureJobAdvanceAsync(SubmitDigitalDocStructureJobAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "docmind-api",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SubmitDigitalDocStructureJobRequest submitDigitalDocStructureJobReq = new SubmitDigitalDocStructureJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, submitDigitalDocStructureJobReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                submitDigitalDocStructureJobReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            SubmitDigitalDocStructureJobResponse submitDigitalDocStructureJobResp = await SubmitDigitalDocStructureJobWithOptionsAsync(submitDigitalDocStructureJobReq, runtime);
            return submitDigitalDocStructureJobResp;
        }

        /**
         * @summary 文档智能解析
         *
         * @param request SubmitDocStructureJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitDocStructureJobResponse
         */
        public SubmitDocStructureJobResponse SubmitDocStructureJobWithOptions(SubmitDocStructureJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowPptFormat))
            {
                query["AllowPptFormat"] = request.AllowPptFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileNameExtension))
            {
                query["FileNameExtension"] = request.FileNameExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormulaEnhancement))
            {
                query["FormulaEnhancement"] = request.FormulaEnhancement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructureType))
            {
                query["StructureType"] = request.StructureType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDocStructureJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDocStructureJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 文档智能解析
         *
         * @param request SubmitDocStructureJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitDocStructureJobResponse
         */
        public async Task<SubmitDocStructureJobResponse> SubmitDocStructureJobWithOptionsAsync(SubmitDocStructureJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowPptFormat))
            {
                query["AllowPptFormat"] = request.AllowPptFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileNameExtension))
            {
                query["FileNameExtension"] = request.FileNameExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormulaEnhancement))
            {
                query["FormulaEnhancement"] = request.FormulaEnhancement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StructureType))
            {
                query["StructureType"] = request.StructureType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDocStructureJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDocStructureJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 文档智能解析
         *
         * @param request SubmitDocStructureJobRequest
         * @return SubmitDocStructureJobResponse
         */
        public SubmitDocStructureJobResponse SubmitDocStructureJob(SubmitDocStructureJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitDocStructureJobWithOptions(request, runtime);
        }

        /**
         * @summary 文档智能解析
         *
         * @param request SubmitDocStructureJobRequest
         * @return SubmitDocStructureJobResponse
         */
        public async Task<SubmitDocStructureJobResponse> SubmitDocStructureJobAsync(SubmitDocStructureJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitDocStructureJobWithOptionsAsync(request, runtime);
        }

        public SubmitDocStructureJobResponse SubmitDocStructureJobAdvance(SubmitDocStructureJobAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "docmind-api",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SubmitDocStructureJobRequest submitDocStructureJobReq = new SubmitDocStructureJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, submitDocStructureJobReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                submitDocStructureJobReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            SubmitDocStructureJobResponse submitDocStructureJobResp = SubmitDocStructureJobWithOptions(submitDocStructureJobReq, runtime);
            return submitDocStructureJobResp;
        }

        public async Task<SubmitDocStructureJobResponse> SubmitDocStructureJobAdvanceAsync(SubmitDocStructureJobAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "docmind-api",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SubmitDocStructureJobRequest submitDocStructureJobReq = new SubmitDocStructureJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, submitDocStructureJobReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                submitDocStructureJobReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            SubmitDocStructureJobResponse submitDocStructureJobResp = await SubmitDocStructureJobWithOptionsAsync(submitDocStructureJobReq, runtime);
            return submitDocStructureJobResp;
        }

        /**
         * @summary 文档抽取
         *
         * @param request SubmitDocumentExtractJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitDocumentExtractJobResponse
         */
        public SubmitDocumentExtractJobResponse SubmitDocumentExtractJobWithOptions(SubmitDocumentExtractJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileNameExtension))
            {
                query["FileNameExtension"] = request.FileNameExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDocumentExtractJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDocumentExtractJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 文档抽取
         *
         * @param request SubmitDocumentExtractJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitDocumentExtractJobResponse
         */
        public async Task<SubmitDocumentExtractJobResponse> SubmitDocumentExtractJobWithOptionsAsync(SubmitDocumentExtractJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileNameExtension))
            {
                query["FileNameExtension"] = request.FileNameExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDocumentExtractJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDocumentExtractJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 文档抽取
         *
         * @param request SubmitDocumentExtractJobRequest
         * @return SubmitDocumentExtractJobResponse
         */
        public SubmitDocumentExtractJobResponse SubmitDocumentExtractJob(SubmitDocumentExtractJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitDocumentExtractJobWithOptions(request, runtime);
        }

        /**
         * @summary 文档抽取
         *
         * @param request SubmitDocumentExtractJobRequest
         * @return SubmitDocumentExtractJobResponse
         */
        public async Task<SubmitDocumentExtractJobResponse> SubmitDocumentExtractJobAsync(SubmitDocumentExtractJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitDocumentExtractJobWithOptionsAsync(request, runtime);
        }

        public SubmitDocumentExtractJobResponse SubmitDocumentExtractJobAdvance(SubmitDocumentExtractJobAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "docmind-api",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SubmitDocumentExtractJobRequest submitDocumentExtractJobReq = new SubmitDocumentExtractJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, submitDocumentExtractJobReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                submitDocumentExtractJobReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            SubmitDocumentExtractJobResponse submitDocumentExtractJobResp = SubmitDocumentExtractJobWithOptions(submitDocumentExtractJobReq, runtime);
            return submitDocumentExtractJobResp;
        }

        public async Task<SubmitDocumentExtractJobResponse> SubmitDocumentExtractJobAdvanceAsync(SubmitDocumentExtractJobAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "docmind-api",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SubmitDocumentExtractJobRequest submitDocumentExtractJobReq = new SubmitDocumentExtractJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, submitDocumentExtractJobReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                submitDocumentExtractJobReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            SubmitDocumentExtractJobResponse submitDocumentExtractJobResp = await SubmitDocumentExtractJobWithOptionsAsync(submitDocumentExtractJobReq, runtime);
            return submitDocumentExtractJobResp;
        }

        /**
         * @summary 表格智能解析
         *
         * @param request SubmitTableUnderstandingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitTableUnderstandingJobResponse
         */
        public SubmitTableUnderstandingJobResponse SubmitTableUnderstandingJobWithOptions(SubmitTableUnderstandingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileNameExtension))
            {
                query["FileNameExtension"] = request.FileNameExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitTableUnderstandingJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitTableUnderstandingJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 表格智能解析
         *
         * @param request SubmitTableUnderstandingJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitTableUnderstandingJobResponse
         */
        public async Task<SubmitTableUnderstandingJobResponse> SubmitTableUnderstandingJobWithOptionsAsync(SubmitTableUnderstandingJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileNameExtension))
            {
                query["FileNameExtension"] = request.FileNameExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["FileUrl"] = request.FileUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitTableUnderstandingJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitTableUnderstandingJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 表格智能解析
         *
         * @param request SubmitTableUnderstandingJobRequest
         * @return SubmitTableUnderstandingJobResponse
         */
        public SubmitTableUnderstandingJobResponse SubmitTableUnderstandingJob(SubmitTableUnderstandingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitTableUnderstandingJobWithOptions(request, runtime);
        }

        /**
         * @summary 表格智能解析
         *
         * @param request SubmitTableUnderstandingJobRequest
         * @return SubmitTableUnderstandingJobResponse
         */
        public async Task<SubmitTableUnderstandingJobResponse> SubmitTableUnderstandingJobAsync(SubmitTableUnderstandingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitTableUnderstandingJobWithOptionsAsync(request, runtime);
        }

        public SubmitTableUnderstandingJobResponse SubmitTableUnderstandingJobAdvance(SubmitTableUnderstandingJobAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "docmind-api",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SubmitTableUnderstandingJobRequest submitTableUnderstandingJobReq = new SubmitTableUnderstandingJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, submitTableUnderstandingJobReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                submitTableUnderstandingJobReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            SubmitTableUnderstandingJobResponse submitTableUnderstandingJobResp = SubmitTableUnderstandingJobWithOptions(submitTableUnderstandingJobReq, runtime);
            return submitTableUnderstandingJobResp;
        }

        public async Task<SubmitTableUnderstandingJobResponse> SubmitTableUnderstandingJobAdvanceAsync(SubmitTableUnderstandingJobAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "docmind-api",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SubmitTableUnderstandingJobRequest submitTableUnderstandingJobReq = new SubmitTableUnderstandingJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, submitTableUnderstandingJobReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                submitTableUnderstandingJobReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            SubmitTableUnderstandingJobResponse submitTableUnderstandingJobResp = await SubmitTableUnderstandingJobWithOptionsAsync(submitTableUnderstandingJobReq, runtime);
            return submitTableUnderstandingJobResp;
        }

    }
}
