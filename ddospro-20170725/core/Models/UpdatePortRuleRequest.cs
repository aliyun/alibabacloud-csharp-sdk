// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DDoSPro20170725.Models
{
    public class UpdatePortRuleRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("FrontPort")]
        [Validation(Required=false)]
        public int? FrontPort { get; set; }

        [NameInMap("RealServerList")]
        [Validation(Required=false)]
        public string RealServerList { get; set; }

        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

    }

}
