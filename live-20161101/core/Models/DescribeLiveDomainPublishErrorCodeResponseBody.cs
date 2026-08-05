// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainPublishErrorCodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The time granularity of the queried data. Unit: seconds. Default value: 60.</para>
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
        /// <para>example1.aliyundoc.com,example2.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-29T09:10:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The status code distribution data for each time interval.</para>
        /// </summary>
        [NameInMap("RealTimeCodeData")]
        [Validation(Required=false)]
        public List<DescribeLiveDomainPublishErrorCodeResponseBodyRealTimeCodeData> RealTimeCodeData { get; set; }
        public class DescribeLiveDomainPublishErrorCodeResponseBodyRealTimeCodeData : TeaModel {
            /// <summary>
            /// <para>The list of status code distribution data.</para>
            /// </summary>
            [NameInMap("CodeData")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainPublishErrorCodeResponseBodyRealTimeCodeDataCodeData> CodeData { get; set; }
            public class DescribeLiveDomainPublishErrorCodeResponseBodyRealTimeCodeDataCodeData : TeaModel {
                /// <summary>
                /// <para>The response code. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>3: read data timeout.</description></item>
                /// <item><description>4: write data error.</description></item>
                /// <item><description>6: write data timeout.</description></item>
                /// <item><description>200: success.</description></item>
                /// <item><description>500: internal system unknown error.</description></item>
                /// <item><description>501: stream ingest exception.</description></item>
                /// <item><description>502: signaling took too long.</description></item>
                /// <item><description>401: stream ingest parameter exception.</description></item>
                /// <item><description>403: stream ingest authentication failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The number of responses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public string Count { get; set; }

                /// <summary>
                /// <para>The proportion of responses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>66.04</para>
                /// </summary>
                [NameInMap("Proportion")]
                [Validation(Required=false)]
                public string Proportion { get; set; }

            }

            /// <summary>
            /// <para>The start time of the time interval. The time is in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
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
        /// <para>BC858082-736F-4A25-867B-E5B67C******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-29T09:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
