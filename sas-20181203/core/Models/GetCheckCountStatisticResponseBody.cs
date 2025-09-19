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
                /// <item><description><b>INSTANCE</b></description></item>
                /// <item><description><b>DISK</b></description></item>
                /// <item><description><b>SECURITY_GROUP</b></description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>InstanceTypeName</b> is set to <b>ACR</b>, this parameter supports the following valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>REPOSITORY_ENTERPRISE</b></description></item>
                /// <item><description><b>REPOSITORY_PERSON</b></description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>InstanceTypeName</b> is set to <b>RAM</b>, this parameter supports the following valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ALIAS</b></description></item>
                /// <item><description><b>USER</b></description></item>
                /// <item><description><b>POLICY</b></description></item>
                /// <item><description><b>GROUP</b></description></item>
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
                /// <item><description><b>0</b>: Elastic Compute Service (ECS) instance.</description></item>
                /// <item><description><b>1</b>: Server Load Balancer (SLB) instance.</description></item>
                /// <item><description><b>2</b>: NAT gateway.</description></item>
                /// <item><description><b>3</b>: ApsaraDB RDS instance.</description></item>
                /// <item><description><b>4</b>: ApsaraDB for MongoDB (MongoDB) instance.</description></item>
                /// <item><description><b>5</b>: Tair (Redis OSS-compatible) (Tair) instance.</description></item>
                /// <item><description><b>6</b>: container image.</description></item>
                /// <item><description><b>7</b>: container.</description></item>
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
                /// <item><description><b>ECS</b>: ECS.</description></item>
                /// <item><description><b>SLB</b>: SLB.</description></item>
                /// <item><description><b>RDS</b>: ApsaraDB RDS.</description></item>
                /// <item><description><b>MONGODB</b>: ApsaraDB for MongoDB.</description></item>
                /// <item><description><b>KVSTORE</b>: Tair.</description></item>
                /// <item><description><b>ACR</b>: Container Registry.</description></item>
                /// <item><description><b>CSK</b>: Container Service for Kubernetes (ACK).</description></item>
                /// <item><description><b>VPC</b>: Virtual Private Cloud (VPC).</description></item>
                /// <item><description><b>ACTIONTRAIL</b>: ActionTrail.</description></item>
                /// <item><description><b>CDN</b>: Alibaba Cloud CDN (CDN).</description></item>
                /// <item><description><b>CAS</b>: Certificate Management Service (formerly SSL Certificates Service).</description></item>
                /// <item><description><b>RDC</b>: Alibaba Cloud DevOps.</description></item>
                /// <item><description><b>RAM</b>: Resource Access Management (RAM).</description></item>
                /// <item><description><b>DDOS</b>: Anti-DDoS.</description></item>
                /// <item><description><b>WAF</b>: Web Application Firewall (WAF).</description></item>
                /// <item><description><b>OSS</b>: Object Storage Service (OSS).</description></item>
                /// <item><description><b>POLARDB</b>: PolarDB.</description></item>
                /// <item><description><b>POSTGRESQL</b>: ApsaraDB RDS for PostgreSQL.</description></item>
                /// <item><description><b>MSE</b>: Microservices Engine (MSE).</description></item>
                /// <item><description><b>NAS</b>: File Storage NAS (NAS).</description></item>
                /// <item><description><b>SDDP</b>: Sensitive Data Discovery and Protection (SDDP).</description></item>
                /// <item><description><b>EIP</b>: Elastic IP Address (EIP).</description></item>
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
                /// <item><description><b>ALIYUN</b>: Alibaba Cloud.</description></item>
                /// <item><description><b>TENCENT</b>: Tencent Cloud.</description></item>
                /// <item><description><b>MICROSOFT</b>: Microsoft Azure.</description></item>
                /// <item><description><b>AWS</b>: AWS.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN</para>
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public int? Vendor { get; set; }

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
            /// <item><description><b>user</b>: the top five users that are granted excessive permissions.</description></item>
            /// <item><description><b>role</b>: the top five roles that are granted excessive permissions.</description></item>
            /// <item><description><b>instance</b>: the top five cloud services on which risks are detected.</description></item>
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
