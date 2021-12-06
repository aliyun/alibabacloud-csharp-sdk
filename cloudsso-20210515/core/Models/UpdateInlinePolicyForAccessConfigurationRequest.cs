// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateInlinePolicyForAccessConfigurationRequest : TeaModel {
        [NameInMap("AccessConfigurationId")]
        [Validation(Required=false)]
        public string AccessConfigurationId { get; set; }

        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        [NameInMap("InlinePolicyName")]
        [Validation(Required=false)]
        public string InlinePolicyName { get; set; }

        [NameInMap("NewInlinePolicyDocument")]
        [Validation(Required=false)]
        public string NewInlinePolicyDocument { get; set; }

    }

}
