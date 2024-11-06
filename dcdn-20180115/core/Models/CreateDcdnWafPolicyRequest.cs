// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CreateDcdnWafPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The type of the WAF protection policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>waf_group: basic web protection</description></item>
        /// <item><description>custom_acl: custom protection</description></item>
        /// <item><description>whitelist: IP address whitelist</description></item>
        /// <item><description>ip_blacklist: IP address blacklist</description></item>
        /// <item><description>region_block: region blacklist</description></item>
        /// <item><description>bot: bot management</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_group</para>
        /// </summary>
        [NameInMap("DefenseScene")]
        [Validation(Required=false)]
        public string DefenseScene { get; set; }

        /// <summary>
        /// <para>The name of the protection policy. The name can be up to 64 characters in length and can contain letters, digits, and underscores (_).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy_test</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The status of the protection policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: The policy is enabled.</description></item>
        /// <item><description>off: The policy is disabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("PolicyStatus")]
        [Validation(Required=false)]
        public string PolicyStatus { get; set; }

        /// <summary>
        /// <para>Specifies whether to set the current policy as the default policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>default: sets the current policy as the default policy.</description></item>
        /// <item><description>custom: does not set the current policy as the default policy.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

    }

}
