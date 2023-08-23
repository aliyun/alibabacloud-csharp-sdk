// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetDeviceIdByIdentityRequest : TeaModel {
        [NameInMap("EncodeKey")]
        [Validation(Required=false)]
        public string EncodeKey { get; set; }

        [NameInMap("EncodeType")]
        [Validation(Required=false)]
        public string EncodeType { get; set; }

        [NameInMap("IdentityId")]
        [Validation(Required=false)]
        public string IdentityId { get; set; }

        [NameInMap("IdentityType")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

    }

}
