// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTableLineageResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the next page has more query results.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMetaTableLineageResponseBodyData Data { get; set; }
        public class GetMetaTableLineageResponseBodyData : TeaModel {
            /// <summary>
            /// The GUID of the metatable.
            /// </summary>
            [NameInMap("DataEntityList")]
            [Validation(Required=false)]
            public List<GetMetaTableLineageResponseBodyDataDataEntityList> DataEntityList { get; set; }
            public class GetMetaTableLineageResponseBodyDataDataEntityList : TeaModel {
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                [NameInMap("TableGuid")]
                [Validation(Required=false)]
                public string TableGuid { get; set; }

                /// <summary>
                /// The time when the metatable was created.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            /// <summary>
            /// The name of the metatable.
            /// </summary>
            [NameInMap("HasNext")]
            [Validation(Required=false)]
            public bool? HasNext { get; set; }

            /// <summary>
            /// The information about the metatable.
            /// </summary>
            [NameInMap("NextPrimaryKey")]
            [Validation(Required=false)]
            public string NextPrimaryKey { get; set; }

        }

        /// <summary>
        /// The paging information.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
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
        /// The error code.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The business data.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
