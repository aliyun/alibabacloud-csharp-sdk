// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSensitiveColumnsDetailResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SensitiveColumnsDetailList")]
        [Validation(Required=false)]
        public ListSensitiveColumnsDetailResponseBodySensitiveColumnsDetailList SensitiveColumnsDetailList { get; set; }
        public class ListSensitiveColumnsDetailResponseBodySensitiveColumnsDetailList : TeaModel {
            [NameInMap("SensitiveColumnsDetail")]
            [Validation(Required=false)]
            public List<ListSensitiveColumnsDetailResponseBodySensitiveColumnsDetailListSensitiveColumnsDetail> SensitiveColumnsDetail { get; set; }
            public class ListSensitiveColumnsDetailResponseBodySensitiveColumnsDetailListSensitiveColumnsDetail : TeaModel {
                public string ColumnDescription { get; set; }
                public string ColumnName { get; set; }
                public string ColumnType { get; set; }
                public long? DbId { get; set; }
                public string DbType { get; set; }
                public string EnvType { get; set; }
                public bool? Logic { get; set; }
                public string SchemaName { get; set; }
                public string SearchName { get; set; }
                public string TableName { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
