// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateRuleActionRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("RuleId")]
        [Validation(Required=true)]
        public long? RuleId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=true)]
        public string Type { get; set; }

        [NameInMap("Configuration")]
        [Validation(Required=true)]
        public string Configuration { get; set; }

        [NameInMap("ErrorActionFlag")]
        [Validation(Required=false)]
        public bool? ErrorActionFlag { get; set; }

    }

}
