// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListQualityRuleTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
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
        /// <para>The error details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The paged query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListQualityRuleTasksResponseBodyPageResult PageResult { get; set; }
        public class ListQualityRuleTasksResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The list of quality rule tasks.</para>
            /// </summary>
            [NameInMap("QualityRuleTaskList")]
            [Validation(Required=false)]
            public List<ListQualityRuleTasksResponseBodyPageResultQualityRuleTaskList> QualityRuleTaskList { get; set; }
            public class ListQualityRuleTasksResponseBodyPageResultQualityRuleTaskList : TeaModel {
                /// <summary>
                /// <para>The business date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30</para>
                /// </summary>
                [NameInMap("BizDate")]
                [Validation(Required=false)]
                public string BizDate { get; set; }

                /// <summary>
                /// <para>The business date format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd</para>
                /// </summary>
                [NameInMap("BizDateFormat")]
                [Validation(Required=false)]
                public string BizDateFormat { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The ID of the rule task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The ID of the user who last modified the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                /// <summary>
                /// <para>The start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The task status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

                /// <summary>
                /// <para>The name of the validated object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ValidateObjectName")]
                [Validation(Required=false)]
                public string ValidateObjectName { get; set; }

                /// <summary>
                /// <para>The object type of the validated object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>column</para>
                /// </summary>
                [NameInMap("ValidateObjectType")]
                [Validation(Required=false)]
                public string ValidateObjectType { get; set; }

                /// <summary>
                /// <para>The validation partition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20251011</para>
                /// </summary>
                [NameInMap("ValidatePartition")]
                [Validation(Required=false)]
                public string ValidatePartition { get; set; }

                /// <summary>
                /// <para>Indicates whether the validation passed.</para>
                /// </summary>
                [NameInMap("ValidateSuccess")]
                [Validation(Required=false)]
                public bool? ValidateSuccess { get; set; }

                /// <summary>
                /// <para>The ID of the associated quality watchtask.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("WatchId")]
                [Validation(Required=false)]
                public long? WatchId { get; set; }

                /// <summary>
                /// <para>The ID of the quality watchtask. This ID is empty for trial-run rule tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("WatchTaskId")]
                [Validation(Required=false)]
                public long? WatchTaskId { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>68</para>
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
