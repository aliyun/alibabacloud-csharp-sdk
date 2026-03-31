// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeUserTrafficResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>EC10C9EA-A367-52D5-<em><b>-</b></em></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserTraffic")]
        [Validation(Required=false)]
        public List<DescribeUserTrafficResponseBodyUserTraffic> UserTraffic { get; set; }
        public class DescribeUserTrafficResponseBodyUserTraffic : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Pv")]
            [Validation(Required=false)]
            public long? Pv { get; set; }

        }

    }

}
