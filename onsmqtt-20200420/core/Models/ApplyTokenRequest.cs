// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class ApplyTokenRequest : TeaModel {
        /// <summary>
        /// <para>The permission type of the token. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>R</b>: read-only permissions. The client can only subscribe to the specified topics and cannot publish messages to the topics.</description></item>
        /// <item><description><b>W</b>: write-only permissions. The client can only publish messages to the specified topics and cannot subscribe to the topics.</description></item>
        /// <item><description><b>R,W</b>: read and write permissions. The client can publish messages to and subscribe to the specified topics. Separate <b>R</b> and <b>W</b> with a comma (,).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>R</para>
        /// </summary>
        [NameInMap("Actions")]
        [Validation(Required=false)]
        public string Actions { get; set; }

        /// <summary>
        /// <para>The expiration time of the token. The value is a millisecond timestamp. The minimum effective period is 60 seconds, and the maximum effective period is 30 days. If the specified value exceeds 30 days, the API operation does not return an error, but the actual effective period is 30 days.</para>
        /// <para>Example: If the effective period of the token is 60 seconds and the current system time in milliseconds is 1609434061000, set this parameter to <b>1609434121000</b>, which is the sum of 1609434061000 and 60 × 1000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1609434121000</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraMQ for MQTT instance. The instance ID must match the actual instance ID used by the client. You can obtain the instance ID on the <b>Instance Details</b> page in the <a href="https://mqtt.console.aliyun.com/">console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>post-cn-0pp12gl****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The resource name, which is the topic of ApsaraMQ for MQTT. Separate multiple topics with commas (,). Each token can be used to perform operations on up to 100 resources. If multiple topics are specified, they must be sorted in lexicographical order.
        /// The resource parameter registered when you apply for a token supports the MQTT wildcard syntax, including the plus sign (+) for single-level wildcards and the number sign (#) for multi-level wildcards.</para>
        /// <para>For example, if you set <b>Resources</b> to &quot;Topic1/+&quot; when you apply for a token, the client can perform operations on any topic in the format of &quot;Topic1/xxx&quot;. If you set <b>Resources</b> to &quot;Topic1/#&quot;, the client can perform operations on any multi-level topic in the format of &quot;Topic1/xxx/xxx/xxx&quot;.</para>
        /// <remarks>
        /// <para>ApsaraMQ for MQTT supports matching child topics. You do not need to create child topics in the console. You can directly configure the settings in the message sending and receiving code. The forward slash (/) in a topic name is used to separate the parent topic and child topics. For more information, see <a href="https://help.aliyun.com/document_detail/42420.html">Terms</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TopicA/+</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

    }

}
