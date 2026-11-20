// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreatePickUpWaybillPreQueryShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The recipient information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ConsigneeInfo")]
        [Validation(Required=false)]
        public string ConsigneeInfoShrink { get; set; }

        /// <summary>
        /// <para>The courier company code. If not specified, the system automatically assigns a courier company.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YTO</para>
        /// </summary>
        [NameInMap("CpCode")]
        [Validation(Required=false)]
        public string CpCode { get; set; }

        /// <summary>
        /// <para>The external channel source identifier. The value cannot contain underscores. The value is agreed upon with the system during integration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("OrderChannels")]
        [Validation(Required=false)]
        public string OrderChannels { get; set; }

        /// <summary>
        /// <para>The order number in the caller\&quot;s system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>787DFHHDS989****</para>
        /// </summary>
        [NameInMap("OuterOrderCode")]
        [Validation(Required=false)]
        public string OuterOrderCode { get; set; }

        /// <summary>
        /// <para>The estimated weight, in grams.</para>
        /// <remarks>
        /// <para>If you want to query the estimated price, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("PreWeight")]
        [Validation(Required=false)]
        public string PreWeight { get; set; }

        /// <summary>
        /// <para>The sender information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SenderInfo")]
        [Validation(Required=false)]
        public string SenderInfoShrink { get; set; }

    }

}
