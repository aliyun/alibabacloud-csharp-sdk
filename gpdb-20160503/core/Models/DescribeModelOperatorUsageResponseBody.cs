// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeModelOperatorUsageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-06-02T00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("Keys")]
        [Validation(Required=false)]
        public List<DescribeModelOperatorUsageResponseBodyKeys> Keys { get; set; }
        public class DescribeModelOperatorUsageResponseBodyKeys : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>request_count</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<DescribeModelOperatorUsageResponseBodyKeysSeries> Series { get; set; }
            public class DescribeModelOperatorUsageResponseBodyKeysSeries : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ApiKeyId")]
                [Validation(Required=false)]
                public int? ApiKeyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>qwen3.6-plus</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>model</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<DescribeModelOperatorUsageResponseBodyKeysSeriesValues> Values { get; set; }
                public class DescribeModelOperatorUsageResponseBodyKeysSeriesValues : TeaModel {
                    [NameInMap("Point")]
                    [Validation(Required=false)]
                    public List<string> Point { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>requests</para>
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-06-01T00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
