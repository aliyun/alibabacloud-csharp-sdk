// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class ConfigInstanceNetworkRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PublicAccessControl")]
        [Validation(Required=false)]
        public int? PublicAccessControl { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("PrivateWhiteList")]
        [Validation(Required=false)]
        public List<string> PrivateWhiteList { get; set; }

        [NameInMap("PublicWhiteList")]
        [Validation(Required=false)]
        public List<string> PublicWhiteList { get; set; }

        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

    }

}
