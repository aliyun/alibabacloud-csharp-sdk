// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class GetCustomerOrderListShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test_123</para>
        /// </summary>
        [NameInMap("CustomerAccount")]
        [Validation(Required=false)]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("CustomerUid")]
        [Validation(Required=false)]
        public long? CustomerUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1727789348000</para>
        /// </summary>
        [NameInMap("OrderCreateAfter")]
        [Validation(Required=false)]
        public long? OrderCreateAfter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1741008566000</para>
        /// </summary>
        [NameInMap("OrderCreateBefore")]
        [Validation(Required=false)]
        public long? OrderCreateBefore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13595216</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1727789348000</para>
        /// </summary>
        [NameInMap("OrderPayAfter")]
        [Validation(Required=false)]
        public long? OrderPayAfter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1741008566000</para>
        /// </summary>
        [NameInMap("OrderPayBefore")]
        [Validation(Required=false)]
        public long? OrderPayBefore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("OrderStatus")]
        [Validation(Required=false)]
        public int? OrderStatus { get; set; }

        [NameInMap("OrderTypeList")]
        [Validation(Required=false)]
        public string OrderTypeListShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PayAmountAfter")]
        [Validation(Required=false)]
        public double? PayAmountAfter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("PayAmountBefore")]
        [Validation(Required=false)]
        public double? PayAmountBefore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public int? PayType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>202502002231</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234532</para>
        /// </summary>
        [NameInMap("RamAccountForCustomerManager")]
        [Validation(Required=false)]
        public string RamAccountForCustomerManager { get; set; }

    }

}
