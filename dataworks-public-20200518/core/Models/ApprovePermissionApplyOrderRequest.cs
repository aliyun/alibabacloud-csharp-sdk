// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ApprovePermissionApplyOrderRequest : TeaModel {
        /// <summary>
        /// <para>The action for the permission request order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: approve</description></item>
        /// <item><description>2: reject</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <list type="bullet">
        /// <item><description>0</description></item>
        /// <item><description>1</description></item>
        /// <item><description>2\.</description></item>
        /// <item><description>3\.</description></item>
        /// <item><description>4</description></item>
        /// <item><description>5</description></item>
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
        /// <para>The comment on the order.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agree</para>
        /// </summary>
        [NameInMap("ApproveComment")]
        [Validation(Required=false)]
        public string ApproveComment { get; set; }

        /// <summary>
        /// <para>The ID of the permission request order. You can call the ListPermissionApplyOrders operation to obtain the order ID.</para>
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
