// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class UpdateAgentRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>TF-CreateRule-1652253755-aa33f762-7e99-4aee-bd27-d3370afa5625</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public UpdateAgentRequestMetadata Metadata { get; set; }
        public class UpdateAgentRequestMetadata : TeaModel {
            [NameInMap("Attachments")]
            [Validation(Required=false)]
            public List<UpdateAgentRequestMetadataAttachments> Attachments { get; set; }
            public class UpdateAgentRequestMetadataAttachments : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>acs:eventbridge:cn-hangzhou:12345:eventhouse/system-rocketmq/namespace/rmq-cn-xxx/table/order</para>
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>inner-resource/event-table</para>
                /// </summary>
                [NameInMap("MimeType")]
                [Validation(Required=false)]
                public string MimeType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-agent</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

    }

}
