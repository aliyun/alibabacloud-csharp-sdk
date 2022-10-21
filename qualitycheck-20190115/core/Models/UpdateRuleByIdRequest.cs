// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class UpdateRuleByIdRequest : TeaModel {
        [NameInMap("IsCopy")]
        [Validation(Required=false)]
        public bool? IsCopy { get; set; }

        [NameInMap("JsonStrForRule")]
        [Validation(Required=false)]
        public string JsonStrForRule { get; set; }

        [NameInMap("ReturnRelatedSchemes")]
        [Validation(Required=false)]
        public bool? ReturnRelatedSchemes { get; set; }

        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

    }

}
