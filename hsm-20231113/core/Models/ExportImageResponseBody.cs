// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hsm20231113.Models
{
    public class ExportImageResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the asynchronous task returned.</para>
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public ExportImageResponseBodyJob Job { get; set; }
        public class ExportImageResponseBodyJob : TeaModel {
            /// <summary>
            /// <para>Indicates whether the task is complete. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Completed")]
            [Validation(Required=false)]
            public bool? Completed { get; set; }

            /// <summary>
            /// <para>The error message returned if the operation is abnormal or fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Job.Canceled</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b1748ca6-6b55-49f4-a6d4-2d694a9f3693</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The progress of the task. Unit: percent (%).</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Process")]
            [Validation(Required=false)]
            public int? Process { get; set; }

            /// <summary>
            /// <para>The response returned after the operation succeeds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Response")]
            [Validation(Required=false)]
            public string Response { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>running</description></item>
            /// <item><description>cancel</description></item>
            /// <item><description>fail</description></item>
            /// <item><description>success</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the task operation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>create</description></item>
            /// <item><description>cancel</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>create</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C467B38-3910-447D-87BC-AC049166F216</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
