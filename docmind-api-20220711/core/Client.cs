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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>整票识别</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AyncTradeDocumentPackageExtractSmartAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AyncTradeDocumentPackageExtractSmartAppResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>整票识别</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AyncTradeDocumentPackageExtractSmartAppRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AyncTradeDocumentPackageExtractSmartAppResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>整票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AyncTradeDocumentPackageExtractSmartAppRequest
        /// </param>
        /// 
        /// <returns>
        /// AyncTradeDocumentPackageExtractSmartAppResponse
        /// </returns>
        public AyncTradeDocumentPackageExtractSmartAppResponse AyncTradeDocumentPackageExtractSmartApp(AyncTradeDocumentPackageExtractSmartAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AyncTradeDocumentPackageExtractSmartAppWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>整票识别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AyncTradeDocumentPackageExtractSmartAppRequest
        /// </param>
        /// 
        /// <returns>
        /// AyncTradeDocumentPackageExtractSmartAppResponse
        /// </returns>
        public async Task<AyncTradeDocumentPackageExtractSmartAppResponse> AyncTradeDocumentPackageExtractSmartAppAsync(AyncTradeDocumentPackageExtractSmartAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AyncTradeDocumentPackageExtractSmartAppWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档结构化流式接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocParserResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocParserResultResponse
        /// </returns>
        public GetDocParserResultResponse GetDocParserResultWithOptions(GetDocParserResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutNum))
            {
                query["LayoutNum"] = request.LayoutNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutStepSize))
            {
                query["LayoutStepSize"] = request.LayoutStepSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocParserResult",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocParserResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档结构化流式接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocParserResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocParserResultResponse
        /// </returns>
        public async Task<GetDocParserResultResponse> GetDocParserResultWithOptionsAsync(GetDocParserResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutNum))
            {
                query["LayoutNum"] = request.LayoutNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LayoutStepSize))
            {
                query["LayoutStepSize"] = request.LayoutStepSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocParserResult",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocParserResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档结构化流式接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocParserResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocParserResultResponse
        /// </returns>
        public GetDocParserResultResponse GetDocParserResult(GetDocParserResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDocParserResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档结构化流式接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocParserResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocParserResultResponse
        /// </returns>
        public async Task<GetDocParserResultResponse> GetDocParserResultAsync(GetDocParserResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDocParserResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档智能解析结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocStructureResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocStructureResultResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseUrlResponseBody))
            {
                query["UseUrlResponseBody"] = request.UseUrlResponseBody;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档智能解析结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocStructureResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocStructureResultResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseUrlResponseBody))
            {
                query["UseUrlResponseBody"] = request.UseUrlResponseBody;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档智能解析结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocStructureResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocStructureResultResponse
        /// </returns>
        public GetDocStructureResultResponse GetDocStructureResult(GetDocStructureResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDocStructureResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档智能解析结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocStructureResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocStructureResultResponse
        /// </returns>
        public async Task<GetDocStructureResultResponse> GetDocStructureResultAsync(GetDocStructureResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDocStructureResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档对比结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentCompareResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentCompareResultResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档对比结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentCompareResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentCompareResultResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档对比结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentCompareResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentCompareResultResponse
        /// </returns>
        public GetDocumentCompareResultResponse GetDocumentCompareResult(GetDocumentCompareResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDocumentCompareResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档对比结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentCompareResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentCompareResultResponse
        /// </returns>
        public async Task<GetDocumentCompareResultResponse> GetDocumentCompareResultAsync(GetDocumentCompareResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDocumentCompareResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档转换结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentConvertResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentConvertResultResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档转换结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentConvertResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentConvertResultResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档转换结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentConvertResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentConvertResultResponse
        /// </returns>
        public GetDocumentConvertResultResponse GetDocumentConvertResult(GetDocumentConvertResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDocumentConvertResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档转换结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentConvertResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentConvertResultResponse
        /// </returns>
        public async Task<GetDocumentConvertResultResponse> GetDocumentConvertResultAsync(GetDocumentConvertResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDocumentConvertResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档抽取结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentExtractResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentExtractResultResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档抽取结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentExtractResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentExtractResultResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档抽取结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentExtractResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentExtractResultResponse
        /// </returns>
        public GetDocumentExtractResultResponse GetDocumentExtractResult(GetDocumentExtractResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDocumentExtractResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档抽取结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentExtractResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentExtractResultResponse
        /// </returns>
        public async Task<GetDocumentExtractResultResponse> GetDocumentExtractResultAsync(GetDocumentExtractResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDocumentExtractResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>openmind</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPageNumRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPageNumResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>openmind</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPageNumRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPageNumResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>openmind</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPageNumRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPageNumResponse
        /// </returns>
        public GetPageNumResponse GetPageNum(GetPageNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPageNumWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>openmind</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPageNumRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPageNumResponse
        /// </returns>
        public async Task<GetPageNumResponse> GetPageNumAsync(GetPageNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPageNumWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>表格智能解析结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableUnderstandingResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTableUnderstandingResultResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>表格智能解析结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableUnderstandingResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTableUnderstandingResultResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>表格智能解析结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableUnderstandingResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTableUnderstandingResultResponse
        /// </returns>
        public GetTableUnderstandingResultResponse GetTableUnderstandingResult(GetTableUnderstandingResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTableUnderstandingResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>表格智能解析结果查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableUnderstandingResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTableUnderstandingResultResponse
        /// </returns>
        public async Task<GetTableUnderstandingResultResponse> GetTableUnderstandingResultAsync(GetTableUnderstandingResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTableUnderstandingResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档智能解析处理状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDocParserStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDocParserStatusResponse
        /// </returns>
        public QueryDocParserStatusResponse QueryDocParserStatusWithOptions(QueryDocParserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryDocParserStatus",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDocParserStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档智能解析处理状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDocParserStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDocParserStatusResponse
        /// </returns>
        public async Task<QueryDocParserStatusResponse> QueryDocParserStatusWithOptionsAsync(QueryDocParserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryDocParserStatus",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDocParserStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档智能解析处理状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDocParserStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDocParserStatusResponse
        /// </returns>
        public QueryDocParserStatusResponse QueryDocParserStatus(QueryDocParserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDocParserStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文档智能解析处理状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDocParserStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDocParserStatusResponse
        /// </returns>
        public async Task<QueryDocParserStatusResponse> QueryDocParserStatusAsync(QueryDocParserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDocParserStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片转excel</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitConvertImageToExcelJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertImageToExcelJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片转excel</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitConvertImageToExcelJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertImageToExcelJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片转excel</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertImageToExcelJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertImageToExcelJobResponse
        /// </returns>
        public SubmitConvertImageToExcelJobResponse SubmitConvertImageToExcelJob(SubmitConvertImageToExcelJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitConvertImageToExcelJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片转excel</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertImageToExcelJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertImageToExcelJobResponse
        /// </returns>
        public async Task<SubmitConvertImageToExcelJobResponse> SubmitConvertImageToExcelJobAsync(SubmitConvertImageToExcelJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitConvertImageToExcelJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片转markdown</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitConvertImageToMarkdownJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertImageToMarkdownJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片转markdown</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitConvertImageToMarkdownJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertImageToMarkdownJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片转markdown</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertImageToMarkdownJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertImageToMarkdownJobResponse
        /// </returns>
        public SubmitConvertImageToMarkdownJobResponse SubmitConvertImageToMarkdownJob(SubmitConvertImageToMarkdownJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitConvertImageToMarkdownJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片转markdown</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertImageToMarkdownJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertImageToMarkdownJobResponse
        /// </returns>
        public async Task<SubmitConvertImageToMarkdownJobResponse> SubmitConvertImageToMarkdownJobAsync(SubmitConvertImageToMarkdownJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitConvertImageToMarkdownJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片转pdf</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitConvertImageToPdfJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertImageToPdfJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片转pdf</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitConvertImageToPdfJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertImageToPdfJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片转pdf</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertImageToPdfJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertImageToPdfJobResponse
        /// </returns>
        public SubmitConvertImageToPdfJobResponse SubmitConvertImageToPdfJob(SubmitConvertImageToPdfJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitConvertImageToPdfJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片转pdf</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertImageToPdfJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertImageToPdfJobResponse
        /// </returns>
        public async Task<SubmitConvertImageToPdfJobResponse> SubmitConvertImageToPdfJobAsync(SubmitConvertImageToPdfJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitConvertImageToPdfJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片转word</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitConvertImageToWordJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertImageToWordJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片转word</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitConvertImageToWordJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertImageToWordJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片转word</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertImageToWordJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertImageToWordJobResponse
        /// </returns>
        public SubmitConvertImageToWordJobResponse SubmitConvertImageToWordJob(SubmitConvertImageToWordJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitConvertImageToWordJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片转word</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertImageToWordJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertImageToWordJobResponse
        /// </returns>
        public async Task<SubmitConvertImageToWordJobResponse> SubmitConvertImageToWordJobAsync(SubmitConvertImageToWordJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitConvertImageToWordJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pdf转excel</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertPdfToExcelJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertPdfToExcelJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pdf转excel</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertPdfToExcelJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertPdfToExcelJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pdf转excel</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertPdfToExcelJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertPdfToExcelJobResponse
        /// </returns>
        public SubmitConvertPdfToExcelJobResponse SubmitConvertPdfToExcelJob(SubmitConvertPdfToExcelJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitConvertPdfToExcelJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pdf转excel</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertPdfToExcelJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertPdfToExcelJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pdf转图片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertPdfToImageJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertPdfToImageJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pdf转图片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertPdfToImageJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertPdfToImageJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pdf转图片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertPdfToImageJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertPdfToImageJobResponse
        /// </returns>
        public SubmitConvertPdfToImageJobResponse SubmitConvertPdfToImageJob(SubmitConvertPdfToImageJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitConvertPdfToImageJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pdf转图片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertPdfToImageJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertPdfToImageJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pdf转markdown</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertPdfToMarkdownJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertPdfToMarkdownJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pdf转markdown</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertPdfToMarkdownJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertPdfToMarkdownJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pdf转markdown</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertPdfToMarkdownJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertPdfToMarkdownJobResponse
        /// </returns>
        public SubmitConvertPdfToMarkdownJobResponse SubmitConvertPdfToMarkdownJob(SubmitConvertPdfToMarkdownJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitConvertPdfToMarkdownJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pdf转markdown</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertPdfToMarkdownJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertPdfToMarkdownJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pdf转word</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertPdfToWordJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertPdfToWordJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormulaEnhancement))
            {
                query["FormulaEnhancement"] = request.FormulaEnhancement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                query["Option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pdf转word</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertPdfToWordJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertPdfToWordJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormulaEnhancement))
            {
                query["FormulaEnhancement"] = request.FormulaEnhancement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                query["Option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pdf转word</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertPdfToWordJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertPdfToWordJobResponse
        /// </returns>
        public SubmitConvertPdfToWordJobResponse SubmitConvertPdfToWordJob(SubmitConvertPdfToWordJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitConvertPdfToWordJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pdf转word</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitConvertPdfToWordJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitConvertPdfToWordJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>电子解析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitDigitalDocStructureJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitDigitalDocStructureJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevealMarkdown))
            {
                query["RevealMarkdown"] = request.RevealMarkdown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseUrlResponseBody))
            {
                query["UseUrlResponseBody"] = request.UseUrlResponseBody;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>电子解析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitDigitalDocStructureJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitDigitalDocStructureJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RevealMarkdown))
            {
                query["RevealMarkdown"] = request.RevealMarkdown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseUrlResponseBody))
            {
                query["UseUrlResponseBody"] = request.UseUrlResponseBody;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>电子解析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitDigitalDocStructureJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitDigitalDocStructureJobResponse
        /// </returns>
        public SubmitDigitalDocStructureJobResponse SubmitDigitalDocStructureJob(SubmitDigitalDocStructureJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitDigitalDocStructureJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>电子解析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitDigitalDocStructureJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitDigitalDocStructureJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档智能解析流式输出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitDocParserJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitDocParserJobResponse
        /// </returns>
        public SubmitDocParserJobResponse SubmitDocParserJobWithOptions(SubmitDocParserJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormulaEnhancement))
            {
                query["FormulaEnhancement"] = request.FormulaEnhancement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmEnhancement))
            {
                query["LlmEnhancement"] = request.LlmEnhancement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                query["Option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDocParserJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDocParserJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档智能解析流式输出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitDocParserJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitDocParserJobResponse
        /// </returns>
        public async Task<SubmitDocParserJobResponse> SubmitDocParserJobWithOptionsAsync(SubmitDocParserJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormulaEnhancement))
            {
                query["FormulaEnhancement"] = request.FormulaEnhancement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LlmEnhancement))
            {
                query["LlmEnhancement"] = request.LlmEnhancement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Option))
            {
                query["Option"] = request.Option;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDocParserJob",
                Version = "2022-07-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDocParserJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档智能解析流式输出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitDocParserJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitDocParserJobResponse
        /// </returns>
        public SubmitDocParserJobResponse SubmitDocParserJob(SubmitDocParserJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitDocParserJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档智能解析流式输出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitDocParserJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitDocParserJobResponse
        /// </returns>
        public async Task<SubmitDocParserJobResponse> SubmitDocParserJobAsync(SubmitDocParserJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitDocParserJobWithOptionsAsync(request, runtime);
        }

        public SubmitDocParserJobResponse SubmitDocParserJobAdvance(SubmitDocParserJobAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            SubmitDocParserJobRequest submitDocParserJobReq = new SubmitDocParserJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, submitDocParserJobReq);
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
                submitDocParserJobReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            SubmitDocParserJobResponse submitDocParserJobResp = SubmitDocParserJobWithOptions(submitDocParserJobReq, runtime);
            return submitDocParserJobResp;
        }

        public async Task<SubmitDocParserJobResponse> SubmitDocParserJobAdvanceAsync(SubmitDocParserJobAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            SubmitDocParserJobRequest submitDocParserJobReq = new SubmitDocParserJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, submitDocParserJobReq);
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
                submitDocParserJobReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            SubmitDocParserJobResponse submitDocParserJobResp = await SubmitDocParserJobWithOptionsAsync(submitDocParserJobReq, runtime);
            return submitDocParserJobResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档智能解析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitDocStructureJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitDocStructureJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档智能解析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitDocStructureJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitDocStructureJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageIndex))
            {
                query["PageIndex"] = request.PageIndex;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档智能解析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitDocStructureJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitDocStructureJobResponse
        /// </returns>
        public SubmitDocStructureJobResponse SubmitDocStructureJob(SubmitDocStructureJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitDocStructureJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档智能解析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitDocStructureJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitDocStructureJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档抽取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitDocumentExtractJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitDocumentExtractJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档抽取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitDocumentExtractJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitDocumentExtractJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档抽取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitDocumentExtractJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitDocumentExtractJobResponse
        /// </returns>
        public SubmitDocumentExtractJobResponse SubmitDocumentExtractJob(SubmitDocumentExtractJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitDocumentExtractJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>文档抽取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitDocumentExtractJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitDocumentExtractJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>表格智能解析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitTableUnderstandingJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitTableUnderstandingJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>表格智能解析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitTableUnderstandingJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitTableUnderstandingJobResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucket))
            {
                query["OssBucket"] = request.OssBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssEndpoint))
            {
                query["OssEndpoint"] = request.OssEndpoint;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>表格智能解析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitTableUnderstandingJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitTableUnderstandingJobResponse
        /// </returns>
        public SubmitTableUnderstandingJobResponse SubmitTableUnderstandingJob(SubmitTableUnderstandingJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitTableUnderstandingJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>表格智能解析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitTableUnderstandingJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitTableUnderstandingJobResponse
        /// </returns>
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
