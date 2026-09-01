// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCloudAssetSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The cloud asset summary information.</para>
        /// </summary>
        [NameInMap("GroupedFields")]
        [Validation(Required=false)]
        public GetCloudAssetSummaryResponseBodyGroupedFields GroupedFields { get; set; }
        public class GetCloudAssetSummaryResponseBodyGroupedFields : TeaModel {
            /// <summary>
            /// <para>The list of cloud service statistics information.</para>
            /// </summary>
            [NameInMap("CloudAssetSummaryMetas")]
            [Validation(Required=false)]
            public List<GetCloudAssetSummaryResponseBodyGroupedFieldsCloudAssetSummaryMetas> CloudAssetSummaryMetas { get; set; }
            public class GetCloudAssetSummaryResponseBodyGroupedFieldsCloudAssetSummaryMetas : TeaModel {
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
                /// <para>The type of the cloud service. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Elastic Compute Service (ECS) server</description></item>
                /// <item><description><b>1</b>: load balancing</description></item>
                /// <item><description><b>3</b>: ApsaraDB RDS database</description></item>
                /// <item><description><b>4</b>: ApsaraDB for MongoDB database</description></item>
                /// <item><description><b>5</b>: Tair (Redis® OSS-Compatible) database</description></item>
                /// <item><description><b>6</b>: Container Registry</description></item>
                /// <item><description><b>8</b>: Container Service for Kubernetes (ACK)</description></item>
                /// <item><description><b>9</b>: Virtual Private Cloud (VPC)</description></item>
                /// <item><description><b>11</b>: ActionTrail</description></item>
                /// <item><description><b>12</b>: CDN</description></item>
                /// <item><description><b>13</b>: Certificate Management Service (formerly SSL Certificates Service)</description></item>
                /// <item><description><b>14</b>: Apsara Devops</description></item>
                /// <item><description><b>15</b>: Resource Access Management (RAM)</description></item>
                /// <item><description><b>16</b>: Anti-DDoS</description></item>
                /// <item><description><b>17</b>: Web Application Firewall (WAF)</description></item>
                /// <item><description><b>18</b>: Object Storage Service (OSS)</description></item>
                /// <item><description><b>19</b>: cloud-native relational database PolarDB</description></item>
                /// <item><description><b>20</b>: ApsaraDB RDS for PostgreSQL database</description></item>
                /// <item><description><b>21</b>: Microservices Engine (MSE)</description></item>
                /// <item><description><b>22</b>: Apsara File Storage NAS</description></item>
                /// <item><description><b>23</b>: Data Security Center (DSC)</description></item>
                /// <item><description><b>24</b>: Elastic IP Address (EIP)</description></item>
                /// <item><description><b>25</b>: Alibaba Cloud IDaaS EIAM</description></item>
                /// <item><description><b>26</b>: PolarDB-X</description></item>
                /// <item><description><b>27</b>: Elasticsearch</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("AssetType")]
                [Validation(Required=false)]
                public int? AssetType { get; set; }

                /// <summary>
                /// <para>The total number of instances of this cloud service type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("InstanceCount")]
                [Validation(Required=false)]
                public int? InstanceCount { get; set; }

                /// <summary>
                /// <para>The total number of at-risk instances of this cloud service type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("InstanceRiskCount")]
                [Validation(Required=false)]
                public int? InstanceRiskCount { get; set; }

                /// <summary>
                /// <para>The number of assets billed by instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InstanceSaleCount")]
                [Validation(Required=false)]
                public int? InstanceSaleCount { get; set; }

                /// <summary>
                /// <para>Indicates whether the asset is billed by instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Billed by instance.</description></item>
                /// <item><description><b>false</b>: Not billed by instance.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("IsInstanceSale")]
                [Validation(Required=false)]
                public bool? IsInstanceSale { get; set; }

                /// <summary>
                /// <para>The server vendor. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Alibaba Cloud asset</description></item>
                /// <item><description><b>1</b>: non-cloud asset</description></item>
                /// <item><description><b>2</b>: IDC asset</description></item>
                /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, <b>7</b>: third-party cloud asset</description></item>
                /// <item><description><b>8</b>: lightweight asset</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public int? Vendor { get; set; }

            }

            /// <summary>
            /// <para>The total number of cloud service instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>919</para>
            /// </summary>
            [NameInMap("InstanceCountTotal")]
            [Validation(Required=false)]
            public int? InstanceCountTotal { get; set; }

            /// <summary>
            /// <para>The total number of at-risk cloud service instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>544</para>
            /// </summary>
            [NameInMap("InstanceRiskCountTotal")]
            [Validation(Required=false)]
            public int? InstanceRiskCountTotal { get; set; }

            /// <summary>
            /// <para>The total number of cloud services billed by instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("InstanceSaleCountTotal")]
            [Validation(Required=false)]
            public int? InstanceSaleCountTotal { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use the request ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5CF78A7-30AA-59DB-847F-13EE3AE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
