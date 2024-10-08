// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafTemplateRulesShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>http_anti_scan</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public string QueryArgsShrink { get; set; }

    }

}
