// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetSkillDetailHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        [NameInMap("AccountContext")]
        [Validation(Required=false)]
        public GetSkillDetailHeadersAccountContext AccountContext { get; set; }
        public class GetSkillDetailHeadersAccountContext : TeaModel {
            /// <summary>
            /// <para>Buc SsoTicket</para>
            /// 
            /// <b>Example:</b>
            /// <para>bucxxx</para>
            /// </summary>
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
