// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCloudAssetDetailRequest : TeaModel {
        /// <summary>
        /// <para>The subtype of the cloud service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AssetSubType")]
        [Validation(Required=false)]
        public int? AssetSubType { get; set; }

        /// <summary>
        /// <para>The type of the cloud asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Elastic Compute Service (ECS).</description></item>
        /// <item><description><b>1</b>: Server Load Balancer (SLB).</description></item>
        /// <item><description><b>3</b>: ApsaraDB RDS.</description></item>
        /// <item><description><b>4</b>: ApsaraDB for MongoDB.</description></item>
        /// <item><description><b>5</b>: ApsaraDB for Redis.</description></item>
        /// <item><description><b>6</b>: Container Registry.</description></item>
        /// <item><description><b>8</b>: Container Service for Kubernetes.</description></item>
        /// <item><description><b>9</b>: Virtual Private Cloud (VPC).</description></item>
        /// <item><description><b>11</b>: ActionTrail.</description></item>
        /// <item><description><b>12</b>: Alibaba Cloud CDN (CDN).</description></item>
        /// <item><description><b>13</b>: Certificate Management Service.</description></item>
        /// <item><description><b>14</b>: Apsara Devops.</description></item>
        /// <item><description><b>15</b>: Resource Access Management (RAM).</description></item>
        /// <item><description><b>16</b>: Anti-DDoS.</description></item>
        /// <item><description><b>17</b>: Web Application Firewall (WAF).</description></item>
        /// <item><description><b>18</b>: Object Storage Service (OSS).</description></item>
        /// <item><description><b>19</b>: PolarDB.</description></item>
        /// <item><description><b>20</b>: ApsaraDB RDS for PostgreSQL.</description></item>
        /// <item><description><b>21</b>: Microservices Engine (MSE).</description></item>
        /// <item><description><b>22</b>: File Storage NAS (NAS).</description></item>
        /// <item><description><b>23</b>: Data Security Center (DSC).</description></item>
        /// <item><description><b>24</b>: Elastic IP Address (EIP).</description></item>
        /// <item><description><b>25</b>: Identity as a Service (IDaaS)-Employee Identity and Access Management (EIAM).</description></item>
        /// <item><description><b>26</b>: PolarDB-X.</description></item>
        /// <item><description><b>27</b>: Elasticsearch.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>14</para>
        /// </summary>
        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public int? AssetType { get; set; }

        /// <summary>
        /// <para>The details of the assets.</para>
        /// </summary>
        [NameInMap("CloudAssetInstances")]
        [Validation(Required=false)]
        public List<GetCloudAssetDetailRequestCloudAssetInstances> CloudAssetInstances { get; set; }
        public class GetCloudAssetDetailRequestCloudAssetInstances : TeaModel {
            /// <summary>
            /// <para>The instance ID of the cloud asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-wz9hf86vbzbrrde7****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region in which the cloud asset resides.</para>
            /// <remarks>
            /// <para>For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The service provider of the cloud asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Alibaba Cloud.</description></item>
        /// <item><description><b>1</b>: service provider that is unrecognized.</description></item>
        /// <item><description><b>2</b>: data center.</description></item>
        /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, and <b>7</b>: third-party service provider.</description></item>
        /// <item><description><b>8</b>: simple application server.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public int? Vendor { get; set; }

    }

}
