// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class PostEventWhiteruleListRequest : TeaModel {
        /// <summary>
        /// <para>The globally unique ID of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
        /// </summary>
        [NameInMap("IncidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        /// <summary>
        /// <para>The region where the threat analysis feature is deployed. Select the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: For assets in the Chinese mainland or China (Hong Kong).</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: For assets in regions outside the Chinese mainland.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of a member account. An administrator can use this parameter to switch to the perspective of the member account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The account scope to which the rule applies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: The current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>1: All accounts within the enterprise.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// <para>The alert whitelisting rule, which is a JSON object.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///       {
        ///             &quot;alertName&quot;: &quot;webshell&quot;,
        ///             &quot;alertNameId&quot;: &quot;webshell&quot;,
        ///             &quot;alertType&quot;: &quot;command&quot;,
        ///             &quot;alertTypeId&quot;: &quot;command&quot;,
        ///             &quot;expression&quot;: {
        ///                   &quot;status&quot;: 1,
        ///                   &quot;conditions&quot;: [
        ///                         {
        ///                               &quot;isNot&quot;: false,
        ///                               &quot;left&quot;: {
        ///                                     &quot;value&quot;: &quot;file_path&quot;
        ///                               },
        ///                               &quot;operator&quot;: &quot;gt&quot;,
        ///                               &quot;right&quot;: {
        ///                                     &quot;value&quot;: &quot;cp&quot;
        ///                               }
        ///                         }
        ///                   ]
        ///             }
        ///       }
        /// ]</para>
        /// </summary>
        [NameInMap("WhiteruleList")]
        [Validation(Required=false)]
        public string WhiteruleList { get; set; }

    }

}
