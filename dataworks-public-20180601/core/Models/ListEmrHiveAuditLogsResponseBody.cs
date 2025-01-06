// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20180601.Models
{
    public class ListEmrHiveAuditLogsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListEmrHiveAuditLogsResponseBodyData Data { get; set; }
        public class ListEmrHiveAuditLogsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("PagedData")]
            [Validation(Required=false)]
            public List<ListEmrHiveAuditLogsResponseBodyDataPagedData> PagedData { get; set; }
            public class ListEmrHiveAuditLogsResponseBodyDataPagedData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1564019679506</para>
                /// </summary>
                [NameInMap("EventTime")]
                [Validation(Required=false)]
                public long? EventTime { get; set; }

                [NameInMap("Groups")]
                [Validation(Required=false)]
                public List<string> Groups { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CREATE_TABLE</para>
                /// </summary>
                [NameInMap("Operation")]
                [Validation(Required=false)]
                public string Operation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_table</para>
                /// </summary>
                [NameInMap("Table")]
                [Validation(Required=false)]
                public string Table { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
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
        /// <para>58D5334A-B013-430E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
