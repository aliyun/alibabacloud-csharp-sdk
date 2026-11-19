// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a4d1a221d-41za1-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The execution result of the API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The execution is successful.</description></item>
        /// <item><description>false: The execution fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
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
                /// <para>The aggregation operator. This field is available only for measure fields, such as SUM, AVG, and MAX. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SUM: Sum.</description></item>
                /// <item><description>MAX: Maximum value.</description></item>
                /// <item><description>MIN: Minimum value.</description></item>
                /// <item><description>AVG: Average value.</description></item>
                /// <item><description>COUNT: Count.</description></item>
                /// <item><description>COUNTD: Deduplicate count.</description></item>
                /// <item><description>STDDEV_POP: Population standard deviation.</description></item>
                /// <item><description>STDDEV_SAMP: Sample standard deviation.</description></item>
                /// <item><description>VAR_POP: Population variance.</description></item>
                /// <item><description>VAR_SAMP: Sample variance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SUM</para>
                /// </summary>
                [NameInMap("Aggregator")]
                [Validation(Required=false)]
                public string Aggregator { get; set; }

                /// <summary>
                /// <para>The name of the field, which corresponds to the field name in the physical table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Column")]
                [Validation(Required=false)]
                public string Column { get; set; }

                /// <summary>
                /// <para>The data type of the field. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>number: Numeric.</description></item>
                /// <item><description>string: String.</description></item>
                /// <item><description>date: Date.</description></item>
                /// <item><description>time: Time.</description></item>
                /// <item><description>datetime: Date and time.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>The granularity of the dimension field. This field is returned only when the requested field is a date dimension or a geographic dimension. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Date granularity: yearRegion (year), monthRegion (month), weekRegion (week), dayRegion (day), hourRegion (hour), minRegion (minute), and secRegion (second).</para>
                /// </description></item>
                /// <item><description><para>Geographic granularity: COUNTRY (country), PROVINCE (province), CITY (city), XIAN (district/county), and REGION (region).</para>
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
                /// <para>The alias of the field, which is the key of the map data row in the values result parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>area</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The original name of the corresponding field in the dataset.</para>
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
                /// <para>The type of the field, which is used to distinguish whether the field is a dimension or a measure. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Dimension: Dimension.</description></item>
                /// <item><description>Measure: Measure.</description></item>
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
            /// <para>The SQL statement of the query.</para>
            /// <remarks>
            /// <para>In addition to the parameter conditions of the current API, the filter conditions in the returned SQL statement also include the row-level and column-level permission configurations.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT COMPANY_T_1_.<c>area</c> AS D_AREA_2_, COMPANY_T_1_.<c>city</c> AS D_CITY_3_, SUM(COMPANY_T_1_.<c>profit_amt</c>) AS D_PROFIT_4_ FROM <c>quickbi_test</c>.<c>company_sales_record_copy</c> AS COMPANY_T_1_ WHERE COMPANY_T_1_.<c>area</c> LIKE \&quot;%test%\&quot; GROUP BY COMPANY_T_1_.<c>area</c>, COMPANY_T_1_.<c>city</c> HAVING SUM(COMPANY_T_1_.<c>order_amt</c>) &gt; 1 LIMIT 0, 10</para>
            /// </summary>
            [NameInMap("Sql")]
            [Validation(Required=false)]
            public string Sql { get; set; }

            /// <summary>
            /// <para>The returned query results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;area&quot;:&quot;test&quot;,&quot;city&quot;:&quot;test&quot;},{&quot;area&quot;:&quot;test&quot;,&quot;city&quot;:&quot;test&quot;}]</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Values { get; set; }

            /// <summary>
            /// <para>The returned query results, including the original value fields.</para>
            /// </summary>
            [NameInMap("ValuesV2")]
            [Validation(Required=false)]
            public List<QueryDataResponseBodyResultValuesV2> ValuesV2 { get; set; }
            public class QueryDataResponseBodyResultValuesV2 : TeaModel {
                /// <summary>
                /// <para>The row values.</para>
                /// </summary>
                [NameInMap("RowValue")]
                [Validation(Required=false)]
                public List<QueryDataResponseBodyResultValuesV2RowValue> RowValue { get; set; }
                public class QueryDataResponseBodyResultValuesV2RowValue : TeaModel {
                    /// <summary>
                    /// <para>The field alias set in Data Service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("L")]
                    [Validation(Required=false)]
                    public string L { get; set; }

                    /// <summary>
                    /// <para>The original value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("R")]
                    [Validation(Required=false)]
                    public string R { get; set; }

                    /// <summary>
                    /// <para>The display value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("V")]
                    [Validation(Required=false)]
                    public string V { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
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
