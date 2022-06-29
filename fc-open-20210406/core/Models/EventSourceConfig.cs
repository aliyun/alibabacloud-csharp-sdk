// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class EventSourceConfig : TeaModel {
        [NameInMap("eventSourceParameters")]
        [Validation(Required=false)]
        public EventSourceParameters EventSourceParameters { get; set; }

        /// <summary>
        /// eventSourceType
        /// </summary>
        [NameInMap("eventSourceType")]
        [Validation(Required=false)]
        public string EventSourceType { get; set; }

    }

}
