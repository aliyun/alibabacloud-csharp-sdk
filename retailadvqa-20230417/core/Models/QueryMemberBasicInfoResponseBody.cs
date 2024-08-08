// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailadvqa20230417.Models
{
    public class QueryMemberBasicInfoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryMemberBasicInfoResponseBodyData Data { get; set; }
        public class QueryMemberBasicInfoResponseBodyData : TeaModel {
            [NameInMap("Area")]
            [Validation(Required=false)]
            public string Area { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
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

            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            [NameInMap("LevelName")]
            [Validation(Required=false)]
            public string LevelName { get; set; }

            [NameInMap("LevelNum")]
            [Validation(Required=false)]
            public string LevelNum { get; set; }

            [NameInMap("MemberName")]
            [Validation(Required=false)]
            public string MemberName { get; set; }

            [NameInMap("MemberNickName")]
            [Validation(Required=false)]
            public string MemberNickName { get; set; }

            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("NearExpiredScore")]
            [Validation(Required=false)]
            public string NearExpiredScore { get; set; }

            [NameInMap("OpenMerchantId")]
            [Validation(Required=false)]
            public string OpenMerchantId { get; set; }

            [NameInMap("OuterMemberId")]
            [Validation(Required=false)]
            public string OuterMemberId { get; set; }

            [NameInMap("Points")]
            [Validation(Required=false)]
            public string Points { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            [NameInMap("Score")]
            [Validation(Required=false)]
            public string Score { get; set; }

            [NameInMap("Sex")]
            [Validation(Required=false)]
            public string Sex { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
