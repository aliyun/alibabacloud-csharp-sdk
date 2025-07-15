// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeUpBpsPeakOfLineResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about peak inbound bandwidth of the leased line on each day.</para>
        /// </summary>
        [NameInMap("DescribeUpBpsPeakOfLines")]
        [Validation(Required=false)]
        public DescribeUpBpsPeakOfLineResponseBodyDescribeUpBpsPeakOfLines DescribeUpBpsPeakOfLines { get; set; }
        public class DescribeUpBpsPeakOfLineResponseBodyDescribeUpBpsPeakOfLines : TeaModel {
            [NameInMap("DescribeUpBpsPeakOfLine")]
            [Validation(Required=false)]
            public List<DescribeUpBpsPeakOfLineResponseBodyDescribeUpBpsPeakOfLinesDescribeUpBpsPeakOfLine> DescribeUpBpsPeakOfLine { get; set; }
            public class DescribeUpBpsPeakOfLineResponseBodyDescribeUpBpsPeakOfLinesDescribeUpBpsPeakOfLine : TeaModel {
                /// <summary>
                /// <para>The daily peak inbound bandwidth of the leased line.</para>
                /// 
                /// <b>Example:</b>
                /// <para>777.2727083333333</para>
                /// </summary>
                [NameInMap("BandWidth")]
                [Validation(Required=false)]
                public float? BandWidth { get; set; }

                /// <summary>
                /// <para>The time when the daily peak bandwidth of the leased line is reached.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1522180000000</para>
                /// </summary>
                [NameInMap("PeakTime")]
                [Validation(Required=false)]
                public string PeakTime { get; set; }

                /// <summary>
                /// <para>The time queried on the day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1522080000000</para>
                /// </summary>
                [NameInMap("QueryTime")]
                [Validation(Required=false)]
                public string QueryTime { get; set; }

                /// <summary>
                /// <para>The category of the statistical data. If the DomainSwitch parameter is set to on, the value of this parameter is the domain name. If the DomainSwitch parameter is set to off or not specified, the value of this parameter is the user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>push-live.aliyuncs.com</para>
                /// </summary>
                [NameInMap("StatName")]
                [Validation(Required=false)]
                public string StatName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6CFDE7AB-571A-14EA-B072-989FF753****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
