// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApisecStatisticsResponseBodyData Data { get; set; }
        public class DescribeApisecStatisticsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of handled events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Actioned")]
            [Validation(Required=false)]
            public long? Actioned { get; set; }

            /// <summary>
            /// <para>The number of APIs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/api/v1/login</para>
            /// </summary>
            [NameInMap("Api")]
            [Validation(Required=false)]
            public long? Api { get; set; }

            /// <summary>
            /// <para>The number of confirmed events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Confirmed")]
            [Validation(Required=false)]
            public long? Confirmed { get; set; }

            /// <summary>
            /// <para>The number of domain names.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a.aliyun.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public long? Domain { get; set; }

            /// <summary>
            /// <para>The number of fixed risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Fixed")]
            [Validation(Required=false)]
            public long? Fixed { get; set; }

            /// <summary>
            /// <para>The number of high-risk events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("High")]
            [Validation(Required=false)]
            public long? High { get; set; }

            /// <summary>
            /// <para>The number of ignored risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Ignore")]
            [Validation(Required=false)]
            public long? Ignore { get; set; }

            /// <summary>
            /// <para>The number of low-risk events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Low")]
            [Validation(Required=false)]
            public long? Low { get; set; }

            /// <summary>
            /// <para>The number of moderate-risk events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Medium")]
            [Validation(Required=false)]
            public long? Medium { get; set; }

            /// <summary>
            /// <para>The number of events to be confirmed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ToBeConfirmed")]
            [Validation(Required=false)]
            public long? ToBeConfirmed { get; set; }

            /// <summary>
            /// <para>The number of risks to be fixed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ToBeFixed")]
            [Validation(Required=false)]
            public long? ToBeFixed { get; set; }

            /// <summary>
            /// <para>The number of new high-risk events today.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TodayHigh")]
            [Validation(Required=false)]
            public string TodayHigh { get; set; }

            /// <summary>
            /// <para>The number of new low-risk events today.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TodayLow")]
            [Validation(Required=false)]
            public long? TodayLow { get; set; }

            /// <summary>
            /// <para>The number of new moderate-risk events today.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TodayMedium")]
            [Validation(Required=false)]
            public string TodayMedium { get; set; }

            /// <summary>
            /// <para>The total number of new events today.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TodayTotal")]
            [Validation(Required=false)]
            public string TodayTotal { get; set; }

            /// <summary>
            /// <para>The total number of events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>221F0F14-54C6-59A1-9967-72***81B61A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
