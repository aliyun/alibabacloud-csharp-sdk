// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeConfigGroupDetailRequest : TeaModel {
        [NameInMap("ConfigGroupId")]
        [Validation(Required=false)]
        public string ConfigGroupId { get; set; }

        [NameInMap("ConfigGroupName")]
        [Validation(Required=false)]
        public string ConfigGroupName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

    }

}
