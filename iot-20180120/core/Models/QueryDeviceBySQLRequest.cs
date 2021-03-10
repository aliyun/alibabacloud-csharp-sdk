// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceBySQLRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=true)]
        public string IotInstanceId { get; set; }

        [NameInMap("SQL")]
        [Validation(Required=true)]
        public string SQL { get; set; }

    }

}
