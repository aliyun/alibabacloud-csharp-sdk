// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class ListVccFlowInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>访问被拒绝的详细原因。</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListVccFlowInfosResponseBodyContent Content { get; set; }
        public class ListVccFlowInfosResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>Lingjun Connection Traffic Information</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListVccFlowInfosResponseBodyContentData> Data { get; set; }
            public class ListVccFlowInfosResponseBodyContentData : TeaModel {
                /// <summary>
                /// <para>The direction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OUT</para>
                /// </summary>
                [NameInMap("Direction")]
                [Validation(Required=false)]
                public string Direction { get; set; }

                /// <summary>
                /// <para>The metric. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>passBytesRate</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-wulanchabu</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Time</para>
                /// 
                /// <b>Example:</b>
                /// <para>1689749749000</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>Value</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public double? Value { get; set; }

                /// <summary>
                /// <para>Lingjun Connection ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>vcc-cn-zvp2w******</para>
                /// </summary>
                [NameInMap("VccId")]
                [Validation(Required=false)]
                public string VccId { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>Response</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID of the current request</para>
        /// 
        /// <b>Example:</b>
        /// <para>BDBCC783-84CA-5733-8EEA-************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
