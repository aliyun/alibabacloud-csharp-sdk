// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaasQIService20260831.Models
{
    public class CameraChatCompletionStreamHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>The access key of the specified Camera instance. Provide the raw value without the Bearer prefix. This key is not an AccessKey secret and cannot replace an OpenAPI signature.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qis_xxx</para>
        /// </summary>
        [NameInMap("X-QI-Agent-Api-Key")]
        [Validation(Required=false)]
        public string XQIAgentApiKey { get; set; }

        /// <summary>
        /// <para>The request ID. A trusted POP ID is preferred. If no trusted POP ID is available, this header is required. The requestId field in the request body is not accepted. For the format and retry rules, refer to the supplementary instructions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>camera-request-001</para>
        /// </summary>
        [NameInMap("X-QI-Request-Id")]
        [Validation(Required=false)]
        public string XQIRequestId { get; set; }

        /// <summary>
        /// <para>The optional session ID. If omitted, a session ID is generated. Reuse the original value for continuation and successful replay. For the format and retrieval method, refer to the supplementary instructions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>camera-session-001</para>
        /// </summary>
        [NameInMap("X-QI-Session-Id")]
        [Validation(Required=false)]
        public string XQISessionId { get; set; }

        /// <summary>
        /// <para>The ID of the published CameraStandard instance. This ID must correspond to the X-QI-Agent-Api-Key header. The recognition scene, model, and thresholds are derived from the published configuration of this instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAMERA_xxx</para>
        /// </summary>
        [NameInMap("x-QI-Instance-Id")]
        [Validation(Required=false)]
        public string XQIInstanceId { get; set; }

    }

}
