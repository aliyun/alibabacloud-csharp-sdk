// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCommonAreasRequest : TeaModel {
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        [NameInMap("IsEpg")]
        [Validation(Required=false)]
        public bool? IsEpg { get; set; }

        [NameInMap("IsIpSet")]
        [Validation(Required=false)]
        public bool? IsIpSet { get; set; }

    }

}
