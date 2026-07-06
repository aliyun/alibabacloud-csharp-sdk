// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetChainResponseBody : TeaModel {
        /// <summary>
        /// <para>Delivery chain configuration description</para>
        /// </summary>
        [NameInMap("ChainConfig")]
        [Validation(Required=false)]
        public GetChainResponseBodyChainConfig ChainConfig { get; set; }
        public class GetChainResponseBodyChainConfig : TeaModel {
            /// <summary>
            /// <para>Delivery chain configuration ID</para>
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
            /// <item><description><para><c>true</c>: The configuration is active.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: The configuration is not active.</para>
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
            /// <para>Each edge zone in the delivery chain</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<GetChainResponseBodyChainConfigNodes> Nodes { get; set; }
            public class GetChainResponseBodyChainConfigNodes : TeaModel {
                /// <summary>
                /// <para>Indicates whether to enable the delivery chain edge zone. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: Enable the delivery chain edge zone.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: Do not enable the delivery chain edge zone.</para>
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
                /// <para>Delivery chain edge zone configuration</para>
                /// </summary>
                [NameInMap("NodeConfig")]
                [Validation(Required=false)]
                public GetChainResponseBodyChainConfigNodesNodeConfig NodeConfig { get; set; }
                public class GetChainResponseBodyChainConfigNodesNodeConfig : TeaModel {
                    /// <summary>
                    /// <para>Deny rules for scan nodes in the delivery chain</para>
                    /// </summary>
                    [NameInMap("DenyPolicy")]
                    [Validation(Required=false)]
                    public GetChainResponseBodyChainConfigNodesNodeConfigDenyPolicy DenyPolicy { get; set; }
                    public class GetChainResponseBodyChainConfigNodesNodeConfigDenyPolicy : TeaModel {
                        /// <summary>
                        /// <para>Deny action. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><c>BLOCK</c>: Block further execution of the delivery chain</para>
                        /// </description></item>
                        /// <item><description><para><c>BLOCK_RETAG</c>: Block overwriting and pushing image tags</para>
                        /// </description></item>
                        /// <item><description><para><c>BLOCK_DELETE_TAG</c>: Block deleting image tags</para>
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
                        /// <para>Collection of baseline samples to block. Separate multiple baseline sample names with commas.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>identification,hc_image_exploit</para>
                        /// </summary>
                        [NameInMap("BaselineList")]
                        [Validation(Required=false)]
                        public string BaselineList { get; set; }

                        /// <summary>
                        /// <para>Number of scanned vulnerabilities that triggers a block</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("IssueCount")]
                        [Validation(Required=false)]
                        public string IssueCount { get; set; }

                        /// <summary>
                        /// <para>The vulnerability Level at which blocking is triggered during a scan</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HIGH</para>
                        /// </summary>
                        [NameInMap("IssueLevel")]
                        [Validation(Required=false)]
                        public string IssueLevel { get; set; }

                        /// <summary>
                        /// <para>Collection of CVE vulnerabilities to block. Separate multiple CVE vulnerability names with commas.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CVE-2020-8286,CVE-2020-8285</para>
                        /// </summary>
                        [NameInMap("IssueList")]
                        [Validation(Required=false)]
                        public string IssueList { get; set; }

                        /// <summary>
                        /// <para>The logic that triggers blocking upon scan detection</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>AND</para>
                        /// </summary>
                        [NameInMap("Logic")]
                        [Validation(Required=false)]
                        public string Logic { get; set; }

                        /// <summary>
                        /// <para>The collection of malicious samples to block, with multiple sample names separated by commas</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>mutate_cockhorse,abnormal_program</para>
                        /// </summary>
                        [NameInMap("MaliciousList")]
                        [Validation(Required=false)]
                        public string MaliciousList { get; set; }

                    }

                    /// <summary>
                    /// <para>Retry Count</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Retry")]
                    [Validation(Required=false)]
                    public int? Retry { get; set; }

                    /// <summary>
                    /// <para>Scan engine for the delivery chain node  </para>
                    /// <list type="bullet">
                    /// <item><description><c>SAS_SCAN_SERVICE</c>, Security Center scan engine (requires paid activation)  </description></item>
                    /// <item><description><c>ACR_SCAN_SERVICE</c>, ACR scan engine</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACR_SCAN_SERVICE</para>
                    /// </summary>
                    [NameInMap("ScanEngine")]
                    [Validation(Required=false)]
                    public string ScanEngine { get; set; }

                    /// <summary>
                    /// <para>Timeout (in seconds)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>900</para>
                    /// </summary>
                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public long? Timeout { get; set; }

                }

                /// <summary>
                /// <para>Delivery chain edge zone name</para>
                /// 
                /// <b>Example:</b>
                /// <para>VULNERABILITY_SCANNING</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

            }

            /// <summary>
            /// <para>Execution order relationships between edge zones in the delivery chain</para>
            /// </summary>
            [NameInMap("Routers")]
            [Validation(Required=false)]
            public List<GetChainResponseBodyChainConfigRouters> Routers { get; set; }
            public class GetChainResponseBodyChainConfigRouters : TeaModel {
                /// <summary>
                /// <para>source edge zone</para>
                /// </summary>
                [NameInMap("From")]
                [Validation(Required=false)]
                public GetChainResponseBodyChainConfigRoutersFrom From { get; set; }
                public class GetChainResponseBodyChainConfigRoutersFrom : TeaModel {
                    /// <summary>
                    /// <para>source edge zone name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DOCKER_IMAGE_BUILD</para>
                    /// </summary>
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                }

                /// <summary>
                /// <para>destination edge zone</para>
                /// </summary>
                [NameInMap("To")]
                [Validation(Required=false)]
                public GetChainResponseBodyChainConfigRoutersTo To { get; set; }
                public class GetChainResponseBodyChainConfigRoutersTo : TeaModel {
                    /// <summary>
                    /// <para>destination edge zone name</para>
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
            /// <para>Delivery chain version</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>Delivery chain ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>chi-0ops0gsmw5x2****</para>
        /// </summary>
        [NameInMap("ChainId")]
        [Validation(Required=false)]
        public string ChainId { get; set; }

        /// <summary>
        /// <para>Return code</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Delivery chain creation time</para>
        /// 
        /// <b>Example:</b>
        /// <para>1638255427000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>Delivery chain description</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-4cdrlqmhn4gm****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation succeeded</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>Updated At of the delivery chain description</para>
        /// 
        /// <b>Example:</b>
        /// <para>1638259914000</para>
        /// </summary>
        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public long? ModifiedTime { get; set; }

        /// <summary>
        /// <para>Delivery chain name</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>C87993B5-7D61-5CAC-8D64-1AC732DD69FF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Collection of repositories excluded from delivery chain execution</para>
        /// </summary>
        [NameInMap("ScopeExclude")]
        [Validation(Required=false)]
        public List<string> ScopeExclude { get; set; }

        /// <summary>
        /// <para>Delivery chain scope ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>crr-nyrh2oko32xb****</para>
        /// </summary>
        [NameInMap("ScopeId")]
        [Validation(Required=false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// <para>Delivery chain scope type</para>
        /// 
        /// <b>Example:</b>
        /// <para>REPOSITORY</para>
        /// </summary>
        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

    }

}
