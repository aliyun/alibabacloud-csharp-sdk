/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ChangeResourceGroupRequest : TeaModel {
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("newResourceGroupId")]
        [Validation(Required=false)]
        public string NewResourceGroupId { get; set; }

    }

}
