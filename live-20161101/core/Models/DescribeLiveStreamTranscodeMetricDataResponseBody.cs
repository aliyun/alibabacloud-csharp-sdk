// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamTranscodeMetricDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-11T02:46:40Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The paged query token. Each query returns a maximum of 5,000 rows of data. If the data to be queried exceeds 5,000 rows, the response provides the start index for the next query.</para>
        /// <para>Pass this token in the request to continue querying data from the row after the last row returned in the previous query. This token is used for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UjsM9x3aVcJi9a0-ArwJUTTC67C***37C0=</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The number of returned data rows.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time. Format: yyyy-MM-ddTHH:mm:ssZ (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-11T03:46:40Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("StreamDetailData")]
        [Validation(Required=false)]
        public DescribeLiveStreamTranscodeMetricDataResponseBodyStreamDetailData StreamDetailData { get; set; }
        public class DescribeLiveStreamTranscodeMetricDataResponseBodyStreamDetailData : TeaModel {
            [NameInMap("StreamData")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamTranscodeMetricDataResponseBodyStreamDetailDataStreamData> StreamData { get; set; }
            public class DescribeLiveStreamTranscodeMetricDataResponseBodyStreamDetailDataStreamData : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("Resolution")]
                [Validation(Required=false)]
                public string Resolution { get; set; }

                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("TranscodeType")]
                [Validation(Required=false)]
                public string TranscodeType { get; set; }

            }

        }

    }

}
