// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCloudAssetSchemasRequest : TeaModel {
        /// <summary>
        /// <para>Whether to filter out attributes that can be associated with other assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AssociatedDataOnly")]
        [Validation(Required=false)]
        public bool? AssociatedDataOnly { get; set; }

        /// <summary>
        /// <para>The types of cloud assets.</para>
        /// </summary>
        [NameInMap("CloudAssetTypes")]
        [Validation(Required=false)]
        public List<ListCloudAssetSchemasRequestCloudAssetTypes> CloudAssetTypes { get; set; }
        public class ListCloudAssetSchemasRequestCloudAssetTypes : TeaModel {
            /// <summary>
            /// <para>The subtype of the cloud service or asset. Valid values:</para>
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
            /// <item><description><para><b>4</b>: MongoDB</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>5</b>: Redis</para>
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
            /// <item><description><b>1</b>: Elastic IP address (EIP)</description></item>
            /// <item><description><b>2</b>: VPN</description></item>
            /// <item><description><b>3</b>: VPC Flow Logs</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>11</b>: ActionTrail</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: trail</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>12</b>: CDN</para>
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
            public int? AssetSubType { get; set; }

            /// <summary>
            /// <para>The type of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Elastic Compute Service (ECS)</description></item>
            /// <item><description><b>1</b>: Server Load Balancer (SLB)</description></item>
            /// <item><description><b>3</b>: ApsaraDB RDS</description></item>
            /// <item><description><b>4</b>: ApsaraDB for MongoDB (MongoDB)</description></item>
            /// <item><description><b>5</b>: ApsaraDB for Redis (Redis)</description></item>
            /// <item><description><b>6</b>: Container Registry</description></item>
            /// <item><description><b>8</b>: Container Service for Kubernetes (ACK)</description></item>
            /// <item><description><b>9</b>: Virtual Private Cloud (VPC)</description></item>
            /// <item><description><b>11</b>: ActionTrail</description></item>
            /// <item><description><b>12</b>: Alibaba Cloud CDN (CDN)</description></item>
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
            /// <item><description><b>25</b>: IDaaS EIAM</description></item>
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
            /// <para>The server type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: a cloud asset provided by Alibaba Cloud</description></item>
            /// <item><description><b>1</b>: a cloud asset outside Alibaba Cloud</description></item>
            /// <item><description><b>2</b>: a cloud asset in a data center</description></item>
            /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, and <b>7</b>: a cloud asset provided by a third-party service provider</description></item>
            /// <item><description><b>8</b>: a lightweight cloud asset</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

        }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>List of asset data names</para>
        /// </summary>
        [NameInMap("DataNames")]
        [Validation(Required=false)]
        public List<string> DataNames { get; set; }

        /// <summary>
        /// <para>The language type for requesting and receiving messages, with a default value of <b>zh</b>. The values can be: - <b>zh</b>: Chinese - <b>en</b>: English</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
