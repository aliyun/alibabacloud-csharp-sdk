// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AttachVbrToVpconnRequest : TeaModel {
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        [NameInMap("VbrId")]
        [Validation(Required=false)]
        public string VbrId { get; set; }

        [NameInMap("VpconnId")]
        [Validation(Required=false)]
        public string VpconnId { get; set; }

    }

}
