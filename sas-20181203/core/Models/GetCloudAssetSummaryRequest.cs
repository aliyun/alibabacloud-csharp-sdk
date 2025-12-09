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
            /// <para>云产品的子类型。
            /// 资产的类型-子类型。取值：</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>：云服务器 ECS <list type="bullet">
            /// <item><description><b>1</b>：磁盘（存储）</description></item>
            /// <item><description><b>2</b>：安全组</description></item>
            /// <item><description><b>100</b>：实例</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>1</b>：负载均衡<list type="bullet">
            /// <item><description><b>0</b>：负载均衡</description></item>
            /// <item><description><b>1</b>：应用型负载均衡</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>3</b>：云数据库 RDS<list type="bullet">
            /// <item><description><b>0</b>：实例</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>4</b>：云数据库 MongoDB 版<list type="bullet">
            /// <item><description><b>0</b>：实例</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>5</b>：云数据库 Tair（兼容 Redis）<list type="bullet">
            /// <item><description><b>0</b>：实例</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>6</b>：容器镜像服务<list type="bullet">
            /// <item><description><b>1</b>：企业版</description></item>
            /// <item><description><b>2</b>：个人版</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>8</b>：容器服务Kubernetes版<list type="bullet">
            /// <item><description><b>0</b>：集群</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>9</b>：专有网络VPC<list type="bullet">
            /// <item><description><b>0</b>：NAT网关</description></item>
            /// <item><description><b>1</b>：EIP</description></item>
            /// <item><description><b>2</b>：VPN</description></item>
            /// <item><description><b>3</b>：FLOW_LOG</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>11</b>：操作审计<list type="bullet">
            /// <item><description><b>0</b>：跟踪</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>12</b>：CDN<list type="bullet">
            /// <item><description><b>0</b>：实例</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>13</b>：数字证书管理服务（原SSL证书）<list type="bullet">
            /// <item><description><b>0</b>：证书</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>14</b>：云效<list type="bullet">
            /// <item><description><b>0</b>：组织</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>16</b>：DDoS防护<list type="bullet">
            /// <item><description><b>0</b>：实例</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>17</b>：Web应用防火墙<list type="bullet">
            /// <item><description><b>0</b>：域名</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>18</b>：对象存储<list type="bullet">
            /// <item><description><b>0</b>：Bucket</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>19</b>：云原生关系型数据库 PolarDB<list type="bullet">
            /// <item><description><b>0</b>：集群</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>20</b>：云数据库 PostgreSQL 版<list type="bullet">
            /// <item><description><b>0</b>：实例</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>21</b>：微服务引擎<list type="bullet">
            /// <item><description><b>0</b>：集群</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>22</b>：文件存储NAS<list type="bullet">
            /// <item><description><b>0</b>：文件系统</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>23</b>：数据安全中心<list type="bullet">
            /// <item><description><b>0</b>：实例</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>24</b>：弹性公网IP<list type="bullet">
            /// <item><description><b>0</b>：任播弹性公网IP</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>25</b>：云身份服务-EIAM<list type="bullet">
            /// <item><description><b>0</b>：实例</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>26</b>：PolarDB-X<list type="bullet">
            /// <item><description><b>0</b>：实例</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>27</b>：Elasticsearch<list type="bullet">
            /// <item><description><b>0</b>：实例</description></item>
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
