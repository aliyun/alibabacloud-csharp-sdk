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
            [NameInMap("AttachNodeNumber")]
            [Validation(Required=false)]
            public int? AttachNodeNumber { get; set; }
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }
            [NameInMap("DBFSClusterId")]
            [Validation(Required=false)]
            public string DBFSClusterId { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("EbsList")]
            [Validation(Required=false)]
            public List<GetDbfsResponseBodyDBFSInfoEbsList> EbsList { get; set; }
            public class GetDbfsResponseBodyDBFSInfoEbsList : TeaModel {
                public string EbsId { get; set; }
                public int? SizeG { get; set; }
            }
            [NameInMap("EcsList")]
            [Validation(Required=false)]
            public List<GetDbfsResponseBodyDBFSInfoEcsList> EcsList { get; set; }
            public class GetDbfsResponseBodyDBFSInfoEcsList : TeaModel {
                public string EcsId { get; set; }
            }
            [NameInMap("EnableRaid")]
            [Validation(Required=false)]
            public bool? EnableRaid { get; set; }
            [NameInMap("Encryption")]
            [Validation(Required=false)]
            public bool? Encryption { get; set; }
            [NameInMap("FsId")]
            [Validation(Required=false)]
            public string FsId { get; set; }
            [NameInMap("FsName")]
            [Validation(Required=false)]
            public string FsName { get; set; }
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }
            [NameInMap("LastFailed")]
            [Validation(Required=false)]
            public string LastFailed { get; set; }
            [NameInMap("LastMountTime")]
            [Validation(Required=false)]
            public string LastMountTime { get; set; }
            [NameInMap("LastUmountTime")]
            [Validation(Required=false)]
            public string LastUmountTime { get; set; }
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }
            [NameInMap("RaidStrip")]
            [Validation(Required=false)]
            public int? RaidStrip { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("SizeG")]
            [Validation(Required=false)]
            public int? SizeG { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetDbfsResponseBodyDBFSInfoTags> Tags { get; set; }
            public class GetDbfsResponseBodyDBFSInfoTags : TeaModel {
                public int? Id { get; set; }
                public string TagKey { get; set; }
                public string TagValue { get; set; }
            }
            [NameInMap("UsedScene")]
            [Validation(Required=false)]
            public string UsedScene { get; set; }
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
