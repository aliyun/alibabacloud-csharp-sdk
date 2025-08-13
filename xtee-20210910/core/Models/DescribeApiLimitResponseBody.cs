// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeApiLimitResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE7E6105-7DEB-5125-9B24-DCBC139F6CD2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeApiLimitResponseBodyResultObject ResultObject { get; set; }
        public class DescribeApiLimitResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Whether the maximum number has been exceeded</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("limit")]
            [Validation(Required=false)]
            public bool? Limit { get; set; }

            /// <summary>
            /// <para>Maximum number of items that can be created</para>
            /// 
            /// <b>Example:</b>
            /// <para>150</para>
            /// </summary>
            [NameInMap("maxTotalItem")]
            [Validation(Required=false)]
            public long? MaxTotalItem { get; set; }

            /// <summary>
            /// <para>Total number of items</para>
            /// 
            /// <b>Example:</b>
            /// <para>31</para>
            /// </summary>
            [NameInMap("totalItem")]
            [Validation(Required=false)]
            public long? TotalItem { get; set; }

        }

    }

}
