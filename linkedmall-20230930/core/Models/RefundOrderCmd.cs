// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class RefundOrderCmd : TeaModel {
        /// <summary>
        /// <para>The refund reason ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47821</para>
        /// </summary>
        [NameInMap("applyReasonTextId")]
        [Validation(Required=false)]
        public long? ApplyReasonTextId { get; set; }

        /// <summary>
        /// <para>The refund reason text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>I no longer want it</para>
        /// </summary>
        [NameInMap("applyReasonTips")]
        [Validation(Required=false)]
        public string ApplyReasonTips { get; set; }

        /// <summary>
        /// <para>The return quantity.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("applyRefundCount")]
        [Validation(Required=false)]
        public int? ApplyRefundCount { get; set; }

        /// <summary>
        /// <para>The requested refund amount in cents.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("applyRefundFee")]
        [Validation(Required=false)]
        public long? ApplyRefundFee { get; set; }

        /// <summary>
        /// <para>The refund type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Refund only. </description></item>
        /// <item><description>3: Return and refund.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("bizClaimType")]
        [Validation(Required=false)]
        public int? BizClaimType { get; set; }

        /// <summary>
        /// <para>The goods status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>4: Not shipped. </description></item>
        /// <item><description>1: Not received.</description></item>
        /// <item><description>2: Received.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("goodsStatus")]
        [Validation(Required=false)]
        public int? GoodsStatus { get; set; }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>I no longer want it</para>
        /// </summary>
        [NameInMap("leaveMessage")]
        [Validation(Required=false)]
        public string LeaveMessage { get; set; }

        /// <summary>
        /// <para>The image list.</para>
        /// </summary>
        [NameInMap("leavePictureLists")]
        [Validation(Required=false)]
        public List<LeavePictureList> LeavePictureLists { get; set; }

        /// <summary>
        /// <para>The sub-distribution order ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6692****5458</para>
        /// </summary>
        [NameInMap("orderLineId")]
        [Validation(Required=false)]
        public string OrderLineId { get; set; }

    }

}
