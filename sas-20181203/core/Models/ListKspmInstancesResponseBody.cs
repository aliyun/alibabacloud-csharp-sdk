// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListKspmInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>List of Kubernetes asset information.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListKspmInstancesResponseBodyInstances> Instances { get; set; }
        public class ListKspmInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>Indicates whether the asset has security alarms. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>YES</b>: There are security alarms</description></item>
            /// <item><description><b>NO</b>: There are no security alarms</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NO</para>
            /// </summary>
            [NameInMap("AlarmStatus")]
            [Validation(Required=false)]
            public string AlarmStatus { get; set; }

            /// <summary>
            /// <para>The subtype of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AssetSubType")]
            [Validation(Required=false)]
            public string AssetSubType { get; set; }

            /// <summary>
            /// <para>The name of the asset subtype.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pod</para>
            /// </summary>
            [NameInMap("AssetSubTypeName")]
            [Validation(Required=false)]
            public string AssetSubTypeName { get; set; }

            /// <summary>
            /// <para>The type of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            /// <summary>
            /// <para>The name of the asset type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Workload</para>
            /// </summary>
            [NameInMap("AssetTypeName")]
            [Validation(Required=false)]
            public string AssetTypeName { get; set; }

            /// <summary>
            /// <para>The timestamp when the instance was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1607365213000</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-uf6t6u05n6g48****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
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

            /// <summary>
            /// <para>The ID of the region where the asset is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hanghzou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Indicates whether the asset has security risks. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>YES</b>: There are security risks</description></item>
            /// <item><description><b>NO</b>: There are no security risks</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NO</para>
            /// </summary>
            [NameInMap("RiskStatus")]
            [Validation(Required=false)]
            public string RiskStatus { get; set; }

            /// <summary>
            /// <para>Security information of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;seriousNum\&quot;:0,\&quot;appNum\&quot;:0,\&quot;baselineMedium\&quot;:0,\&quot;remindNum\&quot;:0,\&quot;imageVulNntf\&quot;:0,\&quot;cveNum\&quot;:0,\&quot;vul\&quot;:0,\&quot;uuid\&quot;:\&quot;rm-uf6t6u05n6g485o70\&quot;,\&quot;emgNum\&quot;:0,\&quot;weakPWNum\&quot;:0,\&quot;imageMaliciousFileRemind\&quot;:0,\&quot;imageBaselineMedium\&quot;:0,\&quot;laterVulCount\&quot;:0,\&quot;cmsNum\&quot;:0,\&quot;imageMaliciousFileSerious\&quot;:0,\&quot;agentlessMalicious\&quot;:0,\&quot;suspNum\&quot;:0,\&quot;imageBaselineHigh\&quot;:0,\&quot;asapVulCount\&quot;:0,\&quot;imageVulLater\&quot;:0,\&quot;agentlessAll\&quot;:0,\&quot;sysNum\&quot;:0,\&quot;containerLater\&quot;:0,\&quot;containerSuspicious\&quot;:0,\&quot;imageBaselineNum\&quot;:0,\&quot;newSuspicious\&quot;:0,\&quot;nntfVulCount\&quot;:0,\&quot;scaNum\&quot;:0,\&quot;containerNntf\&quot;:0,\&quot;health\&quot;:0,\&quot;trojan\&quot;:0,\&quot;suspicious\&quot;:0,\&quot;imageMaliciousFileSuspicious\&quot;:0,\&quot;containerRemind\&quot;:0,\&quot;baselineLow\&quot;:0,\&quot;imageVulAsap\&quot;:0,\&quot;imageBaselineLow\&quot;:0,\&quot;containerAsap\&quot;:0,\&quot;agentlessBaseline\&quot;:0,\&quot;agentlessVulSca\&quot;:0,\&quot;agentlessVulCve\&quot;:0,\&quot;containerSerious\&quot;:0,\&quot;baselineHigh\&quot;:0,\&quot;account\&quot;:0,\&quot;baselineNum\&quot;:6}</para>
            /// </summary>
            [NameInMap("SecurityInfo")]
            [Validation(Required=false)]
            public string SecurityInfo { get; set; }

            /// <summary>
            /// <para>List of resource tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            /// <summary>
            /// <para>The vendor of the asset. This value is fixed at <b>200</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

        }

        /// <summary>
        /// <para>Page information for pagination queries.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListKspmInstancesResponseBodyPageInfo PageInfo { get; set; }
        public class ListKspmInstancesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of data items displayed on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a pagination query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of items to display per page in a pagination query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of data items found.</para>
            /// 
            /// <b>Example:</b>
            /// <para>55</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of this call request, a unique identifier generated by Alibaba Cloud for the request, which can be used to troubleshoot and pinpoint issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-B12447DDCAE1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Success</description></item>
        /// <item><description><b>false</b>: Failure</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
