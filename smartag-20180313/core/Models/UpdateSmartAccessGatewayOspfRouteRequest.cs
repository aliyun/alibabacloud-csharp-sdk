// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class UpdateSmartAccessGatewayOspfRouteRequest : TeaModel {
        /// <summary>
        /// <para>The OSPF area ID.</para>
        /// <para>The value must be an integer from <b>1</b> to <b>2147483647</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AreaId")]
        [Validation(Required=false)]
        public int? AreaId { get; set; }

        /// <summary>
        /// <para>The authentication method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NONE</b>: No authentication is configured.</description></item>
        /// <item><description><b>CLEARTEXT</b>: Plaintext authentication is used.</description></item>
        /// <item><description><b>MD5</b>: MD5 authentication is used.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MD5</para>
        /// </summary>
        [NameInMap("AuthenticationType")]
        [Validation(Required=false)]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// <para>Specifies whether to query only the SAG instances that belong to other Alibaba Cloud accounts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): No.</description></item>
        /// <item><description><b>true</b>: Yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CrossAccount")]
        [Validation(Required=false)]
        public bool? CrossAccount { get; set; }

        /// <summary>
        /// <para>The dead interval. Unit: seconds.</para>
        /// <para>The value must be an integer from <b>1</b> to <b>65535</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("DeadTime")]
        [Validation(Required=false)]
        public int? DeadTime { get; set; }

        /// <summary>
        /// <para>The interval at which Hello packets are sent. Unit: seconds.</para>
        /// <para>The value must be an integer from <b>1</b> to <b>65535</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("HelloTime")]
        [Validation(Required=false)]
        public int? HelloTime { get; set; }

        /// <summary>
        /// <para>The port name.</para>
        /// <remarks>
        /// <para>This parameter is not in use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("InterfaceName")]
        [Validation(Required=false)]
        public string InterfaceName { get; set; }

        /// <summary>
        /// <para>The MD5 key.</para>
        /// <para>The value must be 1 to <b>47</b> characters in length.</para>
        /// <remarks>
        /// <para>This parameter is required only when you set <b>AuthenticationType</b> to <b>MD5</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Md5Key")]
        [Validation(Required=false)]
        public string Md5Key { get; set; }

        /// <summary>
        /// <para>The MD5 key ID.</para>
        /// <para>The value must be an integer from 1 to <b>2147483647</b>.</para>
        /// <remarks>
        /// <para>This parameter is required only when you set <b>AuthenticationType</b> to <b>MD5</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("Md5KeyId")]
        [Validation(Required=false)]
        public int? Md5KeyId { get; set; }

        /// <summary>
        /// <para>The network segment.</para>
        /// <remarks>
        /// <para>This parameter is not in use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.10.0/24</para>
        /// </summary>
        [NameInMap("Networks")]
        [Validation(Required=false)]
        public string Networks { get; set; }

        /// <summary>
        /// <para>The cost of the OSPF route.</para>
        /// <remarks>
        /// <para>This parameter is not in use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[110/11]</para>
        /// </summary>
        [NameInMap("OspfCost")]
        [Validation(Required=false)]
        public int? OspfCost { get; set; }

        /// <summary>
        /// <para>The OSPF network type.</para>
        /// <remarks>
        /// <para>This parameter is not in use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>NSSA</para>
        /// </summary>
        [NameInMap("OspfNetworkType")]
        [Validation(Required=false)]
        public string OspfNetworkType { get; set; }

        /// <summary>
        /// <para>The password for plaintext authentication.</para>
        /// <para>The password must be 1 to 8 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</para>
        /// <remarks>
        /// <para>This parameter is required only when you set <b>AuthenticationType</b> to <b>CLEARTEXT</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>duuf****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The route redistribution protocol.</para>
        /// <remarks>
        /// <para>This parameter is not in use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>OSPF</para>
        /// </summary>
        [NameInMap("RedistributeProtocol")]
        [Validation(Required=false)]
        public string RedistributeProtocol { get; set; }

        /// <summary>
        /// <para>The ID of the region where the SAG instance is deployed.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/69813.html">DescribeRegions</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>109790620697****</para>
        /// </summary>
        [NameInMap("ResourceUid")]
        [Validation(Required=false)]
        public string ResourceUid { get; set; }

        /// <summary>
        /// <para>The OSPF router ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.XX.XX.1</para>
        /// </summary>
        [NameInMap("RouterId")]
        [Validation(Required=false)]
        public string RouterId { get; set; }

        /// <summary>
        /// <para>The ID of the SAG instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-3manef62evrfr6****</para>
        /// </summary>
        [NameInMap("SagInsId")]
        [Validation(Required=false)]
        public string SagInsId { get; set; }

        /// <summary>
        /// <para>The serial number of the SAG device.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sagf4dk****</para>
        /// </summary>
        [NameInMap("SagSn")]
        [Validation(Required=false)]
        public string SagSn { get; set; }

    }

}
