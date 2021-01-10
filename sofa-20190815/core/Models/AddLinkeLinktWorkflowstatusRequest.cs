// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddLinkeLinktWorkflowstatusRequest : TeaModel {
        [NameInMap("AsDefault")]
        [Validation(Required=false)]
        public bool? AsDefault { get; set; }

        [NameInMap("ConvertStatusId")]
        [Validation(Required=false)]
        public long? ConvertStatusId { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("StatusId")]
        [Validation(Required=false)]
        public long? StatusId { get; set; }

        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public long? WorkflowId { get; set; }

    }

}
