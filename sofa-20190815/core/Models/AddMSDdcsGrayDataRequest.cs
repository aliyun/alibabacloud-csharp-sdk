// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddMSDdcsGrayDataRequest : TeaModel {
        [NameInMap("AttributeId")]
        [Validation(Required=false)]
        public int? AttributeId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public string Hosts { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

    }

}
