// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IsvRuleSaveRequest : TeaModel {
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
        public List<IsvRuleSaveRequestBookuserList> BookuserList { get; set; }
        public class IsvRuleSaveRequestBookuserList : TeaModel {
            /// <summary>
            /// <para>The ID of the employee who can be booked for.</para>
            /// <list type="bullet">
            /// <item><description>You can specify up to 300 employee IDs.</description></item>
            /// <item><description>If the number exceeds the limit of 300, you can use <c>entity_type=4</c> to pass values at the department level.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("entity_id")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <para>The scope in which the booking agent permission takes effect.</para>
            /// <list type="bullet">
            /// <item><description>Takes effect only when <c>book_type = bookPerson</c>.</description></item>
            /// <item><description>If this scope is not set, the permission takes effect for all employees by default.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("entity_type")]
            [Validation(Required=false)]
            public int? EntityType { get; set; }

        }

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
