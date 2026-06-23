// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SMQProxy20260409.Models
{
    public class BatchSendMessageRequest : TeaModel {
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<BatchSendMessageRequestMessages> Messages { get; set; }
        public class BatchSendMessageRequestMessages : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("DelaySeconds")]
            [Validation(Required=false)]
            public int? DelaySeconds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>This is test message 1.</para>
            /// </summary>
            [NameInMap("MessageBody")]
            [Validation(Required=false)]
            public string MessageBody { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>group1</para>
            /// </summary>
            [NameInMap("MessageGroupId")]
            [Validation(Required=false)]
            public string MessageGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

    }

}
