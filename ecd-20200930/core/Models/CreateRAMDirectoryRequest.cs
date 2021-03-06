// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateRAMDirectoryRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("DirectoryName")]
        [Validation(Required=false)]
        public string DirectoryName { get; set; }

        [NameInMap("EnableInternetAccess")]
        [Validation(Required=false)]
        public bool? EnableInternetAccess { get; set; }

        [NameInMap("EnableAdminAccess")]
        [Validation(Required=false)]
        public bool? EnableAdminAccess { get; set; }

        [NameInMap("DesktopAccessType")]
        [Validation(Required=false)]
        public string DesktopAccessType { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=true)]
        public List<string> VSwitchId { get; set; }

    }

}
