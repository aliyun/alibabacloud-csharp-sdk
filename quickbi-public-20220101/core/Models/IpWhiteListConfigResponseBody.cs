// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class IpWhiteListConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The IP address whitelist.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public IpWhiteListConfigResponseBodyResult Result { get; set; }
        public class IpWhiteListConfigResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The IP address whitelist array.</para>
            /// </summary>
            [NameInMap("IpWhiteList")]
            [Validation(Required=false)]
            public List<string> IpWhiteList { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
