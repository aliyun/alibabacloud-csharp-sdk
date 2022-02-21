// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeContainerInstanceIdResponseBody : TeaModel {
        [NameInMap("InstanceDetail")]
        [Validation(Required=false)]
        public DescribeContainerInstanceIdResponseBodyInstanceDetail InstanceDetail { get; set; }
        public class DescribeContainerInstanceIdResponseBodyInstanceDetail : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
