// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListInstancesRequest : TeaModel {
        [NameInMap("instanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

    }

}
