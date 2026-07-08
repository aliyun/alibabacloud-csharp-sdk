// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeResourceLogDeliveryStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of log delivery configurations for the protected objects.</para>
        /// </summary>
        [NameInMap("LogConfigs")]
        [Validation(Required=false)]
        public List<DescribeResourceLogDeliveryStatusResponseBodyLogConfigs> LogConfigs { get; set; }
        public class DescribeResourceLogDeliveryStatusResponseBodyLogConfigs : TeaModel {
            /// <summary>
            /// <para>The name of the log delivery configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>export-kafka</para>
            /// </summary>
            [NameInMap("DeliveryName")]
            [Validation(Required=false)]
            public string DeliveryName { get; set; }

            /// <summary>
            /// <para>The type of log delivery for the protected object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>syslog</b>: Logs are delivered to a syslog service.</para>
            /// </description></item>
            /// <item><description><para><b>kafka</b>: Logs are delivered to a Kafka service.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>kafka</para>
            /// </summary>
            [NameInMap("DeliveryType")]
            [Validation(Required=false)]
            public string DeliveryType { get; set; }

            /// <summary>
            /// <para>The name of the protected object, such as a domain name or Application Load Balancer (ALB) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.waf.com-waf</para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// <para>Indicates whether log delivery is enabled for the protected object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Log delivery is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Log delivery is disabled.</para>
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
        /// <para>D7861F61-5B61-46CE-A47C-6B19****5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
