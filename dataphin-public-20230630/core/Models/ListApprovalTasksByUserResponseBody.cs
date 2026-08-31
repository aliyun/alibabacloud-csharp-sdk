// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListApprovalTasksByUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The backend error details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The paging query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListApprovalTasksByUserResponseBodyPageResult PageResult { get; set; }
        public class ListApprovalTasksByUserResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The list of approval tasks.</para>
            /// </summary>
            [NameInMap("TaskList")]
            [Validation(Required=false)]
            public List<ListApprovalTasksByUserResponseBodyPageResultTaskList> TaskList { get; set; }
            public class ListApprovalTasksByUserResponseBodyPageResultTaskList : TeaModel {
                /// <summary>
                /// <para>The applicant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user001</para>
                /// </summary>
                [NameInMap("ApplicantId")]
                [Validation(Required=false)]
                public string ApplicantId { get; set; }

                /// <summary>
                /// <para>The applicant name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John</para>
                /// </summary>
                [NameInMap("ApplicantName")]
                [Validation(Required=false)]
                public string ApplicantName { get; set; }

                /// <summary>
                /// <para>The approval type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DATA_SOURCE</para>
                /// </summary>
                [NameInMap("ApprovalType")]
                [Validation(Required=false)]
                public string ApprovalType { get; set; }

                /// <summary>
                /// <para>The approval flow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The relationship between the current user and the approval task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUBMITTED</para>
                /// </summary>
                [NameInMap("RelationType")]
                [Validation(Required=false)]
                public string RelationType { get; set; }

                /// <summary>
                /// <para>The source system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Dataphin</para>
                /// </summary>
                [NameInMap("SourceSystem")]
                [Validation(Required=false)]
                public string SourceSystem { get; set; }

                /// <summary>
                /// <para>The approval status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>APPROVED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The submission time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-07-30 10:00:00</para>
                /// </summary>
                [NameInMap("SubmittedAt")]
                [Validation(Required=false)]
                public string SubmittedAt { get; set; }

                /// <summary>
                /// <para>The task name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Datasource application</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
