// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateHoneypotNodeRequest : TeaModel {
        [NameInMap("AllowHoneypotAccessInternet")]
        [Validation(Required=false)]
        public bool? AllowHoneypotAccessInternet { get; set; }

        [NameInMap("AvailableProbeNum")]
        [Validation(Required=false)]
        public int? AvailableProbeNum { get; set; }

        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        [NameInMap("SecurityGroupProbeIpList")]
        [Validation(Required=false)]
        public List<string> SecurityGroupProbeIpList { get; set; }

    }

}
