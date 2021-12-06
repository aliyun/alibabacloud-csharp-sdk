// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class CreateAccessConfigurationRequest : TeaModel {
        [NameInMap("AccessConfigurationName")]
        [Validation(Required=false)]
        public string AccessConfigurationName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        [NameInMap("RelayState")]
        [Validation(Required=false)]
        public string RelayState { get; set; }

        [NameInMap("SessionDuration")]
        [Validation(Required=false)]
        public int? SessionDuration { get; set; }

    }

}
