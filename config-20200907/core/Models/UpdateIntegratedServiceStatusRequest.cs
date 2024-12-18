// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class UpdateIntegratedServiceStatusRequest : TeaModel {
        [NameInMap("AggregatorDeliveryDataType")]
        [Validation(Required=false)]
        public string AggregatorDeliveryDataType { get; set; }

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
        /// <para>The identity of the cloud service that is integrated with Cloud Config. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>eventbridge: EventBridge</description></item>
        /// <item><description>cms: CloudMonitor</description></item>
        /// <item><description>bpstudio: Cloud Architect Design Tools</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cadt</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// <para>Specifies whether you want the product to be integrated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public bool? Status { get; set; }

    }

}
