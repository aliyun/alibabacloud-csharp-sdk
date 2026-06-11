// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiStatisticsPathField : TeaModel {
        /// <summary>
        /// <para>The category to which the field belongs, used for grouping and organizing fields.</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>A detailed description that provides additional context about the field\&quot;s purpose and usage.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The unique key used to identify the field in statistical results.</para>
        /// </summary>
        [NameInMap("fieldKey")]
        [Validation(Required=false)]
        public string FieldKey { get; set; }

        /// <summary>
        /// <para>Specifies whether the field is an input or an output. Valid values are typically <c>IN</c> or <c>OUT</c>.</para>
        /// </summary>
        [NameInMap("io")]
        [Validation(Required=false)]
        public string Io { get; set; }

        /// <summary>
        /// <para>The JSONPath expression to extract the field value from the source data.</para>
        /// </summary>
        [NameInMap("jsonPath")]
        [Validation(Required=false)]
        public string JsonPath { get; set; }

        /// <summary>
        /// <para>The display name of the field, used for labeling in user interfaces or reports.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether logging is enabled for this field. If set to <c>true</c>, the system records the field\&quot;s value in logs.</para>
        /// </summary>
        [NameInMap("recordEnabled")]
        [Validation(Required=false)]
        public bool? RecordEnabled { get; set; }

        /// <summary>
        /// <para>A rule or condition applied to the extracted field. The rule\&quot;s format and effect are implementation-specific.</para>
        /// </summary>
        [NameInMap("rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>Indicates whether the field contains sensitive information. If set to <c>true</c>, the system may apply masking or other security measures.</para>
        /// </summary>
        [NameInMap("sensitive")]
        [Validation(Required=false)]
        public bool? Sensitive { get; set; }

        /// <summary>
        /// <para>The data source from which the field is extracted. For example, <c>Request</c> or <c>Response</c>.</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
