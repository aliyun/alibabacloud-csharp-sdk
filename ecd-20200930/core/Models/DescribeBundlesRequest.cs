// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeBundlesRequest : TeaModel {
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public List<string> BundleId { get; set; }

        [NameInMap("BundleType")]
        [Validation(Required=false)]
        public string BundleType { get; set; }

        [NameInMap("CheckStock")]
        [Validation(Required=false)]
        public bool? CheckStock { get; set; }

        [NameInMap("CpuCount")]
        [Validation(Required=false)]
        public int? CpuCount { get; set; }

        [NameInMap("DesktopTypeFamily")]
        [Validation(Required=false)]
        public string DesktopTypeFamily { get; set; }

        [NameInMap("FromDesktopGroup")]
        [Validation(Required=false)]
        public bool? FromDesktopGroup { get; set; }

        [NameInMap("GpuCount")]
        [Validation(Required=false)]
        public float? GpuCount { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("MemorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SupportMultiSession")]
        [Validation(Required=false)]
        public bool? SupportMultiSession { get; set; }

        [NameInMap("VolumeEncryptionEnabled")]
        [Validation(Required=false)]
        public bool? VolumeEncryptionEnabled { get; set; }

    }

}
