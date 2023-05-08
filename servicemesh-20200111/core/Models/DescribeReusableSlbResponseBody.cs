// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeReusableSlbResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of SLB instances that can be reused.
        /// </summary>
        [NameInMap("ReusableSlbList")]
        [Validation(Required=false)]
        public List<DescribeReusableSlbResponseBodyReusableSlbList> ReusableSlbList { get; set; }
        public class DescribeReusableSlbResponseBodyReusableSlbList : TeaModel {
            /// <summary>
            /// The ID of the SLB instance.
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// The name of the SLB instance.
            /// </summary>
            [NameInMap("LoadBalancerName")]
            [Validation(Required=false)]
            public string LoadBalancerName { get; set; }

        }

    }

}
