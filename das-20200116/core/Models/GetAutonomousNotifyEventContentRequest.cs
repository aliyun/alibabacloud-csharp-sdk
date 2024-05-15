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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The unique identifier of the event. You can call the [GetAutonomousNotifyEventsInRange](https://help.aliyun.com/document_detail/288371.html) operation to query the unique identifier returned by the SpanId response parameter.
        /// 
        /// This parameter is required.
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
