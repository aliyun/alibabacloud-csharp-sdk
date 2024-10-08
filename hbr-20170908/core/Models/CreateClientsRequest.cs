// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateClientsRequest : TeaModel {
        /// <summary>
        /// <para>The alert settings. Valid value: INHERITED, which indicates that the HBR client sends alert notifications by using the same method configured for the backup vault.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INHERITED</para>
        /// </summary>
        [NameInMap("AlertSetting")]
        [Validation(Required=false)]
        public string AlertSetting { get; set; }

        /// <summary>
        /// <para>The installation information of the HBR clients.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[  {    &quot;instanceId&quot;: &quot;i-bp116lr<b><b><b>te9q2&quot;,    &quot;accessKeyId&quot;: &quot;&quot;,    &quot;accessKeySecret&quot;: &quot;&quot;,    &quot;clusterId&quot;: &quot;cl-000csy09q</b></b></b>9rfz9&quot;,    &quot;sourceTypes&quot;: [      &quot;HANA&quot;    ]  },  {    &quot;instanceId&quot;: &quot;i-bp116lrux******hte9q4&quot;,    &quot;accessKeyId&quot;: &quot;&quot;,    &quot;accessKeySecret&quot;: &quot;&quot;,    &quot;clusterId&quot;: &quot;cl-000csy09q5094vw9rfz9&quot;,    &quot;sourceTypes&quot;: [      &quot;HANA&quot;    ]  }]</para>
        /// </summary>
        [NameInMap("ClientInfo")]
        [Validation(Required=false)]
        public string ClientInfo { get; set; }

        /// <summary>
        /// <para>The name of the Resource Access Management (RAM) role that is created within the source Alibaba Cloud account and assigned to the current Alibaba Cloud account to authorize the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbrcrossrole</para>
        /// </summary>
        [NameInMap("CrossAccountRoleName")]
        [Validation(Required=false)]
        public string CrossAccountRoleName { get; set; }

        /// <summary>
        /// <para>The backup type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SELF_ACCOUNT</b>: Data is backed up within the same Alibaba Cloud account.</description></item>
        /// <item><description><b>CROSS_ACCOUNT</b>: Data is backed up across Alibaba Cloud accounts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CROSS_ACCOUNT</para>
        /// </summary>
        [NameInMap("CrossAccountType")]
        [Validation(Required=false)]
        public string CrossAccountType { get; set; }

        /// <summary>
        /// <para>The ID of the source Alibaba Cloud account that authorizes the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>158975xxxxx4625</para>
        /// </summary>
        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzvx7d3c4kpny</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to transmit data over HTTPS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: transmits data over HTTPS.</description></item>
        /// <item><description>false: transmits data over HTTP.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseHttps")]
        [Validation(Required=false)]
        public bool? UseHttps { get; set; }

        /// <summary>
        /// <para>The ID of the backup vault.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-0001ufe******kgm</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
