// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckResultRequest : TeaModel {
        [NameInMap("CheckIds")]
        [Validation(Required=false)]
        public List<long?> CheckIds { get; set; }

        /// <summary>
        /// <para>The key that you want to use to search for check items in fuzzy match mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("CheckKey")]
        [Validation(Required=false)]
        public string CheckKey { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Specifies whether the check item supports custom parameters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CustomParam")]
        [Validation(Required=false)]
        public bool? CustomParam { get; set; }

        /// <summary>
        /// <para>The instance IDs of the cloud services that you want to query. Separate multiple IDs with commas (,).</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The asset type of the cloud services. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS</b>: Elastic Compute Service (ECS)</description></item>
        /// <item><description><b>SLB</b>: Server Load Balancer (SLB)</description></item>
        /// <item><description><b>RDS</b>: ApsaraDB RDS</description></item>
        /// <item><description><b>MONGODB</b>: ApsaraDB for MongoDB (MongoDB)</description></item>
        /// <item><description><b>KVSTORE</b>: ApsaraDB for Redis (Redis)</description></item>
        /// <item><description><b>ACR</b>: Container Registry</description></item>
        /// <item><description><b>CSK</b>: Container Service for Kubernetes (ACK)</description></item>
        /// <item><description><b>VPC</b>: Virtual Private Cloud (VPC)</description></item>
        /// <item><description><b>ACTIONTRAIL</b>: ActionTrail</description></item>
        /// <item><description><b>CDN</b>: Alibaba Cloud CDN (CDN)</description></item>
        /// <item><description><b>CAS</b>: Certificate Management Service (formerly SSL Certificates Service)</description></item>
        /// <item><description><b>RDC</b>: Apsara Devops</description></item>
        /// <item><description><b>RAM</b>: Resource Access Management (RAM)</description></item>
        /// <item><description><b>DDOS</b>: Anti-DDoS</description></item>
        /// <item><description><b>WAF</b>: Web Application Firewall (WAF)</description></item>
        /// <item><description><b>OSS</b>: Object Storage Service (OSS)</description></item>
        /// <item><description><b>POLARDB</b>: PolarDB</description></item>
        /// <item><description><b>POSTGRESQL</b>: ApsaraDB RDS for PostgreSQL</description></item>
        /// <item><description><b>MSE</b>: Microservices Engine (MSE)</description></item>
        /// <item><description><b>NAS</b>: Apsara File Storage NAS (NAS)</description></item>
        /// <item><description><b>SDDP</b>: Sensitive Data Discovery and Protection (SDDP)</description></item>
        /// <item><description><b>EIP</b>: Elastic IP Address (EIP)</description></item>
        /// </list>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b>: International</description></item>
        /// <item><description><b>ap-southeast-1</b>: Singapore</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IDs of requirement items.</para>
        /// </summary>
        [NameInMap("RequirementIds")]
        [Validation(Required=false)]
        public List<long?> RequirementIds { get; set; }

        /// <summary>
        /// <para>The risk levels of check items. Separate multiple risk levels with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HIGH</b></description></item>
        /// <item><description><b>MEDIUM</b></description></item>
        /// <item><description><b>LOW</b></description></item>
        /// </list>
        /// </summary>
        [NameInMap("RiskLevels")]
        [Validation(Required=false)]
        public List<string> RiskLevels { get; set; }

        /// <summary>
        /// <para>The types of the conditions based on which check items are sorted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RISK_LEVEL</b>: risk level</description></item>
        /// <item><description><b>STATUS</b>: status</description></item>
        /// </list>
        /// </summary>
        [NameInMap("SortTypes")]
        [Validation(Required=false)]
        public List<string> SortTypes { get; set; }

        /// <summary>
        /// <para>The IDs of standards.</para>
        /// </summary>
        [NameInMap("StandardIds")]
        [Validation(Required=false)]
        public List<long?> StandardIds { get; set; }

        /// <summary>
        /// <para>The statuses of check items. Separate multiple statuses with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PASS</b></description></item>
        /// <item><description><b>NOT_PASS</b></description></item>
        /// <item><description><b>CHECKING</b></description></item>
        /// <item><description><b>NOT_CHECK</b></description></item>
        /// <item><description><b>WHITELIST</b></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

        /// <summary>
        /// <para>The types of check standards.</para>
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public List<string> Types { get; set; }

        /// <summary>
        /// <para>The cloud service providers. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>ALIYUN</b>: Alibaba Cloud</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<string> Vendors { get; set; }

    }

}
