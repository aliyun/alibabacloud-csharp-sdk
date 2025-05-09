// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListPipelineRunsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListPipelineRunsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListPipelineRunsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The processes.</para>
            /// </summary>
            [NameInMap("PipelineRuns")]
            [Validation(Required=false)]
            public List<ListPipelineRunsResponseBodyPagingInfoPipelineRuns> PipelineRuns { get; set; }
            public class ListPipelineRunsResponseBodyPagingInfoPipelineRuns : TeaModel {
                /// <summary>
                /// <para>The time when the process was created. This value is a UNIX timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1702736654000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The creator of the process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110755000425XXXX</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The process ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>097c73fe-ed6e-4fb1-b109-a5d59e46cd58</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The error message returned during the stage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Error message</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The time when the process was modified. This value is a UNIX timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1702736654000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The DataWorks workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70199</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The stages of the process.</para>
                /// </summary>
                [NameInMap("Stages")]
                [Validation(Required=false)]
                public List<ListPipelineRunsResponseBodyPagingInfoPipelineRunsStages> Stages { get; set; }
                public class ListPipelineRunsResponseBodyPagingInfoPipelineRunsStages : TeaModel {
                    /// <summary>
                    /// <para>The code of the stage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DEV_CHECK</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The description of the stage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Check before going online to development</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The additional information about the stage.</para>
                    /// </summary>
                    [NameInMap("Detail")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Detail { get; set; }

                    /// <summary>
                    /// <para>The error message returned during the stage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Error message</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>The name of the stage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Check before going online to development</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The status of the stage.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Init</description></item>
                    /// <item><description>Running</description></item>
                    /// <item><description>Success</description></item>
                    /// <item><description>Fail</description></item>
                    /// <item><description>Termination</description></item>
                    /// <item><description>Cancel</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Running</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The step number of the stage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Step")]
                    [Validation(Required=false)]
                    public int? Step { get; set; }

                    /// <summary>
                    /// <para>The type of the stage. This parameter indicates the operation type in the stage.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Deploy</description></item>
                    /// <item><description>Check</description></item>
                    /// <item><description>Offline</description></item>
                    /// <item><description>Build</description></item>
                    /// <item><description>Delete</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Check</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The status of the process.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Init</description></item>
                /// <item><description>Running</description></item>
                /// <item><description>Success</description></item>
                /// <item><description>Fail</description></item>
                /// <item><description>Termination</description></item>
                /// <item><description>Cancel</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2524</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C352CB7-CD88-50CF-9D0D-E81BDF02XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
