// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateStructSyncOrderRequest : TeaModel {
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateStructSyncOrderRequestParam Param { get; set; }
        public class CreateStructSyncOrderRequestParam : TeaModel {
            [NameInMap("Source")]
            [Validation(Required=false)]
            public CreateStructSyncOrderRequestParamSource Source { get; set; }
            public class CreateStructSyncOrderRequestParamSource : TeaModel {
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                [NameInMap("DbSearchName")]
                [Validation(Required=false)]
                public string DbSearchName { get; set; }

                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }
            [NameInMap("Target")]
            [Validation(Required=false)]
            public CreateStructSyncOrderRequestParamTarget Target { get; set; }
            public class CreateStructSyncOrderRequestParamTarget : TeaModel {
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                [NameInMap("DbSearchName")]
                [Validation(Required=false)]
                public string DbSearchName { get; set; }

                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }
            [NameInMap("IgnoreError")]
            [Validation(Required=false)]
            public bool? IgnoreError { get; set; }
            [NameInMap("TableInfoList")]
            [Validation(Required=false)]
            public List<CreateStructSyncOrderRequestParamTableInfoList> TableInfoList { get; set; }
            public class CreateStructSyncOrderRequestParamTableInfoList : TeaModel {
                public string SourceTableName { get; set; }
                public string TargetTableName { get; set; }
            }
        };

    }

}
