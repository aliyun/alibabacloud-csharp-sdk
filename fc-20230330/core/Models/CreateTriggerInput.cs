// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CreateTriggerInput : TeaModel {
        /// <summary>
        /// <para>The description of the trigger.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trigger for test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The RAM role that is used by the event source such as Object Storage Service (OSS) to invoke the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1234567890:role/fc-test</para>
        /// </summary>
        [NameInMap("invocationRole")]
        [Validation(Required=false)]
        public string InvocationRole { get; set; }

        /// <summary>
        /// <para>The version or alias of the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LATEST</para>
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the trigger event source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:oss:cn-shanghai:12345:mybucket</para>
        /// </summary>
        [NameInMap("sourceArn")]
        [Validation(Required=false)]
        public string SourceArn { get; set; }

        /// <summary>
        /// <para>The configurations of the trigger. The configurations vary based on the trigger type. The following items list the data structures for different types of triggers:</para>
        /// <list type="bullet">
        /// <item><description>OSS triggers: <a href="https://help.aliyun.com/document_detail/2766465.html">OSSTriggerConfig</a>.</description></item>
        /// <item><description>Simple Log Service trigger: <a href="https://help.aliyun.com/document_detail/2618711.html">LogTriggerConfig</a>.</description></item>
        /// <item><description>Time triggers: <a href="https://help.aliyun.com/document_detail/2754638.html">TimerTriggerConfig</a>.</description></item>
        /// <item><description>HTTP triggers: <a href="https://help.aliyun.com/document_detail/2766461.html">HTTPTriggerConfig</a>.</description></item>
        /// <item><description>Tablestore triggers: Specify the <b>SourceArnm</b> parameter and leave this parameter empty.</description></item>
        /// <item><description>Alibaba Cloud CDN event triggers: <a href="https://help.aliyun.com/document_detail/2766462.html">CDNEventsTriggerConfig</a>.</description></item>
        /// <item><description>MNS topic triggers: <a href="https://help.aliyun.com/document_detail/2766464.html">MnsTopicTriggerConfig</a>.</description></item>
        /// <item><description>EventBridge-based triggers: <a href="https://help.aliyun.com/document_detail/2766447.html">EventBridgeTriggerConfig</a>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;events&quot;:[&quot;oss:ObjectCreated:*&quot;],&quot;filter&quot;:{&quot;key&quot;:{&quot;prefix&quot;:&quot;/prefix&quot;,&quot;suffix&quot;:&quot;.zip&quot;}}}</para>
        /// </summary>
        [NameInMap("triggerConfig")]
        [Validation(Required=false)]
        public string TriggerConfig { get; set; }

        /// <summary>
        /// <para>The name of the trigger. The name can contain only letters, digits, hyphens (-), and underscores (_). The name must be 1 to 128 characters in length and cannot start with a digit or a hyphen (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss_create_object_demo</para>
        /// </summary>
        [NameInMap("triggerName")]
        [Validation(Required=false)]
        public string TriggerName { get; set; }

        /// <summary>
        /// <para>The type of the trigger. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>oss</b>: OSS event triggers. For more information, see <a href="https://help.aliyun.com/document_detail/2513613.html">Overview</a>.</description></item>
        /// <item><description><b>log</b>: Simple Log Service triggers. For more information, see <a href="https://help.aliyun.com/document_detail/2513638.html">Simple Log Service triggers</a>.</description></item>
        /// <item><description><b>timer</b>: time triggers. For more information, see <a href="https://help.aliyun.com/document_detail/2513611.html">Time triggers</a>.</description></item>
        /// <item><description><b>http</b>: HTTP triggers. For more information, see <a href="https://help.aliyun.com/document_detail/2513634.html">Overview</a>.</description></item>
        /// <item><description><b>tablestore</b>: Tablestore triggers. For more information, see <a href="https://help.aliyun.com/document_detail/2513640.html">Tablestore triggers</a>.</description></item>
        /// <item><description><b>cdn_events</b>: CDN event triggers. For more information, see <a href="https://help.aliyun.com/document_detail/2513636.html">Overview</a>.</description></item>
        /// <item><description><b>mns_topic</b>: Message Service (MNS) topic triggers. For more information, see <a href="https://help.aliyun.com/document_detail/2513641.html">MNS topic triggers</a>.</description></item>
        /// <item><description><b>eventbridge</b>: EventBridge-based triggers.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("triggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

    }

}
