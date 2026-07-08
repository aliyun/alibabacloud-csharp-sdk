// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeLogDeliveryConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The log delivery configurations.</para>
        /// </summary>
        [NameInMap("DeliveryConfigs")]
        [Validation(Required=false)]
        public List<DescribeLogDeliveryConfigsResponseBodyDeliveryConfigs> DeliveryConfigs { get; set; }
        public class DescribeLogDeliveryConfigsResponseBodyDeliveryConfigs : TeaModel {
            /// <summary>
            /// <para>The details of the log delivery configuration, returned as a JSON string.</para>
            /// <remarks>
            /// <para>The structure of this parameter is the same as the <b>DeliveryDetail</b> request parameter of the <a href="~~CreateLogDeliveryConfig~~">CreateLogDeliveryConfig</a> operation.</para>
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
            /// <item><description><para><b>syslog</b>: Log delivery to a syslog server.</para>
            /// </description></item>
            /// <item><description><para><b>kafka</b>: Log delivery to a Kafka cluster.</para>
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
        /// <para>The maximum number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// <remarks>
        /// <para>If this parameter is not empty, more results are available. Use the value of <b>NextToken</b> in the next request to retrieve the next page of results. If the value is empty, all results have been returned.</para>
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
        /// <para>The total number of log delivery configurations returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
