// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ReleaseInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the security instance. This must be a DDoS security instance ID in the format of esa-ddos-<em>. You can call the ListDDoSInstances operation to obtain the ID. Site instance IDs in the format of esa-site-</em> are not supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esa-ddos-2sdj**3s</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
