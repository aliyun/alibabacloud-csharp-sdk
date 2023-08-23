// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetUserByDeviceIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetUserByDeviceIdResponseBodyResult Result { get; set; }
        public class GetUserByDeviceIdResponseBodyResult : TeaModel {
            [NameInMap("UserOpenId")]
            [Validation(Required=false)]
            public string UserOpenId { get; set; }

            [NameInMap("UserUnionIds")]
            [Validation(Required=false)]
            public List<GetUserByDeviceIdResponseBodyResultUserUnionIds> UserUnionIds { get; set; }
            public class GetUserByDeviceIdResponseBodyResultUserUnionIds : TeaModel {
                [NameInMap("OrganizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

                [NameInMap("UserUnionId")]
                [Validation(Required=false)]
                public string UserUnionId { get; set; }

            }

        }

    }

}
