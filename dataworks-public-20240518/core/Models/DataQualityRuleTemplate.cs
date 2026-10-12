// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DataQualityRuleTemplate : TeaModel {
        /// <summary>
        /// <para>The sample check settings.</para>
        /// </summary>
        [NameInMap("CheckingConfig")]
        [Validation(Required=false)]
        public DataQualityRuleTemplateCheckingConfig CheckingConfig { get; set; }
        public class DataQualityRuleTemplateCheckingConfig : TeaModel {
            /// <summary>
            /// <para>The expression used to query referenced samples. Some threshold types require querying referenced samples and aggregating their values to derive the comparison threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;bizdate&quot;: [ &quot;-1&quot;, &quot;-7&quot;, &quot;-1m&quot; ] }</para>
            /// </summary>
            [NameInMap("ReferencedSamplesFilter")]
            [Validation(Required=false)]
            public string ReferencedSamplesFilter { get; set; }

            /// <summary>
            /// <para>The threshold calculation method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Fixed</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The globally unique code of the rule template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER_DEFINED:123</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The category directory where the custom template is stored. Levels are separated by forward slashes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/ods/OrderData</para>
        /// </summary>
        [NameInMap("DirectoryPath")]
        [Validation(Required=false)]
        public string DirectoryPath { get; set; }

        /// <summary>
        /// <para>The name of the rule template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Table row count check</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2043</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The sample collection settings.</para>
        /// </summary>
        [NameInMap("SamplingConfig")]
        [Validation(Required=false)]
        public DataQualityRuleTemplateSamplingConfig SamplingConfig { get; set; }
        public class DataQualityRuleTemplateSamplingConfig : TeaModel {
            /// <summary>
            /// <para>The name of the sampled metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Min</para>
            /// </summary>
            [NameInMap("Metric")]
            [Validation(Required=false)]
            public string Metric { get; set; }

            /// <summary>
            /// <para>The parameters required for sample collection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;SQL&quot;: &quot;SELECT min(id) from table;&quot; }</para>
            /// </summary>
            [NameInMap("MetricParameters")]
            [Validation(Required=false)]
            public string MetricParameters { get; set; }

            /// <summary>
            /// <para>The runtime parameter setting statements inserted before the execution of the sampling statement. The maximum length is 1,000 characters. Currently, only MaxCompute is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SET odps.sql.udf.timeout=600s;</para>
            /// </summary>
            [NameInMap("SettingConfig")]
            [Validation(Required=false)]
            public string SettingConfig { get; set; }

        }

        /// <summary>
        /// <para>The DataWorks tenant ID.</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        /// <summary>
        /// <para>The visibility scope of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Project</para>
        /// </summary>
        [NameInMap("VisibleScope")]
        [Validation(Required=false)]
        public string VisibleScope { get; set; }

    }

}
