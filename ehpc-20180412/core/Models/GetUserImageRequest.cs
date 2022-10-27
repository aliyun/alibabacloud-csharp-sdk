// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetUserImageRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ContainerType")]
        [Validation(Required=false)]
        public string ContainerType { get; set; }

        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        [NameInMap("ImagePath")]
        [Validation(Required=false)]
        public string ImagePath { get; set; }

        [NameInMap("OSSBucket")]
        [Validation(Required=false)]
        public string OSSBucket { get; set; }

        [NameInMap("OSSEndPoint")]
        [Validation(Required=false)]
        public string OSSEndPoint { get; set; }

    }

}
