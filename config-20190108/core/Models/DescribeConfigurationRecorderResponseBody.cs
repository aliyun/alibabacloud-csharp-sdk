// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class DescribeConfigurationRecorderResponseBody : TeaModel {
        [NameInMap("ConfigurationRecorder")]
        [Validation(Required=false)]
        public DescribeConfigurationRecorderResponseBodyConfigurationRecorder ConfigurationRecorder { get; set; }
        public class DescribeConfigurationRecorderResponseBodyConfigurationRecorder : TeaModel {
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
