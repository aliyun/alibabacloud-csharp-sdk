// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketHmacConfig : TeaModel {
        /// <summary>
        /// <para>The authentication credentials.</para>
        /// </summary>
        [NameInMap("credentials")]
        [Validation(Required=false)]
        public List<HiMarketHmacConfigCredentials> Credentials { get; set; }
        public class HiMarketHmacConfigCredentials : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID.</para>
            /// </summary>
            [NameInMap("ak")]
            [Validation(Required=false)]
            public string Ak { get; set; }

            /// <summary>
            /// <para>The HMAC mode.</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The AccessKey Secret.</para>
            /// </summary>
            [NameInMap("sk")]
            [Validation(Required=false)]
            public string Sk { get; set; }

        }

    }

}
