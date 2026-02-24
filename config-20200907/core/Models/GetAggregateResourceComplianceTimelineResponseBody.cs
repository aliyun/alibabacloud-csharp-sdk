// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateResourceComplianceTimelineResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8D53A78F-1EB8-4264-A554-72F07E34FAE6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The compliance timeline of the resource.</para>
        /// </summary>
        [NameInMap("ResourceComplianceTimeline")]
        [Validation(Required=false)]
        public GetAggregateResourceComplianceTimelineResponseBodyResourceComplianceTimeline ResourceComplianceTimeline { get; set; }
        public class GetAggregateResourceComplianceTimelineResponseBodyResourceComplianceTimeline : TeaModel {
            /// <summary>
            /// <para>A list of compliance timeline entries.</para>
            /// </summary>
            [NameInMap("ComplianceList")]
            [Validation(Required=false)]
            public List<GetAggregateResourceComplianceTimelineResponseBodyResourceComplianceTimelineComplianceList> ComplianceList { get; set; }
            public class GetAggregateResourceComplianceTimelineResponseBodyResourceComplianceTimelineComplianceList : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100931896542****</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// <para>The zone where the resource resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-f</para>
                /// </summary>
                [NameInMap("AvailabilityZone")]
                [Validation(Required=false)]
                public string AvailabilityZone { get; set; }

                /// <summary>
                /// <para>The timestamp when the compliance evaluation was recorded. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1625200295276</para>
                /// </summary>
                [NameInMap("CaptureTime")]
                [Validation(Required=false)]
                public long? CaptureTime { get; set; }

                /// <summary>
                /// <para>A list of rules associated with the resource and their compliance details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;Compliance\&quot;:{\&quot;complianceType\&quot;:\&quot;COMPLIANT\&quot;,\&quot;count\&quot;:1},\&quot;ConfigRuleList\&quot;:[{\&quot;accountId\&quot;:100931896542****,\&quot;configRuleId\&quot;:\&quot;cr-9524626622af003d****\&quot;,\&quot;configRuleArn\&quot;:\&quot;acs:config::100931896542****:rule/cr-9524626622af003d****\&quot;,\&quot;configRuleName\&quot;:\&quot;OSS存储空间ACL禁止公共读写\&quot;,\&quot;complianceType\&quot;:\&quot;COMPLIANT\&quot;,\&quot;riskLevel\&quot;:1,\&quot;annotation\&quot;:\&quot;\&quot;,\&quot;invokingEventMessageType\&quot;:\&quot;ScheduledNotification\&quot;}]}</para>
                /// </summary>
                [NameInMap("Configuration")]
                [Validation(Required=false)]
                public string Configuration { get; set; }

                /// <summary>
                /// <para>The details of the resource change that triggered this evaluation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;OSS存储空间ACL禁止公共读写\&quot;:[{\&quot;accountId\&quot;:100931896542****,\&quot;configRuleId\&quot;:\&quot;cr-965f626622af003d****\&quot;,\&quot;configRuleArn\&quot;:\&quot;acs:config::100931896542****:rule/cr-965f626622af003d****\&quot;,\&quot;configRuleName\&quot;:\&quot;OSS存储空间ACL禁止公共读写\&quot;,\&quot;complianceType\&quot;:\&quot;COMPLIANT\&quot;,\&quot;riskLevel\&quot;:1,\&quot;annotation\&quot;:\&quot;\&quot;,\&quot;invokingEventMessageType\&quot;:\&quot;ScheduledNotification\&quot;},{}]}</para>
                /// </summary>
                [NameInMap("ConfigurationDiff")]
                [Validation(Required=false)]
                public string ConfigurationDiff { get; set; }

                /// <summary>
                /// <para>The ID of the region where the resource resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The timestamp when the resource was created. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1624961112000</para>
                /// </summary>
                [NameInMap("ResourceCreateTime")]
                [Validation(Required=false)]
                public long? ResourceCreateTime { get; set; }

                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>new-bucket</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The resource name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>new-bucket</para>
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>The status of the resource. The status of a resource is defined by the corresponding Alibaba Cloud service. This parameter can be empty. For example:</para>
                /// <list type="bullet">
                /// <item><description><para>If the resource type is ACS::ECS::Instance, this parameter can be Running or Stopped because an ECS instance is stateful.</para>
                /// </description></item>
                /// <item><description><para>If the resource type is ACS::OSS::Bucket, this parameter is empty because an OSS bucket is stateless.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ResourceStatus")]
                [Validation(Required=false)]
                public string ResourceStatus { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS::OSS::Bucket</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The tags of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;\&quot;hc\&quot;\&quot;:[\&quot;\&quot;value2\&quot;\&quot;]}</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token used to query the next page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5OVS5J4I1/UKTkHV5oNs****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

    }

}
