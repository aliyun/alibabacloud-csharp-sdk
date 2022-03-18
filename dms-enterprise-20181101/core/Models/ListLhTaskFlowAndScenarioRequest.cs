// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListLhTaskFlowAndScenarioRequest : TeaModel {
        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public long? SpaceId { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
