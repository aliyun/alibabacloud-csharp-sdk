// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateImageRequest : TeaModel {
        [NameInMap("product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        [NameInMap("Version")]
        [Validation(Required=true)]
        public string Version { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=true)]
        public string InstanceId { get; set; }

        [NameInMap("ImageName")]
        [Validation(Required=true)]
        public string ImageName { get; set; }

        [NameInMap("DeleteAfterImageUpload")]
        [Validation(Required=false)]
        public string DeleteAfterImageUpload { get; set; }

    }

}
