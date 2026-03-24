// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeProductInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the instances.</para>
        /// </summary>
        [NameInMap("ProductInstances")]
        [Validation(Required=false)]
        public List<DescribeProductInstancesResponseBodyProductInstances> ProductInstances { get; set; }
        public class DescribeProductInstancesResponseBodyProductInstances : TeaModel {
            /// <summary>
            /// <para>The ID of the instance added to WAF.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2ze1tm4pvghp****cluv</para>
            /// </summary>
            [NameInMap("AccessInstanceId")]
            [Validation(Required=false)]
            public string AccessInstanceId { get; set; }

            /// <summary>
            /// <para>The port and protocol information of the cloud service added to WAF.</para>
            /// </summary>
            [NameInMap("AccessPortAndProtocols")]
            [Validation(Required=false)]
            public List<DescribeProductInstancesResponseBodyProductInstancesAccessPortAndProtocols> AccessPortAndProtocols { get; set; }
            public class DescribeProductInstancesResponseBodyProductInstancesAccessPortAndProtocols : TeaModel {
                /// <summary>
                /// <para>The certificates.</para>
                /// </summary>
                [NameInMap("CertificateIds")]
                [Validation(Required=false)]
                public List<string> CertificateIds { get; set; }

                /// <summary>
                /// <para>The port of the cloud service added to WAF.</para>
                /// 
                /// <b>Example:</b>
                /// <para>443</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The protocol type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>http</b>: HTTP protocol.</para>
                /// </description></item>
                /// <item><description><para><b>https</b>: HTTPS protocol.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>http</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// <para>The list of ports added to WAF.</para>
            /// </summary>
            [NameInMap("AccessPorts")]
            [Validation(Required=false)]
            public List<int?> AccessPorts { get; set; }

            /// <summary>
            /// <para>The user ID (UID) of the Alibaba Cloud account to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1704********9107</para>
            /// </summary>
            [NameInMap("OwnerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            /// <summary>
            /// <para>The protection status of WAF. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>all</b>: All protected.</para>
            /// </description></item>
            /// <item><description><para><b>any</b>: Protected.</para>
            /// </description></item>
            /// <item><description><para><b>part</b>: Partially protected.</para>
            /// </description></item>
            /// <item><description><para><b>non</b>: Not protected.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("ResourceInstanceAccessStatus")]
            [Validation(Required=false)]
            public string ResourceInstanceAccessStatus { get; set; }

            /// <summary>
            /// <para>The edition of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.e-c1m1.large</para>
            /// </summary>
            [NameInMap("ResourceInstanceEdition")]
            [Validation(Required=false)]
            public string ResourceInstanceEdition { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2ze1tm4pvghp****cluv</para>
            /// </summary>
            [NameInMap("ResourceInstanceId")]
            [Validation(Required=false)]
            public string ResourceInstanceId { get; set; }

            /// <summary>
            /// <para>The IP address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.X.X.1</para>
            /// </summary>
            [NameInMap("ResourceInstanceIp")]
            [Validation(Required=false)]
            public string ResourceInstanceIp { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demoInstanceName</para>
            /// </summary>
            [NameInMap("ResourceInstanceName")]
            [Validation(Required=false)]
            public string ResourceInstanceName { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The public IP address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.X.X.1</para>
            /// </summary>
            [NameInMap("ResourceIp")]
            [Validation(Required=false)]
            [Obsolete]
            public string ResourceIp { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs-test</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            [Obsolete]
            public string ResourceName { get; set; }

            /// <summary>
            /// <para>The information about the ports.</para>
            /// </summary>
            [NameInMap("ResourcePorts")]
            [Validation(Required=false)]
            public List<DescribeProductInstancesResponseBodyProductInstancesResourcePorts> ResourcePorts { get; set; }
            public class DescribeProductInstancesResponseBodyProductInstancesResourcePorts : TeaModel {
                /// <summary>
                /// <para>The information about the certificates.</para>
                /// </summary>
                [NameInMap("Certificates")]
                [Validation(Required=false)]
                public List<DescribeProductInstancesResponseBodyProductInstancesResourcePortsCertificates> Certificates { get; set; }
                public class DescribeProductInstancesResponseBodyProductInstancesResourcePortsCertificates : TeaModel {
                    /// <summary>
                    /// <para>The type of the HTTPS certificate. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>default</b>: Default certificate.</para>
                    /// </description></item>
                    /// <item><description><para><b>extension</b>: Extension certificate.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("AppliedType")]
                    [Validation(Required=false)]
                    public string AppliedType { get; set; }

                    /// <summary>
                    /// <para>The certificate ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234567</para>
                    /// </summary>
                    [NameInMap("CertificateId")]
                    [Validation(Required=false)]
                    public string CertificateId { get; set; }

                    /// <summary>
                    /// <para>The name of the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demoCertName</para>
                    /// </summary>
                    [NameInMap("CertificateName")]
                    [Validation(Required=false)]
                    public string CertificateName { get; set; }

                    /// <summary>
                    /// <para>The domain name bound to the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.test.com">www.test.com</a></para>
                    /// </summary>
                    [NameInMap("Domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }

                }

                /// <summary>
                /// <para>The port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>443</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The protocol type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>http</b>: HTTP protocol.</para>
                /// </description></item>
                /// <item><description><para><b>https</b>: HTTPS protocol.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>https</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// <para>The type of the cloud service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>clb4</b>: Layer 4 CLB.</para>
            /// </description></item>
            /// <item><description><para><b>clb7</b>: Layer 7 CLB.</para>
            /// </description></item>
            /// <item><description><para><b>ecs</b>: ECS.</para>
            /// </description></item>
            /// <item><description><para><b>nlb</b>: NLB.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>clb4</para>
            /// </summary>
            [NameInMap("ResourceProduct")]
            [Validation(Required=false)]
            public string ResourceProduct { get; set; }

            /// <summary>
            /// <para>The region ID of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>cn-chengdu</b>: China (Chengdu).</para>
            /// </description></item>
            /// <item><description><para><b>cn-beijing</b>: China (Beijing).</para>
            /// </description></item>
            /// <item><description><para><b>cn-zhangjiakou</b>: China (Zhangjiakou).</para>
            /// </description></item>
            /// <item><description><para><b>cn-hangzhou</b>: China (Hangzhou).</para>
            /// </description></item>
            /// <item><description><para><b>cn-shanghai</b>: China (Shanghai).</para>
            /// </description></item>
            /// <item><description><para><b>cn-shenzhen</b>: China (Shenzhen).</para>
            /// </description></item>
            /// <item><description><para><b>cn-qingdao</b>: China (Qingdao).</para>
            /// </description></item>
            /// <item><description><para><b>cn-hongkong</b>: China (Hong Kong).</para>
            /// </description></item>
            /// <item><description><para><b>ap-southeast-3</b>: Malaysia (Kuala Lumpur).</para>
            /// </description></item>
            /// <item><description><para><b>ap-southeast-5</b>: Indonesia (Jakarta).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("ResourceRegionId")]
            [Validation(Required=false)]
            public string ResourceRegionId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FDCBAE1E-2B3F-5C13-AD20-844B9473****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
