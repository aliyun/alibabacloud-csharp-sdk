// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDataServiceApplicationResponseBody : TeaModel {
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataServiceApplicationResponseBodyData Data { get; set; }
        public class GetDataServiceApplicationResponseBodyData : TeaModel {
            [NameInMap("ApplicationCode")]
            [Validation(Required=false)]
            public string ApplicationCode { get; set; }
            [NameInMap("ApplicationKey")]
            [Validation(Required=false)]
            public string ApplicationKey { get; set; }
            [NameInMap("ApplicationSecret")]
            [Validation(Required=false)]
            public string ApplicationSecret { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public long? ApplicationId { get; set; }
        };

    }

}
