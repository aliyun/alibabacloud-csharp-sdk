// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class SetServiceSettingsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceSettings")]
        [Validation(Required=false)]
        public List<SetServiceSettingsResponseBodyServiceSettings> ServiceSettings { get; set; }
        public class SetServiceSettingsResponseBodyServiceSettings : TeaModel {
            [NameInMap("DeliveryOssBucketName")]
            [Validation(Required=false)]
            public string DeliveryOssBucketName { get; set; }

            [NameInMap("DeliveryOssKeyPrefix")]
            [Validation(Required=false)]
            public string DeliveryOssKeyPrefix { get; set; }

            [NameInMap("DeliverySlsEnabled")]
            [Validation(Required=false)]
            public bool? DeliverySlsEnabled { get; set; }

            [NameInMap("DeliveryOssEnabled")]
            [Validation(Required=false)]
            public bool? DeliveryOssEnabled { get; set; }

            [NameInMap("DeliverySlsProjectName")]
            [Validation(Required=false)]
            public string DeliverySlsProjectName { get; set; }

        }

    }

}
