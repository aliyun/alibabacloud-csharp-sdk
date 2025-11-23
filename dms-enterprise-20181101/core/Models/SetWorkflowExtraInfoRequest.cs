// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class SetWorkflowExtraInfoRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the Sign button is displayed in the ticket approval section of the DMS console for a third-party approval workflow. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): The Sign button is displayed.</description></item>
        /// <item><description><b>false</b>: The Sign button is not displayed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RenderAddApprovalNode")]
        [Validation(Required=false)]
        public bool? RenderAddApprovalNode { get; set; }

        /// <summary>
        /// <para>Specifies whether the Agree button is displayed in the ticket approval section of the DMS console for a third-party approval workflow. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): The Agree button is displayed.</description></item>
        /// <item><description><b>false</b>: The Agree button is not displayed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RenderAgree")]
        [Validation(Required=false)]
        public bool? RenderAgree { get; set; }

        /// <summary>
        /// <para>Specifies whether the Revoke button is displayed in the ticket approval section of the DMS console for a third-party approval workflow. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): The Revoke button is displayed.</description></item>
        /// <item><description><b>false</b>: The Revoke button is not displayed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RenderCancel")]
        [Validation(Required=false)]
        public bool? RenderCancel { get; set; }

        /// <summary>
        /// <para>Specifies whether the Reject button is displayed in the ticket approval section of the DMS console for a third-party approval workflow. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): The Reject button is displayed.</description></item>
        /// <item><description><b>false</b>: The Reject button is not displayed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RenderReject")]
        [Validation(Required=false)]
        public bool? RenderReject { get; set; }

        /// <summary>
        /// <para>Specifies whether the Forward button is displayed in the ticket approval section of the DMS console for a third-party approval workflow. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): The Forward button is displayed.</description></item>
        /// <item><description><b>false</b>: The Forward button is not displayed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RenderTransfer")]
        [Validation(Required=false)]
        public bool? RenderTransfer { get; set; }

        /// <summary>
        /// <para>The remarks of approval workflow for third parties.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ThirdpartyWorkflowComment")]
        [Validation(Required=false)]
        public string ThirdpartyWorkflowComment { get; set; }

        /// <summary>
        /// <para>The link of approval workflow for third parties.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx">https://xxx</a></para>
        /// </summary>
        [NameInMap("ThirdpartyWorkflowUrl")]
        [Validation(Required=false)]
        public string ThirdpartyWorkflowUrl { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para> To view the ID of the tenant, go to the DMS console and move the pointer over the profile picture in the upper-right corner. For more information, see the <a href="https://help.aliyun.com/document_detail/181330.html">View information about the current tenant</a> section of the &quot;Manage DMS tenants&quot; topic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// <para>The ID of the approval workflow. You can call the <a href="https://help.aliyun.com/document_detail/144642.html">GetOrderBaseInfo</a> operation to query the ID of the approval workflow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>184****</para>
        /// </summary>
        [NameInMap("WorkflowInstanceId")]
        [Validation(Required=false)]
        public long? WorkflowInstanceId { get; set; }

    }

}
