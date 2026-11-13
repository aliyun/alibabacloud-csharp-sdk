// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateApplicationCustomRulesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application template to which the custom rules belong. The template must exist within the current Alibaba Cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ati-4f0691c56b8d4f06</para>
        /// </summary>
        [NameInMap("ApplicationTemplateId")]
        [Validation(Required=false)]
        public string ApplicationTemplateId { get; set; }

        /// <summary>
        /// <para>The list of custom rules for the application. You can pass up to 100 rules at a time, and the total number of rules in the template after creation cannot exceed 100.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string RulesShrink { get; set; }

    }

}
