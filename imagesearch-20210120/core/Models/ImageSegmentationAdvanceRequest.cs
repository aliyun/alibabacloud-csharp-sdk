// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20210120.Models
{
    public class ImageSegmentationAdvanceRequest : TeaModel {
        [NameInMap("PicContentObject")]
        [Validation(Required=true)]
        public Stream PicContentObject { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("ReturnPicFormat")]
        [Validation(Required=false)]
        public string ReturnPicFormat { get; set; }

        [NameInMap("ReturnPicType")]
        [Validation(Required=false)]
        public string ReturnPicType { get; set; }

    }

}
