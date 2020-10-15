// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyImageAttributeRequest : TeaModel {
        [NameInMap("product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        [NameInMap("Version")]
        [Validation(Required=true)]
        public string Version { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=true)]
        public string ImageId { get; set; }

        [NameInMap("ImageName")]
        [Validation(Required=true)]
        public string ImageName { get; set; }

    }

}
