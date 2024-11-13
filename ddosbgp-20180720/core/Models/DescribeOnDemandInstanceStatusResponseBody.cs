// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeOnDemandInstanceStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the anti-DDoS diversion instance.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeOnDemandInstanceStatusResponseBodyInstances> Instances { get; set; }
        public class DescribeOnDemandInstanceStatusResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The details of route advertisement for data centers outside the Chinese mainland. This parameter is a JSON string. The following fields are included in the value:</para>
            /// <list type="bullet">
            /// <item><description><b>region</b>: The code of the data center outside the Chinese mainland. The value is of the string type. For more information, see <b>Codes of data centers outside the Chinese mainland</b>.</description></item>
            /// <item><description><b>declared</b>: indicates whether the data center advertised the route. The value is of the string type. Valid values: <b>0</b> and <b>1</b>. The value of 0 indicates that the data center did not advertise the route. The value of 1 indicates that the data center advertised the route.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;region\&quot;:\&quot;oe24\&quot;,\&quot;declared\&quot;:0},{\&quot;region\&quot;:\&quot;oe26\&quot;,\&quot;declared\&quot;:0},{\&quot;region\&quot;:\&quot;oe28\&quot;,\&quot;declared\&quot;:0},{\&quot;region\&quot;:\&quot;oi39\&quot;,\&quot;declared\&quot;:0},{\&quot;region\&quot;:\&quot;us50\&quot;,\&quot;declared\&quot;:0},{\&quot;region\&quot;:\&quot;jp141\&quot;,\&quot;declared\&quot;:0}]</para>
            /// </summary>
            [NameInMap("Declared")]
            [Validation(Required=false)]
            public string Declared { get; set; }

            /// <summary>
            /// <para>The description of the anti-DDoS diversion instance.</para>
            /// <remarks>
            /// <para>This parameter is returned only when the information about multiple anti-DDoS diversion instances are returned. The value of this parameter is not returned because the information about only one anti-DDoS diversion instance is returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// <para>The ID of the anti-DDoS diversion instance.</para>
            /// <remarks>
            /// <para>This parameter is returned only when the information about multiple anti-DDoS diversion instances are returned. The value of this parameter is not returned because the information about only one anti-DDoS diversion instance is returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ddosbgp-cn-z2q1qzxb****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The mode that is used to enable traffic rerouting to the anti-DDoS diversion instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>manual</b>: The instance is manually started.</description></item>
            /// <item><description><b>netflow-auto</b>: The instance is automatically started by using NetFlow that monitors network traffic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>netflow-auto</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The CIDR block of the anti-DDoS diversion instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.<em><b>.</b></em>.0/24</para>
            /// </summary>
            [NameInMap("Net")]
            [Validation(Required=false)]
            public string Net { get; set; }

            /// <summary>
            /// <para>The number of the autonomous system (AS). Set the value to <b>0</b>, which indicates that AS is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RegistedAs")]
            [Validation(Required=false)]
            public string RegistedAs { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>171986973287****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC49FF51-612F-429B-AB1E-374B3F115396</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
