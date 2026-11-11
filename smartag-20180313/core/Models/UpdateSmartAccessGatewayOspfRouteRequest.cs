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
        /// <para>Valid values: <b>1</b> to <b>2147483647</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AreaId")]
        [Validation(Required=false)]
        public int? AreaId { get; set; }

        /// <summary>
        /// <para>The authentication type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NONE</b>: disables authentication.</para>
        /// </description></item>
        /// <item><description><para><b>CLEARTEXT</b>: uses plaintext authentication.</para>
        /// </description></item>
        /// <item><description><para><b>MD5</b>: uses MD5 authentication.</para>
        /// </description></item>
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
        /// <para>Specifies whether to query only cross-account Smart Access Gateway instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): no.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: yes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CrossAccount")]
        [Validation(Required=false)]
        public bool? CrossAccount { get; set; }

        /// <summary>
        /// <para>The OSPF dead interval. Unit: seconds.</para>
        /// <para>Valid values: <b>1</b> to <b>65535</b>.</para>
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
        /// <para>Valid values: <b>1</b> to <b>65535</b>.</para>
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
        /// <para>This parameter does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("InterfaceName")]
        [Validation(Required=false)]
        public string InterfaceName { get; set; }

        /// <summary>
        /// <para>The value of the MD5 key.</para>
        /// <para>Valid values: <b>1</b> to <b>47</b>.</para>
        /// <remarks>
        /// <para>This parameter is required only when <b>AuthenticationType</b> is set to <b>MD5</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Md5Key")]
        [Validation(Required=false)]
        public string Md5Key { get; set; }

        /// <summary>
        /// <para>The ID of the MD5 key.</para>
        /// <para>Valid values: <b>1</b> to <b>2147483647</b>.</para>
        /// <remarks>
        /// <para>This parameter is required only when <b>AuthenticationType</b> is set to <b>MD5</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("Md5KeyId")]
        [Validation(Required=false)]
        public int? Md5KeyId { get; set; }

        /// <summary>
        /// <para>The CIDR block.</para>
        /// <remarks>
        /// <para>This parameter does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.10.0/24</para>
        /// </summary>
        [NameInMap("Networks")]
        [Validation(Required=false)]
        public string Networks { get; set; }

        /// <summary>
        /// <para>The OSPF route cost.</para>
        /// <remarks>
        /// <para>This parameter does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("OspfCost")]
        [Validation(Required=false)]
        public int? OspfCost { get; set; }

        /// <summary>
        /// <para>The OSPF area type.</para>
        /// <remarks>
        /// <para>This parameter does not take effect.</para>
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
        /// <para>This parameter is required only when <b>AuthenticationType</b> is set to <b>CLEARTEXT</b>.</para>
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
        /// <para>This parameter does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>OSPF</para>
        /// </summary>
        [NameInMap("RedistributeProtocol")]
        [Validation(Required=false)]
        public string RedistributeProtocol { get; set; }

        /// <summary>
        /// <para>The region ID of the Smart Access Gateway instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/69813.html">DescribeRegions</a> operation to obtain region IDs.</para>
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
        /// <para>The Smart Access Gateway instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-3manef62evrfr6****</para>
        /// </summary>
        [NameInMap("SagInsId")]
        [Validation(Required=false)]
        public string SagInsId { get; set; }

        /// <summary>
        /// <para>The serial number of the Smart Access Gateway device.</para>
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
