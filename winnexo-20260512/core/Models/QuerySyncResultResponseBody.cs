// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class QuerySyncResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The time when the task was completed (ISO 8601 format).</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("completedAt")]
        [Validation(Required=false)]
        public string CompletedAt { get; set; }

        /// <summary>
        /// <para>The enterprise identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleCorpId</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <para>The department synchronization statistics. This field has a value when the task is completed.</para>
        /// </summary>
        [NameInMap("deptStats")]
        [Validation(Required=false)]
        public QuerySyncResultResponseBodyDeptStats DeptStats { get; set; }
        public class QuerySyncResultResponseBodyDeptStats : TeaModel {
            /// <summary>
            /// <para>The total number of external departments.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            /// <summary>
            /// <para>The number of user groups marked for deletion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("deleted")]
            [Validation(Required=false)]
            public long? Deleted { get; set; }

            /// <summary>
            /// <para>The number of moved user groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("moved")]
            [Validation(Required=false)]
            public long? Moved { get; set; }

            /// <summary>
            /// <para>The number of renamed user groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("renamed")]
            [Validation(Required=false)]
            public long? Renamed { get; set; }

            /// <summary>
            /// <para>The number of skipped user groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("skipped")]
            [Validation(Required=false)]
            public long? Skipped { get; set; }

            /// <summary>
            /// <para>The total number of external departments.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("totalExternal")]
            [Validation(Required=false)]
            public long? TotalExternal { get; set; }

        }

        /// <summary>
        /// <para>The execution duration, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("durationSeconds")]
        [Validation(Required=false)]
        public long? DurationSeconds { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The member synchronization statistics. This field has a value when syncMembers is set to true and the task is completed.</para>
        /// </summary>
        [NameInMap("memberStats")]
        [Validation(Required=false)]
        public QuerySyncResultResponseBodyMemberStats MemberStats { get; set; }
        public class QuerySyncResultResponseBodyMemberStats : TeaModel {
            /// <summary>
            /// <para>The number of failed members.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("failed")]
            [Validation(Required=false)]
            public long? Failed { get; set; }

            /// <summary>
            /// <para>The number of added member relationships.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("relationshipAdded")]
            [Validation(Required=false)]
            public long? RelationshipAdded { get; set; }

            /// <summary>
            /// <para>The number of removed member relationships.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("relationshipRemoved")]
            [Validation(Required=false)]
            public long? RelationshipRemoved { get; set; }

            /// <summary>
            /// <para>The total number of external members.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("totalExternal")]
            [Validation(Required=false)]
            public long? TotalExternal { get; set; }

            /// <summary>
            /// <para>The number of unchanged member relationships.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("unchanged")]
            [Validation(Required=false)]
            public long? Unchanged { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The platform type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("platformType")]
        [Validation(Required=false)]
        public string PlatformType { get; set; }

        /// <summary>
        /// <para>The request trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The time when the task started (ISO 8601 format).</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("startedAt")]
        [Validation(Required=false)]
        public string StartedAt { get; set; }

        /// <summary>
        /// <para>The task status. Valid values: PENDING, RUNNING, COMPLETED, FAILED, TIMEOUT, and CANCELED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>READY</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time when the task was submitted (ISO 8601 format).</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("submittedAt")]
        [Validation(Required=false)]
        public string SubmittedAt { get; set; }

        /// <summary>
        /// <para>The intelligent meeting summary content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
