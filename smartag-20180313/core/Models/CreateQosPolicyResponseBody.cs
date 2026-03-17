// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class CreateQosPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the traffic classification rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.10.0/24</para>
        /// </summary>
        [NameInMap("DestCidr")]
        [Validation(Required=false)]
        public string DestCidr { get; set; }

        /// <summary>
        /// <para>The destination port range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80/80</para>
        /// </summary>
        [NameInMap("DestPortRange")]
        [Validation(Required=false)]
        public string DestPortRange { get; set; }

        [NameInMap("DpiGroupIds")]
        [Validation(Required=false)]
        public CreateQosPolicyResponseBodyDpiGroupIds DpiGroupIds { get; set; }
        public class CreateQosPolicyResponseBodyDpiGroupIds : TeaModel {
            [NameInMap("DpiGroupId")]
            [Validation(Required=false)]
            public List<string> DpiGroupId { get; set; }

        }

        [NameInMap("DpiSignatureIds")]
        [Validation(Required=false)]
        public CreateQosPolicyResponseBodyDpiSignatureIds DpiSignatureIds { get; set; }
        public class CreateQosPolicyResponseBodyDpiSignatureIds : TeaModel {
            [NameInMap("DpiSignatureId")]
            [Validation(Required=false)]
            public List<string> DpiSignatureId { get; set; }

        }

        /// <summary>
        /// <para>The time when the traffic classification rule expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-14T16:41:33+0800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The protocol that applies to the traffic classification rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <para>The name of the traffic classification rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The priority of the traffic throttling policy to which the traffic classification rule belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The ID of the QoS policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-xitd8690ucu8ro****</para>
        /// </summary>
        [NameInMap("QosId")]
        [Validation(Required=false)]
        public string QosId { get; set; }

        /// <summary>
        /// <para>The ID of the traffic classification rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qospy-xhwhyuo43l********</para>
        /// </summary>
        [NameInMap("QosPolicyId")]
        [Validation(Required=false)]
        public string QosPolicyId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>97862812-2C7E-4D25-B0D5-B26DAC7FA293</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The source CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.10.0/24</para>
        /// </summary>
        [NameInMap("SourceCidr")]
        [Validation(Required=false)]
        public string SourceCidr { get; set; }

        /// <summary>
        /// <para>The source port range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80/80</para>
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// <para>The time when the traffic classification rule takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-14T16:41:33+0800</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
