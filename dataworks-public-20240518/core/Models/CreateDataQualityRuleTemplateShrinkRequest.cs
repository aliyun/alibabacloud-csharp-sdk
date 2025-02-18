// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataQualityRuleTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The check settings for sample data.</para>
        /// </summary>
        [NameInMap("CheckingConfig")]
        [Validation(Required=false)]
        public string CheckingConfigShrink { get; set; }

        /// <summary>
        /// <para>The directory in which the template is stored. Slashes (/) are used to separate directory levels. The name of each directory level can be up to 1,024 characters in length. It cannot contain whitespace characters or slashes (/).</para>
        /// 
        /// <b>Example:</b>
        /// <para>/ods/order_data</para>
        /// </summary>
        [NameInMap("DirectoryPath")]
        [Validation(Required=false)]
        public string DirectoryPath { get; set; }

        /// <summary>
        /// <para>The name of the template. The name can be up to 512 characters in length and can contain digits, letters, and punctuation marks.</para>
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
        /// <para>The sampling settings.</para>
        /// </summary>
        [NameInMap("SamplingConfig")]
        [Validation(Required=false)]
        public string SamplingConfigShrink { get; set; }

        /// <summary>
        /// <para>The applicable scope of the template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Tenant: The template is available in all workspaces in the current tenant.</description></item>
        /// <item><description>Project: The template is available only in the current workspace.</description></item>
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
