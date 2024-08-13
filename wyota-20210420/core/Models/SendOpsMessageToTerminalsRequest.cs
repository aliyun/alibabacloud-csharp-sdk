// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class SendOpsMessageToTerminalsRequest : TeaModel {
        [NameInMap("Delay")]
        [Validation(Required=false)]
        public bool? Delay { get; set; }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("OpsAction")]
        [Validation(Required=false)]
        public string OpsAction { get; set; }

        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public List<string> Uuids { get; set; }

        [NameInMap("WaitForAck")]
        [Validation(Required=false)]
        public bool? WaitForAck { get; set; }

    }

}
