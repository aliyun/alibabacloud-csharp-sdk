// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgDesensPlanAddOrUpdateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A collection of data masking rules that you want to add or modify.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DesensRules")]
        [Validation(Required=false)]
        public string DesensRulesShrink { get; set; }

    }

}
