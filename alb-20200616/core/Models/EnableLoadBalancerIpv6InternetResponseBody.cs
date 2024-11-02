// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class EnableLoadBalancerIpv6InternetResponseBody : TeaModel {
        /// <summary>
        /// <para>The asynchronous task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4a6e3ad4-ef08-4ab1-b332-fa621cfe****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BB920797-D70E-567F-8098-55A861DD7912</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
