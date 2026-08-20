// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreatePersonalVoiceMeetingResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The bound directory ID. This value echoes the directoryId provided in the request body. If no directoryId is specified, the value is null because the default root directory is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleDirectoryId</para>
        /// </summary>
        [NameInMap("directoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The creation time in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-22T08:15:28.000+00:00</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The knowledge base name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-toolset-e95d1287-3d40-487a-bcce-6e6252c7a793</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5241B90-8FF4-565C-977A-0CE1842AED72</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource scope. The value is fixed to PERSONAL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_info projects pull_requests hook gists emails</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The unique identifier on the business system side, that is, the business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The resource status. The initial status during the creation process is typically PENDING. If the on_create process fails, the status is FAILED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;observedGeneration\&quot;: 4, \&quot;servicesInstances\&quot;: {}, \&quot;observedTime\&quot;: \&quot;2025-10-31T03:48:27Z\&quot;, \&quot;servicesWithPendingChanges\&quot;: [], \&quot;latestEnvironmentDeploymentName\&quot;: \&quot;manual-1761882507097-Eu1vIP\&quot;}</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
