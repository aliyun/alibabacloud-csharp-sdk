// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of parameter names of the returned parameters. The value is a string of the List type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78C1AA2D-9201-599E-A0BA-6FC462E57A95</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDataServiceResponseBodyResult Result { get; set; }
        public class QueryDataServiceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The SQL of the request query.</para>
            /// </summary>
            [NameInMap("Headers")]
            [Validation(Required=false)]
            public List<QueryDataServiceResponseBodyResultHeaders> Headers { get; set; }
            public class QueryDataServiceResponseBodyResultHeaders : TeaModel {
                /// <summary>
                /// <para>The field name, which corresponds to the physical table field name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUM</para>
                /// </summary>
                [NameInMap("Aggregator")]
                [Validation(Required=false)]
                public string Aggregator { get; set; }

                /// <summary>
                /// <para>The granularity of the dimension field. This field is returned only when the requested field is a date dimension or a geographical dimension. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Date granularity: yearRegion (year), monthRegion (month), weekRegion (week), dayRegion (day), hourRegion (hour), minRegion (minute), secRegion (second)</description></item>
                /// <item><description>Geographic information granularity: COUNTRY (international level), PROVINCE (provincial level), CITY (municipal level), XIAN (district /county), and REGION (regional level)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>The alias of the field. The key of the map data row in the result parameter values.</para>
                /// </summary>
                [NameInMap("Column")]
                [Validation(Required=false)]
                public string Column { get; set; }

                /// <summary>
                /// <para>The column header.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>The field type, which is used to distinguish whether the field type is a dimension or a measure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yearRegion</para>
                /// </summary>
                [NameInMap("Granularity")]
                [Validation(Required=false)]
                public string Granularity { get; set; }

                /// <summary>
                /// <para>The data type of the field. generally have number, string, date, datetime, time, and geographic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>area</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>SELECT COMPANY_T_1_.\&quot;area\&quot; AS D_AREA_2_, COMPANY_T_1_.\&quot;city\&quot; AS D_CITY_3_, SUM(COMPANY_T_1_.\&quot;profit_amt\&quot;) AS D_PROFIT_4_ FROM \&quot;quickbi_test\&quot;.\&quot;company_sales_record_copy\&quot; AS COMPANY_T_1_ WHERE COMPANY_T_1_.\&quot;area\&quot; LIKE \&quot;% China East %\&quot; GROUP BY COMPANY_T_1_.\&quot;area\&quot;, COMPANY_T_1_.\&quot;city\&quot; HAVING SUM(COMPANY_T_1_.\&quot;order_amt\&quot;) &gt; 1 LIMIT 0,10</para>
                /// 
                /// <b>Example:</b>
                /// <para>StandardDimension</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The ID of the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The query result of the API operation is returned.</para>
            /// </summary>
            [NameInMap("Sql")]
            [Validation(Required=false)]
            public string Sql { get; set; }

            /// <summary>
            /// <para>Physical Field Name</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Values { get; set; }

        }

        /// <summary>
        /// <para>{ &quot;area&quot;: [&quot;East China&quot;, &quot;North China&quot;], &quot;shopping_date&quot;: &quot;2019Q1&quot;, }</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
