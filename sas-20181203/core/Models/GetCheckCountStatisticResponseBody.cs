// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckCountStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>List of risk item count statistics results.</para>
        /// </summary>
        [NameInMap("CheckCountStatisticDTO")]
        [Validation(Required=false)]
        public GetCheckCountStatisticResponseBodyCheckCountStatisticDTO CheckCountStatisticDTO { get; set; }
        public class GetCheckCountStatisticResponseBodyCheckCountStatisticDTO : TeaModel {
            /// <summary>
            /// <para>Risk item count statistics results.</para>
            /// </summary>
            [NameInMap("CheckCountStatisticItems")]
            [Validation(Required=false)]
            public List<GetCheckCountStatisticResponseBodyCheckCountStatisticDTOCheckCountStatisticItems> CheckCountStatisticItems { get; set; }
            public class GetCheckCountStatisticResponseBodyCheckCountStatisticDTOCheckCountStatisticItems : TeaModel {
                /// <summary>
                /// <para>Cloud product instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-wz9bpxyu6t74qn9g****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Instance name of the asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>launch-advisor-2021****</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>Subtype of the cloud product.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InstanceSubType")]
                [Validation(Required=false)]
                public int? InstanceSubType { get; set; }

                /// <summary>
                /// <para>The subtype of the cloud product. Values:  </para>
                /// <list type="bullet">
                /// <item><description>When <b>InstanceType</b> is <b>ECS</b>, this parameter can take the following values:  <list type="bullet">
                /// <item><description><b>INSTANCE</b>  </description></item>
                /// <item><description><b>DISK</b>  </description></item>
                /// <item><description><b>SECURITY_GROUP</b></description></item>
                /// </list>
                /// </description></item>
                /// <item><description>When <b>InstanceType</b> is <b>ACR</b>, this parameter can take the following values:  <list type="bullet">
                /// <item><description><b>REPOSITORY_ENTERPRISE</b>  </description></item>
                /// <item><description><b>REPOSITORY_PERSON</b></description></item>
                /// </list>
                /// </description></item>
                /// <item><description>When <b>InstanceType</b> is <b>RAM</b>, this parameter can take the following values:  <list type="bullet">
                /// <item><description><b>ALIAS</b>  </description></item>
                /// <item><description><b>USER</b>  </description></item>
                /// <item><description><b>POLICY</b>  </description></item>
                /// <item><description><b>GROUP</b></description></item>
                /// </list>
                /// </description></item>
                /// <item><description>When <b>InstanceType</b> is <b>WAF</b>, this parameter can take the following value:  <list type="bullet">
                /// <item><description><b>DOMAIN</b></description></item>
                /// </list>
                /// </description></item>
                /// <item><description>For other <b>InstanceType</b> values, this parameter takes the value:  <list type="bullet">
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
                /// <para>Type of the cloud product. Values:  </para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: ECS (Elastic Compute Service)</description></item>
                /// <item><description><b>1</b>: SLB (Server Load Balancer)</description></item>
                /// <item><description><b>2</b>: NAT Gateway</description></item>
                /// <item><description><b>3</b>: RDS (Relational Database Service) Database</description></item>
                /// <item><description><b>4</b>: MongoDB Database</description></item>
                /// <item><description><b>5</b>: Redis Database</description></item>
                /// <item><description><b>6</b>: Container Image</description></item>
                /// <item><description><b>7</b>: Container</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public int? InstanceType { get; set; }

                /// <summary>
                /// <para>The asset type of cloud products. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>ECS</b>: Elastic Compute Service </description></item>
                /// <item><description><b>SLB</b>: Server Load Balancer </description></item>
                /// <item><description><b>RDS</b>: Relational Database Service </description></item>
                /// <item><description><b>MONGODB</b>: MongoDB Database </description></item>
                /// <item><description><b>KVSTORE</b>: Redis Database </description></item>
                /// <item><description><b>ACR</b>: Container Registry </description></item>
                /// <item><description><b>CSK</b>: CSK </description></item>
                /// <item><description><b>VPC</b>: Virtual Private Cloud </description></item>
                /// <item><description><b>ACTIONTRAIL</b>: Action Trail </description></item>
                /// <item><description><b>CDN</b>: Content Delivery Network </description></item>
                /// <item><description><b>CAS</b>: Digital Certificate Management Service (formerly SSL Certificates) </description></item>
                /// <item><description><b>RDC</b>: DevOps </description></item>
                /// <item><description><b>RAM</b>: Resource Access Management </description></item>
                /// <item><description><b>DDOS</b>: Distributed Denial of Service </description></item>
                /// <item><description><b>WAF</b>: Web Application Firewall </description></item>
                /// <item><description><b>OSS</b>: Object Storage Service </description></item>
                /// <item><description><b>POLARDB</b>: POLARDB </description></item>
                /// <item><description><b>POSTGRESQL</b>: PostgreSQL </description></item>
                /// <item><description><b>MSE</b>: MSE </description></item>
                /// <item><description><b>NAS</b>: Network Attached Storage </description></item>
                /// <item><description><b>SDDP</b>: Sensitive Data Discovery and Protection </description></item>
                /// <item><description><b>EIP</b>: Elastic IP</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ECS</para>
                /// </summary>
                [NameInMap("InstanceTypeName")]
                [Validation(Required=false)]
                public string InstanceTypeName { get; set; }

                /// <summary>
                /// <para>Region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Number of risks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("RiskCount")]
                [Validation(Required=false)]
                public int? RiskCount { get; set; }

                /// <summary>
                /// <para>Cloud vendor. Values:  </para>
                /// <list type="bullet">
                /// <item><description><b>ALIYUN</b>: Alibaba Cloud</description></item>
                /// <item><description><b>TENCENT</b>: Tencent Cloud</description></item>
                /// <item><description><b>MICROSOFT</b>: Azure</description></item>
                /// <item><description><b>AWS</b>: Amazon Web Services (AWS)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN</para>
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public int? Vendor { get; set; }

            }

            /// <summary>
            /// <para>The type of data statistics. Values:  </para>
            /// <list type="bullet">
            /// <item><description><b>user</b>: Top 5 over-authorized users.  </description></item>
            /// <item><description><b>role</b>: Top 5 over-authorized roles.  </description></item>
            /// <item><description><b>instance</b>: Top 5 risky cloud products.</description></item>
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
        /// <para>The ID of this call request, which is a unique identifier generated by Alibaba Cloud for this request and can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20456DD5-5CBF-5015-9173-12CA4246B***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
