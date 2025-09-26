// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCloudAssetDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of instances in the list of cloud assets returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>An array that consists of the details of the cloud assets.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<GetCloudAssetDetailResponseBodyInstances> Instances { get; set; }
        public class GetCloudAssetDetailResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>Indicates whether alerts are generated for the current cloud asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>YES</b></description></item>
            /// <item><description><b>NO</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NO</para>
            /// </summary>
            [NameInMap("AlarmStatus")]
            [Validation(Required=false)]
            public string AlarmStatus { get; set; }

            /// <summary>
            /// <para>The subtype of the cloud asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetSubType")]
            [Validation(Required=false)]
            public int? AssetSubType { get; set; }

            /// <summary>
            /// <para>The name of the cloud asset subtype.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INSTANCE</para>
            /// </summary>
            [NameInMap("AssetSubTypeName")]
            [Validation(Required=false)]
            public string AssetSubTypeName { get; set; }

            /// <summary>
            /// <para>The type of the cloud asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: ECS.</description></item>
            /// <item><description><b>1</b>: SLB.</description></item>
            /// <item><description><b>3</b>: ApsaraDB RDS.</description></item>
            /// <item><description><b>4</b>: ApsaraDB for MongoDB.</description></item>
            /// <item><description><b>5</b>: ApsaraDB for Redis.</description></item>
            /// <item><description><b>6</b>: Container Registry.</description></item>
            /// <item><description><b>8</b>: Container Service for Kubernetes.</description></item>
            /// <item><description><b>9</b>: VPC.</description></item>
            /// <item><description><b>11</b>: ActionTrail.</description></item>
            /// <item><description><b>12</b>: CDN.</description></item>
            /// <item><description><b>13</b>: Certificate Management Service.</description></item>
            /// <item><description><b>14</b>: Apsara Devops.</description></item>
            /// <item><description><b>15</b>: RAM.</description></item>
            /// <item><description><b>16</b>: Anti-DDoS.</description></item>
            /// <item><description><b>17</b>: WAF.</description></item>
            /// <item><description><b>18</b>: OSS.</description></item>
            /// <item><description><b>19</b>: PolarDB.</description></item>
            /// <item><description><b>20</b>: ApsaraDB RDS for PostgreSQL.</description></item>
            /// <item><description><b>21</b>: MSE.</description></item>
            /// <item><description><b>22</b>: NAS.</description></item>
            /// <item><description><b>23</b>: DSC.</description></item>
            /// <item><description><b>24</b>: EIP.</description></item>
            /// <item><description><b>25</b>: IDaaS-EIAM.</description></item>
            /// <item><description><b>26</b>: PolarDB-X.</description></item>
            /// <item><description><b>27</b>: Elasticsearch.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            /// <summary>
            /// <para>The name of the cloud asset type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("AssetTypeName")]
            [Validation(Required=false)]
            public string AssetTypeName { get; set; }

            /// <summary>
            /// <para>The time when the instance was created. The value is a timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1607365213000</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The detailed address of the cloud asset.</para>
            /// </summary>
            [NameInMap("DetailLink")]
            [Validation(Required=false)]
            public string DetailLink { get; set; }

            /// <summary>
            /// <para>The instance ID of the cloud asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-uf6t6u05n6g48****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name of the cloud asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yztest-l***</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            [NameInMap("OriginalAssetInfo")]
            [Validation(Required=false)]
            public string OriginalAssetInfo { get; set; }

            /// <summary>
            /// <para>The region in which the cloud asset resides.</para>
            /// <remarks>
            /// <para>For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hanghzou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Indicates whether risks are detected on the current cloud asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>YES</b></description></item>
            /// <item><description><b>NO</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NO</para>
            /// </summary>
            [NameInMap("RiskStatus")]
            [Validation(Required=false)]
            public string RiskStatus { get; set; }

            /// <summary>
            /// <para>The security information about the cloud asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;seriousNum\&quot;:0,\&quot;appNum\&quot;:0,\&quot;baselineMedium\&quot;:0,\&quot;remindNum\&quot;:0,\&quot;imageVulNntf\&quot;:0,\&quot;cveNum\&quot;:0,\&quot;vul\&quot;:0,\&quot;uuid\&quot;:\&quot;rm-uf6t6u05n6g485o70\&quot;,\&quot;emgNum\&quot;:0,\&quot;weakPWNum\&quot;:0,\&quot;imageMaliciousFileRemind\&quot;:0,\&quot;imageBaselineMedium\&quot;:0,\&quot;laterVulCount\&quot;:0,\&quot;cmsNum\&quot;:0,\&quot;imageMaliciousFileSerious\&quot;:0,\&quot;agentlessMalicious\&quot;:0,\&quot;suspNum\&quot;:0,\&quot;imageBaselineHigh\&quot;:0,\&quot;asapVulCount\&quot;:0,\&quot;imageVulLater\&quot;:0,\&quot;agentlessAll\&quot;:0,\&quot;sysNum\&quot;:0,\&quot;containerLater\&quot;:0,\&quot;containerSuspicious\&quot;:0,\&quot;imageBaselineNum\&quot;:0,\&quot;newSuspicious\&quot;:0,\&quot;nntfVulCount\&quot;:0,\&quot;scaNum\&quot;:0,\&quot;containerNntf\&quot;:0,\&quot;health\&quot;:0,\&quot;trojan\&quot;:0,\&quot;suspicious\&quot;:0,\&quot;imageMaliciousFileSuspicious\&quot;:0,\&quot;containerRemind\&quot;:0,\&quot;baselineLow\&quot;:0,\&quot;imageVulAsap\&quot;:0,\&quot;imageBaselineLow\&quot;:0,\&quot;containerAsap\&quot;:0,\&quot;agentlessBaseline\&quot;:0,\&quot;agentlessVulSca\&quot;:0,\&quot;agentlessVulCve\&quot;:0,\&quot;containerSerious\&quot;:0,\&quot;baselineHigh\&quot;:0,\&quot;account\&quot;:0,\&quot;baselineNum\&quot;:6}</para>
            /// </summary>
            [NameInMap("SecurityInfo")]
            [Validation(Required=false)]
            public string SecurityInfo { get; set; }

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

            [NameInMap("VendorUid")]
            [Validation(Required=false)]
            public string VendorUid { get; set; }

            [NameInMap("VendorUserName")]
            [Validation(Required=false)]
            public string VendorUserName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB45CAED-31C3-517A-8619-10F632D3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
