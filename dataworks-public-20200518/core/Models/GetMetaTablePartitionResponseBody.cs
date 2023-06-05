// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTablePartitionResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned per page. Default value: 10. Maximum value: 100.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMetaTablePartitionResponseBodyData Data { get; set; }
        public class GetMetaTablePartitionResponseBodyData : TeaModel {
            /// <summary>
            /// The size of the partition. Unit: bytes.
            /// </summary>
            [NameInMap("DataEntityList")]
            [Validation(Required=false)]
            public List<GetMetaTablePartitionResponseBodyDataDataEntityList> DataEntityList { get; set; }
            public class GetMetaTablePartitionResponseBodyDataDataEntityList : TeaModel {
                /// <summary>
                /// The time when the partition was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// The type of the partition.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The comment.
                /// </summary>
                [NameInMap("DataSize")]
                [Validation(Required=false)]
                public long? DataSize { get; set; }

                /// <summary>
                /// The number of entries in the partition.
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public long? ModifiedTime { get; set; }

                /// <summary>
                /// The GUID of the metatable.
                /// </summary>
                [NameInMap("PartitionGuid")]
                [Validation(Required=false)]
                public string PartitionGuid { get; set; }

                [NameInMap("PartitionLocation")]
                [Validation(Required=false)]
                public string PartitionLocation { get; set; }

                /// <summary>
                /// The time when the partition was modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("PartitionName")]
                [Validation(Required=false)]
                public string PartitionName { get; set; }

                /// <summary>
                /// The name of the partition.
                /// </summary>
                [NameInMap("PartitionPath")]
                [Validation(Required=false)]
                public string PartitionPath { get; set; }

                /// <summary>
                /// The location of the Hive partition.
                /// </summary>
                [NameInMap("PartitionType")]
                [Validation(Required=false)]
                public string PartitionType { get; set; }

                /// <summary>
                /// The GUID of the partition.
                /// </summary>
                [NameInMap("RecordCount")]
                [Validation(Required=false)]
                public long? RecordCount { get; set; }

                [NameInMap("TableGuid")]
                [Validation(Required=false)]
                public string TableGuid { get; set; }

            }

            /// <summary>
            /// The total number of partitions.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The list of partitions.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The path of the partition.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The business data returned.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
