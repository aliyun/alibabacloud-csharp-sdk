// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SetUserProfilePathRulesRequest : TeaModel {
        /// <summary>
        /// The desktop group ID.
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The directories that you want to configure in the blacklist and whitelist.
        /// </summary>
        [NameInMap("UserProfilePathRule")]
        [Validation(Required=false)]
        public List<SetUserProfilePathRulesRequestUserProfilePathRule> UserProfilePathRule { get; set; }
        public class SetUserProfilePathRulesRequestUserProfilePathRule : TeaModel {
            /// <summary>
            /// The directory in the blacklist.
            /// </summary>
            [NameInMap("BlackPath")]
            [Validation(Required=false)]
            public SetUserProfilePathRulesRequestUserProfilePathRuleBlackPath BlackPath { get; set; }
            public class SetUserProfilePathRulesRequestUserProfilePathRuleBlackPath : TeaModel {
                /// <summary>
                /// The blacklist path.
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
            /// The directories that you want to configure in the whitelist.
            /// </summary>
            [NameInMap("WhitePaths")]
            [Validation(Required=false)]
            public List<SetUserProfilePathRulesRequestUserProfilePathRuleWhitePaths> WhitePaths { get; set; }
            public class SetUserProfilePathRulesRequestUserProfilePathRuleWhitePaths : TeaModel {
                /// <summary>
                /// The whitelist path.
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
        /// The directory type that you want to configure.
        /// 
        /// Valid values:
        /// 
        /// *   Both_Default_DesktopGroup
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
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
