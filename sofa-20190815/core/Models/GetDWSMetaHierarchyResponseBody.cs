// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetDWSMetaHierarchyResponseBody : TeaModel {
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
        public List<GetDWSMetaHierarchyResponseBodyData> Data { get; set; }
        public class GetDWSMetaHierarchyResponseBodyData : TeaModel {
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            [NameInMap("AllColumn")]
            [Validation(Required=false)]
            public List<GetDWSMetaHierarchyResponseBodyDataAllColumn> AllColumn { get; set; }
            public class GetDWSMetaHierarchyResponseBodyDataAllColumn : TeaModel {
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                [NameInMap("ColumnInfo")]
                [Validation(Required=false)]
                public List<GetDWSMetaHierarchyResponseBodyDataAllColumnColumnInfo> ColumnInfo { get; set; }
                public class GetDWSMetaHierarchyResponseBodyDataAllColumnColumnInfo : TeaModel {
                    [NameInMap("IsPrimaryKey")]
                    [Validation(Required=false)]
                    public bool? IsPrimaryKey { get; set; }

                    [NameInMap("IsUnique")]
                    [Validation(Required=false)]
                    public bool? IsUnique { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

        }

    }

}
