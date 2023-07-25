// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetConfigurationRecorderResponseBody : TeaModel {
        [NameInMap("ConfigurationRecorder")]
        [Validation(Required=false)]
        public GetConfigurationRecorderResponseBodyConfigurationRecorder ConfigurationRecorder { get; set; }
        public class GetConfigurationRecorderResponseBodyConfigurationRecorder : TeaModel {
            [NameInMap("ConfigurationRecorderStatus")]
            [Validation(Required=false)]
            public string ConfigurationRecorderStatus { get; set; }

            [NameInMap("ResourceTypes")]
            [Validation(Required=false)]
            public List<string> ResourceTypes { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
