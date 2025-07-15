// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainPublishErrorCodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The time granularity of the query. Unit: seconds. Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// <para>The ingest domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com,example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range during which data was queried. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-29T09:10:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The proportions of error codes at each time interval.</para>
        /// </summary>
        [NameInMap("RealTimeCodeData")]
        [Validation(Required=false)]
        public List<DescribeLiveDomainPublishErrorCodeResponseBodyRealTimeCodeData> RealTimeCodeData { get; set; }
        public class DescribeLiveDomainPublishErrorCodeResponseBodyRealTimeCodeData : TeaModel {
            /// <summary>
            /// <para>The proportions of error codes.</para>
            /// </summary>
            [NameInMap("CodeData")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainPublishErrorCodeResponseBodyRealTimeCodeDataCodeData> CodeData { get; set; }
            public class DescribeLiveDomainPublishErrorCodeResponseBodyRealTimeCodeDataCodeData : TeaModel {
                /// <summary>
                /// <para>The response code. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>3: The data read timed out.</description></item>
                /// <item><description>4: A data write error occurred.</description></item>
                /// <item><description>6: The data write timed out.</description></item>
                /// <item><description>200: The request is successful.</description></item>
                /// <item><description>500: An unknown internal error occurred.</description></item>
                /// <item><description>501: The stream ingest failed.</description></item>
                /// <item><description>502: The signaling operation timed out.</description></item>
                /// <item><description>401: A stream ingest parameter is invalid.</description></item>
                /// <item><description>403: The stream ingest authentication failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The number of times the HTTP status code was returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public string Count { get; set; }

                /// <summary>
                /// <para>The proportion of the HTTP status code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>66.04</para>
                /// </summary>
                [NameInMap("Proportion")]
                [Validation(Required=false)]
                public string Proportion { get; set; }

            }

            /// <summary>
            /// <para>The timestamp of the data returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2016-06-29T09:01:00Z</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC858082-736F-4A25-867B-E5B67C85ACF7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range during which data was queried. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-29T09:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
