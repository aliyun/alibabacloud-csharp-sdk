// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListLogicDatabasesResponseBody : TeaModel {
        /// <summary>
        /// The error code that is returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message that is returned.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The details of logical databases.
        /// </summary>
        [NameInMap("LogicDatabaseList")]
        [Validation(Required=false)]
        public ListLogicDatabasesResponseBodyLogicDatabaseList LogicDatabaseList { get; set; }
        public class ListLogicDatabasesResponseBodyLogicDatabaseList : TeaModel {
            [NameInMap("LogicDatabase")]
            [Validation(Required=false)]
            public List<ListLogicDatabasesResponseBodyLogicDatabaseListLogicDatabase> LogicDatabase { get; set; }
            public class ListLogicDatabasesResponseBodyLogicDatabaseListLogicDatabase : TeaModel {
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
                /// Logical database sub-ID list.
                /// </summary>
                [NameInMap("DatabaseIds")]
                [Validation(Required=false)]
                public ListLogicDatabasesResponseBodyLogicDatabaseListLogicDatabaseDatabaseIds DatabaseIds { get; set; }
                public class ListLogicDatabasesResponseBodyLogicDatabaseListLogicDatabaseDatabaseIds : TeaModel {
                    [NameInMap("DatabaseIds")]
                    [Validation(Required=false)]
                    public List<long?> DatabaseIds { get; set; }

                }

                /// <summary>
                /// The type of the logical database. For more information about the valid values of this parameter, see [DbType parameter](https://www.alibabacloud.com/help/en/data-management-service/latest/dbtype-parameter).
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// The type of the environment to which the logical database belongs. Valid values:
                /// 
                /// - **product**: production environment
                /// - **dev**: development environment
                /// - **pre**: staging environment
                /// - **test**: test environment
                /// - **sit**: system integration testing (SIT) environment
                /// - **uat**: user acceptance testing (UAT) environment
                /// - **pet**: stress testing environment
                /// - **stag**: STAG environment
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
                public ListLogicDatabasesResponseBodyLogicDatabaseListLogicDatabaseOwnerIdList OwnerIdList { get; set; }
                public class ListLogicDatabasesResponseBodyLogicDatabaseListLogicDatabaseOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }

                /// <summary>
                /// The names of the owners of the logical database.
                /// </summary>
                [NameInMap("OwnerNameList")]
                [Validation(Required=false)]
                public ListLogicDatabasesResponseBodyLogicDatabaseListLogicDatabaseOwnerNameList OwnerNameList { get; set; }
                public class ListLogicDatabasesResponseBodyLogicDatabaseListLogicDatabaseOwnerNameList : TeaModel {
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
                /// 
                /// > We recommend that you do not use this parameter for business development. The format of the parameter value may be modified in later versions.
                /// </summary>
                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// - **true**: The request is successful.
        /// - **false**: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of logical databases.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
