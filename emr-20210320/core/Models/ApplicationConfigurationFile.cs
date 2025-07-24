// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ApplicationConfigurationFile : TeaModel {
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ConfigFileFormat")]
        [Validation(Required=false)]
        public string ConfigFileFormat { get; set; }

        [NameInMap("ConfigFileGroup")]
        [Validation(Required=false)]
        public string ConfigFileGroup { get; set; }

        [NameInMap("ConfigFileLink")]
        [Validation(Required=false)]
        public string ConfigFileLink { get; set; }

        [NameInMap("ConfigFileMode")]
        [Validation(Required=false)]
        public string ConfigFileMode { get; set; }

        [NameInMap("ConfigFileName")]
        [Validation(Required=false)]
        public string ConfigFileName { get; set; }

        [NameInMap("ConfigFileOwner")]
        [Validation(Required=false)]
        public string ConfigFileOwner { get; set; }

        [NameInMap("ConfigFilePath")]
        [Validation(Required=false)]
        public string ConfigFilePath { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

    }

}
