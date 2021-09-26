// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class AddSecurityWhiteListRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("PortRange")]
        [Validation(Required=false)]
        public string PortRange { get; set; }

        [NameInMap("WhiteIpList")]
        [Validation(Required=false)]
        public List<string> WhiteIpList { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
