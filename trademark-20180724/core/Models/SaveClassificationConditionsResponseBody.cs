// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class SaveClassificationConditionsResponseBody : TeaModel {
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("InvalidList")]
        [Validation(Required=false)]
        public List<SaveClassificationConditionsResponseBodyInvalidList> InvalidList { get; set; }
        public class SaveClassificationConditionsResponseBodyInvalidList : TeaModel {
            [NameInMap("ClassificationCode")]
            [Validation(Required=false)]
            public string ClassificationCode { get; set; }

            [NameInMap("ClassificationName")]
            [Validation(Required=false)]
            public string ClassificationName { get; set; }

            [NameInMap("OfficialCode")]
            [Validation(Required=false)]
            public string OfficialCode { get; set; }

            [NameInMap("ParentCode")]
            [Validation(Required=false)]
            public string ParentCode { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

    }

}
