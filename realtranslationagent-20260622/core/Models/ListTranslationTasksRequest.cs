// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RealTranslationAgent20260622.Models
{
    public class ListTranslationTasksRequest : TeaModel {
        /// <summary>
        /// <para>The API key that identifies the identity of member accounts. You can obtain it from the RuiYiBao console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-1***s</para>
        /// </summary>
        [NameInMap("APIKey")]
        [Validation(Required=false)]
        public string APIKey { get; set; }

        /// <summary>
        /// <para>The end time of the task.</para>
        /// <list type="bullet">
        /// <item><description>Format: YYYY-MM-dd HH:mm:ss.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2026-06-27 00:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return per request when using the NextToken-based pagination.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6lkCoZlXVoygoU1omMcKBVc</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The name of the source file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>translated_a_file.pptx</para>
        /// </summary>
        [NameInMap("OriginalFileName")]
        [Validation(Required=false)]
        public string OriginalFileName { get; set; }

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
        /// <para>The start time of the task.</para>
        /// <list type="bullet">
        /// <item><description>Format: YYYY-MM-dd HH:mm:ss.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2026-06-26 00:00:00</para>
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
        /// <para>PROCESSING</para>
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
        /// <para>The translation task ID, which is the TaskId obtained from UploadTranslationFile.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f9c35b0453b</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
