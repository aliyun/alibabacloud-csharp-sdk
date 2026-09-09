// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class SubmitBatchChangeTableOwnerResponseBody : TeaModel {
        /// <summary>
        /// <para>The submit result of the batch table ownership transfer task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SubmitBatchChangeTableOwnerResponseBodyData Data { get; set; }
        public class SubmitBatchChangeTableOwnerResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The batch transfer task ID. You can use this ID to call GetBatchChangeTableOwnerStatus to query the task progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>524257_xxxxx</para>
            /// </summary>
            [NameInMap("BatchId")]
            [Validation(Required=false)]
            public string BatchId { get; set; }

            /// <summary>
            /// <para>The initial status of the task after submission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUBMITTED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The total number of tables submitted in this batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>824F80BA-1778-5D8A-BAFF-668A4D9C4CC7</para>
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
