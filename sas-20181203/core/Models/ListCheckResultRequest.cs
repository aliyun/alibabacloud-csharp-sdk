// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckResultRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the check items.</para>
        /// </summary>
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
        /// <para>Source type of the situation awareness check item.</para>
        /// </summary>
        [NameInMap("CheckTypes")]
        [Validation(Required=false)]
        public List<string> CheckTypes { get; set; }

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
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b></para>
        /// </description></item>
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
        /// <item><description><para><b>ECS</b>: Elastic Compute Service (ECS)</para>
        /// </description></item>
        /// <item><description><para><b>SLB</b>: Server Load Balancer (SLB)</para>
        /// </description></item>
        /// <item><description><para><b>RDS</b>: ApsaraDB RDS</para>
        /// </description></item>
        /// <item><description><para><b>MONGODB</b>: ApsaraDB for MongoDB (MongoDB)</para>
        /// </description></item>
        /// <item><description><para><b>KVSTORE</b>: ApsaraDB for Redis (Redis)</para>
        /// </description></item>
        /// <item><description><para><b>ACR</b>: Container Registry</para>
        /// </description></item>
        /// <item><description><para><b>CSK</b>: Container Service for Kubernetes (ACK)</para>
        /// </description></item>
        /// <item><description><para><b>VPC</b>: Virtual Private Cloud (VPC)</para>
        /// </description></item>
        /// <item><description><para><b>ACTIONTRAIL</b>: ActionTrail</para>
        /// </description></item>
        /// <item><description><para><b>CDN</b>: Alibaba Cloud CDN (CDN)</para>
        /// </description></item>
        /// <item><description><para><b>CAS</b>: Certificate Management Service (formerly SSL Certificates Service)</para>
        /// </description></item>
        /// <item><description><para><b>RDC</b>: Apsara Devops</para>
        /// </description></item>
        /// <item><description><para><b>RAM</b>: Resource Access Management (RAM)</para>
        /// </description></item>
        /// <item><description><para><b>DDOS</b>: Anti-DDoS</para>
        /// </description></item>
        /// <item><description><para><b>WAF</b>: Web Application Firewall (WAF)</para>
        /// </description></item>
        /// <item><description><para><b>OSS</b>: Object Storage Service (OSS)</para>
        /// </description></item>
        /// <item><description><para><b>POLARDB</b>: PolarDB</para>
        /// </description></item>
        /// <item><description><para><b>POSTGRESQL</b>: ApsaraDB RDS for PostgreSQL</para>
        /// </description></item>
        /// <item><description><para><b>MSE</b>: Microservices Engine (MSE)</para>
        /// </description></item>
        /// <item><description><para><b>NAS</b>: File Storage NAS (NAS)</para>
        /// </description></item>
        /// <item><description><para><b>SDDP</b>: Sensitive Data Discovery and Protection (SDDP)</para>
        /// </description></item>
        /// <item><description><para><b>EIP</b>: Elastic IP Address (EIP)</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies whether fixing is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>SUPPORT_REPAIR</b></para>
        /// </description></item>
        /// <item><description><para><b>NOT_SUPPORT_REPAIR</b></para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("OperationTypes")]
        [Validation(Required=false)]
        public List<string> OperationTypes { get; set; }

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
        /// <item><description><para><b>cn-hangzhou</b>: International</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: Singapore</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IDs of the requirements.</para>
        /// </summary>
        [NameInMap("RequirementIds")]
        [Validation(Required=false)]
        public List<long?> RequirementIds { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member in the resource directory.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain the IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>127608589417****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The risk levels of check items. Separate multiple risk levels with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HIGH</b></para>
        /// </description></item>
        /// <item><description><para><b>MEDIUM</b></para>
        /// </description></item>
        /// <item><description><para><b>LOW</b></para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("RiskLevels")]
        [Validation(Required=false)]
        public List<string> RiskLevels { get; set; }

        /// <summary>
        /// <para>The types of the conditions based on which check items are sorted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RISK_LEVEL</b>: risk level</para>
        /// </description></item>
        /// <item><description><para><b>STATUS</b>: status</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("SortTypes")]
        [Validation(Required=false)]
        public List<string> SortTypes { get; set; }

        /// <summary>
        /// <para>The standard IDs.</para>
        /// </summary>
        [NameInMap("StandardIds")]
        [Validation(Required=false)]
        public List<long?> StandardIds { get; set; }

        /// <summary>
        /// <para>The statuses of check items. Separate multiple statuses with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PASS</b></para>
        /// </description></item>
        /// <item><description><para><b>NOT_PASS</b></para>
        /// </description></item>
        /// <item><description><para><b>CHECKING</b></para>
        /// </description></item>
        /// <item><description><para><b>NOT_CHECK</b></para>
        /// </description></item>
        /// <item><description><para><b>WHITELIST</b></para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

        /// <summary>
        /// <para>Delete the custom category in a custom inspection item.</para>
        /// </summary>
        [NameInMap("TaskSources")]
        [Validation(Required=false)]
        public List<string> TaskSources { get; set; }

        /// <summary>
        /// <para>The types of check standards.</para>
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public List<string> Types { get; set; }

        /// <summary>
        /// <para>The cloud service providers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ALIYUN</b>: Alibaba Cloud</para>
        /// </description></item>
        /// <item><description><para><b>TENCENT</b>: Tencent Cloud</para>
        /// </description></item>
        /// <item><description><para><b>AWS</b>: Amazon Web Services (AWS)</para>
        /// </description></item>
        /// <item><description><para><b>MICROSOFT</b>: Microsoft Azure</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<string> Vendors { get; set; }

    }

}
