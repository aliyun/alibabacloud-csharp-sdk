// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class GetAgentJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The task information.</para>
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public GetAgentJobResponseBodyJob Job { get; set; }
        public class GetAgentJobResponseBodyJob : TeaModel {
            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bc30a1080b21434f961a0d9a391b30b9</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The task output JSON string. Different tasks return different structures, which are defined by the business side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;OssUri\&quot;:\&quot;oss://ice-ai-saas/ice-ai-saas-prd/1123668546389636/210606863/generate/ag_3a506706a33f44008aec6274d2e38d58/\&quot;}</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Created</description></item>
            /// <item><description>Queuing</description></item>
            /// <item><description>Executing</description></item>
            /// <item><description>Finished</description></item>
            /// <item><description>Failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
