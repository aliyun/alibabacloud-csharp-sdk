// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GrantInstanceToVbrShrinkRequest : TeaModel {
        [NameInMap("GrantType")]
        [Validation(Required=false)]
        public string GrantType { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("VbrInstanceIds")]
        [Validation(Required=false)]
        public string VbrInstanceIdsShrink { get; set; }

        [NameInMap("VbrOwnerUid")]
        [Validation(Required=false)]
        public long? VbrOwnerUid { get; set; }

        [NameInMap("VbrRegionNo")]
        [Validation(Required=false)]
        public string VbrRegionNo { get; set; }

    }

}
