// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListDataServiceApiCallStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>Backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Backend error details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Paginated query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListDataServiceApiCallStatisticsResponseBodyPageResult PageResult { get; set; }
        public class ListDataServiceApiCallStatisticsResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>API call statistics list.</para>
            /// </summary>
            [NameInMap("CallStatisticsList")]
            [Validation(Required=false)]
            public List<ListDataServiceApiCallStatisticsResponseBodyPageResultCallStatisticsList> CallStatisticsList { get; set; }
            public class ListDataServiceApiCallStatisticsResponseBodyPageResultCallStatisticsList : TeaModel {
                /// <summary>
                /// <para>API ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1003</para>
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public long? ApiId { get; set; }

                /// <summary>
                /// <para>API name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// <para>Authorized application names.</para>
                /// </summary>
                [NameInMap("AppNameList")]
                [Validation(Required=false)]
                public List<string> AppNameList { get; set; }

                /// <summary>
                /// <para>Number of authorized applications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AuthorizedAppCount")]
                [Validation(Required=false)]
                public int? AuthorizedAppCount { get; set; }

                /// <summary>
                /// <para>Average response time, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("AvgResponseTime")]
                [Validation(Required=false)]
                public double? AvgResponseTime { get; set; }

                /// <summary>
                /// <para>Number of calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("CallCount")]
                [Validation(Required=false)]
                public long? CallCount { get; set; }

                /// <summary>
                /// <para>Creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>Number of call errors.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("ErrorCount")]
                [Validation(Required=false)]
                public string ErrorCount { get; set; }

                /// <summary>
                /// <para>Error rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23.2%</para>
                /// </summary>
                [NameInMap("ErrorRate")]
                [Validation(Required=false)]
                public string ErrorRate { get; set; }

                /// <summary>
                /// <para>Last call time. Format: yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 08:00:00</para>
                /// </summary>
                [NameInMap("LastCallTime")]
                [Validation(Required=false)]
                public string LastCallTime { get; set; }

                /// <summary>
                /// <para>Offline percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23.2%</para>
                /// </summary>
                [NameInMap("OfflineRate")]
                [Validation(Required=false)]
                public string OfflineRate { get; set; }

                /// <summary>
                /// <para>Data service project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>101201</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public int? ProjectId { get; set; }

                /// <summary>
                /// <para>Data service project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>SQL table primary key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1121</para>
                /// </summary>
                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public int? SqlId { get; set; }

            }

            /// <summary>
            /// <para>Total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>68</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
