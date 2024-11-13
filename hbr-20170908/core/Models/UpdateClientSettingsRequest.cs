// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpdateClientSettingsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to generate alert for partially completed jobs. This parameter is valid only for on-premises file backup and ECS file backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AlertOnPartialComplete")]
        [Validation(Required=false)]
        public bool? AlertOnPartialComplete { get; set; }

        /// <summary>
        /// <para>The ID of the HBR client.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-*********************</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The type of the endpoint on the data plane. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PUBLIC</b>: Internet</description></item>
        /// <item><description><b>VPC</b>: virtual private cloud (VPC)</description></item>
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
        /// <para>The proxy configuration on the data plane. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DISABLE</b>: The proxy is not used.</description></item>
        /// <item><description><b>USE_CONTROL_PROXY</b> (default): The configuration is the same as that on the control plane.</description></item>
        /// <item><description><b>CUSTOM</b>: The configuration is customized (HTTP).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USE_CONTROL_PROXY</para>
        /// </summary>
        [NameInMap("DataProxySetting")]
        [Validation(Required=false)]
        public string DataProxySetting { get; set; }

        /// <summary>
        /// <para>The number of CPU cores used by a single backup job. The value 0 indicates that the number is unlimited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxCpuCore")]
        [Validation(Required=false)]
        public int? MaxCpuCore { get; set; }

        /// <summary>
        /// <para>The maximum memory that can be used by the client. Unit: bytes. Only V2.13.0 and later are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4096</para>
        /// </summary>
        [NameInMap("MaxMemory")]
        [Validation(Required=false)]
        public long? MaxMemory { get; set; }

        /// <summary>
        /// <para>The number of concurrent backup jobs. The value 0 indicates that the number is unlimited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxWorker")]
        [Validation(Required=false)]
        public int? MaxWorker { get; set; }

        /// <summary>
        /// <para>The custom host IP address of the proxy server on the data plane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.11.100</para>
        /// </summary>
        [NameInMap("ProxyHost")]
        [Validation(Required=false)]
        public string ProxyHost { get; set; }

        /// <summary>
        /// <para>The custom password of the proxy server on the data plane.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ProxyPassword")]
        [Validation(Required=false)]
        public string ProxyPassword { get; set; }

        /// <summary>
        /// <para>The custom host port of the proxy server on the data plane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3128</para>
        /// </summary>
        [NameInMap("ProxyPort")]
        [Validation(Required=false)]
        public int? ProxyPort { get; set; }

        /// <summary>
        /// <para>The custom username of the proxy server on the data plane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("ProxyUser")]
        [Validation(Required=false)]
        public string ProxyUser { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-*********************</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to transmit the data on the data plane over HTTPS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Data is transmitted over HTTPS.</description></item>
        /// <item><description>false: Data is transmitted over HTTP.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseHttps")]
        [Validation(Required=false)]
        public bool? UseHttps { get; set; }

        /// <summary>
        /// <para>The ID of the backup vault. This parameter is required for the old HBR client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-*********************</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
