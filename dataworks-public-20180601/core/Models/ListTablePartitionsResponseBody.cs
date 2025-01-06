// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20180601.Models
{
    public class ListTablePartitionsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTablePartitionsResponseBodyData Data { get; set; }
        public class ListTablePartitionsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("PagedData")]
            [Validation(Required=false)]
            public List<ListTablePartitionsResponseBodyDataPagedData> PagedData { get; set; }
            public class ListTablePartitionsResponseBodyDataPagedData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1568032253000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1568032253000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hdfs://emr-header-1.cluster-136574:9000/user/hive/warehouse/pt_table_090901_emr_child/ds=20190909/hr=20/region=shanghai</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("PartitionComment")]
                [Validation(Required=false)]
                public string PartitionComment { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ds=20190909/hr=20/region=shanghai</para>
                /// </summary>
                [NameInMap("PartitionName")]
                [Validation(Required=false)]
                public string PartitionName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hdfs://emr-header-1.cluster-136574:9000/user/hive/warehouse/pt_table_090901_emr_child/ds=20190909/hr=20/region=shanghai</para>
                /// </summary>
                [NameInMap("PartitionPath")]
                [Validation(Required=false)]
                public string PartitionPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HIVE</para>
                /// </summary>
                [NameInMap("PartitionType")]
                [Validation(Required=false)]
                public string PartitionType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UUID</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
