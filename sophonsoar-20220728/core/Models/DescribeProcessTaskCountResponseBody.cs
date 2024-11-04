// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeProcessTaskCountResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeProcessTaskCountResponseBodyData> Data { get; set; }
        public class DescribeProcessTaskCountResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>67</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a680c9ae-<b><b>-4c39-</b></b>-0302****fc8e</para>
            /// </summary>
            [NameInMap("EntityUuid")]
            [Validation(Required=false)]
            public string EntityUuid { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>e866cce0-****-41de-817e-****8d5e2650</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
