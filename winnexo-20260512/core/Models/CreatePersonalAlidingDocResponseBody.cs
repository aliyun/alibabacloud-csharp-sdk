// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreatePersonalAlidingDocResponseBody : TeaModel {
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
        /// <para>The folder ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleDirectoryId</para>
        /// </summary>
        [NameInMap("directoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The publicly accessible URL of the AliDing online document.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/winnexo/resource">https://example.com/winnexo/resource</a></para>
        /// </summary>
        [NameInMap("filePublicUrl")]
        [Validation(Required=false)]
        public string FilePublicUrl { get; set; }

        /// <summary>
        /// <para>The timestamp when the customer group was created. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-22T08:15:28.000+00:00</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pipeline name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_paswd_104</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E68654BD-F7BA-5837-8686-5645D739A47C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The permission scope.</para>
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
        /// <para>2000413</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The call status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PENDING</b>: Waiting for receipt.</description></item>
        /// <item><description><b>SUCCESS</b>: Succeeded.</description></item>
        /// <item><description><b>FAILED</b>: Failed.</description></item>
        /// <item><description><b>TIMEOUT</b>: Timed out.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;servicesInstances\&quot;: {}, \&quot;servicesWithPendingChanges\&quot;: []}</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
