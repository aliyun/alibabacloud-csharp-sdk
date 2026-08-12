// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeResourceLogDeliveryStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of log delivery configurations for protected objects.</para>
        /// </summary>
        [NameInMap("LogConfigs")]
        [Validation(Required=false)]
        public List<DescribeResourceLogDeliveryStatusResponseBodyLogConfigs> LogConfigs { get; set; }
        public class DescribeResourceLogDeliveryStatusResponseBodyLogConfigs : TeaModel {
            /// <summary>
            /// <para>The name of the delivery configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>export-kafka</para>
            /// </summary>
            [NameInMap("DeliveryName")]
            [Validation(Required=false)]
            public string DeliveryName { get; set; }

            /// <summary>
            /// <para>The delivery type of the protected object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>syslog</b>: delivered to a syslog service.</description></item>
            /// <item><description><b>kafka</b>: delivered to a Kafka service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>kafka</para>
            /// </summary>
            [NameInMap("DeliveryType")]
            [Validation(Required=false)]
            public string DeliveryType { get; set; }

            /// <summary>
            /// <para>The protected object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.waf.com-waf</para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// <para>The log delivery status of the protected object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disabled.</para>
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
