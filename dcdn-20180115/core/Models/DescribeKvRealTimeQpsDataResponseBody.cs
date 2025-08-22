// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeKvRealTimeQpsDataResponseBody : TeaModel {
        [NameInMap("AggregateData")]
        [Validation(Required=false)]
        public List<DescribeKvRealTimeQpsDataResponseBodyAggregateData> AggregateData { get; set; }
        public class DescribeKvRealTimeQpsDataResponseBodyAggregateData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Acc")]
            [Validation(Required=false)]
            public long? Acc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>get</para>
            /// </summary>
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("KeyAcc")]
            [Validation(Required=false)]
            public long? KeyAcc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1233</para>
            /// </summary>
            [NameInMap("KeySuccAcc")]
            [Validation(Required=false)]
            public long? KeySuccAcc { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-01-18T15:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("KvQpsData")]
        [Validation(Required=false)]
        public List<DescribeKvRealTimeQpsDataResponseBodyKvQpsData> KvQpsData { get; set; }
        public class DescribeKvRealTimeQpsDataResponseBodyKvQpsData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>get</para>
            /// </summary>
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("KeyQps")]
            [Validation(Required=false)]
            public long? KeyQps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1233</para>
            /// </summary>
            [NameInMap("KeySuccQps")]
            [Validation(Required=false)]
            public long? KeySuccQps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>534167033424646***</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5236</para>
            /// </summary>
            [NameInMap("Qps")]
            [Validation(Required=false)]
            public long? Qps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-01-10T16:00:00Z</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3C6CCEC4-6B88-4D4A-93E4-D47B3D92C***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-01-10T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
