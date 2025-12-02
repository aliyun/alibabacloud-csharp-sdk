// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class ExportCipStatsRequest : TeaModel {
        /// <summary>
        /// <para>Whether to support monthly indexing. Values: -<b>true</b>: Supported. -<b>false</b>: Not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ByMonth")]
        [Validation(Required=false)]
        public bool? ByMonth { get; set; }

        /// <summary>
        /// <para>The end time of the query, in the format yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-16 09:00:00</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>Export type. Values: -<b>level</b>: Export by risk level. -<b>label</b>: Export by label.</para>
        /// 
        /// <b>Example:</b>
        /// <para>label</para>
        /// </summary>
        [NameInMap("ExportType")]
        [Validation(Required=false)]
        public string ExportType { get; set; }

        /// <summary>
        /// <para>The label of the task to be exported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>Service code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>baselineCheck</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// <para>The start time of the query, in the format yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-15 09:00:00</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>Sub-account UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>268220485413130979</para>
        /// </summary>
        [NameInMap("SubUid")]
        [Validation(Required=false)]
        public string SubUid { get; set; }

        /// <summary>
        /// <para>Type, values: -<b>cip</b>: Content Security Invocation Count Statistics. -<b>risk_level</b>: Content Security Risk Level Statistics. -<b>content_moderation</b>: AI Safety Guardrail Content Compliance Risk Level and Label Statistics. -<b>sensitive_data</b>: AI Safety Guardrail Sensitive Data Risk Level and Label Statistics. -<b>prompt_attack</b>: AI Safety Guardrail Prompt Word Risk Level and Label Statistics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>risk_level</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
