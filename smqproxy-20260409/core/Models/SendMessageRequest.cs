// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SMQProxy20260409.Models
{
    public class SendMessageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DelaySeconds")]
        [Validation(Required=false)]
        public int? DelaySeconds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;Hello MNS&quot;</para>
        /// </summary>
        [NameInMap("MessageBody")]
        [Validation(Required=false)]
        public string MessageBody { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>group-123</para>
        /// </summary>
        [NameInMap("MessageGroupId")]
        [Validation(Required=false)]
        public string MessageGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;key1&quot;:&quot;value1&quot;, &quot;key2&quot;:&quot;value2&quot;}</para>
        /// </summary>
        [NameInMap("UserProperties")]
        [Validation(Required=false)]
        public string UserProperties { get; set; }

    }

}
