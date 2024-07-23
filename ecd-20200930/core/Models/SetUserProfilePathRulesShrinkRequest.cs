// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SetUserProfilePathRulesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The desktop group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dg-2i8qxpv6t1a03****</para>
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The directories that you want to configure in the blacklist and whitelist.</para>
        /// </summary>
        [NameInMap("UserProfilePathRule")]
        [Validation(Required=false)]
        public string UserProfilePathRuleShrink { get; set; }

        /// <summary>
        /// <para>The directory type that you want to configure.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Both_Default_DesktopGroup</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>DesktopGroup</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Default</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DesktopGroup</para>
        /// </summary>
        [NameInMap("UserProfileRuleType")]
        [Validation(Required=false)]
        public string UserProfileRuleType { get; set; }

    }

}
