// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class UpdateWhiteRuleListRequest : TeaModel {
        /// <summary>
        /// <para>The alert whitelist rule. This is a JSON object.</para>
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
        [NameInMap("Expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        /// <summary>
        /// <para>The global unique ID of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
        /// </summary>
        [NameInMap("IncidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        /// <summary>
        /// <para>The region of the Data Management center for threat analysis. Select a region for the Data Management center based on the region of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Your assets are in the Chinese mainland or China (Hong Kong).</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Your assets are outside China.</para>
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
        /// <para>The user ID of the member. This parameter is used when an administrator switches to the perspective of a member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type.</para>
        /// <list type="bullet">
        /// <item><description><para>0: The view of the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>1: The view of all accounts that belong to the enterprise.</para>
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
        /// <para>The unique ID of the whitelist rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("WhiteRuleId")]
        [Validation(Required=false)]
        public long? WhiteRuleId { get; set; }

    }

}
