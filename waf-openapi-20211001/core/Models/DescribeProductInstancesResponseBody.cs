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
            [NameInMap("AccessInstanceId")]
            [Validation(Required=false)]
            public string AccessInstanceId { get; set; }

            [NameInMap("AccessPortAndProtocols")]
            [Validation(Required=false)]
            public List<DescribeProductInstancesResponseBodyProductInstancesAccessPortAndProtocols> AccessPortAndProtocols { get; set; }
            public class DescribeProductInstancesResponseBodyProductInstancesAccessPortAndProtocols : TeaModel {
                [NameInMap("CertificateIds")]
                [Validation(Required=false)]
                public List<string> CertificateIds { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            [NameInMap("AccessPorts")]
            [Validation(Required=false)]
            public List<int?> AccessPorts { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1704********9107</para>
            /// </summary>
            [NameInMap("OwnerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            [NameInMap("ResourceInstanceAccessStatus")]
            [Validation(Required=false)]
            public string ResourceInstanceAccessStatus { get; set; }

            [NameInMap("ResourceInstanceEdition")]
            [Validation(Required=false)]
            public string ResourceInstanceEdition { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2ze1tm4pvghp****cluv</para>
            /// </summary>
            [NameInMap("ResourceInstanceId")]
            [Validation(Required=false)]
            public string ResourceInstanceId { get; set; }

            /// <summary>
            /// <para>The IP address of the instance that is added to WAF.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.X.X.1</para>
            /// </summary>
            [NameInMap("ResourceInstanceIp")]
            [Validation(Required=false)]
            public string ResourceInstanceIp { get; set; }

            /// <summary>
            /// <para>The name of the instance that is added to WAF.</para>
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
                    [NameInMap("AppliedType")]
                    [Validation(Required=false)]
                    public string AppliedType { get; set; }

                    /// <summary>
                    /// <para>The ID of the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10106183</para>
                    /// </summary>
                    [NameInMap("CertificateId")]
                    [Validation(Required=false)]
                    public string CertificateId { get; set; }

                    /// <summary>
                    /// <para>The name of the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>trafficxxxx.cn</para>
                    /// </summary>
                    [NameInMap("CertificateName")]
                    [Validation(Required=false)]
                    public string CertificateName { get; set; }

                    [NameInMap("Domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }

                }

                /// <summary>
                /// <para>The port number.</para>
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
                /// <item><description><b>http</b></description></item>
                /// <item><description><b>https</b></description></item>
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
            /// <para>The cloud service to which the instance belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>clb4</b>: Layer 4 CLB.</description></item>
            /// <item><description><b>clb7</b>: Layer 7 CLB.</description></item>
            /// <item><description><b>ecs</b>: ECS.</description></item>
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
            /// <item><description><b>cn-chengdu</b>: China (Chengdu).</description></item>
            /// <item><description><b>cn-beijing</b>: China (Beijing).</description></item>
            /// <item><description><b>cn-zhangjiakou</b>: China (Zhangjiakou).</description></item>
            /// <item><description><b>cn-hangzhou</b>: China (Hangzhou).</description></item>
            /// <item><description><b>cn-shanghai</b>: China (Shanghai).</description></item>
            /// <item><description><b>cn-shenzhen</b>: China (Shenzhen).</description></item>
            /// <item><description><b>cn-qingdao</b>: China (Qingdao).</description></item>
            /// <item><description><b>cn-hongkong</b>: China (Hong Kong).</description></item>
            /// <item><description><b>ap-southeast-3</b>: Malaysia (Kuala Lumpur).</description></item>
            /// <item><description><b>ap-southeast-5</b>: Indonesia (Jakarta).</description></item>
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
