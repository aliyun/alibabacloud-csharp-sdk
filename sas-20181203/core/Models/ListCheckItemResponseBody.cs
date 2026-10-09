// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckItemResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of check item information.</para>
        /// </summary>
        [NameInMap("CheckItems")]
        [Validation(Required=false)]
        public List<ListCheckItemResponseBodyCheckItems> CheckItems { get; set; }
        public class ListCheckItemResponseBodyCheckItems : TeaModel {
            /// <summary>
            /// <para>The check item ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// <para>The check item name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4 Access Control</para>
            /// </summary>
            [NameInMap("CheckShowName")]
            [Validation(Required=false)]
            public string CheckShowName { get; set; }

            /// <summary>
            /// <para>The source type of the Threat Detection Service check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CUSTOM</b>: user-defined</description></item>
            /// <item><description><b>SYSTEM</b>: predefined by the Threat Detection Service platform</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public string CheckType { get; set; }

            /// <summary>
            /// <para>The list of user-defined check configuration information.</para>
            /// </summary>
            [NameInMap("CustomConfigs")]
            [Validation(Required=false)]
            public List<ListCheckItemResponseBodyCheckItemsCustomConfigs> CustomConfigs { get; set; }
            public class ListCheckItemResponseBodyCheckItemsCustomConfigs : TeaModel {
                /// <summary>
                /// <para>The default value string of the custom configuration item for the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>The name of the user-defined check configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IPList</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The display name of the user-defined check configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IP list</para>
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// <para>The JSON string that defines the type of the custom configuration item for the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;type\&quot;:\&quot;LIST\&quot;,\&quot;range\&quot;:[1,512],\&quot;listType\&quot;:{\&quot;type\&quot;:\&quot;STRING\&quot;,\&quot;range\&quot;:[0,22]}}</para>
                /// </summary>
                [NameInMap("TypeDefine")]
                [Validation(Required=false)]
                public string TypeDefine { get; set; }

                /// <summary>
                /// <para>The user-configured value string of the custom configuration item for the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The check item description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public ListCheckItemResponseBodyCheckItemsDescription Description { get; set; }
            public class ListCheckItemResponseBodyCheckItemsDescription : TeaModel {
                /// <summary>
                /// <para>The type of the check description attribute. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>text</b>: text</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The text content when the check item risk description type is text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Checks whether strict access control policies are configured. Requirements: 1. If no blacklists and whitelist are configured, configure a whitelist first. 2. If a blacklist is configured, find the blacklist in the list of access control policies. We recommend that you do not configure an empty blacklist. 3. If a whitelist is configured, find the whitelist in the list of access control policies. We recommend that you do not configure an empty whitelist. Make sure that the whitelist does not contain 0.0.0.0. You can add the following IP addresses to the whitelist: ${IPList}.</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The estimated number of licenses that the check item will consume.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("EstimatedCount")]
            [Validation(Required=false)]
            public int? EstimatedCount { get; set; }

            /// <summary>
            /// <para>The estimated number of instances affected by the check item.</para>
            /// </summary>
            [NameInMap("InstanceEstimatedCount")]
            [Validation(Required=false)]
            public int? InstanceEstimatedCount { get; set; }

            /// <summary>
            /// <para>The asset subtype of the cloud service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>When <b>InstanceType</b> is set to <b>ECS</b>, valid values are:<list type="bullet">
            /// <item><description><b>INSTANCE</b></description></item>
            /// <item><description><b>DISK</b></description></item>
            /// <item><description><b>SECURITY_GROUP</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description>When <b>InstanceType</b> is set to <b>ACR</b>, valid values are:<list type="bullet">
            /// <item><description><b>REPOSITORY_ENTERPRISE</b></description></item>
            /// <item><description><b>REPOSITORY_PERSON</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description>When <b>InstanceType</b> is set to <b>RAM</b>, valid values are:<list type="bullet">
            /// <item><description><b>ALIAS</b></description></item>
            /// <item><description><b>USER</b></description></item>
            /// <item><description><b>POLICY</b></description></item>
            /// <item><description><b>GROUP</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description>When <b>InstanceType</b> is set to <b>WAF</b>, valid values are:<list type="bullet">
            /// <item><description><b>DOMAIN</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description>When <b>InstanceType</b> is set to other values, valid values are:<list type="bullet">
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
            /// <item><description><b>ECS</b>: Elastic Compute Service server</description></item>
            /// <item><description><b>SLB</b>: load balancing</description></item>
            /// <item><description><b>RDS</b>: RDS database</description></item>
            /// <item><description><b>MONGODB</b>: MongoDB database</description></item>
            /// <item><description><b>KVSTORE</b>: Redis database</description></item>
            /// <item><description><b>ACR</b>: ACR</description></item>
            /// <item><description><b>CSK</b>: CSK</description></item>
            /// <item><description><b>VPC</b>: VPC</description></item>
            /// <item><description><b>ACTIONTRAIL</b>: ActionTrail</description></item>
            /// <item><description><b>CDN</b>: CDN</description></item>
            /// <item><description><b>CAS</b>: SSL Certificates Service (formerly Digital Certificate Management Service)</description></item>
            /// <item><description><b>RDC</b>: Yunxiao</description></item>
            /// <item><description><b>RAM</b>: RAM</description></item>
            /// <item><description><b>DDOS</b>: distributed denial of service</description></item>
            /// <item><description><b>WAF</b>: WAF</description></item>
            /// <item><description><b>OSS</b>: access control</description></item>
            /// <item><description><b>POLARDB</b>: PolarDB</description></item>
            /// <item><description><b>POSTGRESQL</b>: PostgreSQL</description></item>
            /// <item><description><b>MSE</b>: MSE</description></item>
            /// <item><description><b>NAS</b>: NAS</description></item>
            /// <item><description><b>SDDP</b>: SDDP</description></item>
            /// <item><description><b>EIP</b>: EIP</description></item>
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
            /// <item><description><b>HIGH</b>: high risk</description></item>
            /// <item><description><b>MEDIUM</b>: medium risk</description></item>
            /// <item><description><b>LOW</b>: low risk</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HIGH</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The list of sections associated with the check item.</para>
            /// </summary>
            [NameInMap("SectionIds")]
            [Validation(Required=false)]
            public List<long?> SectionIds { get; set; }

            /// <summary>
            /// <para>The cloud asset vendor. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Alibaba Cloud asset</description></item>
            /// <item><description><b>1</b>: non-cloud asset</description></item>
            /// <item><description><b>2</b>: IDC asset</description></item>
            /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, <b>7</b>: other cloud assets</description></item>
            /// <item><description><b>8</b>: simple application server</description></item>
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
        /// <para>The page information for a paged query.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCheckItemResponseBodyPageInfo PageInfo { get; set; }
        public class ListCheckItemResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries displayed on the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of query results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>149</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. This is a unique identifier generated by Alibaba Cloud for the request. You can use it to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9F4E6157-9600-5588-86B9-38F09067****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
