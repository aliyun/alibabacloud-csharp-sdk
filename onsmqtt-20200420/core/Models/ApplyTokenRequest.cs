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
        /// <item><description><b>R</b>: read-only. You can only subscribe to the specified topics.</description></item>
        /// <item><description><b>W</b>: write-only. You can only send messages to the specified topics.</description></item>
        /// <item><description><b>R,W</b>: read and write. You can send messages to and subscribe to the specified topics. Separate <b>R</b> and <b>W</b> with a comma (,).</description></item>
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
        /// <para>The timestamp that indicates the point in time when the token expires. Unit: milliseconds. The minimum validity period of a token is 60 seconds, and the maximum validity period of a token is 30 days. If you specify a validity period of more than 30 days for a token, no errors are returned. However, the token is valid only for 30 days.</para>
        /// <para>For example, you want to specify a validity period of 60 seconds for a token. If the current system timestamp is 1609434061000, you must set this parameter to <b>1609434121000</b>. The value is calculated by using the following formula: 1609434061000 + 60 x 1000 = 1609434121000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1609434121000</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraMQ for MQTT instance. The ID must be consistent with the ID of the instance that the ApsaraMQ for MQTT client uses. You can obtain the instance ID on the <b>Instance Details</b> page that corresponds to the instance in the <a href="https://mqtt.console.aliyun.com/">ApsaraMQ for MQTT console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>post-cn-0pp12gl****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The topics on the ApsaraMQ for MQTT instance. Separate multiple topics with commas (,). Each token can be used to access up to 100 topics. Multiple topics are sorted in alphabetic order. MQTT wildcards, including single-level wildcards represented by plus signs (+) and multi-level wildcards represented by number signs (#), can be used for the Resources parameter that you register to apply for a token.</para>
        /// <para>For example, if you set the <b>Resources</b> parameter to Topic1/+ when you apply for a token, the ApsaraMQ for MQTT client can manage the topics in Topic1/xxx. If you set the <b>Resources</b> parameter to Topic1/# when you apply for a token, the ApsaraMQ for MQTT client can manage topics of any level in Topic1/xxx/xxx/xxx.</para>
        /// <remarks>
        /// <para> ApsaraMQ for MQTT supports subtopics. You can specify subtopics in the code for messaging instead of configuring them in the ApsaraMQ for MQTT console. Forward slashes (/) are used to separate topics of different levels. For more information, see <a href="https://help.aliyun.com/document_detail/42420.html">Terms</a>.</para>
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
