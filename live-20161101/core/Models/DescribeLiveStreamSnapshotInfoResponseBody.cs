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
        /// <para>The time when the next call occurred. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
        /// <remarks>
        /// <para> If the number of snapshots that were captured within the specified time period exceeds the value of the Limit parameter, this parameter is returned. It indicates the time when the DescribeLiveStreamSnapshotInfo operation was called again. If this parameter is not returned, the number of snapshots that are captured within the specified time period does not exceed the specified limit.</para>
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
