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

        [NameInMap("LogicDatabaseList")]
        [Validation(Required=false)]
        public ListLogicDatabasesResponseBodyLogicDatabaseList LogicDatabaseList { get; set; }
        public class ListLogicDatabasesResponseBodyLogicDatabaseList : TeaModel {
            [NameInMap("LogicDatabase")]
            [Validation(Required=false)]
            public List<ListLogicDatabasesResponseBodyLogicDatabaseListLogicDatabase> LogicDatabase { get; set; }
            public class ListLogicDatabasesResponseBodyLogicDatabaseListLogicDatabase : TeaModel {
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                [NameInMap("DatabaseId")]
                [Validation(Required=false)]
                public string DatabaseId { get; set; }

                [NameInMap("DatabaseIds")]
                [Validation(Required=false)]
                public ListLogicDatabasesResponseBodyLogicDatabaseListLogicDatabaseDatabaseIds DatabaseIds { get; set; }
                public class ListLogicDatabasesResponseBodyLogicDatabaseListLogicDatabaseDatabaseIds : TeaModel {
                    [NameInMap("DatabaseIds")]
                    [Validation(Required=false)]
                    public List<long?> DatabaseIds { get; set; }

                }

                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                [NameInMap("OwnerIdList")]
                [Validation(Required=false)]
                public ListLogicDatabasesResponseBodyLogicDatabaseListLogicDatabaseOwnerIdList OwnerIdList { get; set; }
                public class ListLogicDatabasesResponseBodyLogicDatabaseListLogicDatabaseOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }

                [NameInMap("OwnerNameList")]
                [Validation(Required=false)]
                public ListLogicDatabasesResponseBodyLogicDatabaseListLogicDatabaseOwnerNameList OwnerNameList { get; set; }
                public class ListLogicDatabasesResponseBodyLogicDatabaseListLogicDatabaseOwnerNameList : TeaModel {
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                }

                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

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
