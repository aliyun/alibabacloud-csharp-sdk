// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchGetEdgeInstanceDeviceChannelResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("DeviceChannelList")]
        [Validation(Required=true)]
        public List<BatchGetEdgeInstanceDeviceChannelResponseDeviceChannelList> DeviceChannelList { get; set; }
        public class BatchGetEdgeInstanceDeviceChannelResponseDeviceChannelList : TeaModel {
            [NameInMap("ChannelId")]
            [Validation(Required=true)]
            public string ChannelId { get; set; }

            [NameInMap("ChannelName")]
            [Validation(Required=true)]
            public string ChannelName { get; set; }

            [NameInMap("IotId")]
            [Validation(Required=true)]
            public string IotId { get; set; }

        }

    }

}
