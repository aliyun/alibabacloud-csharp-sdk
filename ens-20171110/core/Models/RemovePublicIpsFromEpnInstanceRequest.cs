// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RemovePublicIpsFromEpnInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the EPN instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epn-xxxx</para>
        /// </summary>
        [NameInMap("EPNInstanceId")]
        [Validation(Required=false)]
        public string EPNInstanceId { get; set; }

        /// <summary>
        /// <para>The information about the public IP addresses that you want to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;PublicIpAddress&quot;:&quot;2.230.XX.XX&quot;},{&quot;PublicIpAddress&quot;:&quot;2.230.XX.XX&quot;}]</para>
        /// </summary>
        [NameInMap("InstanceInfos")]
        [Validation(Required=false)]
        public string InstanceInfos { get; set; }

    }

}
