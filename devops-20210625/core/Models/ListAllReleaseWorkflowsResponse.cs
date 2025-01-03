// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListAllReleaseWorkflowsResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<ListAllReleaseWorkflowsResponseBody> Body { get; set; }
        public class ListAllReleaseWorkflowsResponseBody : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>testApp</para>
            /// </summary>
            [NameInMap("appName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ce51b31b996246ecaf874736838360b2</para>
            /// </summary>
            [NameInMap("sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("order")]
            [Validation(Required=false)]
            public string Order { get; set; }

            [NameInMap("releaseStages")]
            [Validation(Required=false)]
            public List<ListAllReleaseWorkflowsResponseBodyReleaseStages> ReleaseStages { get; set; }
            public class ListAllReleaseWorkflowsResponseBodyReleaseStages : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>testApp</para>
                /// </summary>
                [NameInMap("appName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5aa8cc67e75e41bf9dddeb708775bcc3</para>
                /// </summary>
                [NameInMap("sn")]
                [Validation(Required=false)]
                public string Sn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ce51b31b996246ecaf874736838360b2</para>
                /// </summary>
                [NameInMap("releaseWorkflowSn")]
                [Validation(Required=false)]
                public string ReleaseWorkflowSn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("order")]
                [Validation(Required=false)]
                public string Order { get; set; }

                [NameInMap("variableGroups")]
                [Validation(Required=false)]
                public List<ListAllReleaseWorkflowsResponseBodyReleaseStagesVariableGroups> VariableGroups { get; set; }
                public class ListAllReleaseWorkflowsResponseBodyReleaseStagesVariableGroups : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dev</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("displayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>APP</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("note")]
            [Validation(Required=false)]
            public string Note { get; set; }

        }

    }

}
