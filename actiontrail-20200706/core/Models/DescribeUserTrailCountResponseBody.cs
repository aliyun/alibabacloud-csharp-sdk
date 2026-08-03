// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class DescribeUserTrailCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeUserTrailCountResponseBodyData Data { get; set; }
        public class DescribeUserTrailCountResponseBodyData : TeaModel {
            /// <summary>
            /// <para>An array of trail counts, where each count corresponds to a date in the <c>Dates</c> array.</para>
            /// </summary>
            [NameInMap("Counts")]
            [Validation(Required=false)]
            public List<long?> Counts { get; set; }

            /// <summary>
            /// <para>A list of dates.</para>
            /// </summary>
            [NameInMap("Dates")]
            [Validation(Required=false)]
            public List<string> Dates { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EDDEBA6B-FFE2-4EF6-8BAB-2A6B98DC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
