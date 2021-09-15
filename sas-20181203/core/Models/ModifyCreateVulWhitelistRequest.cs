// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyCreateVulWhitelistRequest : TeaModel {
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public string Whitelist { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("TargetInfo")]
        [Validation(Required=false)]
        public string TargetInfo { get; set; }

    }

}
