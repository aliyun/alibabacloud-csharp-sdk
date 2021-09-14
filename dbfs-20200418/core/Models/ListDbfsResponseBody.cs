// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class ListDbfsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("DBFSInfo")]
        [Validation(Required=false)]
        public List<ListDbfsResponseBodyDBFSInfo> DBFSInfo { get; set; }
        public class ListDbfsResponseBodyDBFSInfo : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Encryption")]
            [Validation(Required=false)]
            public bool? Encryption { get; set; }

            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            [NameInMap("FsId")]
            [Validation(Required=false)]
            public string FsId { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListDbfsResponseBodyDBFSInfoTags> Tags { get; set; }
            public class ListDbfsResponseBodyDBFSInfoTags : TeaModel {
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

            }

            [NameInMap("SizeG")]
            [Validation(Required=false)]
            public int? SizeG { get; set; }

            [NameInMap("EcsList")]
            [Validation(Required=false)]
            public List<ListDbfsResponseBodyDBFSInfoEcsList> EcsList { get; set; }
            public class ListDbfsResponseBodyDBFSInfoEcsList : TeaModel {
                [NameInMap("EcsId")]
                [Validation(Required=false)]
                public string EcsId { get; set; }

            }

            [NameInMap("EbsList")]
            [Validation(Required=false)]
            public List<ListDbfsResponseBodyDBFSInfoEbsList> EbsList { get; set; }
            public class ListDbfsResponseBodyDBFSInfoEbsList : TeaModel {
                [NameInMap("EbsId")]
                [Validation(Required=false)]
                public string EbsId { get; set; }

                [NameInMap("SizeG")]
                [Validation(Required=false)]
                public int? SizeG { get; set; }

            }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("DBFSClusterId")]
            [Validation(Required=false)]
            public string DBFSClusterId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("FsName")]
            [Validation(Required=false)]
            public string FsName { get; set; }

            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("AttachNodeNumber")]
            [Validation(Required=false)]
            public int? AttachNodeNumber { get; set; }

            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            [NameInMap("UsedScene")]
            [Validation(Required=false)]
            public string UsedScene { get; set; }

            [NameInMap("LastMountTime")]
            [Validation(Required=false)]
            public string LastMountTime { get; set; }

            [NameInMap("LastUmountTime")]
            [Validation(Required=false)]
            public string LastUmountTime { get; set; }

            [NameInMap("EnableRaid")]
            [Validation(Required=false)]
            public bool? EnableRaid { get; set; }

            [NameInMap("RaidStrip")]
            [Validation(Required=false)]
            public int? RaidStrip { get; set; }

        }

    }

}
