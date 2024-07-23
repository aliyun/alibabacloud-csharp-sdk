// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SetUserProfilePathRulesRequest : TeaModel {
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
        public List<SetUserProfilePathRulesRequestUserProfilePathRule> UserProfilePathRule { get; set; }
        public class SetUserProfilePathRulesRequestUserProfilePathRule : TeaModel {
            /// <summary>
            /// <para>The directory in the blacklist.</para>
            /// </summary>
            [NameInMap("BlackPath")]
            [Validation(Required=false)]
            public SetUserProfilePathRulesRequestUserProfilePathRuleBlackPath BlackPath { get; set; }
            public class SetUserProfilePathRulesRequestUserProfilePathRuleBlackPath : TeaModel {
                /// <summary>
                /// <para>The blacklist path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AppLocal/Data</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The path type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>file</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>folder</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- --></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>folder</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The directories that you want to configure in the whitelist.</para>
            /// </summary>
            [NameInMap("WhitePaths")]
            [Validation(Required=false)]
            public List<SetUserProfilePathRulesRequestUserProfilePathRuleWhitePaths> WhitePaths { get; set; }
            public class SetUserProfilePathRulesRequestUserProfilePathRuleWhitePaths : TeaModel {
                /// <summary>
                /// <para>The whitelist path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>whitePath</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The path type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>file</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>folder</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- --></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>file</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

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
