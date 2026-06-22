// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListPrivateRegistryListResponseBody : TeaModel {
        /// <summary>
        /// <para>An array of private image registries.</para>
        /// </summary>
        [NameInMap("ImageRegistryInfos")]
        [Validation(Required=false)]
        public List<ListPrivateRegistryListResponseBodyImageRegistryInfos> ImageRegistryInfos { get; set; }
        public class ListPrivateRegistryListResponseBodyImageRegistryInfos : TeaModel {
            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1766185894******</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The domain name of the image registry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The unique ID of the image registry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66485</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The Jenkins environment information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JenkinsInfo</para>
            /// </summary>
            [NameInMap("JenkinsEnv")]
            [Validation(Required=false)]
            public string JenkinsEnv { get; set; }

            /// <summary>
            /// <para>The network type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: public network</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: VPC</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public long? NetType { get; set; }

            /// <summary>
            /// <para>The password for the image registry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Harbor******</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The asset retention period in days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("PersistenceDay")]
            [Validation(Required=false)]
            public long? PersistenceDay { get; set; }

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
            /// <item><description><para><b>1</b>: http</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: https</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public long? ProtocolType { get; set; }

            /// <summary>
            /// <para>The region ID of the image registry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The IP address of the image registry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>114.55.XXX.XXX</para>
            /// </summary>
            [NameInMap("RegistryHostIp")]
            [Validation(Required=false)]
            public string RegistryHostIp { get; set; }

            /// <summary>
            /// <para>The alias of the image registry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("RegistryName")]
            [Validation(Required=false)]
            public string RegistryName { get; set; }

            /// <summary>
            /// <para>The image registry type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>acr</b>: ACR</para>
            /// </description></item>
            /// <item><description><para><b>harbor</b>: Harbor</para>
            /// </description></item>
            /// <item><description><para><b>quay</b>: Quay</para>
            /// </description></item>
            /// <item><description><para><b>CI/CD</b>: a CI/CD registry</para>
            /// </description></item>
            /// </list>
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
            /// <item><description><para><b>V1</b>: Version 1.0</para>
            /// </description></item>
            /// <item><description><para><b>V2</b>: Version 2.0</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>V1</para>
            /// </summary>
            [NameInMap("RegistryVersion")]
            [Validation(Required=false)]
            public string RegistryVersion { get; set; }

            /// <summary>
            /// <para>The user authentication token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0da12bce-cc36-4c48-b3e6-2215fc3a****</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// <para>The number of scan tasks per hour.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TransPerHour")]
            [Validation(Required=false)]
            public int? TransPerHour { get; set; }

            /// <summary>
            /// <para>The username for the image registry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RegistryUser</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The ID of the VPC instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp12897gqrex01zn0****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The IP whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.104.XXX.XXX</para>
            /// </summary>
            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public string WhiteList { get; set; }

        }

        /// <summary>
        /// <para>The unique ID generated by Alibaba Cloud for the request. Use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE120DAB-F4E7-4C53-ADC3-A97578AB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
