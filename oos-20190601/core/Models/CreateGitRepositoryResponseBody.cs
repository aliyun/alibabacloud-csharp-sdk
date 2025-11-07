// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreateGitRepositoryResponseBody : TeaModel {
        [NameInMap("GitRepo")]
        [Validation(Required=false)]
        public CreateGitRepositoryResponseBodyGitRepo GitRepo { get; set; }
        public class CreateGitRepositoryResponseBodyGitRepo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Test parameter for security testing</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aliyun-computest/lingo</para>
            /// </summary>
            [NameInMap("FullName")]
            [Validation(Required=false)]
            public string FullName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://github.com/alibaba/fastjson">https://github.com/alibaba/fastjson</a></para>
            /// </summary>
            [NameInMap("HtmlUrl")]
            [Validation(Required=false)]
            public string HtmlUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("IsPrivate")]
            [Validation(Required=false)]
            public string IsPrivate { get; set; }

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
