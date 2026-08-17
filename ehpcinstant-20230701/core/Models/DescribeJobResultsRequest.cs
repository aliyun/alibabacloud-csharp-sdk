// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class DescribeJobResultsRequest : TeaModel {
        /// <summary>
        /// <para>The executor number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0_1</para>
        /// </summary>
        [NameInMap("ArrayIndex")]
        [Validation(Required=false)]
        public int? ArrayIndex { get; set; }

        /// <summary>
        /// <para>The encoding format for the <c>CommandContent</c> and <c>Output</c> fields in the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PlainText: Returns the original script content and output.</para>
        /// </description></item>
        /// <item><description><para>Base64: Returns the Base64-encoded script content and output.</para>
        /// </description></item>
        /// </list>
        /// <para>The default value is Base64.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PlainText</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-xxxxxxx</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The maximum size of the log in bytes. The value must be between 1 and 1,048,576 (1 MB).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1048576</para>
        /// </summary>
        [NameInMap("LimitBytes")]
        [Validation(Required=false)]
        public string LimitBytes { get; set; }

        /// <summary>
        /// <para>The time in UTC, formatted according to RFC 3339.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-09-02T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Task0</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
