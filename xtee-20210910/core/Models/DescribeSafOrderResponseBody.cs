// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSafOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeSafOrderResponseBodyResultObject ResultObject { get; set; }
        public class DescribeSafOrderResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The expiration date (UNIX timestamp).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1755076800000</para>
            /// </summary>
            [NameInMap("expirationDate")]
            [Validation(Required=false)]
            public long? ExpirationDate { get; set; }

        }

    }

}
