// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class PutConfigurationRecorderResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ConfigurationRecorder")]
        [Validation(Required=false)]
        public PutConfigurationRecorderResponseBodyConfigurationRecorder ConfigurationRecorder { get; set; }
        public class PutConfigurationRecorderResponseBodyConfigurationRecorder : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }
            [NameInMap("ConfigurationRecorderStatus")]
            [Validation(Required=false)]
            public string ConfigurationRecorderStatus { get; set; }
            [NameInMap("ResourceTypes")]
            [Validation(Required=false)]
            public List<string> ResourceTypes { get; set; }
        };

    }

}
