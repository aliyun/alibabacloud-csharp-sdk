// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20170115.Models
{
    public class DescribeClusterModelResponseBody : TeaModel {
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        [NameInMap("BackupStatus")]
        [Validation(Required=false)]
        public string BackupStatus { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("ColdStorageStatus")]
        [Validation(Required=false)]
        public string ColdStorageStatus { get; set; }

        [NameInMap("CoreDiskQuantity")]
        [Validation(Required=false)]
        public int? CoreDiskQuantity { get; set; }

        [NameInMap("CoreDiskSize")]
        [Validation(Required=false)]
        public string CoreDiskSize { get; set; }

        [NameInMap("CoreDiskType")]
        [Validation(Required=false)]
        public string CoreDiskType { get; set; }

        [NameInMap("CoreInstanceQuantity")]
        [Validation(Required=false)]
        public int? CoreInstanceQuantity { get; set; }

        [NameInMap("CoreInstanceType")]
        [Validation(Required=false)]
        public string CoreInstanceType { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("HaType")]
        [Validation(Required=false)]
        public string HaType { get; set; }

        [NameInMap("HasUser")]
        [Validation(Required=false)]
        public string HasUser { get; set; }

        [NameInMap("IsMultimod")]
        [Validation(Required=false)]
        public string IsMultimod { get; set; }

        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

        [NameInMap("MainVersion")]
        [Validation(Required=false)]
        public string MainVersion { get; set; }

        [NameInMap("MasterDiskSize")]
        [Validation(Required=false)]
        public int? MasterDiskSize { get; set; }

        [NameInMap("MasterDiskType")]
        [Validation(Required=false)]
        public string MasterDiskType { get; set; }

        [NameInMap("MasterInstanceType")]
        [Validation(Required=false)]
        public string MasterInstanceType { get; set; }

        [NameInMap("MinorVersion")]
        [Validation(Required=false)]
        public string MinorVersion { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeClusterModelResponseBodyTags Tags { get; set; }
        public class DescribeClusterModelResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeClusterModelResponseBodyTagsTag> Tag { get; set; }
            public class DescribeClusterModelResponseBodyTagsTag : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("UpdateStatus")]
        [Validation(Required=false)]
        public string UpdateStatus { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
