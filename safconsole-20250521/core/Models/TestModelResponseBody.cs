// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safconsole20250521.Models
{
    public class TestModelResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4A91D2D1-AEC9-1658-ABCE-5A39DE66A5C2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public TestModelResponseBodyResultObject ResultObject { get; set; }
        public class TestModelResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>49.0</para>
            /// </summary>
            [NameInMap("ConsistencyCount")]
            [Validation(Required=false)]
            public long? ConsistencyCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>98.0</para>
            /// </summary>
            [NameInMap("ConsistencyRate")]
            [Validation(Required=false)]
            public double? ConsistencyRate { get; set; }

            [NameInMap("TestResult")]
            [Validation(Required=false)]
            public List<TestModelResponseBodyResultObjectTestResult> TestResult { get; set; }
            public class TestModelResponseBodyResultObjectTestResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0.00</para>
                /// </summary>
                [NameInMap("ActualResult")]
                [Validation(Required=false)]
                public string ActualResult { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Consistency")]
                [Validation(Required=false)]
                public bool? Consistency { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.00</para>
                /// </summary>
                [NameInMap("TestResult")]
                [Validation(Required=false)]
                public string TestResult { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.00</para>
                /// </summary>
                [NameInMap("TrainResult")]
                [Validation(Required=false)]
                public string TrainResult { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
