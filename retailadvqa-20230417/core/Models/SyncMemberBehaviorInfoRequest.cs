// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailadvqa20230417.Models
{
    public class SyncMemberBehaviorInfoRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public SyncMemberBehaviorInfoRequestBody Body { get; set; }
        public class SyncMemberBehaviorInfoRequestBody : TeaModel {
            [NameInMap("ActionDuration")]
            [Validation(Required=false)]
            public string ActionDuration { get; set; }

            [NameInMap("ActionEndDate")]
            [Validation(Required=false)]
            public string ActionEndDate { get; set; }

            [NameInMap("ActionResult")]
            [Validation(Required=false)]
            public bool? ActionResult { get; set; }

            [NameInMap("ActionStartDate")]
            [Validation(Required=false)]
            public string ActionStartDate { get; set; }

            [NameInMap("ActionSubType")]
            [Validation(Required=false)]
            public string ActionSubType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("OpenMerchantId")]
            [Validation(Required=false)]
            public string OpenMerchantId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("OuterMemberId")]
            [Validation(Required=false)]
            public string OuterMemberId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("PlatFormType")]
            [Validation(Required=false)]
            public string PlatFormType { get; set; }

        }

    }

}
