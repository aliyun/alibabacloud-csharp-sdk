// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AddNetworkInterfaceToInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to specify the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoStart")]
        [Validation(Required=false)]
        public bool? AutoStart { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourInstance ID</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The network. The value is a JSON string. Only IPv6 is supported. Sample code of an IPv6 network: [{ &quot;ipType&quot;: &quot;public&quot;, &quot;ipAddressType&quot;: &quot;ipv6&quot; }]</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ipType&quot;: &quot;public&quot;, &quot;ipAddressType&quot;: &quot;ipv6&quot; }]</para>
        /// </summary>
        [NameInMap("Networks")]
        [Validation(Required=false)]
        public string Networks { get; set; }

    }

}
