// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateRetcodeAppRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("RetcodeAppName")]
        [Validation(Required=false)]
        public string RetcodeAppName { get; set; }

        [NameInMap("RetcodeAppType")]
        [Validation(Required=false)]
        public string RetcodeAppType { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateRetcodeAppRequestTags> Tags { get; set; }
        public class CreateRetcodeAppRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
