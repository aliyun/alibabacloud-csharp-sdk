// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeUserProfilePathRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A87DBB05-653A-5E4B-B72B-5F4A1E07****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The directory blacklist and whitelist.</para>
        /// </summary>
        [NameInMap("UserProfilePathRule")]
        [Validation(Required=false)]
        public DescribeUserProfilePathRulesResponseBodyUserProfilePathRule UserProfilePathRule { get; set; }
        public class DescribeUserProfilePathRulesResponseBodyUserProfilePathRule : TeaModel {
            /// <summary>
            /// <para>The desktop group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dg-4i8fvpv6tfs03****</para>
            /// </summary>
            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            /// <summary>
            /// <para>The directory rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeUserProfilePathRulesResponseBodyUserProfilePathRuleRules> Rules { get; set; }
            public class DescribeUserProfilePathRulesResponseBodyUserProfilePathRuleRules : TeaModel {
                /// <summary>
                /// <para>The blacklist that is configured.</para>
                /// </summary>
                [NameInMap("BlackPath")]
                [Validation(Required=false)]
                public DescribeUserProfilePathRulesResponseBodyUserProfilePathRuleRulesBlackPath BlackPath { get; set; }
                public class DescribeUserProfilePathRulesResponseBodyUserProfilePathRuleRulesBlackPath : TeaModel {
                    /// <summary>
                    /// <para>The path.</para>
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
                    /// <para>file</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The directories in the whitelist.</para>
                /// </summary>
                [NameInMap("WhitePaths")]
                [Validation(Required=false)]
                public List<DescribeUserProfilePathRulesResponseBodyUserProfilePathRuleRulesWhitePaths> WhitePaths { get; set; }
                public class DescribeUserProfilePathRulesResponseBodyUserProfilePathRuleRulesWhitePaths : TeaModel {
                    /// <summary>
                    /// <para>The path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>games</para>
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

            }

            /// <summary>
            /// <para>The directory type that is configured for the directory.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
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
            /// <para>Default</para>
            /// </summary>
            [NameInMap("UserProfileRuleType")]
            [Validation(Required=false)]
            public string UserProfileRuleType { get; set; }

        }

    }

}
