// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class CreateGroupDNSServiceRuleResponseBody : TeaModel {
        [NameInMap("DNSServiceRuleId")]
        [Validation(Required=false)]
        public string DNSServiceRuleId { get; set; }

        [NameInMap("IoTCloudConnectorGroupId")]
        [Validation(Required=false)]
        public string IoTCloudConnectorGroupId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
