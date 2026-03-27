// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentEventStruct : TeaModel {
        /// <summary>
        /// <para>Automatic recovery time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741234567890</para>
        /// </summary>
        [NameInMap("autoRecoverTime")]
        [Validation(Required=false)]
        public long? AutoRecoverTime { get; set; }

        /// <summary>
        /// <para>Content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Detected that the CPU usage of the user-service instance i-abc123 has reached 95%, triggering an alert.</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>Dimension.</para>
        /// </summary>
        [NameInMap("dimension")]
        [Validation(Required=false)]
        public Dictionary<string, string> Dimension { get; set; }

        /// <summary>
        /// <para>Used for grouping dimensions.</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public Dictionary<string, string> GroupBy { get; set; }

        /// <summary>
        /// <para>Incident Event Id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>event-001</para>
        /// </summary>
        [NameInMap("incidentEventId")]
        [Validation(Required=false)]
        public string IncidentEventId { get; set; }

        /// <summary>
        /// <para>Incident Id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>incident-001</para>
        /// </summary>
        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public string IncidentId { get; set; }

        /// <summary>
        /// <para>Last time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741234567890</para>
        /// </summary>
        [NameInMap("lastTime")]
        [Validation(Required=false)]
        public long? LastTime { get; set; }

        /// <summary>
        /// <para>Manual recovery time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741234567890</para>
        /// </summary>
        [NameInMap("recoverTime")]
        [Validation(Required=false)]
        public long? RecoverTime { get; set; }

        /// <summary>
        /// <para>Describes the resource information associated with the event.</para>
        /// </summary>
        [NameInMap("resource")]
        [Validation(Required=false)]
        public Dictionary<string, string> Resource { get; set; }

        /// <summary>
        /// <para>Status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// <para>Time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58Z</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

        /// <summary>
        /// <para>Title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>User service CPU usage is too high.</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>User ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-12345</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
