// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateBundleRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=true)]
        public string ImageId { get; set; }

        [NameInMap("DesktopType")]
        [Validation(Required=true)]
        public string DesktopType { get; set; }

        [NameInMap("RootDiskSizeGib")]
        [Validation(Required=true)]
        public int? RootDiskSizeGib { get; set; }

        [NameInMap("BundleName")]
        [Validation(Required=false)]
        public string BundleName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("UserDiskSizeGib")]
        [Validation(Required=true)]
        public List<int?> UserDiskSizeGib { get; set; }

    }

}
