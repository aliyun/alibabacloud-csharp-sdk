// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class RebootProxyRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1ymwrhvq79zj****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The IDs of the proxy nodes that you want to restart or rebuild. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>90310144,90310144</para>
        /// </summary>
        [NameInMap("ProxyList")]
        [Validation(Required=false)]
        public string ProxyList { get; set; }

        /// <summary>
        /// <para>The IDs of the hosts on which the proxy nodes are deployed. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>36912280,36912282</para>
        /// </summary>
        [NameInMap("ProxyNodeList")]
        [Validation(Required=false)]
        public string ProxyNodeList { get; set; }

        /// <summary>
        /// <para>The type of operation that you want to perform. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>reboot</b>: restarts the proxy node.</description></item>
        /// <item><description><b>rebuild</b>: rebuilds the proxy node.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>reboot</para>
        /// </summary>
        [NameInMap("RebootMode")]
        [Validation(Required=false)]
        public string RebootMode { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
