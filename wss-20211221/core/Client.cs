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
        /// <para>Use this API to order, renew, and modify specific products, such as monthly resource plans for Elastic Desktop Service (EDS) Enterprise Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;
        /// Before calling this API, make sure you understand how Wuying Workspace is billed and its <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a>.
        /// &lt;props=&quot;intl&quot;&gt;
        /// Before calling this API, make sure you understand how Wuying Workspace is billed and its <a href="https://www.alibabacloud.com/zh/product/cloud-desktop?#J_8623712560">pricing</a>.
        /// If you do not specify automatic payment, this API does not handle the payment. You must use the returned order ID to construct a payment URL. The order becomes active and the resource is provisioned only after the payment is complete.</para>
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
        /// <para>Use this API to order, renew, and modify specific products, such as monthly resource plans for Elastic Desktop Service (EDS) Enterprise Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;
        /// Before calling this API, make sure you understand how Wuying Workspace is billed and its <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a>.
        /// &lt;props=&quot;intl&quot;&gt;
        /// Before calling this API, make sure you understand how Wuying Workspace is billed and its <a href="https://www.alibabacloud.com/zh/product/cloud-desktop?#J_8623712560">pricing</a>.
        /// If you do not specify automatic payment, this API does not handle the payment. You must use the returned order ID to construct a payment URL. The order becomes active and the resource is provisioned only after the payment is complete.</para>
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
        /// <para>Use this API to order, renew, and modify specific products, such as monthly resource plans for Elastic Desktop Service (EDS) Enterprise Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;
        /// Before calling this API, make sure you understand how Wuying Workspace is billed and its <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a>.
        /// &lt;props=&quot;intl&quot;&gt;
        /// Before calling this API, make sure you understand how Wuying Workspace is billed and its <a href="https://www.alibabacloud.com/zh/product/cloud-desktop?#J_8623712560">pricing</a>.
        /// If you do not specify automatic payment, this API does not handle the payment. You must use the returned order ID to construct a payment URL. The order becomes active and the resource is provisioned only after the payment is complete.</para>
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
        /// <para>Use this API to order, renew, and modify specific products, such as monthly resource plans for Elastic Desktop Service (EDS) Enterprise Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;
        /// Before calling this API, make sure you understand how Wuying Workspace is billed and its <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a>.
        /// &lt;props=&quot;intl&quot;&gt;
        /// Before calling this API, make sure you understand how Wuying Workspace is billed and its <a href="https://www.alibabacloud.com/zh/product/cloud-desktop?#J_8623712560">pricing</a>.
        /// If you do not specify automatic payment, this API does not handle the payment. You must use the returned order ID to construct a payment URL. The order becomes active and the resource is provisioned only after the payment is complete.</para>
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
        /// <para>Queries a list of agents and their usage information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description><b>Pagination</b>: This operation supports pagination by using the <c>NextToken</c> and <c>MaxResults</c> parameters. For the first request, set <c>NextToken</c> to an empty string.</description></item>
        /// <item><description><b>Filtering</b>: Use the <c>AgentType</c> and <c>AgentIds</c> parameters to filter the results.</description></item>
        /// <item><description><b>Status filtering</b>: Use the <c>Status</c> parameter to filter agents by status. Valid values are 0 (deleted) and 1 (active).</description></item>
        /// <item><description><b>Sorting</b>: By default, the results are sorted by <c>id</c> in ascending order.</description></item>
        /// <item><description><b>Additional parameter for anonymous edition</b>: The <c>FillInstance</c> parameter automatically populates the ID of the JVS_COPILOT agent that is associated with the current user.</description></item>
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
        /// <para>Queries a list of agents and their usage information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description><b>Pagination</b>: This operation supports pagination by using the <c>NextToken</c> and <c>MaxResults</c> parameters. For the first request, set <c>NextToken</c> to an empty string.</description></item>
        /// <item><description><b>Filtering</b>: Use the <c>AgentType</c> and <c>AgentIds</c> parameters to filter the results.</description></item>
        /// <item><description><b>Status filtering</b>: Use the <c>Status</c> parameter to filter agents by status. Valid values are 0 (deleted) and 1 (active).</description></item>
        /// <item><description><b>Sorting</b>: By default, the results are sorted by <c>id</c> in ascending order.</description></item>
        /// <item><description><b>Additional parameter for anonymous edition</b>: The <c>FillInstance</c> parameter automatically populates the ID of the JVS_COPILOT agent that is associated with the current user.</description></item>
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
        /// <para>Queries a list of agents and their usage information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description><b>Pagination</b>: This operation supports pagination by using the <c>NextToken</c> and <c>MaxResults</c> parameters. For the first request, set <c>NextToken</c> to an empty string.</description></item>
        /// <item><description><b>Filtering</b>: Use the <c>AgentType</c> and <c>AgentIds</c> parameters to filter the results.</description></item>
        /// <item><description><b>Status filtering</b>: Use the <c>Status</c> parameter to filter agents by status. Valid values are 0 (deleted) and 1 (active).</description></item>
        /// <item><description><b>Sorting</b>: By default, the results are sorted by <c>id</c> in ascending order.</description></item>
        /// <item><description><b>Additional parameter for anonymous edition</b>: The <c>FillInstance</c> parameter automatically populates the ID of the JVS_COPILOT agent that is associated with the current user.</description></item>
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
        /// <para>Queries a list of agents and their usage information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description><b>Pagination</b>: This operation supports pagination by using the <c>NextToken</c> and <c>MaxResults</c> parameters. For the first request, set <c>NextToken</c> to an empty string.</description></item>
        /// <item><description><b>Filtering</b>: Use the <c>AgentType</c> and <c>AgentIds</c> parameters to filter the results.</description></item>
        /// <item><description><b>Status filtering</b>: Use the <c>Status</c> parameter to filter agents by status. Valid values are 0 (deleted) and 1 (active).</description></item>
        /// <item><description><b>Sorting</b>: By default, the results are sorted by <c>id</c> in ascending order.</description></item>
        /// <item><description><b>Additional parameter for anonymous edition</b>: The <c>FillInstance</c> parameter automatically populates the ID of the JVS_COPILOT agent that is associated with the current user.</description></item>
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
        /// <para>Queries credit usage by a specified dimension such as user, credit package, or agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This API operation queries credit usage details based on the dimension specified by <c>UsageType</c> (User, CreditPackage, or Agent). The response includes the total, remaining, and used credits of the current credit package, hourly consumption samples, alert thresholds, period quotas, and other information.</para>
        /// <list type="bullet">
        /// <item><description><b>User</b>: User dimension. Returns the aggregated usage and remaining credits across all active credit packages for the current user.</description></item>
        /// <item><description><b>CreditPackage</b>: Credit package dimension. Returns the total, remaining, and consumption samples for a specified credit package instance.</description></item>
        /// <item><description><b>Agent</b>: Agent dimension. Returns the cumulative usage, current period usage, quota, alert, and other information for a specified agent.
        /// <b>Notes</b>:</description></item>
        /// <item><description>The <c>InstanceIds</c> parameter can be omitted when <c>UsageType=User</c>. Set this parameter to the credit package instance ID when <c>UsageType=CreditPackage</c>, or to the AgentId when <c>UsageType=Agent</c>.</description></item>
        /// <item><description>Anonymous requests support the <c>FillInstance</c> parameter. If <c>InstanceIds</c> is not explicitly specified and <c>FillInstance=true</c>, the server automatically populates the bound <c>JVS_COPILOT</c> AgentId based on the current logon <c>wyId</c>.</description></item>
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
        /// <para>Queries credit usage by a specified dimension such as user, credit package, or agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This API operation queries credit usage details based on the dimension specified by <c>UsageType</c> (User, CreditPackage, or Agent). The response includes the total, remaining, and used credits of the current credit package, hourly consumption samples, alert thresholds, period quotas, and other information.</para>
        /// <list type="bullet">
        /// <item><description><b>User</b>: User dimension. Returns the aggregated usage and remaining credits across all active credit packages for the current user.</description></item>
        /// <item><description><b>CreditPackage</b>: Credit package dimension. Returns the total, remaining, and consumption samples for a specified credit package instance.</description></item>
        /// <item><description><b>Agent</b>: Agent dimension. Returns the cumulative usage, current period usage, quota, alert, and other information for a specified agent.
        /// <b>Notes</b>:</description></item>
        /// <item><description>The <c>InstanceIds</c> parameter can be omitted when <c>UsageType=User</c>. Set this parameter to the credit package instance ID when <c>UsageType=CreditPackage</c>, or to the AgentId when <c>UsageType=Agent</c>.</description></item>
        /// <item><description>Anonymous requests support the <c>FillInstance</c> parameter. If <c>InstanceIds</c> is not explicitly specified and <c>FillInstance=true</c>, the server automatically populates the bound <c>JVS_COPILOT</c> AgentId based on the current logon <c>wyId</c>.</description></item>
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
        /// <para>Queries credit usage by a specified dimension such as user, credit package, or agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This API operation queries credit usage details based on the dimension specified by <c>UsageType</c> (User, CreditPackage, or Agent). The response includes the total, remaining, and used credits of the current credit package, hourly consumption samples, alert thresholds, period quotas, and other information.</para>
        /// <list type="bullet">
        /// <item><description><b>User</b>: User dimension. Returns the aggregated usage and remaining credits across all active credit packages for the current user.</description></item>
        /// <item><description><b>CreditPackage</b>: Credit package dimension. Returns the total, remaining, and consumption samples for a specified credit package instance.</description></item>
        /// <item><description><b>Agent</b>: Agent dimension. Returns the cumulative usage, current period usage, quota, alert, and other information for a specified agent.
        /// <b>Notes</b>:</description></item>
        /// <item><description>The <c>InstanceIds</c> parameter can be omitted when <c>UsageType=User</c>. Set this parameter to the credit package instance ID when <c>UsageType=CreditPackage</c>, or to the AgentId when <c>UsageType=Agent</c>.</description></item>
        /// <item><description>Anonymous requests support the <c>FillInstance</c> parameter. If <c>InstanceIds</c> is not explicitly specified and <c>FillInstance=true</c>, the server automatically populates the bound <c>JVS_COPILOT</c> AgentId based on the current logon <c>wyId</c>.</description></item>
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
        /// <para>Queries credit usage by a specified dimension such as user, credit package, or agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Operation description</h2>
        /// <para>This API operation queries credit usage details based on the dimension specified by <c>UsageType</c> (User, CreditPackage, or Agent). The response includes the total, remaining, and used credits of the current credit package, hourly consumption samples, alert thresholds, period quotas, and other information.</para>
        /// <list type="bullet">
        /// <item><description><b>User</b>: User dimension. Returns the aggregated usage and remaining credits across all active credit packages for the current user.</description></item>
        /// <item><description><b>CreditPackage</b>: Credit package dimension. Returns the total, remaining, and consumption samples for a specified credit package instance.</description></item>
        /// <item><description><b>Agent</b>: Agent dimension. Returns the cumulative usage, current period usage, quota, alert, and other information for a specified agent.
        /// <b>Notes</b>:</description></item>
        /// <item><description>The <c>InstanceIds</c> parameter can be omitted when <c>UsageType=User</c>. Set this parameter to the credit package instance ID when <c>UsageType=CreditPackage</c>, or to the AgentId when <c>UsageType=Agent</c>.</description></item>
        /// <item><description>Anonymous requests support the <c>FillInstance</c> parameter. If <c>InstanceIds</c> is not explicitly specified and <c>FillInstance=true</c>, the server automatically populates the bound <c>JVS_COPILOT</c> AgentId based on the current logon <c>wyId</c>.</description></item>
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
        /// <para>Retrieves resource deduction and usage statistics based on specified criteria.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request</h2>
        /// <list type="bullet">
        /// <item><description>This API supports GET and POST methods.</description></item>
        /// <item><description>The <c>periods</c> parameter is a JSON array of <c>PeriodParam</c> objects, each containing the <c>periodUnit</c> and <c>baseTime</c> fields.</description></item>
        /// <item><description>The <c>resourceTypes</c> parameter is a JSON array of resource type strings.</description></item>
        /// <item><description>The <c>startTime</c> and <c>endTime</c> parameters are timestamps that define the query\&quot;s time range.</description></item>
        /// <item><description>The <c>nextToken</c>, <c>maxResults</c>, <c>pageNo</c>, and <c>pageSize</c> parameters control pagination and the number of results to return.</description></item>
        /// <item><description>The API throws a <c>SalesClientException</c> if the <c>resourceTypes</c> parameter contains an invalid value or if the <c>periods</c> parameter fails JSON parsing.</description></item>
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
        /// <para>Retrieves resource deduction and usage statistics based on specified criteria.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request</h2>
        /// <list type="bullet">
        /// <item><description>This API supports GET and POST methods.</description></item>
        /// <item><description>The <c>periods</c> parameter is a JSON array of <c>PeriodParam</c> objects, each containing the <c>periodUnit</c> and <c>baseTime</c> fields.</description></item>
        /// <item><description>The <c>resourceTypes</c> parameter is a JSON array of resource type strings.</description></item>
        /// <item><description>The <c>startTime</c> and <c>endTime</c> parameters are timestamps that define the query\&quot;s time range.</description></item>
        /// <item><description>The <c>nextToken</c>, <c>maxResults</c>, <c>pageNo</c>, and <c>pageSize</c> parameters control pagination and the number of results to return.</description></item>
        /// <item><description>The API throws a <c>SalesClientException</c> if the <c>resourceTypes</c> parameter contains an invalid value or if the <c>periods</c> parameter fails JSON parsing.</description></item>
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
        /// <para>Retrieves resource deduction and usage statistics based on specified criteria.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request</h2>
        /// <list type="bullet">
        /// <item><description>This API supports GET and POST methods.</description></item>
        /// <item><description>The <c>periods</c> parameter is a JSON array of <c>PeriodParam</c> objects, each containing the <c>periodUnit</c> and <c>baseTime</c> fields.</description></item>
        /// <item><description>The <c>resourceTypes</c> parameter is a JSON array of resource type strings.</description></item>
        /// <item><description>The <c>startTime</c> and <c>endTime</c> parameters are timestamps that define the query\&quot;s time range.</description></item>
        /// <item><description>The <c>nextToken</c>, <c>maxResults</c>, <c>pageNo</c>, and <c>pageSize</c> parameters control pagination and the number of results to return.</description></item>
        /// <item><description>The API throws a <c>SalesClientException</c> if the <c>resourceTypes</c> parameter contains an invalid value or if the <c>periods</c> parameter fails JSON parsing.</description></item>
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
        /// <para>Retrieves resource deduction and usage statistics based on specified criteria.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request</h2>
        /// <list type="bullet">
        /// <item><description>This API supports GET and POST methods.</description></item>
        /// <item><description>The <c>periods</c> parameter is a JSON array of <c>PeriodParam</c> objects, each containing the <c>periodUnit</c> and <c>baseTime</c> fields.</description></item>
        /// <item><description>The <c>resourceTypes</c> parameter is a JSON array of resource type strings.</description></item>
        /// <item><description>The <c>startTime</c> and <c>endTime</c> parameters are timestamps that define the query\&quot;s time range.</description></item>
        /// <item><description>The <c>nextToken</c>, <c>maxResults</c>, <c>pageNo</c>, and <c>pageSize</c> parameters control pagination and the number of results to return.</description></item>
        /// <item><description>The API throws a <c>SalesClientException</c> if the <c>resourceTypes</c> parameter contains an invalid value or if the <c>periods</c> parameter fails JSON parsing.</description></item>
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
        /// <para>Queries prices for Elastic Desktop Service products, covering order types such as purchase, renewal, configuration change, and cancellation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;
        /// Before using this interface, ensure you understand the billing methods and <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a> for Wuying Workspace.</para>
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
        /// <para>Queries prices for Elastic Desktop Service products, covering order types such as purchase, renewal, configuration change, and cancellation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;
        /// Before using this interface, ensure you understand the billing methods and <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a> for Wuying Workspace.</para>
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
        /// <para>Queries prices for Elastic Desktop Service products, covering order types such as purchase, renewal, configuration change, and cancellation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;
        /// Before using this interface, ensure you understand the billing methods and <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a> for Wuying Workspace.</para>
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
        /// <para>Queries prices for Elastic Desktop Service products, covering order types such as purchase, renewal, configuration change, and cancellation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>&lt;props=&quot;china&quot;&gt;
        /// Before using this interface, ensure you understand the billing methods and <a href="https://www.aliyun.com/price/product?#/gws/detail/gws">pricing</a> for Wuying Workspace.</para>
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
        /// <para>Query deduction details for time-based packages.</para>
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
        /// <para>Query deduction details for time-based packages.</para>
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
        /// <para>Query deduction details for time-based packages.</para>
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
        /// <para>Query deduction details for time-based packages.</para>
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
