// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListAccountsByLogResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAccountsByLogResponseBodyData> Data { get; set; }
        public class ListAccountsByLogResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the cloud account.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// The name of the cloud account.
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// Indicates whether the account is added. Valid values: -1: yes -0: no
            /// </summary>
            [NameInMap("Imported")]
            [Validation(Required=false)]
            public int? Imported { get; set; }

            /// <summary>
            /// The code of the log.
            /// </summary>
            [NameInMap("LogCode")]
            [Validation(Required=false)]
            public string LogCode { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that is used to purchase the threat analysis feature.
            /// </summary>
            [NameInMap("MainUserId")]
            [Validation(Required=false)]
            public long? MainUserId { get; set; }

            /// <summary>
            /// The code of the service.
            /// </summary>
            [NameInMap("ProdCode")]
            [Validation(Required=false)]
            public string ProdCode { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account for which the threat analysis feature is enabled.
            /// </summary>
            [NameInMap("SubUserId")]
            [Validation(Required=false)]
            public long? SubUserId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
