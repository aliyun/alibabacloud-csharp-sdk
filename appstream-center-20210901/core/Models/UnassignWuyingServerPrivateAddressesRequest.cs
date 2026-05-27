// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class UnassignWuyingServerPrivateAddressesRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;10.0.0.2&quot;,&quot;10.0.0.3&quot;]</para>
        /// </summary>
        [NameInMap("PrivateIpAddresses")]
        [Validation(Required=false)]
        public List<string> PrivateIpAddresses { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-bp1234567890abcde</para>
        /// </summary>
        [NameInMap("WuyingServerId")]
        [Validation(Required=false)]
        public string WuyingServerId { get; set; }

    }

}
