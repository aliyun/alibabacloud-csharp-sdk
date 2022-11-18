// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class GetEntityResponseBody : TeaModel {
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public List<string> Attributes { get; set; }

        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
