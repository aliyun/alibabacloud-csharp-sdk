// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class ModifyAccountRelationRequest : TeaModel {
        /// <summary>
        /// <para>The display name. This name is shown on the page to help you identify the use case of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用户昵称</para>
        /// </summary>
        [NameInMap("ChildNick")]
        [Validation(Required=false)]
        public string ChildNick { get; set; }

        /// <summary>
        /// <para>The UID of the member account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1512996702208737</para>
        /// </summary>
        [NameInMap("ChildUserId")]
        [Validation(Required=false)]
        public long? ChildUserId { get; set; }

        /// <summary>
        /// <para>The UID of the Alibaba Cloud account.</para>
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
        /// <item><description><para>SYNCHRONIZE_FINANCE_IDENTITY: Allow synchronizing the credit control identity with the linked account.</para>
        /// </description></item>
        /// <item><description><para>SYNCHRONIZE_FINANCE_DISCOUNT_POLICY_TO_TARGET: Allow synchronizing discounts with the linked account.</para>
        /// </description></item>
        /// <item><description><para>FORBID_WITHDRAW_CASH: Prohibit the linked account from withdrawing its balance.</para>
        /// </description></item>
        /// <item><description><para>FORBID_MANAGE_INVOICE: Prohibit the linked account from managing invoices.</para>
        /// </description></item>
        /// <item><description><para>CHECK_FINANCE_INFO: View information about the account linking relationship.</para>
        /// </description></item>
        /// <item><description><para>MANAGE_TARGET_INVOICE: Manage invoices for the linked account.</para>
        /// </description></item>
        /// <item><description><para>CHECK_TARGET_CONSUMPTION: View the consumption details of the linked account.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SYNCHRONIZE_FINANCE_IDENTITY</para>
        /// </summary>
        [NameInMap("PermissionCodes")]
        [Validation(Required=false)]
        public List<string> PermissionCodes { get; set; }

        /// <summary>
        /// <para>The relationship ID. Obtain this value from the relationId field returned by the QueryRelationList operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51463</para>
        /// </summary>
        [NameInMap("RelationId")]
        [Validation(Required=false)]
        public long? RelationId { get; set; }

        /// <summary>
        /// <para>The action to perform. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ADD: Adds the permission.</para>
        /// </description></item>
        /// <item><description><para>DELETE: Deletes the permission.</para>
        /// </description></item>
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
        /// <para>The relationship type. Currently, only enterprise_group is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enterprise_group</para>
        /// </summary>
        [NameInMap("RelationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. This ID is used to mark a request and troubleshoot issues.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request_id</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Modifying roles is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trusteeship</para>
        /// </summary>
        [NameInMap("RoleCodes")]
        [Validation(Required=false)]
        public List<string> RoleCodes { get; set; }

    }

}
