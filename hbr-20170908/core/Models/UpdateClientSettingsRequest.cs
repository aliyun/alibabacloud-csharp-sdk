// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpdateClientSettingsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to trigger an alert for partially completed jobs. This parameter takes effect only for local File Backup and ECS File Backup Essential Edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AlertOnPartialComplete")]
        [Validation(Required=false)]
        public bool? AlertOnPartialComplete { get; set; }

        /// <summary>
        /// <para>The backup client ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-*********************</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The data plane access point type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PUBLIC</b>: public network</description></item>
        /// <item><description><b>VPC</b>: VPC network</description></item>
        /// <item><description><b>CLASSIC</b>: classic network</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("DataNetworkType")]
        [Validation(Required=false)]
        public string DataNetworkType { get; set; }

        /// <summary>
        /// <para>The data plane proxy setting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DISABLE</b>: does not use a proxy.</description></item>
        /// <item><description><b>USE_CONTROL_PROXY</b> (default): uses the same configuration as the control plane.</description></item>
        /// <item><description><b>CUSTOM</b>: uses a custom configuration (HTTP protocol).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USE_CONTROL_PROXY</para>
        /// </summary>
        [NameInMap("DataProxySetting")]
        [Validation(Required=false)]
        public string DataProxySetting { get; set; }

        /// <summary>
        /// <para>The number of CPU cores used by a single backup job. A value of 0 indicates no limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxCpuCore")]
        [Validation(Required=false)]
        public int? MaxCpuCore { get; set; }

        /// <summary>
        /// <para>The maximum memory that the client can use, in bytes. Only version 2.13.0 and later are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4096</para>
        /// </summary>
        [NameInMap("MaxMemory")]
        [Validation(Required=false)]
        public long? MaxMemory { get; set; }

        /// <summary>
        /// <para>The number of concurrent workers for a single backup job. A value of 0 indicates no limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxWorker")]
        [Validation(Required=false)]
        public int? MaxWorker { get; set; }

        /// <summary>
        /// <para>The IP address of the custom data plane proxy server host.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.11.100</para>
        /// </summary>
        [NameInMap("ProxyHost")]
        [Validation(Required=false)]
        public string ProxyHost { get; set; }

        /// <summary>
        /// <para>The password of the custom data plane proxy server.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ProxyPassword")]
        [Validation(Required=false)]
        public string ProxyPassword { get; set; }

        /// <summary>
        /// <para>The port of the custom data plane proxy server host.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3128</para>
        /// </summary>
        [NameInMap("ProxyPort")]
        [Validation(Required=false)]
        public int? ProxyPort { get; set; }

        /// <summary>
        /// <para>The username of the custom data plane proxy server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("ProxyUser")]
        [Validation(Required=false)]
        public string ProxyUser { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-*********************</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use HTTPS to transmit data plane data.</para>
        /// <list type="bullet">
        /// <item><description>true: Uses HTTPS for transmission.</description></item>
        /// <item><description>false: Uses HTTP for transmission.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseHttps")]
        [Validation(Required=false)]
        public bool? UseHttps { get; set; }

        /// <summary>
        /// <para>The backup vault ID. This parameter is required for legacy clients.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-*********************</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
