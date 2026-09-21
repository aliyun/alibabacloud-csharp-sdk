// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class InvokeContainerHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        [NameInMap("accountContext")]
        [Validation(Required=false)]
        public InvokeContainerHeadersAccountContext AccountContext { get; set; }
        public class InvokeContainerHeadersAccountContext : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>012345</para>
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("alidingSsoTicket")]
            [Validation(Required=false)]
            public string AlidingSsoTicket { get; set; }

            [NameInMap("ssoTicket")]
            [Validation(Required=false)]
            public string SsoTicket { get; set; }

        }

    }

}
