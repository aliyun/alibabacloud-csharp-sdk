// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchGetEdgeInstanceDeviceConfigResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("DeviceConfigList")]
        [Validation(Required=true)]
        public List<BatchGetEdgeInstanceDeviceConfigResponseDeviceConfigList> DeviceConfigList { get; set; }
        public class BatchGetEdgeInstanceDeviceConfigResponseDeviceConfigList : TeaModel {
            [NameInMap("IotId")]
            [Validation(Required=true)]
            public string IotId { get; set; }

            [NameInMap("Config")]
            [Validation(Required=true)]
            public BatchGetEdgeInstanceDeviceConfigResponseDeviceConfigListConfig Config { get; set; }
            public class BatchGetEdgeInstanceDeviceConfigResponseDeviceConfigListConfig : TeaModel {
                [NameInMap("Format")]
                [Validation(Required=true)]
                public string Format { get; set; }
                [NameInMap("Content")]
                [Validation(Required=true)]
                public string Content { get; set; }
            };

        }

    }

}
