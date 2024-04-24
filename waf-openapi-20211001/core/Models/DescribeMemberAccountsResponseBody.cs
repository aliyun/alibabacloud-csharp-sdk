// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeMemberAccountsResponseBody : TeaModel {
        /// <summary>
        /// The information about the member.
        /// </summary>
        [NameInMap("AccountInfos")]
        [Validation(Required=false)]
        public List<DescribeMemberAccountsResponseBodyAccountInfos> AccountInfos { get; set; }
        public class DescribeMemberAccountsResponseBodyAccountInfos : TeaModel {
            /// <summary>
            /// The ID of the member.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// The name of the member.
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// The status of the member.
            /// 
            /// *   **enabled**: managed.
            /// *   **disabled**: not managed.
            /// *   **disabling**: being deleted.
            /// </summary>
            [NameInMap("AccountStatus")]
            [Validation(Required=false)]
            public string AccountStatus { get; set; }

            /// <summary>
            /// The description of the member.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The time when the member was added.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
