// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cloudcontrol20220830.Models;

namespace AlibabaCloud.SDK.Cloudcontrol20220830
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cloudcontrol", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 取消任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelTaskResponse
         */
        public CancelTaskResponse CancelTaskWithOptions(string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelTask",
                Version = "2022-08-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/operation/cancel",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 取消任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelTaskResponse
         */
        public async Task<CancelTaskResponse> CancelTaskWithOptionsAsync(string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelTask",
                Version = "2022-08-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/operation/cancel",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 取消任务
         *
         * @return CancelTaskResponse
         */
        public CancelTaskResponse CancelTask(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelTaskWithOptions(taskId, headers, runtime);
        }

        /**
         * @summary 取消任务
         *
         * @return CancelTaskResponse
         */
        public async Task<CancelTaskResponse> CancelTaskAsync(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelTaskWithOptionsAsync(taskId, headers, runtime);
        }

        /**
         * @summary 创建资源
         *
         * @param requestPath the whole path of resource string
         * @param request CreateResourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateResourceResponse
         */
        public CreateResourceResponse CreateResourceWithOptions(string requestPath, CreateResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResource",
                Version = "2022-08-30",
                Protocol = "HTTPS",
                Pathname = "" + requestPath,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建资源
         *
         * @param requestPath the whole path of resource string
         * @param request CreateResourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateResourceResponse
         */
        public async Task<CreateResourceResponse> CreateResourceWithOptionsAsync(string requestPath, CreateResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResource",
                Version = "2022-08-30",
                Protocol = "HTTPS",
                Pathname = "" + requestPath,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建资源
         *
         * @param requestPath the whole path of resource string
         * @param request CreateResourceRequest
         * @return CreateResourceResponse
         */
        public CreateResourceResponse CreateResource(string requestPath, CreateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateResourceWithOptions(requestPath, request, headers, runtime);
        }

        /**
         * @summary 创建资源
         *
         * @param requestPath the whole path of resource string
         * @param request CreateResourceRequest
         * @return CreateResourceResponse
         */
        public async Task<CreateResourceResponse> CreateResourceAsync(string requestPath, CreateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateResourceWithOptionsAsync(requestPath, request, headers, runtime);
        }

        /**
         * @summary 删除资源
         *
         * @param requestPath the whole path of resource string
         * @param request DeleteResourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteResourceResponse
         */
        public DeleteResourceResponse DeleteResourceWithOptions(string requestPath, DeleteResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResource",
                Version = "2022-08-30",
                Protocol = "HTTPS",
                Pathname = "" + requestPath,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除资源
         *
         * @param requestPath the whole path of resource string
         * @param request DeleteResourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteResourceResponse
         */
        public async Task<DeleteResourceResponse> DeleteResourceWithOptionsAsync(string requestPath, DeleteResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResource",
                Version = "2022-08-30",
                Protocol = "HTTPS",
                Pathname = "" + requestPath,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除资源
         *
         * @param requestPath the whole path of resource string
         * @param request DeleteResourceRequest
         * @return DeleteResourceResponse
         */
        public DeleteResourceResponse DeleteResource(string requestPath, DeleteResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteResourceWithOptions(requestPath, request, headers, runtime);
        }

        /**
         * @summary 删除资源
         *
         * @param requestPath the whole path of resource string
         * @param request DeleteResourceRequest
         * @return DeleteResourceResponse
         */
        public async Task<DeleteResourceResponse> DeleteResourceAsync(string requestPath, DeleteResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteResourceWithOptionsAsync(requestPath, request, headers, runtime);
        }

        /**
         * @summary 查询价格
         *
         * @param requestPath the whole path of resource string
         * @param tmpReq GetPriceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPriceResponse
         */
        public GetPriceResponse GetPriceWithOptions(string requestPath, GetPriceRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetPriceShrinkRequest request = new GetPriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceAttributes))
            {
                request.ResourceAttributesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceAttributes, "resourceAttributes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAttributesShrink))
            {
                query["resourceAttributes"] = request.ResourceAttributesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPrice",
                Version = "2022-08-30",
                Protocol = "HTTPS",
                Pathname = "" + requestPath,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPriceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询价格
         *
         * @param requestPath the whole path of resource string
         * @param tmpReq GetPriceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPriceResponse
         */
        public async Task<GetPriceResponse> GetPriceWithOptionsAsync(string requestPath, GetPriceRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetPriceShrinkRequest request = new GetPriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceAttributes))
            {
                request.ResourceAttributesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceAttributes, "resourceAttributes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAttributesShrink))
            {
                query["resourceAttributes"] = request.ResourceAttributesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPrice",
                Version = "2022-08-30",
                Protocol = "HTTPS",
                Pathname = "" + requestPath,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询价格
         *
         * @param requestPath the whole path of resource string
         * @param request GetPriceRequest
         * @return GetPriceResponse
         */
        public GetPriceResponse GetPrice(string requestPath, GetPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPriceWithOptions(requestPath, request, headers, runtime);
        }

        /**
         * @summary 查询价格
         *
         * @param requestPath the whole path of resource string
         * @param request GetPriceRequest
         * @return GetPriceResponse
         */
        public async Task<GetPriceResponse> GetPriceAsync(string requestPath, GetPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPriceWithOptionsAsync(requestPath, request, headers, runtime);
        }

        /**
         * @summary 获取资源元数据
         *
         * @param requestPath the whole path of resource string
         * @param headers GetResourceTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourceTypeResponse
         */
        public GetResourceTypeResponse GetResourceTypeWithOptions(string requestPath, GetResourceTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAcceptLanguage))
            {
                realHeaders["x-acs-accept-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAcceptLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceType",
                Version = "2022-08-30",
                Protocol = "HTTPS",
                Pathname = "" + requestPath,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceTypeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取资源元数据
         *
         * @param requestPath the whole path of resource string
         * @param headers GetResourceTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourceTypeResponse
         */
        public async Task<GetResourceTypeResponse> GetResourceTypeWithOptionsAsync(string requestPath, GetResourceTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAcceptLanguage))
            {
                realHeaders["x-acs-accept-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAcceptLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceType",
                Version = "2022-08-30",
                Protocol = "HTTPS",
                Pathname = "" + requestPath,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取资源元数据
         *
         * @param requestPath the whole path of resource string
         * @return GetResourceTypeResponse
         */
        public GetResourceTypeResponse GetResourceType(string requestPath)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResourceTypeHeaders headers = new GetResourceTypeHeaders();
            return GetResourceTypeWithOptions(requestPath, headers, runtime);
        }

        /**
         * @summary 获取资源元数据
         *
         * @param requestPath the whole path of resource string
         * @return GetResourceTypeResponse
         */
        public async Task<GetResourceTypeResponse> GetResourceTypeAsync(string requestPath)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResourceTypeHeaders headers = new GetResourceTypeHeaders();
            return await GetResourceTypeWithOptionsAsync(requestPath, headers, runtime);
        }

        /**
         * @summary 查询资源
         *
         * @param requestPath the whole path of resource string
         * @param tmpReq GetResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourcesResponse
         */
        public GetResourcesResponse GetResourcesWithOptions(string requestPath, GetResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetResourcesShrinkRequest request = new GetResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "filter", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                query["filter"] = request.FilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResources",
                Version = "2022-08-30",
                Protocol = "HTTPS",
                Pathname = "" + requestPath,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询资源
         *
         * @param requestPath the whole path of resource string
         * @param tmpReq GetResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResourcesResponse
         */
        public async Task<GetResourcesResponse> GetResourcesWithOptionsAsync(string requestPath, GetResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetResourcesShrinkRequest request = new GetResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "filter", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                query["filter"] = request.FilterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResources",
                Version = "2022-08-30",
                Protocol = "HTTPS",
                Pathname = "" + requestPath,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询资源
         *
         * @param requestPath the whole path of resource string
         * @param request GetResourcesRequest
         * @return GetResourcesResponse
         */
        public GetResourcesResponse GetResources(string requestPath, GetResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetResourcesWithOptions(requestPath, request, headers, runtime);
        }

        /**
         * @summary 查询资源
         *
         * @param requestPath the whole path of resource string
         * @param request GetResourcesRequest
         * @return GetResourcesResponse
         */
        public async Task<GetResourcesResponse> GetResourcesAsync(string requestPath, GetResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetResourcesWithOptionsAsync(requestPath, request, headers, runtime);
        }

        /**
         * @summary 查询任务
         *
         * @description GET /api/v1/tasks/{taskId}。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskResponse
         */
        public GetTaskResponse GetTaskWithOptions(string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTask",
                Version = "2022-08-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询任务
         *
         * @description GET /api/v1/tasks/{taskId}。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskResponse
         */
        public async Task<GetTaskResponse> GetTaskWithOptionsAsync(string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTask",
                Version = "2022-08-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询任务
         *
         * @description GET /api/v1/tasks/{taskId}。
         *
         * @return GetTaskResponse
         */
        public GetTaskResponse GetTask(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskWithOptions(taskId, headers, runtime);
        }

        /**
         * @summary 查询任务
         *
         * @description GET /api/v1/tasks/{taskId}。
         *
         * @return GetTaskResponse
         */
        public async Task<GetTaskResponse> GetTaskAsync(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskWithOptionsAsync(taskId, headers, runtime);
        }

        /**
         * @summary 列举资源属性可选值
         *
         * @param requestPath the whole path of resource string
         * @param tmpReq ListDataSourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDataSourcesResponse
         */
        public ListDataSourcesResponse ListDataSourcesWithOptions(string requestPath, ListDataSourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDataSourcesShrinkRequest request = new ListDataSourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "filter", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttributeName))
            {
                query["attributeName"] = request.AttributeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                query["filter"] = request.FilterShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSources",
                Version = "2022-08-30",
                Protocol = "HTTPS",
                Pathname = "" + requestPath,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列举资源属性可选值
         *
         * @param requestPath the whole path of resource string
         * @param tmpReq ListDataSourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDataSourcesResponse
         */
        public async Task<ListDataSourcesResponse> ListDataSourcesWithOptionsAsync(string requestPath, ListDataSourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListDataSourcesShrinkRequest request = new ListDataSourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "filter", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttributeName))
            {
                query["attributeName"] = request.AttributeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                query["filter"] = request.FilterShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSources",
                Version = "2022-08-30",
                Protocol = "HTTPS",
                Pathname = "" + requestPath,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列举资源属性可选值
         *
         * @param requestPath the whole path of resource string
         * @param request ListDataSourcesRequest
         * @return ListDataSourcesResponse
         */
        public ListDataSourcesResponse ListDataSources(string requestPath, ListDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataSourcesWithOptions(requestPath, request, headers, runtime);
        }

        /**
         * @summary 列举资源属性可选值
         *
         * @param requestPath the whole path of resource string
         * @param request ListDataSourcesRequest
         * @return ListDataSourcesResponse
         */
        public async Task<ListDataSourcesResponse> ListDataSourcesAsync(string requestPath, ListDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataSourcesWithOptionsAsync(requestPath, request, headers, runtime);
        }

        /**
         * @summary 列举资源类型
         *
         * @description GET /api/v1/providers/{provider}/products。
         *
         * @param request ListProductsRequest
         * @param headers ListProductsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProductsResponse
         */
        public ListProductsResponse ListProductsWithOptions(string provider, ListProductsRequest request, ListProductsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAcceptLanguage))
            {
                realHeaders["x-acs-accept-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAcceptLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProducts",
                Version = "2022-08-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/providers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(provider) + "/products",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列举资源类型
         *
         * @description GET /api/v1/providers/{provider}/products。
         *
         * @param request ListProductsRequest
         * @param headers ListProductsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProductsResponse
         */
        public async Task<ListProductsResponse> ListProductsWithOptionsAsync(string provider, ListProductsRequest request, ListProductsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAcceptLanguage))
            {
                realHeaders["x-acs-accept-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAcceptLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProducts",
                Version = "2022-08-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/providers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(provider) + "/products",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列举资源类型
         *
         * @description GET /api/v1/providers/{provider}/products。
         *
         * @param request ListProductsRequest
         * @return ListProductsResponse
         */
        public ListProductsResponse ListProducts(string provider, ListProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListProductsHeaders headers = new ListProductsHeaders();
            return ListProductsWithOptions(provider, request, headers, runtime);
        }

        /**
         * @summary 列举资源类型
         *
         * @description GET /api/v1/providers/{provider}/products。
         *
         * @param request ListProductsRequest
         * @return ListProductsResponse
         */
        public async Task<ListProductsResponse> ListProductsAsync(string provider, ListProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListProductsHeaders headers = new ListProductsHeaders();
            return await ListProductsWithOptionsAsync(provider, request, headers, runtime);
        }

        /**
         * @summary 列举资源类型
         *
         * @description GET /api/v1/providers/{provider}/products/{product}/resourceTypes。
         *
         * @param tmpReq ListResourceTypesRequest
         * @param headers ListResourceTypesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResourceTypesResponse
         */
        public ListResourceTypesResponse ListResourceTypesWithOptions(string provider, string product, ListResourceTypesRequest tmpReq, ListResourceTypesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListResourceTypesShrinkRequest request = new ListResourceTypesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceTypes))
            {
                request.ResourceTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceTypes, "resourceTypes", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypesShrink))
            {
                query["resourceTypes"] = request.ResourceTypesShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAcceptLanguage))
            {
                realHeaders["x-acs-accept-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAcceptLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceTypes",
                Version = "2022-08-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/providers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(provider) + "/products/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(product) + "/resourceTypes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceTypesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 列举资源类型
         *
         * @description GET /api/v1/providers/{provider}/products/{product}/resourceTypes。
         *
         * @param tmpReq ListResourceTypesRequest
         * @param headers ListResourceTypesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResourceTypesResponse
         */
        public async Task<ListResourceTypesResponse> ListResourceTypesWithOptionsAsync(string provider, string product, ListResourceTypesRequest tmpReq, ListResourceTypesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListResourceTypesShrinkRequest request = new ListResourceTypesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceTypes))
            {
                request.ResourceTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceTypes, "resourceTypes", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypesShrink))
            {
                query["resourceTypes"] = request.ResourceTypesShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAcceptLanguage))
            {
                realHeaders["x-acs-accept-language"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAcceptLanguage);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceTypes",
                Version = "2022-08-30",
                Protocol = "HTTPS",
                Pathname = "/api/v1/providers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(provider) + "/products/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(product) + "/resourceTypes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceTypesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 列举资源类型
         *
         * @description GET /api/v1/providers/{provider}/products/{product}/resourceTypes。
         *
         * @param request ListResourceTypesRequest
         * @return ListResourceTypesResponse
         */
        public ListResourceTypesResponse ListResourceTypes(string provider, string product, ListResourceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListResourceTypesHeaders headers = new ListResourceTypesHeaders();
            return ListResourceTypesWithOptions(provider, product, request, headers, runtime);
        }

        /**
         * @summary 列举资源类型
         *
         * @description GET /api/v1/providers/{provider}/products/{product}/resourceTypes。
         *
         * @param request ListResourceTypesRequest
         * @return ListResourceTypesResponse
         */
        public async Task<ListResourceTypesResponse> ListResourceTypesAsync(string provider, string product, ListResourceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListResourceTypesHeaders headers = new ListResourceTypesHeaders();
            return await ListResourceTypesWithOptionsAsync(provider, product, request, headers, runtime);
        }

        /**
         * @summary 更新资源
         *
         * @param requestPath the whole path of resource string
         * @param request UpdateResourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResourceResponse
         */
        public UpdateResourceResponse UpdateResourceWithOptions(string requestPath, UpdateResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResource",
                Version = "2022-08-30",
                Protocol = "HTTPS",
                Pathname = "" + requestPath,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新资源
         *
         * @param requestPath the whole path of resource string
         * @param request UpdateResourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResourceResponse
         */
        public async Task<UpdateResourceResponse> UpdateResourceWithOptionsAsync(string requestPath, UpdateResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResource",
                Version = "2022-08-30",
                Protocol = "HTTPS",
                Pathname = "" + requestPath,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新资源
         *
         * @param requestPath the whole path of resource string
         * @param request UpdateResourceRequest
         * @return UpdateResourceResponse
         */
        public UpdateResourceResponse UpdateResource(string requestPath, UpdateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateResourceWithOptions(requestPath, request, headers, runtime);
        }

        /**
         * @summary 更新资源
         *
         * @param requestPath the whole path of resource string
         * @param request UpdateResourceRequest
         * @return UpdateResourceResponse
         */
        public async Task<UpdateResourceResponse> UpdateResourceAsync(string requestPath, UpdateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateResourceWithOptionsAsync(requestPath, request, headers, runtime);
        }

    }
}
