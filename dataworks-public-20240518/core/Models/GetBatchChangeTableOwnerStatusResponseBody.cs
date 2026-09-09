// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetBatchChangeTableOwnerStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The execution status of the batch table owner transfer task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBatchChangeTableOwnerStatusResponseBodyData Data { get; set; }
        public class GetBatchChangeTableOwnerStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The batch transfer task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>524257_openapi-req-abc123</para>
            /// </summary>
            [NameInMap("BatchId")]
            [Validation(Required=false)]
            public string BatchId { get; set; }

            /// <summary>
            /// <para>The transfer result details for each table.</para>
            /// </summary>
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<GetBatchChangeTableOwnerStatusResponseBodyDataDetails> Details { get; set; }
            public class GetBatchChangeTableOwnerStatusResponseBodyDataDetails : TeaModel {
                /// <summary>
                /// <para>The error message returned when the table transfer fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Forbidden: You are not a member of this project</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The transfer status of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metadata entity ID of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>maxcompute-table:123:project_a::table_1</para>
                /// </summary>
                [NameInMap("TableMetaEntityId")]
                [Validation(Required=false)]
                public string TableMetaEntityId { get; set; }

            }

            /// <summary>
            /// <para>The number of tables that failed to transfer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FailedCount")]
            [Validation(Required=false)]
            public int? FailedCount { get; set; }

            /// <summary>
            /// <para>The number of tables that are still being processed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("OngoingCount")]
            [Validation(Required=false)]
            public int? OngoingCount { get; set; }

            /// <summary>
            /// <para>The overall status of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The number of tables that were successfully transferred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

            /// <summary>
            /// <para>The total number of tables in the batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A017D3-207E-582C-A683-BE991E54051D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
