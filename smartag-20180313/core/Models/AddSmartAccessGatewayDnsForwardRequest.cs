// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class AddSmartAccessGatewayDnsForwardRequest : TeaModel {
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("MasterIp")]
        [Validation(Required=false)]
        public string MasterIp { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("OutboundPortIndex")]
        [Validation(Required=false)]
        public string OutboundPortIndex { get; set; }

        [NameInMap("OutboundPortName")]
        [Validation(Required=false)]
        public string OutboundPortName { get; set; }

        [NameInMap("OutboundPortType")]
        [Validation(Required=false)]
        public string OutboundPortType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SagInsId")]
        [Validation(Required=false)]
        public string SagInsId { get; set; }

        [NameInMap("SagSn")]
        [Validation(Required=false)]
        public string SagSn { get; set; }

        [NameInMap("SlaveIp")]
        [Validation(Required=false)]
        public string SlaveIp { get; set; }

    }

}
