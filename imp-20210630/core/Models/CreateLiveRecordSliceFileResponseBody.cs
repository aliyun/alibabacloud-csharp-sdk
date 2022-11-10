// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class CreateLiveRecordSliceFileResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateLiveRecordSliceFileResponseBodyResult Result { get; set; }
        public class CreateLiveRecordSliceFileResponseBodyResult : TeaModel {
            [NameInMap("SliceRecordUrl")]
            [Validation(Required=false)]
            public string SliceRecordUrl { get; set; }

        }

    }

}
