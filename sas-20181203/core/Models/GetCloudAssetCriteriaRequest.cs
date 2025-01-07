// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCloudAssetCriteriaRequest : TeaModel {
        /// <summary>
        /// <para>The types of cloud assets.</para>
        /// </summary>
        [NameInMap("CloudAssetTypes")]
        [Validation(Required=false)]
        public List<GetCloudAssetCriteriaRequestCloudAssetTypes> CloudAssetTypes { get; set; }
        public class GetCloudAssetCriteriaRequestCloudAssetTypes : TeaModel {
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
            /// <para>2</para>
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
            /// <para>9</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

        }

        /// <summary>
        /// <para>The keyword for fuzzy search when you query the asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testwww</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
