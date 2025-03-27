// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyNodePoolAmountRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the delivery group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The parameters related to the configuration change of the node pool.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodePool")]
        [Validation(Required=false)]
        public ModifyNodePoolAmountRequestNodePool NodePool { get; set; }
        public class ModifyNodePoolAmountRequestNodePool : TeaModel {
            /// <summary>
            /// <para>The total number of subscription nodes after the change.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            /// <summary>
            /// <para>The change mode of subscription nodes.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>EXPAND_FROM_POST_PAID_EXPLICIT: changes from specified pay-as-you-go nodes</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EXPAND_FROM_POST_PAID_EXPLICIT</para>
            /// </summary>
            [NameInMap("PrePaidNodeAmountModifyMode")]
            [Validation(Required=false)]
            public string PrePaidNodeAmountModifyMode { get; set; }

            /// <summary>
            /// <para>The nodes for which you want to change the billing method.</para>
            /// </summary>
            [NameInMap("PrePaidNodeAmountModifyNodeIds")]
            [Validation(Required=false)]
            public List<string> PrePaidNodeAmountModifyNodeIds { get; set; }

        }

        /// <summary>
        /// <para>The product type.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: App Streaming</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
