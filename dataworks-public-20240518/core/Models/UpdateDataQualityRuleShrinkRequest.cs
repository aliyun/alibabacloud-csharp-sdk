// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateDataQualityRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The sample verification settings.</para>
        /// </summary>
        [NameInMap("CheckingConfig")]
        [Validation(Required=false)]
        public string CheckingConfigShrink { get; set; }

        /// <summary>
        /// <para>The rule description. The maximum length is 500 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a odps _sql task</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether the rule is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The list of issue handlers for data quality rule verification.</para>
        /// </summary>
        [NameInMap("ErrorHandlers")]
        [Validation(Required=false)]
        public string ErrorHandlersShrink { get; set; }

        /// <summary>
        /// <para>The rule ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The rule name. The name can be a combination of digits, English letters, Chinese characters, and half-width or full-width punctuation. The maximum length is 255 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The table cannot be empty.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Settings page to obtain the workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The settings required for sample collection.</para>
        /// </summary>
        [NameInMap("SamplingConfig")]
        [Validation(Required=false)]
        public string SamplingConfigShrink { get; set; }

        /// <summary>
        /// <para>The severity level of the rule for the business (corresponding to strong/weak rules on the page). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Normal</description></item>
        /// <item><description>High</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>High</para>
        /// </summary>
        [NameInMap("Severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The unique identifier of the rule template referenced by the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM:table:table_count:fixed</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

    }

}
