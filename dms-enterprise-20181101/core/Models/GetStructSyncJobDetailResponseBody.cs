// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetStructSyncJobDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48602B78-0DDF-414C-8688-70CAB6070115</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the schema synchronization task.</para>
        /// </summary>
        [NameInMap("StructSyncJobDetail")]
        [Validation(Required=false)]
        public GetStructSyncJobDetailResponseBodyStructSyncJobDetail StructSyncJobDetail { get; set; }
        public class GetStructSyncJobDetailResponseBodyStructSyncJobDetail : TeaModel {
            /// <summary>
            /// <para>The ID of the SQL task group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("DBTaskGroupId")]
            [Validation(Required=false)]
            public long? DBTaskGroupId { get; set; }

            /// <summary>
            /// <para>The number of SQL statements that have been executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ExecuteCount")]
            [Validation(Required=false)]
            public long? ExecuteCount { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NEW</b>: The task was created.</description></item>
            /// <item><description><b>COMPARING</b>: The schemas of tables were being compared.</description></item>
            /// <item><description><b>COMPARE_BREAK</b>: The schema comparison was interrupted.</description></item>
            /// <item><description><b>COMPARE_FINISH</b>: The comparison was finished.</description></item>
            /// <item><description><b>NOT_SCRIPTS</b>: The comparison was finished but no executable script was available.</description></item>
            /// <item><description><b>SUBMITED_DBTASK</b>: The task was submitted.</description></item>
            /// <item><description><b>DBTASK_SUCCESS</b>: The task was complete.</description></item>
            /// <item><description><b>SUBMITED_WORKFLOW</b>: The ticket was submitted.</description></item>
            /// <item><description><b>WORKFLOW_SUCCESS</b>: The ticket was approved.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DBTASK_SUCCESS</para>
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            /// <summary>
            /// <para>The description of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The type of security rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CANNOT_SYNC</b>: Synchronization cannot be performed.</description></item>
            /// <item><description><b>WITH_APPROVE</b>: The schema synchronization can be performed after the ticket is approved. You can call the <a href="https://help.aliyun.com/document_detail/206166.html">SubmitStructSyncOrderApproval</a> operation to submit the ticket for approval.</description></item>
            /// <item><description><b>WITHOUT_APPROVE</b>: The schema synchronization can be performed without approval.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WITHOUT_APPROVE</para>
            /// </summary>
            [NameInMap("SecurityRule")]
            [Validation(Required=false)]
            public string SecurityRule { get; set; }

            /// <summary>
            /// <para>The total number of SQL statements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SqlCount")]
            [Validation(Required=false)]
            public long? SqlCount { get; set; }

            /// <summary>
            /// <para>The number of tables that have been analyzed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TableAnalyzed")]
            [Validation(Required=false)]
            public long? TableAnalyzed { get; set; }

            /// <summary>
            /// <para>The total number of tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TableCount")]
            [Validation(Required=false)]
            public long? TableCount { get; set; }

        }

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
