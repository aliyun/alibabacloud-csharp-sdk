// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RealTranslationAgent20260622.Models
{
    public class ListTranslationTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTranslationTasksResponseBodyData Data { get; set; }
        public class ListTranslationTasksResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data list.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListTranslationTasksResponseBodyDataList> List { get; set; }
            public class ListTranslationTasksResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The task completion time, in 13-digit timestamp format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1782459562000</para>
                /// </summary>
                [NameInMap("CompleteTime")]
                [Validation(Required=false)]
                public string CompleteTime { get; set; }

                /// <summary>
                /// <para>The credits consumed by this task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>81.2992</para>
                /// </summary>
                [NameInMap("CostCredits")]
                [Validation(Required=false)]
                public double? CostCredits { get; set; }

                /// <summary>
                /// <para>The time consumed, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>196</para>
                /// </summary>
                [NameInMap("CostTime")]
                [Validation(Required=false)]
                public long? CostTime { get; set; }

                /// <summary>
                /// <para>The creator ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acc_93****c936</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The creator name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:tes_account@test.com">tes_account@test.com</a></para>
                /// </summary>
                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                /// <summary>
                /// <para>The error message when the task fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>device offline</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The parsed file format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PPTX</para>
                /// </summary>
                [NameInMap("FileFormat")]
                [Validation(Required=false)]
                public string FileFormat { get; set; }

                /// <summary>
                /// <para>The file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>translated_a_file.pptx</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The task creation time, in 13-digit timestamp format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1782459562000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The organization ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>org_c6******cdc2ce7</para>
                /// </summary>
                [NameInMap("OrgId")]
                [Validation(Required=false)]
                public string OrgId { get; set; }

                /// <summary>
                /// <para>The source file address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>translated_a_file.pptx</para>
                /// </summary>
                [NameInMap("OriginalFileName")]
                [Validation(Required=false)]
                public string OriginalFileName { get; set; }

                /// <summary>
                /// <para>The page count of the uploaded file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>21</para>
                /// </summary>
                [NameInMap("PageCount")]
                [Validation(Required=false)]
                public long? PageCount { get; set; }

                /// <summary>
                /// <para>The task progress.</para>
                /// 
                /// <b>Example:</b>
                /// <para>61</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// <para>The language of the source file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zh</para>
                /// </summary>
                [NameInMap("SourceLanguage")]
                [Validation(Required=false)]
                public string SourceLanguage { get; set; }

                /// <summary>
                /// <para>The task start time, in 13-digit timestamp format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1782459562000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The task status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CANCELLED: Cancelled.</description></item>
                /// <item><description>COMPLETED: Completed.</description></item>
                /// <item><description>FAILED: Failed.</description></item>
                /// <item><description>PROCESSING: Processing.</description></item>
                /// <item><description>PENDING: Pending.</description></item>
                /// <item><description>ANALYZED: Analyzed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CANCELLED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The target language.</para>
                /// 
                /// <b>Example:</b>
                /// <para>en</para>
                /// </summary>
                [NameInMap("TargetLanguage")]
                [Validation(Required=false)]
                public string TargetLanguage { get; set; }

                /// <summary>
                /// <para>The translation task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f9c35b0453b</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The task type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DOCUMENT: document type.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DOCUMENT</para>
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

                /// <summary>
                /// <para>The translation template. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>common: General.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>common</para>
                /// </summary>
                [NameInMap("Template")]
                [Validation(Required=false)]
                public string Template { get; set; }

                /// <summary>
                /// <para>The word count of the uploaded file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1600</para>
                /// </summary>
                [NameInMap("WordCount")]
                [Validation(Required=false)]
                public long? WordCount { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6458351*****0cc5</para>
                /// </summary>
                [NameInMap("WorkSpaceId")]
                [Validation(Required=false)]
                public string WorkSpaceId { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of results returned per request when using the NextToken-based pagination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>Indicates whether a token exists for the next query. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If <b>NextToken</b> is empty, no next query exists.</description></item>
            /// <item><description>If <b>NextToken</b> has a value, the value is the token for the next query.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AAAAAVpfrV4aVmra0dxbtRB74lmSGzegoejeIqxIET/WdX50</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50ABF118-2F9D-51DF-B1FB-1E389817DC47</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
