// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeLogDeliveryConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the log delivery configuration.</para>
        /// </summary>
        [NameInMap("DeliveryConfigs")]
        [Validation(Required=false)]
        public List<DescribeLogDeliveryConfigsResponseBodyDeliveryConfigs> DeliveryConfigs { get; set; }
        public class DescribeLogDeliveryConfigsResponseBodyDeliveryConfigs : TeaModel {
            /// <summary>
            /// <para>The content of the log delivery configuration. The value is a JSON string that contains multiple parameters.</para>
            /// <remarks>
            /// <para> This parameter is the same as the <b>DeliveryDetail</b> parameter of the <b>CreateLogDeliveryConfig</b> operation. For more information, see <b>Parameter description for log delivery configuration</b> of the <a href="~~CreateLogDeliveryConfig~~">CreateLogDeliveryConfig</a> operation.</para>
            /// </remarks>
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
            /// <item><description><b>syslog</b>: Logs are delivered to a syslog service.</description></item>
            /// <item><description><b>kafka</b>: Logs are delivered to a Kafka service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>kafka</para>
            /// </summary>
            [NameInMap("DeliveryType")]
            [Validation(Required=false)]
            public string DeliveryType { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2EFCFE18-78F8-5079-B312-07***48B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
