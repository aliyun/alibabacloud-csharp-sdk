// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class CreateMultiModalTaskRequest : TeaModel {
        /// <summary>
        /// <para>The AgentSpace name. It must be 3 to 63 characters in length and can contain only lowercase letters, digits, and hyphens. It must start and end with a letter or a digit.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-space</para>
        /// </summary>
        [NameInMap("agentSpace")]
        [Validation(Required=false)]
        public string AgentSpace { get; set; }

        /// <summary>
        /// <para>The input parameters for the evaluator. The keys are defined by the evaluator specified by evaluatorRef. Example for national subsidy image inspection: {&quot;imageUrl&quot;:&quot;<a href="https://example.com/label.jpg%22%7D">https://example.com/label.jpg&quot;}</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;imageUrl&quot;:&quot;<a href="https://example-bucket.oss-cn-hangzhou.aliyuncs.com/label.jpg%22%7D">https://example-bucket.oss-cn-hangzhou.aliyuncs.com/label.jpg&quot;}</a></para>
        /// </summary>
        [NameInMap("args")]
        [Validation(Required=false)]
        public Dictionary<string, object> Args { get; set; }

        /// <summary>
        /// <para>The ARN of the role used to access OSS or SLS, such as acs:ram::<accountId>:role/<roleName>. It is used to derive the signature region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1234567890123456:role/media-reader</para>
        /// </summary>
        [NameInMap("arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        /// <summary>
        /// <para>The name of the evaluator registered as a public API. If the evaluator is not registered, not exposed as a public API, or the current version is invalid, a 400 error is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Builtin.subsidy_api</para>
        /// </summary>
        [NameInMap("evaluatorRef")]
        [Validation(Required=false)]
        public string EvaluatorRef { get; set; }

        /// <summary>
        /// <para>The signature region when the media is stored in OSS or SLS, such as cn-hangzhou. This parameter is used only when the region cannot be determined from the URL itself.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ossRegion")]
        [Validation(Required=false)]
        public string OssRegion { get; set; }

        /// <summary>
        /// <para>The evaluation prompt. If omitted, it is processed as an empty string. The maximum length is 2,000 characters, counted by Unicode code points.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Verify whether the image is complete</para>
        /// </summary>
        [NameInMap("prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The task name, used to group multiple calls of the same business line in the console. If omitted or empty, agentloop-media-process is used. The maximum length is 128 characters. Control characters are not allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agentloop-media-process</para>
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
