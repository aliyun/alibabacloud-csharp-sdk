// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListIntegratedServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the cloud service that can be integrated.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListIntegratedServiceResponseBodyData> Data { get; set; }
        public class ListIntegratedServiceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The type of the event that is integrated across accounts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NonCompliantNotification: non-compliance event</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NonCompliantNotification</para>
            /// </summary>
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
            /// <para>The identifier of the cloud service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>eventbridge: EventBridge</description></item>
            /// <item><description>cms: CloudMonitor</description></item>
            /// <item><description>bpstudio: Cloud Architect Design Tools</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cms</para>
            /// </summary>
            [NameInMap("ServiceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

            /// <summary>
            /// <para>The name of the cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cms</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The integration status of the cloud service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86DB52A5-0C25-505A-96D5-9BAE1EFA00B9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
