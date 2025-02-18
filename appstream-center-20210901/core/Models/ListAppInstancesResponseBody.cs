// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAppInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the application instances.</para>
        /// </summary>
        [NameInMap("AppInstanceModels")]
        [Validation(Required=false)]
        public List<ListAppInstancesResponseBodyAppInstanceModels> AppInstanceModels { get; set; }
        public class ListAppInstancesResponseBodyAppInstanceModels : TeaModel {
            /// <summary>
            /// <para>The ID of the delivery group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-dk8p95irqfst9****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the application instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ai-8dl7dzchklmka****</para>
            /// </summary>
            [NameInMap("AppInstanceId")]
            [Validation(Required=false)]
            public string AppInstanceId { get; set; }

            /// <summary>
            /// <para>The information about the binding between the application instance and end users.</para>
            /// </summary>
            [NameInMap("BindInfo")]
            [Validation(Required=false)]
            public ListAppInstancesResponseBodyAppInstanceModelsBindInfo BindInfo { get; set; }
            public class ListAppInstancesResponseBodyAppInstanceModelsBindInfo : TeaModel {
                /// <summary>
                /// <para>The ID of the end user that is bound to the application instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app.test</para>
                /// </summary>
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                /// <summary>
                /// <para>The use duration of the application instance. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("UsageDuration")]
                [Validation(Required=false)]
                public long? UsageDuration { get; set; }

            }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The time when the application instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-07T20:29:19.000+08:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the application instance was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-07T20:29:19.000+08:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The public IP address associated with the primary NIC. This value is returned only if <c>StrategyType</c> is set to <c>Mixed</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.13.13.211</para>
            /// </summary>
            [NameInMap("MainEthPublicIp")]
            [Validation(Required=false)]
            public string MainEthPublicIp { get; set; }

            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The session status. This parameter is returned only if the application instance is in the <c>RUNNING</c> state.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>disconnect: disconnected</description></item>
            /// <item><description>connect: connected</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>connect</para>
            /// </summary>
            [NameInMap("SessionStatus")]
            [Validation(Required=false)]
            public string SessionStatus { get; set; }

            /// <summary>
            /// <para>The status of the application instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BOUND</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page. We recommend that you configure this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page. The value cannot be greater than <c>100</c>. We recommend that you configure this parameter.</para>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
