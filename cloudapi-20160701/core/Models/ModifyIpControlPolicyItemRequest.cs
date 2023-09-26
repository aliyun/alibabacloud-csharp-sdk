// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160701.Models
{
    public class ModifyIpControlPolicyItemRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("CidrIp")]
        [Validation(Required=false)]
        public string CidrIp { get; set; }

        [NameInMap("IpControlId")]
        [Validation(Required=false)]
        public string IpControlId { get; set; }

        [NameInMap("PolicyItemId")]
        [Validation(Required=false)]
        public string PolicyItemId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
