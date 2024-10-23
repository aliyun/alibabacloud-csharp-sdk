// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class DeliveryOption : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("concurrency")]
        [Validation(Required=false)]
        public long? Concurrency { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RawData</para>
        /// </summary>
        [NameInMap("eventSchema")]
        [Validation(Required=false)]
        public string EventSchema { get; set; }

    }

}
