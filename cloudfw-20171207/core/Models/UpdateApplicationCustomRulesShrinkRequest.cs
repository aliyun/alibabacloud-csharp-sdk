// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class UpdateApplicationCustomRulesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of custom application rules to be modified. You can specify up to 20 rules at a time. Rule IDs in the list must be unique.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string RulesShrink { get; set; }

    }

}
