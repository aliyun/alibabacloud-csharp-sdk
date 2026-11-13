// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class QueryJobsWithResultResponseBody : TeaModel {
        /// <summary>
        /// <para>Code</para>
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
        /// <para>The jobs.</para>
        /// </summary>
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public QueryJobsWithResultResponseBodyJobs Jobs { get; set; }
        public class QueryJobsWithResultResponseBodyJobs : TeaModel {
            /// <summary>
            /// <para>The list of jobs.</para>
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
                /// <para>The reason for the job failure.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description>Unknown: Unknown error.</description></item>
                /// <item><description>NoAnswer: No answer.</description></item>
                /// <item><description>InvalidStrategy: Invalid strategy or incorrect strategy configuration.</description></item>
                /// <item><description>TimeUp: Timeout during scheduling.</description></item>
                /// <item><description>NoStrategy: Strategy is empty or not found.</description></item>
                /// <item><description>CallFailed: Call failed.</description></item>
                /// <item><description>PerDayCallCountLimit: Daily call count limit for the phone number reached.</description></item>
                /// <item><description>ContactBlockList: Contact is on the outbound call blacklist.</description></item>
                /// <item><description>EmptyNumber: Nonexistent number, no further outbound calls.</description></item>
                /// <item><description>JobPerDayCallCountLimit: Daily call count limit for the phone number reached.</description></item>
                /// <item><description>VerificationCancelled: Canceled due to pre-call verification failure.</description></item>
                /// <item><description>ContactSuspended: Call suspended.</description></item>
                /// <item><description>InArrears: Overdue payment.</description></item>
                /// <item><description>OutOfService: Service suspended.</description></item>
                /// <item><description>NoneRepeatableJobMaxAttemptCountLimit: Maximum retry count for the job reached. This takes effect when RepeatBy is set to None</description></item>
                /// </list>
                /// </summary>
                [NameInMap("JobFailureReason")]
                [Validation(Required=false)]
                public string JobFailureReason { get; set; }

                /// <summary>
                /// <para>The latest call.</para>
                /// </summary>
                [NameInMap("LatestTask")]
                [Validation(Required=false)]
                public QueryJobsWithResultResponseBodyJobsListLatestTask LatestTask { get; set; }
                public class QueryJobsWithResultResponseBodyJobsListLatestTask : TeaModel {
                    /// <summary>
                    /// <para>The call duration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>40000</para>
                    /// </summary>
                    [NameInMap("CallDuration")]
                    [Validation(Required=false)]
                    public int? CallDuration { get; set; }

                    /// <summary>
                    /// <para>The call duration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>40</para>
                    /// </summary>
                    [NameInMap("CallDurationDisplay")]
                    [Validation(Required=false)]
                    public string CallDurationDisplay { get; set; }

                    /// <summary>
                    /// <para>The call time. The value is a UNIX timestamp in milliseconds.</para>
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
                        /// <para>The honorific of the contact. If this field is not specified, the default value is the same as the name.</para>
                        /// <remarks>
                        /// <para>This is a custom field. You can pass it in JSON format when you call the API operation to execute the outbound call task.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Mr. Zhang</para>
                        /// </summary>
                        [NameInMap("Honorific")]
                        [Validation(Required=false)]
                        public string Honorific { get; set; }

                        /// <summary>
                        /// <para>The contact ID. A unique identifier generated by the system when the outbound call list is uploaded.</para>
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
                        /// <para>The name of the contact, such as Zhang San.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Zhang San</para>
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
                        /// <para>The phone number specified by the callee during the conversation. If this field is specified, the system calls this number.</para>
                        /// <remarks>
                        /// <para>This is a custom field. You can pass it in JSON format when you call the API operation to execute the outbound call task.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>134123****</para>
                        /// </summary>
                        [NameInMap("PreferredPhoneNumber")]
                        [Validation(Required=false)]
                        public string PreferredPhoneNumber { get; set; }

                        /// <summary>
                        /// <para>The custom contact ID uploaded by the customer. This ID must be provided by the business side to avoid duplicate names.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>C01</para>
                        /// </summary>
                        [NameInMap("ReferenceId")]
                        [Validation(Required=false)]
                        public string ReferenceId { get; set; }

                        /// <summary>
                        /// <para>The role of the contact in the outbound call business. If this field is not specified, roles are not distinguished. For example, in debt collection scenarios, contact roles can be borrower, co-borrower, or guarantor.</para>
                        /// <remarks>
                        /// <para>This is a custom field. You can pass it in JSON format when you call the API operation.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Borrower</para>
                        /// </summary>
                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        /// <summary>
                        /// <para>The conversation round.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>151</para>
                        /// </summary>
                        [NameInMap("Round")]
                        [Validation(Required=false)]
                        public int? Round { get; set; }

                        /// <summary>
                        /// <para>The status of the contact. Valid values: Available, WrongNumber, and DoesNotExist.</para>
                        /// <remarks>
                        /// <para>This is a custom field. You can pass it in JSON format when you call the API operation to execute the outbound call task.</para>
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
                    /// <para>The call exception codes.</para>
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
                        /// <para>The error message.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>None</para>
                        /// </summary>
                        [NameInMap("Hint")]
                        [Validation(Required=false)]
                        public string Hint { get; set; }

                    }

                    /// <summary>
                    /// <para>The names of the tags to be collected.</para>
                    /// </summary>
                    [NameInMap("Extras")]
                    [Validation(Required=false)]
                    public List<QueryJobsWithResultResponseBodyJobsListLatestTaskExtras> Extras { get; set; }
                    public class QueryJobsWithResultResponseBodyJobsListLatestTaskExtras : TeaModel {
                        /// <summary>
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Whether the call is connected</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Yes</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The party that hung up the call.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Callee</para>
                    /// </summary>
                    [NameInMap("HangUpDirection")]
                    [Validation(Required=false)]
                    public string HangUpDirection { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the call is answered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("HasAnswered")]
                    [Validation(Required=false)]
                    public bool? HasAnswered { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the call is hung up due to unrecognized intent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("HasHangUpByRejection")]
                    [Validation(Required=false)]
                    public bool? HasHangUpByRejection { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the playback is completed when the call is hung up.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("HasLastPlaybackCompleted")]
                    [Validation(Required=false)]
                    public bool? HasLastPlaybackCompleted { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the call flow is completed.</para>
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
                    /// <para>Not dialed - Daily limit exceeded</para>
                    /// </summary>
                    [NameInMap("StatusName")]
                    [Validation(Required=false)]
                    public string StatusName { get; set; }

                    /// <summary>
                    /// <para>The tag hit information. This field is returned for the legacy canvas.</para>
                    /// </summary>
                    [NameInMap("TagHits")]
                    [Validation(Required=false)]
                    public List<QueryJobsWithResultResponseBodyJobsListLatestTaskTagHits> TagHits { get; set; }
                    public class QueryJobsWithResultResponseBodyJobsListLatestTaskTagHits : TeaModel {
                        /// <summary>
                        /// <para>The tag group to which the tag belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Animal</para>
                        /// </summary>
                        [NameInMap("TagGroup")]
                        [Validation(Required=false)]
                        public string TagGroup { get; set; }

                        /// <summary>
                        /// <para>The tag name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Kitten,Kitten</para>
                        /// </summary>
                        [NameInMap("TagName")]
                        [Validation(Required=false)]
                        public string TagName { get; set; }

                    }

                    /// <summary>
                    /// <para>The call result.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FINISHED</para>
                    /// </summary>
                    [NameInMap("TaskEndReason")]
                    [Validation(Required=false)]
                    public string TaskEndReason { get; set; }

                    /// <summary>
                    /// <para>The name of the voice used in this call.</para>
                    /// </summary>
                    [NameInMap("VoiceName")]
                    [Validation(Required=false)]
                    public string VoiceName { get; set; }

                }

                /// <summary>
                /// <para>The job status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Scheduling (0): Scheduling.</description></item>
                /// <item><description>Executing (1): Executing.</description></item>
                /// <item><description>Succeeded (2): Completed and reached.</description></item>
                /// <item><description>Paused (3): Paused.</description></item>
                /// <item><description>Failed (4): Completed but not reached.</description></item>
                /// <item><description>Cancelled (5): Canceled due to manual intervention.</description></item>
                /// <item><description>Drafted (6): Draft.</description></item>
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
                /// <para>Completed and reached</para>
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
            /// <para>The page size.</para>
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
        /// <para>The tag information that can be used as filter conditions.</para>
        /// <remarks>
        /// <para>This field displays all tag information with enumeration values in the task group.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<QueryJobsWithResultResponseBodyLabels> Labels { get; set; }
        public class QueryJobsWithResultResponseBodyLabels : TeaModel {
            /// <summary>
            /// <para>The tag name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Whether satisfied</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of tag values.</para>
            /// </summary>
            [NameInMap("ValueList")]
            [Validation(Required=false)]
            public List<string> ValueList { get; set; }

        }

        /// <summary>
        /// <para>The message returned by the API.</para>
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
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The names of the tags to be collected.</para>
        /// </summary>
        [NameInMap("VariableNames")]
        [Validation(Required=false)]
        public List<string> VariableNames { get; set; }

    }

}
