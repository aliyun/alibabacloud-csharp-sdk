// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class TicketApplyRefundRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("AccountNo")]
        [Validation(Required=false)]
        public long? AccountNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("DistributorOrderId")]
        [Validation(Required=false)]
        public string DistributorOrderId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>计划有变</para>
        /// </summary>
        [NameInMap("RefundReason")]
        [Validation(Required=false)]
        public string RefundReason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>档期冲突</para>
        /// </summary>
        [NameInMap("RefundRemark")]
        [Validation(Required=false)]
        public string RefundRemark { get; set; }

    }

}
