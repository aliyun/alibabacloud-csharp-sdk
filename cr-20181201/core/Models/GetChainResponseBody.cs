// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetChainResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration of the delivery chain.</para>
        /// </summary>
        [NameInMap("ChainConfig")]
        [Validation(Required=false)]
        public GetChainResponseBodyChainConfig ChainConfig { get; set; }
        public class GetChainResponseBodyChainConfig : TeaModel {
            /// <summary>
            /// <para>The configuration ID of the delivery chain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cci-lz3ycgo69ukt****</para>
            /// </summary>
            [NameInMap("ChainConfigId")]
            [Validation(Required=false)]
            public string ChainConfigId { get; set; }

            /// <summary>
            /// <para>Indicates whether the delivery chain configuration is active. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Active.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Inactive.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsActive")]
            [Validation(Required=false)]
            public bool? IsActive { get; set; }

            /// <summary>
            /// <para>The nodes in the delivery chain.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<GetChainResponseBodyChainConfigNodes> Nodes { get; set; }
            public class GetChainResponseBodyChainConfigNodes : TeaModel {
                /// <summary>
                /// <para>Indicates whether the delivery chain node is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Enabled.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The configuration of the delivery chain node.</para>
                /// </summary>
                [NameInMap("NodeConfig")]
                [Validation(Required=false)]
                public GetChainResponseBodyChainConfigNodesNodeConfig NodeConfig { get; set; }
                public class GetChainResponseBodyChainConfigNodesNodeConfig : TeaModel {
                    /// <summary>
                    /// <para>The blocking policy for the scan node in the delivery chain.</para>
                    /// </summary>
                    [NameInMap("DenyPolicy")]
                    [Validation(Required=false)]
                    public GetChainResponseBodyChainConfigNodesNodeConfigDenyPolicy DenyPolicy { get; set; }
                    public class GetChainResponseBodyChainConfigNodesNodeConfigDenyPolicy : TeaModel {
                        /// <summary>
                        /// <para>The blocking action. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><c>BLOCK</c>: Blocks the delivery chain from continuing execution.</para>
                        /// </description></item>
                        /// <item><description><para><c>BLOCK_RETAG</c>: Blocks and overwrites the pushed image tag.</para>
                        /// </description></item>
                        /// <item><description><para><c>BLOCK_DELETE_TAG</c>: Blocks and deletes the image tag.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>BLOCK</para>
                        /// </summary>
                        [NameInMap("Action")]
                        [Validation(Required=false)]
                        public string Action { get; set; }

                        /// <summary>
                        /// <para>The collection of baseline samples to block. Separate multiple baseline sample names with commas (,).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>identification,hc_image_exploit</para>
                        /// </summary>
                        [NameInMap("BaselineList")]
                        [Validation(Required=false)]
                        public string BaselineList { get; set; }

                        /// <summary>
                        /// <para>The number of vulnerabilities that triggers blocking.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("IssueCount")]
                        [Validation(Required=false)]
                        public string IssueCount { get; set; }

                        /// <summary>
                        /// <para>The vulnerability severity level that triggers blocking.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HIGH</para>
                        /// </summary>
                        [NameInMap("IssueLevel")]
                        [Validation(Required=false)]
                        public string IssueLevel { get; set; }

                        /// <summary>
                        /// <para>The collection of CVE vulnerabilities to block. Separate multiple CVE vulnerability names with commas (,).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CVE-2020-8286,CVE-2020-8285</para>
                        /// </summary>
                        [NameInMap("IssueList")]
                        [Validation(Required=false)]
                        public string IssueList { get; set; }

                        /// <summary>
                        /// <para>The logic that triggers blocking during scanning.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>AND</para>
                        /// </summary>
                        [NameInMap("Logic")]
                        [Validation(Required=false)]
                        public string Logic { get; set; }

                        /// <summary>
                        /// <para>The collection of malicious samples to block. Separate multiple malicious sample names with commas (,).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>mutate_cockhorse,abnormal_program</para>
                        /// </summary>
                        [NameInMap("MaliciousList")]
                        [Validation(Required=false)]
                        public string MaliciousList { get; set; }

                    }

                    /// <summary>
                    /// <para>The number of retries.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Retry")]
                    [Validation(Required=false)]
                    public int? Retry { get; set; }

                    /// <summary>
                    /// <para>The scan engine of the delivery chain scan node. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>SAS_SCAN_SERVICE</c>: Security Center scan engine (requires paid activation).</description></item>
                    /// <item><description><c>ACR_SCAN_SERVICE</c>: ACR scan engine.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACR_SCAN_SERVICE</para>
                    /// </summary>
                    [NameInMap("ScanEngine")]
                    [Validation(Required=false)]
                    public string ScanEngine { get; set; }

                    /// <summary>
                    /// <para>The timeout period, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>900</para>
                    /// </summary>
                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public long? Timeout { get; set; }

                }

                /// <summary>
                /// <para>The name of the delivery chain node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VULNERABILITY_SCANNING</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

            }

            /// <summary>
            /// <para>The execution order between delivery chain nodes.</para>
            /// </summary>
            [NameInMap("Routers")]
            [Validation(Required=false)]
            public List<GetChainResponseBodyChainConfigRouters> Routers { get; set; }
            public class GetChainResponseBodyChainConfigRouters : TeaModel {
                /// <summary>
                /// <para>The source node.</para>
                /// </summary>
                [NameInMap("From")]
                [Validation(Required=false)]
                public GetChainResponseBodyChainConfigRoutersFrom From { get; set; }
                public class GetChainResponseBodyChainConfigRoutersFrom : TeaModel {
                    /// <summary>
                    /// <para>The name of the source node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DOCKER_IMAGE_BUILD</para>
                    /// </summary>
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                }

                /// <summary>
                /// <para>The destination node.</para>
                /// </summary>
                [NameInMap("To")]
                [Validation(Required=false)]
                public GetChainResponseBodyChainConfigRoutersTo To { get; set; }
                public class GetChainResponseBodyChainConfigRoutersTo : TeaModel {
                    /// <summary>
                    /// <para>The name of the destination node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DOCKER_IMAGE_PUSH</para>
                    /// </summary>
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                }

            }

            /// <summary>
            /// <para>The version of the delivery chain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The delivery chain ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chi-0ops0gsmw5x2****</para>
        /// </summary>
        [NameInMap("ChainId")]
        [Validation(Required=false)]
        public string ChainId { get; set; }

        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The time when the delivery chain was created. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1638255427000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the delivery chain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-4cdrlqmhn4gm****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The time when the delivery chain description was last modified. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1638259914000</para>
        /// </summary>
        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public long? ModifiedTime { get; set; }

        /// <summary>
        /// <para>The name of the delivery chain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C87993B5-7D61-5CAC-8D64-1AC732DD69FF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The collection of repositories excluded from the delivery chain execution.</para>
        /// </summary>
        [NameInMap("ScopeExclude")]
        [Validation(Required=false)]
        public List<string> ScopeExclude { get; set; }

        /// <summary>
        /// <para>The scope ID of the delivery chain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crr-nyrh2oko32xb****</para>
        /// </summary>
        [NameInMap("ScopeId")]
        [Validation(Required=false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// <para>The scope type of the delivery chain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REPOSITORY</para>
        /// </summary>
        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

    }

}
