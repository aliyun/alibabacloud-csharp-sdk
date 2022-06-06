// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateBundleRequest : TeaModel {
        [NameInMap("BundleName")]
        [Validation(Required=false)]
        public string BundleName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DesktopType")]
        [Validation(Required=false)]
        public string DesktopType { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RootDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string RootDiskPerformanceLevel { get; set; }

        [NameInMap("RootDiskSizeGib")]
        [Validation(Required=false)]
        public int? RootDiskSizeGib { get; set; }

        [NameInMap("UserDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string UserDiskPerformanceLevel { get; set; }

        [NameInMap("UserDiskSizeGib")]
        [Validation(Required=false)]
        public List<int?> UserDiskSizeGib { get; set; }

    }

}
