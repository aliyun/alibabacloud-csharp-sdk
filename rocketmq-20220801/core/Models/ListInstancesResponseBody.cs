// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MissingPageNumber</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListInstancesResponseBodyData Data { get; set; }
        public class ListInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The paged data.</para>
            /// </summary>
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyDataList> List { get; set; }
            public class ListInstancesResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The commodity code of the ApsaraMQ for RocketMQ 5.x series instance, such as ons_rmqsub_public_cn.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ons_rmqsub_public_cn</para>
                /// </summary>
                [NameInMap("commodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>The time when the instance version was last updated, in YYYY-MM-DD HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-01 00:00:00</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the instance expires, in YYYY-MM-DD HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-09-01 00:00:00</para>
                /// </summary>
                [NameInMap("expireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>The number of consumer groups created in the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("groupCount")]
                [Validation(Required=false)]
                public long? GroupCount { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rmq-cn-7e22ody****</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test instance</para>
                /// </summary>
                [NameInMap("instanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The billing method of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PayAsYouGo: pay-as-you-go (postpaid).</description></item>
                /// <item><description>Subscription: subscription (prepaid).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Subscription</para>
                /// </summary>
                [NameInMap("paymentType")]
                [Validation(Required=false)]
                public string PaymentType { get; set; }

                /// <summary>
                /// <para>The product information.</para>
                /// </summary>
                [NameInMap("productInfo")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyDataListProductInfo ProductInfo { get; set; }
                public class ListInstancesResponseBodyDataListProductInfo : TeaModel {
                    /// <summary>
                    /// <para>The capacity mode. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>provisioned: reserved capacity with elastic scaling.</description></item>
                    /// <item><description>ondemand: pay-as-you-go.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>provisioned</para>
                    /// </summary>
                    [NameInMap("capacityType")]
                    [Validation(Required=false)]
                    public string CapacityType { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the message trace feature is enabled.</para>
                    /// <list type="bullet">
                    /// <item><description>true: The message trace feature is enabled.</description></item>
                    /// <item><description>false: The message trace feature is disabled.</description></item>
                    /// </list>
                    /// <para>&lt;props=&quot;intl&quot;&gt;This parameter does not take effect. Regardless of whether this parameter is enabled, the instance supports the message trace feature by default.
                    /// &lt;props=&quot;china&quot;&gt;This parameter takes effect only for Serverless instances. If the message trace feature is enabled, message trace fees are incurred. For more information about billing, see <a href="https://help.aliyun.com/document_detail/2586280.html">Serverless billing description</a>.</para>
                    /// <para>&lt;props=&quot;china&quot;&gt;For pay-as-you-go and subscription instances, this parameter does not take effect. Regardless of whether this parameter is enabled, the message trace feature is supported by default.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("traceOn")]
                    [Validation(Required=false)]
                    public bool? TraceOn { get; set; }

                }

                /// <summary>
                /// <para>The ID of the region to which the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The time when the instance was released, in YYYY-MM-DD HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-09-07 00:00:00</para>
                /// </summary>
                [NameInMap("releaseTime")]
                [Validation(Required=false)]
                public string ReleaseTime { get; set; }

                /// <summary>
                /// <para>The remarks for the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is remark for instance.</para>
                /// </summary>
                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmx7caj******</para>
                /// </summary>
                [NameInMap("resourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The primary series code of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>standard: Standard Edition.</description></item>
                /// <item><description>ultimate: Platinum Edition.</description></item>
                /// <item><description>professional: Professional Edition.</description></item>
                /// <item><description>shared: Shared Edition.</description></item>
                /// <item><description>dedicated: Dedicated Edition.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("seriesCode")]
                [Validation(Required=false)]
                public string SeriesCode { get; set; }

                /// <summary>
                /// <para>The service code of the instance. The service code for ApsaraMQ for RocketMQ is rmq.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rmq</para>
                /// </summary>
                [NameInMap("serviceCode")]
                [Validation(Required=false)]
                public string ServiceCode { get; set; }

                /// <summary>
                /// <para>The time when the instance was created, in YYYY-MM-DD HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-01 00:00:00</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The instance status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>RELEASED: Released.</description></item>
                /// <item><description>RUNNING: Running.</description></item>
                /// <item><description>STOPPED: Stopped.</description></item>
                /// <item><description>CHANGING: Changing.</description></item>
                /// <item><description>CREATING: Creating.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The sub-series code of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cluster_ha: cluster high-availability edition.</description></item>
                /// <item><description>single_node: single-node edition.</description></item>
                /// <item><description>serverless: serverless edition.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cluster_ha</para>
                /// </summary>
                [NameInMap("subSeriesCode")]
                [Validation(Required=false)]
                public string SubSeriesCode { get; set; }

                /// <summary>
                /// <para>The resource tag list.</para>
                /// </summary>
                [NameInMap("tags")]
                [Validation(Required=false)]
                public List<ListInstancesResponseBodyDataListTags> Tags { get; set; }
                public class ListInstancesResponseBodyDataListTags : TeaModel {
                    /// <summary>
                    /// <para>The key of the resource tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the resource tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>value</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The number of topics created in the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("topicCount")]
                [Validation(Required=false)]
                public long? TopicCount { get; set; }

                /// <summary>
                /// <para>The time when the instance was last modified, in YYYY-MM-DD HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-02 00:00:00</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The ID of the user to whom the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6W0xz2uPfiwp****</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of returned results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PageNumber</para>
        /// </summary>
        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pageNumber</para>
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter pageNumber is mandatory for this action .</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. Each request has a unique ID that you can use to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>84445A20-2B50-5306-A3C0-AF99FC1833C6</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
