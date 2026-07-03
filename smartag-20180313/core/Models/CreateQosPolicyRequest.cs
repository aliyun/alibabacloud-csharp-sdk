// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class CreateQosPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The description of the traffic classification rule for the QoS policy.</para>
        /// <para>The description must be 1 to 512 characters in length and must start with a letter or a Chinese character. It can contain digits, underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination CIDR block.</para>
        /// <para>The destination CIDR block is in CIDR notation. Example: 192.168.10.0/24.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.20.0/24</para>
        /// </summary>
        [NameInMap("DestCidr")]
        [Validation(Required=false)]
        public string DestCidr { get; set; }

        /// <summary>
        /// <para>The destination port range.</para>
        /// <para>Valid values: <b>-1</b> or <b>1</b> to <b>65535</b>.</para>
        /// <para>Examples of destination port range formats:</para>
        /// <list type="bullet">
        /// <item><description><b>1/200</b>: port range 1 to 200.</description></item>
        /// <item><description><b>80/80</b>: port 80.</description></item>
        /// <item><description><b>-1/-1</b>: all ports.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80/80</para>
        /// </summary>
        [NameInMap("DestPortRange")]
        [Validation(Required=false)]
        public string DestPortRange { get; set; }

        /// <summary>
        /// <para>The list of application group IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DpiGroupIds")]
        [Validation(Required=false)]
        public List<string> DpiGroupIds { get; set; }

        /// <summary>
        /// <para>The list of application IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DpiSignatureIds")]
        [Validation(Required=false)]
        public List<string> DpiSignatureIds { get; set; }

        /// <summary>
        /// <para>The time when the traffic classification rule expires.</para>
        /// <para>The time is expressed in ISO 8601 format and uses UTC+8. Format: <c>YYYY-MM-DDThh:mm:ss+0800</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-14T16:41:33+0800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The protocol type to which the traffic classification rule applies.</para>
        /// <para>For the protocol types supported by the traffic classification rule, refer to the console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <para>The name of the traffic classification rule for the QoS policy.</para>
        /// <para>The name must be 2 to 100 characters in length and must start with a letter or a Chinese character. It can contain digits, hyphens (-), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The priority of the rate limiting rule to which the traffic classification rule belongs.</para>
        /// <para>Valid values: <b>1</b> to <b>3</b>. A smaller value indicates a higher priority.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The instance ID of the QoS policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-xitd8690ucu8ro****</para>
        /// </summary>
        [NameInMap("QosId")]
        [Validation(Required=false)]
        public string QosId { get; set; }

        /// <summary>
        /// <para>The region ID of the QoS policy instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The source CIDR block.</para>
        /// <para>The source CIDR block is in CIDR notation. Example: 192.168.1.0/24.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.10.0/24</para>
        /// </summary>
        [NameInMap("SourceCidr")]
        [Validation(Required=false)]
        public string SourceCidr { get; set; }

        /// <summary>
        /// <para>The source port range.</para>
        /// <para>Valid values: <b>-1</b> or <b>1</b> to <b>65535</b>.</para>
        /// <para>Examples of source port range formats:</para>
        /// <list type="bullet">
        /// <item><description><b>1/200</b>: port range 1 to 200.</description></item>
        /// <item><description><b>80/80</b>: port 80.</description></item>
        /// <item><description><b>-1/-1</b>: all ports.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80/80</para>
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// <para>The effective period start time of the traffic categorization rule for the QoS policy.</para>
        /// <para>The time is expressed in ISO 8601 format and uses UTC+8. Format: <c>YYYY-MM-DDThh:mm:ss+0800</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-14T16:41:33+0800</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
