// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class CreateMcpServiceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("connection")]
        [Validation(Required=false)]
        public CreateMcpServiceRequestConnection Connection { get; set; }
        public class CreateMcpServiceRequestConnection : TeaModel {
            [NameInMap("auth")]
            [Validation(Required=false)]
            public CreateMcpServiceRequestConnectionAuth Auth { get; set; }
            public class CreateMcpServiceRequestConnectionAuth : TeaModel {
                /// <summary>
                /// <para>key</para>
                /// </summary>
                [NameInMap("keyInfo")]
                [Validation(Required=false)]
                public Dictionary<string, string> KeyInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>bearer</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://10.0.1.23:8080/mcp">http://10.0.1.23:8080/mcp</a></para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("timeout")]
            [Validation(Required=false)]
            public long? Timeout { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http</para>
            /// </summary>
            [NameInMap("transport")]
            [Validation(Required=false)]
            public string Transport { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("mcpServiceName")]
        [Validation(Required=false)]
        public string McpServiceName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("network")]
        [Validation(Required=false)]
        public CreateMcpServiceRequestNetwork Network { get; set; }
        public class CreateMcpServiceRequestNetwork : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>100.2.243.1</para>
            /// </summary>
            [NameInMap("accessIp")]
            [Validation(Required=false)]
            public string AccessIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("accessPort")]
            [Validation(Required=false)]
            public long? AccessPort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>gw-xxx</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mcp-xxxx</para>
            /// </summary>
            [NameInMap("mcpServerId")]
            [Validation(Required=false)]
            public string McpServerId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>public</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sg-xxxx</para>
            /// </summary>
            [NameInMap("securityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-xxx</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-xxxx</para>
            /// </summary>
            [NameInMap("vswId")]
            [Validation(Required=false)]
            public string VswId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("tools")]
        [Validation(Required=false)]
        public List<CreateMcpServiceRequestTools> Tools { get; set; }
        public class CreateMcpServiceRequestTools : TeaModel {
            [NameInMap("annotations")]
            [Validation(Required=false)]
            public Dictionary<string, object> Annotations { get; set; }

            [NameInMap("confirm")]
            [Validation(Required=false)]
            public bool? Confirm { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hahahhahaha</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ahahah</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("execution")]
            [Validation(Required=false)]
            public Dictionary<string, object> Execution { get; set; }

            [NameInMap("icons")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Icons { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("inputSchema")]
            [Validation(Required=false)]
            public Dictionary<string, object> InputSchema { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agentloop-1654218979e79fb55dbddac2</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("outputSchema")]
            [Validation(Required=false)]
            public Dictionary<string, object> OutputSchema { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
