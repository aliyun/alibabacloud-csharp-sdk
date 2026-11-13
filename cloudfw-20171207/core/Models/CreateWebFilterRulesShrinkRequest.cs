// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateWebFilterRulesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of web filtering rules. You can specify a maximum of 100 rules at a time, and the total number of rules in the template after creation cannot exceed 100.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string RulesShrink { get; set; }

        /// <summary>
        /// <para>The ID of the web filtering template to which the web filtering rules belong. The template must exist under the current Alibaba Cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wft-3f2a9c1d4b5e6f70</para>
        /// </summary>
        [NameInMap("WebFilterTemplateId")]
        [Validation(Required=false)]
        public string WebFilterTemplateId { get; set; }

    }

}
