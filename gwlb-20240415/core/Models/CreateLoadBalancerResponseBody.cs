// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gwlb20240415.Models
{
    public class CreateLoadBalancerResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>gwlb-9njtjmqt7zfcqm****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>00B19438-66BB-58C3-8C2F-DA5B6F95CBDA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
