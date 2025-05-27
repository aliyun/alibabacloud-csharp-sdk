// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class UpdateWhiteRuleListRequest : TeaModel {
        /// <summary>
        /// <para>The alert whitelist rule. The value is a JSON object.</para>
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
        /// <para>The UUID of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
        /// </summary>
        [NameInMap("IncidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        /// <summary>
        /// <para>The region in which the data management center of the threat analysis feature resides. Specify this parameter based on the regions in which your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Your assets reside in regions in China.</description></item>
        /// <item><description>ap-southeast-1: Your assets reside in regions outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

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
