// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class RequestServiceOfCloudDBARequest : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("ServiceRequestParam")]
        [Validation(Required=false)]
        public string ServiceRequestParam { get; set; }

        [NameInMap("ServiceRequestType")]
        [Validation(Required=false)]
        public string ServiceRequestType { get; set; }

    }

}
