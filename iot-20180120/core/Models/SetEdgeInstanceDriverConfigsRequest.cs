// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class SetEdgeInstanceDriverConfigsRequest : TeaModel {
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<SetEdgeInstanceDriverConfigsRequestConfigs> Configs { get; set; }
        public class SetEdgeInstanceDriverConfigsRequestConfigs : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

        }

        [NameInMap("DriverId")]
        [Validation(Required=false)]
        public string DriverId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

    }

}
