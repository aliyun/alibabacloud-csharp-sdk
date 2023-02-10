// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchSetEdgeInstanceDeviceChannelRequest : TeaModel {
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("DriverId")]
        [Validation(Required=false)]
        public string DriverId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IotIds")]
        [Validation(Required=false)]
        public List<string> IotIds { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

    }

}
