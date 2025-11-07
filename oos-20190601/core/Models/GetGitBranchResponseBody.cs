// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetGitBranchResponseBody : TeaModel {
        [NameInMap("Commit")]
        [Validation(Required=false)]
        public GetGitBranchResponseBodyCommit Commit { get; set; }
        public class GetGitBranchResponseBodyCommit : TeaModel {
            /// <summary>
            /// <para>git commit message</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>git commit hash</para>
            /// 
            /// <b>Example:</b>
            /// <para>51417755</para>
            /// </summary>
            [NameInMap("Sha")]
            [Validation(Required=false)]
            public string Sha { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AA9FA778-AE4B-55EC-81CC-C46BAF08A166</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
