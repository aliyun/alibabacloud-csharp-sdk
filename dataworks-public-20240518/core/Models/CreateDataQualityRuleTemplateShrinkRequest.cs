// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataQualityRuleTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The sample validation settings.</para>
        /// </summary>
        [NameInMap("CheckingConfig")]
        [Validation(Required=false)]
        public string CheckingConfigShrink { get; set; }

        /// <summary>
        /// <para>The category directory where the custom template is stored. Hierarchy levels are separated by slashes. Each level name can be up to 1024 characters long and cannot contain whitespace characters or slashes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/ods/order_data</para>
        /// </summary>
        [NameInMap("DirectoryPath")]
        [Validation(Required=false)]
        public string DirectoryPath { get; set; }

        /// <summary>
        /// <para>The name of the rule template. It can be a combination of digits, English letters, Chinese characters, and half-width or full-width punctuation marks. The maximum length is 512 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Table row Count Verification</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
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
        /// <para>The visibility scope of the template:</para>
        /// <list type="bullet">
        /// <item><description>Tenant: available to the entire tenant</description></item>
        /// <item><description>Project: available only in the current project</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Project</para>
        /// </summary>
        [NameInMap("VisibleScope")]
        [Validation(Required=false)]
        public string VisibleScope { get; set; }

    }

}
