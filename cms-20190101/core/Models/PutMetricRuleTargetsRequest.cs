// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutMetricRuleTargetsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a dry run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the alert rule.</para>
        /// <para>For more information about how to obtain the ID of an alert rule, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ae06917_75a8c43178ab66****</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>None.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<PutMetricRuleTargetsRequestTargets> Targets { get; set; }
        public class PutMetricRuleTargetsRequestTargets : TeaModel {
            /// <summary>
            /// <para>The ARN of the resource. Simple Message Queue (formerly MNS), Auto Scaling (ESS), Simple Log Service (SLS), and Function Compute (FC) are supported.</para>
            /// <para>The ARN parameters for Simple Message Queue (formerly MNS) are as follows:</para>
            /// <para><c>acs:mns:{regionId}:{userId}:/{resource type}/{resource name}/message</c>.</para>
            /// <list type="bullet">
            /// <item><description><para>{regionId}: the region where the Simple Message Queue (formerly MNS) queue or topic resides.</para>
            /// </description></item>
            /// <item><description><para>{userId}: the Alibaba Cloud account to which the resource belongs.</para>
            /// </description></item>
            /// <item><description><para>{resource type}: the type of the resource that accepts alerts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>queues</b>: queue</description></item>
            /// <item><description><b>topics</b>: topic</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>{resource name}: the name of the resource.</para>
            /// <list type="bullet">
            /// <item><description>If the resource type is <b>queues</b>, the resource name is the queue name.</description></item>
            /// <item><description>If the resource type is <b>topics</b>, the resource name is the topic name.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <para>The ARN for Auto Scaling:</para>
            /// <para>acs:ess:{regionId}:{userId}:scalingGroupId/{scaling group ID}:scalingRuleId/{scaling rule ID}</para>
            /// <para>The ARN for Simple Log Service:</para>
            /// <para>acs:log:{regionId}:{userId}:project/{project name}/logstore/{Logstore name}</para>
            /// <para>The ARN for Function Compute:</para>
            /// <para>acs:fc:{regionId}:{userId}:services/{service name}/functions/{function name}</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:mns:cn-hangzhou:120886317861****:/queues/test/message</para>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// <para>The ID of the alert trigger target.</para>
            /// <para>For more information about how to obtain the ID of an alert trigger target, see <a href="https://help.aliyun.com/document_detail/121592.html">DescribeMetricRuleTargets</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The JSON-formatted parameters for the alert callback.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;customField1&quot;:&quot;value1&quot;,&quot;customField2&quot;:&quot;$.name&quot;}</para>
            /// </summary>
            [NameInMap("JsonParams")]
            [Validation(Required=false)]
            public string JsonParams { get; set; }

            /// <summary>
            /// <para>The alert level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INFO: information</description></item>
            /// <item><description>WARN: warning</description></item>
            /// <item><description>CRITICAL: critical</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;INFO&quot;, &quot;WARN&quot;, &quot;CRITICAL&quot;]</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

        }

    }

}
