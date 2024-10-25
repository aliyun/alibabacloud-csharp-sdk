// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AddDeviceInternetPortRequest : TeaModel {
        /// <summary>
        /// <para>The Internet service provider (ISP). If you leave this parameter empty, the system automatically allows a random ISP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>telecom: China Telecom</description></item>
        /// <item><description>cmcc: China Mobile</description></item>
        /// <item><description>unicom: China Unicom</description></item>
        /// <item><description>cbn: China Broadcasting Network (CBN)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>telecom</para>
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// <para>The ID of the instance. You can specify the ID of the server or container.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5saiou41t6ude2ia56ri902ke</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The private IP address of the simple application server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.50</para>
        /// </summary>
        [NameInMap("InternalIp")]
        [Validation(Required=false)]
        public string InternalIp { get; set; }

        /// <summary>
        /// <para>The internal port number. Specify this parameter in the following format: first port/last port. Separate multiple port number groups with commas (,). Example: 1026/2001,2005/2005. This parameter is required if you set NatType to DNAT. If you set NatType to SNAT, the value of this parameter is invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12022/12022</para>
        /// </summary>
        [NameInMap("InternalPort")]
        [Validation(Required=false)]
        public string InternalPort { get; set; }

        /// <summary>
        /// <para>The type of the NAT gateway. The value of this parameter is of the enumerated data type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SNAT</description></item>
        /// <item><description>DNAT</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DNAT</para>
        /// </summary>
        [NameInMap("NatType")]
        [Validation(Required=false)]
        public string NatType { get; set; }

        /// <summary>
        /// <para>The ID of the Edge Node Service (ENS) node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wuxi-5</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
