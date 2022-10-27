// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetCommonImageRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ContainType")]
        [Validation(Required=false)]
        public string ContainType { get; set; }

        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
