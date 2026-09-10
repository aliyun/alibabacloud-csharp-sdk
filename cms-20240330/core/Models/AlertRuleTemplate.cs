// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleTemplate : TeaModel {
        /// <summary>
        /// <para>The alert type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>METRIC_SET</para>
        /// </summary>
        [NameInMap("alertType")]
        [Validation(Required=false)]
        public string AlertType { get; set; }

        /// <summary>
        /// <para>The number of rules that have been applied from this template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("applyCount")]
        [Validation(Required=false)]
        public long? ApplyCount { get; set; }

        /// <summary>
        /// <para>The business type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALERT</para>
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The data source, in JSON string format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;SLS&quot;,&quot;project&quot;:&quot;my-project&quot;}</para>
        /// </summary>
        [NameInMap("datasource")]
        [Validation(Required=false)]
        public string Datasource { get; set; }

        /// <summary>
        /// <para>The template description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Triggers an alert when the CPU usage of an ECS instance exceeds the threshold</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The creation time, in UNIX millisecond timestamp format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700000000000</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        /// <summary>
        /// <para>The last modified time, in UNIX millisecond timestamp format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700000000000</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Indicates whether the template is a system template. Valid values: 1: yes. 0: no.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("isSystem")]
        [Validation(Required=false)]
        public int? IsSystem { get; set; }

        /// <summary>
        /// <para>The labels, in JSON string format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;env&quot;:&quot;prod&quot;,&quot;team&quot;:&quot;ops&quot;}</para>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs_ecs_dashboard</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The cloud service category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("productCategory")]
        [Validation(Required=false)]
        public string ProductCategory { get; set; }

        /// <summary>
        /// <para>The rule configurations, in JSON string format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;threshold&quot;:80,&quot;duration&quot;:60}</para>
        /// </summary>
        [NameInMap("ruleConfigs")]
        [Validation(Required=false)]
        public string RuleConfigs { get; set; }

        /// <summary>
        /// <para>The applicable scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("scenes")]
        [Validation(Required=false)]
        public string Scenes { get; set; }

        /// <summary>
        /// <para>The schema version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("schemaVersion")]
        [Validation(Required=false)]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// <para>The source type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The template status. Valid values: 1: enabled. 0: disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The subtype.</para>
        /// 
        /// <b>Example:</b>
        /// <para>THRESHOLD</para>
        /// </summary>
        [NameInMap("subType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

        /// <summary>
        /// <para>The template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS CPU Usage Alert Template</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The ID of the user to whom the template belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The template UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4-e5f6-7890-abcd-ef1234567890</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
