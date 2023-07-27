// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class CreateAccessPointConfiguration : TeaModel {
        [NameInMap("AccessPointName")]
        [Validation(Required=false)]
        public string AccessPointName { get; set; }

        [NameInMap("NetworkOrigin")]
        [Validation(Required=false)]
        public string NetworkOrigin { get; set; }

        [NameInMap("VpcConfiguration")]
        [Validation(Required=false)]
        public AccessPointVpcConfiguration VpcConfiguration { get; set; }

    }

}
