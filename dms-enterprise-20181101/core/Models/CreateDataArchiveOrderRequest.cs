// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDataArchiveOrderRequest : TeaModel {
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateDataArchiveOrderRequestParam Param { get; set; }
        public class CreateDataArchiveOrderRequestParam : TeaModel {
            [NameInMap("ArchiveMethod")]
            [Validation(Required=false)]
            public string ArchiveMethod { get; set; }

            [NameInMap("DbSchema")]
            [Validation(Required=false)]
            public string DbSchema { get; set; }

            [NameInMap("Logic")]
            [Validation(Required=false)]
            public bool? Logic { get; set; }

            [NameInMap("OrderAfter")]
            [Validation(Required=false)]
            public List<string> OrderAfter { get; set; }

            [NameInMap("RunMethod")]
            [Validation(Required=false)]
            public string RunMethod { get; set; }

            [NameInMap("SourceDatabaseId")]
            [Validation(Required=false)]
            public long? SourceDatabaseId { get; set; }

            [NameInMap("TableIncludes")]
            [Validation(Required=false)]
            public List<CreateDataArchiveOrderRequestParamTableIncludes> TableIncludes { get; set; }
            public class CreateDataArchiveOrderRequestParamTableIncludes : TeaModel {
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                [NameInMap("TableWhere")]
                [Validation(Required=false)]
                public string TableWhere { get; set; }

            }

            [NameInMap("TableMapping")]
            [Validation(Required=false)]
            public List<string> TableMapping { get; set; }

            [NameInMap("TargetInstanceId")]
            [Validation(Required=false)]
            public string TargetInstanceId { get; set; }

            [NameInMap("Variables")]
            [Validation(Required=false)]
            public List<string> Variables { get; set; }

        }

        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        [NameInMap("PluginType")]
        [Validation(Required=false)]
        public string PluginType { get; set; }

        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<string> RelatedUserList { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
