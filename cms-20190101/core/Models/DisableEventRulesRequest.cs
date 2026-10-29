// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DisableEventRulesRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The names of the alert rules.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RuleNames")]
        [Validation(Required=false)]
        public List<string> RuleNames { get; set; }

    }

}
