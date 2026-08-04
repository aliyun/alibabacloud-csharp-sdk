// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class QueryDeleteTaskCheckDataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TaskCheckDataDtoList")]
        [Validation(Required=false)]
        public List<QueryDeleteTaskCheckDataResponseBodyTaskCheckDataDtoList> TaskCheckDataDtoList { get; set; }
        public class QueryDeleteTaskCheckDataResponseBodyTaskCheckDataDtoList : TeaModel {
            [NameInMap("CheckerDesc")]
            [Validation(Required=false)]
            public string CheckerDesc { get; set; }

            [NameInMap("CheckerName")]
            [Validation(Required=false)]
            public string CheckerName { get; set; }

            [NameInMap("CheckerUniKey")]
            [Validation(Required=false)]
            public string CheckerUniKey { get; set; }

            [NameInMap("DependencyLevel")]
            [Validation(Required=false)]
            public string DependencyLevel { get; set; }

        }

    }

}
