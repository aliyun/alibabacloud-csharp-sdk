// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class KillJobsRequest : TeaModel {
        /// <summary>
        /// <para>The list of jobs to terminate. The instanceId is obtained from the job instance ID returned by ListJobInfos, and the projectName is obtained from the project name returned by ListProjects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///       {
        ///             &quot;instanceId&quot;: &quot;&quot;,
        ///             &quot;projectName&quot;: &quot;&quot;
        ///       },
        ///       {
        ///             &quot;instanceId&quot;: &quot;&quot;,
        ///             &quot;projectName&quot;: &quot;&quot;
        ///       }
        /// ]</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>478403690625249</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
