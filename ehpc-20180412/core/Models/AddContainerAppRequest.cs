// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class AddContainerAppRequest : TeaModel {
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Repository")]
        [Validation(Required=false)]
        public string Repository { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

        [NameInMap("ContainerType")]
        [Validation(Required=false)]
        public string ContainerType { get; set; }

    }

}
