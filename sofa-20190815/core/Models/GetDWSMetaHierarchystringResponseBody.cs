// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetDWSMetaHierarchystringResponseBody : TeaModel {
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
        public List<GetDWSMetaHierarchystringResponseBodyData> Data { get; set; }
        public class GetDWSMetaHierarchystringResponseBodyData : TeaModel {
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<GetDWSMetaHierarchystringResponseBodyDataColumns> Columns { get; set; }
            public class GetDWSMetaHierarchystringResponseBodyDataColumns : TeaModel {
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                [NameInMap("ColumnDetailInfo")]
                [Validation(Required=false)]
                public List<string> ColumnDetailInfo { get; set; }

            }

        }

    }

}
