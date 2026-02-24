// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentEventForView : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1743876600000</para>
        /// </summary>
        [NameInMap("autoRecoverTime")]
        [Validation(Required=false)]
        public long? AutoRecoverTime { get; set; }

        [NameInMap("content")]
        [Validation(Required=false)]
        public CmsEventForView Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ &quot;env&quot;: &quot;prod&quot;, &quot;module&quot;: &quot;payment&quot; }</para>
        /// </summary>
        [NameInMap("dimension")]
        [Validation(Required=false)]
        public Dictionary<string, object> Dimension { get; set; }

        [NameInMap("eventResource")]
        [Validation(Required=false)]
        public EventResourceForIncidentView EventResource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ &quot;resourceId&quot;: &quot;i-bp123456&quot;, &quot;severity&quot;: &quot;Critical&quot; }</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public Dictionary<string, object> GroupBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;x1y2z3a4-b5c6-d7e8-f9g0-h1i2j3k4l5m6&quot;</para>
        /// </summary>
        [NameInMap("incidentEventUuid")]
        [Validation(Required=false)]
        public string IncidentEventUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;a1b2c3d4-e5f6-7890-1234-567890abcdef&quot;</para>
        /// </summary>
        [NameInMap("incidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ &quot;project&quot;: &quot;payment-gateway&quot;, &quot;owner&quot;: &quot;ops-team&quot; }</para>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public Dictionary<string, object> Labels { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1743876000000</para>
        /// </summary>
        [NameInMap("lastTime")]
        [Validation(Required=false)]
        public long? LastTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1743876600000</para>
        /// </summary>
        [NameInMap("recoverTime")]
        [Validation(Required=false)]
        public long? RecoverTime { get; set; }

        [NameInMap("searchIndex")]
        [Validation(Required=false)]
        public List<string> SearchIndex { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;Critical&quot;</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ &quot;Critical&quot;: 2, &quot;High&quot;: 1 }</para>
        /// </summary>
        [NameInMap("severityCountMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> SeverityCountMap { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public int? State { get; set; }

        [NameInMap("textIndex")]
        [Validation(Required=false)]
        public string TextIndex { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1743876000000</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

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
