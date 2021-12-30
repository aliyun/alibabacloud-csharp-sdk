// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostAccountsForHostShareKeyResponseBody : TeaModel {
        [NameInMap("HostAccounts")]
        [Validation(Required=false)]
        public List<ListHostAccountsForHostShareKeyResponseBodyHostAccounts> HostAccounts { get; set; }
        public class ListHostAccountsForHostShareKeyResponseBodyHostAccounts : TeaModel {
            [NameInMap("HostAccountName")]
            [Validation(Required=false)]
            public string HostAccountName { get; set; }

            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            [NameInMap("HostsAccountId")]
            [Validation(Required=false)]
            public string HostsAccountId { get; set; }

            [NameInMap("ProtocolName")]
            [Validation(Required=false)]
            public string ProtocolName { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
