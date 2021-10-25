// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DeleteNodesRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ReleaseInstance")]
        [Validation(Required=false)]
        public bool? ReleaseInstance { get; set; }

        [NameInMap("Sync")]
        [Validation(Required=false)]
        public bool? Sync { get; set; }

        [NameInMap("Instance")]
        [Validation(Required=false)]
        public List<DeleteNodesRequestInstance> Instance { get; set; }
        public class DeleteNodesRequestInstance : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

    }

}
