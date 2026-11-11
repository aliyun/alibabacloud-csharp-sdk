// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class GetUpsertCollectionDataJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the task for uploading vector data.</para>
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public GetUpsertCollectionDataJobResponseBodyJob Job { get; set; }
        public class GetUpsertCollectionDataJobResponseBodyJob : TeaModel {
            /// <summary>
            /// <para>Indicates whether the operation is completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Completed")]
            [Validation(Required=false)]
            public bool? Completed { get; set; }

            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-08 16:52:04.864664</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error message returned when the current operation is abnormal or fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Failed to connect database.</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>231460f8-75dc-405e-a669-0c5204887e91</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The upload progress. The value indicates the number of data records that have been uploaded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1600</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Success: The task is successful.</description></item>
            /// <item><description>Failed: The task fails. You can view the Error field for the cause of the failure.</description></item>
            /// <item><description>Cancelling: The task is being canceled.</description></item>
            /// <item><description>Cancelled: The task is canceled.</description></item>
            /// <item><description>Start: The task is started.</description></item>
            /// <item><description>Running: The task is running.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the task was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-08 16:53:04.864664</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
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
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b>: The operation is successful.</description></item>
        /// <item><description><b>fail</b>: The operation fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
