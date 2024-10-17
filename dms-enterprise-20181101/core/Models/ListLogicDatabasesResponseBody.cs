// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListLogicDatabasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The details of logical databases.</para>
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
                /// <para>The alias of the logical database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>logic_db_alias</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The ID of the logical database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1***</para>
                /// </summary>
                [NameInMap("DatabaseId")]
                [Validation(Required=false)]
                public string DatabaseId { get; set; }

                /// <summary>
                /// <para>Logical database sub-ID list.</para>
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
                /// <para>The type of the logical database. For more information about the valid values of this parameter, see <a href="https://www.alibabacloud.com/help/en/data-management-service/latest/dbtype-parameter">DbType parameter</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>polardb</para>
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// <para>The type of the environment to which the logical database belongs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>product</b>: production environment</description></item>
                /// <item><description><b>dev</b>: development environment</description></item>
                /// <item><description><b>pre</b>: staging environment</description></item>
                /// <item><description><b>test</b>: test environment</description></item>
                /// <item><description><b>sit</b>: system integration testing (SIT) environment</description></item>
                /// <item><description><b>uat</b>: user acceptance testing (UAT) environment</description></item>
                /// <item><description><b>pet</b>: stress testing environment</description></item>
                /// <item><description><b>stag</b>: STAG environment</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// <para>Indicates whether the database is a logical database. The return value is true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// <para>The IDs of the owners of the logical database.</para>
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
                /// <para>The names of the owners of the logical database.</para>
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
                /// <para>The name of the logical database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>logic_db</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The name that is used to search for the logical database.</para>
                /// <remarks>
                /// <para>We recommend that you do not use this parameter for business development. The format of the parameter value may be modified in later versions.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>logic_db[logic_db_alias]</para>
                /// </summary>
                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8068AF82-8A1A-592C-AC2E-6B75338BAB87</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of logical databases.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
