// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class BatchRemoveConsumerGroupConsumersRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;cs-8c13d2b4f8a1&quot;]</para>
        /// </summary>
        [NameInMap("consumerIds")]
        [Validation(Required=false)]
        public List<string> ConsumerIds { get; set; }

    }

}
