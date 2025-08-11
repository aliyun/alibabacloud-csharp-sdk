// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a4d1a221d-41za1-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returns the result of the interface execution. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: Execution succeeded</description></item>
        /// <item><description>false: Execution failed</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDataResponseBodyResult Result { get; set; }
        public class QueryDataResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Column headers.</para>
            /// </summary>
            [NameInMap("Headers")]
            [Validation(Required=false)]
            public List<QueryDataResponseBodyResultHeaders> Headers { get; set; }
            public class QueryDataResponseBodyResultHeaders : TeaModel {
                /// <summary>
                /// <para>Aggregation operator. Only present for measure fields, such as SUM, AVG, and MAX.</para>
                /// <list type="bullet">
                /// <item><description>SUM: Sum</description></item>
                /// <item><description>MAX: Maximum value</description></item>
                /// <item><description>MIN: Minimum value</description></item>
                /// <item><description>AVG: Average</description></item>
                /// <item><description>COUNT: Count</description></item>
                /// <item><description>COUNTD: Distinct count</description></item>
                /// <item><description>STDDEV_POP: Population standard deviation</description></item>
                /// <item><description>STDDEV_SAMP: Sample standard deviation</description></item>
                /// <item><description>VAR_POP: Population variance</description></item>
                /// <item><description>VAR_SAMP: Sample variance</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SUM</para>
                /// </summary>
                [NameInMap("Aggregator")]
                [Validation(Required=false)]
                public string Aggregator { get; set; }

                /// <summary>
                /// <para>Field name, corresponding to the physical table field name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Specific physical field name</para>
                /// </summary>
                [NameInMap("Column")]
                [Validation(Required=false)]
                public string Column { get; set; }

                /// <summary>
                /// <para>The keyword of the sensitive field type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>The granularity of the dimension field.
                /// This field is returned only when the requested field is a date or geographic dimension, with the following possible values:</para>
                /// <list type="bullet">
                /// <item><description><para>Date Granularity: yearRegion (year), monthRegion (month), weekRegion (week), dayRegion (day), hourRegion (hour), minRegion (minute), secRegion (second)</para>
                /// </description></item>
                /// <item><description><para>Geographic Granularity: COUNTRY (international level), PROVINCE (provincial level), CITY (city level), XIAN (district/county level), REGION (region)</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>REGION</para>
                /// </summary>
                [NameInMap("Granularity")]
                [Validation(Required=false)]
                public string Granularity { get; set; }

                /// <summary>
                /// <para>Field alias, which serves as the key in the map data rows of the <c>values</c> parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>area</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("OriginalColumn")]
                [Validation(Required=false)]
                public string OriginalColumn { get; set; }

                /// <summary>
                /// <para>Field type, used to distinguish between dimension and measure fields.</para>
                /// <list type="bullet">
                /// <item><description>Dimension: dimension</description></item>
                /// <item><description>Measure: measure</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Dimension</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The SQL query that was executed.</para>
            /// <remarks>
            /// <para>The filter conditions in the returned SQL statement include not only the parameters passed through this interface but also the row and column permission configurations.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Sql")]
            [Validation(Required=false)]
            public string Sql { get; set; }

            /// <summary>
            /// <para>The results of the query.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Values { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: Request succeeded</description></item>
        /// <item><description>false: Request failed</description></item>
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
