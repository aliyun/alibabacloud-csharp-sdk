// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateDefenseRuleRequest : TeaModel {
        [NameInMap("DefenseScene")]
        [Validation(Required=false)]
        public string DefenseScene { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string Rules { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
