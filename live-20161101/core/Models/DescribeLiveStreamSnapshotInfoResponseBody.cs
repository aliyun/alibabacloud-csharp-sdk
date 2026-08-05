// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamSnapshotInfoResponseBody : TeaModel {
        [NameInMap("LiveStreamSnapshotInfoList")]
        [Validation(Required=false)]
        public DescribeLiveStreamSnapshotInfoResponseBodyLiveStreamSnapshotInfoList LiveStreamSnapshotInfoList { get; set; }
        public class DescribeLiveStreamSnapshotInfoResponseBodyLiveStreamSnapshotInfoList : TeaModel {
            [NameInMap("LiveStreamSnapshotInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamSnapshotInfoResponseBodyLiveStreamSnapshotInfoListLiveStreamSnapshotInfo> LiveStreamSnapshotInfo { get; set; }
            public class DescribeLiveStreamSnapshotInfoResponseBodyLiveStreamSnapshotInfoListLiveStreamSnapshotInfo : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("IsOverlay")]
                [Validation(Required=false)]
                public bool? IsOverlay { get; set; }

                [NameInMap("OssBucket")]
                [Validation(Required=false)]
                public string OssBucket { get; set; }

                [NameInMap("OssEndpoint")]
                [Validation(Required=false)]
                public string OssEndpoint { get; set; }

                [NameInMap("OssObject")]
                [Validation(Required=false)]
                public string OssObject { get; set; }

            }

        }

        /// <summary>
        /// <para>The next start time. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
        /// <remarks>
        /// <para>If the content within this time range exceeds the value of Limit, this parameter is returned as the creation time of the next file. You can use this time as the StartTime value and call this operation again to retrieve the next set of content. If this parameter is not returned, the content does not exceed the Limit value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-01T17:36:00Z</para>
        /// </summary>
        [NameInMap("NextStartTime")]
        [Validation(Required=false)]
        public string NextStartTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>62136AE6-7793-45ED-B14A-60D19A9486D3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
