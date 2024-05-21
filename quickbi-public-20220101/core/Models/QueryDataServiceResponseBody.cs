// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataServiceResponseBody : TeaModel {
        /// <summary>
        /// The list of parameter names of the returned parameters. The value is a string of the List type.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   true: The request was successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDataServiceResponseBodyResult Result { get; set; }
        public class QueryDataServiceResponseBodyResult : TeaModel {
            /// <summary>
            /// The SQL of the request query.
            /// </summary>
            [NameInMap("Headers")]
            [Validation(Required=false)]
            public List<QueryDataServiceResponseBodyResultHeaders> Headers { get; set; }
            public class QueryDataServiceResponseBodyResultHeaders : TeaModel {
                /// <summary>
                /// The field name, which corresponds to the physical table field name.
                /// </summary>
                [NameInMap("Aggregator")]
                [Validation(Required=false)]
                public string Aggregator { get; set; }

                /// <summary>
                /// The granularity of the dimension field. This field is returned only when the requested field is a date dimension or a geographical dimension. Valid values:
                /// 
                /// *   Date granularity: yearRegion (year), monthRegion (month), weekRegion (week), dayRegion (day), hourRegion (hour), minRegion (minute), secRegion (second)
                /// *   Geographic information granularity: COUNTRY (international level), PROVINCE (provincial level), CITY (municipal level), XIAN (district /county), and REGION (regional level)
                /// </summary>
                [NameInMap("Column")]
                [Validation(Required=false)]
                public string Column { get; set; }

                /// <summary>
                /// The column header.
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// The field type, which is used to distinguish whether the field type is a dimension or a measure.
                /// </summary>
                [NameInMap("Granularity")]
                [Validation(Required=false)]
                public string Granularity { get; set; }

                /// <summary>
                /// The data type of the field. generally have number, string, date, datetime, time, and geographic.
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// SELECT COMPANY_T_1_.\\"area\\" AS D_AREA_2_, COMPANY_T_1_.\\"city\\" AS D_CITY_3_, SUM(COMPANY_T_1_.\\"profit_amt\\") AS D_PROFIT_4_ FROM \\"quickbi_test\\".\\"company_sales_record_copy\\" AS COMPANY_T_1_ WHERE COMPANY_T_1_.\\"area\\" LIKE \\"% China East %\\" GROUP BY COMPANY_T_1_.\\"area\\", COMPANY_T_1_.\\"city\\" HAVING SUM(COMPANY_T_1_.\\"order_amt\\") > 1 LIMIT 0,10
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("Sql")]
            [Validation(Required=false)]
            public string Sql { get; set; }

            /// <summary>
            /// Physical Field Name
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Values { get; set; }

        }

        /// <summary>
        /// { "area": ["East China", "North China"], "shopping_date": "2019Q1", }
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
