// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeUserProfilePathRulesResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The directory blacklist and whitelist.
        /// </summary>
        [NameInMap("UserProfilePathRule")]
        [Validation(Required=false)]
        public DescribeUserProfilePathRulesResponseBodyUserProfilePathRule UserProfilePathRule { get; set; }
        public class DescribeUserProfilePathRulesResponseBodyUserProfilePathRule : TeaModel {
            /// <summary>
            /// The desktop group ID.
            /// </summary>
            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            /// <summary>
            /// The directory rules.
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeUserProfilePathRulesResponseBodyUserProfilePathRuleRules> Rules { get; set; }
            public class DescribeUserProfilePathRulesResponseBodyUserProfilePathRuleRules : TeaModel {
                /// <summary>
                /// The blacklist that is configured.
                /// </summary>
                [NameInMap("BlackPath")]
                [Validation(Required=false)]
                public DescribeUserProfilePathRulesResponseBodyUserProfilePathRuleRulesBlackPath BlackPath { get; set; }
                public class DescribeUserProfilePathRulesResponseBodyUserProfilePathRuleRulesBlackPath : TeaModel {
                    /// <summary>
                    /// The path.
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// The path type.
                    /// 
                    /// Valid values:
                    /// 
                    /// *   file
                    /// 
                    ///     <!-- -->
                    /// 
                    ///     <!-- -->
                    /// 
                    ///     <!-- -->
                    /// 
                    /// *   folder
                    /// 
                    ///     <!-- -->
                    /// 
                    ///     <!-- -->
                    /// 
                    ///     <!-- -->
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// The directories in the whitelist.
                /// </summary>
                [NameInMap("WhitePaths")]
                [Validation(Required=false)]
                public List<DescribeUserProfilePathRulesResponseBodyUserProfilePathRuleRulesWhitePaths> WhitePaths { get; set; }
                public class DescribeUserProfilePathRulesResponseBodyUserProfilePathRuleRulesWhitePaths : TeaModel {
                    /// <summary>
                    /// The path.
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// The path type.
                    /// 
                    /// Valid values:
                    /// 
                    /// *   file
                    /// 
                    ///     <!-- -->
                    /// 
                    ///     <!-- -->
                    /// 
                    ///     <!-- -->
                    /// 
                    /// *   folder
                    /// 
                    ///     <!-- -->
                    /// 
                    ///     <!-- -->
                    /// 
                    ///     <!-- -->
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// The directory type that is configured for the directory.
            /// 
            /// Valid values:
            /// 
            /// *   DesktopGroup
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Default
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("UserProfileRuleType")]
            [Validation(Required=false)]
            public string UserProfileRuleType { get; set; }

        }

    }

}
