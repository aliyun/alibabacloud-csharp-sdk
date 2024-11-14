// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeVisitUasResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2847CE98-AFAE-5A64-B80E-60461717F9DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The array of the top 10 user agents that are used to initiate requests.</para>
        /// </summary>
        [NameInMap("Uas")]
        [Validation(Required=false)]
        public List<DescribeVisitUasResponseBodyUas> Uas { get; set; }
        public class DescribeVisitUasResponseBodyUas : TeaModel {
            /// <summary>
            /// <para>The number of requests that use the user agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>698455</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The user agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chrome</para>
            /// </summary>
            [NameInMap("Ua")]
            [Validation(Required=false)]
            public string Ua { get; set; }

        }

    }

}
