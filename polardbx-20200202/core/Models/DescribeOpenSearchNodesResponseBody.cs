// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeOpenSearchNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeOpenSearchNodesResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeOpenSearchNodesResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The authentication action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The identity used for authentication in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The owner ID of the authentication principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>The type of the authentication principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>222</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>The encoded diagnostic message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQEAAAAAaKPfwjY0MzMyODRGLUZCQkQtNTA1RS04MUUxLTc5NTkzODk2MUIzMg==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>The type of the permission denial.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>The policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PRIORITY</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The data struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeOpenSearchNodesResponseBodyData Data { get; set; }
        public class DescribeOpenSearchNodesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The query result object.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DescribeOpenSearchNodesResponseBodyDataResult> Result { get; set; }
            public class DescribeOpenSearchNodesResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The number of CPU cores of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CpuCores")]
                [Validation(Required=false)]
                public int? CpuCores { get; set; }

                /// <summary>
                /// <para>The CPU usage (%).</para>
                /// 
                /// <b>Example:</b>
                /// <para>35.6</para>
                /// </summary>
                [NameInMap("CpuPercent")]
                [Validation(Required=false)]
                public string CpuPercent { get; set; }

                /// <summary>
                /// <para>The total disk capacity of the node, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("DiskSizeGB")]
                [Validation(Required=false)]
                public int? DiskSizeGB { get; set; }

                /// <summary>
                /// <para>The disk space usage of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>42.5</para>
                /// </summary>
                [NameInMap("DiskUsedPercent")]
                [Validation(Required=false)]
                public string DiskUsedPercent { get; set; }

                /// <summary>
                /// <para>The total number of unresolved baseline check items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GREEN</para>
                /// </summary>
                [NameInMap("Health")]
                [Validation(Required=false)]
                public string Health { get; set; }

                /// <summary>
                /// <para>The JVM heap memory usage of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>38.2</para>
                /// </summary>
                [NameInMap("HeapPercent")]
                [Validation(Required=false)]
                public string HeapPercent { get; set; }

                /// <summary>
                /// <para>The IP address and port of the session host that initiated the session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.115.107.0/24</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The name of the host on which the node instance runs. You can log on to the host and run the <c>hostname</c> command to view the hostname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hb2h-ali-oceanbase-public-online-013</para>
                /// </summary>
                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                /// <summary>
                /// <para>The average system load of the node over the last 1 minute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.25</para>
                /// </summary>
                [NameInMap("LoadOneM")]
                [Validation(Required=false)]
                public string LoadOneM { get; set; }

                /// <summary>
                /// <para>The amount of memory used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("MemoryGB")]
                [Validation(Required=false)]
                public int? MemoryGB { get; set; }

                /// <summary>
                /// <para>The node type to query. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>all: queries both dn and gms nodes.</description></item>
                /// <item><description>gms: queries only gms nodes.</description></item>
                /// <item><description>dn: queries only dn nodes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>dn</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <para>The port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing-i</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE4F6C34-065F-45AA-B5DC-4B8D816F6305</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
