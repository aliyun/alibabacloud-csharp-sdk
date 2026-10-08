// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class CreateIntlFixedPriceDomainOrderRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false (default): manual payment.</para>
        /// </description></item>
        /// <item><description><para>true: automatic payment.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The contact ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13350500</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public long? ContactId { get; set; }

        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>appp16.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The expected price.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58.00</para>
        /// </summary>
        [NameInMap("ExpectedPrice")]
        [Validation(Required=false)]
        public long? ExpectedPrice { get; set; }

        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public int? ProductType { get; set; }

    }

}
