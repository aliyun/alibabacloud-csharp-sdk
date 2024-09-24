// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutMetricRuleTargetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The failed data.</para>
        /// </summary>
        [NameInMap("FailData")]
        [Validation(Required=false)]
        public PutMetricRuleTargetsResponseBodyFailData FailData { get; set; }
        public class PutMetricRuleTargetsResponseBodyFailData : TeaModel {
            /// <summary>
            /// <para>The information about the resources for which alerts are triggered.</para>
            /// </summary>
            [NameInMap("Targets")]
            [Validation(Required=false)]
            public PutMetricRuleTargetsResponseBodyFailDataTargets Targets { get; set; }
            public class PutMetricRuleTargetsResponseBodyFailDataTargets : TeaModel {
                [NameInMap("Target")]
                [Validation(Required=false)]
                public List<PutMetricRuleTargetsResponseBodyFailDataTargetsTarget> Target { get; set; }
                public class PutMetricRuleTargetsResponseBodyFailDataTargetsTarget : TeaModel {
                    /// <summary>
                    /// <para>The ARN of the resource. Format: <c>acs:{Service name abbreviation}:{regionId}:{userId}:/{Resource type}/{Resource name}/message</c>. MNS, Auto Scaling, Simple Log Service, and Function Compute are supported. Example: <c>acs:mns:cn-hangzhou:120886317861****:/queues/test123/message</c>. The following part describes the ARN of MNS and the parameters in the ARN:</para>
                    /// <list type="bullet">
                    /// <item><description><para>{Service name abbreviation}: mns.</para>
                    /// </description></item>
                    /// <item><description><para>{userId}: the ID of the Alibaba Cloud account.</para>
                    /// </description></item>
                    /// <item><description><para>{regionId}: the region ID of the message queue or topic.</para>
                    /// </description></item>
                    /// <item><description><para>{Resource type}: the type of the resource for which alerts are triggered. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>queues</b></description></item>
                    /// <item><description><b>topics</b></description></item>
                    /// </list>
                    /// </description></item>
                    /// <item><description><para>{Resource name}: the resource name.</para>
                    /// <list type="bullet">
                    /// <item><description>If the resource type is <b>queues</b>, the resource name is the queue name.</description></item>
                    /// <item><description>If the resource type is <b>topics</b>, the resource name is the topic name.</description></item>
                    /// </list>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs:mns:cn-hangzhou:111:/queues/test/message</para>
                    /// </summary>
                    [NameInMap("Arn")]
                    [Validation(Required=false)]
                    public string Arn { get; set; }

                    /// <summary>
                    /// <para>The ID of the resource for which alerts are triggered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The alert level. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>INFO</description></item>
                    /// <item><description>WARN</description></item>
                    /// <item><description>CRITICAL</description></item>
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

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A569B0D-9055-58AF-9E82-BAEAF95C0FD5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
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
