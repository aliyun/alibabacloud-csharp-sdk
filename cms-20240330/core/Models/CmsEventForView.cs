// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CmsEventForView : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{ &quot;description&quot;: &quot;High load detected on server&quot;, &quot;operator&quot;: &quot;auto&quot; }</para>
        /// </summary>
        [NameInMap("annotations")]
        [Validation(Required=false)]
        public Dictionary<string, object> Annotations { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ &quot;metricName&quot;: &quot;cpu_usage&quot;, &quot;value&quot;: 95.2, &quot;threshold&quot;: 80 }</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;application/json&quot;</para>
        /// </summary>
        [NameInMap("datacontenttype")]
        [Validation(Required=false)]
        public string Datacontenttype { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;<a href="https://schema.alibabacloud.com/cms/alert/v1">https://schema.alibabacloud.com/cms/alert/v1</a>&quot;</para>
        /// </summary>
        [NameInMap("dataschema")]
        [Validation(Required=false)]
        public string Dataschema { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;dedup-abc123&quot;</para>
        /// </summary>
        [NameInMap("dedupId")]
        [Validation(Required=false)]
        public string DedupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;event-1234567890&quot;</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;integration-xyz&quot;</para>
        /// </summary>
        [NameInMap("integrationUuid")]
        [Validation(Required=false)]
        public string IntegrationUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;source\&quot;: \&quot;system\&quot;}</para>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public Dictionary<string, object> Labels { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1743846610000</para>
        /// </summary>
        [NameInMap("receiveTime")]
        [Validation(Required=false)]
        public long? ReceiveTime { get; set; }

        [NameInMap("resource")]
        [Validation(Required=false)]
        public EventResourceForEventView Resource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;CRITICAL&quot;</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;ECS&quot;</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;CloudMonitor&quot;</para>
        /// </summary>
        [NameInMap("sourcetype")]
        [Validation(Required=false)]
        public string Sourcetype { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;Instance cpu usage exceeds threshold&quot;</para>
        /// </summary>
        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;HighCPUUsage&quot;</para>
        /// </summary>
        [NameInMap("subtype")]
        [Validation(Required=false)]
        public string Subtype { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;sys-event-987654321&quot;</para>
        /// </summary>
        [NameInMap("sysId")]
        [Validation(Required=false)]
        public string SysId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;2025-04-05T10:30:00Z&quot;</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1743846600000</para>
        /// </summary>
        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;Alert&quot;</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;ws-abc123&quot;</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ &quot;department&quot;: &quot;finance&quot;, &quot;project&quot;: &quot;payment-gateway&quot; }</para>
        /// </summary>
        [NameInMap("workspaceTags")]
        [Validation(Required=false)]
        public Dictionary<string, object> WorkspaceTags { get; set; }

    }

}
