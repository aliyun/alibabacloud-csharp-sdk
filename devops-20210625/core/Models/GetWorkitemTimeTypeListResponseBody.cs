// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetWorkitemTimeTypeListResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("timeType")]
        [Validation(Required=false)]
        public List<GetWorkitemTimeTypeListResponseBodyTimeType> TimeType { get; set; }
        public class GetWorkitemTimeTypeListResponseBodyTimeType : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("position")]
            [Validation(Required=false)]
            public long? Position { get; set; }

        }

    }

}
