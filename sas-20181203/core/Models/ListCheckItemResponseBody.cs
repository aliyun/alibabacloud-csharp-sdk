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
            /// <para>Enable deletion protection</para>
            /// </summary>
            [NameInMap("CheckShowName")]
            [Validation(Required=false)]
            public string CheckShowName { get; set; }

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
                /// <para>Ensure RAM password policy prevents password reuse</para>
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
                /// <para>The download of query results that are returned by SELECT statements in DataStudio must be prohibited at the MaxCompute level.</para>
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
            /// <item><description><b>INSTANCE</b></description></item>
            /// <item><description><b>DISK</b></description></item>
            /// <item><description><b>SECURITY_GROUP</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If <b>InstanceType</b> is set to <b>ACR</b>, this parameter supports the following valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>REPOSITORY_ENTERPRISE</b></description></item>
            /// <item><description><b>REPOSITORY_PERSON</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If <b>InstanceType</b> is set to <b>RAM</b>, this parameter supports the following valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ALIAS</b></description></item>
            /// <item><description><b>USER</b></description></item>
            /// <item><description><b>POLICY</b></description></item>
            /// <item><description><b>GROUP</b></description></item>
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
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("InstanceSubType")]
            [Validation(Required=false)]
            public string InstanceSubType { get; set; }

            /// <summary>
            /// <para>The asset type of the cloud service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ECS</b>: Elastic Compute Service (ECS).</description></item>
            /// <item><description><b>SLB</b>: Server Load Balancer (SLB).</description></item>
            /// <item><description><b>RDS</b>: ApsaraDB RDS.</description></item>
            /// <item><description><b>MONGODB</b>: ApsaraDB for MongoDB (MongoDB).</description></item>
            /// <item><description><b>KVSTORE</b>: ApsaraDB for Redis (Redis).</description></item>
            /// <item><description><b>ACR</b>: Container Registry.</description></item>
            /// <item><description><b>CSK</b>: Container Service for Kubernetes (ACK).</description></item>
            /// <item><description><b>VPC</b>: Virtual Private Cloud (VPC).</description></item>
            /// <item><description><b>ACTIONTRAIL</b>: ActionTrail.</description></item>
            /// <item><description><b>CDN</b>: Alibaba Cloud CDN (CDN).</description></item>
            /// <item><description><b>CAS</b>: Certificate Management Service (formerly SSL Certificates Service).</description></item>
            /// <item><description><b>RDC</b>: Apsara Devops.</description></item>
            /// <item><description><b>RAM</b>: Resource Access Management (RAM).</description></item>
            /// <item><description><b>DDOS</b>: Anti-DDoS.</description></item>
            /// <item><description><b>WAF</b>: Web Application Firewall (WAF).</description></item>
            /// <item><description><b>OSS</b>: Object Storage Service (OSS).</description></item>
            /// <item><description><b>POLARDB</b>: PolarDB.</description></item>
            /// <item><description><b>POSTGRESQL</b>: ApsaraDB RDS for PostgreSQL.</description></item>
            /// <item><description><b>MSE</b>: Microservices Engine (MSE).</description></item>
            /// <item><description><b>NAS</b>: Apsara File Storage NAS (NAS).</description></item>
            /// <item><description><b>SDDP</b>: Sensitive Data Discovery and Protection (SDDP).</description></item>
            /// <item><description><b>EIP</b>: Elastic IP Address (EIP).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The risk level of the check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>HIGH</b></description></item>
            /// <item><description><b>MEDIUM</b></description></item>
            /// <item><description><b>LOW</b></description></item>
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
            /// <item><description><b>0</b>: an asset provided by Alibaba Cloud.</description></item>
            /// <item><description><b>1</b>: an asset outside Alibaba Cloud.</description></item>
            /// <item><description><b>2</b>: an asset in a data center.</description></item>
            /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, and <b>7</b>: other cloud asset.</description></item>
            /// <item><description><b>8</b>: a simple application server.</description></item>
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
