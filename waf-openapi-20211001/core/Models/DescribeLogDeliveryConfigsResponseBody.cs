// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeLogDeliveryConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The delivery configuration information.</para>
        /// </summary>
        [NameInMap("DeliveryConfigs")]
        [Validation(Required=false)]
        public List<DescribeLogDeliveryConfigsResponseBodyDeliveryConfigs> DeliveryConfigs { get; set; }
        public class DescribeLogDeliveryConfigsResponseBodyDeliveryConfigs : TeaModel {
            /// <summary>
            /// <para>The content of the delivery configuration. The content is a JSON string constructed from a series of parameters.</para>
            /// <remarks>
            /// <para>This parameter is the same as the <b>DeliveryDetail</b> request parameter of the <a href="~~CreateLogDeliveryConfig~~">CreateLogDeliveryConfig</a> operation. For more information, see the <b>Delivery configuration content parameters</b> section of the <a href="~~CreateLogDeliveryConfig~~">CreateLogDeliveryConfig</a> operation.</para>
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
            /// <para>The name of the delivery configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("DeliveryName")]
            [Validation(Required=false)]
            public string DeliveryName { get; set; }

            /// <summary>
            /// <para>The type of the delivery configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>syslog</b>: Delivers logs to a Syslog service.</description></item>
            /// <item><description><b>kafka</b>: Delivers logs to a Kafka service.</description></item>
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
        /// <para>The number of entries to return per page during paging in a paged query. Valid values: 1 to 50. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for querying the next page. If a next page exists, this field returns a value.</para>
        /// <remarks>
        /// <para>If this parameter returns a value, it indicates that more pages exist. You can use the returned <b>NextToken</b> value as a request parameter to obtain the data on the next page. Repeat this process until no value is returned, which indicates that all data has been retrieved.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAGBgV9tolsLfijC4wam2htS*****D/46H3X2wIS</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2EFCFE18-78F8-5079-B312-07***48B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
