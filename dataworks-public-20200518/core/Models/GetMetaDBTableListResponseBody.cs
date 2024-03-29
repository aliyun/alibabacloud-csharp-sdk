// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaDBTableListResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned per page. Default value: 10. Maximum value: 100.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMetaDBTableListResponseBodyData Data { get; set; }
        public class GetMetaDBTableListResponseBodyData : TeaModel {
            /// <summary>
            /// The total number of compute engine instances.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The list of metatables in the compute engine instance.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The GUID of the metatable.
            /// </summary>
            [NameInMap("TableEntityList")]
            [Validation(Required=false)]
            public List<GetMetaDBTableListResponseBodyDataTableEntityList> TableEntityList { get; set; }
            public class GetMetaDBTableListResponseBodyDataTableEntityList : TeaModel {
                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                [NameInMap("TableGuid")]
                [Validation(Required=false)]
                public string TableGuid { get; set; }

                /// <summary>
                /// The name of the metadatabase.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            /// <summary>
            /// The name of the metatable.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
