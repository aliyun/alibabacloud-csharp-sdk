// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAppInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of queried application instances.</para>
        /// </summary>
        [NameInMap("AppInstanceModels")]
        [Validation(Required=false)]
        public List<ListAppInstancesResponseBodyAppInstanceModels> AppInstanceModels { get; set; }
        public class ListAppInstancesResponseBodyAppInstanceModels : TeaModel {
            /// <summary>
            /// <para>The delivery group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-dk8p95irqfst9****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The application instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ai-8dl7dzchklmka****</para>
            /// </summary>
            [NameInMap("AppInstanceId")]
            [Validation(Required=false)]
            public string AppInstanceId { get; set; }

            /// <summary>
            /// <para>The binding information between the instance and the user.</para>
            /// </summary>
            [NameInMap("BindInfo")]
            [Validation(Required=false)]
            public ListAppInstancesResponseBodyAppInstanceModelsBindInfo BindInfo { get; set; }
            public class ListAppInstancesResponseBodyAppInstanceModelsBindInfo : TeaModel {
                /// <summary>
                /// <para>The ID of the end user bound to the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app.test</para>
                /// </summary>
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                /// <summary>
                /// <para>The usage duration of the instance. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("UsageDuration")]
                [Validation(Required=false)]
                public long? UsageDuration { get; set; }

            }

            /// <summary>
            /// <para>The billing method of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PrePaid</b>: subscription.</description></item>
            /// <item><description><b>PostPaid</b>: pay-as-you-go.<remarks>
            /// <para>This parameter is returned only when the billing mode of the delivery group to which the instance belongs is set to resource-based billing (ChargeResourceMode=Node).</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-07T20:29:19.000+08:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-07T20:29:19.000+08:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The public IP address of the primary network interface controller (NIC). This value is returned only when the network policy (<c>StrategyType</c>) of the delivery group is set to mixed mode pattern (<c>Mixed</c>). Otherwise, this value is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.13.13.211</para>
            /// </summary>
            [NameInMap("MainEthPublicIp")]
            [Validation(Required=false)]
            public string MainEthPublicIp { get; set; }

            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            [NameInMap("NetworkInterfaceIp")]
            [Validation(Required=false)]
            public string NetworkInterfaceIp { get; set; }

            /// <summary>
            /// <para>The ID of the node on which the instance runs.</para>
            /// <remarks>
            /// <para>This parameter is returned only when the billing mode of the delivery group to which the instance belongs is set to resource-based billing (ChargeResourceMode=Node).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp13********</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The session connection status. This value is returned only when the instance status is running (<c>RUNNING</c>). Otherwise, this value is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connect</para>
            /// </summary>
            [NameInMap("SessionStatus")]
            [Validation(Required=false)]
            public string SessionStatus { get; set; }

            /// <summary>
            /// <para>The application instance status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BOUND</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The page number of the query results to display. Specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of query results per page. Maximum value: <c>100</c>. Specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
