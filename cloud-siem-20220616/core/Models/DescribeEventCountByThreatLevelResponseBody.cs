// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeEventCountByThreatLevelResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEventCountByThreatLevelResponseBodyData Data { get; set; }
        public class DescribeEventCountByThreatLevelResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The daily event statistics.</para>
            /// </summary>
            [NameInMap("EventDailyNum")]
            [Validation(Required=false)]
            public List<DescribeEventCountByThreatLevelResponseBodyDataEventDailyNum> EventDailyNum { get; set; }
            public class DescribeEventCountByThreatLevelResponseBodyDataEventDailyNum : TeaModel {
                /// <summary>
                /// <para>The date in the YYYY-MM-DD format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-10-06</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <para>The total number of security events.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("EventNum")]
                [Validation(Required=false)]
                public long? EventNum { get; set; }

                /// <summary>
                /// <para>The number of unhandled security events.</para>
                /// 
                /// <b>Example:</b>
                /// <para>34</para>
                /// </summary>
                [NameInMap("UndealEventNum")]
                [Validation(Required=false)]
                public long? UndealEventNum { get; set; }

            }

            /// <summary>
            /// <para>The total number of events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("EventNum")]
            [Validation(Required=false)]
            public long? EventNum { get; set; }

            /// <summary>
            /// <para>The number of high-risk events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("HighLevelEventNum")]
            [Validation(Required=false)]
            public long? HighLevelEventNum { get; set; }

            /// <summary>
            /// <para>The number of informational-level events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InfoLevelEventNum")]
            [Validation(Required=false)]
            public long? InfoLevelEventNum { get; set; }

            /// <summary>
            /// <para>The number of low-risk events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>52</para>
            /// </summary>
            [NameInMap("LowLevelEventNum")]
            [Validation(Required=false)]
            public long? LowLevelEventNum { get; set; }

            /// <summary>
            /// <para>The number of medium-risk events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MediumLevelEventNum")]
            [Validation(Required=false)]
            public long? MediumLevelEventNum { get; set; }

            /// <summary>
            /// <para>The number of critical-level events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SeriousLevelEventNum")]
            [Validation(Required=false)]
            public long? SeriousLevelEventNum { get; set; }

            /// <summary>
            /// <para>The number of unhandled events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>75</para>
            /// </summary>
            [NameInMap("UndealEventNum")]
            [Validation(Required=false)]
            public long? UndealEventNum { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: successful.</description></item>
        /// <item><description>false: failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
