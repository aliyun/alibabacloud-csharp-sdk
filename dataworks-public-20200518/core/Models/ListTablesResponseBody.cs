// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListTablesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTablesResponseBodyData Data { get; set; }
        public class ListTablesResponseBodyData : TeaModel {
            [NameInMap("TableEntityList")]
            [Validation(Required=false)]
            public List<ListTablesResponseBodyDataTableEntityList> TableEntityList { get; set; }
            public class ListTablesResponseBodyDataTableEntityList : TeaModel {
                [NameInMap("EntityContent")]
                [Validation(Required=false)]
                public ListTablesResponseBodyDataTableEntityListEntityContent EntityContent { get; set; }
                public class ListTablesResponseBodyDataTableEntityListEntityContent : TeaModel {
                    [NameInMap("DataSourceQualifiedName")]
                    [Validation(Required=false)]
                    public string DataSourceQualifiedName { get; set; }

                    [NameInMap("DataSourceUniqueId")]
                    [Validation(Required=false)]
                    public string DataSourceUniqueId { get; set; }

                    [NameInMap("DatabaseName")]
                    [Validation(Required=false)]
                    public string DatabaseName { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("ProjectName")]
                    [Validation(Required=false)]
                    public string ProjectName { get; set; }

                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

                [NameInMap("EntityQualifiedName")]
                [Validation(Required=false)]
                public string EntityQualifiedName { get; set; }

            }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
