// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class SetWorkflowExtraInfoRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RenderAddApprovalNode")]
        [Validation(Required=false)]
        public bool? RenderAddApprovalNode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RenderAgree")]
        [Validation(Required=false)]
        public bool? RenderAgree { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RenderCancel")]
        [Validation(Required=false)]
        public bool? RenderCancel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RenderReject")]
        [Validation(Required=false)]
        public bool? RenderReject { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RenderTransfer")]
        [Validation(Required=false)]
        public bool? RenderTransfer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ThirdpartyWorkflowComment")]
        [Validation(Required=false)]
        public string ThirdpartyWorkflowComment { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://xxx">https://xxx</a></para>
        /// </summary>
        [NameInMap("ThirdpartyWorkflowUrl")]
        [Validation(Required=false)]
        public string ThirdpartyWorkflowUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
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
