// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentEventForView : TeaModel {
        /// <summary>
        /// <para>The UNIX timestamp of the automatic recovery.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1743876600000</para>
        /// </summary>
        [NameInMap("autoRecoverTime")]
        [Validation(Required=false)]
        public long? AutoRecoverTime { get; set; }

        /// <summary>
        /// <para>The details of the event.</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public CmsEventForView Content { get; set; }

        /// <summary>
        /// <para>The number of times the event was triggered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The dimension information of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;env&quot;: &quot;prod&quot;, &quot;module&quot;: &quot;payment&quot; }</para>
        /// </summary>
        [NameInMap("dimension")]
        [Validation(Required=false)]
        public Dictionary<string, object> Dimension { get; set; }

        /// <summary>
        /// <para>The information about the associated resource.</para>
        /// </summary>
        [NameInMap("eventResource")]
        [Validation(Required=false)]
        public EventResourceForIncidentView EventResource { get; set; }

        /// <summary>
        /// <para>The criteria for grouping.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;resourceId&quot;: &quot;i-bp123456&quot;, &quot;severity&quot;: &quot;Critical&quot; }</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public Dictionary<string, object> GroupBy { get; set; }

        /// <summary>
        /// <para>The unique ID of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;x1y2z3a4-b5c6-d7e8-f9g0-h1i2j3k4l5m6&quot;</para>
        /// </summary>
        [NameInMap("incidentEventUuid")]
        [Validation(Required=false)]
        public string IncidentEventUuid { get; set; }

        /// <summary>
        /// <para>The unique ID of the incident to which the event belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;a1b2c3d4-e5f6-7890-1234-567890abcdef&quot;</para>
        /// </summary>
        [NameInMap("incidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        /// <summary>
        /// <para>The key-value pairs of custom tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;project&quot;: &quot;payment-gateway&quot;, &quot;owner&quot;: &quot;ops-team&quot; }</para>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public Dictionary<string, object> Labels { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp of the last occurrence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1743876000000</para>
        /// </summary>
        [NameInMap("lastTime")]
        [Validation(Required=false)]
        public long? LastTime { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp of the recovery.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1743876600000</para>
        /// </summary>
        [NameInMap("recoverTime")]
        [Validation(Required=false)]
        public long? RecoverTime { get; set; }

        /// <summary>
        /// <para>The list of search index fields.</para>
        /// </summary>
        [NameInMap("searchIndex")]
        [Validation(Required=false)]
        public List<string> SearchIndex { get; set; }

        /// <summary>
        /// <para>The severity level of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;Critical&quot;</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The statistics on the number of events for each severity level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;Critical&quot;: 2, &quot;High&quot;: 1 }</para>
        /// </summary>
        [NameInMap("severityCountMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> SeverityCountMap { get; set; }

        /// <summary>
        /// <para>The current status code of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public int? State { get; set; }

        /// <summary>
        /// <para>The text index field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;ECS 实例 CPU 使用率过高&quot;</para>
        /// </summary>
        [NameInMap("textIndex")]
        [Validation(Required=false)]
        public string TextIndex { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp when the event occurred.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1743876000000</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        /// <summary>
        /// <para>The title of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;ECS 实例 i-bp123456 CPU 使用率超过 90%&quot;</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The ID of the user who created or triggered the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;user-abc123&quot;</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The name of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;ws-xyz789&quot;</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
