// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a4d1a221d-41za1-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the API call. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The call was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The call failed.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDataResponseBodyResult Result { get; set; }
        public class QueryDataResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The column headers.</para>
            /// </summary>
            [NameInMap("Headers")]
            [Validation(Required=false)]
            public List<QueryDataResponseBodyResultHeaders> Headers { get; set; }
            public class QueryDataResponseBodyResultHeaders : TeaModel {
                /// <summary>
                /// <para>The aggregate operator. Returned only for measure fields.</para>
                /// <list type="bullet">
                /// <item><description><para>SUM: The sum.</para>
                /// </description></item>
                /// <item><description><para>MAX: The maximum value.</para>
                /// </description></item>
                /// <item><description><para>MIN: The minimum value.</para>
                /// </description></item>
                /// <item><description><para>AVG: The average value.</para>
                /// </description></item>
                /// <item><description><para>COUNT: The count.</para>
                /// </description></item>
                /// <item><description><para>COUNTD: The count of unique values.</para>
                /// </description></item>
                /// <item><description><para>STDDEV_POP: The population standard deviation.</para>
                /// </description></item>
                /// <item><description><para>STDDEV_SAMP: The sample standard deviation.</para>
                /// </description></item>
                /// <item><description><para>VAR_POP: The population variance.</para>
                /// </description></item>
                /// <item><description><para>VAR_SAMP: The sample variance.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SUM</para>
                /// </summary>
                [NameInMap("Aggregator")]
                [Validation(Required=false)]
                public string Aggregator { get; set; }

                /// <summary>
                /// <para>The physical table field name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Column")]
                [Validation(Required=false)]
                public string Column { get; set; }

                /// <summary>
                /// <para>The field data type. Common types:</para>
                /// <list type="bullet">
                /// <item><description><para>number</para>
                /// </description></item>
                /// <item><description><para>string</para>
                /// </description></item>
                /// <item><description><para>date</para>
                /// </description></item>
                /// <item><description><para>time</para>
                /// </description></item>
                /// <item><description><para>datetime</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>The dimension granularity. Returned only for date or geographic dimensions. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Date granularity: yearRegion (year), monthRegion (month), weekRegion (week), dayRegion (day), hourRegion (hour), minRegion (minute), secRegion (second)</para>
                /// </description></item>
                /// <item><description><para>Geographic granularity: COUNTRY (country), PROVINCE (province), CITY (city), XIAN (county/district), REGION (region)</para>
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
                /// <para>The field alias. Used as the key in each Values map entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>area</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The original field name in the dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>area</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("OriginalColumn")]
                [Validation(Required=false)]
                public string OriginalColumn { get; set; }

                /// <summary>
                /// <para>Whether the field is a dimension or measure.</para>
                /// <list type="bullet">
                /// <item><description><para>Dimension</para>
                /// </description></item>
                /// <item><description><para>Measure</para>
                /// </description></item>
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
            /// <para>The SQL statement for the query.</para>
            /// <remarks>
            /// <para>The returned SQL includes both the filter conditions from this call and any row-level or column-level permission rules.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT COMPANY_T_1_.<c>area</c> AS D_AREA_2_, COMPANY_T_1_.<c>city</c> AS D_CITY_3_, SUM(COMPANY_T_1_.<c>profit_amt</c>) AS D_PROFIT_4_ FROM <c>quickbi_test</c>.<c>company_sales_record_copy</c> AS COMPANY_T_1_ WHERE COMPANY_T_1_.<c>area</c> LIKE \&quot;%test%\&quot; GROUP BY COMPANY_T_1_.<c>area</c>, COMPANY_T_1_.<c>city</c> HAVING SUM(COMPANY_T_1_.<c>order_amt</c>) &gt; 1 LIMIT 0, 10</para>
            /// </summary>
            [NameInMap("Sql")]
            [Validation(Required=false)]
            public string Sql { get; set; }

            /// <summary>
            /// <para>The query results.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Values { get; set; }

        }

        /// <summary>
        /// <para>Whether the request succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The request failed.</para>
        /// </description></item>
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
