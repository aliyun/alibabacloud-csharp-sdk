// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.MaasAISearchProxy20260424.Models;

namespace AlibabaCloud.SDK.MaasAISearchProxy20260424
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("maasaisearchproxy", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>提交单条记录导入任务（通过AccessKey认证）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenDatasetImportDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenDatasetImportDataResponse
        /// </returns>
        public OpenDatasetImportDataResponse OpenDatasetImportDataWithOptions(OpenDatasetImportDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["datasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenDatasetImportData",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/api/v1/dataset/open/upsert",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenDatasetImportDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交单条记录导入任务（通过AccessKey认证）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenDatasetImportDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenDatasetImportDataResponse
        /// </returns>
        public async Task<OpenDatasetImportDataResponse> OpenDatasetImportDataWithOptionsAsync(OpenDatasetImportDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["datasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenDatasetImportData",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/api/v1/dataset/open/upsert",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenDatasetImportDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交单条记录导入任务（通过AccessKey认证）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenDatasetImportDataRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenDatasetImportDataResponse
        /// </returns>
        public OpenDatasetImportDataResponse OpenDatasetImportData(OpenDatasetImportDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OpenDatasetImportDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交单条记录导入任务（通过AccessKey认证）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenDatasetImportDataRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenDatasetImportDataResponse
        /// </returns>
        public async Task<OpenDatasetImportDataResponse> OpenDatasetImportDataAsync(OpenDatasetImportDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OpenDatasetImportDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据集资源 OSS 访问地址（通过AccessKey认证）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenDatasetResourceUrlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenDatasetResourceUrlResponse
        /// </returns>
        public OpenDatasetResourceUrlResponse OpenDatasetResourceUrlWithOptions(OpenDatasetResourceUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["datasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryKey))
            {
                body["primaryKey"] = request.PrimaryKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenDatasetResourceUrl",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/api/v1/dataset/open/resources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenDatasetResourceUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据集资源 OSS 访问地址（通过AccessKey认证）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenDatasetResourceUrlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenDatasetResourceUrlResponse
        /// </returns>
        public async Task<OpenDatasetResourceUrlResponse> OpenDatasetResourceUrlWithOptionsAsync(OpenDatasetResourceUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["datasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryKey))
            {
                body["primaryKey"] = request.PrimaryKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenDatasetResourceUrl",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/api/v1/dataset/open/resources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenDatasetResourceUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据集资源 OSS 访问地址（通过AccessKey认证）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenDatasetResourceUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenDatasetResourceUrlResponse
        /// </returns>
        public OpenDatasetResourceUrlResponse OpenDatasetResourceUrl(OpenDatasetResourceUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OpenDatasetResourceUrlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据集资源 OSS 访问地址（通过AccessKey认证）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenDatasetResourceUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenDatasetResourceUrlResponse
        /// </returns>
        public async Task<OpenDatasetResourceUrlResponse> OpenDatasetResourceUrlAsync(OpenDatasetResourceUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OpenDatasetResourceUrlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>联网搜API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WebSearchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WebSearchResponse
        /// </returns>
        public WebSearchResponse WebSearchWithOptions(WebSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDomain))
            {
                body["excludeDomain"] = request.ExcludeDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeDomain))
            {
                body["includeDomain"] = request.IncludeDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                body["searchType"] = request.SearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WebSearch",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/api/web-search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<WebSearchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>联网搜API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WebSearchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WebSearchResponse
        /// </returns>
        public async Task<WebSearchResponse> WebSearchWithOptionsAsync(WebSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDomain))
            {
                body["excludeDomain"] = request.ExcludeDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeDomain))
            {
                body["includeDomain"] = request.IncludeDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchType))
            {
                body["searchType"] = request.SearchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WebSearch",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/api/web-search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<WebSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>联网搜API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WebSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// WebSearchResponse
        /// </returns>
        public WebSearchResponse WebSearch(WebSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return WebSearchWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>联网搜API</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WebSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// WebSearchResponse
        /// </returns>
        public async Task<WebSearchResponse> WebSearchAsync(WebSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await WebSearchWithOptionsAsync(request, headers, runtime);
        }

    }
}
