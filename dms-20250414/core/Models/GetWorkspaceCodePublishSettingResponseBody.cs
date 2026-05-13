// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetWorkspaceCodePublishSettingResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWorkspaceCodePublishSettingResponseBodyData Data { get; set; }
        public class GetWorkspaceCodePublishSettingResponseBodyData : TeaModel {
            [NameInMap("Exclude")]
            [Validation(Required=false)]
            public List<string> Exclude { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("LockRepoBranch")]
            [Validation(Required=false)]
            public bool? LockRepoBranch { get; set; }

            [NameInMap("Repos")]
            [Validation(Required=false)]
            public List<GetWorkspaceCodePublishSettingResponseBodyDataRepos> Repos { get; set; }
            public class GetWorkspaceCodePublishSettingResponseBodyDataRepos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>main</para>
                /// </summary>
                [NameInMap("Branch")]
                [Validation(Required=false)]
                public string Branch { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/luna-public/</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>analyticscomputing/dide</para>
                /// </summary>
                [NameInMap("Repo")]
                [Validation(Required=false)]
                public string Repo { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>This record is being collected, please wait for a moment.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E0D21075-CD3E-4D98-8264-FD8AD04A63B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
