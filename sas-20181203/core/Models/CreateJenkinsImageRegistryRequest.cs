// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateJenkinsImageRegistryRequest : TeaModel {
        /// <summary>
        /// <para>The domain name of the image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The additional parameters of the image repository. The value of this parameter contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>namespace</b>: the namespace</description></item>
        /// <item><description><b>authToken</b>: the authorization token</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;namespace\&quot;:\&quot;aa\&quot;,\&quot;authToken\&quot;:\&quot;aa\&quot;}]</para>
        /// </summary>
        [NameInMap("ExtraParam")]
        [Validation(Required=false)]
        public string ExtraParam { get; set; }

        /// <summary>
        /// <para>The network type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Internet</description></item>
        /// <item><description><b>2</b>: Virtual Private Cloud (VPC)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NetType")]
        [Validation(Required=false)]
        public int? NetType { get; set; }

        /// <summary>
        /// <para>The password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Harbor********</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The number of days during which assets can be retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PersistenceDay")]
        [Validation(Required=false)]
        public int? PersistenceDay { get; set; }

        /// <summary>
        /// <para>The type of the protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: HTTP</description></item>
        /// <item><description><b>2</b>: HTTPS</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public int? ProtocolType { get; set; }

        /// <summary>
        /// <para>The region ID of the image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IP address of the image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>114.55.XXX.XXX</para>
        /// </summary>
        [NameInMap("RegistryHostIp")]
        [Validation(Required=false)]
        public string RegistryHostIp { get; set; }

        /// <summary>
        /// <para>The alias of the image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testRepo</para>
        /// </summary>
        [NameInMap("RegistryName")]
        [Validation(Required=false)]
        public string RegistryName { get; set; }

        /// <summary>
        /// <para>The type of the image repository. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CI/CD</b>: Jenkins</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CI/CD</para>
        /// </summary>
        [NameInMap("RegistryType")]
        [Validation(Required=false)]
        public string RegistryType { get; set; }

        /// <summary>
        /// <para>The version of the image repository. Default value: -. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-</b>: the default version</description></item>
        /// <item><description><b>V1</b>: V1.0</description></item>
        /// <item><description><b>V2</b>: V2.0</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>V1</para>
        /// </summary>
        [NameInMap("RegistryVersion")]
        [Validation(Required=false)]
        public string RegistryVersion { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>41.121.XXX.XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The number of images that can be scanned per hour.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TransPerHour")]
        [Validation(Required=false)]
        public int? TransPerHour { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RegistryUser</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2ze4aoqgeu51ydfb8****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The whitelist of IP addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XXX.XXX</para>
        /// </summary>
        [NameInMap("WhiteList")]
        [Validation(Required=false)]
        public string WhiteList { get; set; }

    }

}
