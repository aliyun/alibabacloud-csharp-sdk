// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class DescribeJobResultsRequest : TeaModel {
        /// <summary>
        /// <para>The executor index.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ArrayIndex")]
        [Validation(Required=false)]
        public int? ArrayIndex { get; set; }

        /// <summary>
        /// <para>Specifies the encoding method for the CommandContent and Output fields in the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PlainText: Returns the original script content and output.</description></item>
        /// <item><description>Base64: Returns the Base64-encoded script content and output.</description></item>
        /// </list>
        /// <para>Default value: Base64.</para>
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
        /// <para>The limit on the total size of the logs. Unit: bytes. Valid values: 1 to 1048576 (1 MB).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1048576</para>
        /// </summary>
        [NameInMap("LimitBytes")]
        [Validation(Required=false)]
        public string LimitBytes { get; set; }

        /// <summary>
        /// <para>The start time in UTC, in RFC 3339 format.</para>
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
