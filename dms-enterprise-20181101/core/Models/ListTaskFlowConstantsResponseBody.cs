// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowConstantsResponseBody : TeaModel {
        [NameInMap("DagConstants")]
        [Validation(Required=false)]
        public ListTaskFlowConstantsResponseBodyDagConstants DagConstants { get; set; }
        public class ListTaskFlowConstantsResponseBodyDagConstants : TeaModel {
            [NameInMap("DagConstant")]
            [Validation(Required=false)]
            public List<ListTaskFlowConstantsResponseBodyDagConstantsDagConstant> DagConstant { get; set; }
            public class ListTaskFlowConstantsResponseBodyDagConstantsDagConstant : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
