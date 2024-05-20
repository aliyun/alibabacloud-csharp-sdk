// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgWhiteListAddOrUpdateRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("WhiteLists")]
        [Validation(Required=false)]
        public List<DsgWhiteListAddOrUpdateRequestWhiteLists> WhiteLists { get; set; }
        public class DsgWhiteListAddOrUpdateRequestWhiteLists : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public int? RuleId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("UserGroupIds")]
            [Validation(Required=false)]
            public List<int?> UserGroupIds { get; set; }

        }

    }

}
