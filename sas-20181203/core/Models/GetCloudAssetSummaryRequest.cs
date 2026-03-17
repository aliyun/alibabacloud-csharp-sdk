// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCloudAssetSummaryRequest : TeaModel {
        /// <summary>
        /// <para>List of asset type information for cloud assets</para>
        /// </summary>
        [NameInMap("CloudAssetTypes")]
        [Validation(Required=false)]
        public List<GetCloudAssetSummaryRequestCloudAssetTypes> CloudAssetTypes { get; set; }
        public class GetCloudAssetSummaryRequestCloudAssetTypes : TeaModel {
            /// <summary>
            /// <para>Subtypes of cloud products. Asset type-subtype. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: ECS (Elastic Compute Service)<list type="bullet">
            /// <item><description><b>1</b>: Disk (Storage)</description></item>
            /// <item><description><b>2</b>: Security Group</description></item>
            /// <item><description><b>100</b>: Instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>1</b>: Load Balancer <list type="bullet">
            /// <item><description><b>0</b>: Load Balancer </description></item>
            /// <item><description><b>1</b>: Application Load Balancer</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>3</b>: ApsaraDB RDS <list type="bullet">
            /// <item><description><b>0</b>: Instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>4</b>: ApsaraDB for MongoDB <list type="bullet">
            /// <item><description><b>0</b>: Instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>5</b>: ApsaraDB Tair (Redis Compatible) <list type="bullet">
            /// <item><description><b>0</b>: Instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>6</b>: Container Registry <list type="bullet">
            /// <item><description><b>1</b>: Enterprise Edition </description></item>
            /// <item><description><b>2</b>: Personal Edition</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>8</b>: Container Service for Kubernetes <list type="bullet">
            /// <item><description><b>0</b>: Cluster</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>9</b>: Virtual Private Cloud (VPC) <list type="bullet">
            /// <item><description><b>0</b>: NAT Gateway </description></item>
            /// <item><description><b>1</b>: EIP (Elastic IP) </description></item>
            /// <item><description><b>2</b>: VPN </description></item>
            /// <item><description><b>3</b>: FLOW_LOG</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>11</b>: ActionTrail <list type="bullet">
            /// <item><description><b>0</b>: Trail</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>12</b>: CDN <list type="bullet">
            /// <item><description><b>0</b>: Instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>13</b>: Digital Certificate Management Service (formerly SSL Certificates) <list type="bullet">
            /// <item><description><b>0</b>: Certificate</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>14</b>: DevOps <list type="bullet">
            /// <item><description><b>0</b>: Organization</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>16</b>: DDoS Protection <list type="bullet">
            /// <item><description><b>0</b>: Instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>17</b>: Web Application Firewall <list type="bullet">
            /// <item><description><b>0</b>: Domain</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>18</b>: Object Storage <list type="bullet">
            /// <item><description><b>0</b>: Bucket</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>19</b>: PolarDB (Cloud-Native Relational Database) <list type="bullet">
            /// <item><description><b>0</b>: Cluster</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>20</b>: ApsaraDB for PostgreSQL <list type="bullet">
            /// <item><description><b>0</b>: Instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>21</b>: Microservices Engine <list type="bullet">
            /// <item><description><b>0</b>: Cluster</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>22</b>: File Storage NAS <list type="bullet">
            /// <item><description><b>0</b>: File System</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>23</b>: Data Security Center <list type="bullet">
            /// <item><description><b>0</b>: Instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>24</b>: Elastic Public IP <list type="bullet">
            /// <item><description><b>0</b>: Anycast Elastic Public IP</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>25</b>: Cloud Identity Service - EIAM <list type="bullet">
            /// <item><description><b>0</b>: Instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>26</b>: PolarDB-X <list type="bullet">
            /// <item><description><b>0</b>: Instance</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>27</b>: Elasticsearch <list type="bullet">
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
            /// <para>The type of asset. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Elastic Compute Service (ECS) </description></item>
            /// <item><description><b>1</b>: Load Balancer </description></item>
            /// <item><description><b>3</b>: ApsaraDB for RDS </description></item>
            /// <item><description><b>4</b>: ApsaraDB for MongoDB </description></item>
            /// <item><description><b>5</b>: ApsaraDB for Tair (Redis compatible) </description></item>
            /// <item><description><b>6</b>: Container Registry </description></item>
            /// <item><description><b>8</b>: Container Service for Kubernetes </description></item>
            /// <item><description><b>9</b>: Virtual Private Cloud (VPC) </description></item>
            /// <item><description><b>11</b>: ActionTrail </description></item>
            /// <item><description><b>12</b>: Content Delivery Network (CDN) </description></item>
            /// <item><description><b>13</b>: SSL Certificates (now known as Certificate Management Service) </description></item>
            /// <item><description><b>14</b>: DevOps </description></item>
            /// <item><description><b>16</b>: DDoS Protection </description></item>
            /// <item><description><b>17</b>: Web Application Firewall </description></item>
            /// <item><description><b>18</b>: Object Storage Service (OSS) </description></item>
            /// <item><description><b>19</b>: PolarDB </description></item>
            /// <item><description><b>20</b>: ApsaraDB for PostgreSQL </description></item>
            /// <item><description><b>21</b>: Microservices Engine </description></item>
            /// <item><description><b>22</b>: File Storage NAS </description></item>
            /// <item><description><b>23</b>: Data Security Center </description></item>
            /// <item><description><b>24</b>: Elastic IP Address </description></item>
            /// <item><description><b>25</b>: Cloud Identity Service - EIAM </description></item>
            /// <item><description><b>26</b>: PolarDB-X </description></item>
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
            /// <para>Server vendor. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Alibaba Cloud Asset </description></item>
            /// <item><description><b>1</b>: Non-cloud Asset </description></item>
            /// <item><description><b>2</b>: IDC Asset </description></item>
            /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, <b>7</b>: Other Cloud Assets </description></item>
            /// <item><description><b>8</b>: Lightweight Asset</description></item>
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
        /// <para>List of cloud vendors to be queried.</para>
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<int?> Vendors { get; set; }

    }

}
