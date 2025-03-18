// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeProcessStatisticsResponseBody : TeaModel {
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public DescribeProcessStatisticsResponseBodyMetrics Metrics { get; set; }
        public class DescribeProcessStatisticsResponseBodyMetrics : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BanFileNum")]
            [Validation(Required=false)]
            public int? BanFileNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BanIpNum")]
            [Validation(Required=false)]
            public int? BanIpNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BanProcessNum")]
            [Validation(Required=false)]
            public int? BanProcessNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskNum")]
            [Validation(Required=false)]
            public int? TaskNum { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4CFC0F8A-D600-5FFF-A0DF-3121C4C1B90F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
