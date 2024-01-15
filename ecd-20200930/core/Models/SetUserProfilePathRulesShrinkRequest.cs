// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SetUserProfilePathRulesShrinkRequest : TeaModel {
        /// <summary>
        /// The desktop group ID.
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The directories that you want to configure in the blacklist and whitelist.
        /// </summary>
        [NameInMap("UserProfilePathRule")]
        [Validation(Required=false)]
        public string UserProfilePathRuleShrink { get; set; }

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
