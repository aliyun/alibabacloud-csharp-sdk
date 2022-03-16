// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeReusableSlbResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ReusableSlbList")]
        [Validation(Required=false)]
        public List<DescribeReusableSlbResponseBodyReusableSlbList> ReusableSlbList { get; set; }
        public class DescribeReusableSlbResponseBodyReusableSlbList : TeaModel {
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            [NameInMap("LoadBalancerName")]
            [Validation(Required=false)]
            public string LoadBalancerName { get; set; }

        }

    }

}
