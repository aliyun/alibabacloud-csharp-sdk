// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78C1AA2D-9201-599E-A0BA-6FC462E57A95</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returns the result of the interface query.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDataServiceResponseBodyResult Result { get; set; }
        public class QueryDataServiceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Column headers.</para>
            /// </summary>
            [NameInMap("Headers")]
            [Validation(Required=false)]
            public List<QueryDataServiceResponseBodyResultHeaders> Headers { get; set; }
            public class QueryDataServiceResponseBodyResultHeaders : TeaModel {
                /// <summary>
                /// <para>Aggregation operator. Only present for measure fields, such as SUM, AVG, and MAX.</para>
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
                /// <para>The alias of the field. The key of the map data row in the result parameter values.</para>
                /// </summary>
                [NameInMap("Column")]
                [Validation(Required=false)]
                public string Column { get; set; }

                /// <summary>
                /// <para>The data type of the field. Common types include number, string, date, datetime, time, and geographic.</para>
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
                /// <item><description><para>Date granularity: yearRegion (year), monthRegion (month), weekRegion (week), dayRegion (day), hourRegion (hour), minRegion (minute), secRegion (second)</para>
                /// </description></item>
                /// <item><description><para>Geographic granularity: COUNTRY (country level), PROVINCE (province level), CITY (city level), XIAN (district/county level), REGION (region)</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>yearRegion</para>
                /// </summary>
                [NameInMap("Granularity")]
                [Validation(Required=false)]
                public string Granularity { get; set; }

                /// <summary>
                /// <para>字段别名，结果参数values中map数据行的key。</para>
                /// 
                /// <b>Example:</b>
                /// <para>area</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>Field type, used to distinguish between dimension and measure fields.</para>
                /// 
                /// <b>Example:</b>
                /// <para>StandardDimension</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The SQL of the query request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT COMPANY_T_1_.<c>area</c> AS D_AREA_2_, COMPANY_T_1_.<c>city</c> AS D_CITY_3_, SUM(COMPANY_T_1_.<c>profit_amt</c>) AS D_PROFIT_4_ FROM <c>quickbi_test</c>.<c>company_sales_record_copy</c> AS COMPANY_T_1_ WHERE COMPANY_T_1_.<c>area</c> LIKE \&quot;%华东%\&quot; GROUP BY COMPANY_T_1_.<c>area</c>, COMPANY_T_1_.<c>city</c> HAVING SUM(COMPANY_T_1_.<c>order_amt</c>) &gt; 1 LIMIT 0, 10</para>
            /// </summary>
            [NameInMap("Sql")]
            [Validation(Required=false)]
            public string Sql { get; set; }

            /// <summary>
            /// <para>The queried results returned.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Values { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The request was successful</para>
        /// </description></item>
        /// <item><description><para>false: The request failed</para>
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
