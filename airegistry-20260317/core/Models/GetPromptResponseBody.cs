// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class GetPromptResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPromptResponseBodyData Data { get; set; }
        public class GetPromptResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of business tags.</para>
            /// </summary>
            [NameInMap("BizTags")]
            [Validation(Required=false)]
            public List<string> BizTags { get; set; }

            /// <summary>
            /// <para>The description of the prompt.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Prompt for test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The version number of the draft version. This value is empty if no draft version exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.1</para>
            /// </summary>
            [NameInMap("EditingVersion")]
            [Validation(Required=false)]
            public string EditingVersion { get; set; }

            /// <summary>
            /// <para>The time when the prompt was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-13T02:11:53Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The mapping between prompt labels and versions.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public Dictionary<string, string> Labels { get; set; }

            /// <summary>
            /// <para>The version number of the latest version of the prompt.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.1</para>
            /// </summary>
            [NameInMap("LatestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            /// <summary>
            /// <para>The number of online versions of the prompt.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OnlineCnt")]
            [Validation(Required=false)]
            public int? OnlineCnt { get; set; }

            /// <summary>
            /// <para>The unique identifier of the prompt.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer-service-qa</para>
            /// </summary>
            [NameInMap("PromptKey")]
            [Validation(Required=false)]
            public string PromptKey { get; set; }

            /// <summary>
            /// <para>The version number of the prompt version that is under review.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.1</para>
            /// </summary>
            [NameInMap("ReviewingVersion")]
            [Validation(Required=false)]
            public string ReviewingVersion { get; set; }

            /// <summary>
            /// <para>The schema version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("SchemaVersion")]
            [Validation(Required=false)]
            public int? SchemaVersion { get; set; }

            /// <summary>
            /// <para>The list of version details.</para>
            /// </summary>
            [NameInMap("VersionDetails")]
            [Validation(Required=false)]
            public List<GetPromptResponseBodyDataVersionDetails> VersionDetails { get; set; }
            public class GetPromptResponseBodyDataVersionDetails : TeaModel {
                /// <summary>
                /// <para>The commit message of the version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is a test Version</para>
                /// </summary>
                [NameInMap("CommitMsg")]
                [Validation(Required=false)]
                public string CommitMsg { get; set; }

                /// <summary>
                /// <para>The time when the version was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1627545952000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>The unique identifier of the prompt.</para>
                /// 
                /// <b>Example:</b>
                /// <para>customer-service-qa</para>
                /// </summary>
                [NameInMap("PromptKey")]
                [Validation(Required=false)]
                public string PromptKey { get; set; }

                /// <summary>
                /// <para>The creator of the version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("SrcUser")]
                [Validation(Required=false)]
                public string SrcUser { get; set; }

                /// <summary>
                /// <para>The version status. Valid values: draft and online.</para>
                /// 
                /// <b>Example:</b>
                /// <para>online</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The list of version numbers.</para>
            /// </summary>
            [NameInMap("Versions")]
            [Validation(Required=false)]
            public List<string> Versions { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9E87E66-9EF0-5C10-A5E6-924020A0C9B7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
