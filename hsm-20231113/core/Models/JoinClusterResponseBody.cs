// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hsm20231113.Models
{
    public class JoinClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the task.</para>
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public JoinClusterResponseBodyJob Job { get; set; }
        public class JoinClusterResponseBodyJob : TeaModel {
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
            /// <para>The time when the task was created. Unit: milliseconds. The value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1711764127000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error message returned if the task fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OperationTimeout</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-202401250936hze747fd7e0007005</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The progress of the task. Unit: percent (%).</para>
            /// 
            /// <b>Example:</b>
            /// <para>86</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <para>The response returned after the task succeeds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Response")]
            [Validation(Required=false)]
            public string Response { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>success</description></item>
            /// <item><description>running</description></item>
            /// <item><description>cancel</description></item>
            /// <item><description>fail</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The operation type. Valid values:</para>
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
