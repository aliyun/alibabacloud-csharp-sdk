// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateAgentRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public CreateAgentRequestMetadata Metadata { get; set; }
        public class CreateAgentRequestMetadata : TeaModel {
            [NameInMap("Attachments")]
            [Validation(Required=false)]
            public List<CreateAgentRequestMetadataAttachments> Attachments { get; set; }
            public class CreateAgentRequestMetadataAttachments : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>acs:eventbridge:cn-hangzhou:12345:eventhouse/system-rocketmq/namespace/rmq-cn-XXX/table/order</para>
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
