// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160701.Models
{
    public class AddTrafficSpecialControlRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("SpecialKey")]
        [Validation(Required=false)]
        public string SpecialKey { get; set; }

        [NameInMap("SpecialType")]
        [Validation(Required=false)]
        public string SpecialType { get; set; }

        [NameInMap("TrafficControlId")]
        [Validation(Required=false)]
        public string TrafficControlId { get; set; }

        [NameInMap("TrafficValue")]
        [Validation(Required=false)]
        public int? TrafficValue { get; set; }

    }

}
