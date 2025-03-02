// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class GetDbfsResponseBody : TeaModel {
        [NameInMap("DBFSInfo")]
        [Validation(Required=false)]
        public GetDbfsResponseBodyDBFSInfo DBFSInfo { get; set; }
        public class GetDbfsResponseBodyDBFSInfo : TeaModel {
            [NameInMap("AdvancedFeatures")]
            [Validation(Required=false)]
            public string AdvancedFeatures { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AttachNodeNumber")]
            [Validation(Required=false)]
            public int? AttachNodeNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1609330367000</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c39EcDBf-2Ecb-C3C6-6526-018d4Dcf63eD</para>
            /// </summary>
            [NameInMap("DBFSClusterId")]
            [Validation(Required=false)]
            public string DBFSClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>desc</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EbsList")]
            [Validation(Required=false)]
            public List<GetDbfsResponseBodyDBFSInfoEbsList> EbsList { get; set; }
            public class GetDbfsResponseBodyDBFSInfoEbsList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>d-bp1hq4******qi7gy1th</para>
                /// </summary>
                [NameInMap("EbsId")]
                [Validation(Required=false)]
                public string EbsId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("SizeG")]
                [Validation(Required=false)]
                public int? SizeG { get; set; }

            }

            [NameInMap("EcsList")]
            [Validation(Required=false)]
            public List<GetDbfsResponseBodyDBFSInfoEcsList> EcsList { get; set; }
            public class GetDbfsResponseBodyDBFSInfoEcsList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>i-y2vZ3********vvMilZ2hQ</para>
                /// </summary>
                [NameInMap("EcsId")]
                [Validation(Required=false)]
                public string EcsId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableRaid")]
            [Validation(Required=false)]
            public bool? EnableRaid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encryption")]
            [Validation(Required=false)]
            public bool? Encryption { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dbfs-GOrr********Yd0VLOyBpg</para>
            /// </summary>
            [NameInMap("FsId")]
            [Validation(Required=false)]
            public string FsId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dbfs-test-01</para>
            /// </summary>
            [NameInMap("FsName")]
            [Validation(Required=false)]
            public string FsName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dbfs.small</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c39EcDBf-2Ecb-C3C6-6526-018d4D******</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TargetIsBusy.DBFS</para>
            /// </summary>
            [NameInMap("LastFailed")]
            [Validation(Required=false)]
            public string LastFailed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1644915400000</para>
            /// </summary>
            [NameInMap("LastMountTime")]
            [Validation(Required=false)]
            public string LastMountTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1644915319000</para>
            /// </summary>
            [NameInMap("LastUmountTime")]
            [Validation(Required=false)]
            public string LastUmountTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>postpaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RaidStrip")]
            [Validation(Required=false)]
            public int? RaidStrip { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("SizeG")]
            [Validation(Required=false)]
            public int? SizeG { get; set; }

            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            [NameInMap("SnapshotInfo")]
            [Validation(Required=false)]
            public GetDbfsResponseBodyDBFSInfoSnapshotInfo SnapshotInfo { get; set; }
            public class GetDbfsResponseBodyDBFSInfoSnapshotInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>sl-9zskwvgoqqqvzxa*******</para>
                /// </summary>
                [NameInMap("LinkId")]
                [Validation(Required=false)]
                public string LinkId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sp-ehuhzlfetb2jiwz*******</para>
                /// </summary>
                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public string PolicyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SnapshotCount")]
                [Validation(Required=false)]
                public int? SnapshotCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50331648</para>
                /// </summary>
                [NameInMap("TotalSize")]
                [Validation(Required=false)]
                public long? TotalSize { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>attached</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetDbfsResponseBodyDBFSInfoTags> Tags { get; set; }
            public class GetDbfsResponseBodyDBFSInfoTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TestTagKey1</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TestTagValue1</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MySQL 5.7</para>
            /// </summary>
            [NameInMap("UsedScene")]
            [Validation(Required=false)]
            public string UsedScene { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
