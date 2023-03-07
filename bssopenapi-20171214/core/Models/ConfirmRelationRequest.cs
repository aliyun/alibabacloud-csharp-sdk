// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class ConfirmRelationRequest : TeaModel {
        /// <summary>
        /// The ID of the Alibaba Cloud account that is used as the member.
        /// </summary>
        [NameInMap("ChildUserId")]
        [Validation(Required=false)]
        public long? ChildUserId { get; set; }

        /// <summary>
        /// The operation to be performed to confirm the invitation. Valid values:
        /// 
        /// *   child_agree: The member accepts the invitation.
        /// *   child_disagree: The member rejects the invitation.
        /// *   Canceled by the master account: The management account cancels the confirmation.
        /// </summary>
        [NameInMap("ConfirmCode")]
        [Validation(Required=false)]
        public string ConfirmCode { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account that is used as the management account.
        /// </summary>
        [NameInMap("ParentUserId")]
        [Validation(Required=false)]
        public long? ParentUserId { get; set; }

        /// <summary>
        /// The permissions that can be granted to the member. Valid values:
        /// 
        /// *   SYNCHRONIZE_FINANCE_IDENTITY: allows the credit control identity to be shared with the member.
        /// *   SYNCHRONIZE_FINANCE_DISCOUNT_POLICY_TO_TARGET: allows the discount policy to be shared with the member.
        /// *   FORBID_WITHDRAW_CASH: does not allow the member to withdraw the balance.
        /// *   FORBID_MANAGE_INVOICE: does not allow the member to manage invoices.
        /// *   CHECK_FINANCE_INFO: requests to view information about the financial relationship.
        /// *   MANAGE_TARGET_INVOICE: allows the member to manage invoices.
        /// *   CHECK_TARGET_CONSUMPTION: allows the member to view the bills.
        /// </summary>
        [NameInMap("PermissionCodes")]
        [Validation(Required=false)]
        public List<string> PermissionCodes { get; set; }

        /// <summary>
        /// The ID of the financial relationship. Set this parameter to the value of the RelationId response parameter returned by calling the QueryRelationList operation.
        /// </summary>
        [NameInMap("RelationId")]
        [Validation(Required=false)]
        public long? RelationId { get; set; }

        /// <summary>
        /// The type of the financial relationship. Set the value to enterprise_group.
        /// </summary>
        [NameInMap("RelationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        /// <summary>
        /// The unique ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
