// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78C1AA2D-9201-599E-A0BA-6FC462E57A95</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The query result returned by the API.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDataServiceResponseBodyResult Result { get; set; }
        public class QueryDataServiceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The column headers.</para>
            /// </summary>
            [NameInMap("Headers")]
            [Validation(Required=false)]
            public List<QueryDataServiceResponseBodyResultHeaders> Headers { get; set; }
            public class QueryDataServiceResponseBodyResultHeaders : TeaModel {
                /// <summary>
                /// <para>The aggregation operator. This parameter is returned only for measure fields, such as SUM, AVG, and MAX.</para>
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
                /// <para>A specific physical field name</para>
                /// </summary>
                [NameInMap("Column")]
                [Validation(Required=false)]
                public string Column { get; set; }

                /// <summary>
                /// <para>The data type of the field. Common values include number, string, date, datetime, time, and geographic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>The granularity of the dimension field. This parameter is returned only when the requested field is a date dimension or geographic dimension field. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Date granularity: yearRegion (year), monthRegion (month), weekRegion (week), dayRegion (day), hourRegion (hour), minRegion (minute), and secRegion (second).</para>
                /// </description></item>
                /// <item><description><para>Geographic information granularity: COUNTRY (country level), PROVINCE (province level), CITY (city level), XIAN (district or county level), and REGION (region level).</para>
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
                /// <para>The alias of the field, which is the key of the map data row in the Values response parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>area</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The type of the field, which is used to distinguish whether the field is a dimension or a measure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>StandardDimension</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The SQL statement of the query request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT COMPANY_T_1_.<c>area</c> AS D_AREA_2_, COMPANY_T_1_.<c>city</c> AS D_CITY_3_, SUM(COMPANY_T_1_.<c>profit_amt</c>) AS D_PROFIT_4_ FROM <c>quickbi_test</c>.<c>company_sales_record_copy</c> AS COMPANY_T_1_ WHERE COMPANY_T_1_.<c>area</c> LIKE \&quot;%East China%\&quot; GROUP BY COMPANY_T_1_.<c>area</c>, COMPANY_T_1_.<c>city</c> HAVING SUM(COMPANY_T_1_.<c>order_amt</c>) &gt; 1 LIMIT 0, 10</para>
            /// </summary>
            [NameInMap("Sql")]
            [Validation(Required=false)]
            public string Sql { get; set; }

            /// <summary>
            /// <para>The returned query results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;area&quot;:&quot;East China&quot;,&quot;city&quot;:&quot;Sanming&quot;},{&quot;area&quot;:&quot;East China&quot;,&quot;city&quot;:&quot;Shanghai&quot;}]</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Values { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The request is successful.</para>
        /// </description></item>
        /// <item><description><para>false: The request fails.</para>
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
