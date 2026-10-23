// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateLogstashChargeTypeRequest : TeaModel {
        /// <summary>
        /// <para>The billing information of the Logstash instance after conversion, including the subscription duration and billing cycle.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;paymentInfo&quot;:{&quot;duration&quot;:1,&quot;pricingCycle&quot;:&quot;Month&quot;},&quot;paymentType&quot;:&quot;prepaid&quot;}</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. The client generates the parameter value. The value must be unique across different requests and can contain a maximum of 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
