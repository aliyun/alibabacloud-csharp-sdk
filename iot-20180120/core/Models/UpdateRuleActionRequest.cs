// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UpdateRuleActionRequest : TeaModel {
        [NameInMap("ActionId")]
        [Validation(Required=true)]
        public long? ActionId { get; set; }

        [NameInMap("Configuration")]
        [Validation(Required=true)]
        public string Configuration { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=true)]
        public string Type { get; set; }

    }

}
