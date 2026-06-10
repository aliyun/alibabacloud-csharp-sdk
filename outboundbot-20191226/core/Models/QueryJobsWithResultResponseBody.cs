// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class QueryJobsWithResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The value <c>OK</c> indicates that the request was successful.</para>
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
        /// <para>The paginated list of jobs.</para>
        /// </summary>
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public QueryJobsWithResultResponseBodyJobs Jobs { get; set; }
        public class QueryJobsWithResultResponseBodyJobs : TeaModel {
            /// <summary>
            /// <para>A list of jobs.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryJobsWithResultResponseBodyJobsList> List { get; set; }
            public class QueryJobsWithResultResponseBodyJobsList : TeaModel {
                /// <summary>
                /// <para>The job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cc231a1d-3c05-4739-8926-193ecf4097ba</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The reason the job failed.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description>Unknown（未知错误）</description></item>
                /// <item><description>NoAnswer（无人接听）</description></item>
                /// <item><description>InvalidStrategy（无效的策略，策略配置不正确）</description></item>
                /// <item><description>TimeUp（调度时发现超时）</description></item>
                /// <item><description>NoStrategy（策略为空或没有找到）</description></item>
                /// <item><description>CallFailed（呼叫失败）
                /// -PerDayCallCountLimit（号码每日呼叫次数限制）</description></item>
                /// <item><description>ContactBlockList（禁止外呼名单）</description></item>
                /// <item><description>EmptyNumber（空号不再外呼）</description></item>
                /// <item><description>JobPerDayCallCountLimit（号码每日呼叫次数限制）</description></item>
                /// <item><description>VerificationCancelled（呼叫前验证不通过取消）</description></item>
                /// <item><description>ContactSuspended（止呼）</description></item>
                /// <item><description>InArrears（欠费）</description></item>
                /// <item><description>OutOfService（停机）</description></item>
                /// <item><description>NoneRepeatableJobMaxAttemptCountLimit（ 任务最大尝试次数， 当RepeatBy（@see ）为None时生效）</description></item>
                /// </list>
                /// </summary>
                [NameInMap("JobFailureReason")]
                [Validation(Required=false)]
                public string JobFailureReason { get; set; }

                /// <summary>
                /// <para>The most recent call.</para>
                /// </summary>
                [NameInMap("LatestTask")]
                [Validation(Required=false)]
                public QueryJobsWithResultResponseBodyJobsListLatestTask LatestTask { get; set; }
                public class QueryJobsWithResultResponseBodyJobsListLatestTask : TeaModel {
                    /// <summary>
                    /// <para>The call duration, in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>40000</para>
                    /// </summary>
                    [NameInMap("CallDuration")]
                    [Validation(Required=false)]
                    public int? CallDuration { get; set; }

                    /// <summary>
                    /// <para>The call duration, formatted for display.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>40</para>
                    /// </summary>
                    [NameInMap("CallDurationDisplay")]
                    [Validation(Required=false)]
                    public string CallDurationDisplay { get; set; }

                    /// <summary>
                    /// <para>The time when the call was made. This value is a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1615363297000</para>
                    /// </summary>
                    [NameInMap("CallTime")]
                    [Validation(Required=false)]
                    public long? CallTime { get; set; }

                    /// <summary>
                    /// <para>The contact.</para>
                    /// </summary>
                    [NameInMap("Contact")]
                    [Validation(Required=false)]
                    public QueryJobsWithResultResponseBodyJobsListLatestTaskContact Contact { get; set; }
                    public class QueryJobsWithResultResponseBodyJobsListLatestTaskContact : TeaModel {
                        /// <summary>
                        /// <para>The honorific for the contact, such as Mr. or Ms. If not provided, it defaults to the value of the <c>Name</c> parameter.</para>
                        /// <remarks>
                        /// <para>This is a custom parameter. You can specify it in the JSON object when you start an outbound job.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>张先生</para>
                        /// </summary>
                        [NameInMap("Honorific")]
                        [Validation(Required=false)]
                        public string Honorific { get; set; }

                        /// <summary>
                        /// <para>The unique ID of the contact, generated by the system when the contact list is uploaded.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>63860deb-6218-45df-b1e0-76f2b166e790</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The job ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cc231a1d-3c05-4739-8926-193ecf4097ba</para>
                        /// </summary>
                        [NameInMap("JobUuid")]
                        [Validation(Required=false)]
                        public string JobUuid { get; set; }

                        /// <summary>
                        /// <para>The name of the contact. For example, John Smith.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>张三</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The phone number of the contact.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1882020****</para>
                        /// </summary>
                        [NameInMap("PhoneNumber")]
                        [Validation(Required=false)]
                        public string PhoneNumber { get; set; }

                        /// <summary>
                        /// <para>The phone number specified by the callee during the conversation. If provided, Outbound Bot calls this number.</para>
                        /// <remarks>
                        /// <para>This is a custom parameter. You can specify it in the JSON object when you start an outbound job.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>134123****</para>
                        /// </summary>
                        [NameInMap("PreferredPhoneNumber")]
                        [Validation(Required=false)]
                        public string PreferredPhoneNumber { get; set; }

                        /// <summary>
                        /// <para>Your custom ID for the contact. This ID helps you uniquely identify the contact and prevent issues caused by duplicate names.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>C01</para>
                        /// </summary>
                        [NameInMap("ReferenceId")]
                        [Validation(Required=false)]
                        public string ReferenceId { get; set; }

                        /// <summary>
                        /// <para>The role of the contact in the outbound calling scenario. This parameter is optional. For example, in a debt collection scenario, roles can include <c>borrower</c>, <c>co-borrower</c>, or <c>guarantor</c>.</para>
                        /// <remarks>
                        /// <para>This is a custom parameter. You can specify it in the JSON object when starting a job.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>借款人</para>
                        /// </summary>
                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        /// <summary>
                        /// <para>The call attempt number.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>151</para>
                        /// </summary>
                        [NameInMap("Round")]
                        [Validation(Required=false)]
                        public int? Round { get; set; }

                        /// <summary>
                        /// <para>The status of the contact. For example, <c>Available</c> (the contact is available), <c>WrongNumber</c> (the phone number is incorrect), or <c>DoesNotExist</c> (the phone number does not exist).</para>
                        /// <remarks>
                        /// <para>This is a custom parameter. You can specify it in the JSON object when you start an outbound job.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Available</para>
                        /// </summary>
                        [NameInMap("State")]
                        [Validation(Required=false)]
                        public string State { get; set; }

                    }

                    /// <summary>
                    /// <para>The error codes for the call.</para>
                    /// </summary>
                    [NameInMap("DialExceptionCodes")]
                    [Validation(Required=false)]
                    public List<QueryJobsWithResultResponseBodyJobsListLatestTaskDialExceptionCodes> DialExceptionCodes { get; set; }
                    public class QueryJobsWithResultResponseBodyJobsListLatestTaskDialExceptionCodes : TeaModel {
                        /// <summary>
                        /// <para>The error code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// <para>Error message</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>无</para>
                        /// </summary>
                        [NameInMap("Hint")]
                        [Validation(Required=false)]
                        public string Hint { get; set; }

                    }

                    /// <summary>
                    /// <para>The custom tags (key-value pairs) associated with the call.</para>
                    /// </summary>
                    [NameInMap("Extras")]
                    [Validation(Required=false)]
                    public List<QueryJobsWithResultResponseBodyJobsListLatestTaskExtras> Extras { get; set; }
                    public class QueryJobsWithResultResponseBodyJobsListLatestTaskExtras : TeaModel {
                        /// <summary>
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>是否已经接通</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>是</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>被叫用户</para>
                    /// </summary>
                    [NameInMap("HangUpDirection")]
                    [Validation(Required=false)]
                    public string HangUpDirection { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the call was answered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("HasAnswered")]
                    [Validation(Required=false)]
                    public bool? HasAnswered { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the call was hung up due to rejection.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("HasHangUpByRejection")]
                    [Validation(Required=false)]
                    public bool? HasHangUpByRejection { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the last voice playback was completed before the call was hung up.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("HasLastPlaybackCompleted")]
                    [Validation(Required=false)]
                    public bool? HasLastPlaybackCompleted { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the call flow was completed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("HasReachedEndOfFlow")]
                    [Validation(Required=false)]
                    public bool? HasReachedEndOfFlow { get; set; }

                    /// <summary>
                    /// <para>The call status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Succeeded</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The name of the call status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>未呼出-超出每日上限</para>
                    /// </summary>
                    [NameInMap("StatusName")]
                    [Validation(Required=false)]
                    public string StatusName { get; set; }

                    /// <summary>
                    /// <para>Information about tags that were matched. This parameter is returned for flows created using the legacy canvas.</para>
                    /// </summary>
                    [NameInMap("TagHits")]
                    [Validation(Required=false)]
                    public List<QueryJobsWithResultResponseBodyJobsListLatestTaskTagHits> TagHits { get; set; }
                    public class QueryJobsWithResultResponseBodyJobsListLatestTaskTagHits : TeaModel {
                        /// <summary>
                        /// <para>The tag group to which the tag belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>动物</para>
                        /// </summary>
                        [NameInMap("TagGroup")]
                        [Validation(Required=false)]
                        public string TagGroup { get; set; }

                        /// <summary>
                        /// <para>The tag name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>猫幼年期,猫幼年期</para>
                        /// </summary>
                        [NameInMap("TagName")]
                        [Validation(Required=false)]
                        public string TagName { get; set; }

                    }

                    /// <summary>
                    /// <para>The call end reason.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FINISHED</para>
                    /// </summary>
                    [NameInMap("TaskEndReason")]
                    [Validation(Required=false)]
                    public string TaskEndReason { get; set; }

                }

                /// <summary>
                /// <para>The job status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Scheduling</c>: The job is being scheduled.</para>
                /// </description></item>
                /// <item><description><para><c>Executing</c>: The job is in progress.</para>
                /// </description></item>
                /// <item><description><para><c>Succeeded</c>: The job succeeded, and the contact was reached.</para>
                /// </description></item>
                /// <item><description><para><c>Paused</c>: The job is paused.</para>
                /// </description></item>
                /// <item><description><para><c>Failed</c>: The job failed because the contact was not reached.</para>
                /// </description></item>
                /// <item><description><para><c>Cancelled</c>: The job was cancelled by a user.</para>
                /// </description></item>
                /// <item><description><para><c>Drafted</c>: The job is a draft.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Succeeded</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The name of the job status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>结束-已触达</para>
                /// </summary>
                [NameInMap("StatusName")]
                [Validation(Required=false)]
                public string StatusName { get; set; }

            }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }

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
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RowCount")]
            [Validation(Required=false)]
            public int? RowCount { get; set; }

        }

        /// <summary>
        /// <para>The tag information that can be used as filter criteria.</para>
        /// <remarks>
        /// <para>Displays information for all tags in the job group that have enumerated values.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<QueryJobsWithResultResponseBodyLabels> Labels { get; set; }
        public class QueryJobsWithResultResponseBodyLabels : TeaModel {
            /// <summary>
            /// <para>Tag Name</para>
            /// 
            /// <b>Example:</b>
            /// <para>是否满意</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Tag value list.</para>
            /// </summary>
            [NameInMap("ValueList")]
            [Validation(Required=false)]
            public List<string> ValueList { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9bdaa1d1-a036-4451-ab11-ca0373679091</para>
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

        /// <summary>
        /// <para>The names of tags to be collected.</para>
        /// </summary>
        [NameInMap("VariableNames")]
        [Validation(Required=false)]
        public List<string> VariableNames { get; set; }

    }

}
