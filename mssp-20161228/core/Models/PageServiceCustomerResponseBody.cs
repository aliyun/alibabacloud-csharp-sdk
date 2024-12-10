// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class PageServiceCustomerResponseBody : TeaModel {
        /// <summary>
        /// <para>Interface return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>System error or openapi error</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data query results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<PageServiceCustomerResponseBodyData> Data { get; set; }
        public class PageServiceCustomerResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Customer UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1667751131382856</para>
            /// </summary>
            [NameInMap("Aliuid")]
            [Validation(Required=false)]
            public string Aliuid { get; set; }

            /// <summary>
            /// <para>Authorization status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AuthStatus")]
            [Validation(Required=false)]
            public int? AuthStatus { get; set; }

            /// <summary>
            /// <para>Cloud Monitoring - Alert authorization status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CmAuthStatus")]
            [Validation(Required=false)]
            public int? CmAuthStatus { get; set; }

            /// <summary>
            /// <para>End time. The format is a Unix timestamp, which is the number of milliseconds since January 1, 1970.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710123149222</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>Customer level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GC1</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>Cloud Security - Alert authorization status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MonitorAuthStatus")]
            [Validation(Required=false)]
            public int? MonitorAuthStatus { get; set; }

            /// <summary>
            /// <para>Customer name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>中国工程院</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Owner name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>常温</para>
            /// </summary>
            [NameInMap("OwnId")]
            [Validation(Required=false)]
            public string OwnId { get; set; }

            /// <summary>
            /// <para>Start time. The format is a Unix timestamp, which is the number of milliseconds since January 1, 1970.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710123149000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>Customer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1667751131382856</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>Version information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>企业版</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

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
        /// <para>Return message. When the request is successful, it returns a success message; when the request fails, it returns the reason for the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public PageServiceCustomerResponseBodyPageInfo PageInfo { get; set; }
        public class PageServiceCustomerResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The current page number in pagination queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>Number of items per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of query results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>808A307F-9513-5099-AAA5-98D4EF199140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Request return status.</para>
        /// <list type="bullet">
        /// <item><description>true: Success.</description></item>
        /// <item><description>false: Failure.</description></item>
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
