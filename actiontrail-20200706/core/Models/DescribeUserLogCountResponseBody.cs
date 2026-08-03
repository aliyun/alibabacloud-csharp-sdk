// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class DescribeUserLogCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeUserLogCountResponseBodyData Data { get; set; }
        public class DescribeUserLogCountResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The statistics returned.</para>
            /// </summary>
            [NameInMap("Counts")]
            [Validation(Required=false)]
            public List<long?> Counts { get; set; }

            /// <summary>
            /// <para>The dates of logs.</para>
            /// </summary>
            [NameInMap("Dates")]
            [Validation(Required=false)]
            public List<string> Dates { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90D6CC31-947F-5D8A-BEDC-F312EE9B31EA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
