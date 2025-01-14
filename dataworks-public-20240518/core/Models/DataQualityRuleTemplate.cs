// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DataQualityRuleTemplate : TeaModel {
        [NameInMap("CheckingConfig")]
        [Validation(Required=false)]
        public DataQualityRuleTemplateCheckingConfig CheckingConfig { get; set; }
        public class DataQualityRuleTemplateCheckingConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{ &quot;bizdate&quot;: [ &quot;-1&quot;, &quot;-7&quot;, &quot;-1m&quot; ] }</para>
            /// </summary>
            [NameInMap("ReferencedSamplesFilter")]
            [Validation(Required=false)]
            public string ReferencedSamplesFilter { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Fixed</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/ods/订单数据</para>
        /// </summary>
        [NameInMap("DirectoryPath")]
        [Validation(Required=false)]
        public string DirectoryPath { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("SamplingConfig")]
        [Validation(Required=false)]
        public DataQualityRuleTemplateSamplingConfig SamplingConfig { get; set; }
        public class DataQualityRuleTemplateSamplingConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Min</para>
            /// </summary>
            [NameInMap("Metric")]
            [Validation(Required=false)]
            public string Metric { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{ &quot;SQL&quot;: &quot;SELECT min(id) from table;&quot; }</para>
            /// </summary>
            [NameInMap("MetricParameters")]
            [Validation(Required=false)]
            public string MetricParameters { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SET odps.sql.udf.timeout=600s;</para>
            /// </summary>
            [NameInMap("SettingConfig")]
            [Validation(Required=false)]
            public string SettingConfig { get; set; }

        }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Project</para>
        /// </summary>
        [NameInMap("VisibleScope")]
        [Validation(Required=false)]
        public string VisibleScope { get; set; }

    }

}
