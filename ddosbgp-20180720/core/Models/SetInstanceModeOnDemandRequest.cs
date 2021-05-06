// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class SetInstanceModeOnDemandRequest : TeaModel {
        [NameInMap("InstanceIdList")]
        [Validation(Required=true)]
        public List<string> InstanceIdList { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=true)]
        public string Mode { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
