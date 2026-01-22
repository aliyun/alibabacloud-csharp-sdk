// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class DescribeJobResultsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0_1</para>
        /// </summary>
        [NameInMap("ArrayIndex")]
        [Validation(Required=false)]
        public int? ArrayIndex { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PlainText</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>job-xxxxxxx</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1048576</para>
        /// </summary>
        [NameInMap("LimitBytes")]
        [Validation(Required=false)]
        public string LimitBytes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-09-02T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Task0</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
