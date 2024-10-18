// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateSearchDomeHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        [NameInMap("AccountContext")]
        [Validation(Required=false)]
        public CreateSearchDomeHeadersAccountContext AccountContext { get; set; }
        public class CreateSearchDomeHeadersAccountContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ba3a9b612345678d8fedf544ef69d19e</para>
            /// </summary>
            [NameInMap("userToken")]
            [Validation(Required=false)]
            public string UserToken { get; set; }

        }

    }

}
