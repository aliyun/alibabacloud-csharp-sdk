// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cityvisual20181030.Models
{
    public class ModifyResourceProfileRequest : TeaModel {
        [NameInMap("ResourceProfileName")]
        [Validation(Required=false)]
        public string ResourceProfileName { get; set; }

        [NameInMap("ResourceProfileId")]
        [Validation(Required=false)]
        public string ResourceProfileId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ResourceProfileParams")]
        [Validation(Required=false)]
        public List<ModifyResourceProfileRequestResourceProfileParams> ResourceProfileParams { get; set; }
        public class ModifyResourceProfileRequestResourceProfileParams : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
