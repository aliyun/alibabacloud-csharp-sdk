// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreatePickUpWaybillPreQueryShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The consignee information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ConsigneeInfo")]
        [Validation(Required=false)]
        public string ConsigneeInfoShrink { get; set; }

        /// <summary>
        /// <para>The code of the courier company. If no courier company is specified, the system allocates a courier company.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YTO</para>
        /// </summary>
        [NameInMap("CpCode")]
        [Validation(Required=false)]
        public string CpCode { get; set; }

        /// <summary>
        /// <para>The identifier of the external channel source. It cannot contain underscores.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("OrderChannels")]
        [Validation(Required=false)]
        public string OrderChannels { get; set; }

        /// <summary>
        /// <para>The order number of the access system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>787DFHHDS989****</para>
        /// </summary>
        [NameInMap("OuterOrderCode")]
        [Validation(Required=false)]
        public string OuterOrderCode { get; set; }

        /// <summary>
        /// <para>The estimated weight. Unit: gram.</para>
        /// <remarks>
        /// <para> If you need to query the estimated price, this parameter is required.</para>
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
