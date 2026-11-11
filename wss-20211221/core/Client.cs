// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Wss20211221.Models;

namespace AlibabaCloud.SDK.Wss20211221
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "wss";
            AlibabaCloud.GatewayPop.Client gatewayClient = new AlibabaCloud.GatewayPop.Client();
            this._spi = gatewayClient;
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("wss", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Creates an order, renews, or modifies the configuration of specific products such as the monthly duration package for Wuying Workspace Enterprise Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;Make sure that you fully understand the billing methods and <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a> of Wuying Workspace before you call this operation.
        /// &lt;props=&quot;intl&quot;&gt;Make sure that you fully understand the billing methods and <a href="https://www.alibabacloud.com/zh/product/cloud-desktop?#J_8623712560">pricing</a> of Wuying Workspace before you call this operation.
        /// If automatic payment is not specified, this operation does not process the payment. You must use the order ID returned by this operation to construct a payment redirect URL and complete the payment. The order takes effect and resources are provisioned only after the payment is completed.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateMultiOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMultiOrderResponse
        /// </returns>
        public CreateMultiOrderResponse CreateMultiOrderWithOptions(CreateMultiOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateMultiOrderShrinkRequest request = new CreateMultiOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Properties))
            {
                request.PropertiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Properties, "Properties", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCookie))
            {
                query["ChannelCookie"] = request.ChannelCookie;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderItems))
            {
                query["OrderItems"] = request.OrderItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertiesShrink))
            {
                query["Properties"] = request.PropertiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResellerOwnerUid))
            {
                query["ResellerOwnerUid"] = request.ResellerOwnerUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMultiOrder",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMultiOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an order, renews, or modifies the configuration of specific products such as the monthly duration package for Wuying Workspace Enterprise Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;Make sure that you fully understand the billing methods and <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a> of Wuying Workspace before you call this operation.
        /// &lt;props=&quot;intl&quot;&gt;Make sure that you fully understand the billing methods and <a href="https://www.alibabacloud.com/zh/product/cloud-desktop?#J_8623712560">pricing</a> of Wuying Workspace before you call this operation.
        /// If automatic payment is not specified, this operation does not process the payment. You must use the order ID returned by this operation to construct a payment redirect URL and complete the payment. The order takes effect and resources are provisioned only after the payment is completed.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateMultiOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMultiOrderResponse
        /// </returns>
        public async Task<CreateMultiOrderResponse> CreateMultiOrderWithOptionsAsync(CreateMultiOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateMultiOrderShrinkRequest request = new CreateMultiOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Properties))
            {
                request.PropertiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Properties, "Properties", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCookie))
            {
                query["ChannelCookie"] = request.ChannelCookie;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderItems))
            {
                query["OrderItems"] = request.OrderItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertiesShrink))
            {
                query["Properties"] = request.PropertiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResellerOwnerUid))
            {
                query["ResellerOwnerUid"] = request.ResellerOwnerUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMultiOrder",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMultiOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an order, renews, or modifies the configuration of specific products such as the monthly duration package for Wuying Workspace Enterprise Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;Make sure that you fully understand the billing methods and <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a> of Wuying Workspace before you call this operation.
        /// &lt;props=&quot;intl&quot;&gt;Make sure that you fully understand the billing methods and <a href="https://www.alibabacloud.com/zh/product/cloud-desktop?#J_8623712560">pricing</a> of Wuying Workspace before you call this operation.
        /// If automatic payment is not specified, this operation does not process the payment. You must use the order ID returned by this operation to construct a payment redirect URL and complete the payment. The order takes effect and resources are provisioned only after the payment is completed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateMultiOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMultiOrderResponse
        /// </returns>
        public CreateMultiOrderResponse CreateMultiOrder(CreateMultiOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMultiOrderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an order, renews, or modifies the configuration of specific products such as the monthly duration package for Wuying Workspace Enterprise Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;Make sure that you fully understand the billing methods and <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a> of Wuying Workspace before you call this operation.
        /// &lt;props=&quot;intl&quot;&gt;Make sure that you fully understand the billing methods and <a href="https://www.alibabacloud.com/zh/product/cloud-desktop?#J_8623712560">pricing</a> of Wuying Workspace before you call this operation.
        /// If automatic payment is not specified, this operation does not process the payment. You must use the order ID returned by this operation to construct a payment redirect URL and complete the payment. The order takes effect and resources are provisioned only after the payment is completed.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateMultiOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMultiOrderResponse
        /// </returns>
        public async Task<CreateMultiOrderResponse> CreateMultiOrderAsync(CreateMultiOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMultiOrderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paging query for AI model invocation records based on specified conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation performs a paging query for AI model invocation details of the current Alibaba Cloud account within a specified business edition, region, and time range.</description></item>
        /// <item><description>You can filter results by model invocation request ID, requested model, and user ID.</description></item>
        /// <item><description>Query results are returned in descending order of invocation time.</description></item>
        /// <item><description>By default, this operation queries data from 00:00:00 (UTC+8) of the current day to the current time. The query time range cannot exceed 30 days and cannot start earlier than three calendar months before the current time.</description></item>
        /// <item><description>You can only query data for the primary account to which the current caller identity belongs. You cannot specify other accounts.</description></item>
        /// <item><description>The product of PageNumber and PageSize cannot exceed 1,000,000.</description></item>
        /// <item><description>If BizType is not specified, the default value is Enterprise Edition.</description></item>
        /// <item><description>If GatewayRegion is not specified, the default value is Shanghai for the China site and Singapore for the international site.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAICallDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAICallDetailsResponse
        /// </returns>
        public DescribeAICallDetailsResponse DescribeAICallDetailsWithOptions(DescribeAICallDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayRegion))
            {
                query["GatewayRegion"] = request.GatewayRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["ModelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchRequestId))
            {
                query["SearchRequestId"] = request.SearchRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WyIds))
            {
                query["WyIds"] = request.WyIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAICallDetails",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAICallDetailsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paging query for AI model invocation records based on specified conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation performs a paging query for AI model invocation details of the current Alibaba Cloud account within a specified business edition, region, and time range.</description></item>
        /// <item><description>You can filter results by model invocation request ID, requested model, and user ID.</description></item>
        /// <item><description>Query results are returned in descending order of invocation time.</description></item>
        /// <item><description>By default, this operation queries data from 00:00:00 (UTC+8) of the current day to the current time. The query time range cannot exceed 30 days and cannot start earlier than three calendar months before the current time.</description></item>
        /// <item><description>You can only query data for the primary account to which the current caller identity belongs. You cannot specify other accounts.</description></item>
        /// <item><description>The product of PageNumber and PageSize cannot exceed 1,000,000.</description></item>
        /// <item><description>If BizType is not specified, the default value is Enterprise Edition.</description></item>
        /// <item><description>If GatewayRegion is not specified, the default value is Shanghai for the China site and Singapore for the international site.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAICallDetailsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAICallDetailsResponse
        /// </returns>
        public async Task<DescribeAICallDetailsResponse> DescribeAICallDetailsWithOptionsAsync(DescribeAICallDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayRegion))
            {
                query["GatewayRegion"] = request.GatewayRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["ModelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchRequestId))
            {
                query["SearchRequestId"] = request.SearchRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WyIds))
            {
                query["WyIds"] = request.WyIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAICallDetails",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAICallDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paging query for AI model invocation records based on specified conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation performs a paging query for AI model invocation details of the current Alibaba Cloud account within a specified business edition, region, and time range.</description></item>
        /// <item><description>You can filter results by model invocation request ID, requested model, and user ID.</description></item>
        /// <item><description>Query results are returned in descending order of invocation time.</description></item>
        /// <item><description>By default, this operation queries data from 00:00:00 (UTC+8) of the current day to the current time. The query time range cannot exceed 30 days and cannot start earlier than three calendar months before the current time.</description></item>
        /// <item><description>You can only query data for the primary account to which the current caller identity belongs. You cannot specify other accounts.</description></item>
        /// <item><description>The product of PageNumber and PageSize cannot exceed 1,000,000.</description></item>
        /// <item><description>If BizType is not specified, the default value is Enterprise Edition.</description></item>
        /// <item><description>If GatewayRegion is not specified, the default value is Shanghai for the China site and Singapore for the international site.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAICallDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAICallDetailsResponse
        /// </returns>
        public DescribeAICallDetailsResponse DescribeAICallDetails(DescribeAICallDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAICallDetailsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paging query for AI model invocation records based on specified conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation performs a paging query for AI model invocation details of the current Alibaba Cloud account within a specified business edition, region, and time range.</description></item>
        /// <item><description>You can filter results by model invocation request ID, requested model, and user ID.</description></item>
        /// <item><description>Query results are returned in descending order of invocation time.</description></item>
        /// <item><description>By default, this operation queries data from 00:00:00 (UTC+8) of the current day to the current time. The query time range cannot exceed 30 days and cannot start earlier than three calendar months before the current time.</description></item>
        /// <item><description>You can only query data for the primary account to which the current caller identity belongs. You cannot specify other accounts.</description></item>
        /// <item><description>The product of PageNumber and PageSize cannot exceed 1,000,000.</description></item>
        /// <item><description>If BizType is not specified, the default value is Enterprise Edition.</description></item>
        /// <item><description>If GatewayRegion is not specified, the default value is Shanghai for the China site and Singapore for the international site.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAICallDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAICallDetailsResponse
        /// </returns>
        public async Task<DescribeAICallDetailsResponse> DescribeAICallDetailsAsync(DescribeAICallDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAICallDetailsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of agents and usage summary information under the current username.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><b>Paging</b>: Use the <c>NextToken</c> and <c>MaxResults</c> parameters for paging. Set <c>NextToken</c> to an empty character string for the first request.</description></item>
        /// <item><description><b>Filtering</b>: Use the <c>AgentType</c> and <c>AgentIds</c> parameters to filter the returned agent list.</description></item>
        /// <item><description><b>Status filtering</b>: Use the <c>Status</c> parameter to filter agents by status. Valid values: 0 (deleted) and 1 (active).</description></item>
        /// <item><description><b>Sorting</b>: Results are sorted by <c>id</c> in ascending order by default.</description></item>
        /// <item><description><b>Additional parameter for anonymous edition</b>: The <c>FillInstance</c> parameter automatically populates the bound JVS_COPILOT AgentId of the currently logged-on user.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCreditPackageAgentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCreditPackageAgentsResponse
        /// </returns>
        public DescribeCreditPackageAgentsResponse DescribeCreditPackageAgentsWithOptions(DescribeCreditPackageAgentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentIds))
            {
                query["AgentIds"] = request.AgentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentType))
            {
                query["AgentType"] = request.AgentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCreditPackageAgents",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCreditPackageAgentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of agents and usage summary information under the current username.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><b>Paging</b>: Use the <c>NextToken</c> and <c>MaxResults</c> parameters for paging. Set <c>NextToken</c> to an empty character string for the first request.</description></item>
        /// <item><description><b>Filtering</b>: Use the <c>AgentType</c> and <c>AgentIds</c> parameters to filter the returned agent list.</description></item>
        /// <item><description><b>Status filtering</b>: Use the <c>Status</c> parameter to filter agents by status. Valid values: 0 (deleted) and 1 (active).</description></item>
        /// <item><description><b>Sorting</b>: Results are sorted by <c>id</c> in ascending order by default.</description></item>
        /// <item><description><b>Additional parameter for anonymous edition</b>: The <c>FillInstance</c> parameter automatically populates the bound JVS_COPILOT AgentId of the currently logged-on user.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCreditPackageAgentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCreditPackageAgentsResponse
        /// </returns>
        public async Task<DescribeCreditPackageAgentsResponse> DescribeCreditPackageAgentsWithOptionsAsync(DescribeCreditPackageAgentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentIds))
            {
                query["AgentIds"] = request.AgentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentType))
            {
                query["AgentType"] = request.AgentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCreditPackageAgents",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCreditPackageAgentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of agents and usage summary information under the current username.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><b>Paging</b>: Use the <c>NextToken</c> and <c>MaxResults</c> parameters for paging. Set <c>NextToken</c> to an empty character string for the first request.</description></item>
        /// <item><description><b>Filtering</b>: Use the <c>AgentType</c> and <c>AgentIds</c> parameters to filter the returned agent list.</description></item>
        /// <item><description><b>Status filtering</b>: Use the <c>Status</c> parameter to filter agents by status. Valid values: 0 (deleted) and 1 (active).</description></item>
        /// <item><description><b>Sorting</b>: Results are sorted by <c>id</c> in ascending order by default.</description></item>
        /// <item><description><b>Additional parameter for anonymous edition</b>: The <c>FillInstance</c> parameter automatically populates the bound JVS_COPILOT AgentId of the currently logged-on user.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCreditPackageAgentsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCreditPackageAgentsResponse
        /// </returns>
        public DescribeCreditPackageAgentsResponse DescribeCreditPackageAgents(DescribeCreditPackageAgentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCreditPackageAgentsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of agents and usage summary information under the current username.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description><b>Paging</b>: Use the <c>NextToken</c> and <c>MaxResults</c> parameters for paging. Set <c>NextToken</c> to an empty character string for the first request.</description></item>
        /// <item><description><b>Filtering</b>: Use the <c>AgentType</c> and <c>AgentIds</c> parameters to filter the returned agent list.</description></item>
        /// <item><description><b>Status filtering</b>: Use the <c>Status</c> parameter to filter agents by status. Valid values: 0 (deleted) and 1 (active).</description></item>
        /// <item><description><b>Sorting</b>: Results are sorted by <c>id</c> in ascending order by default.</description></item>
        /// <item><description><b>Additional parameter for anonymous edition</b>: The <c>FillInstance</c> parameter automatically populates the bound JVS_COPILOT AgentId of the currently logged-on user.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCreditPackageAgentsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCreditPackageAgentsResponse
        /// </returns>
        public async Task<DescribeCreditPackageAgentsResponse> DescribeCreditPackageAgentsAsync(DescribeCreditPackageAgentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCreditPackageAgentsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the credit usage of users, credit packages, or agents based on a specified dimension.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries credit usage details based on the dimension specified by <c>UsageType</c> (User, CreditPackage, Agent, or EndUser). The response includes the total amount, remaining amount, and used amount of the current credit package, hourly consumption samples, alert thresholds, and periodic quotas.</para>
        /// <list type="bullet">
        /// <item><description><b>User</b>: The user dimension. Returns the total used amount and remaining amount of all active credit packages for the current user.</description></item>
        /// <item><description><b>CreditPackage</b>: The credit package dimension. Returns the total amount, remaining amount, and consumption samples of a specified credit package instance.</description></item>
        /// <item><description><b>Agent</b>: The agent dimension. Returns the cumulative used amount, current period used amount, quota, and alerts for a specified agent.</description></item>
        /// <item><description><b>EndUser</b>: The Wuying user dimension. Returns the shared credit usage, pay-as-you-go credit usage, and total credit usage for the current period of a Wuying user.
        /// <b>Note</b>:</description></item>
        /// <item><description>The <c>InstanceIds</c> parameter can be omitted when <c>UsageType</c> is set to <c>User</c>. Set it to the credit package instance ID when <c>UsageType</c> is <c>CreditPackage</c>, the agent ID when <c>UsageType</c> is <c>Agent</c>, and the Wuying ID when <c>UsageType</c> is <c>EndUser</c>.</description></item>
        /// <item><description>Anonymous requests support the <c>FillInstance</c> parameter. If <c>InstanceIds</c> is not explicitly provided and <c>FillInstance</c> is set to <c>true</c>, the server automatically populates the bound <c>JVS_COPILOT</c> agent ID based on the currently logged-in <c>wyId</c>.</description></item>
        /// <item><description>Time window constants: The statistical window for <c>dayUsedCredit</c> is <c>now - ONE_DAY_MILLIS</c>, and the statistical window for <c>weekUsedCredit</c> is <c>now - ONE_WEEK_MILLIS</c>.</description></item>
        /// <item><description>The consumption samples in <c>currentCreditConsumeList</c> are aggregated by hour and may have an asynchronous synchronization delay of up to 5 minutes.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCreditUsageInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCreditUsageInfoResponse
        /// </returns>
        public DescribeCreditUsageInfoResponse DescribeCreditUsageInfoWithOptions(DescribeCreditUsageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsageType))
            {
                query["UsageType"] = request.UsageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCreditUsageInfo",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCreditUsageInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the credit usage of users, credit packages, or agents based on a specified dimension.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries credit usage details based on the dimension specified by <c>UsageType</c> (User, CreditPackage, Agent, or EndUser). The response includes the total amount, remaining amount, and used amount of the current credit package, hourly consumption samples, alert thresholds, and periodic quotas.</para>
        /// <list type="bullet">
        /// <item><description><b>User</b>: The user dimension. Returns the total used amount and remaining amount of all active credit packages for the current user.</description></item>
        /// <item><description><b>CreditPackage</b>: The credit package dimension. Returns the total amount, remaining amount, and consumption samples of a specified credit package instance.</description></item>
        /// <item><description><b>Agent</b>: The agent dimension. Returns the cumulative used amount, current period used amount, quota, and alerts for a specified agent.</description></item>
        /// <item><description><b>EndUser</b>: The Wuying user dimension. Returns the shared credit usage, pay-as-you-go credit usage, and total credit usage for the current period of a Wuying user.
        /// <b>Note</b>:</description></item>
        /// <item><description>The <c>InstanceIds</c> parameter can be omitted when <c>UsageType</c> is set to <c>User</c>. Set it to the credit package instance ID when <c>UsageType</c> is <c>CreditPackage</c>, the agent ID when <c>UsageType</c> is <c>Agent</c>, and the Wuying ID when <c>UsageType</c> is <c>EndUser</c>.</description></item>
        /// <item><description>Anonymous requests support the <c>FillInstance</c> parameter. If <c>InstanceIds</c> is not explicitly provided and <c>FillInstance</c> is set to <c>true</c>, the server automatically populates the bound <c>JVS_COPILOT</c> agent ID based on the currently logged-in <c>wyId</c>.</description></item>
        /// <item><description>Time window constants: The statistical window for <c>dayUsedCredit</c> is <c>now - ONE_DAY_MILLIS</c>, and the statistical window for <c>weekUsedCredit</c> is <c>now - ONE_WEEK_MILLIS</c>.</description></item>
        /// <item><description>The consumption samples in <c>currentCreditConsumeList</c> are aggregated by hour and may have an asynchronous synchronization delay of up to 5 minutes.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCreditUsageInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCreditUsageInfoResponse
        /// </returns>
        public async Task<DescribeCreditUsageInfoResponse> DescribeCreditUsageInfoWithOptionsAsync(DescribeCreditUsageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsageType))
            {
                query["UsageType"] = request.UsageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCreditUsageInfo",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCreditUsageInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the credit usage of users, credit packages, or agents based on a specified dimension.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries credit usage details based on the dimension specified by <c>UsageType</c> (User, CreditPackage, Agent, or EndUser). The response includes the total amount, remaining amount, and used amount of the current credit package, hourly consumption samples, alert thresholds, and periodic quotas.</para>
        /// <list type="bullet">
        /// <item><description><b>User</b>: The user dimension. Returns the total used amount and remaining amount of all active credit packages for the current user.</description></item>
        /// <item><description><b>CreditPackage</b>: The credit package dimension. Returns the total amount, remaining amount, and consumption samples of a specified credit package instance.</description></item>
        /// <item><description><b>Agent</b>: The agent dimension. Returns the cumulative used amount, current period used amount, quota, and alerts for a specified agent.</description></item>
        /// <item><description><b>EndUser</b>: The Wuying user dimension. Returns the shared credit usage, pay-as-you-go credit usage, and total credit usage for the current period of a Wuying user.
        /// <b>Note</b>:</description></item>
        /// <item><description>The <c>InstanceIds</c> parameter can be omitted when <c>UsageType</c> is set to <c>User</c>. Set it to the credit package instance ID when <c>UsageType</c> is <c>CreditPackage</c>, the agent ID when <c>UsageType</c> is <c>Agent</c>, and the Wuying ID when <c>UsageType</c> is <c>EndUser</c>.</description></item>
        /// <item><description>Anonymous requests support the <c>FillInstance</c> parameter. If <c>InstanceIds</c> is not explicitly provided and <c>FillInstance</c> is set to <c>true</c>, the server automatically populates the bound <c>JVS_COPILOT</c> agent ID based on the currently logged-in <c>wyId</c>.</description></item>
        /// <item><description>Time window constants: The statistical window for <c>dayUsedCredit</c> is <c>now - ONE_DAY_MILLIS</c>, and the statistical window for <c>weekUsedCredit</c> is <c>now - ONE_WEEK_MILLIS</c>.</description></item>
        /// <item><description>The consumption samples in <c>currentCreditConsumeList</c> are aggregated by hour and may have an asynchronous synchronization delay of up to 5 minutes.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCreditUsageInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCreditUsageInfoResponse
        /// </returns>
        public DescribeCreditUsageInfoResponse DescribeCreditUsageInfo(DescribeCreditUsageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCreditUsageInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the credit usage of users, credit packages, or agents based on a specified dimension.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries credit usage details based on the dimension specified by <c>UsageType</c> (User, CreditPackage, Agent, or EndUser). The response includes the total amount, remaining amount, and used amount of the current credit package, hourly consumption samples, alert thresholds, and periodic quotas.</para>
        /// <list type="bullet">
        /// <item><description><b>User</b>: The user dimension. Returns the total used amount and remaining amount of all active credit packages for the current user.</description></item>
        /// <item><description><b>CreditPackage</b>: The credit package dimension. Returns the total amount, remaining amount, and consumption samples of a specified credit package instance.</description></item>
        /// <item><description><b>Agent</b>: The agent dimension. Returns the cumulative used amount, current period used amount, quota, and alerts for a specified agent.</description></item>
        /// <item><description><b>EndUser</b>: The Wuying user dimension. Returns the shared credit usage, pay-as-you-go credit usage, and total credit usage for the current period of a Wuying user.
        /// <b>Note</b>:</description></item>
        /// <item><description>The <c>InstanceIds</c> parameter can be omitted when <c>UsageType</c> is set to <c>User</c>. Set it to the credit package instance ID when <c>UsageType</c> is <c>CreditPackage</c>, the agent ID when <c>UsageType</c> is <c>Agent</c>, and the Wuying ID when <c>UsageType</c> is <c>EndUser</c>.</description></item>
        /// <item><description>Anonymous requests support the <c>FillInstance</c> parameter. If <c>InstanceIds</c> is not explicitly provided and <c>FillInstance</c> is set to <c>true</c>, the server automatically populates the bound <c>JVS_COPILOT</c> agent ID based on the currently logged-in <c>wyId</c>.</description></item>
        /// <item><description>Time window constants: The statistical window for <c>dayUsedCredit</c> is <c>now - ONE_DAY_MILLIS</c>, and the statistical window for <c>weekUsedCredit</c> is <c>now - ONE_WEEK_MILLIS</c>.</description></item>
        /// <item><description>The consumption samples in <c>currentCreditConsumeList</c> are aggregated by hour and may have an asynchronous synchronization delay of up to 5 minutes.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCreditUsageInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCreditUsageInfoResponse
        /// </returns>
        public async Task<DescribeCreditUsageInfoResponse> DescribeCreditUsageInfoAsync(DescribeCreditUsageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCreditUsageInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves resource deduction and usage statistics based on specified conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation supports GET and POST methods.</description></item>
        /// <item><description>The <c>periods</c> parameter is in JSON array format. Each element is a <c>PeriodParam</c> object that contains the <c>periodUnit</c> and <c>baseTime</c> fields.</description></item>
        /// <item><description>The <c>resourceTypes</c> parameter is in JSON array format and contains multiple resource type strings.</description></item>
        /// <item><description>The <c>startTime</c> and <c>endTime</c> parameters are in timestamp format and specify the time range for the query.</description></item>
        /// <item><description>Pagination parameters include <c>nextToken</c>, <c>maxResults</c>, <c>pageNo</c>, and <c>pageSize</c>, which control the number and pagination of returned results.</description></item>
        /// <item><description>If the <c>resourceTypes</c> parameter contains invalid values or the <c>periods</c> parameter fails JSON parsing, a <c>SalesClientException</c> exception is thrown.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDeductionStatisticRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDeductionStatisticResponse
        /// </returns>
        public DescribeDeductionStatisticResponse DescribeDeductionStatisticWithOptions(DescribeDeductionStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Periods))
            {
                query["Periods"] = request.Periods;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDeductionStatistic",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDeductionStatisticResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves resource deduction and usage statistics based on specified conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation supports GET and POST methods.</description></item>
        /// <item><description>The <c>periods</c> parameter is in JSON array format. Each element is a <c>PeriodParam</c> object that contains the <c>periodUnit</c> and <c>baseTime</c> fields.</description></item>
        /// <item><description>The <c>resourceTypes</c> parameter is in JSON array format and contains multiple resource type strings.</description></item>
        /// <item><description>The <c>startTime</c> and <c>endTime</c> parameters are in timestamp format and specify the time range for the query.</description></item>
        /// <item><description>Pagination parameters include <c>nextToken</c>, <c>maxResults</c>, <c>pageNo</c>, and <c>pageSize</c>, which control the number and pagination of returned results.</description></item>
        /// <item><description>If the <c>resourceTypes</c> parameter contains invalid values or the <c>periods</c> parameter fails JSON parsing, a <c>SalesClientException</c> exception is thrown.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDeductionStatisticRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDeductionStatisticResponse
        /// </returns>
        public async Task<DescribeDeductionStatisticResponse> DescribeDeductionStatisticWithOptionsAsync(DescribeDeductionStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Periods))
            {
                query["Periods"] = request.Periods;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDeductionStatistic",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDeductionStatisticResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves resource deduction and usage statistics based on specified conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation supports GET and POST methods.</description></item>
        /// <item><description>The <c>periods</c> parameter is in JSON array format. Each element is a <c>PeriodParam</c> object that contains the <c>periodUnit</c> and <c>baseTime</c> fields.</description></item>
        /// <item><description>The <c>resourceTypes</c> parameter is in JSON array format and contains multiple resource type strings.</description></item>
        /// <item><description>The <c>startTime</c> and <c>endTime</c> parameters are in timestamp format and specify the time range for the query.</description></item>
        /// <item><description>Pagination parameters include <c>nextToken</c>, <c>maxResults</c>, <c>pageNo</c>, and <c>pageSize</c>, which control the number and pagination of returned results.</description></item>
        /// <item><description>If the <c>resourceTypes</c> parameter contains invalid values or the <c>periods</c> parameter fails JSON parsing, a <c>SalesClientException</c> exception is thrown.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDeductionStatisticRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDeductionStatisticResponse
        /// </returns>
        public DescribeDeductionStatisticResponse DescribeDeductionStatistic(DescribeDeductionStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeductionStatisticWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves resource deduction and usage statistics based on specified conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation supports GET and POST methods.</description></item>
        /// <item><description>The <c>periods</c> parameter is in JSON array format. Each element is a <c>PeriodParam</c> object that contains the <c>periodUnit</c> and <c>baseTime</c> fields.</description></item>
        /// <item><description>The <c>resourceTypes</c> parameter is in JSON array format and contains multiple resource type strings.</description></item>
        /// <item><description>The <c>startTime</c> and <c>endTime</c> parameters are in timestamp format and specify the time range for the query.</description></item>
        /// <item><description>Pagination parameters include <c>nextToken</c>, <c>maxResults</c>, <c>pageNo</c>, and <c>pageSize</c>, which control the number and pagination of returned results.</description></item>
        /// <item><description>If the <c>resourceTypes</c> parameter contains invalid values or the <c>periods</c> parameter fails JSON parsing, a <c>SalesClientException</c> exception is thrown.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDeductionStatisticRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDeductionStatisticResponse
        /// </returns>
        public async Task<DescribeDeductionStatisticResponse> DescribeDeductionStatisticAsync(DescribeDeductionStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeductionStatisticWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries logistics address information.</para>
        /// </summary>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDeliveryAddressResponse
        /// </returns>
        public DescribeDeliveryAddressResponse DescribeDeliveryAddressWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDeliveryAddress",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDeliveryAddressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries logistics address information.</para>
        /// </summary>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDeliveryAddressResponse
        /// </returns>
        public async Task<DescribeDeliveryAddressResponse> DescribeDeliveryAddressWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDeliveryAddress",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDeliveryAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries logistics address information.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeDeliveryAddressResponse
        /// </returns>
        public DescribeDeliveryAddressResponse DescribeDeliveryAddress()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeliveryAddressWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries logistics address information.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeDeliveryAddressResponse
        /// </returns>
        public async Task<DescribeDeliveryAddressResponse> DescribeDeliveryAddressAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeliveryAddressWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries deduction group information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;Before you call this operation, make sure that you fully understand the billing methods and <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a> of Elastic Desktop Service.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeGroupsResponse
        /// </returns>
        public DescribeGroupsResponse DescribeGroupsWithOptions(DescribeGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupResourceTypes))
            {
                query["GroupResourceTypes"] = request.GroupResourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.States))
            {
                query["States"] = request.States;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeUsingPeriod))
            {
                query["TimeUsingPeriod"] = request.TimeUsingPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGroups",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries deduction group information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;Before you call this operation, make sure that you fully understand the billing methods and <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a> of Elastic Desktop Service.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeGroupsResponse
        /// </returns>
        public async Task<DescribeGroupsResponse> DescribeGroupsWithOptionsAsync(DescribeGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupResourceTypes))
            {
                query["GroupResourceTypes"] = request.GroupResourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.States))
            {
                query["States"] = request.States;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeUsingPeriod))
            {
                query["TimeUsingPeriod"] = request.TimeUsingPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGroups",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries deduction group information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;Before you call this operation, make sure that you fully understand the billing methods and <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a> of Elastic Desktop Service.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeGroupsResponse
        /// </returns>
        public DescribeGroupsResponse DescribeGroups(DescribeGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGroupsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries deduction group information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;Before you call this operation, make sure that you fully understand the billing methods and <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a> of Elastic Desktop Service.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeGroupsResponse
        /// </returns>
        public async Task<DescribeGroupsResponse> DescribeGroupsAsync(DescribeGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGroupsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the renewal methods.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Filters instances by resource type, instance, and region, and uses paging to query the auto-renewal status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceAutoRenewalAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceAutoRenewalAttributeResponse
        /// </returns>
        public DescribeInstanceAutoRenewalAttributeResponse DescribeInstanceAutoRenewalAttributeWithOptions(DescribeInstanceAutoRenewalAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewal))
            {
                query["AutoRenewal"] = request.AutoRenewal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                query["InstanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypeList))
            {
                query["ResourceTypeList"] = request.ResourceTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchRegionId))
            {
                query["SearchRegionId"] = request.SearchRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceAutoRenewalAttribute",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceAutoRenewalAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the renewal methods.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Filters instances by resource type, instance, and region, and uses paging to query the auto-renewal status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceAutoRenewalAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceAutoRenewalAttributeResponse
        /// </returns>
        public async Task<DescribeInstanceAutoRenewalAttributeResponse> DescribeInstanceAutoRenewalAttributeWithOptionsAsync(DescribeInstanceAutoRenewalAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewal))
            {
                query["AutoRenewal"] = request.AutoRenewal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                query["InstanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypeList))
            {
                query["ResourceTypeList"] = request.ResourceTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchRegionId))
            {
                query["SearchRegionId"] = request.SearchRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceAutoRenewalAttribute",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceAutoRenewalAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the renewal methods.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Filters instances by resource type, instance, and region, and uses paging to query the auto-renewal status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceAutoRenewalAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceAutoRenewalAttributeResponse
        /// </returns>
        public DescribeInstanceAutoRenewalAttributeResponse DescribeInstanceAutoRenewalAttribute(DescribeInstanceAutoRenewalAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceAutoRenewalAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the renewal methods.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Filters instances by resource type, instance, and region, and uses paging to query the auto-renewal status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceAutoRenewalAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceAutoRenewalAttributeResponse
        /// </returns>
        public async Task<DescribeInstanceAutoRenewalAttributeResponse> DescribeInstanceAutoRenewalAttributeAsync(DescribeInstanceAutoRenewalAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceAutoRenewalAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries sold instances and their quotas and properties by paging based on resource type, instance ID, business resource ID, and status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries sold instances and their quotas and properties by paging based on resource type, instance ID, business resource ID, and status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancesResponse
        /// </returns>
        public DescribeInstancesResponse DescribeInstancesWithOptions(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoResourceId))
            {
                query["NoResourceId"] = request.NoResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyKeyList))
            {
                query["PropertyKeyList"] = request.PropertyKeyList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StateList))
            {
                query["StateList"] = request.StateList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstances",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries sold instances and their quotas and properties by paging based on resource type, instance ID, business resource ID, and status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries sold instances and their quotas and properties by paging based on resource type, instance ID, business resource ID, and status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancesResponse
        /// </returns>
        public async Task<DescribeInstancesResponse> DescribeInstancesWithOptionsAsync(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoResourceId))
            {
                query["NoResourceId"] = request.NoResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyKeyList))
            {
                query["PropertyKeyList"] = request.PropertyKeyList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StateList))
            {
                query["StateList"] = request.StateList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstances",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries sold instances and their quotas and properties by paging based on resource type, instance ID, business resource ID, and status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries sold instances and their quotas and properties by paging based on resource type, instance ID, business resource ID, and status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancesResponse
        /// </returns>
        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries sold instances and their quotas and properties by paging based on resource type, instance ID, business resource ID, and status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries sold instances and their quotas and properties by paging based on resource type, instance ID, business resource ID, and status.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancesResponse
        /// </returns>
        public async Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the prices of Elastic Desktop Service products for order types such as new purchases, renewals, configuration changes, and unsubscriptions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;Before you call this operation, make sure that you fully understand the billing methods and <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a> of Elastic Desktop Service.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMultiPriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMultiPriceResponse
        /// </returns>
        public DescribeMultiPriceResponse DescribeMultiPriceWithOptions(DescribeMultiPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderItems))
            {
                query["OrderItems"] = request.OrderItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageCode))
            {
                query["PackageCode"] = request.PackageCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResellerOwnerUid))
            {
                query["ResellerOwnerUid"] = request.ResellerOwnerUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMultiPrice",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMultiPriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the prices of Elastic Desktop Service products for order types such as new purchases, renewals, configuration changes, and unsubscriptions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;Before you call this operation, make sure that you fully understand the billing methods and <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a> of Elastic Desktop Service.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMultiPriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMultiPriceResponse
        /// </returns>
        public async Task<DescribeMultiPriceResponse> DescribeMultiPriceWithOptionsAsync(DescribeMultiPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderItems))
            {
                query["OrderItems"] = request.OrderItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageCode))
            {
                query["PackageCode"] = request.PackageCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResellerOwnerUid))
            {
                query["ResellerOwnerUid"] = request.ResellerOwnerUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMultiPrice",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMultiPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the prices of Elastic Desktop Service products for order types such as new purchases, renewals, configuration changes, and unsubscriptions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;Before you call this operation, make sure that you fully understand the billing methods and <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a> of Elastic Desktop Service.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMultiPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMultiPriceResponse
        /// </returns>
        public DescribeMultiPriceResponse DescribeMultiPrice(DescribeMultiPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMultiPriceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the prices of Elastic Desktop Service products for order types such as new purchases, renewals, configuration changes, and unsubscriptions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;Before you call this operation, make sure that you fully understand the billing methods and <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a> of Elastic Desktop Service.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMultiPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMultiPriceResponse
        /// </returns>
        public async Task<DescribeMultiPriceResponse> DescribeMultiPriceAsync(DescribeMultiPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMultiPriceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the deduction details of core-hour packages.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePackageDeductionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePackageDeductionsResponse
        /// </returns>
        public DescribePackageDeductionsResponse DescribePackageDeductionsWithOptions(DescribePackageDeductionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentType))
            {
                query["AgentType"] = request.AgentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentTypes))
            {
                query["AgentTypes"] = request.AgentTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumeWyId))
            {
                query["ConsumeWyId"] = request.ConsumeWyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumeWyIds))
            {
                query["ConsumeWyIds"] = request.ConsumeWyIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeductionRequestId))
            {
                query["DeductionRequestId"] = request.DeductionRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeductionTypes))
            {
                query["DeductionTypes"] = request.DeductionTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupResourceTypes))
            {
                query["GroupResourceTypes"] = request.GroupResourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdType))
            {
                query["InstanceIdType"] = request.InstanceIdType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageIds))
            {
                query["PackageIds"] = request.PackageIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["RunId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunIdList))
            {
                query["RunIdList"] = request.RunIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WyId))
            {
                query["WyId"] = request.WyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePackageDeductions",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePackageDeductionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the deduction details of core-hour packages.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePackageDeductionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePackageDeductionsResponse
        /// </returns>
        public async Task<DescribePackageDeductionsResponse> DescribePackageDeductionsWithOptionsAsync(DescribePackageDeductionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentType))
            {
                query["AgentType"] = request.AgentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentTypes))
            {
                query["AgentTypes"] = request.AgentTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumeWyId))
            {
                query["ConsumeWyId"] = request.ConsumeWyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumeWyIds))
            {
                query["ConsumeWyIds"] = request.ConsumeWyIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeductionRequestId))
            {
                query["DeductionRequestId"] = request.DeductionRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeductionTypes))
            {
                query["DeductionTypes"] = request.DeductionTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupResourceTypes))
            {
                query["GroupResourceTypes"] = request.GroupResourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdType))
            {
                query["InstanceIdType"] = request.InstanceIdType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageIds))
            {
                query["PackageIds"] = request.PackageIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["RunId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunIdList))
            {
                query["RunIdList"] = request.RunIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WyId))
            {
                query["WyId"] = request.WyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePackageDeductions",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePackageDeductionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the deduction details of core-hour packages.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePackageDeductionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePackageDeductionsResponse
        /// </returns>
        public DescribePackageDeductionsResponse DescribePackageDeductions(DescribePackageDeductionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePackageDeductionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the deduction details of core-hour packages.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePackageDeductionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePackageDeductionsResponse
        /// </returns>
        public async Task<DescribePackageDeductionsResponse> DescribePackageDeductionsAsync(DescribePackageDeductionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePackageDeductionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries AI credit deductions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation supports the GET and POST methods.</description></item>
        /// <item><description>The periods parameter is in JSON array format. Each element is a PeriodParam object that contains the periodUnit and baseTime fields.</description></item>
        /// <item><description>The resourceTypes parameter is in JSON array format and contains multiple resource type strings.</description></item>
        /// <item><description>The startTime and endTime parameters are in timestamp format and specify the time range for the query.</description></item>
        /// <item><description>The pagination parameters include nextToken, maxResults, pageNo, and pageSize, which are used to control the number of returned results and pagination.</description></item>
        /// <item><description>If the resourceTypes parameter contains invalid values or the JSON parsing of the periods parameter fails, a SalesClientException is thrown.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeRunIdDeductionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRunIdDeductionsResponse
        /// </returns>
        public DescribeRunIdDeductionsResponse DescribeRunIdDeductionsWithOptions(DescribeRunIdDeductionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentType))
            {
                query["AgentType"] = request.AgentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentTypes))
            {
                query["AgentTypes"] = request.AgentTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                query["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumeWyId))
            {
                query["ConsumeWyId"] = request.ConsumeWyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumeWyIds))
            {
                query["ConsumeWyIds"] = request.ConsumeWyIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeductionRequestId))
            {
                query["DeductionRequestId"] = request.DeductionRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeductionTypes))
            {
                query["DeductionTypes"] = request.DeductionTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupByFields))
            {
                query["GroupByFields"] = request.GroupByFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupResourceTypes))
            {
                query["GroupResourceTypes"] = request.GroupResourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupSeparator))
            {
                query["GroupSeparator"] = request.GroupSeparator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdType))
            {
                query["InstanceIdType"] = request.InstanceIdType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageIds))
            {
                query["PackageIds"] = request.PackageIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["RunId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunIdList))
            {
                query["RunIdList"] = request.RunIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WyId))
            {
                query["WyId"] = request.WyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRunIdDeductions",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRunIdDeductionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries AI credit deductions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation supports the GET and POST methods.</description></item>
        /// <item><description>The periods parameter is in JSON array format. Each element is a PeriodParam object that contains the periodUnit and baseTime fields.</description></item>
        /// <item><description>The resourceTypes parameter is in JSON array format and contains multiple resource type strings.</description></item>
        /// <item><description>The startTime and endTime parameters are in timestamp format and specify the time range for the query.</description></item>
        /// <item><description>The pagination parameters include nextToken, maxResults, pageNo, and pageSize, which are used to control the number of returned results and pagination.</description></item>
        /// <item><description>If the resourceTypes parameter contains invalid values or the JSON parsing of the periods parameter fails, a SalesClientException is thrown.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeRunIdDeductionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRunIdDeductionsResponse
        /// </returns>
        public async Task<DescribeRunIdDeductionsResponse> DescribeRunIdDeductionsWithOptionsAsync(DescribeRunIdDeductionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentType))
            {
                query["AgentType"] = request.AgentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentTypes))
            {
                query["AgentTypes"] = request.AgentTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                query["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumeWyId))
            {
                query["ConsumeWyId"] = request.ConsumeWyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumeWyIds))
            {
                query["ConsumeWyIds"] = request.ConsumeWyIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeductionRequestId))
            {
                query["DeductionRequestId"] = request.DeductionRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeductionTypes))
            {
                query["DeductionTypes"] = request.DeductionTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupByFields))
            {
                query["GroupByFields"] = request.GroupByFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupResourceTypes))
            {
                query["GroupResourceTypes"] = request.GroupResourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupSeparator))
            {
                query["GroupSeparator"] = request.GroupSeparator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdType))
            {
                query["InstanceIdType"] = request.InstanceIdType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageIds))
            {
                query["PackageIds"] = request.PackageIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                query["ResourceTypes"] = request.ResourceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["RunId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunIdList))
            {
                query["RunIdList"] = request.RunIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WyId))
            {
                query["WyId"] = request.WyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRunIdDeductions",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRunIdDeductionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries AI credit deductions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation supports the GET and POST methods.</description></item>
        /// <item><description>The periods parameter is in JSON array format. Each element is a PeriodParam object that contains the periodUnit and baseTime fields.</description></item>
        /// <item><description>The resourceTypes parameter is in JSON array format and contains multiple resource type strings.</description></item>
        /// <item><description>The startTime and endTime parameters are in timestamp format and specify the time range for the query.</description></item>
        /// <item><description>The pagination parameters include nextToken, maxResults, pageNo, and pageSize, which are used to control the number of returned results and pagination.</description></item>
        /// <item><description>If the resourceTypes parameter contains invalid values or the JSON parsing of the periods parameter fails, a SalesClientException is thrown.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeRunIdDeductionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRunIdDeductionsResponse
        /// </returns>
        public DescribeRunIdDeductionsResponse DescribeRunIdDeductions(DescribeRunIdDeductionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRunIdDeductionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries AI credit deductions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation supports the GET and POST methods.</description></item>
        /// <item><description>The periods parameter is in JSON array format. Each element is a PeriodParam object that contains the periodUnit and baseTime fields.</description></item>
        /// <item><description>The resourceTypes parameter is in JSON array format and contains multiple resource type strings.</description></item>
        /// <item><description>The startTime and endTime parameters are in timestamp format and specify the time range for the query.</description></item>
        /// <item><description>The pagination parameters include nextToken, maxResults, pageNo, and pageSize, which are used to control the number of returned results and pagination.</description></item>
        /// <item><description>If the resourceTypes parameter contains invalid values or the JSON parsing of the periods parameter fails, a SalesClientException is thrown.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeRunIdDeductionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRunIdDeductionsResponse
        /// </returns>
        public async Task<DescribeRunIdDeductionsResponse> DescribeRunIdDeductionsAsync(DescribeRunIdDeductionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRunIdDeductionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstancePropertiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstancePropertiesResponse
        /// </returns>
        public ModifyInstancePropertiesResponse ModifyInstancePropertiesWithOptions(ModifyInstancePropertiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                query["Properties"] = request.Properties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceProperties",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstancePropertiesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstancePropertiesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstancePropertiesResponse
        /// </returns>
        public async Task<ModifyInstancePropertiesResponse> ModifyInstancePropertiesWithOptionsAsync(ModifyInstancePropertiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                query["Properties"] = request.Properties;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceProperties",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstancePropertiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstancePropertiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstancePropertiesResponse
        /// </returns>
        public ModifyInstancePropertiesResponse ModifyInstanceProperties(ModifyInstancePropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstancePropertiesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstancePropertiesRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstancePropertiesResponse
        /// </returns>
        public async Task<ModifyInstancePropertiesResponse> ModifyInstancePropertiesAsync(ModifyInstancePropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstancePropertiesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the credit usage quota for a specified Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>You can use this API operation to set the credit usage quota for a specific type of Agent. Batch setting of quotas for multiple Agents is supported.</para>
        /// <h3>Before you begin</h3>
        /// <list type="bullet">
        /// <item><description>The <c>AgentType</c> parameter specifies the type of Agent for which you want to set the quota, such as <c>JVSClaw</c> or <c>OpenClaw</c>.</description></item>
        /// <item><description>The <c>AgentIds</c> parameter is an array that can contain up to 100 Agent IDs.</description></item>
        /// <item><description>The <c>CreditQuota</c> parameter specifies the credit usage quota for each Agent.</description></item>
        /// </list>
        /// <h3>Examples</h3>
        /// </description>
        /// 
        /// <param name="request">
        /// SetAgentCreditQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetAgentCreditQuotaResponse
        /// </returns>
        public SetAgentCreditQuotaResponse SetAgentCreditQuotaWithOptions(SetAgentCreditQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentIds))
            {
                query["AgentIds"] = request.AgentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentType))
            {
                query["AgentType"] = request.AgentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditQuota))
            {
                query["CreditQuota"] = request.CreditQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetAgentCreditQuota",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAgentCreditQuotaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the credit usage quota for a specified Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>You can use this API operation to set the credit usage quota for a specific type of Agent. Batch setting of quotas for multiple Agents is supported.</para>
        /// <h3>Before you begin</h3>
        /// <list type="bullet">
        /// <item><description>The <c>AgentType</c> parameter specifies the type of Agent for which you want to set the quota, such as <c>JVSClaw</c> or <c>OpenClaw</c>.</description></item>
        /// <item><description>The <c>AgentIds</c> parameter is an array that can contain up to 100 Agent IDs.</description></item>
        /// <item><description>The <c>CreditQuota</c> parameter specifies the credit usage quota for each Agent.</description></item>
        /// </list>
        /// <h3>Examples</h3>
        /// </description>
        /// 
        /// <param name="request">
        /// SetAgentCreditQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetAgentCreditQuotaResponse
        /// </returns>
        public async Task<SetAgentCreditQuotaResponse> SetAgentCreditQuotaWithOptionsAsync(SetAgentCreditQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentIds))
            {
                query["AgentIds"] = request.AgentIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentType))
            {
                query["AgentType"] = request.AgentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditQuota))
            {
                query["CreditQuota"] = request.CreditQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneType))
            {
                query["SceneType"] = request.SceneType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetAgentCreditQuota",
                Version = "2021-12-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAgentCreditQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the credit usage quota for a specified Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>You can use this API operation to set the credit usage quota for a specific type of Agent. Batch setting of quotas for multiple Agents is supported.</para>
        /// <h3>Before you begin</h3>
        /// <list type="bullet">
        /// <item><description>The <c>AgentType</c> parameter specifies the type of Agent for which you want to set the quota, such as <c>JVSClaw</c> or <c>OpenClaw</c>.</description></item>
        /// <item><description>The <c>AgentIds</c> parameter is an array that can contain up to 100 Agent IDs.</description></item>
        /// <item><description>The <c>CreditQuota</c> parameter specifies the credit usage quota for each Agent.</description></item>
        /// </list>
        /// <h3>Examples</h3>
        /// </description>
        /// 
        /// <param name="request">
        /// SetAgentCreditQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// SetAgentCreditQuotaResponse
        /// </returns>
        public SetAgentCreditQuotaResponse SetAgentCreditQuota(SetAgentCreditQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAgentCreditQuotaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the credit usage quota for a specified Agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>You can use this API operation to set the credit usage quota for a specific type of Agent. Batch setting of quotas for multiple Agents is supported.</para>
        /// <h3>Before you begin</h3>
        /// <list type="bullet">
        /// <item><description>The <c>AgentType</c> parameter specifies the type of Agent for which you want to set the quota, such as <c>JVSClaw</c> or <c>OpenClaw</c>.</description></item>
        /// <item><description>The <c>AgentIds</c> parameter is an array that can contain up to 100 Agent IDs.</description></item>
        /// <item><description>The <c>CreditQuota</c> parameter specifies the credit usage quota for each Agent.</description></item>
        /// </list>
        /// <h3>Examples</h3>
        /// </description>
        /// 
        /// <param name="request">
        /// SetAgentCreditQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// SetAgentCreditQuotaResponse
        /// </returns>
        public async Task<SetAgentCreditQuotaResponse> SetAgentCreditQuotaAsync(SetAgentCreditQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAgentCreditQuotaWithOptionsAsync(request, runtime);
        }

    }
}
