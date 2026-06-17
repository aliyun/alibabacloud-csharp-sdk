// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutMetricRuleTargetsRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the alert rule.</para>
        /// <para>For information about how to obtain the alert rule ID, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</para>
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
            /// <para>The Alibaba Cloud Resource Name (ARN) of the resource. Simple Message Queue (formerly MNS), elastic scaling (ESS), Simple Log Service (SLS), and Function Compute (FC) are supported.</para>
            /// <para>The following section describes the ARN parameter metric description for Simple Message Queue (formerly MNS):</para>
            /// <para><c>acs:mns:{regionId}:{userId}:/{Resource type}/{Resource name}/message</c></para>
            /// <list type="bullet">
            /// <item><description><para>{regionId}: the region where the MSMQ or topic of Simple Message Queue (formerly MNS) resides.</para>
            /// </description></item>
            /// <item><description><para>{userId}: the Alibaba Cloud account that owns the resource.</para>
            /// </description></item>
            /// <item><description><para>{Resource type}: the type of the resource that accepts alert notifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>queues</b>: queue.</description></item>
            /// <item><description><b>topics</b>: topic.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>{Resource name}: the name of the resource.</para>
            /// <list type="bullet">
            /// <item><description>If the resource type is <b>queues</b>, the resource name is the queue name.</description></item>
            /// <item><description>If the resource type is <b>topics</b>, the resource name is the topic name.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <para>ARN for elastic scaling:</para>
            /// <para>acs:ess:{regionId}:{userId}:scalingGroupId/{Scaling group ID}:scalingRuleId/{Scaling rule ID}</para>
            /// <para>ARN for Simple Log Service:</para>
            /// <para>acs:log:{regionId}:{userId}:project/{Project name}/logstore/{Logstore name}</para>
            /// <para>ARN for Function Compute:</para>
            /// <para>acs:fc:{regionId}:{userId}:services/{Service name}/functions/{Function name}.</para>
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
            /// <para>For information about how to obtain the alert trigger target ID, see <a href="https://help.aliyun.com/document_detail/121592.html">DescribeMetricRuleTargets</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The JSON-formatted parameters of the alert callback.</para>
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
            /// <item><description>INFO: information.</description></item>
            /// <item><description>WARN: warning.</description></item>
            /// <item><description>CRITICAL: critical.</description></item>
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
