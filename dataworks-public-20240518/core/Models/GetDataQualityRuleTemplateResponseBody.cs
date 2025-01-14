// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDataQualityRuleTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the template.</para>
        /// </summary>
        [NameInMap("DataQualityRuleTemplate")]
        [Validation(Required=false)]
        public GetDataQualityRuleTemplateResponseBodyDataQualityRuleTemplate DataQualityRuleTemplate { get; set; }
        public class GetDataQualityRuleTemplateResponseBodyDataQualityRuleTemplate : TeaModel {
            [NameInMap("CheckingConfig")]
            [Validation(Required=false)]
            public GetDataQualityRuleTemplateResponseBodyDataQualityRuleTemplateCheckingConfig CheckingConfig { get; set; }
            public class GetDataQualityRuleTemplateResponseBodyDataQualityRuleTemplateCheckingConfig : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>USER_DEFINED:123</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("DirectoryPath")]
            [Validation(Required=false)]
            public string DirectoryPath { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4020</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("SamplingConfig")]
            [Validation(Required=false)]
            public GetDataQualityRuleTemplateResponseBodyDataQualityRuleTemplateSamplingConfig SamplingConfig { get; set; }
            public class GetDataQualityRuleTemplateResponseBodyDataQualityRuleTemplateSamplingConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Max</para>
                /// </summary>
                [NameInMap("Metric")]
                [Validation(Required=false)]
                public string Metric { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;SQL&quot;: &quot;select count(1) from table;&quot;}</para>
                /// </summary>
                [NameInMap("MetricParameters")]
                [Validation(Required=false)]
                public string MetricParameters { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SET odps.sql.udf.timeout=600s; 
                /// SET odps.sql.python.version=cp27;</para>
                /// </summary>
                [NameInMap("SettingConfig")]
                [Validation(Required=false)]
                public string SettingConfig { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Project</para>
            /// </summary>
            [NameInMap("VisibleScope")]
            [Validation(Required=false)]
            public string VisibleScope { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>691CA452-D37A-4ED0-9441</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
