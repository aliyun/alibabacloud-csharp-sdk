// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateKnowledgeBaseAliDingDocResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleDirectoryId</para>
        /// </summary>
        [NameInMap("directoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The public URL of the document (echoes the input parameter).</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/winnexo/resource">https://example.com/winnexo/resource</a></para>
        /// </summary>
        [NameInMap("filePublicUrl")]
        [Validation(Required=false)]
        public string FilePublicUrl { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-05-22 16:03:27</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The error details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-toolset-b8a1de80-e9f5-49f3-8a12-873d378889c6</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F42FC60B-C54D-5DFB-A8EC-04625BFFF1F7</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The permission scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>repo</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The unique identifier on the business system side, which is the business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The refund status. Query this field to confirm the refund status during processing. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SUCCESS: All refunds are successful.</description></item>
        /// <item><description>FAIL: The refund failed.</description></item>
        /// <item><description>WAIT_PAY: Waiting for refund.</description></item>
        /// <item><description>EXPIRE: The refund has expired.</description></item>
        /// <item><description>PAYING: The refund is being processed.</description></item>
        /// <item><description>TERMINATE: The refund is terminated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;observedGeneration\&quot;: 7, \&quot;servicesInstances\&quot;: {}, \&quot;observedTime\&quot;: \&quot;2025-12-17T11:57:07Z\&quot;, \&quot;servicesWithPendingChanges\&quot;: [], \&quot;latestEnvironmentDeploymentName\&quot;: \&quot;manual-1765972627273-k7GZvr\&quot;}</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
