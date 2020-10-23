// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class PutConfigurationRecorderResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ConfigurationRecorder")]
        [Validation(Required=true)]
        public PutConfigurationRecorderResponseConfigurationRecorder ConfigurationRecorder { get; set; }
        public class PutConfigurationRecorderResponseConfigurationRecorder : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=true)]
            public long AccountId { get; set; }
            [NameInMap("ConfigurationRecorderStatus")]
            [Validation(Required=true)]
            public string ConfigurationRecorderStatus { get; set; }
            [NameInMap("OrganizationMasterId")]
            [Validation(Required=true)]
            public long OrganizationMasterId { get; set; }
            [NameInMap("OrganizationEnableStatus")]
            [Validation(Required=true)]
            public string OrganizationEnableStatus { get; set; }
            [NameInMap("ResourceTypes")]
            [Validation(Required=true)]
            public List<string> ResourceTypes { get; set; }
        };

    }

}
