// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class UpdateGatewayBlockVolumeRequest : TeaModel {
        [NameInMap("ChapEnabled")]
        [Validation(Required=false)]
        public bool? ChapEnabled { get; set; }

        [NameInMap("ChapInPassword")]
        [Validation(Required=false)]
        public string ChapInPassword { get; set; }

        [NameInMap("ChapInUser")]
        [Validation(Required=false)]
        public string ChapInUser { get; set; }

        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        [NameInMap("IndexId")]
        [Validation(Required=false)]
        public string IndexId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

    }

}
