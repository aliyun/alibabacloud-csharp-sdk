// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UpdateEdgeInstanceChannelRequest : TeaModel {
        [NameInMap("ChannelId")]
        [Validation(Required=true)]
        public string ChannelId { get; set; }

        [NameInMap("ChannelName")]
        [Validation(Required=true)]
        public string ChannelName { get; set; }

        [NameInMap("Configs")]
        [Validation(Required=true)]
        public List<UpdateEdgeInstanceChannelRequestConfigs> Configs { get; set; }
        public class UpdateEdgeInstanceChannelRequestConfigs : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=true)]
            public string Content { get; set; }

            [NameInMap("Format")]
            [Validation(Required=true)]
            public string Format { get; set; }

            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

        }

        [NameInMap("DriverId")]
        [Validation(Required=true)]
        public string DriverId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=true)]
        public string InstanceId { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

    }

}
