// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class ConfirmRelationRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud UID of the linked account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1512996702208737</para>
        /// </summary>
        [NameInMap("ChildUserId")]
        [Validation(Required=false)]
        public long? ChildUserId { get; set; }

        /// <summary>
        /// <para>The confirmation action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>child_agree: The linked account agrees.</description></item>
        /// <item><description>child_disagree: The linked account rejects.</description></item>
        /// <item><description>主账号取消确认: The main account cancels the confirmation.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>child_agree</para>
        /// </summary>
        [NameInMap("ConfirmCode")]
        [Validation(Required=false)]
        public string ConfirmCode { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud UID of the main account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1738376485192612</para>
        /// </summary>
        [NameInMap("ParentUserId")]
        [Validation(Required=false)]
        public long? ParentUserId { get; set; }

        /// <summary>
        /// <para>The permissions granted to the linked account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SYNCHRONIZE_FINANCE_IDENTITY: Allows synchronizing the credit-based payment identity to the linked account.</description></item>
        /// <item><description>SYNCHRONIZE_FINANCE_DISCOUNT_POLICY_TO_TARGET: Allows synchronizing discounts to the linked account.</description></item>
        /// <item><description>FORBID_WITHDRAW_CASH: Prohibits the linked account from withdrawing cash from the balance.</description></item>
        /// <item><description>FORBID_MANAGE_INVOICE: Prohibits the linked account from managing invoices.</description></item>
        /// <item><description>CHECK_FINANCE_INFO: Allows requesting to view the account linking information.</description></item>
        /// <item><description>MANAGE_TARGET_INVOICE: Allows managing invoices of the target account.</description></item>
        /// <item><description>CHECK_TARGET_CONSUMPTION: Allows viewing the consumption information of the linked account.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYNCHRONIZE_FINANCE_IDENTITY</para>
        /// </summary>
        [NameInMap("PermissionCodes")]
        [Validation(Required=false)]
        public List<string> PermissionCodes { get; set; }

        /// <summary>
        /// <para>The relationship ID. You can obtain the value from the relationId field in the response of the QueryRelationList operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51463</para>
        /// </summary>
        [NameInMap("RelationId")]
        [Validation(Required=false)]
        public long? RelationId { get; set; }

        /// <summary>
        /// <para>The relationship type. Valid values: enterprise_group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enterprise_group</para>
        /// </summary>
        [NameInMap("RelationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request_id</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
