// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMsConfigClientValuesRequest : TeaModel {
        [NameInMap("AttributeId")]
        [Validation(Required=false)]
        public long? AttributeId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Ips")]
        [Validation(Required=false)]
        public string Ips { get; set; }

    }

}
