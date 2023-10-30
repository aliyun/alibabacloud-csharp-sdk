// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostAccountsForUserResponseBody : TeaModel {
        /// <summary>
        /// The host accounts returned.
        /// </summary>
        [NameInMap("HostAccounts")]
        [Validation(Required=false)]
        public List<ListHostAccountsForUserResponseBodyHostAccounts> HostAccounts { get; set; }
        public class ListHostAccountsForUserResponseBodyHostAccounts : TeaModel {
            /// <summary>
            /// The protocol that is used by the host account. Valid values:
            /// 
            /// *   **SSH**
            /// *   **RDP**
            /// </summary>
            [NameInMap("HostAccountId")]
            [Validation(Required=false)]
            public string HostAccountId { get; set; }

            /// <summary>
            /// The ID of the host account.
            /// </summary>
            [NameInMap("HostAccountName")]
            [Validation(Required=false)]
            public string HostAccountName { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// The ID of the host for which you want to query the host accounts that the user is authorized to manage.
            /// 
            /// >  You can call the [ListHosts](~~200665~~) operation to query the ID of the host.
            /// </summary>
            [NameInMap("IsAuthorized")]
            [Validation(Required=false)]
            public bool? IsAuthorized { get; set; }

            /// <summary>
            /// Indicates whether the user is authorized to manage the host account. Valid values:
            /// 
            /// *   **true**: The user is authorized to manage the host account.
            /// *   **false**: The user is not authorized to manage the host account.
            /// </summary>
            [NameInMap("ProtocolName")]
            [Validation(Required=false)]
            public string ProtocolName { get; set; }

        }

        /// <summary>
        /// The ID of the Bastionhost instance where you want to query the host accounts that the user is authorized to manage on the host.
        /// 
        /// >  You can call the [DescribeInstances](~~153281~~) operation to query the ID of the Bastionhost instance.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// The value of the PageSize parameter must not exceed 100. Default value: 20. If you leave the PageSize parameter empty, 20 entries are returned on each page.
        /// 
        /// >  We recommend that you do not leave the PageSize parameter empty.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
