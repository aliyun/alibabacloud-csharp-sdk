// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDagsResponseBody : TeaModel {
        /// <summary>
        /// The details of DAGs.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDagsResponseBodyData Data { get; set; }
        public class ListDagsResponseBodyData : TeaModel {
            /// <summary>
            /// The entities returned.
            /// </summary>
            [NameInMap("Dags")]
            [Validation(Required=false)]
            public List<ListDagsResponseBodyDataDags> Dags { get; set; }
            public class ListDagsResponseBodyDataDags : TeaModel {
                /// <summary>
                /// The data timestamp.
                /// </summary>
                [NameInMap("Bizdate")]
                [Validation(Required=false)]
                public long? Bizdate { get; set; }

                /// <summary>
                /// The creation time.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The creator.
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// The DAG ID.
                /// </summary>
                [NameInMap("DagId")]
                [Validation(Required=false)]
                public long? DagId { get; set; }

                /// <summary>
                /// The end time.
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// The actual running time.
                /// </summary>
                [NameInMap("Gmtdate")]
                [Validation(Required=false)]
                public long? Gmtdate { get; set; }

                /// <summary>
                /// The modification time.
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// The name of the DAG.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The sequence number of the operation.
                /// </summary>
                [NameInMap("OpSeq")]
                [Validation(Required=false)]
                public long? OpSeq { get; set; }

                /// <summary>
                /// The workspace ID.
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// The start time.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// The status of the DAG. Valid values:
                /// 
                /// *   CREATED
                /// *   RUNNING
                /// *   FAILURE
                /// *   SUCCESS
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The type of the DAG. Valid values:
                /// 
                /// *   MANUAL: DAG for a manually triggered workflow
                /// *   SMOKE_TEST: DAG for a smoke testing workflow
                /// *   SUPPLY_DATA: DAG for a data backfill instance
                /// *   BUSINESS_PROCESS_DAG: DAG for a one-time workflow
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The request ID. You can use the ID to locate logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
