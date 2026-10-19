// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class RestartInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The time when the instance is restarted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediately</b>: The instance is restarted immediately. This is the default value.</description></item>
        /// <item><description><b>MaintainTime</b>: The instance is restarted during the maintenance window.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Immediately</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
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
        /// <para>Specifies whether to upgrade the minor version to the latest version when the instance is restarted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Upgrades the minor version.</description></item>
        /// <item><description><b>false</b>: Does not upgrade the minor version.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UpgradeMinorVersion")]
        [Validation(Required=false)]
        public bool? UpgradeMinorVersion { get; set; }

    }

}
