// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateExpressCloudConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The bandwidth of the Express Cloud Connection instance, which corresponds to the bandwidth of the underlying physical connection.</para>
        /// <para>Unit: Mbit/s.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The email address of the contact person for the Express Cloud Connection application.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:XX@example.com">XX@example.com</a></para>
        /// </summary>
        [NameInMap("ContactMail")]
        [Validation(Required=false)]
        public string ContactMail { get; set; }

        /// <summary>
        /// <para>The phone number of the contact person for the Express Cloud Connection application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132*********</para>
        /// </summary>
        [NameInMap("ContactTel")]
        [Validation(Required=false)]
        public string ContactTel { get; set; }

        /// <summary>
        /// <para>The description of the Express Cloud Connection instance.</para>
        /// <para>The description must be 2 to 256 characters in length and must start with a letter or a Chinese character, but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>高速上云服务</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID card number of the contact person for the Express Cloud Connection application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32*****************</para>
        /// </summary>
        [NameInMap("IDCardNo")]
        [Validation(Required=false)]
        public string IDCardNo { get; set; }

        /// <summary>
        /// <para>The network service provider of the IDC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CU</para>
        /// </summary>
        [NameInMap("IdcSP")]
        [Validation(Required=false)]
        public string IdcSP { get; set; }

        /// <summary>
        /// <para>The name of the Express Cloud Connection instance.</para>
        /// <para>The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-), but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doctest</para>
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
        /// <para>The city where the on-premises IDC is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>杭州</para>
        /// </summary>
        [NameInMap("PeerCity")]
        [Validation(Required=false)]
        public string PeerCity { get; set; }

        /// <summary>
        /// <para>The geographic location of the on-premises data center.</para>
        /// <remarks>
        /// <para>The location must be accurate to the street number, floor, room number, and rack number.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b>市</b>区/县<b>路</b>号<b>物业或楼宇名称</b>座<b>楼层</b>房间号<b>机柜号</b>机柜名称<b>设备</b>端口</para>
        /// </summary>
        [NameInMap("PeerLocation")]
        [Validation(Required=false)]
        public string PeerLocation { get; set; }

        /// <summary>
        /// <para>The port type of the Express Connect circuit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>100Base-T: 100M Ethernet port</para>
        /// </description></item>
        /// <item><description><para>1000Base-T (default): GE electrical port</para>
        /// </description></item>
        /// <item><description><para>1000Base-LX: GE single-mode optical port (10 km)</para>
        /// </description></item>
        /// <item><description><para>10GBase-T: 10 GE electrical port</para>
        /// </description></item>
        /// <item><description><para>10GBase-LR: 10 GE single-mode optical port (10 km)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100Base-T</para>
        /// </summary>
        [NameInMap("PortType")]
        [Validation(Required=false)]
        public string PortType { get; set; }

        /// <summary>
        /// <para>The instance ID of the redundant Express Cloud Connection circuit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecc-d****</para>
        /// </summary>
        [NameInMap("RedundantEccId")]
        [Validation(Required=false)]
        public string RedundantEccId { get; set; }

        /// <summary>
        /// <para>The region ID of the Express Cloud Connection instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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

    }

}
