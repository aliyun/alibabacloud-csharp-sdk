// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListLinkeLinktOperationlogsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public long? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListLinkeLinktOperationlogsResponseBodyData> Data { get; set; }
        public class ListLinkeLinktOperationlogsResponseBodyData : TeaModel {
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            [NameInMap("CurrentValue")]
            [Validation(Required=false)]
            public string CurrentValue { get; set; }

            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            [NameInMap("DisplayContent")]
            [Validation(Required=false)]
            public string DisplayContent { get; set; }

            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            [NameInMap("FieldType")]
            [Validation(Required=false)]
            public string FieldType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("LastValue")]
            [Validation(Required=false)]
            public string LastValue { get; set; }

            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public long? UpdatedAt { get; set; }

        }

    }

}
