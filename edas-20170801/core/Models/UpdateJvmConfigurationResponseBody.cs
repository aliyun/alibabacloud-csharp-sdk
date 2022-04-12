// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateJvmConfigurationResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("JvmConfiguration")]
        [Validation(Required=false)]
        public UpdateJvmConfigurationResponseBodyJvmConfiguration JvmConfiguration { get; set; }
        public class UpdateJvmConfigurationResponseBodyJvmConfiguration : TeaModel {
            [NameInMap("MaxHeapSize")]
            [Validation(Required=false)]
            public int? MaxHeapSize { get; set; }
            [NameInMap("MaxPermSize")]
            [Validation(Required=false)]
            public int? MaxPermSize { get; set; }
            [NameInMap("MinHeapSize")]
            [Validation(Required=false)]
            public int? MinHeapSize { get; set; }
            [NameInMap("Options")]
            [Validation(Required=false)]
            public string Options { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
