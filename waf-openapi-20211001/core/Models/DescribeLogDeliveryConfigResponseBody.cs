// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeLogDeliveryConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The log delivery configuration.</para>
        /// </summary>
        [NameInMap("DeliveryConfig")]
        [Validation(Required=false)]
        public DescribeLogDeliveryConfigResponseBodyDeliveryConfig DeliveryConfig { get; set; }
        public class DescribeLogDeliveryConfigResponseBodyDeliveryConfig : TeaModel {
            /// <summary>
            /// <para>The details of the log delivery configuration, in JSON format.</para>
            /// <remarks>
            /// <para>This parameter is the same as the <b>DeliveryDetail</b> parameter of the <b>CreateLogDeliveryConfig</b> operation. For more information, see <a href="~~CreateLogDeliveryConfig~~">CreateLogDeliveryConfig</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;rfcVersion&quot;: &quot;rfc3164&quot;,
            ///   &quot;protocol&quot;: &quot;tcp&quot;,
            ///   &quot;servers&quot;: [
            ///     {
            ///       &quot;address&quot;: &quot;1.1.1.1&quot;,
            ///       &quot;port&quot;: 20
            ///     }
            ///   ]
            /// }</para>
            /// </summary>
            [NameInMap("DeliveryDetail")]
            [Validation(Required=false)]
            public string DeliveryDetail { get; set; }

            /// <summary>
            /// <para>The name of the log delivery configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("DeliveryName")]
            [Validation(Required=false)]
            public string DeliveryName { get; set; }

            /// <summary>
            /// <para>The type of the log delivery configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>syslog</b>: The logs are delivered to a syslog service.</para>
            /// </description></item>
            /// <item><description><para><b>kafka</b>: The logs are delivered to a Kafka service.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>syslog</para>
            /// </summary>
            [NameInMap("DeliveryType")]
            [Validation(Required=false)]
            public string DeliveryType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66A98669-CC6E-4F3E-80A6-******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
