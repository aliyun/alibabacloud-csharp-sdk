// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class DisableLoadBalancerIpv6InternetResponseBody : TeaModel {
        /// <summary>
        /// <para>The asynchronous task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d12871a6-ebb2-41f3-8d74-d9f452bb****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7D866E37-1123-5160-AFF1-BDAF5EB86A8A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
