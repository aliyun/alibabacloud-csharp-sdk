// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class CheckAuthCodeBindForExtRequest : TeaModel {
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
        public CheckAuthCodeBindForExtRequestUserInfo UserInfo { get; set; }
        public class CheckAuthCodeBindForExtRequestUserInfo : TeaModel {
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

    }

}
