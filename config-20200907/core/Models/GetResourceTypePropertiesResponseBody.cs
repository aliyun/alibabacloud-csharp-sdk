// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetResourceTypePropertiesResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///     {
        ///       &quot;description&quot;: &quot;The ID of the resource group to which the instance belongs.\n&quot;,
        ///       &quot;title&quot;: &quot;ResourceGroupId&quot;,
        ///       &quot;type&quot;: &quot;String&quot;,
        ///       &quot;key&quot;: &quot;ResourceGroupId&quot;,
        ///       &quot;example&quot;: &quot;rg-bp67acfmxazb4p****&quot;
        ///     },
        ///     {
        ///       &quot;description&quot;: &quot;The billing method of the instance. Valid values:\n\n*   PrePaid: subscription\n*   PostPaid: pay-as-you-go\n&quot;,
        ///       &quot;title&quot;: &quot;InstanceChargeType&quot;,
        ///       &quot;type&quot;: &quot;String&quot;,
        ///       &quot;key&quot;: &quot;InstanceChargeType&quot;,
        ///       &quot;example&quot;: &quot;PostPaid&quot;
        ///     }]</para>
        /// </summary>
        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public string Configuration { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0C2868BF-47EE-5441-B34B-17F080B10DC7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
