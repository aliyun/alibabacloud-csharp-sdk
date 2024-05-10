// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IsvRuleSaveRequest : TeaModel {
        [NameInMap("apply_need")]
        [Validation(Required=false)]
        public bool? ApplyNeed { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("book_type")]
        [Validation(Required=false)]
        public string BookType { get; set; }

        [NameInMap("bookuser_list")]
        [Validation(Required=false)]
        public List<IsvRuleSaveRequestBookuserList> BookuserList { get; set; }
        public class IsvRuleSaveRequestBookuserList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("entity_id")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("entity_type")]
            [Validation(Required=false)]
            public int? EntityType { get; set; }

        }

        [NameInMap("rule_need")]
        [Validation(Required=false)]
        public bool? RuleNeed { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
