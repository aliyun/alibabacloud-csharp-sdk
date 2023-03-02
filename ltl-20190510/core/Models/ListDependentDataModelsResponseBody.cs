// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ltl20190510.Models
{
    public class ListDependentDataModelsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDependentDataModelsResponseBodyData Data { get; set; }
        public class ListDependentDataModelsResponseBodyData : TeaModel {
            [NameInMap("DataModelInfo")]
            [Validation(Required=false)]
            public List<ListDependentDataModelsResponseBodyDataDataModelInfo> DataModelInfo { get; set; }
            public class ListDependentDataModelsResponseBodyDataDataModelInfo : TeaModel {
                [NameInMap("DataModelCode")]
                [Validation(Required=false)]
                public string DataModelCode { get; set; }

                [NameInMap("DataModelName")]
                [Validation(Required=false)]
                public string DataModelName { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
