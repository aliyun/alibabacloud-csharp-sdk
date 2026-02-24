// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentTimeline : TeaModel {
        /// <summary>
        /// <para>Subtype.</para>
        /// 
        /// <b>Example:</b>
        /// <para>comment</para>
        /// </summary>
        [NameInMap("childType")]
        [Validation(Required=false)]
        public string ChildType { get; set; }

        /// <summary>
        /// <para>Content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The operations team has been notified to investigate.</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Incident ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>incident-001</para>
        /// </summary>
        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public string IncidentId { get; set; }

        /// <summary>
        /// <para>Timeline node unique ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>timeline-001</para>
        /// </summary>
        [NameInMap("incidentTimelineId")]
        [Validation(Required=false)]
        public string IncidentTimelineId { get; set; }

        /// <summary>
        /// <para>Time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741234567890</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        /// <summary>
        /// <para>Parent timeline ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>timeline-main-001</para>
        /// </summary>
        [NameInMap("timelineId")]
        [Validation(Required=false)]
        public string TimelineId { get; set; }

        /// <summary>
        /// <para>Title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The operations team has been contacted.</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>Type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACTION</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

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
