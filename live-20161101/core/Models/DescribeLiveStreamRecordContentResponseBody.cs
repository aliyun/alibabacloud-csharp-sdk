// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamRecordContentResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// </summary>
        [NameInMap("RecordContentInfoList")]
        [Validation(Required=false)]
        public DescribeLiveStreamRecordContentResponseBodyRecordContentInfoList RecordContentInfoList { get; set; }
        public class DescribeLiveStreamRecordContentResponseBodyRecordContentInfoList : TeaModel {
            [NameInMap("RecordContentInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamRecordContentResponseBodyRecordContentInfoListRecordContentInfo> RecordContentInfo { get; set; }
            public class DescribeLiveStreamRecordContentResponseBodyRecordContentInfoListRecordContentInfo : TeaModel {
                /// <summary>
                /// <para>The beginning of the time range for which the recordings were queried. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public float? Duration { get; set; }

                /// <summary>
                /// <para>The recordings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-12-01T07:46:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The recording length. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveBucket****</para>
                /// </summary>
                [NameInMap("OssBucket")]
                [Validation(Required=false)]
                public string OssBucket { get; set; }

                /// <summary>
                /// <para>The naming rule of recordings in OSS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-oss-****.aliyuncs.com</para>
                /// </summary>
                [NameInMap("OssEndpoint")]
                [Validation(Required=false)]
                public string OssEndpoint { get; set; }

                /// <summary>
                /// <para>The name of the Object Storage Service (OSS) bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>record/{Date}/{UnixTimestamp}_{Sequence}</para>
                /// </summary>
                [NameInMap("OssObjectPrefix")]
                [Validation(Required=false)]
                public string OssObjectPrefix { get; set; }

                /// <summary>
                /// <para>The end of the time range for which the recordings were queried. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-12-01T07:36:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The end of the time range to query. The time range that is specified by the StartTime and EndTime parameters cannot exceed 4 days. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>62136AE6-7793-45ED-B14A-60D19A9486D3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
