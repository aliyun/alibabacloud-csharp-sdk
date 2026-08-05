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
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-shanghai", "wss.cn-shanghai.aliyuncs.com"},
                {"ap-southeast-1", "wss.ap-southeast-1.aliyuncs.com"},
            };
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
        /// <para>Places, renews, or modifies orders for specific products of Elastic Desktop Service (EDS) Enterprise Edition, such as monthly duration packages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;Before you use this operation, make sure that you fully understand the billing methods and <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a> of EDS.
        /// &lt;props=&quot;intl&quot;&gt;Before you use this operation, make sure that you fully understand the billing methods and <a href="https://www.alibabacloud.com/zh/product/cloud-desktop?#J_8623712560">pricing</a> of EDS.
        /// If automatic payment is not specified, this operation does not process the payment. You must use the order ID returned by this operation to construct a payment redirect URL and complete the payment before the order takes effect and the resources are provisioned.</para>
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
        /// <para>Places, renews, or modifies orders for specific products of Elastic Desktop Service (EDS) Enterprise Edition, such as monthly duration packages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;Before you use this operation, make sure that you fully understand the billing methods and <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a> of EDS.
        /// &lt;props=&quot;intl&quot;&gt;Before you use this operation, make sure that you fully understand the billing methods and <a href="https://www.alibabacloud.com/zh/product/cloud-desktop?#J_8623712560">pricing</a> of EDS.
        /// If automatic payment is not specified, this operation does not process the payment. You must use the order ID returned by this operation to construct a payment redirect URL and complete the payment before the order takes effect and the resources are provisioned.</para>
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
        /// <para>Places, renews, or modifies orders for specific products of Elastic Desktop Service (EDS) Enterprise Edition, such as monthly duration packages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;Before you use this operation, make sure that you fully understand the billing methods and <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a> of EDS.
        /// &lt;props=&quot;intl&quot;&gt;Before you use this operation, make sure that you fully understand the billing methods and <a href="https://www.alibabacloud.com/zh/product/cloud-desktop?#J_8623712560">pricing</a> of EDS.
        /// If automatic payment is not specified, this operation does not process the payment. You must use the order ID returned by this operation to construct a payment redirect URL and complete the payment before the order takes effect and the resources are provisioned.</para>
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
        /// <para>Places, renews, or modifies orders for specific products of Elastic Desktop Service (EDS) Enterprise Edition, such as monthly duration packages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;Before you use this operation, make sure that you fully understand the billing methods and <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a> of EDS.
        /// &lt;props=&quot;intl&quot;&gt;Before you use this operation, make sure that you fully understand the billing methods and <a href="https://www.alibabacloud.com/zh/product/cloud-desktop?#J_8623712560">pricing</a> of EDS.
        /// If automatic payment is not specified, this operation does not process the payment. You must use the order ID returned by this operation to construct a payment redirect URL and complete the payment before the order takes effect and the resources are provisioned.</para>
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
        /// <para>Queries the list of Agents and usage summary information under the current username.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><b>Paging support</b>: Use the <c>NextToken</c> and <c>MaxResults</c> parameters for paging. Set <c>NextToken</c> to an empty character string for the first request.</description></item>
        /// <item><description><b>Filtering</b>: Use the <c>AgentType</c> and <c>AgentIds</c> parameters to filter the returned Agent list.</description></item>
        /// <item><description><b>Status filtering</b>: Use the <c>Status</c> parameter to filter Agents by status (0: deleted, 1: active).</description></item>
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
        /// <para>Queries the list of Agents and usage summary information under the current username.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><b>Paging support</b>: Use the <c>NextToken</c> and <c>MaxResults</c> parameters for paging. Set <c>NextToken</c> to an empty character string for the first request.</description></item>
        /// <item><description><b>Filtering</b>: Use the <c>AgentType</c> and <c>AgentIds</c> parameters to filter the returned Agent list.</description></item>
        /// <item><description><b>Status filtering</b>: Use the <c>Status</c> parameter to filter Agents by status (0: deleted, 1: active).</description></item>
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
        /// <para>Queries the list of Agents and usage summary information under the current username.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><b>Paging support</b>: Use the <c>NextToken</c> and <c>MaxResults</c> parameters for paging. Set <c>NextToken</c> to an empty character string for the first request.</description></item>
        /// <item><description><b>Filtering</b>: Use the <c>AgentType</c> and <c>AgentIds</c> parameters to filter the returned Agent list.</description></item>
        /// <item><description><b>Status filtering</b>: Use the <c>Status</c> parameter to filter Agents by status (0: deleted, 1: active).</description></item>
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
        /// <para>Queries the list of Agents and usage summary information under the current username.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description><b>Paging support</b>: Use the <c>NextToken</c> and <c>MaxResults</c> parameters for paging. Set <c>NextToken</c> to an empty character string for the first request.</description></item>
        /// <item><description><b>Filtering</b>: Use the <c>AgentType</c> and <c>AgentIds</c> parameters to filter the returned Agent list.</description></item>
        /// <item><description><b>Status filtering</b>: Use the <c>Status</c> parameter to filter Agents by status (0: deleted, 1: active).</description></item>
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
        /// <para>Queries credit usage details by a specified dimension such as user, credit package, or agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries credit usage details based on the dimension specified by <c>UsageType</c> (User / CreditPackage / Agent). The response includes the total credits, remaining credits, used credits of the current credit package, hourly consumption samples, alert thresholds, and period quotas.</para>
        /// <list type="bullet">
        /// <item><description><b>User</b>: User dimension. Returns the aggregated usage and remaining credits across all active credit packages for the current user.</description></item>
        /// <item><description><b>CreditPackage</b>: Credit package dimension. Returns the total credits, remaining credits, and consumption samples for the specified credit package instance.</description></item>
        /// <item><description><b>Agent</b>: Agent dimension. Returns the cumulative usage, current period usage, quota, and alert information for the specified agent.
        /// <b>Notes</b>:</description></item>
        /// <item><description>The <c>InstanceIds</c> parameter can be omitted when <c>UsageType=User</c>. Pass the credit package instance ID when <c>UsageType=CreditPackage</c>, or pass the AgentId when <c>UsageType=Agent</c>.</description></item>
        /// <item><description>Anonymous requests support the <c>FillInstance</c> parameter. When <c>InstanceIds</c> is not explicitly provided and <c>FillInstance=true</c>, the server automatically populates the bound <c>JVS_COPILOT</c> AgentId based on the current logged-in <c>wyId</c>.</description></item>
        /// <item><description>Time window constants: The <c>dayUsedCredit</c> statistics window is <c>now - ONE_DAY_MILLIS</c>, and the <c>weekUsedCredit</c> statistics window is <c>now - ONE_WEEK_MILLIS</c>.</description></item>
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
        /// <para>Queries credit usage details by a specified dimension such as user, credit package, or agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries credit usage details based on the dimension specified by <c>UsageType</c> (User / CreditPackage / Agent). The response includes the total credits, remaining credits, used credits of the current credit package, hourly consumption samples, alert thresholds, and period quotas.</para>
        /// <list type="bullet">
        /// <item><description><b>User</b>: User dimension. Returns the aggregated usage and remaining credits across all active credit packages for the current user.</description></item>
        /// <item><description><b>CreditPackage</b>: Credit package dimension. Returns the total credits, remaining credits, and consumption samples for the specified credit package instance.</description></item>
        /// <item><description><b>Agent</b>: Agent dimension. Returns the cumulative usage, current period usage, quota, and alert information for the specified agent.
        /// <b>Notes</b>:</description></item>
        /// <item><description>The <c>InstanceIds</c> parameter can be omitted when <c>UsageType=User</c>. Pass the credit package instance ID when <c>UsageType=CreditPackage</c>, or pass the AgentId when <c>UsageType=Agent</c>.</description></item>
        /// <item><description>Anonymous requests support the <c>FillInstance</c> parameter. When <c>InstanceIds</c> is not explicitly provided and <c>FillInstance=true</c>, the server automatically populates the bound <c>JVS_COPILOT</c> AgentId based on the current logged-in <c>wyId</c>.</description></item>
        /// <item><description>Time window constants: The <c>dayUsedCredit</c> statistics window is <c>now - ONE_DAY_MILLIS</c>, and the <c>weekUsedCredit</c> statistics window is <c>now - ONE_WEEK_MILLIS</c>.</description></item>
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
        /// <para>Queries credit usage details by a specified dimension such as user, credit package, or agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries credit usage details based on the dimension specified by <c>UsageType</c> (User / CreditPackage / Agent). The response includes the total credits, remaining credits, used credits of the current credit package, hourly consumption samples, alert thresholds, and period quotas.</para>
        /// <list type="bullet">
        /// <item><description><b>User</b>: User dimension. Returns the aggregated usage and remaining credits across all active credit packages for the current user.</description></item>
        /// <item><description><b>CreditPackage</b>: Credit package dimension. Returns the total credits, remaining credits, and consumption samples for the specified credit package instance.</description></item>
        /// <item><description><b>Agent</b>: Agent dimension. Returns the cumulative usage, current period usage, quota, and alert information for the specified agent.
        /// <b>Notes</b>:</description></item>
        /// <item><description>The <c>InstanceIds</c> parameter can be omitted when <c>UsageType=User</c>. Pass the credit package instance ID when <c>UsageType=CreditPackage</c>, or pass the AgentId when <c>UsageType=Agent</c>.</description></item>
        /// <item><description>Anonymous requests support the <c>FillInstance</c> parameter. When <c>InstanceIds</c> is not explicitly provided and <c>FillInstance=true</c>, the server automatically populates the bound <c>JVS_COPILOT</c> AgentId based on the current logged-in <c>wyId</c>.</description></item>
        /// <item><description>Time window constants: The <c>dayUsedCredit</c> statistics window is <c>now - ONE_DAY_MILLIS</c>, and the <c>weekUsedCredit</c> statistics window is <c>now - ONE_WEEK_MILLIS</c>.</description></item>
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
        /// <para>Queries credit usage details by a specified dimension such as user, credit package, or agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This API queries credit usage details based on the dimension specified by <c>UsageType</c> (User / CreditPackage / Agent). The response includes the total credits, remaining credits, used credits of the current credit package, hourly consumption samples, alert thresholds, and period quotas.</para>
        /// <list type="bullet">
        /// <item><description><b>User</b>: User dimension. Returns the aggregated usage and remaining credits across all active credit packages for the current user.</description></item>
        /// <item><description><b>CreditPackage</b>: Credit package dimension. Returns the total credits, remaining credits, and consumption samples for the specified credit package instance.</description></item>
        /// <item><description><b>Agent</b>: Agent dimension. Returns the cumulative usage, current period usage, quota, and alert information for the specified agent.
        /// <b>Notes</b>:</description></item>
        /// <item><description>The <c>InstanceIds</c> parameter can be omitted when <c>UsageType=User</c>. Pass the credit package instance ID when <c>UsageType=CreditPackage</c>, or pass the AgentId when <c>UsageType=Agent</c>.</description></item>
        /// <item><description>Anonymous requests support the <c>FillInstance</c> parameter. When <c>InstanceIds</c> is not explicitly provided and <c>FillInstance=true</c>, the server automatically populates the bound <c>JVS_COPILOT</c> AgentId based on the current logged-in <c>wyId</c>.</description></item>
        /// <item><description>Time window constants: The <c>dayUsedCredit</c> statistics window is <c>now - ONE_DAY_MILLIS</c>, and the <c>weekUsedCredit</c> statistics window is <c>now - ONE_WEEK_MILLIS</c>.</description></item>
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
        /// <item><description>When the <c>resourceTypes</c> parameter contains invalid values or the <c>periods</c> parameter fails JSON parsing, a <c>SalesClientException</c> exception is thrown.</description></item>
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
        /// <item><description>When the <c>resourceTypes</c> parameter contains invalid values or the <c>periods</c> parameter fails JSON parsing, a <c>SalesClientException</c> exception is thrown.</description></item>
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
        /// <item><description>When the <c>resourceTypes</c> parameter contains invalid values or the <c>periods</c> parameter fails JSON parsing, a <c>SalesClientException</c> exception is thrown.</description></item>
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
        /// <item><description>When the <c>resourceTypes</c> parameter contains invalid values or the <c>periods</c> parameter fails JSON parsing, a <c>SalesClientException</c> exception is thrown.</description></item>
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
        /// <para>Retrieves information about delivery addresses.</para>
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
        /// <para>Retrieves information about delivery addresses.</para>
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
        /// <para>Retrieves information about delivery addresses.</para>
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
        /// <para>Retrieves information about delivery addresses.</para>
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
        /// <para>Queries the prices of Elastic Desktop Service products, including prices for new purchases, renewals, specification changes, and unsubscriptions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;Before you call this operation, make sure that you fully understand the billing of Elastic Desktop Service and its <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a>.</para>
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
        /// <para>Queries the prices of Elastic Desktop Service products, including prices for new purchases, renewals, specification changes, and unsubscriptions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;Before you call this operation, make sure that you fully understand the billing of Elastic Desktop Service and its <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a>.</para>
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
        /// <para>Queries the prices of Elastic Desktop Service products, including prices for new purchases, renewals, specification changes, and unsubscriptions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;Before you call this operation, make sure that you fully understand the billing of Elastic Desktop Service and its <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a>.</para>
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
        /// <para>Queries the prices of Elastic Desktop Service products, including prices for new purchases, renewals, specification changes, and unsubscriptions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;Before you call this operation, make sure that you fully understand the billing of Elastic Desktop Service and its <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a>.</para>
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
        /// <para>Queries the deduction details of a core-hour package.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
        /// <para>Queries the deduction details of a core-hour package.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
        /// <para>Queries the deduction details of a core-hour package.</para>
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
        /// <para>Queries the deduction details of a core-hour package.</para>
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
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation supports GET and POST methods.</description></item>
        /// <item><description>The <c>periods</c> parameter is in JSON array format. Each element is a <c>PeriodParam</c> object that contains the <c>periodUnit</c> and <c>baseTime</c> fields.</description></item>
        /// <item><description>The <c>resourceTypes</c> parameter is in JSON array format and contains multiple resource type strings.</description></item>
        /// <item><description>The <c>startTime</c> and <c>endTime</c> parameters are in timestamp format and specify the time range for the query.</description></item>
        /// <item><description>Pagination parameters include <c>nextToken</c>, <c>maxResults</c>, <c>pageNo</c>, and <c>pageSize</c>, which control the number and pagination of returned results.</description></item>
        /// <item><description>A <c>SalesClientException</c> exception is thrown when the <c>resourceTypes</c> parameter contains invalid values or the <c>periods</c> parameter fails JSON parsing.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                query["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeductionTypes))
            {
                query["DeductionTypes"] = request.DeductionTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupSeparator))
            {
                query["GroupSeparator"] = request.GroupSeparator;
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
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation supports GET and POST methods.</description></item>
        /// <item><description>The <c>periods</c> parameter is in JSON array format. Each element is a <c>PeriodParam</c> object that contains the <c>periodUnit</c> and <c>baseTime</c> fields.</description></item>
        /// <item><description>The <c>resourceTypes</c> parameter is in JSON array format and contains multiple resource type strings.</description></item>
        /// <item><description>The <c>startTime</c> and <c>endTime</c> parameters are in timestamp format and specify the time range for the query.</description></item>
        /// <item><description>Pagination parameters include <c>nextToken</c>, <c>maxResults</c>, <c>pageNo</c>, and <c>pageSize</c>, which control the number and pagination of returned results.</description></item>
        /// <item><description>A <c>SalesClientException</c> exception is thrown when the <c>resourceTypes</c> parameter contains invalid values or the <c>periods</c> parameter fails JSON parsing.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                query["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeductionTypes))
            {
                query["DeductionTypes"] = request.DeductionTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupSeparator))
            {
                query["GroupSeparator"] = request.GroupSeparator;
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
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation supports GET and POST methods.</description></item>
        /// <item><description>The <c>periods</c> parameter is in JSON array format. Each element is a <c>PeriodParam</c> object that contains the <c>periodUnit</c> and <c>baseTime</c> fields.</description></item>
        /// <item><description>The <c>resourceTypes</c> parameter is in JSON array format and contains multiple resource type strings.</description></item>
        /// <item><description>The <c>startTime</c> and <c>endTime</c> parameters are in timestamp format and specify the time range for the query.</description></item>
        /// <item><description>Pagination parameters include <c>nextToken</c>, <c>maxResults</c>, <c>pageNo</c>, and <c>pageSize</c>, which control the number and pagination of returned results.</description></item>
        /// <item><description>A <c>SalesClientException</c> exception is thrown when the <c>resourceTypes</c> parameter contains invalid values or the <c>periods</c> parameter fails JSON parsing.</description></item>
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
        /// <h2>Operation description</h2>
        /// <list type="bullet">
        /// <item><description>This operation supports GET and POST methods.</description></item>
        /// <item><description>The <c>periods</c> parameter is in JSON array format. Each element is a <c>PeriodParam</c> object that contains the <c>periodUnit</c> and <c>baseTime</c> fields.</description></item>
        /// <item><description>The <c>resourceTypes</c> parameter is in JSON array format and contains multiple resource type strings.</description></item>
        /// <item><description>The <c>startTime</c> and <c>endTime</c> parameters are in timestamp format and specify the time range for the query.</description></item>
        /// <item><description>Pagination parameters include <c>nextToken</c>, <c>maxResults</c>, <c>pageNo</c>, and <c>pageSize</c>, which control the number and pagination of returned results.</description></item>
        /// <item><description>A <c>SalesClientException</c> exception is thrown when the <c>resourceTypes</c> parameter contains invalid values or the <c>periods</c> parameter fails JSON parsing.</description></item>
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
        /// <para>Sets the credit quota for specified Agents.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <para>This operation sets the credit quota for one or more Agents of a specific type.</para>
        /// <h3>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>The <c>AgentType</c> parameter specifies the type of Agent to which the quota applies, such as <c>JVSClaw</c> or <c>OpenClaw</c>.</description></item>
        /// <item><description>The <c>AgentIds</c> parameter is an array of up to 100 Agent IDs.</description></item>
        /// <item><description>The <c>CreditQuota</c> parameter specifies the credit quota for each Agent.</description></item>
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
        /// <para>Sets the credit quota for specified Agents.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <para>This operation sets the credit quota for one or more Agents of a specific type.</para>
        /// <h3>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>The <c>AgentType</c> parameter specifies the type of Agent to which the quota applies, such as <c>JVSClaw</c> or <c>OpenClaw</c>.</description></item>
        /// <item><description>The <c>AgentIds</c> parameter is an array of up to 100 Agent IDs.</description></item>
        /// <item><description>The <c>CreditQuota</c> parameter specifies the credit quota for each Agent.</description></item>
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
        /// <para>Sets the credit quota for specified Agents.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <para>This operation sets the credit quota for one or more Agents of a specific type.</para>
        /// <h3>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>The <c>AgentType</c> parameter specifies the type of Agent to which the quota applies, such as <c>JVSClaw</c> or <c>OpenClaw</c>.</description></item>
        /// <item><description>The <c>AgentIds</c> parameter is an array of up to 100 Agent IDs.</description></item>
        /// <item><description>The <c>CreditQuota</c> parameter specifies the credit quota for each Agent.</description></item>
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
        /// <para>Sets the credit quota for specified Agents.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <para>This operation sets the credit quota for one or more Agents of a specific type.</para>
        /// <h3>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>The <c>AgentType</c> parameter specifies the type of Agent to which the quota applies, such as <c>JVSClaw</c> or <c>OpenClaw</c>.</description></item>
        /// <item><description>The <c>AgentIds</c> parameter is an array of up to 100 Agent IDs.</description></item>
        /// <item><description>The <c>CreditQuota</c> parameter specifies the credit quota for each Agent.</description></item>
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
