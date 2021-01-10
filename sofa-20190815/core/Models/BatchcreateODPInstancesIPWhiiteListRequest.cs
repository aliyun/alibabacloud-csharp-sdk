// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class BatchcreateODPInstancesIPWhiiteListRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IpList")]
        [Validation(Required=false)]
        public string IpList { get; set; }

        [NameInMap("ZdalproxyInstanceId")]
        [Validation(Required=false)]
        public string ZdalproxyInstanceId { get; set; }

    }

}
