// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class GetIoTCloudConnectorAccessLogResponseBody : TeaModel {
        [NameInMap("AccessLogSlsLogStore")]
        [Validation(Required=false)]
        public string AccessLogSlsLogStore { get; set; }

        [NameInMap("AccessLogSlsProject")]
        [Validation(Required=false)]
        public string AccessLogSlsProject { get; set; }

        [NameInMap("AccessLogStatus")]
        [Validation(Required=false)]
        public string AccessLogStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
