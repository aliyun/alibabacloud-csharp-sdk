// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IsvRuleSaveShrinkRequest : TeaModel {
        [NameInMap("apply_need")]
        [Validation(Required=false)]
        public bool? ApplyNeed { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("book_type")]
        [Validation(Required=false)]
        public string BookType { get; set; }

        [NameInMap("bookuser_list")]
        [Validation(Required=false)]
        public string BookuserListShrink { get; set; }

        [NameInMap("rule_need")]
        [Validation(Required=false)]
        public bool? RuleNeed { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
