// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCloudAssetSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>Summary information of cloud assets.</para>
        /// </summary>
        [NameInMap("GroupedFields")]
        [Validation(Required=false)]
        public GetCloudAssetSummaryResponseBodyGroupedFields GroupedFields { get; set; }
        public class GetCloudAssetSummaryResponseBodyGroupedFields : TeaModel {
            /// <summary>
            /// <para>List of cloud product statistics</para>
            /// </summary>
            [NameInMap("CloudAssetSummaryMetas")]
            [Validation(Required=false)]
            public List<GetCloudAssetSummaryResponseBodyGroupedFieldsCloudAssetSummaryMetas> CloudAssetSummaryMetas { get; set; }
            public class GetCloudAssetSummaryResponseBodyGroupedFieldsCloudAssetSummaryMetas : TeaModel {
                /// <summary>
                /// <para>Subtype of the cloud product</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AssetSubType")]
                [Validation(Required=false)]
                public int? AssetSubType { get; set; }

                /// <summary>
                /// <para>The type of cloud product. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Elastic Compute Service (ECS) </description></item>
                /// <item><description><b>1</b>: Load Balancer </description></item>
                /// <item><description><b>3</b>: ApsaraDB for RDS </description></item>
                /// <item><description><b>4</b>: ApsaraDB for MongoDB </description></item>
                /// <item><description><b>5</b>: ApsaraDB for Tair (compatible with Redis) </description></item>
                /// <item><description><b>6</b>: Container Registry </description></item>
                /// <item><description><b>8</b>: Container Service for Kubernetes </description></item>
                /// <item><description><b>9</b>: Virtual Private Cloud (VPC) </description></item>
                /// <item><description><b>11</b>: ActionTrail </description></item>
                /// <item><description><b>12</b>: Content Delivery Network (CDN) </description></item>
                /// <item><description><b>13</b>: SSL Certificates (now known as Certificate Management Service) </description></item>
                /// <item><description><b>14</b>: DevOps</description></item>
                /// <item><description><b>15</b>: Access Control </description></item>
                /// <item><description><b>16</b>: DDoS Protection</description></item>
                /// <item><description><b>17</b>: Web Application Firewall</description></item>
                /// <item><description><b>18</b>: Object Storage Service (OSS)</description></item>
                /// <item><description><b>19</b>: PolarDB </description></item>
                /// <item><description><b>20</b>: ApsaraDB for PostgreSQL </description></item>
                /// <item><description><b>21</b>: Microservices Engine </description></item>
                /// <item><description><b>22</b>: NAS File Storage</description></item>
                /// <item><description><b>23</b>: Data Security Center</description></item>
                /// <item><description><b>24</b>: Elastic IP Address </description></item>
                /// <item><description><b>25</b>: Cloud Identity Service - EIAM </description></item>
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
                /// <para>Total number of this type of cloud product instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("InstanceCount")]
                [Validation(Required=false)]
                public int? InstanceCount { get; set; }

                /// <summary>
                /// <para>Total number of risky instances for this type of cloud product.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("InstanceRiskCount")]
                [Validation(Required=false)]
                public int? InstanceRiskCount { get; set; }

                /// <summary>
                /// <para>Server vendor. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Alibaba Cloud Asset </description></item>
                /// <item><description><b>1</b>: Non-cloud Asset</description></item>
                /// <item><description><b>2</b>: IDC Asset</description></item>
                /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, <b>7</b>: Other Cloud Assets </description></item>
                /// <item><description><b>8</b>: Lightweight Asset</description></item>
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
            /// <para>Total number of cloud product instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>919</para>
            /// </summary>
            [NameInMap("InstanceCountTotal")]
            [Validation(Required=false)]
            public int? InstanceCountTotal { get; set; }

            /// <summary>
            /// <para>Total number of cloud product instances at risk</para>
            /// 
            /// <b>Example:</b>
            /// <para>544</para>
            /// </summary>
            [NameInMap("InstanceRiskCountTotal")]
            [Validation(Required=false)]
            public int? InstanceRiskCountTotal { get; set; }

        }

        /// <summary>
        /// <para>The ID of this call request, a unique identifier generated by Alibaba Cloud for the request, which can be used to troubleshoot and pinpoint issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5CF78A7-30AA-59DB-847F-13EE3AE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
