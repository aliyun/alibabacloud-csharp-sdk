// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListPipelinesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The paged query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListPipelinesResponseBodyData Data { get; set; }
        public class ListPipelinesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of task information on the current page.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListPipelinesResponseBodyDataList> List { get; set; }
            public class ListPipelinesResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The list of user IDs of development owners.</para>
                /// </summary>
                [NameInMap("DevelopOwners")]
                [Validation(Required=false)]
                public List<string> DevelopOwners { get; set; }

                /// <summary>
                /// <para>The directory in which the task resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/dwd/Finance/</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <para>The file ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12121111</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <para>The scheduling node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_6793582765516849152</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The node name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The list of user IDs of O&amp;M owners.</para>
                /// </summary>
                [NameInMap("OpsOwners")]
                [Validation(Required=false)]
                public List<string> OpsOwners { get; set; }

                /// <summary>
                /// <para>The pipeline ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1450811</para>
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public long? PipelineId { get; set; }

                /// <summary>
                /// <para>The schedule type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: periodic scheduling.</description></item>
                /// <item><description>3: manual scheduling.</description></item>
                /// <item><description>5: real-time scheduling.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ScheduleType")]
                [Validation(Required=false)]
                public int? ScheduleType { get; set; }

                /// <summary>
                /// <para>The list of task tag names.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

                /// <summary>
                /// <para>The task status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DRAFT: draft.</description></item>
                /// <item><description>SUBMITTING: being submitted.</description></item>
                /// <item><description>SUBMITTED: submitted.</description></item>
                /// <item><description>PUBLISHED: published.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SUBMITTED</para>
                /// </summary>
                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public string TaskStatus { get; set; }

                /// <summary>
                /// <para>The task type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: offline integration.</description></item>
                /// <item><description>1: real-time integration.</description></item>
                /// <item><description>13: data aggregation.</description></item>
                /// <item><description>14: offline unstructured workflow.</description></item>
                /// <item><description>15: real-time unstructured workflow.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public int? TaskType { get; set; }

            }

            /// <summary>
            /// <para>The cursor for the next page (an opaque cursor that the caller does not need to interpret). A null value indicates that there are no more pages. Otherwise, pass this value as the nextCursor parameter in the next request to retrieve the next page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("NextCursor")]
            [Validation(Required=false)]
            public long? NextCursor { get; set; }

            /// <summary>
            /// <para>The current page number, starting from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

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
            /// <para>The total number of records that match the conditions. On the first page request, the actual total is returned. On subsequent page requests (when nextCursor is passed in), if totalCount is included in the request, the same value is returned. Otherwise, this field is not returned. The total value is a snapshot taken at the time of the first page query and is not updated in real time as data changes during pagination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>105</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
