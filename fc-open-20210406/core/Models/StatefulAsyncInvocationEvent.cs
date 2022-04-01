// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class StatefulAsyncInvocationEvent : TeaModel {
        /// <summary>
        /// 事件详细数据。
        /// </summary>
        [NameInMap("eventDetail")]
        [Validation(Required=false)]
        public string EventDetail { get; set; }

        /// <summary>
        /// 事件ID。
        /// </summary>
        [NameInMap("eventId")]
        [Validation(Required=false)]
        public long? EventId { get; set; }

        /// <summary>
        /// 事件执行状态。
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 事件时间。
        /// </summary>
        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
