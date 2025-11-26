// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SearchTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<SearchTaskResponseBodyLabels> Labels { get; set; }
        public class SearchTaskResponseBodyLabels : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ValueList")]
            [Validation(Required=false)]
            public List<string> ValueList { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("SearchTaskInfoList")]
        [Validation(Required=false)]
        public List<SearchTaskResponseBodySearchTaskInfoList> SearchTaskInfoList { get; set; }
        public class SearchTaskResponseBodySearchTaskInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1643436089677</para>
            /// </summary>
            [NameInMap("ActualTime")]
            [Validation(Required=false)]
            public long? ActualTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1646792941</para>
            /// </summary>
            [NameInMap("CallDuration")]
            [Validation(Required=false)]
            public int? CallDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ActualTime</para>
            /// </summary>
            [NameInMap("CallDurationDisplay")]
            [Validation(Required=false)]
            public string CallDurationDisplay { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>15205879599</para>
            /// </summary>
            [NameInMap("CalledNumber")]
            [Validation(Required=false)]
            public string CalledNumber { get; set; }

            [NameInMap("CallingNumber")]
            [Validation(Required=false)]
            public string CallingNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[{&quot;code&quot;:&quot;OutboundCallError.SipCodeError&quot;, &quot;params&quot;:[{&quot;key&quot;:&quot;SipCode&quot;,&quot;value&quot;:&quot;500&quot;}]}]</para>
            /// </summary>
            [NameInMap("DialException")]
            [Validation(Required=false)]
            public string DialException { get; set; }

            [NameInMap("DialExceptionCodes")]
            [Validation(Required=false)]
            public List<string> DialExceptionCodes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;OutboundCallError.SipTrunkError&quot;]</para>
            /// </summary>
            [NameInMap("DialExceptionOld")]
            [Validation(Required=false)]
            public string DialExceptionOld { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasAnswered")]
            [Validation(Required=false)]
            public bool? HasAnswered { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasHangUpByRejection")]
            [Validation(Required=false)]
            public bool? HasHangUpByRejection { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasLastPlaybackCompleted")]
            [Validation(Required=false)]
            public bool? HasLastPlaybackCompleted { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasReachedEndOfFlow")]
            [Validation(Required=false)]
            public bool? HasReachedEndOfFlow { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>73df6283-26b2-402d-bad0-ffa489923ea1</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>37db3113-ad34-4ba3-b930-468f016bbf95</para>
            /// </summary>
            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

            [NameInMap("JobGroupName")]
            [Validation(Required=false)]
            public string JobGroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6203248e-e652-4ef8-a1eb-586ed7b54dc2</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Succeeded</para>
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public int? JobStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("JobStatusName")]
            [Validation(Required=false)]
            public string JobStatusName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Scheduling</para>
            /// </summary>
            [NameInMap("JobStatusString")]
            [Validation(Required=false)]
            public string JobStatusString { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<SearchTaskResponseBodySearchTaskInfoListLabels> Labels { get; set; }
            public class SearchTaskResponseBodySearchTaskInfoListLabels : TeaModel {
                [NameInMap("K")]
                [Validation(Required=false)]
                public string K { get; set; }

                [NameInMap("V")]
                [Validation(Required=false)]
                public string V { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RecordingDuration")]
            [Validation(Required=false)]
            public int? RecordingDuration { get; set; }

            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1646792941</para>
            /// </summary>
            [NameInMap("TaskCreateTime")]
            [Validation(Required=false)]
            public long? TaskCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OutOfService</para>
            /// </summary>
            [NameInMap("TaskEndReason")]
            [Validation(Required=false)]
            public int? TaskEndReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>479aea04-3a92-4ac3-935d-c8798c667850</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("TaskStatusName")]
            [Validation(Required=false)]
            public string TaskStatusName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Executing</para>
            /// </summary>
            [NameInMap("TaskStatusString")]
            [Validation(Required=false)]
            public string TaskStatusString { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12334134</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("VariableNames")]
        [Validation(Required=false)]
        public List<string> VariableNames { get; set; }

    }

}
