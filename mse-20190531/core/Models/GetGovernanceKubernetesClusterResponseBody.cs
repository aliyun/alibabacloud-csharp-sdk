// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGovernanceKubernetesClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGovernanceKubernetesClusterResponseBodyData Data { get; set; }
        public class GetGovernanceKubernetesClusterResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cd23228b3c80c4d4f9ad7af1d87cc30d5</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myCluster</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The version of Kubernetes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.20.11-aliyun.1</para>
            /// </summary>
            [NameInMap("K8sVersion")]
            [Validation(Required=false)]
            public string K8sVersion { get; set; }

            /// <summary>
            /// <para>The information of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;Name\&quot;:\&quot;ack-onepilot\&quot;,\&quot;Tags\&quot;:null},{\&quot;Name\&quot;:\&quot;default\&quot;,\&quot;Tags\&quot;:{\&quot;mse-enable\&quot;:\&quot;enabled\&quot;}},{\&quot;Name\&quot;:\&quot;kube-node-lease\&quot;,\&quot;Tags\&quot;:null},{\&quot;Name\&quot;:\&quot;kube-public\&quot;,\&quot;Tags\&quot;:null},{\&quot;Name\&quot;:\&quot;kube-system\&quot;,\&quot;Tags\&quot;:null}]</para>
            /// </summary>
            [NameInMap("NamespaceInfos")]
            [Validation(Required=false)]
            public string NamespaceInfos { get; set; }

            /// <summary>
            /// <para>The queried namespaces.</para>
            /// </summary>
            [NameInMap("Namespaces")]
            [Validation(Required=false)]
            public List<GetGovernanceKubernetesClusterResponseBodyDataNamespaces> Namespaces { get; set; }
            public class GetGovernanceKubernetesClusterResponseBodyDataNamespaces : TeaModel {
                /// <summary>
                /// <para>The name of the MSE namespace that you want to access.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("MseNamespace")]
                [Validation(Required=false)]
                public string MseNamespace { get; set; }

                /// <summary>
                /// <para>The name of the namespace in the ACK cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The time when the pilot component was started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-11T11:50:38.000+0000</para>
            /// </summary>
            [NameInMap("PilotStartTime")]
            [Validation(Required=false)]
            public string PilotStartTime { get; set; }

            [NameInMap("PilotVersion")]
            [Validation(Required=false)]
            public string PilotVersion { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the instance resides. The region is supported by MSE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The time of the last modification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-12T05:24:31.000+0000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("VersionLifeCycle")]
            [Validation(Required=false)]
            public string VersionLifeCycle { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
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
        /// <para>5B170A0D-2C5D-4CF8-B808-03966B86****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request was successful.</description></item>
        /// <item><description><c>false</c>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
