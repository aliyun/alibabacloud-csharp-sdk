// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class BindK8sSlbRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("SlbId")]
        [Validation(Required=false)]
        public string SlbId { get; set; }

        [NameInMap("SlbProtocol")]
        [Validation(Required=false)]
        public string SlbProtocol { get; set; }

        [NameInMap("TargetPort")]
        [Validation(Required=false)]
        public string TargetPort { get; set; }

        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        [NameInMap("ServicePortInfos")]
        [Validation(Required=false)]
        public string ServicePortInfos { get; set; }

        [NameInMap("Specification")]
        [Validation(Required=false)]
        public string Specification { get; set; }

        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

    }

}
