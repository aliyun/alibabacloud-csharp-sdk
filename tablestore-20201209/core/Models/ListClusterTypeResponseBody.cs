// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class ListClusterTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of the detailed information about the cluster types.</para>
        /// </summary>
        [NameInMap("ClusterTypeInfos")]
        [Validation(Required=false)]
        public List<ListClusterTypeResponseBodyClusterTypeInfos> ClusterTypeInfos { get; set; }
        public class ListClusterTypeResponseBodyClusterTypeInfos : TeaModel {
            /// <summary>
            /// <para>The cluster type.</para>
            /// <list type="bullet">
            /// <item><description><para>HYBRID: Capacity.</para>
            /// </description></item>
            /// <item><description><para>SSD: Performance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SSD</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>Indicates whether the cluster supports deployment in multiple availability zones (AZs).</para>
            /// <list type="bullet">
            /// <item><description><para>true: The cluster supports multi-zone deployment and provides zone-redundant storage.</para>
            /// </description></item>
            /// <item><description><para>false: The cluster does not support multi-zone deployment and provides locally redundant storage.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsMultiAZ")]
            [Validation(Required=false)]
            public bool? IsMultiAZ { get; set; }

        }

        /// <summary>
        /// <para>A list of cluster types.</para>
        /// </summary>
        [NameInMap("ClusterTypes")]
        [Validation(Required=false)]
        public List<string> ClusterTypes { get; set; }

        /// <summary>
        /// <para>The request ID. Use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88BA193C-4918-08C4-9870-E1FE6BBECF34</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
