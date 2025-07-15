// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveSnapshotConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The snapshot configurations.</para>
        /// </summary>
        [NameInMap("LiveStreamSnapshotConfigList")]
        [Validation(Required=false)]
        public DescribeLiveSnapshotConfigResponseBodyLiveStreamSnapshotConfigList LiveStreamSnapshotConfigList { get; set; }
        public class DescribeLiveSnapshotConfigResponseBodyLiveStreamSnapshotConfigList : TeaModel {
            [NameInMap("LiveStreamSnapshotConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveSnapshotConfigResponseBodyLiveStreamSnapshotConfigListLiveStreamSnapshotConfig> LiveStreamSnapshotConfig { get; set; }
            public class DescribeLiveSnapshotConfigResponseBodyLiveStreamSnapshotConfigListLiveStreamSnapshotConfig : TeaModel {
                /// <summary>
                /// <para>The name of the application to which the live stream belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveApp****</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The callback URL that is used to receive notifications about snapshot capture.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://learn.aliyundoc.com">https://learn.aliyundoc.com</a></para>
                /// </summary>
                [NameInMap("Callback")]
                [Validation(Required=false)]
                public string Callback { get; set; }

                /// <summary>
                /// <para>The time when the configuration was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-05-20T01:33:38Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The main streaming domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The name of the Object Storage Service (OSS) bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveBucket****</para>
                /// </summary>
                [NameInMap("OssBucket")]
                [Validation(Required=false)]
                public string OssBucket { get; set; }

                /// <summary>
                /// <para>The endpoint of the OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-oss-****.aliyuncs.com</para>
                /// </summary>
                [NameInMap("OssEndpoint")]
                [Validation(Required=false)]
                public string OssEndpoint { get; set; }

                /// <summary>
                /// <para>The naming format of snapshots that are stored in the overwrite mode, which means that a new snapshot overwrites the previous snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{liveApp****}/{liveStream****}.jpg</para>
                /// </summary>
                [NameInMap("OverwriteOssObject")]
                [Validation(Required=false)]
                public string OverwriteOssObject { get; set; }

                /// <summary>
                /// <para>The naming format of snapshots that are stored in sequence, which means that a new snapshot does not overwrite the previous snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>snapshot/{liveApp****}/{liveStream****}/{UnixTimestamp}.jpg</para>
                /// </summary>
                [NameInMap("SequenceOssObject")]
                [Validation(Required=false)]
                public string SequenceOssObject { get; set; }

                /// <summary>
                /// <para>The interval at which snapshots are captured. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TimeInterval")]
                [Validation(Required=false)]
                public int? TimeInterval { get; set; }

            }

        }

        /// <summary>
        /// <para>The sort order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A3136B58-5876-4168-83CA-B562781981A0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that meet the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
