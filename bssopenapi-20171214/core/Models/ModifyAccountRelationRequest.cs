// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class ModifyAccountRelationRequest : TeaModel {
        /// <summary>
        /// <para>The display name of the member. This helps clarify the scenario in which the account is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Display name of the member</para>
        /// </summary>
        [NameInMap("ChildNick")]
        [Validation(Required=false)]
        public string ChildNick { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that is used as the member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1512996702208737</para>
        /// </summary>
        [NameInMap("ChildUserId")]
        [Validation(Required=false)]
        public long? ChildUserId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that is used as the management account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1738376485192612</para>
        /// </summary>
        [NameInMap("ParentUserId")]
        [Validation(Required=false)]
        public long? ParentUserId { get; set; }

        /// <summary>
        /// <para>The permissions that can be modified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SYNCHRONIZE_FINANCE_IDENTITY: allows the credit control identity to be shared with the member.</description></item>
        /// <item><description>SYNCHRONIZE_FINANCE_DISCOUNT_POLICY_TO_TARGET: allows the discount policy to be shared with the member.</description></item>
        /// <item><description>FORBID_WITHDRAW_CASH: does not allow the member to withdraw the balance.</description></item>
        /// <item><description>FORBID_MANAGE_INVOICE: does not allow the member to manage invoices.</description></item>
        /// <item><description>CHECK_FINANCE_INFO: requests to view information about the financial relationship.</description></item>
        /// <item><description>MANAGE_TARGET_INVOICE: allows the member to manage invoices.</description></item>
        /// <item><description>CHECK_TARGET_CONSUMPTION: allows the member to view the bills.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SYNCHRONIZE_FINANCE_IDENTITY</para>
        /// </summary>
        [NameInMap("PermissionCodes")]
        [Validation(Required=false)]
        public List<string> PermissionCodes { get; set; }

        /// <summary>
        /// <para>The ID of the financial relationship. Set this parameter to the value of the relationId response parameter returned by calling the QueryRelationList operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51463</para>
        /// </summary>
        [NameInMap("RelationId")]
        [Validation(Required=false)]
        public long? RelationId { get; set; }

        /// <summary>
        /// <para>The operation to be performed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ADD</description></item>
        /// <item><description>DELETE</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADD</para>
        /// </summary>
        [NameInMap("RelationOperation")]
        [Validation(Required=false)]
        public string RelationOperation { get; set; }

        /// <summary>
        /// <para>The type of the financial relationship. Set the value to enterprise_group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enterprise_group</para>
        /// </summary>
        [NameInMap("RelationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. The ID is used to mark a request and troubleshoot a problem.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request_id</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The roles that can be assigned to the member. You cannot modify the roles.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trusteeship</para>
        /// </summary>
        [NameInMap("RoleCodes")]
        [Validation(Required=false)]
        public List<string> RoleCodes { get; set; }

    }

}
