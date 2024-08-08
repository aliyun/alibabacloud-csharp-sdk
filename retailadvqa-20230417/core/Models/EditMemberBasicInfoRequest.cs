// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailadvqa20230417.Models
{
    public class EditMemberBasicInfoRequest : TeaModel {
        [NameInMap("Body")]
        [Validation(Required=false)]
        public EditMemberBasicInfoRequestBody Body { get; set; }
        public class EditMemberBasicInfoRequestBody : TeaModel {
            [NameInMap("Area")]
            [Validation(Required=false)]
            public string Area { get; set; }

            [NameInMap("Avatar")]
            [Validation(Required=false)]
            public string Avatar { get; set; }

            [NameInMap("Birthday")]
            [Validation(Required=false)]
            public string Birthday { get; set; }

            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("MemberName")]
            [Validation(Required=false)]
            public string MemberName { get; set; }

            [NameInMap("MemberNickName")]
            [Validation(Required=false)]
            public string MemberNickName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("OpenMerchantId")]
            [Validation(Required=false)]
            public string OpenMerchantId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("PlatformType")]
            [Validation(Required=false)]
            public string PlatformType { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            [NameInMap("Sex")]
            [Validation(Required=false)]
            public string Sex { get; set; }

        }

    }

}
