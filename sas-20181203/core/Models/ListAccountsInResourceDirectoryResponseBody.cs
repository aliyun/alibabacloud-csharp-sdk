// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAccountsInResourceDirectoryResponseBody : TeaModel {
        /// <summary>
        /// The members in the resource directory.
        /// </summary>
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public List<ListAccountsInResourceDirectoryResponseBodyAccounts> Accounts { get; set; }
        public class ListAccountsInResourceDirectoryResponseBodyAccounts : TeaModel {
            /// <summary>
            /// The Alibaba Cloud account ID of the member.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// The name of the member.
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// The ID of the folder in the resource directory.
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// Indicates whether the member is an administrator account of the resource directory. Valid values:
            /// 
            /// *   **yes**
            /// *   **no**
            /// </summary>
            [NameInMap("IsMaAccount")]
            [Validation(Required=false)]
            public string IsMaAccount { get; set; }

            /// <summary>
            /// Indicates whether the member is marked as followed.
            /// </summary>
            [NameInMap("IsMarked")]
            [Validation(Required=false)]
            public string IsMarked { get; set; }

            /// <summary>
            /// Indicates whether the member is a delegated administrator account of Security Center. Valid values:
            /// 
            /// *   **yes**
            /// *   **no**
            /// </summary>
            [NameInMap("IsSasDaAccount")]
            [Validation(Required=false)]
            public string IsSasDaAccount { get; set; }

            /// <summary>
            /// Indicates whether the member is an account of the threat analysis and response feature. Valid values:
            /// 
            /// *   **yes**
            /// *   **no**
            /// </summary>
            [NameInMap("IsSiemControlAccount")]
            [Validation(Required=false)]
            public string IsSiemControlAccount { get; set; }

            /// <summary>
            /// Indicates whether the member is a delegated administrator account of the threat analysis and response feature. Valid values:
            /// 
            /// *   **yes**
            /// *   **no**
            /// </summary>
            [NameInMap("IsSiemDaAccount")]
            [Validation(Required=false)]
            public string IsSiemDaAccount { get; set; }

            /// <summary>
            /// The edition of Security Center that you use. Valid value:
            /// 
            /// *   **0** or **1**: Basic
            /// *   **2** or **3**: Enterprise
            /// *   **5**: Advanced
            /// *   **6**: Anti-virus
            /// *   **7**: Ultimate
            /// </summary>
            [NameInMap("SasVersion")]
            [Validation(Required=false)]
            public string SasVersion { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
