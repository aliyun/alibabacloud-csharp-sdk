// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class CreateIpamPoolResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ipam-pool-6rcq3tobayc20t****</para>
        /// </summary>
        [NameInMap("IpamPoolId")]
        [Validation(Required=false)]
        public string IpamPoolId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BB2C39DE-CEB8-595A-981A-F2EFCBE7324E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
