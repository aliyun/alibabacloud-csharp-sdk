// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDDLPublishRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the publishing records.</para>
        /// </summary>
        [NameInMap("DDLPublishRecordList")]
        [Validation(Required=false)]
        public List<ListDDLPublishRecordsResponseBodyDDLPublishRecordList> DDLPublishRecordList { get; set; }
        public class ListDDLPublishRecordsResponseBodyDDLPublishRecordList : TeaModel {
            /// <summary>
            /// <para>The time when the approval expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-14 20:52:38</para>
            /// </summary>
            [NameInMap("AuditExpireTime")]
            [Validation(Required=false)]
            public string AuditExpireTime { get; set; }

            /// <summary>
            /// <para>The approval state of the ticket. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>EXEMPT_PASS</b>: The ticket passes without approval.</description></item>
            /// <item><description><b>TO_AUDIT</b>: The ticket is pending for approval.</description></item>
            /// <item><description><b>CANCEL</b>: The ticket is canceled.</description></item>
            /// <item><description><b>SUCCESS</b>: The ticket is approved.</description></item>
            /// <item><description><b>FAIL</b>: The ticket fails to pass the approval.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CANCEL</para>
            /// </summary>
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }

            /// <summary>
            /// <para>Release remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Release remarks</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The ID of the user who creates the ticket. You can obtain the user ID by calling the <a href="https://help.aliyun.com/document_detail/147098.html">GetUser</a> operation and querying the value of the UserId parameter. The value is not the unique ID (UID) of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1423</para>
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public long? CreatorId { get; set; }

            /// <summary>
            /// <para>Indicates whether the approval is terminated. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The approval is terminated.</description></item>
            /// <item><description><b>false</b>: The approval is not terminated.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Multiple reasons can terminate the approval. For example, you withdraw the application or your ticket is not approved before the specified time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Finality")]
            [Validation(Required=false)]
            public bool? Finality { get; set; }

            /// <summary>
            /// <para>The reason for the termination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CANCEL</para>
            /// </summary>
            [NameInMap("FinalityReason")]
            [Validation(Required=false)]
            public string FinalityReason { get; set; }

            /// <summary>
            /// <para>The publishing state of the ticket. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>START</b>: The ticket is created.</description></item>
            /// <item><description><b>ANALYZE</b>: The ticket is under analysis.</description></item>
            /// <item><description><b>AUDIT</b>: The ticket is under approval.</description></item>
            /// <item><description><b>DISPATCH</b>: A task is generated for the ticket.</description></item>
            /// <item><description><b>SUCCESS</b>: The task is successful.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AUDIT</para>
            /// </summary>
            [NameInMap("PublishStatus")]
            [Validation(Required=false)]
            public string PublishStatus { get; set; }

            /// <summary>
            /// <para>The list of publishing tasks.</para>
            /// </summary>
            [NameInMap("PublishTaskInfoList")]
            [Validation(Required=false)]
            public List<ListDDLPublishRecordsResponseBodyDDLPublishRecordListPublishTaskInfoList> PublishTaskInfoList { get; set; }
            public class ListDDLPublishRecordsResponseBodyDDLPublishRecordListPublishTaskInfoList : TeaModel {
                /// <summary>
                /// <para>The ID of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4325</para>
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// <para>Indicates whether the database is a logical database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The database is a logical database.</description></item>
                /// <item><description><b>false</b>: the database is not a logical database.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// <para>The time to publish the ticket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-14 20:52:38</para>
                /// </summary>
                [NameInMap("PlanTime")]
                [Validation(Required=false)]
                public string PlanTime { get; set; }

                /// <summary>
                /// <para>The list of the publishing tasks.</para>
                /// </summary>
                [NameInMap("PublishJobList")]
                [Validation(Required=false)]
                public List<ListDDLPublishRecordsResponseBodyDDLPublishRecordListPublishTaskInfoListPublishJobList> PublishJobList { get; set; }
                public class ListDDLPublishRecordsResponseBodyDDLPublishRecordListPublishTaskInfoListPublishJobList : TeaModel {
                    /// <summary>
                    /// <para>The ID of the SQL task group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>423515</para>
                    /// </summary>
                    [NameInMap("DBTaskGroupId")]
                    [Validation(Required=false)]
                    public long? DBTaskGroupId { get; set; }

                    /// <summary>
                    /// <para>The number of SQL statements that are executed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ExecuteCount")]
                    [Validation(Required=false)]
                    public long? ExecuteCount { get; set; }

                    /// <summary>
                    /// <para>The script for data changes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ALTER TABLE test_toolkit_rename_table_after_rename MODIFY COLUMN gmt_modified datetime NOT NULL</para>
                    /// </summary>
                    [NameInMap("Scripts")]
                    [Validation(Required=false)]
                    public string Scripts { get; set; }

                    /// <summary>
                    /// <para>The description of the state.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NONE</para>
                    /// </summary>
                    [NameInMap("StatusDesc")]
                    [Validation(Required=false)]
                    public string StatusDesc { get; set; }

                    /// <summary>
                    /// <para>The name of the table after the change.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_toolkit_rename_table_after_rename</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                    /// <summary>
                    /// <para>The state of the publishing task. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>NONE</b>: The state of the task is unknown.</description></item>
                    /// <item><description><b>SUCCESS</b>: The task is successful.</description></item>
                    /// <item><description><b>FAIL</b>: The task fails.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NONE</para>
                    /// </summary>
                    [NameInMap("TaskJobStatus")]
                    [Validation(Required=false)]
                    public string TaskJobStatus { get; set; }

                }

                /// <summary>
                /// <para>The publishing policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>IMMEDIATELY</b>: immediately publishes the ticket.</description></item>
                /// <item><description><b>REGULARLY</b>: publishes the ticket at a scheduled time.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>IMMEDIATELY</para>
                /// </summary>
                [NameInMap("PublishStrategy")]
                [Validation(Required=false)]
                public string PublishStrategy { get; set; }

                /// <summary>
                /// <para>The description of the state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NONE</para>
                /// </summary>
                [NameInMap("StatusDesc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                /// <summary>
                /// <para>The state of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NONE</para>
                /// </summary>
                [NameInMap("TaskJobStatus")]
                [Validation(Required=false)]
                public string TaskJobStatus { get; set; }

            }

            /// <summary>
            /// <para>The risk level of the operation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NONE_RISK</b>: The operation does not have risks.</description></item>
            /// <item><description><b>LOW_RISK</b>: The operation is at low risk.</description></item>
            /// <item><description><b>MIDDLE_RISK</b>: The operation is at medium risk.</description></item>
            /// <item><description><b>HIGH_RISK</b>: The operation is at high risk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LOW_RISK</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The description of the publishing state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CANCEL</para>
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// <para>The ID of the approval process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>432153</para>
            /// </summary>
            [NameInMap("WorkflowInstanceId")]
            [Validation(Required=false)]
            public long? WorkflowInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1549FB0-D4B8-4140-919F-17322C1072B8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
