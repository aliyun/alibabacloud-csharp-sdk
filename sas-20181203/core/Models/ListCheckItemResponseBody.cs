// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckItemResponseBody : TeaModel {
        /// <summary>
        /// <para>The check items.</para>
        /// </summary>
        [NameInMap("CheckItems")]
        [Validation(Required=false)]
        public List<ListCheckItemResponseBodyCheckItems> CheckItems { get; set; }
        public class ListCheckItemResponseBodyCheckItems : TeaModel {
            /// <summary>
            /// <para>The ID of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// <para>The name of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4 Access Control</para>
            /// </summary>
            [NameInMap("CheckShowName")]
            [Validation(Required=false)]
            public string CheckShowName { get; set; }

            /// <summary>
            /// <para>The source type of the Situation Awareness check item:</para>
            /// <list type="bullet">
            /// <item><description><para><b>CUSTOM</b>: User-defined</para>
            /// </description></item>
            /// <item><description><para><b>SYSTEM</b>: Predefined by the Situation Awareness platform</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public string CheckType { get; set; }

            /// <summary>
            /// <para>The check items.</para>
            /// </summary>
            [NameInMap("CustomConfigs")]
            [Validation(Required=false)]
            public List<ListCheckItemResponseBodyCheckItemsCustomConfigs> CustomConfigs { get; set; }
            public class ListCheckItemResponseBodyCheckItemsCustomConfigs : TeaModel {
                /// <summary>
                /// <para>The default value of the check item. The value is a string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>The name of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IPList</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The display name of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IP列表</para>
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// <para>The type of the check item. The value is a JSON string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;type\&quot;:\&quot;LIST\&quot;,\&quot;range\&quot;:[1,512],\&quot;listType\&quot;:{\&quot;type\&quot;:\&quot;STRING\&quot;,\&quot;range\&quot;:[0,22]}}</para>
                /// </summary>
                [NameInMap("TypeDefine")]
                [Validation(Required=false)]
                public string TypeDefine { get; set; }

                /// <summary>
                /// <para>The specified value of the check item. The value is a string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The description of the check item.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public ListCheckItemResponseBodyCheckItemsDescription Description { get; set; }
            public class ListCheckItemResponseBodyCheckItemsDescription : TeaModel {
                /// <summary>
                /// <para>The type of the description of the check item. Valid value:</para>
                /// <list type="bullet">
                /// <item><description><b>text</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The content of the description for the check item when the Type parameter is text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Checks whether strict access control policies are configured. Requirements: 1. If no blacklists and whitelist are configured, configure a whitelist first. 2. If a blacklist is configured, find the blacklist in the list of access control policies. We recommend that you do not configure an empty blacklist. 3. If a whitelist is configured, find the whitelist in the list of access control policies. We recommend that you do not configure an empty whitelist. Make sure that the whitelist does not contain 0.0.0.0. You can add the following IP addresses to the whitelist: ${IPList}.</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The estimated quota that will be consumed by this check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("EstimatedCount")]
            [Validation(Required=false)]
            public int? EstimatedCount { get; set; }

            /// <summary>
            /// <para>The asset subtype of the cloud service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If <b>InstanceType</b> is set to <b>ECS</b>, this parameter supports the following valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>INSTANCE</b></para>
            /// </description></item>
            /// <item><description><para><b>DISK</b></para>
            /// </description></item>
            /// <item><description><para><b>SECURITY_GROUP</b></para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If <b>InstanceType</b> is set to <b>ACR</b>, this parameter supports the following valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>REPOSITORY_ENTERPRISE</b></para>
            /// </description></item>
            /// <item><description><para><b>REPOSITORY_PERSON</b></para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If <b>InstanceType</b> is set to <b>RAM</b>, this parameter supports the following valid values:</para>
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
            /// <item><description><para>If <b>InstanceType</b> is set to <b>WAF</b>, this parameter supports the following valid value:</para>
            /// <list type="bullet">
            /// <item><description><b>DOMAIN</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If <b>InstanceType</b> is set to other values, this parameter supports the following valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INSTANCE</b></description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INSTANCE</para>
            /// </summary>
            [NameInMap("InstanceSubType")]
            [Validation(Required=false)]
            public string InstanceSubType { get; set; }

            /// <summary>
            /// <para>The asset type of the cloud service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ECS</b>: Elastic Compute Service (ECS).</para>
            /// </description></item>
            /// <item><description><para><b>SLB</b>: Server Load Balancer (SLB).</para>
            /// </description></item>
            /// <item><description><para><b>RDS</b>: ApsaraDB RDS.</para>
            /// </description></item>
            /// <item><description><para><b>MONGODB</b>: ApsaraDB for MongoDB (MongoDB).</para>
            /// </description></item>
            /// <item><description><para><b>KVSTORE</b>: ApsaraDB for Redis (Redis).</para>
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
            /// <item><description><para><b>RDC</b>: Apsara Devops.</para>
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
            /// <para>API_GATEWAY</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The risk level of the check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>HIGH</b></para>
            /// </description></item>
            /// <item><description><para><b>MEDIUM</b></para>
            /// </description></item>
            /// <item><description><para><b>LOW</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HIGH</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The IDs of the sections associated with the check items.</para>
            /// </summary>
            [NameInMap("SectionIds")]
            [Validation(Required=false)]
            public List<long?> SectionIds { get; set; }

            /// <summary>
            /// <para>The type of the cloud asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: an asset provided by Alibaba Cloud.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: an asset outside Alibaba Cloud.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: an asset in a data center.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>, <b>4</b>, <b>5</b>, and <b>7</b>: other cloud asset.</para>
            /// </description></item>
            /// <item><description><para><b>8</b>: a simple application server.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCheckItemResponseBodyPageInfo PageInfo { get; set; }
        public class ListCheckItemResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>149</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9F4E6157-9600-5588-86B9-38F09067****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
