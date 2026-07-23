// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateAgentRequest : TeaModel {
        /// <summary>
        /// <para>The description of the event bus.</para>
        /// 
        /// <b>Example:</b>
        /// <para>连接配置描述信息</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The associated metadata.</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public CreateAgentRequestMetadata Metadata { get; set; }
        public class CreateAgentRequestMetadata : TeaModel {
            /// <summary>
            /// <para>The array of attached metadata objects.</para>
            /// </summary>
            [NameInMap("Attachments")]
            [Validation(Required=false)]
            public List<CreateAgentRequestMetadataAttachments> Attachments { get; set; }
            public class CreateAgentRequestMetadataAttachments : TeaModel {
                /// <summary>
                /// <para>The ARN of the attached metadata object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:eventbridge:cn-hangzhou:12345:eventhouse/system-rocketmq/namespace/rmq-cn-XXX/table/order</para>
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
        /// <para>You are an IoT data analytics assistant...</para>
        /// 
        /// <b>Example:</b>
        /// <para>我想要她，你这样增加请求头获取用户IP CF-Connecting-IP%3B</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

    }

}
