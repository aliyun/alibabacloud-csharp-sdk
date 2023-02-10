// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class InstallCloudMonitorRequest : TeaModel {
        [NameInMap("AgentAccessKey")]
        [Validation(Required=false)]
        public string AgentAccessKey { get; set; }

        [NameInMap("AgentSecretKey")]
        [Validation(Required=false)]
        public string AgentSecretKey { get; set; }

        [NameInMap("ArgusVersion")]
        [Validation(Required=false)]
        public string ArgusVersion { get; set; }

        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
