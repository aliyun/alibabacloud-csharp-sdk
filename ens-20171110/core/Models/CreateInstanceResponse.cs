// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateInstanceResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=true)]
        public CreateInstanceResponseInstanceIds InstanceIds { get; set; }
        public class CreateInstanceResponseInstanceIds : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public List<string> InstanceId { get; set; }
        };

    }

}
