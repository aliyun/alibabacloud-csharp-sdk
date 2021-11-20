// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class StartConfigurationRecorderResponseBody : TeaModel {
        [NameInMap("ConfigurationRecorder")]
        [Validation(Required=false)]
        public StartConfigurationRecorderResponseBodyConfigurationRecorder ConfigurationRecorder { get; set; }
        public class StartConfigurationRecorderResponseBodyConfigurationRecorder : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }
            [NameInMap("ConfigurationRecorderStatus")]
            [Validation(Required=false)]
            public string ConfigurationRecorderStatus { get; set; }
            [NameInMap("OrganizationEnableStatus")]
            [Validation(Required=false)]
            public string OrganizationEnableStatus { get; set; }
            [NameInMap("OrganizationMasterId")]
            [Validation(Required=false)]
            public long? OrganizationMasterId { get; set; }
            [NameInMap("ResourceTypes")]
            [Validation(Required=false)]
            public List<string> ResourceTypes { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
