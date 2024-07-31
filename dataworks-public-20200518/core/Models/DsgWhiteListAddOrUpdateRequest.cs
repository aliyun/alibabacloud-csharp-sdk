// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgWhiteListAddOrUpdateRequest : TeaModel {
        /// <summary>
        /// A collection of whitelists.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("WhiteLists")]
        [Validation(Required=false)]
        public List<DsgWhiteListAddOrUpdateRequestWhiteLists> WhiteLists { get; set; }
        public class DsgWhiteListAddOrUpdateRequestWhiteLists : TeaModel {
            /// <summary>
            /// The end of the time range to query. If you enter null, the whitelist is valid permanently.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The ID of the data masking whitelist.
            /// 
            /// *   If you do not configure this parameter, the current operation is to add a data masking whitelist.
            /// *   If you configure this parameter, the current operation is to modify a data masking whitelist. You can call the [DsgWhiteListQueryList](https://help.aliyun.com/document_detail/2786508.html) operation to query the whitelist ID.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// The ID of the data masking rule. You can call the [DsgDesensPlanQueryList](https://help.aliyun.com/document_detail/2786578.html) operation to query the ID of the data masking rule.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public int? RuleId { get; set; }

            /// <summary>
            /// The beginning of the time range to query.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// A collection of user group IDs.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("UserGroupIds")]
            [Validation(Required=false)]
            public List<int?> UserGroupIds { get; set; }

        }

    }

}
