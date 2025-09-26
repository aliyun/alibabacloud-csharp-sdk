// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCloudAssetInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the cloud assets.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListCloudAssetInstancesResponseBodyInstances> Instances { get; set; }
        public class ListCloudAssetInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>Indicates whether alerts are generated for the cloud asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>YES</b></description></item>
            /// <item><description><b>NO</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NO</para>
            /// </summary>
            [NameInMap("AlarmStatus")]
            [Validation(Required=false)]
            public string AlarmStatus { get; set; }

            /// <summary>
            /// <para>The subtype of the cloud service. The subtype of the cloud asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: ECS</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: instance</description></item>
            /// <item><description><b>1</b>: disk (storage)</description></item>
            /// <item><description><b>2</b>: security group</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>1</b>: SLB</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: SLB</description></item>
            /// <item><description><b>1</b>: Application Load Balancer (ALB)</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>3</b>: ApsaraDB RDS</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>4</b>: ApsaraDB for MongoDB</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>5</b>: ApsaraDB for Redis</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>6</b>: Container Registry</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Enterprise Edition</description></item>
            /// <item><description><b>2</b>: Personal Edition</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>8</b>: ACK</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: cluster</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>9</b>: VPC</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: NAT gateway</description></item>
            /// <item><description><b>1</b>: EIP</description></item>
            /// <item><description><b>2</b>: VPN</description></item>
            /// <item><description><b>3</b>: FLOW_LOG</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>11</b>: ActionTrail</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: trail</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>12</b>: Alibaba Cloud CDN</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>13</b>: Certificate Management Service (formerly SSL Certificates Service)</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: certificate</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>14</b>: Apsara Devops</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: organization</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>16</b>: Anti-DDoS</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>17</b>: WAF</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: domain name</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>18</b>: OSS</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: bucket</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>19</b>: PolarDB</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: cluster</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>20</b>: ApsaraDB RDS for PostgreSQL</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>21</b>: MSE</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: cluster</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>22</b>: NAS</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: file system</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>23</b>: DSC</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>24</b>: EIP</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Anycast EIP</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>25</b>: IDaaS EIAM</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>26</b>: PolarDB-X</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>27</b>: Elasticsearch</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: instance</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetSubType")]
            [Validation(Required=false)]
            public string AssetSubType { get; set; }

            /// <summary>
            /// <para>The subtype name of the cloud asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SECURITY_GROUP</para>
            /// </summary>
            [NameInMap("AssetSubTypeName")]
            [Validation(Required=false)]
            public string AssetSubTypeName { get; set; }

            /// <summary>
            /// <para>The type of the cloud asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Elastic Compute Service (ECS)</description></item>
            /// <item><description><b>1</b>: Server Load Balancer (SLB)</description></item>
            /// <item><description><b>3</b>: ApsaraDB RDS</description></item>
            /// <item><description><b>4</b>: ApsaraDB for MongoDB</description></item>
            /// <item><description><b>5</b>: ApsaraDB for Redis</description></item>
            /// <item><description><b>6</b>: Container Registry</description></item>
            /// <item><description><b>8</b>: Container Service for Kubernetes (ACK)</description></item>
            /// <item><description><b>9</b>: Virtual Private Cloud (VPC)</description></item>
            /// <item><description><b>11</b>: ActionTrail</description></item>
            /// <item><description><b>12</b>: Alibaba Cloud CDN</description></item>
            /// <item><description><b>13</b>: Certificate Management Service (formerly SSL Certificates Service)</description></item>
            /// <item><description><b>14</b>: Apsara Devops</description></item>
            /// <item><description><b>16</b>: Anti-DDoS</description></item>
            /// <item><description><b>17</b>: Web Application Firewall (WAF)</description></item>
            /// <item><description><b>18</b>: Object Storage Service (OSS)</description></item>
            /// <item><description><b>19</b>: PolarDB</description></item>
            /// <item><description><b>20</b>: ApsaraDB RDS for PostgreSQL</description></item>
            /// <item><description><b>21</b>: Microservices Engine (MSE)</description></item>
            /// <item><description><b>22</b>: File Storage NAS (NAS)</description></item>
            /// <item><description><b>23</b>: Data Security Center (DSC)</description></item>
            /// <item><description><b>24</b>: Elastic IP Address (EIP)</description></item>
            /// <item><description><b>25</b>: Identity as a Service (IDaaS) Employee Identity and Access Management (EIAM)</description></item>
            /// <item><description><b>26</b>: PolarDB-X</description></item>
            /// <item><description><b>27</b>: Elasticsearch</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            /// <summary>
            /// <para>The type name of the cloud asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("AssetTypeName")]
            [Validation(Required=false)]
            public string AssetTypeName { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1607365213000</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The instance ID of the cloud asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-uf60vevzkztnflx7cny5</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name of the cloud asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yztest-l***</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the cloud asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The ID of the region to which the cloud asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hanghzou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Indicates whether risks are detected on the cloud asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>YES</b></description></item>
            /// <item><description><b>NO</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NO</para>
            /// </summary>
            [NameInMap("RiskStatus")]
            [Validation(Required=false)]
            public string RiskStatus { get; set; }

            /// <summary>
            /// <para>The security information about the cloud asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;seriousNum&quot;:0,&quot;appNum&quot;:0,&quot;baselineMedium&quot;:0,&quot;remindNum&quot;:0,&quot;imageVulNntf&quot;:0,&quot;cveNum&quot;:0,&quot;vul&quot;:0,&quot;uuid&quot;:&quot;yuejia-test&quot;,&quot;emgNum&quot;:0,&quot;weakPWNum&quot;:0,&quot;imageMaliciousFileRemind&quot;:0,&quot;imageBaselineMedium&quot;:0,&quot;laterVulCount&quot;:0,&quot;cmsNum&quot;:0,&quot;imageMaliciousFileSerious&quot;:0,&quot;agentlessMalicious&quot;:0,&quot;suspNum&quot;:0,&quot;imageBaselineHigh&quot;:0,&quot;asapVulCount&quot;:0,&quot;imageVulLater&quot;:0,&quot;agentlessAll&quot;:0,&quot;sysNum&quot;:0,&quot;containerLater&quot;:0,&quot;containerSuspicious&quot;:0,&quot;imageBaselineNum&quot;:0,&quot;newSuspicious&quot;:0,&quot;nntfVulCount&quot;:0,&quot;scaNum&quot;:0,&quot;containerNntf&quot;:0,&quot;health&quot;:0,&quot;trojan&quot;:0,&quot;suspicious&quot;:0,&quot;imageMaliciousFileSuspicious&quot;:0,&quot;containerRemind&quot;:0,&quot;baselineLow&quot;:0,&quot;imageVulAsap&quot;:0,&quot;imageBaselineLow&quot;:0,&quot;containerAsap&quot;:0,&quot;agentlessBaseline&quot;:0,&quot;agentlessVulSca&quot;:0,&quot;agentlessVulCve&quot;:0,&quot;containerSerious&quot;:0,&quot;baselineHigh&quot;:0,&quot;account&quot;:0,&quot;baselineNum&quot;:5}</para>
            /// </summary>
            [NameInMap("SecurityInfo")]
            [Validation(Required=false)]
            public string SecurityInfo { get; set; }

            /// <summary>
            /// <para>Tag list.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            /// <summary>
            /// <para>The service provider (SP) of the cloud asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: a cloud asset provided by Alibaba Cloud</description></item>
            /// <item><description><b>1</b>: a third-party cloud asset</description></item>
            /// <item><description><b>2</b>: a cloud asset in a data center</description></item>
            /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, and <b>7</b>: other cloud asset</description></item>
            /// <item><description><b>8</b>: a lightweight cloud asset</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

            [NameInMap("VendorUid")]
            [Validation(Required=false)]
            public string VendorUid { get; set; }

            [NameInMap("VendorUserName")]
            [Validation(Required=false)]
            public string VendorUserName { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCloudAssetInstancesResponseBodyPageInfo PageInfo { get; set; }
        public class ListCloudAssetInstancesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of cloud assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>028CF634-5268-5660-9575-48C9ED6BF880</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
