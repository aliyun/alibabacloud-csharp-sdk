// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class OrderResult : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-09-01T12:00:00.000Z</para>
        /// </summary>
        [NameInMap("createDate")]
        [Validation(Required=false)]
        public string CreateDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12****01</para>
        /// </summary>
        [NameInMap("distributorId")]
        [Validation(Required=false)]
        public string DistributorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("logisticsStatus")]
        [Validation(Required=false)]
        public string LogisticsStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("orderAmount")]
        [Validation(Required=false)]
        public long? OrderAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>系统关单</para>
        /// </summary>
        [NameInMap("orderClosedReason")]
        [Validation(Required=false)]
        public string OrderClosedReason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6692****5457</para>
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("orderLineList")]
        [Validation(Required=false)]
        public List<OrderLineResult> OrderLineList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("orderStatus")]
        [Validation(Required=false)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D12***111</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
