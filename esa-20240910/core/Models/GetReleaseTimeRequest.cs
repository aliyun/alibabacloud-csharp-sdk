// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetReleaseTimeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the security instance. This must be a DDoS security instance ID (in the format esa-ddos-), which you can obtain by calling the ListDDoSInstances operation. Site instance IDs (in the format esa-site-) are not supported.</para>
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
