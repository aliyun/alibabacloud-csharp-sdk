// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateExpressCloudConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The bandwidth for ECC, which corresponds to the bandwidth for the underlying circuit.</para>
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
        /// <para>The email address of the contact who applies for ECC.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:XX@example.com">XX@example.com</a></para>
        /// </summary>
        [NameInMap("ContactMail")]
        [Validation(Required=false)]
        public string ContactMail { get; set; }

        /// <summary>
        /// <para>The phone number of the contact who applies for ECC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132*********</para>
        /// </summary>
        [NameInMap("ContactTel")]
        [Validation(Required=false)]
        public string ContactTel { get; set; }

        /// <summary>
        /// <para>The description of ECC.</para>
        /// <para>The description must be 2 to 256 characters in length. It must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECC</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID card number of the contact who applies for ECC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32*****************</para>
        /// </summary>
        [NameInMap("IDCardNo")]
        [Validation(Required=false)]
        public string IDCardNo { get; set; }

        /// <summary>
        /// <para>The Internet service provider (ISP) for the data center.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CU</para>
        /// </summary>
        [NameInMap("IdcSP")]
        [Validation(Required=false)]
        public string IdcSP { get; set; }

        /// <summary>
        /// <para>The name of the ECC instance.</para>
        /// <para>The name must be 2 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>The city where the data center is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hangzhou</para>
        /// </summary>
        [NameInMap("PeerCity")]
        [Validation(Required=false)]
        public string PeerCity { get; set; }

        /// <summary>
        /// <para>The geographical location of the data center.</para>
        /// <remarks>
        /// <para>It must be accurate to house number-floor-room number-server rack number.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>\*\<em>city\</em>\<em>district/county\</em>\<em>road\</em>\<em>number\</em>\<em>property or building name\</em>\<em>building\</em>\<em>floor\</em>\<em>room number\</em>\<em>server rack number\</em>\<em>server rack name\</em>\<em>device\</em>\*port</para>
        /// </summary>
        [NameInMap("PeerLocation")]
        [Validation(Required=false)]
        public string PeerLocation { get; set; }

        /// <summary>
        /// <para>The port of the Express Connect circuit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>100Base-T</description></item>
        /// <item><description>1000Base-T</description></item>
        /// <item><description>1000Base-LX</description></item>
        /// <item><description>10GBase-T</description></item>
        /// <item><description>10GBase-LR</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100Base-T</para>
        /// </summary>
        [NameInMap("PortType")]
        [Validation(Required=false)]
        public string PortType { get; set; }

        /// <summary>
        /// <para>The ID of the standby Express Connect circuit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecc-d****</para>
        /// </summary>
        [NameInMap("RedundantEccId")]
        [Validation(Required=false)]
        public string RedundantEccId { get; set; }

        /// <summary>
        /// <para>The region ID of the ECC instance.</para>
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
