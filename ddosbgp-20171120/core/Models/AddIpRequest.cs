// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20171120.Models
{
    public class AddIpRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("PackId")]
        [Validation(Required=true)]
        public string PackId { get; set; }

        [NameInMap("IpList")]
        [Validation(Required=true)]
        public string IpList { get; set; }

    }

}
