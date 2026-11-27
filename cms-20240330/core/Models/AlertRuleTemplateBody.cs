// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleTemplateBody : TeaModel {
        /// <summary>
        /// <para>The template description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alert template for sustained CPU usage above 80%</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The business-level key-value labels. This is a JSON object string, such as {&quot;env&quot;:&quot;prod&quot;}. The default value is an empty object. An empty string is equivalent to not passing this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;env&quot;:&quot;prod&quot;}</para>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The rule configurations. This is a v2 wire JSON object string, and the top level must include datasourceConfig.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;datasourceConfig&quot;:{&quot;type&quot;:&quot;PROMETHEUS&quot;,&quot;regionId&quot;:&quot;cn-hangzhou&quot;},&quot;queryConfig&quot;:{&quot;type&quot;:&quot;PROMQL_QUERY&quot;,&quot;expr&quot;:&quot;up == 0&quot;}}</para>
        /// </summary>
        [NameInMap("ruleConfigs")]
        [Validation(Required=false)]
        public string RuleConfigs { get; set; }

        /// <summary>
        /// <para>The scenario labels. This is a JSON array string, such as [&quot;Runbook&quot;]. The default value is an empty array. An empty string is equivalent to not passing this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Runbook&quot;]</para>
        /// </summary>
        [NameInMap("scenes")]
        [Validation(Required=false)]
        public string Scenes { get; set; }

        /// <summary>
        /// <para>The schema version of the template. The default value is v2. v1 is rejected by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("schemaVersion")]
        [Validation(Required=false)]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// <para>The enabling status of the template. Valid values: 1: Enabled. 0: Disabled. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod-cpu-high-template</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
