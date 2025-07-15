// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamPushMetricDetailDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range that was queried. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>A pagination token. When you call this operation, up to 5,000 rows of data can be returned per query. If the number of rows exceeds 5,000, the response includes a pagination token that is used in the next request to retrieve a new page of results.</para>
        /// <para>When you specify the token in the next query, data continues to be obtained from the end of the previous query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UjsM9x3aVcJi9a0-ArwJUTTC67C***37C0=</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The number of rows returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5EBF2AC3-4B73-40A5-8B32-83F49D5F035E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range that was queried. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The data array returned.</para>
        /// </summary>
        [NameInMap("StreamDetailData")]
        [Validation(Required=false)]
        public DescribeLiveStreamPushMetricDetailDataResponseBodyStreamDetailData StreamDetailData { get; set; }
        public class DescribeLiveStreamPushMetricDetailDataResponseBodyStreamDetailData : TeaModel {
            [NameInMap("StreamData")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamPushMetricDetailDataResponseBodyStreamDetailDataStreamData> StreamData { get; set; }
            public class DescribeLiveStreamPushMetricDetailDataResponseBodyStreamDetailDataStreamData : TeaModel {
                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The total bandwidth consumed by the stream per minute. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>423304182</para>
                /// </summary>
                [NameInMap("ReqBps")]
                [Validation(Required=false)]
                public float? ReqBps { get; set; }

                /// <summary>
                /// <para>The total amount of traffic consumed by the stream per minute. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>423304182.66</para>
                /// </summary>
                [NameInMap("ReqTraffic")]
                [Validation(Required=false)]
                public long? ReqTraffic { get; set; }

                /// <summary>
                /// <para>The name of the stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.flv</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                /// <summary>
                /// <para>The timestamp of the returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-09-10T20:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

    }

}
