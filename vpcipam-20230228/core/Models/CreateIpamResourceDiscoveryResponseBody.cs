// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class CreateIpamResourceDiscoveryResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the instance for resource discovery.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipam-res-disco-jt5f2af2u6nk2z321****</para>
        /// </summary>
        [NameInMap("IpamResourceDiscoveryId")]
        [Validation(Required=false)]
        public string IpamResourceDiscoveryId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BB2C39DE-CEB8-595A-981A-F2EFCBE7324E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
