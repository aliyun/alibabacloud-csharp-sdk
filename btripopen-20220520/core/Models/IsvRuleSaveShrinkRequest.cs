// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IsvRuleSaveShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the current employee needs to submit a travel approval request when making a booking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("apply_need")]
        [Validation(Required=false)]
        public bool? ApplyNeed { get; set; }

        /// <summary>
        /// <para>The type of role permission granted to the employee.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>authorizedPerson</para>
        /// </summary>
        [NameInMap("book_type")]
        [Validation(Required=false)]
        public string BookType { get; set; }

        /// <summary>
        /// <para>The list of users for whom the booking agent permission takes effect.</para>
        /// </summary>
        [NameInMap("bookuser_list")]
        [Validation(Required=false)]
        public string BookuserListShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether the current employee is subject to travel policy restrictions when making a booking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("rule_need")]
        [Validation(Required=false)]
        public bool? RuleNeed { get; set; }

        /// <summary>
        /// <para>Specifies whether the authorization takes effect.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The employee ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_1234</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
