// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class AddCustomAuthPermissionRequest : TeaModel {
        [NameInMap("Effect")]
        [Validation(Required=false)]
        public string Effect { get; set; }

        [NameInMap("Identity")]
        [Validation(Required=false)]
        public string Identity { get; set; }

        [NameInMap("IdentityType")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PermitAction")]
        [Validation(Required=false)]
        public string PermitAction { get; set; }

        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
