// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketHmacConfig : TeaModel {
        /// <summary>
        /// <para>The list of credentials.</para>
        /// </summary>
        [NameInMap("credentials")]
        [Validation(Required=false)]
        public List<HiMarketHmacConfigCredentials> Credentials { get; set; }
        public class HiMarketHmacConfigCredentials : TeaModel {
            /// <summary>
            /// <para>Access Key ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-access-key-123</para>
            /// </summary>
            [NameInMap("ak")]
            [Validation(Required=false)]
            public string Ak { get; set; }

            /// <summary>
            /// <para>The generation mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>Access Key Secret</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-secret-key-456</para>
            /// </summary>
            [NameInMap("sk")]
            [Validation(Required=false)]
            public string Sk { get; set; }

        }

    }

}
