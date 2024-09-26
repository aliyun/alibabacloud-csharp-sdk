// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTablePartitionResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMetaTablePartitionResponseBodyData Data { get; set; }
        public class GetMetaTablePartitionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of partitions.</para>
            /// </summary>
            [NameInMap("DataEntityList")]
            [Validation(Required=false)]
            public List<GetMetaTablePartitionResponseBodyDataDataEntityList> DataEntityList { get; set; }
            public class GetMetaTablePartitionResponseBodyDataDataEntityList : TeaModel {
                /// <summary>
                /// <para>The comment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The time when the partition was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1590032868000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The size of the partition. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>19</para>
                /// </summary>
                [NameInMap("DataSize")]
                [Validation(Required=false)]
                public long? DataSize { get; set; }

                /// <summary>
                /// <para>The time when the partition was modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1590032868000</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public long? ModifiedTime { get; set; }

                /// <summary>
                /// <para>The GUID of the partition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps.engine_name.table_name.pt=20170614</para>
                /// </summary>
                [NameInMap("PartitionGuid")]
                [Validation(Required=false)]
                public string PartitionGuid { get; set; }

                /// <summary>
                /// <para>The location of the Hive partition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("PartitionLocation")]
                [Validation(Required=false)]
                public string PartitionLocation { get; set; }

                /// <summary>
                /// <para>The name of the partition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pt=20170614</para>
                /// </summary>
                [NameInMap("PartitionName")]
                [Validation(Required=false)]
                public string PartitionName { get; set; }

                /// <summary>
                /// <para>The path of the partition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("PartitionPath")]
                [Validation(Required=false)]
                public string PartitionPath { get; set; }

                /// <summary>
                /// <para>The type of the partition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("PartitionType")]
                [Validation(Required=false)]
                public string PartitionType { get; set; }

                /// <summary>
                /// <para>The number of entries in the partition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>233</para>
                /// </summary>
                [NameInMap("RecordCount")]
                [Validation(Required=false)]
                public long? RecordCount { get; set; }

                /// <summary>
                /// <para>The unique identifier of the metatable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps.engine_name.table_name</para>
                /// </summary>
                [NameInMap("TableGuid")]
                [Validation(Required=false)]
                public string TableGuid { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of partitions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid.Tenant.ConnectionNotExists</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The connection does not exist.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1ec92159376</para>
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
