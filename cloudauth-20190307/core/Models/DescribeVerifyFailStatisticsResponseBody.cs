// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyFailStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C2C596D1-B14B-5D79-9672-61D7686912B2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Authentication result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DescribeVerifyFailStatisticsResponseBodyResultObject ResultObject { get; set; }
        public class DescribeVerifyFailStatisticsResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Line chart of failure reasons.</para>
            /// </summary>
            [NameInMap("Column")]
            [Validation(Required=false)]
            public DescribeVerifyFailStatisticsResponseBodyResultObjectColumn Column { get; set; }
            public class DescribeVerifyFailStatisticsResponseBodyResultObjectColumn : TeaModel {
                /// <summary>
                /// <para>Column information.</para>
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<DescribeVerifyFailStatisticsResponseBodyResultObjectColumnItems> Items { get; set; }
                public class DescribeVerifyFailStatisticsResponseBodyResultObjectColumnItems : TeaModel {
                    /// <summary>
                    /// <para>Error code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>404</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>Failure count.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <para>Date: Date</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-10-16</para>
                    /// </summary>
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public string Rate { get; set; }

                }

                /// <summary>
                /// <para>Total count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>Bar chart of failure reasons.</para>
            /// </summary>
            [NameInMap("Line")]
            [Validation(Required=false)]
            public DescribeVerifyFailStatisticsResponseBodyResultObjectLine Line { get; set; }
            public class DescribeVerifyFailStatisticsResponseBodyResultObjectLine : TeaModel {
                /// <summary>
                /// <para>Column information.</para>
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<DescribeVerifyFailStatisticsResponseBodyResultObjectLineItems> Items { get; set; }
                public class DescribeVerifyFailStatisticsResponseBodyResultObjectLineItems : TeaModel {
                    /// <summary>
                    /// <para>Error code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>404</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>Returned quantity data.</para>
                    /// </summary>
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public List<DescribeVerifyFailStatisticsResponseBodyResultObjectLineItemsData> Data { get; set; }
                    public class DescribeVerifyFailStatisticsResponseBodyResultObjectLineItemsData : TeaModel {
                        /// <summary>
                        /// <para>Error code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>404</para>
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// <para>Count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>9</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public long? Count { get; set; }

                        /// <summary>
                        /// <para>Date.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2025-10-16</para>
                        /// </summary>
                        [NameInMap("Date")]
                        [Validation(Required=false)]
                        public string Date { get; set; }

                    }

                }

                /// <summary>
                /// <para>Total count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

        }

    }

}
