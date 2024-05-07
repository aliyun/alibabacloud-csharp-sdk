// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateResourceRuleItemRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MaxValue")]
        [Validation(Required=false)]
        public double? MaxValue { get; set; }

        [NameInMap("MinValue")]
        [Validation(Required=false)]
        public double? MinValue { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public double? Value { get; set; }

    }

}
