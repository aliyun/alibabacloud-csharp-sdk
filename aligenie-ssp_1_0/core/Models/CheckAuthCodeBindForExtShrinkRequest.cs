// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class CheckAuthCodeBindForExtShrinkRequest : TeaModel {
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        [NameInMap("EncodeKey")]
        [Validation(Required=false)]
        public string EncodeKey { get; set; }

        [NameInMap("EncodeType")]
        [Validation(Required=false)]
        public string EncodeType { get; set; }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public string UserInfoShrink { get; set; }

    }

}
