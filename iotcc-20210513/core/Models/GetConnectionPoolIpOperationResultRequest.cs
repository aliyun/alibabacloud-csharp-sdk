// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class GetConnectionPoolIpOperationResultRequest : TeaModel {
        [NameInMap("ConnectionPoolId")]
        [Validation(Required=false)]
        public string ConnectionPoolId { get; set; }

        [NameInMap("IoTCloudConnectorId")]
        [Validation(Required=false)]
        public string IoTCloudConnectorId { get; set; }

        [NameInMap("QueryRequestId")]
        [Validation(Required=false)]
        public string QueryRequestId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
