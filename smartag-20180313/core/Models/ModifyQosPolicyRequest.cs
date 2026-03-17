// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ModifyQosPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The description of the traffic classification rule.</para>
        /// <para>The description must be 1 to 512 characters in length, and can contain digits, underscores (_), and hyphens (-). It must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The range of the destination IP addresses.</para>
        /// <para>Specify the value of this parameter in CIDR notation. Example: 192.168.10.0/24.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.20.0/24</para>
        /// </summary>
        [NameInMap("DestCidr")]
        [Validation(Required=false)]
        public string DestCidr { get; set; }

        /// <summary>
        /// <para>The range of destination ports.</para>
        /// <para>Valid values: <b>1</b> to <b>65535</b> and <b>-1</b>.</para>
        /// <para>Set this parameter in one of the following formats:</para>
        /// <list type="bullet">
        /// <item><description><b>1/200</b>: port 1 to port 200</description></item>
        /// <item><description><b>80/80</b>: port 80</description></item>
        /// <item><description><b>-1/-1</b>: all ports</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>300/400</para>
        /// </summary>
        [NameInMap("DestPortRange")]
        [Validation(Required=false)]
        public string DestPortRange { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DpiGroupIds")]
        [Validation(Required=false)]
        public List<string> DpiGroupIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DpiSignatureIds")]
        [Validation(Required=false)]
        public List<string> DpiSignatureIds { get; set; }

        /// <summary>
        /// <para>The time when the traffic classification rule becomes invalid.</para>
        /// <para>Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss+0800 format. The time must be in UTC+8.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-14T16:41:33+0800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The type of the protocol that applies to the traffic classification rule.</para>
        /// <para>The supported protocols provided in this topic are for reference only. The actual protocols in the console shall prevail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <para>The name of the traffic classification rule.</para>
        /// <para>The name must be 2 to 100 characters in length, and can contain digits, underscores (_), and hyphens (-). It must start with a letter.</para>
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
        /// <para>The priority of the traffic throttling policy to which the traffic classification rule belongs.</para>
        /// <para>Valid values: <b>1 to 3</b>. A smaller value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The ID of the QoS policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-xitd8690ucu8ro****</para>
        /// </summary>
        [NameInMap("QosId")]
        [Validation(Required=false)]
        public string QosId { get; set; }

        /// <summary>
        /// <para>The ID of the traffic classification rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qospy-427m9fo6wkh****</para>
        /// </summary>
        [NameInMap("QosPolicyId")]
        [Validation(Required=false)]
        public string QosPolicyId { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the QoS policy belongs.</para>
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
        /// <para>The range of the source IP addresses.</para>
        /// <para>Specify the value of this parameter in CIDR notation. Example: 192.168.1.0/24.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.10.0/24</para>
        /// </summary>
        [NameInMap("SourceCidr")]
        [Validation(Required=false)]
        public string SourceCidr { get; set; }

        /// <summary>
        /// <para>The range of source ports.</para>
        /// <para>Valid values: <b>1</b> to <b>65535</b> and <b>-1</b>.</para>
        /// <para>Set this parameter in one of the following formats:</para>
        /// <list type="bullet">
        /// <item><description><b>1/200</b>: a port range from 1 to 200</description></item>
        /// <item><description><b>80/80</b>: port 80</description></item>
        /// <item><description><b>-1/-1</b>: all ports</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1/200</para>
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// <para>The time when the traffic classification rule takes effect.</para>
        /// <para>Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss+0800 format. The time must be in UTC+8.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-07-14T16:41:33+0800</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
