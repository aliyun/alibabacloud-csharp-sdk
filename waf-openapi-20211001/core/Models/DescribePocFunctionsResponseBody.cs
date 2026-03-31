// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribePocFunctionsResponseBody : TeaModel {
        [NameInMap("Functions")]
        [Validation(Required=false)]
        public List<DescribePocFunctionsResponseBodyFunctions> Functions { get; set; }
        public class DescribePocFunctionsResponseBodyFunctions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1760581677000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>botWeb</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1557B42F-B889-460A-B17F-1DE5C5AD7FF2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
