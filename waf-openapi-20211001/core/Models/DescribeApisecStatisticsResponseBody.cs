// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistical results of API security risks or events.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApisecStatisticsResponseBodyData Data { get; set; }
        public class DescribeApisecStatisticsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of accounts associated with the monitored APIs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Account")]
            [Validation(Required=false)]
            public long? Account { get; set; }

            /// <summary>
            /// <para>The number of handled items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Actioned")]
            [Validation(Required=false)]
            public long? Actioned { get; set; }

            /// <summary>
            /// <para>The number of APIs that are monitored by the API security module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202</para>
            /// </summary>
            [NameInMap("Api")]
            [Validation(Required=false)]
            public long? Api { get; set; }

            /// <summary>
            /// <para>The number of confirmed items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Confirmed")]
            [Validation(Required=false)]
            public long? Confirmed { get; set; }

            /// <summary>
            /// <para>The number of domain names that are monitored by the API security module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public long? Domain { get; set; }

            /// <summary>
            /// <para>The number of items that are manually verified as fixed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("Fixed")]
            [Validation(Required=false)]
            public long? Fixed { get; set; }

            /// <summary>
            /// <para>The number of high-risk items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>135</para>
            /// </summary>
            [NameInMap("High")]
            [Validation(Required=false)]
            public long? High { get; set; }

            /// <summary>
            /// <para>The number of ignored items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Ignore")]
            [Validation(Required=false)]
            public long? Ignore { get; set; }

            /// <summary>
            /// <para>The number of low-risk items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>160</para>
            /// </summary>
            [NameInMap("Low")]
            [Validation(Required=false)]
            public long? Low { get; set; }

            /// <summary>
            /// <para>The number of medium-risk items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("Medium")]
            [Validation(Required=false)]
            public long? Medium { get; set; }

            /// <summary>
            /// <para>The number of items that are verified as not fixed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NotFixed")]
            [Validation(Required=false)]
            public long? NotFixed { get; set; }

            /// <summary>
            /// <para>The number of items that are verified as fixed by the system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SystemFixed")]
            [Validation(Required=false)]
            public long? SystemFixed { get; set; }

            /// <summary>
            /// <para>The number of items to be confirmed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>295</para>
            /// </summary>
            [NameInMap("ToBeConfirmed")]
            [Validation(Required=false)]
            public long? ToBeConfirmed { get; set; }

            /// <summary>
            /// <para>The number of items to be fixed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ToBeFixed")]
            [Validation(Required=false)]
            public long? ToBeFixed { get; set; }

            /// <summary>
            /// <para>The number of items to be verified by the system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ToBeVerified")]
            [Validation(Required=false)]
            public long? ToBeVerified { get; set; }

            /// <summary>
            /// <para>The number of new high-risk items detected today.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TodayHigh")]
            [Validation(Required=false)]
            public string TodayHigh { get; set; }

            /// <summary>
            /// <para>The number of new low-risk items detected today.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TodayLow")]
            [Validation(Required=false)]
            public long? TodayLow { get; set; }

            /// <summary>
            /// <para>The number of new medium-risk items detected today.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TodayMedium")]
            [Validation(Required=false)]
            public string TodayMedium { get; set; }

            /// <summary>
            /// <para>The total number of new items detected today.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TodayTotal")]
            [Validation(Required=false)]
            public string TodayTotal { get; set; }

            /// <summary>
            /// <para>The total number of items.</para>
            /// <remarks>
            /// <para>This is the sum of the values of the <b>High</b>, <b>Medium</b>, and <b>Low</b> response parameters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>322</para>
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
