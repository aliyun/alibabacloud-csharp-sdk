// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetIntegratedServiceStatusResponseBody : TeaModel {
        [NameInMap("AggregatorDeliveryDataType")]
        [Validation(Required=false)]
        public string AggregatorDeliveryDataType { get; set; }

        /// <summary>
        /// <para>Indicates whether the product has been integrated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public bool? Data { get; set; }

        /// <summary>
        /// <para>The types of the integrated events. Separate multiple event types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ConfigurationItemChangeNotification: resource change event</description></item>
        /// <item><description>NonCompliantNotification: non-compliance event</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NonCompliantNotification</para>
        /// </summary>
        [NameInMap("IntegratedTypes")]
        [Validation(Required=false)]
        public string IntegratedTypes { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2E396C84-8D50-5F95-97FA-C0367181BA8A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
