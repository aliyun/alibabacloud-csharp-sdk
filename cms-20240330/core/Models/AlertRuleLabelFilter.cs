// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleLabelFilter : TeaModel {
        [NameInMap("labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

        [NameInMap("opt")]
        [Validation(Required=false)]
        public string Opt { get; set; }

    }

}
