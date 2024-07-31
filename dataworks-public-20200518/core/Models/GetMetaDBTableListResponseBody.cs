// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaDBTableListResponseBody : TeaModel {
        /// <summary>
        /// The metatable information in a compute engine instance.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMetaDBTableListResponseBodyData Data { get; set; }
        public class GetMetaDBTableListResponseBodyData : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page. Default value: 10. Maximum value: 100.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The list of metatables in the compute engine instance.
            /// </summary>
            [NameInMap("TableEntityList")]
            [Validation(Required=false)]
            public List<GetMetaDBTableListResponseBodyDataTableEntityList> TableEntityList { get; set; }
            public class GetMetaDBTableListResponseBodyDataTableEntityList : TeaModel {
                /// <summary>
                /// The name of the metadatabase.
                /// </summary>
                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                /// <summary>
                /// The GUID of the metatable.
                /// </summary>
                [NameInMap("TableGuid")]
                [Validation(Required=false)]
                public string TableGuid { get; set; }

                /// <summary>
                /// The name of the metatable.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            /// <summary>
            /// The total number of compute engine instances returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
