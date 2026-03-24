// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentTimeline : TeaModel {
        /// <summary>
        /// <para>子类型。</para>
        /// 
        /// <b>Example:</b>
        /// <para>comment</para>
        /// </summary>
        [NameInMap("childType")]
        [Validation(Required=false)]
        public string ChildType { get; set; }

        /// <summary>
        /// <para>内容。</para>
        /// 
        /// <b>Example:</b>
        /// <para>已通知运维团队进行排查</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>所属事件 ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>incident-001</para>
        /// </summary>
        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public string IncidentId { get; set; }

        /// <summary>
        /// <para>时间线节点唯一 ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>timeline-001</para>
        /// </summary>
        [NameInMap("incidentTimelineId")]
        [Validation(Required=false)]
        public string IncidentTimelineId { get; set; }

        /// <summary>
        /// <para>时间戳。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741234567890</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        /// <summary>
        /// <para>所属时间线 ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>timeline-main-001</para>
        /// </summary>
        [NameInMap("timelineId")]
        [Validation(Required=false)]
        public string TimelineId { get; set; }

        /// <summary>
        /// <para>时间线标题。</para>
        /// 
        /// <b>Example:</b>
        /// <para>已联系运维团队</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>类型。</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACTION</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>用户 ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-12345</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
