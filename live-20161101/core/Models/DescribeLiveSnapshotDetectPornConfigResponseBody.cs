// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveSnapshotDetectPornConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of video moderation configurations.</para>
        /// </summary>
        [NameInMap("LiveSnapshotDetectPornConfigList")]
        [Validation(Required=false)]
        public DescribeLiveSnapshotDetectPornConfigResponseBodyLiveSnapshotDetectPornConfigList LiveSnapshotDetectPornConfigList { get; set; }
        public class DescribeLiveSnapshotDetectPornConfigResponseBodyLiveSnapshotDetectPornConfigList : TeaModel {
            [NameInMap("LiveSnapshotDetectPornConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveSnapshotDetectPornConfigResponseBodyLiveSnapshotDetectPornConfigListLiveSnapshotDetectPornConfig> LiveSnapshotDetectPornConfig { get; set; }
            public class DescribeLiveSnapshotDetectPornConfigResponseBodyLiveSnapshotDetectPornConfigListLiveSnapshotDetectPornConfig : TeaModel {
                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveApp****</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

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
                /// <para>The interval at which snapshots are captured from the live stream. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <para>The name of the OSS bucket.</para>
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
                /// <para>The name of the storage file in Object Storage Service (OSS).</para>
                /// 
                /// <b>Example:</b>
                /// <para>{liveApp****}/{liveStream****}/{Date}/{Hour}/{Minute}_{Second}.jpg</para>
                /// </summary>
                [NameInMap("OssObject")]
                [Validation(Required=false)]
                public string OssObject { get; set; }

                /// <summary>
                /// <para>The moderation scenario array.</para>
                /// </summary>
                [NameInMap("Scenes")]
                [Validation(Required=false)]
                public DescribeLiveSnapshotDetectPornConfigResponseBodyLiveSnapshotDetectPornConfigListLiveSnapshotDetectPornConfigScenes Scenes { get; set; }
                public class DescribeLiveSnapshotDetectPornConfigResponseBodyLiveSnapshotDetectPornConfigListLiveSnapshotDetectPornConfigScenes : TeaModel {
                    [NameInMap("scene")]
                    [Validation(Required=false)]
                    public List<string> Scene { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The sort order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
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
        /// <para>11</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
