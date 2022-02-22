// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class SetDeployPauseTypeRequest : TeaModel {
        [NameInMap("DeployOrderId")]
        [Validation(Required=false)]
        public long? DeployOrderId { get; set; }

        [NameInMap("DeployPauseType")]
        [Validation(Required=false)]
        public string DeployPauseType { get; set; }

    }

}
