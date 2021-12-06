// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateAccessConfigurationRequest : TeaModel {
        [NameInMap("AccessConfigurationId")]
        [Validation(Required=false)]
        public string AccessConfigurationId { get; set; }

        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        [NameInMap("NewDescription")]
        [Validation(Required=false)]
        public string NewDescription { get; set; }

        [NameInMap("NewRelayState")]
        [Validation(Required=false)]
        public string NewRelayState { get; set; }

        [NameInMap("NewSessionDuration")]
        [Validation(Required=false)]
        public int? NewSessionDuration { get; set; }

    }

}
