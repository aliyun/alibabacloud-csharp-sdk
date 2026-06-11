// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentEventStruct : TeaModel {
        /// <summary>
        /// <para>The time of automatic recovery.</para>
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
        /// <para>检测到 user-service 实例 i-abc123 的 CPU 使用率达到 95%，已触发告警。</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The dimension.</para>
        /// </summary>
        [NameInMap("dimension")]
        [Validation(Required=false)]
        public Dictionary<string, string> Dimension { get; set; }

        /// <summary>
        /// <para>The dimension for grouping.</para>
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
        /// <para>The time of the last occurrence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741234567890</para>
        /// </summary>
        [NameInMap("lastTime")]
        [Validation(Required=false)]
        public long? LastTime { get; set; }

        /// <summary>
        /// <para>The time of manual recovery.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741234567890</para>
        /// </summary>
        [NameInMap("recoverTime")]
        [Validation(Required=false)]
        public long? RecoverTime { get; set; }

        /// <summary>
        /// <para>The resource associated with the event.</para>
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
        /// <para>用户服务 CPU 使用率过高</para>
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
