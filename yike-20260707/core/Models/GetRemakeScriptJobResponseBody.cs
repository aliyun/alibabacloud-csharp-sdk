// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class GetRemakeScriptJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The generated creative script object.</para>
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public GetRemakeScriptJobResponseBodyJob Job { get; set; }
        public class GetRemakeScriptJobResponseBodyJob : TeaModel {
            /// <summary>
            /// <para>The error code. Returned when the status is Failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message. Returned when the status is Failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The specified product does not exist.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>68ca759e798b40b4903b255*******</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The URL of the file that contains the script rewriting result. The file content is the creative script in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxxx.json">http://xxxx.json</a></para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Created: The task is created.</description></item>
            /// <item><description>Executing: The task is executing.</description></item>
            /// <item><description>Finished: The task is finished.</description></item>
            /// <item><description>Failed: The task failed.</description></item>
            /// <item><description>Deleted: The task is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Executing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The user-defined parameter, which is a string in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;NotifyAddress&quot;: &quot;<a href="http://xxx.callback.url%22%7D">http://xxx.callback.url&quot;}</a></para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
