// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentEventStruct : TeaModel {
        /// <summary>
        /// <para>The automatic recovery time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741234567890</para>
        /// </summary>
        [NameInMap("autoRecoverTime")]
        [Validation(Required=false)]
        public long? AutoRecoverTime { get; set; }

        /// <summary>
        /// <para>The content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The CPU utilization of the user-service instance i-abc123 reached 95%, triggering an alert</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The statistical count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The dimension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;regionId&quot;:&quot;cn-hangzhou&quot;}</para>
        /// </summary>
        [NameInMap("dimension")]
        [Validation(Required=false)]
        public Dictionary<string, string> Dimension { get; set; }

        /// <summary>
        /// <para>The dimension used for grouping.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;severity&quot;:&quot;Critical&quot;}</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public Dictionary<string, string> GroupBy { get; set; }

        /// <summary>
        /// <para>The incident event ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>event-001</para>
        /// </summary>
        [NameInMap("incidentEventId")]
        [Validation(Required=false)]
        public string IncidentEventId { get; set; }

        /// <summary>
        /// <para>The incident ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>incident-001</para>
        /// </summary>
        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public string IncidentId { get; set; }

        /// <summary>
        /// <para>The last time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741234567890</para>
        /// </summary>
        [NameInMap("lastTime")]
        [Validation(Required=false)]
        public long? LastTime { get; set; }

        /// <summary>
        /// <para>The manual recovery time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741234567890</para>
        /// </summary>
        [NameInMap("recoverTime")]
        [Validation(Required=false)]
        public long? RecoverTime { get; set; }

        /// <summary>
        /// <para>The information about the resources associated with the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;resourceId&quot;:&quot;i-example001&quot;}</para>
        /// </summary>
        [NameInMap("resource")]
        [Validation(Required=false)]
        public Dictionary<string, string> Resource { get; set; }

        /// <summary>
        /// <para>The status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// <para>The time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58Z</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

        /// <summary>
        /// <para>The title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>High CPU utilization of the user service</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-12345</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
