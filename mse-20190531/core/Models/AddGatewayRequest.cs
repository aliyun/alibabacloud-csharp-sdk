// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddGatewayRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("EnableHardwareAcceleration")]
        [Validation(Required=false)]
        public bool? EnableHardwareAcceleration { get; set; }

        [NameInMap("EnableSls")]
        [Validation(Required=false)]
        public bool? EnableSls { get; set; }

        [NameInMap("EnableXtrace")]
        [Validation(Required=false)]
        public bool? EnableXtrace { get; set; }

        [NameInMap("EnterpriseSecurityGroup")]
        [Validation(Required=false)]
        public bool? EnterpriseSecurityGroup { get; set; }

        [NameInMap("InternetSlbSpec")]
        [Validation(Required=false)]
        public string InternetSlbSpec { get; set; }

        [NameInMap("MseSessionId")]
        [Validation(Required=false)]
        public string MseSessionId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("Replica")]
        [Validation(Required=false)]
        public int? Replica { get; set; }

        [NameInMap("SlbSpec")]
        [Validation(Required=false)]
        public string SlbSpec { get; set; }

        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("VSwitchId2")]
        [Validation(Required=false)]
        public string VSwitchId2 { get; set; }

        [NameInMap("Vpc")]
        [Validation(Required=false)]
        public string Vpc { get; set; }

        [NameInMap("XtraceRatio")]
        [Validation(Required=false)]
        public string XtraceRatio { get; set; }

    }

}
