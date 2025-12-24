// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeProcessStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public DescribeProcessStatisticsResponseBodyMetrics Metrics { get; set; }
        public class DescribeProcessStatisticsResponseBodyMetrics : TeaModel {
            /// <summary>
            /// <para>The number of blocked files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BanFileNum")]
            [Validation(Required=false)]
            public int? BanFileNum { get; set; }

            /// <summary>
            /// <para>The number of blocked IP addresses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BanIpNum")]
            [Validation(Required=false)]
            public int? BanIpNum { get; set; }

            /// <summary>
            /// <para>The number of blocked processes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BanProcessNum")]
            [Validation(Required=false)]
            public int? BanProcessNum { get; set; }

            /// <summary>
            /// <para>The number of handling tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskNum")]
            [Validation(Required=false)]
            public int? TaskNum { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4CFC0F8A-D600-5FFF-A0DF-3121C4C1B90F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
