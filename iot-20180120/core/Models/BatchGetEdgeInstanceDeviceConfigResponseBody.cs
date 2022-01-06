// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchGetEdgeInstanceDeviceConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DeviceConfigList")]
        [Validation(Required=false)]
        public List<BatchGetEdgeInstanceDeviceConfigResponseBodyDeviceConfigList> DeviceConfigList { get; set; }
        public class BatchGetEdgeInstanceDeviceConfigResponseBodyDeviceConfigList : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public BatchGetEdgeInstanceDeviceConfigResponseBodyDeviceConfigListConfig Config { get; set; }
            public class BatchGetEdgeInstanceDeviceConfigResponseBodyDeviceConfigListConfig : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }
            };

            [NameInMap("IotId")]
            [Validation(Required=false)]
            public string IotId { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
