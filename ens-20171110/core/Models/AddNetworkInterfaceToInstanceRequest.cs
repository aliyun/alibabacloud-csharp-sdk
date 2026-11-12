// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AddNetworkInterfaceToInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically restart the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoStart")]
        [Validation(Required=false)]
        public bool? AutoStart { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourInstance ID</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The network parameters in JSON string format. Currently, only IPv6 is supported. An example of adding an IPv6 gateway is as follows:
        /// [{&quot;ipType&quot;: &quot;public&quot;, &quot;ipAddressType&quot;: &quot;ipv6&quot;}]</para>
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
