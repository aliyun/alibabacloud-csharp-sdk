// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeReusableSlbResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EDDC0D86-2FC3-56FB-9213-96EB0A3523F1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of SLB instances that can be reused.</para>
        /// </summary>
        [NameInMap("ReusableSlbList")]
        [Validation(Required=false)]
        public List<DescribeReusableSlbResponseBodyReusableSlbList> ReusableSlbList { get; set; }
        public class DescribeReusableSlbResponseBodyReusableSlbList : TeaModel {
            /// <summary>
            /// <para>The ID of the SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-bp17xygzsxth0bwlz****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The name of the SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ad6044b015ac54484a20c47241175bb3</para>
            /// </summary>
            [NameInMap("LoadBalancerName")]
            [Validation(Required=false)]
            public string LoadBalancerName { get; set; }

        }

    }

}
