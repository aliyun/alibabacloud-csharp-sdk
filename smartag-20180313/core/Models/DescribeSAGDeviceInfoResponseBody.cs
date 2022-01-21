// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSAGDeviceInfoResponseBody : TeaModel {
        [NameInMap("ControllerState")]
        [Validation(Required=false)]
        public string ControllerState { get; set; }

        [NameInMap("LastConnectedControllerTime")]
        [Validation(Required=false)]
        public string LastConnectedControllerTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResettableStatus")]
        [Validation(Required=false)]
        public string ResettableStatus { get; set; }

        [NameInMap("ServiceIP")]
        [Validation(Required=false)]
        public string ServiceIP { get; set; }

        [NameInMap("SmartAGType")]
        [Validation(Required=false)]
        public string SmartAGType { get; set; }

        [NameInMap("StartupTime")]
        [Validation(Required=false)]
        public string StartupTime { get; set; }

        [NameInMap("SynStatus")]
        [Validation(Required=false)]
        public string SynStatus { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        [NameInMap("VpnState")]
        [Validation(Required=false)]
        public string VpnState { get; set; }

    }

}
