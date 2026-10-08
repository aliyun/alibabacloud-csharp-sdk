// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListUserAuthorizedResourcesHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        [NameInMap("AccountContext")]
        [Validation(Required=false)]
        public ListUserAuthorizedResourcesHeadersAccountContext AccountContext { get; set; }
        public class ListUserAuthorizedResourcesHeadersAccountContext : TeaModel {
            [NameInMap("AlidingSsoTicket")]
            [Validation(Required=false)]
            public string AlidingSsoTicket { get; set; }

            [NameInMap("SsoTicket")]
            [Validation(Required=false)]
            public string SsoTicket { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>012345</para>
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

        }

    }

}
