// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class InspectImageRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ContainerType")]
        [Validation(Required=false)]
        public string ContainerType { get; set; }

        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

    }

}
