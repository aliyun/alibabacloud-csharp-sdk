// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckCountStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The risk item statistics.</para>
        /// </summary>
        [NameInMap("CheckCountStatisticDTO")]
        [Validation(Required=false)]
        public GetCheckCountStatisticResponseBodyCheckCountStatisticDTO CheckCountStatisticDTO { get; set; }
        public class GetCheckCountStatisticResponseBodyCheckCountStatisticDTO : TeaModel {
            /// <summary>
            /// <para>The risk item statistics.</para>
            /// </summary>
            [NameInMap("CheckCountStatisticItems")]
            [Validation(Required=false)]
            public List<GetCheckCountStatisticResponseBodyCheckCountStatisticDTOCheckCountStatisticItems> CheckCountStatisticItems { get; set; }
            public class GetCheckCountStatisticResponseBodyCheckCountStatisticDTOCheckCountStatisticItems : TeaModel {
                /// <summary>
                /// <para>Check item display name</para>
                /// 
                /// <b>Example:</b>
                /// <para>开启公网访问</para>
                /// </summary>
                [NameInMap("CheckShowName")]
                [Validation(Required=false)]
                public string CheckShowName { get; set; }

                /// <summary>
                /// <para>The number of the CPU cores used by the host instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Cores")]
                [Validation(Required=false)]
                public int? Cores { get; set; }

                /// <summary>
                /// <para>The instance ID of the cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-wz9bpxyu6t74qn9g****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The instance name of the asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>launch-advisor-2021****</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The subtype of the cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InstanceSubType")]
                [Validation(Required=false)]
                public int? InstanceSubType { get; set; }

                /// <summary>
                /// <para>The asset subtype of the cloud service. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>If <b>InstanceTypeName</b> is set to <b>ECS</b>, this parameter supports the following valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>INSTANCE</b></para>
                /// </description></item>
                /// <item><description><para><b>DISK</b></para>
                /// </description></item>
                /// <item><description><para><b>SECURITY_GROUP</b></para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>InstanceTypeName</b> is set to <b>ACR</b>, this parameter supports the following valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>REPOSITORY_ENTERPRISE</b></para>
                /// </description></item>
                /// <item><description><para><b>REPOSITORY_PERSON</b></para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>InstanceTypeName</b> is set to <b>RAM</b>, this parameter supports the following valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>ALIAS</b></para>
                /// </description></item>
                /// <item><description><para><b>USER</b></para>
                /// </description></item>
                /// <item><description><para><b>POLICY</b></para>
                /// </description></item>
                /// <item><description><para><b>GROUP</b></para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>InstanceTypeName</b> is set to <b>WAF</b>, this parameter supports the following valid value:</para>
                /// <list type="bullet">
                /// <item><description><b>DOMAIN</b></description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>InstanceTypeName</b> is set to other values, this parameter supports the following valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>INSTANCE</b></description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>INSTANCE</para>
                /// </summary>
                [NameInMap("InstanceSubTypeName")]
                [Validation(Required=false)]
                public string InstanceSubTypeName { get; set; }

                /// <summary>
                /// <para>The asset type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: Elastic Compute Service (ECS) instance.</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: Server Load Balancer (SLB) instance.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: NAT gateway.</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: ApsaraDB RDS instance.</para>
                /// </description></item>
                /// <item><description><para><b>4</b>: ApsaraDB for MongoDB (MongoDB) instance.</para>
                /// </description></item>
                /// <item><description><para><b>5</b>: Tair (Redis OSS-compatible) (Tair) instance.</para>
                /// </description></item>
                /// <item><description><para><b>6</b>: container image.</para>
                /// </description></item>
                /// <item><description><para><b>7</b>: container.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public int? InstanceType { get; set; }

                /// <summary>
                /// <para>The asset type of the cloud service. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>ECS</b>: ECS.</para>
                /// </description></item>
                /// <item><description><para><b>SLB</b>: SLB.</para>
                /// </description></item>
                /// <item><description><para><b>RDS</b>: ApsaraDB RDS.</para>
                /// </description></item>
                /// <item><description><para><b>MONGODB</b>: ApsaraDB for MongoDB.</para>
                /// </description></item>
                /// <item><description><para><b>KVSTORE</b>: Tair.</para>
                /// </description></item>
                /// <item><description><para><b>ACR</b>: Container Registry.</para>
                /// </description></item>
                /// <item><description><para><b>CSK</b>: Container Service for Kubernetes (ACK).</para>
                /// </description></item>
                /// <item><description><para><b>VPC</b>: Virtual Private Cloud (VPC).</para>
                /// </description></item>
                /// <item><description><para><b>ACTIONTRAIL</b>: ActionTrail.</para>
                /// </description></item>
                /// <item><description><para><b>CDN</b>: Alibaba Cloud CDN (CDN).</para>
                /// </description></item>
                /// <item><description><para><b>CAS</b>: Certificate Management Service (formerly SSL Certificates Service).</para>
                /// </description></item>
                /// <item><description><para><b>RDC</b>: Alibaba Cloud DevOps.</para>
                /// </description></item>
                /// <item><description><para><b>RAM</b>: Resource Access Management (RAM).</para>
                /// </description></item>
                /// <item><description><para><b>DDOS</b>: Anti-DDoS.</para>
                /// </description></item>
                /// <item><description><para><b>WAF</b>: Web Application Firewall (WAF).</para>
                /// </description></item>
                /// <item><description><para><b>OSS</b>: Object Storage Service (OSS).</para>
                /// </description></item>
                /// <item><description><para><b>POLARDB</b>: PolarDB.</para>
                /// </description></item>
                /// <item><description><para><b>POSTGRESQL</b>: ApsaraDB RDS for PostgreSQL.</para>
                /// </description></item>
                /// <item><description><para><b>MSE</b>: Microservices Engine (MSE).</para>
                /// </description></item>
                /// <item><description><para><b>NAS</b>: File Storage NAS (NAS).</para>
                /// </description></item>
                /// <item><description><para><b>SDDP</b>: Sensitive Data Discovery and Protection (SDDP).</para>
                /// </description></item>
                /// <item><description><para><b>EIP</b>: Elastic IP Address (EIP).</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ECS</para>
                /// </summary>
                [NameInMap("InstanceTypeName")]
                [Validation(Required=false)]
                public string InstanceTypeName { get; set; }

                /// <summary>
                /// <para>The public IP address of the host instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2.XX.XX</para>
                /// </summary>
                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                /// <summary>
                /// <para>The private IP address of the host instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2.XX.XX</para>
                /// </summary>
                [NameInMap("IntranetIp")]
                [Validation(Required=false)]
                public string IntranetIp { get; set; }

                /// <summary>
                /// <para>The version of the operating system that the host instance runs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>linux</para>
                /// </summary>
                [NameInMap("Os")]
                [Validation(Required=false)]
                public string Os { get; set; }

                /// <summary>
                /// <para>The region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The number of risk items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("RiskCount")]
                [Validation(Required=false)]
                public int? RiskCount { get; set; }

                /// <summary>
                /// <para>The UUID of the host instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c9107c04-942f-40c1-981a-f1c1****</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

                /// <summary>
                /// <para>The cloud service provider. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>ALIYUN</b>: Alibaba Cloud.</para>
                /// </description></item>
                /// <item><description><para><b>TENCENT</b>: Tencent Cloud.</para>
                /// </description></item>
                /// <item><description><para><b>MICROSOFT</b>: Microsoft Azure.</para>
                /// </description></item>
                /// <item><description><para><b>AWS</b>: AWS.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN</para>
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public int? Vendor { get; set; }

                /// <summary>
                /// <para>Vendor name</para>
                /// 
                /// <b>Example:</b>
                /// <para>阿里云</para>
                /// </summary>
                [NameInMap("VendorShowName")]
                [Validation(Required=false)]
                public string VendorShowName { get; set; }

                /// <summary>
                /// <para>The ID of the VPC to which the host instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf60agqq65bs98zoo****</para>
                /// </summary>
                [NameInMap("VpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }

            }

            /// <summary>
            /// <para>The type of the statistics. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>user</b>: the top five users that are granted excessive permissions.</para>
            /// </description></item>
            /// <item><description><para><b>role</b>: the top five roles that are granted excessive permissions.</para>
            /// </description></item>
            /// <item><description><para><b>instance</b>: the top five cloud services on which risks are detected.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("StatisticType")]
            [Validation(Required=false)]
            public string StatisticType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20456DD5-5CBF-5015-9173-12CA4246B***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
