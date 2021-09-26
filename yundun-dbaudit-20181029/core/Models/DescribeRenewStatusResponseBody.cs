// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20181029.Models
{
    public class DescribeRenewStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeRenewStatusResponseBodyInstances> Instances { get; set; }
        public class DescribeRenewStatusResponseBodyInstances : TeaModel {
            [NameInMap("RenewStatus")]
            [Validation(Required=false)]
            public string RenewStatus { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

    }

}
