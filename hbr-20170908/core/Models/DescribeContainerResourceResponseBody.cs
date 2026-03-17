// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeContainerResourceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
        /// <para>D98A2895-745B-5530-A8C1-9A86F0A82354</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<DescribeContainerResourceResponseBodyResources> Resources { get; set; }
        public class DescribeContainerResourceResponseBodyResources : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cc-0005**********hhjw</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c21b653f********695e892e718c419a4</para>
            /// </summary>
            [NameInMap("ClusterIdentifier")]
            [Validation(Required=false)]
            public string ClusterIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a9ab843d-<b><b>-</b></b>-8e46-1d67a82128a7</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;pv_name&quot;:&quot;nas-a9ab843d-<b><b>-</b></b>-8e46-1d67a82128a7&quot;,&quot;pv_size&quot;:&quot;1000Gi&quot;,&quot;storage_class&quot;:&quot;opk8s-nas&quot;,&quot;pvc_name&quot;:&quot;**-pvc&quot;,&quot;namespace&quot;:&quot;default&quot;}</para>
            /// </summary>
            [NameInMap("ResourceInfo")]
            [Validation(Required=false)]
            public string ResourceInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PV</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
