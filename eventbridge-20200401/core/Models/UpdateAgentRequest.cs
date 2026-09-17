// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class UpdateAgentRequest : TeaModel {
        /// <summary>
        /// <para>The client-generated request token. This parameter is used to ensure the idempotence of the request. The token must be unique across different requests and can contain up to 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TF-CreateRule-1652253755-aa33f762-7e99-4aee-bd27-d3370afa5625</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the event source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Filtering rule for MNS</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the MCP server bound to the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bGXX51ULuGl10xrr</para>
        /// </summary>
        [NameInMap("McpServerId")]
        [Validation(Required=false)]
        public string McpServerId { get; set; }

        /// <summary>
        /// <para>The name of the MCP server bound to the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eventhouse-agentbridge</para>
        /// </summary>
        [NameInMap("McpServerName")]
        [Validation(Required=false)]
        public string McpServerName { get; set; }

        /// <summary>
        /// <para>The associated metadata.</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public UpdateAgentRequestMetadata Metadata { get; set; }
        public class UpdateAgentRequestMetadata : TeaModel {
            /// <summary>
            /// <para>The bound metadata objects.</para>
            /// </summary>
            [NameInMap("Attachments")]
            [Validation(Required=false)]
            public List<UpdateAgentRequestMetadataAttachments> Attachments { get; set; }
            public class UpdateAgentRequestMetadataAttachments : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the bound metadata object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:eventbridge:cn-hangzhou:12345:eventhouse/system-rocketmq/namespace/rmq-cn-xxx/table/order</para>
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// <para>The object type of the attached metadata.</para>
                /// 
                /// <b>Example:</b>
                /// <para>inner-resource/event-table</para>
                /// </summary>
                [NameInMap("MimeType")]
                [Validation(Required=false)]
                public string MimeType { get; set; }

            }

        }

        /// <summary>
        /// <para>The name of the agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The prompt for the agent, such as &quot;You are an IoT data analytics assistant...&quot;</para>
        /// 
        /// <b>Example:</b>
        /// <para>瑞士冻结马杜罗在瑞资产</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

    }

}
