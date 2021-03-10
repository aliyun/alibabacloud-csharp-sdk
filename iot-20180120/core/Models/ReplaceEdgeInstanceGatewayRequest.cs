// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ReplaceEdgeInstanceGatewayRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=true)]
        public string InstanceId { get; set; }

        [NameInMap("CurrentGatewayId")]
        [Validation(Required=true)]
        public string CurrentGatewayId { get; set; }

        [NameInMap("NewGatewayId")]
        [Validation(Required=true)]
        public string NewGatewayId { get; set; }

    }

}
