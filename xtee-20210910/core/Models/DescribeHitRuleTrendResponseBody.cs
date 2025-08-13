// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeHitRuleTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error details</para>
        /// 
        /// <b>Example:</b>
        /// <para>The input parameter data is not valid. order_storage_company_num component not found</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE7E6105-7DEB-5125-9B24-DCBC139F6CD2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Response object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeHitRuleTrendResponseBodyResultObject ResultObject { get; set; }
        public class DescribeHitRuleTrendResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Chart data</para>
            /// </summary>
            [NameInMap("series")]
            [Validation(Required=false)]
            public List<DescribeHitRuleTrendResponseBodyResultObjectSeries> Series { get; set; }
            public class DescribeHitRuleTrendResponseBodyResultObjectSeries : TeaModel {
                /// <summary>
                /// <para>Returned data object</para>
                /// </summary>
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<DescribeHitRuleTrendResponseBodyResultObjectSeriesData> Data { get; set; }
                public class DescribeHitRuleTrendResponseBodyResultObjectSeriesData : TeaModel {
                    /// <summary>
                    /// <para>Number</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("num")]
                    [Validation(Required=false)]
                    public long? Num { get; set; }

                    /// <summary>
                    /// <para>Scale</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.00%</para>
                    /// </summary>
                    [NameInMap("scale")]
                    [Validation(Required=false)]
                    public string Scale { get; set; }

                }

                /// <summary>
                /// <para>Display title</para>
                /// 
                /// <b>Example:</b>
                /// <para>策略name</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>X-axis data</para>
            /// </summary>
            [NameInMap("xaxis")]
            [Validation(Required=false)]
            public DescribeHitRuleTrendResponseBodyResultObjectXaxis Xaxis { get; set; }
            public class DescribeHitRuleTrendResponseBodyResultObjectXaxis : TeaModel {
                /// <summary>
                /// <para>Returned data object</para>
                /// </summary>
                [NameInMap("data")]
                [Validation(Required=false)]
                public List<string> Data { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the operation was successful, where true means success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
