// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddMSDdcsAttributesRequest : TeaModel {
        [NameInMap("AttributeName")]
        [Validation(Required=false)]
        public string AttributeName { get; set; }

        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public long? ResourceId { get; set; }

    }

}
