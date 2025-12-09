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
                /// <para>云产品的类型。取值：</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>：云服务器 ECS</description></item>
                /// <item><description><b>1</b>：负载均衡</description></item>
                /// <item><description><b>3</b>：云数据库 RDS</description></item>
                /// <item><description><b>4</b>：云数据库 MongoDB 版</description></item>
                /// <item><description><b>5</b>：云数据库 Tair（兼容 Redis）</description></item>
                /// <item><description><b>6</b>：容器镜像服务</description></item>
                /// <item><description><b>8</b>：容器服务Kubernetes版</description></item>
                /// <item><description><b>9</b>：专有网络VPC</description></item>
                /// <item><description><b>11</b>：操作审计</description></item>
                /// <item><description><b>12</b>：CDN</description></item>
                /// <item><description><b>13</b>：数字证书管理服务（原SSL证书）</description></item>
                /// <item><description><b>14</b>：云效</description></item>
                /// <item><description><b>15</b>：访问控制</description></item>
                /// <item><description><b>16</b>：DDoS防护</description></item>
                /// <item><description><b>17</b>：Web应用防火墙</description></item>
                /// <item><description><b>18</b>：对象存储</description></item>
                /// <item><description><b>19</b>：云原生关系型数据库 PolarDB</description></item>
                /// <item><description><b>20</b>：云数据库 PostgreSQL 版</description></item>
                /// <item><description><b>21</b>：微服务引擎</description></item>
                /// <item><description><b>22</b>：文件存储NAS</description></item>
                /// <item><description><b>23</b>：数据安全中心</description></item>
                /// <item><description><b>24</b>：弹性公网IP</description></item>
                /// <item><description><b>25</b>：云身份服务-EIAM</description></item>
                /// <item><description><b>26</b>：PolarDB-X</description></item>
                /// <item><description><b>27</b>：Elasticsearch</description></item>
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
                /// <para>服务器厂商。取值：</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>：阿里云资产</description></item>
                /// <item><description><b>1</b>：云外资产</description></item>
                /// <item><description><b>2</b>：IDC资产</description></item>
                /// <item><description><b>3</b>、<b>4</b>、<b>5</b>、<b>7</b>：其它云资产</description></item>
                /// <item><description><b>8</b>：轻量级资产</description></item>
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
        /// <para>本次调用请求的ID，是由阿里云为该请求生成的唯一标识符，可用于排查和定位问题。</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5CF78A7-30AA-59DB-847F-13EE3AE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
