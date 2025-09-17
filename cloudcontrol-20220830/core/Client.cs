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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to cancel a specified asynchronous task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only tasks that are in the Pending or Running state can be canceled.
        /// You can call the CancelTask operation to cancel a Cloud Control API task, but the tasks that have been started in the downstream Alibaba Cloud services cannot be canceled.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelTaskResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to cancel a specified asynchronous task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only tasks that are in the Pending or Running state can be canceled.
        /// You can call the CancelTask operation to cancel a Cloud Control API task, but the tasks that have been started in the downstream Alibaba Cloud services cannot be canceled.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelTaskResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to cancel a specified asynchronous task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only tasks that are in the Pending or Running state can be canceled.
        /// You can call the CancelTask operation to cancel a Cloud Control API task, but the tasks that have been started in the downstream Alibaba Cloud services cannot be canceled.</para>
        /// </description>
        /// 
        /// <returns>
        /// CancelTaskResponse
        /// </returns>
        public CancelTaskResponse CancelTask(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelTaskWithOptions(taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to cancel a specified asynchronous task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only tasks that are in the Pending or Running state can be canceled.
        /// You can call the CancelTask operation to cancel a Cloud Control API task, but the tasks that have been started in the downstream Alibaba Cloud services cannot be canceled.</para>
        /// </description>
        /// 
        /// <returns>
        /// CancelTaskResponse
        /// </returns>
        public async Task<CancelTaskResponse> CancelTaskAsync(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelTaskWithOptionsAsync(taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to create resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can go to <a href="https://next.api.aliyun.com/cloudcontrol">OpenAPI Explorer</a> to view the documentation and try out Cloud Control API.</para>
        /// </description>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="request">
        /// CreateResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to create resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can go to <a href="https://next.api.aliyun.com/cloudcontrol">OpenAPI Explorer</a> to view the documentation and try out Cloud Control API.</para>
        /// </description>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="request">
        /// CreateResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to create resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can go to <a href="https://next.api.aliyun.com/cloudcontrol">OpenAPI Explorer</a> to view the documentation and try out Cloud Control API.</para>
        /// </description>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="request">
        /// CreateResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceResponse
        /// </returns>
        public CreateResourceResponse CreateResource(string requestPath, CreateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateResourceWithOptions(requestPath, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to create resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can go to <a href="https://next.api.aliyun.com/cloudcontrol">OpenAPI Explorer</a> to view the documentation and try out Cloud Control API.</para>
        /// </description>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="request">
        /// CreateResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceResponse
        /// </returns>
        public async Task<CreateResourceResponse> CreateResourceAsync(string requestPath, CreateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateResourceWithOptionsAsync(requestPath, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to delete resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can go to <a href="https://next.api.aliyun.com/cloudcontrol">OpenAPI Explorer</a> to view the documentation and try out Cloud Control API.</para>
        /// </description>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="tmpReq">
        /// DeleteResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceResponse
        /// </returns>
        public DeleteResourceResponse DeleteResourceWithOptions(string requestPath, DeleteResourceRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteResourceShrinkRequest request = new DeleteResourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "filter", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                query["filter"] = request.FilterShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to delete resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can go to <a href="https://next.api.aliyun.com/cloudcontrol">OpenAPI Explorer</a> to view the documentation and try out Cloud Control API.</para>
        /// </description>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="tmpReq">
        /// DeleteResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceResponse
        /// </returns>
        public async Task<DeleteResourceResponse> DeleteResourceWithOptionsAsync(string requestPath, DeleteResourceRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteResourceShrinkRequest request = new DeleteResourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filter))
            {
                request.FilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filter, "filter", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterShrink))
            {
                query["filter"] = request.FilterShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to delete resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can go to <a href="https://next.api.aliyun.com/cloudcontrol">OpenAPI Explorer</a> to view the documentation and try out Cloud Control API.</para>
        /// </description>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="request">
        /// DeleteResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceResponse
        /// </returns>
        public DeleteResourceResponse DeleteResource(string requestPath, DeleteResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteResourceWithOptions(requestPath, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to delete resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can go to <a href="https://next.api.aliyun.com/cloudcontrol">OpenAPI Explorer</a> to view the documentation and try out Cloud Control API.</para>
        /// </description>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="request">
        /// DeleteResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceResponse
        /// </returns>
        public async Task<DeleteResourceResponse> DeleteResourceAsync(string requestPath, DeleteResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteResourceWithOptionsAsync(requestPath, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An RFQ interface through which users can query resource prices.</para>
        /// </summary>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="tmpReq">
        /// GetPriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPriceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An RFQ interface through which users can query resource prices.</para>
        /// </summary>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="tmpReq">
        /// GetPriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPriceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An RFQ interface through which users can query resource prices.</para>
        /// </summary>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="request">
        /// GetPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPriceResponse
        /// </returns>
        public GetPriceResponse GetPrice(string requestPath, GetPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPriceWithOptions(requestPath, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An RFQ interface through which users can query resource prices.</para>
        /// </summary>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="request">
        /// GetPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPriceResponse
        /// </returns>
        public async Task<GetPriceResponse> GetPriceAsync(string requestPath, GetPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPriceWithOptionsAsync(requestPath, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the operation to obtain resource metadata.</para>
        /// </summary>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="headers">
        /// GetResourceTypeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceTypeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the operation to obtain resource metadata.</para>
        /// </summary>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="headers">
        /// GetResourceTypeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceTypeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the operation to obtain resource metadata.</para>
        /// </summary>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// 
        /// <returns>
        /// GetResourceTypeResponse
        /// </returns>
        public GetResourceTypeResponse GetResourceType(string requestPath)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResourceTypeHeaders headers = new GetResourceTypeHeaders();
            return GetResourceTypeWithOptions(requestPath, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the operation to obtain resource metadata.</para>
        /// </summary>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// 
        /// <returns>
        /// GetResourceTypeResponse
        /// </returns>
        public async Task<GetResourceTypeResponse> GetResourceTypeAsync(string requestPath)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetResourceTypeHeaders headers = new GetResourceTypeHeaders();
            return await GetResourceTypeWithOptionsAsync(requestPath, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the operation to query resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can go to <a href="https://next.api.aliyun.com/cloudcontrol">OpenAPI Explorer</a> to view the documentation and try out CloudControl API.
        /// You can call this operation to query resources List and Get based on different request paths.</para>
        /// </description>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="tmpReq">
        /// GetResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the operation to query resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can go to <a href="https://next.api.aliyun.com/cloudcontrol">OpenAPI Explorer</a> to view the documentation and try out CloudControl API.
        /// You can call this operation to query resources List and Get based on different request paths.</para>
        /// </description>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="tmpReq">
        /// GetResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the operation to query resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can go to <a href="https://next.api.aliyun.com/cloudcontrol">OpenAPI Explorer</a> to view the documentation and try out CloudControl API.
        /// You can call this operation to query resources List and Get based on different request paths.</para>
        /// </description>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="request">
        /// GetResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourcesResponse
        /// </returns>
        public GetResourcesResponse GetResources(string requestPath, GetResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetResourcesWithOptions(requestPath, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the operation to query resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can go to <a href="https://next.api.aliyun.com/cloudcontrol">OpenAPI Explorer</a> to view the documentation and try out CloudControl API.
        /// You can call this operation to query resources List and Get based on different request paths.</para>
        /// </description>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="request">
        /// GetResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourcesResponse
        /// </returns>
        public async Task<GetResourcesResponse> GetResourcesAsync(string requestPath, GetResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetResourcesWithOptionsAsync(requestPath, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to query a specified asynchronous task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>GET /api/v1/tasks/{taskId}.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to query a specified asynchronous task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>GET /api/v1/tasks/{taskId}.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to query a specified asynchronous task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>GET /api/v1/tasks/{taskId}.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetTaskResponse
        /// </returns>
        public GetTaskResponse GetTask(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskWithOptions(taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to query a specified asynchronous task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>GET /api/v1/tasks/{taskId}.</para>
        /// </description>
        /// 
        /// <returns>
        /// GetTaskResponse
        /// </returns>
        public async Task<GetTaskResponse> GetTaskAsync(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskWithOptionsAsync(taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the operation to query the valid values of resource attributes, such as RegionID and ZoneId.</para>
        /// </summary>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="tmpReq">
        /// ListDataSourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the operation to query the valid values of resource attributes, such as RegionID and ZoneId.</para>
        /// </summary>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="tmpReq">
        /// ListDataSourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the operation to query the valid values of resource attributes, such as RegionID and ZoneId.</para>
        /// </summary>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="request">
        /// ListDataSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourcesResponse
        /// </returns>
        public ListDataSourcesResponse ListDataSources(string requestPath, ListDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDataSourcesWithOptions(requestPath, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call the operation to query the valid values of resource attributes, such as RegionID and ZoneId.</para>
        /// </summary>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="request">
        /// ListDataSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourcesResponse
        /// </returns>
        public async Task<ListDataSourcesResponse> ListDataSourcesAsync(string requestPath, ListDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDataSourcesWithOptionsAsync(requestPath, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to list the supported services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>GET /api/v1/providers/{provider}/products.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListProductsRequest
        /// </param>
        /// <param name="headers">
        /// ListProductsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProductsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to list the supported services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>GET /api/v1/providers/{provider}/products.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListProductsRequest
        /// </param>
        /// <param name="headers">
        /// ListProductsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProductsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to list the supported services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>GET /api/v1/providers/{provider}/products.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListProductsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProductsResponse
        /// </returns>
        public ListProductsResponse ListProducts(string provider, ListProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListProductsHeaders headers = new ListProductsHeaders();
            return ListProductsWithOptions(provider, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to list the supported services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>GET /api/v1/providers/{provider}/products.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListProductsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProductsResponse
        /// </returns>
        public async Task<ListProductsResponse> ListProductsAsync(string provider, ListProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListProductsHeaders headers = new ListProductsHeaders();
            return await ListProductsWithOptionsAsync(provider, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to list the resource types of a service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>GET /api/v1/providers/{provider}/products/{product}/resourceTypes.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListResourceTypesRequest
        /// </param>
        /// <param name="headers">
        /// ListResourceTypesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTypesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to list the resource types of a service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>GET /api/v1/providers/{provider}/products/{product}/resourceTypes.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListResourceTypesRequest
        /// </param>
        /// <param name="headers">
        /// ListResourceTypesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTypesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to list the resource types of a service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>GET /api/v1/providers/{provider}/products/{product}/resourceTypes.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceTypesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTypesResponse
        /// </returns>
        public ListResourceTypesResponse ListResourceTypes(string provider, string product, ListResourceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListResourceTypesHeaders headers = new ListResourceTypesHeaders();
            return ListResourceTypesWithOptions(provider, product, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to list the resource types of a service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>GET /api/v1/providers/{provider}/products/{product}/resourceTypes.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceTypesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTypesResponse
        /// </returns>
        public async Task<ListResourceTypesResponse> ListResourceTypesAsync(string provider, string product, ListResourceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListResourceTypesHeaders headers = new ListResourceTypesHeaders();
            return await ListResourceTypesWithOptionsAsync(provider, product, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to update resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can go to <a href="https://next.api.aliyun.com/cloudcontrol">OpenAPI Explorer</a> to view the documentation and try out Cloud Control API.
        /// If resources fail to be updated at any time, the Cloud Control API does not roll the resource back to the original status.
        /// The resource APIs cannot be rolled back. If the API operation is partially failed to be called, you can call the GetResource operation to view the latest status of the resource. If necessary, you can call the UpdateResource or DeleteResource operation to manually compensate for the failure.</para>
        /// </description>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="request">
        /// UpdateResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to update resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can go to <a href="https://next.api.aliyun.com/cloudcontrol">OpenAPI Explorer</a> to view the documentation and try out Cloud Control API.
        /// If resources fail to be updated at any time, the Cloud Control API does not roll the resource back to the original status.
        /// The resource APIs cannot be rolled back. If the API operation is partially failed to be called, you can call the GetResource operation to view the latest status of the resource. If necessary, you can call the UpdateResource or DeleteResource operation to manually compensate for the failure.</para>
        /// </description>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="request">
        /// UpdateResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to update resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can go to <a href="https://next.api.aliyun.com/cloudcontrol">OpenAPI Explorer</a> to view the documentation and try out Cloud Control API.
        /// If resources fail to be updated at any time, the Cloud Control API does not roll the resource back to the original status.
        /// The resource APIs cannot be rolled back. If the API operation is partially failed to be called, you can call the GetResource operation to view the latest status of the resource. If necessary, you can call the UpdateResource or DeleteResource operation to manually compensate for the failure.</para>
        /// </description>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="request">
        /// UpdateResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceResponse
        /// </returns>
        public UpdateResourceResponse UpdateResource(string requestPath, UpdateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateResourceWithOptions(requestPath, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls this operation to update resources.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can go to <a href="https://next.api.aliyun.com/cloudcontrol">OpenAPI Explorer</a> to view the documentation and try out Cloud Control API.
        /// If resources fail to be updated at any time, the Cloud Control API does not roll the resource back to the original status.
        /// The resource APIs cannot be rolled back. If the API operation is partially failed to be called, you can call the GetResource operation to view the latest status of the resource. If necessary, you can call the UpdateResource or DeleteResource operation to manually compensate for the failure.</para>
        /// </description>
        /// 
        /// <param name="requestPath">
        /// the whole path of resource string
        /// </param>
        /// <param name="request">
        /// UpdateResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceResponse
        /// </returns>
        public async Task<UpdateResourceResponse> UpdateResourceAsync(string requestPath, UpdateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateResourceWithOptionsAsync(requestPath, request, headers, runtime);
        }

    }
}
