// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetAutonomousNotifyEventContentRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The unique identifier of the event. You can call the [GetAutonomousNotifyEventsInRange](~~288371~~) operation to query the unique identifier returned by the SpanId response parameter.
        /// </summary>
        [NameInMap("SpanId")]
        [Validation(Required=false)]
        public string SpanId { get; set; }

        /// <summary>
        /// The reserved parameter.
        /// </summary>
        [NameInMap("__context")]
        [Validation(Required=false)]
        public string Context { get; set; }

    }

}
