// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostAccountsForHostShareKeyResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the host accounts that are associated with the shared key.
        /// </summary>
        [NameInMap("HostAccounts")]
        [Validation(Required=false)]
        public List<ListHostAccountsForHostShareKeyResponseBodyHostAccounts> HostAccounts { get; set; }
        public class ListHostAccountsForHostShareKeyResponseBodyHostAccounts : TeaModel {
            /// <summary>
            /// The name of the host account.
            /// </summary>
            [NameInMap("HostAccountName")]
            [Validation(Required=false)]
            public string HostAccountName { get; set; }

            /// <summary>
            /// The ID of the host.
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// The ID of the host account.
            /// </summary>
            [NameInMap("HostsAccountId")]
            [Validation(Required=false)]
            public string HostsAccountId { get; set; }

            /// <summary>
            /// The O&M protocol.
            /// </summary>
            [NameInMap("ProtocolName")]
            [Validation(Required=false)]
            public string ProtocolName { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of the host accounts that are associated with the shared key.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
