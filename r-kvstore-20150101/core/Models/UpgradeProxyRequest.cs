// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class UpgradeProxyRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1vgja77wl7pb****</para>
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
        /// <para>The IDs of the proxy nodes to upgrade, separated by commas (,). This parameter is valid only for Classic Edition instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1vgja77wl7pb****-proxy-0</para>
        /// </summary>
        [NameInMap("ProxyInstanceIds")]
        [Validation(Required=false)]
        public string ProxyInstanceIds { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The time when the upgrade is performed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediately</b>: The upgrade is immediately performed. This is the default value.</description></item>
        /// <item><description><b>MaintainTime</b>: The upgrade is performed within the O&amp;M window of the instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/473775.html">ModifyInstanceMaintainTime</a> to modify the O&amp;M window of a Redis instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Immediately</para>
        /// </summary>
        [NameInMap("SwitchTimeMode")]
        [Validation(Required=false)]
        public int? SwitchTimeMode { get; set; }

    }

}
