// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class RefundOrderCmd : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47821</para>
        /// </summary>
        [NameInMap("applyReasonTextId")]
        [Validation(Required=false)]
        public long? ApplyReasonTextId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>不想要了</para>
        /// </summary>
        [NameInMap("applyReasonTips")]
        [Validation(Required=false)]
        public string ApplyReasonTips { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("applyRefundCount")]
        [Validation(Required=false)]
        public int? ApplyRefundCount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("applyRefundFee")]
        [Validation(Required=false)]
        public long? ApplyRefundFee { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("bizClaimType")]
        [Validation(Required=false)]
        public int? BizClaimType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("goodsStatus")]
        [Validation(Required=false)]
        public int? GoodsStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>不想要了</para>
        /// </summary>
        [NameInMap("leaveMessage")]
        [Validation(Required=false)]
        public string LeaveMessage { get; set; }

        [NameInMap("leavePictureLists")]
        [Validation(Required=false)]
        public List<LeavePictureList> LeavePictureLists { get; set; }

        /// <summary>
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
