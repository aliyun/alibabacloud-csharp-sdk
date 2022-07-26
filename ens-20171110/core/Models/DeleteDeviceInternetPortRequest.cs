// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteDeviceInternetPortRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("NatType")]
        [Validation(Required=false)]
        public string NatType { get; set; }

        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

    }

}
