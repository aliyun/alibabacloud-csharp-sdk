// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The billing method of the instance. Valid values: PREPAY: subscription. If you select this billing method, make sure that your account supports balance payment or credit payment. Otherwise, the InvalidPayMethod error is returned. You must also specify the paymentInfo parameter. POSTPAY: pay-as-you-go (currently not supported).</para>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("chargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The list of specification information related to the instance.</para>
        /// </summary>
        [NameInMap("components")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestComponents> Components { get; set; }
        public class CreateInstanceRequestComponents : TeaModel {
            /// <summary>
            /// <para>The specification code, which is consistent with the sales parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>searcherdocsize</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The data entered in the control.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The payment information.</para>
        /// </summary>
        [NameInMap("order")]
        [Validation(Required=false)]
        public CreateInstanceRequestOrder Order { get; set; }
        public class CreateInstanceRequestOrder : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable auto-renewal. Valid values: true and false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("autoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The billing cycle. Valid values: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, and 12.</para>
            /// 
            /// <b>Example:</b>
            /// <para>29</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The unit of the billing cycle. Valid values: Month and Year.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("pricingCycle")]
            [Validation(Required=false)]
            public string PricingCycle { get; set; }

        }

        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestTags> Tags { get; set; }
        public class CreateInstanceRequestTags : TeaModel {
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
