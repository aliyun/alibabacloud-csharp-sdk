// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class EventSourceConfig : TeaModel {
        [NameInMap("eventSourceParameters")]
        [Validation(Required=false)]
        public EventSourceParameters EventSourceParameters { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MNS</para>
        /// </summary>
        [NameInMap("eventSourceType")]
        [Validation(Required=false)]
        public string EventSourceType { get; set; }

    }

}
