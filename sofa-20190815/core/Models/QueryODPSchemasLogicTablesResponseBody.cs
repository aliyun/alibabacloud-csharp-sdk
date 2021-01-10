// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryODPSchemasLogicTablesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryODPSchemasLogicTablesResponseBodyData Data { get; set; }
        public class QueryODPSchemasLogicTablesResponseBodyData : TeaModel {
            [NameInMap("BroadcastTable")]
            [Validation(Required=false)]
            public bool? BroadcastTable { get; set; }
            [NameInMap("CreateTableNow")]
            [Validation(Required=false)]
            public bool? CreateTableNow { get; set; }
            [NameInMap("EnvMode")]
            [Validation(Required=false)]
            public string EnvMode { get; set; }
            [NameInMap("EnvTenant")]
            [Validation(Required=false)]
            public string EnvTenant { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }
            [NameInMap("GroupCount")]
            [Validation(Required=false)]
            public long? GroupCount { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("SchemaGroupType")]
            [Validation(Required=false)]
            public long? SchemaGroupType { get; set; }
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }
            [NameInMap("SingleTable")]
            [Validation(Required=false)]
            public bool? SingleTable { get; set; }
            [NameInMap("SqlText")]
            [Validation(Required=false)]
            public string SqlText { get; set; }
            [NameInMap("TableCount")]
            [Validation(Required=false)]
            public long? TableCount { get; set; }
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }
            [NameInMap("TbSuffix")]
            [Validation(Required=false)]
            public string TbSuffix { get; set; }
            [NameInMap("TbSuffixPadding")]
            [Validation(Required=false)]
            public string TbSuffixPadding { get; set; }
            [NameInMap("DbRules")]
            [Validation(Required=false)]
            public List<QueryODPSchemasLogicTablesResponseBodyDataDbRules> DbRules { get; set; }
            public class QueryODPSchemasLogicTablesResponseBodyDataDbRules : TeaModel {
                public bool? Customized { get; set; }
                public string Field { get; set; }
                public string Text { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<QueryODPSchemasLogicTablesResponseBodyDataRules> Rules { get; set; }
            public class QueryODPSchemasLogicTablesResponseBodyDataRules : TeaModel {
                public bool? Customized { get; set; }
                public string Field { get; set; }
                public string Text { get; set; }
                public string Value { get; set; }
            }
        };

    }

}
