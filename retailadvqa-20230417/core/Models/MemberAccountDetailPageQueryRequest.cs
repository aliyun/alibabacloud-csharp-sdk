// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailadvqa20230417.Models
{
    public class MemberAccountDetailPageQueryRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public MemberAccountDetailPageQueryRequestBody Body { get; set; }
        public class MemberAccountDetailPageQueryRequestBody : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public int? AccountType { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("OpenMerchantId")]
            [Validation(Required=false)]
            public string OpenMerchantId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("OuterMemberId")]
            [Validation(Required=false)]
            public string OuterMemberId { get; set; }

            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("PlatFormType")]
            [Validation(Required=false)]
            public string PlatFormType { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

    }

}
