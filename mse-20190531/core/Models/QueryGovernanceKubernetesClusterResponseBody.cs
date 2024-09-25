// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryGovernanceKubernetesClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryGovernanceKubernetesClusterResponseBodyData Data { get; set; }
        public class QueryGovernanceKubernetesClusterResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The details of the data.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<QueryGovernanceKubernetesClusterResponseBodyDataResult> Result { get; set; }
            public class QueryGovernanceKubernetesClusterResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcdef123456789</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The name of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-cluster</para>
                /// </summary>
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                /// <summary>
                /// <para>The version of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.22</para>
                /// </summary>
                [NameInMap("K8sVersion")]
                [Validation(Required=false)]
                public string K8sVersion { get; set; }

                /// <summary>
                /// <para>The information about the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;Name&quot;:&quot;ack-onepilot&quot;,&quot;Tags&quot;:{&quot;name&quot;:&quot;ack-onepilot&quot;}}]</para>
                /// </summary>
                [NameInMap("NamespaceInfos")]
                [Validation(Required=false)]
                public string NamespaceInfos { get; set; }

                /// <summary>
                /// <para>The time when the pilot component was started.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-17T05:39:43.000+0000</para>
                /// </summary>
                [NameInMap("PilotStartTime")]
                [Validation(Required=false)]
                public string PilotStartTime { get; set; }

                /// <summary>
                /// <para>The region where the cluster resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

            /// <summary>
            /// <para>The total number of clusters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DE34D413-2B79-5E77-9696-36D875E822AD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
