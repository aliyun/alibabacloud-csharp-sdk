// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class PaymentInfo : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("autoRenewDuration")]
        [Validation(Required=false)]
        public long? AutoRenewDuration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isAutoRenew")]
        [Validation(Required=false)]
        public bool? IsAutoRenew { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("pricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

    }

}
