// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class SearchMetaTablesResponseBody : TeaModel {
        /// <summary>
        /// The search results.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchMetaTablesResponseBodyData Data { get; set; }
        public class SearchMetaTablesResponseBodyData : TeaModel {
            /// <summary>
            /// The list of metatables.
            /// </summary>
            [NameInMap("DataEntityList")]
            [Validation(Required=false)]
            public List<SearchMetaTablesResponseBodyDataDataEntityList> DataEntityList { get; set; }
            public class SearchMetaTablesResponseBodyDataDataEntityList : TeaModel {
                /// <summary>
                /// The ID of the EMR cluster.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The name of the metadatabase.
                /// </summary>
                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                /// <summary>
                /// The type of the metatable. Valid values:
                /// 
                /// *   0: table
                /// *   1: view
                /// </summary>
                [NameInMap("EntityType")]
                [Validation(Required=false)]
                public int? EntityType { get; set; }

                /// <summary>
                /// The type of the environment. Valid values:
                /// 
                /// *   1: production environment
                /// *   0: development environment
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public int? EnvType { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account used by the workspace owner.
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// The ID of the workspace.
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// The name of the workspace.
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// The schema information of the table. You must configure this parameter if you enable the three-layer model of MaxCompute.
                /// </summary>
                [NameInMap("Schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

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

                /// <summary>
                /// The tenant ID.
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

            }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of metatables.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

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
        /// The request ID.
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
