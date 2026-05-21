// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ListOperationEventsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>COLD_UPGRADE</para>
        /// </summary>
        [NameInMap("eventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("eventNameDesc")]
        [Validation(Required=false)]
        public bool? EventNameDesc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SYSTEM_MAINTENANCE</para>
        /// </summary>
        [NameInMap("eventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hgpost-cn-xxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("scheduleTimeDesc")]
        [Validation(Required=false)]
        public bool? ScheduleTimeDesc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
