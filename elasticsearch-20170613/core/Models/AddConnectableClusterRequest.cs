// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class AddConnectableClusterRequest : TeaModel {
        /// <summary>
        /// <para>The remote instance ID. Specifies the remote instance ID to establish network connectivity with. The remote instance must be in the same VPC as the current instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;instanceId&quot;:&quot;es-cn-09k1rgid9000g****&quot; }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>A client-generated token used to ensure the idempotence of the request. The value must be unique across different requests and cannot exceed 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
