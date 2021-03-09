/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20210120.Models
{
    public class ImageSegmentationRequest : TeaModel {
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("PicContent")]
        [Validation(Required=false)]
        public string PicContent { get; set; }

        [NameInMap("ReturnPicFormat")]
        [Validation(Required=false)]
        public string ReturnPicFormat { get; set; }

        [NameInMap("ReturnPicType")]
        [Validation(Required=false)]
        public string ReturnPicType { get; set; }

    }

}
