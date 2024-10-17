// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetLogicDatabaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The details of the logical database.</para>
        /// </summary>
        [NameInMap("LogicDatabase")]
        [Validation(Required=false)]
        public GetLogicDatabaseResponseBodyLogicDatabase LogicDatabase { get; set; }
        public class GetLogicDatabaseResponseBodyLogicDatabase : TeaModel {
            /// <summary>
            /// <para>The alias of the logical database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_logic_alias</para>
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
            /// <para>The IDs of database shards of the logical database.</para>
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
            /// <para>The database engine. For more information about the valid values of the DbType parameter, see <a href="https://help.aliyun.com/document_detail/198106.html">DbType parameter</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POLARDB</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The type of the environment to which the database belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>product: production environment</description></item>
            /// <item><description>dev: development environment</description></item>
            /// <item><description>pre: pre-release environment</description></item>
            /// <item><description>test: test environment</description></item>
            /// <item><description>sit: system integration testing (SIT) environment</description></item>
            /// <item><description>uat: user acceptance testing (UAT) environment</description></item>
            /// <item><description>pet: stress testing environment</description></item>
            /// <item><description>stag: staging environment</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>dev</para>
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
            public GetLogicDatabaseResponseBodyLogicDatabaseOwnerIdList OwnerIdList { get; set; }
            public class GetLogicDatabaseResponseBodyLogicDatabaseOwnerIdList : TeaModel {
                [NameInMap("OwnerIds")]
                [Validation(Required=false)]
                public List<string> OwnerIds { get; set; }

            }

            /// <summary>
            /// <para>The names of the owners of the logical database.</para>
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
            /// <para>The name of the logical database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_logic_db</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The name that is used to search for the logical database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_logic_db[test_logic_alias]</para>
            /// </summary>
            [NameInMap("SearchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90260530-565C-42B9-A6E8-893481FE6AB6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
