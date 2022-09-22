// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class ListServiceSettingsResponseBody : TeaModel {
        [NameInMap("CloudAssistantDeliverySettings")]
        [Validation(Required=false)]
        public ListServiceSettingsResponseBodyCloudAssistantDeliverySettings CloudAssistantDeliverySettings { get; set; }
        public class ListServiceSettingsResponseBodyCloudAssistantDeliverySettings : TeaModel {
            [NameInMap("OssBucketName")]
            [Validation(Required=false)]
            public string OssBucketName { get; set; }

            [NameInMap("OssEnabled")]
            [Validation(Required=false)]
            public bool? OssEnabled { get; set; }

            [NameInMap("OssKeyPrefix")]
            [Validation(Required=false)]
            public string OssKeyPrefix { get; set; }

            [NameInMap("SlsEnabled")]
            [Validation(Required=false)]
            public bool? SlsEnabled { get; set; }

            [NameInMap("SlsLogstoreName")]
            [Validation(Required=false)]
            public string SlsLogstoreName { get; set; }

            [NameInMap("SlsProjectName")]
            [Validation(Required=false)]
            public string SlsProjectName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
