// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class Trigger : TeaModel {
        /// <summary>
        /// <para>The time when the trigger was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-08-20T02:28:21Z</para>
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The description of the trigger.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The information about the HTTP trigger.</para>
        /// </summary>
        [NameInMap("httpTrigger")]
        [Validation(Required=false)]
        public HTTPTrigger HttpTrigger { get; set; }

        /// <summary>
        /// <para>The role that is used by the event source such as OSS to invoke the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::151641468453****:role/my-role</para>
        /// </summary>
        [NameInMap("invocationRole")]
        [Validation(Required=false)]
        public string InvocationRole { get; set; }

        /// <summary>
        /// <para>The time when the trigger was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-04-23T06:32:43Z</para>
        /// </summary>
        [NameInMap("lastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

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
        /// <para>The Alibaba Cloud Resource Name (ARN) of the event source for the trigger.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:oss:cn-hangzhou:151641468453****:my-bucket</para>
        /// </summary>
        [NameInMap("sourceArn")]
        [Validation(Required=false)]
        public string SourceArn { get; set; }

        /// <summary>
        /// <para>The status of the trigger.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ARN of the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:oss:cn-hangzhou:151641468453****:my-bucket</para>
        /// </summary>
        [NameInMap("targetArn")]
        [Validation(Required=false)]
        public string TargetArn { get; set; }

        /// <summary>
        /// <para>The configurations of the trigger. The configurations vary based on trigger types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;events&quot;: [
        ///             &quot;oss:ObjectCreated:*&quot;
        ///       ],
        ///       &quot;filter&quot;: {
        ///             &quot;key&quot;: {
        ///                   &quot;prefix&quot;: &quot;/prefix&quot;,
        ///                   &quot;suffix&quot;: &quot;.zip&quot;
        ///             }
        ///       }
        /// }</para>
        /// </summary>
        [NameInMap("triggerConfig")]
        [Validation(Required=false)]
        public string TriggerConfig { get; set; }

        /// <summary>
        /// <para>The unique ID of the trigger.</para>
        /// 
        /// <b>Example:</b>
        /// <para>546959b5-ce1a-4991-8891-df7a02b25086</para>
        /// </summary>
        [NameInMap("triggerId")]
        [Validation(Required=false)]
        public string TriggerId { get; set; }

        /// <summary>
        /// <para>The name of the trigger. The name contains only letters, digits, hyphens (-), and underscores (_). The name must be 1 to 128 characters in length and cannot start with a digit or hyphen (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>defaultTrigger</para>
        /// </summary>
        [NameInMap("triggerName")]
        [Validation(Required=false)]
        public string TriggerName { get; set; }

        /// <summary>
        /// <para>The type of the trigger.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http</para>
        /// </summary>
        [NameInMap("triggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

    }

}
