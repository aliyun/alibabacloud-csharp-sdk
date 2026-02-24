// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentTimelineForView : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;Open -&gt; In Progress&quot;</para>
        /// </summary>
        [NameInMap("changeType")]
        [Validation(Required=false)]
        public string ChangeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;{&quot;action&quot;:&quot;restart&quot;,&quot;resourceId&quot;:&quot;i-bp123456&quot;}&quot;</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public object Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;a1b2c3d4-e5f6-7890-1234-567890abcdef&quot;</para>
        /// </summary>
        [NameInMap("incidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        [NameInMap("operator")]
        [Validation(Required=false)]
        public ContactForIncidentView Operator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1743876000000</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;x1y2z3a4-b5c6-d7e8-f9g0-h1i2j3k4l5m6&quot;</para>
        /// </summary>
        [NameInMap("timelineUuid")]
        [Validation(Required=false)]
        public string TimelineUuid { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;Comment&quot;</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;user-abc123&quot;</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;ws-xyz789&quot;</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
