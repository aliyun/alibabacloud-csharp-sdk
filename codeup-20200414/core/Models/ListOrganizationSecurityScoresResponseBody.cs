// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class ListOrganizationSecurityScoresResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListOrganizationSecurityScoresResponseBodyResult> Result { get; set; }
        public class ListOrganizationSecurityScoresResponseBodyResult : TeaModel {
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            [NameInMap("OrganizationSecurityScore")]
            [Validation(Required=false)]
            public ListOrganizationSecurityScoresResponseBodyResultOrganizationSecurityScore OrganizationSecurityScore { get; set; }
            public class ListOrganizationSecurityScoresResponseBodyResultOrganizationSecurityScore : TeaModel {
                [NameInMap("AuthorityControlScore")]
                [Validation(Required=false)]
                public int? AuthorityControlScore { get; set; }

                [NameInMap("CodeContentScore")]
                [Validation(Required=false)]
                public int? CodeContentScore { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("MemberBehaviorScore")]
                [Validation(Required=false)]
                public int? MemberBehaviorScore { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
