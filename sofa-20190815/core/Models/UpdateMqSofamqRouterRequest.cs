// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateMqSofamqRouterRequest : TeaModel {
        [NameInMap("CurrentStatus")]
        [Validation(Required=false)]
        public long? CurrentStatus { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RouterId")]
        [Validation(Required=false)]
        public long? RouterId { get; set; }

        [NameInMap("TargetStatus")]
        [Validation(Required=false)]
        public long? TargetStatus { get; set; }

    }

}
