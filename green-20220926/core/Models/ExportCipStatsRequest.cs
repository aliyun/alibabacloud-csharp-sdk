// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class ExportCipStatsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether monthly indexing is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Supported.</description></item>
        /// <item><description><b>false</b>: Not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ByMonth")]
        [Validation(Required=false)]
        public bool? ByMonth { get; set; }

        /// <summary>
        /// <para>The end time of the query. Format: yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-16 09:00:00</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The export type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>level</b>: Export by risk level.</description></item>
        /// <item><description><b>label</b>: Export by label.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>label</para>
        /// </summary>
        [NameInMap("ExportType")]
        [Validation(Required=false)]
        public string ExportType { get; set; }

        /// <summary>
        /// <para>The task label to export.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The query condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Classify&quot;:&quot;guard-scene&quot;}</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The service code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>baselineCheck</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// <para>The start time of the query. Format: yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-15 09:00:00</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The UID of the RAM user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>268220485413130979</para>
        /// </summary>
        [NameInMap("SubUid")]
        [Validation(Required=false)]
        public string SubUid { get; set; }

        /// <summary>
        /// <para>The type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cip</b>: Content Moderation invoke volume statistics.</description></item>
        /// <item><description><b>risk_level</b>: Content Moderation security risk level statistics.</description></item>
        /// <item><description><b>content_moderation</b>: AI Safety Guardrail content compliance risk level and tag statistics.</description></item>
        /// <item><description><b>sensitive_data</b>: AI Safety Guardrail sensitive data risk level and tag statistics.</description></item>
        /// <item><description><b>prompt_attack</b>: AI Safety Guardrail prompt risk level and tag statistics.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>risk_level</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
