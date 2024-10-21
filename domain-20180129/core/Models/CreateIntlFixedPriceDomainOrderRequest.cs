// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class CreateIntlFixedPriceDomainOrderRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13350500</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public long? ContactId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>appp16.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>58.00</para>
        /// </summary>
        [NameInMap("ExpectedPrice")]
        [Validation(Required=false)]
        public long? ExpectedPrice { get; set; }

    }

}
