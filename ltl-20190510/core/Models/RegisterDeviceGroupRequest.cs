// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ltl20190510.Models
{
    public class RegisterDeviceGroupRequest : TeaModel {
        [NameInMap("ApiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        [NameInMap("AuthorizeType")]
        [Validation(Required=false)]
        public string AuthorizeType { get; set; }

        [NameInMap("BizChainId")]
        [Validation(Required=false)]
        public string BizChainId { get; set; }

        [NameInMap("DeviceGroupName")]
        [Validation(Required=false)]
        public string DeviceGroupName { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
