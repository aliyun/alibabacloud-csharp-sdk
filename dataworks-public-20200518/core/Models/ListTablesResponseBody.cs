// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListTablesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTablesResponseBodyData Data { get; set; }
        public class ListTablesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>AAAAAVY3rYiv9VoUJQSiCitgjgSwg+byk0FIjirFkm4zfM4G0xYwM/FQvOhgrTHsCPIZ5yqXYu2NG6qRCRC52HvwbOA=</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("TableEntityList")]
            [Validation(Required=false)]
            public List<ListTablesResponseBodyDataTableEntityList> TableEntityList { get; set; }
            public class ListTablesResponseBodyDataTableEntityList : TeaModel {
                [NameInMap("EntityContent")]
                [Validation(Required=false)]
                public ListTablesResponseBodyDataTableEntityListEntityContent EntityContent { get; set; }
                public class ListTablesResponseBodyDataTableEntityListEntityContent : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>accountId:cn-shanghai:odps:project</para>
                    /// </summary>
                    [NameInMap("DataSourceQualifiedName")]
                    [Validation(Required=false)]
                    public string DataSourceQualifiedName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>e70f92239d491057f6a2563b545bdaf8cc6b537d9dc55ec84c55f7cfefg</para>
                    /// </summary>
                    [NameInMap("DataSourceUniqueId")]
                    [Validation(Required=false)]
                    public string DataSourceUniqueId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>database</para>
                    /// </summary>
                    [NameInMap("DatabaseName")]
                    [Validation(Required=false)]
                    public string DatabaseName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>rm-uf6rn0123</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>project</para>
                    /// </summary>
                    [NameInMap("ProjectName")]
                    [Validation(Required=false)]
                    public string ProjectName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>table</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>maxcompute-table.project.table</para>
                /// </summary>
                [NameInMap("EntityQualifiedName")]
                [Validation(Required=false)]
                public string EntityQualifiedName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E25887B7-579C-54A5-9C4F-83A0DE367DD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
