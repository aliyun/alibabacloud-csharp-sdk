// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetLogicDatabaseResponseBody : TeaModel {
        /// <summary>
        /// The status code.
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
        /// The details of the logical database.
        /// </summary>
        [NameInMap("LogicDatabase")]
        [Validation(Required=false)]
        public GetLogicDatabaseResponseBodyLogicDatabase LogicDatabase { get; set; }
        public class GetLogicDatabaseResponseBodyLogicDatabase : TeaModel {
            /// <summary>
            /// The alias of the logical database.
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// The ID of the logical database.
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

            /// <summary>
            /// The IDs of database shards of the logical database.
            /// </summary>
            [NameInMap("DatabaseIds")]
            [Validation(Required=false)]
            public GetLogicDatabaseResponseBodyLogicDatabaseDatabaseIds DatabaseIds { get; set; }
            public class GetLogicDatabaseResponseBodyLogicDatabaseDatabaseIds : TeaModel {
                [NameInMap("DatabaseIds")]
                [Validation(Required=false)]
                public List<long?> DatabaseIds { get; set; }

            }

            /// <summary>
            /// The database engine. For more information about the valid values of the DbType parameter, see [DbType parameter](~~198106~~).
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// The type of the environment to which the database belongs. Valid values:
            /// 
            /// *   product: production environment
            /// *   dev: development environment
            /// *   pre: pre-release environment
            /// *   test: test environment
            /// *   sit: system integration testing (SIT) environment
            /// *   uat: user acceptance testing (UAT) environment
            /// *   pet: stress testing environment
            /// *   stag: staging environment
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// Indicates whether the database is a logical database. The return value is true.
            /// </summary>
            [NameInMap("Logic")]
            [Validation(Required=false)]
            public bool? Logic { get; set; }

            /// <summary>
            /// The IDs of the owners of the logical database.
            /// </summary>
            [NameInMap("OwnerIdList")]
            [Validation(Required=false)]
            public GetLogicDatabaseResponseBodyLogicDatabaseOwnerIdList OwnerIdList { get; set; }
            public class GetLogicDatabaseResponseBodyLogicDatabaseOwnerIdList : TeaModel {
                [NameInMap("OwnerIds")]
                [Validation(Required=false)]
                public List<string> OwnerIds { get; set; }

            }

            /// <summary>
            /// The names of the owners of the logical database.
            /// </summary>
            [NameInMap("OwnerNameList")]
            [Validation(Required=false)]
            public GetLogicDatabaseResponseBodyLogicDatabaseOwnerNameList OwnerNameList { get; set; }
            public class GetLogicDatabaseResponseBodyLogicDatabaseOwnerNameList : TeaModel {
                [NameInMap("OwnerNames")]
                [Validation(Required=false)]
                public List<string> OwnerNames { get; set; }

            }

            /// <summary>
            /// The name of the logical database.
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// The name that is used to search for the logical database.
            /// </summary>
            [NameInMap("SearchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true: The request was successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
