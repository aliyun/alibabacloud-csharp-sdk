// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceProxyConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The key of the <b>configuration item</b> for the database proxy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TransparentSwitch</b>: transparent switchover</description></item>
        /// <item><description><b>PersistentConnections</b>: short-lived connection optimization</description></item>
        /// <item><description><b>AttacksProtection</b>: brute-force attack protection</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TransparentSwitch</para>
        /// </summary>
        [NameInMap("ProxyConfigurationKey")]
        [Validation(Required=false)]
        public string ProxyConfigurationKey { get; set; }

        /// <summary>
        /// <para>The features and status of the database proxy:</para>
        /// <list type="bullet">
        /// <item><description><para><b>TransparentSwitch</b>: transparent switchover. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: The feature is enabled. This is the default value.</description></item>
        /// <item><description><b>Disable</b>: The feature is disabled.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>PersistentConnections</b>: short-lived connection optimization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: The feature is enabled.</description></item>
        /// <item><description><b>Disable</b>: The feature is disabled. This is the default value.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>AttacksProtection</b>: brute-force attack protection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: The feature is enabled.</description></item>
        /// <item><description><b>Disable</b>: The feature is disabled. This is the default value.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>Format: {&quot;Feature 1&quot;:&quot;Status 1&quot;,&quot;Feature 2&quot;:&quot;Status 2&quot;...}</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;status&quot;:&quot;Enable&quot;}</para>
        /// </summary>
        [NameInMap("ProxyConfigurationValue")]
        [Validation(Required=false)]
        public string ProxyConfigurationValue { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
