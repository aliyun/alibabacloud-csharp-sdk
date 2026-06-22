// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCloudAssetSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The list of asset type information of cloud assets.</para>
        /// </summary>
        [NameInMap("CloudAssetTypes")]
        [Validation(Required=false)]
        public List<GetCloudAssetSummaryRequestCloudAssetTypes> CloudAssetTypes { get; set; }
        public class GetCloudAssetSummaryRequestCloudAssetTypes : TeaModel {
            /// <summary>
            /// <para>The subtype of the cloud service.
            /// The asset type-subtype. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Elastic Compute Service (ECS) <list type="bullet">
            /// <item><description><b>1</b>: Disk (Storage)</description></item>
            /// <item><description><b>2</b>: Security Group</description></item>
            /// <item><description><b>100</b>: Instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>1</b>: Server Load Balancer<list type="bullet">
            /// <item><description><b>0</b>: Server Load Balancer (SLB)</description></item>
            /// <item><description><b>1</b>: Application Load Balancer (ALB)</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>3</b>: ApsaraDB RDS<list type="bullet">
            /// <item><description><b>0</b>: Instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>4</b>: ApsaraDB for MongoDB<list type="bullet">
            /// <item><description><b>0</b>: Instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>5</b>: ApsaraDB for Tair (compatible with Redis)<list type="bullet">
            /// <item><description><b>0</b>: Instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>6</b>: Container Registry<list type="bullet">
            /// <item><description><b>1</b>: Enterprise Edition</description></item>
            /// <item><description><b>2</b>: Personal Edition</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>8</b>: Container Service for Kubernetes (ACK)<list type="bullet">
            /// <item><description><b>0</b>: Cluster</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>9</b>: Virtual Private Cloud (VPC)<list type="bullet">
            /// <item><description><b>0</b>: NAT Gateway</description></item>
            /// <item><description><b>1</b>: EIP</description></item>
            /// <item><description><b>2</b>: VPN</description></item>
            /// <item><description><b>3</b>: FLOW_LOG</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>11</b>: ActionTrail<list type="bullet">
            /// <item><description><b>0</b>: Trail</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>12</b>: Alibaba Cloud CDN<list type="bullet">
            /// <item><description><b>0</b>: Instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>13</b>: Certificate Management Service (formerly SSL Certificates Service)<list type="bullet">
            /// <item><description><b>0</b>: Certificate</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>14</b>: Apsara Devops<list type="bullet">
            /// <item><description><b>0</b>: Organization</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>16</b>: Anti-DDoS<list type="bullet">
            /// <item><description><b>0</b>: Instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>17</b>: Web Application Firewall (WAF)<list type="bullet">
            /// <item><description><b>0</b>: Domain name</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>18</b>: Object Storage Service (OSS)<list type="bullet">
            /// <item><description><b>0</b>: Bucket</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>19</b>: PolarDB<list type="bullet">
            /// <item><description><b>0</b>: Cluster</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>20</b>: ApsaraDB RDS for PostgreSQL<list type="bullet">
            /// <item><description><b>0</b>: Instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>21</b>: Microservices Engine (MSE)<list type="bullet">
            /// <item><description><b>0</b>: Cluster</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>22</b>: Apsara File Storage NAS<list type="bullet">
            /// <item><description><b>0</b>: File system</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>23</b>: Data Security Center (DSC)<list type="bullet">
            /// <item><description><b>0</b>: Instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>24</b>: Elastic IP Address (EIP)<list type="bullet">
            /// <item><description><b>0</b>: Anycast EIP</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>25</b>: Identity as a Service - EIAM<list type="bullet">
            /// <item><description><b>0</b>: Instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>26</b>: PolarDB-X<list type="bullet">
            /// <item><description><b>0</b>: Instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>27</b>: Elasticsearch<list type="bullet">
            /// <item><description><b>0</b>: Instance</description></item>
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
            /// <para>The type of asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Elastic Compute Service (ECS)</description></item>
            /// <item><description><b>1</b>: Server Load Balancer (SLB)</description></item>
            /// <item><description><b>3</b>: ApsaraDB RDS</description></item>
            /// <item><description><b>4</b>: ApsaraDB for MongoDB</description></item>
            /// <item><description><b>5</b>: ApsaraDB for Tair (compatible with Redis)</description></item>
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
            /// <item><description><b>22</b>: Apsara File Storage NAS</description></item>
            /// <item><description><b>23</b>: Data Security Center (DSC)</description></item>
            /// <item><description><b>24</b>: Elastic IP Address (EIP)</description></item>
            /// <item><description><b>25</b>: Identity as a Service - EIAM</description></item>
            /// <item><description><b>26</b>: PolarDB-X</description></item>
            /// <item><description><b>27</b>: Elasticsearch</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            /// <summary>
            /// <para>Server vendor. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Alibaba Cloud assets</description></item>
            /// <item><description><b>1</b>: Off-cloud assets</description></item>
            /// <item><description><b>2</b>: IDC assets</description></item>
            /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, <b>7</b>: Other cloud assets</description></item>
            /// <item><description><b>8</b>: Lightweight assets</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

        }

        [NameInMap("IsSaleData")]
        [Validation(Required=false)]
        public bool? IsSaleData { get; set; }

        /// <summary>
        /// <para>The list of cloud vendors to query.</para>
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<int?> Vendors { get; set; }

    }

}
