// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListIntegratedServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the integrated services.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListIntegratedServiceResponseBodyData> Data { get; set; }
        public class ListIntegratedServiceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The event type for cross-account integration. Supported event types:</para>
            /// <list type="bullet">
            /// <item><description>NonCompliantNotification: non-compliance events.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NonCompliantNotification</para>
            /// </summary>
            [NameInMap("AggregatorDeliveryDataType")]
            [Validation(Required=false)]
            public string AggregatorDeliveryDataType { get; set; }

            /// <summary>
            /// <para>The event types for the integration. Separate multiple types with commas (,). Supported event types:</para>
            /// <list type="bullet">
            /// <item><description><para>ConfigurationItemChangeNotification: resource change events.</para>
            /// </description></item>
            /// <item><description><para>NonCompliantNotification: non-compliance events.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NonCompliantNotification</para>
            /// </summary>
            [NameInMap("IntegratedTypes")]
            [Validation(Required=false)]
            public string IntegratedTypes { get; set; }

            /// <summary>
            /// <para>The identifier of the integrable Alibaba Cloud service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>eventbridge: EventBridge.</para>
            /// </description></item>
            /// <item><description><para>cms: Cloud Monitor.</para>
            /// </description></item>
            /// <item><description><para>bpstudio: Cloud Architect Design Tools.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cms</para>
            /// </summary>
            [NameInMap("ServiceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

            /// <summary>
            /// <para>The name of the integrated service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>云监控</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The integration status of the Alibaba Cloud service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The service is integrated.</para>
            /// </description></item>
            /// <item><description><para>false: The service is not integrated.</para>
            /// </description></item>
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
