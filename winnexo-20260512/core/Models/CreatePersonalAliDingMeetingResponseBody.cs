// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreatePersonalAliDingMeetingResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
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
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-11-12T03:08:56Z</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The name of the bot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-toolset-80a4520e-b35c-4e8b-acf7-3a01c7307522</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>247FBC97-433C-544A-BB29-98F572C06E9F</para>
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
        /// <para>2000358</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The signing status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CREATED: Created but not signed.</description></item>
        /// <item><description>SUCCESS: Signed.</description></item>
        /// <item><description>STOP: Terminated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;observedGeneration\&quot;: 2, \&quot;servicesInstances\&quot;: {}, \&quot;observedTime\&quot;: \&quot;2026-03-05T16:00:09Z\&quot;, \&quot;servicesWithPendingChanges\&quot;: [], \&quot;latestEnvironmentDeploymentName\&quot;: \&quot;manual-1772726409137-lmvsqr\&quot;}</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
