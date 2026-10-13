// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddPrivateRegistryRequest : TeaModel {
        /// <summary>
        /// <para>The domain name of the registry.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The additional parameters for the image registry. This parameter is required when you use <b>quay</b>. The parameters include:</para>
        /// <list type="bullet">
        /// <item><description><b>namespace</b>: The namespace.</description></item>
        /// <item><description><b>authToken</b>: The authorization token.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;namespace&quot;:&quot;aa&quot;,&quot;authToken&quot;:&quot;aa&quot;}]</para>
        /// </summary>
        [NameInMap("ExtraParam")]
        [Validation(Required=false)]
        public string ExtraParam { get; set; }

        /// <summary>
        /// <para>The network type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Internet.</description></item>
        /// <item><description><b>2</b>: VPC.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NetType")]
        [Validation(Required=false)]
        public long? NetType { get; set; }

        /// <summary>
        /// <para>The password.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The port number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The protocol type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: HTTP.</description></item>
        /// <item><description><b>2</b>: HTTPS.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public long? ProtocolType { get; set; }

        /// <summary>
        /// <para>The IP address of the registry.</para>
        /// <para>Enter a valid IPv4 address that can be used to connect to the image registry. To specify a domain name for the image registry, use the DomainName parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>114.55.**.**</c></para>
        /// </summary>
        [NameInMap("RegistryHostIp")]
        [Validation(Required=false)]
        public string RegistryHostIp { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListImageRegistryRegion~~">ListImageRegistryRegion</a> operation to query the supported region IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegistryRegionId")]
        [Validation(Required=false)]
        public string RegistryRegionId { get; set; }

        /// <summary>
        /// <para>The type of the private image registry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>harbor</b>: Harbor environment.</description></item>
        /// <item><description><b>quay</b>: Quay environment.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>harbor</para>
        /// </summary>
        [NameInMap("RegistryType")]
        [Validation(Required=false)]
        public string RegistryType { get; set; }

        /// <summary>
        /// <para>The version of the image registry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>V1</b>: Version 1.0.</description></item>
        /// <item><description><b>V2</b>: Version 2.0.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>V2</para>
        /// </summary>
        [NameInMap("RegistryVersion")]
        [Validation(Required=false)]
        public string RegistryVersion { get; set; }

        /// <summary>
        /// <para>The number of images scanned per hour.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TransPerHour")]
        [Validation(Required=false)]
        public int? TransPerHour { get; set; }

        /// <summary>
        /// <para>The username of the image registry.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>The instance ID of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-wz9hs3e5*******908kd</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
