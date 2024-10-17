// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ApproveOrderRequest : TeaModel {
        /// <summary>
        /// <para>If ApprovalType is set to ADD_APPROVAL_NODE, you need to specify this parameter. The ID of the user that is added as the new approval node. This node must be a user-defined approval node. You can call the ListUserDefineWorkFlowNodes operation to obtain the value of this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ApprovalNodeId")]
        [Validation(Required=false)]
        public long? ApprovalNodeId { get; set; }

        /// <summary>
        /// <para>The position of the new approval node. You must specify this parameter if ApprovalType is set to ADD_APPROVAL_NODE. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PRE_ADD_APPROVAL_NODE</b>: before the current approval node.</description></item>
        /// <item><description><b>POST_ADD_APPROVAL_NODE</b>: after the current approval node.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>POST_ADD_APPROVAL_NODE</para>
        /// </summary>
        [NameInMap("ApprovalNodePos")]
        [Validation(Required=false)]
        public string ApprovalNodePos { get; set; }

        /// <summary>
        /// <para>The action that you want to perform on the ticket. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AGREE</b></description></item>
        /// <item><description><b>CANCEL</b></description></item>
        /// <item><description><b>REJECT</b></description></item>
        /// <item><description><b>TRANSFER</b></description></item>
        /// <item><description><b>ADD_APPROVAL_NODE</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agree</para>
        /// </summary>
        [NameInMap("ApprovalType")]
        [Validation(Required=false)]
        public string ApprovalType { get; set; }

        /// <summary>
        /// <para>The description of the ticket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The ID of the user to which the ticket is transferred. If ApprovalType is set to TRANSFER, you need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12***</para>
        /// </summary>
        [NameInMap("NewApprover")]
        [Validation(Required=false)]
        public long? NewApprover { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> You can specify this parameter if ApprovalType is set to TRANSFER. You need to only specify one of NewApproverList and NewApprover.</para>
        /// </remarks>
        /// <para>The IDs of the users to whom the ticket is transferred. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>154***,155***,156***</para>
        /// </summary>
        [NameInMap("NewApproverList")]
        [Validation(Required=false)]
        public string NewApproverList { get; set; }

        /// <summary>
        /// <para>The ID of the user that transfers the ticket to another user. The default value is the ID of the current user. If the current user is an administrator or a database administrator (DBA), the user can change the value of this parameter to the ID of another user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23***</para>
        /// </summary>
        [NameInMap("OldApprover")]
        [Validation(Required=false)]
        public long? OldApprover { get; set; }

        /// <summary>
        /// <para>The UID of the Alibaba Cloud account that actually calls the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21400447956867****</para>
        /// </summary>
        [NameInMap("RealLoginUserUid")]
        [Validation(Required=false)]
        public string RealLoginUserUid { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> operation to obtain the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// <para>The ID of the approval process. You can call the <a href="https://help.aliyun.com/document_detail/144642.html">GetOrderBaseInfo</a> operation to obtain the ID of the approval process.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("WorkflowInstanceId")]
        [Validation(Required=false)]
        public long? WorkflowInstanceId { get; set; }

    }

}
