// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class UpdateServiceSettingsRequest : TeaModel {
        [NameInMap("CloudAssistantDeliverySettings")]
        [Validation(Required=false)]
        public UpdateServiceSettingsRequestCloudAssistantDeliverySettings CloudAssistantDeliverySettings { get; set; }
        public class UpdateServiceSettingsRequestCloudAssistantDeliverySettings : TeaModel {
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

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
