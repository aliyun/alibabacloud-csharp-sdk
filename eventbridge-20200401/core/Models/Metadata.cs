// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class Metadata : TeaModel {
        [NameInMap("Attachments")]
        [Validation(Required=false)]
        public List<MetadataAttachments> Attachments { get; set; }
        public class MetadataAttachments : TeaModel {
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

}
