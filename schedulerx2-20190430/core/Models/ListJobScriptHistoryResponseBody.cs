// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ListJobScriptHistoryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListJobScriptHistoryResponseBodyData Data { get; set; }
        public class ListJobScriptHistoryResponseBodyData : TeaModel {
            /// <summary>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("JobScriptHistoryInfos")]
            [Validation(Required=false)]
            public List<ListJobScriptHistoryResponseBodyDataJobScriptHistoryInfos> JobScriptHistoryInfos { get; set; }
            public class ListJobScriptHistoryResponseBodyDataJobScriptHistoryInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-03-12 14:52:42</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1272118248844842</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("ScriptContent")]
                [Validation(Required=false)]
                public string ScriptContent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>init version</para>
                /// </summary>
                [NameInMap("VersionesDescription")]
                [Validation(Required=false)]
                public string VersionesDescription { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>job is not existed, jobId=302</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4F68ABED-AC31-4412-9297-D9A8F0401108</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
