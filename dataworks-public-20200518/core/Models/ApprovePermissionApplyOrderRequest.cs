// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ApprovePermissionApplyOrderRequest : TeaModel {
        /// <summary>
        /// <para>The approval action to perform. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Approve.</description></item>
        /// <item><description>2: Reject.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ApproveAction")]
        [Validation(Required=false)]
        public int? ApproveAction { get; set; }

        /// <summary>
        /// <para>The remarks for the approval.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agree</para>
        /// </summary>
        [NameInMap("ApproveComment")]
        [Validation(Required=false)]
        public string ApproveComment { get; set; }

        /// <summary>
        /// <para>The ID of the permission request order to approve. You can call the <a href="https://help.aliyun.com/document_detail/211008.html">ListPermissionApplyOrders</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48f36729-05f9-4a40-9286-933fd940f30a</para>
        /// </summary>
        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

    }

}
