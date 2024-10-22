// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAppInstancesResponseBody : TeaModel {
        [NameInMap("AppInstanceModels")]
        [Validation(Required=false)]
        public List<ListAppInstancesResponseBodyAppInstanceModels> AppInstanceModels { get; set; }
        public class ListAppInstancesResponseBodyAppInstanceModels : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>aig-dk8p95irqfst9****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ai-8dl7dzchklmka****</para>
            /// </summary>
            [NameInMap("AppInstanceId")]
            [Validation(Required=false)]
            public string AppInstanceId { get; set; }

            [NameInMap("BindInfo")]
            [Validation(Required=false)]
            public ListAppInstancesResponseBodyAppInstanceModelsBindInfo BindInfo { get; set; }
            public class ListAppInstancesResponseBodyAppInstanceModelsBindInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>app.test</para>
                /// </summary>
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("UsageDuration")]
                [Validation(Required=false)]
                public long? UsageDuration { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-03-07T20:29:19.000+08:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-03-07T20:29:19.000+08:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10.13.13.211</para>
            /// </summary>
            [NameInMap("MainEthPublicIp")]
            [Validation(Required=false)]
            public string MainEthPublicIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>connect</para>
            /// </summary>
            [NameInMap("SessionStatus")]
            [Validation(Required=false)]
            public string SessionStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BOUND</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
