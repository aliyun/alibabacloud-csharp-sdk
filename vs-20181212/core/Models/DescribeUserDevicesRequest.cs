// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeUserDevicesRequest : TeaModel {
        [NameInMap("EnsInstanceIds")]
        [Validation(Required=false)]
        public string EnsInstanceIds { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ServerName")]
        [Validation(Required=false)]
        public string ServerName { get; set; }

    }

}
