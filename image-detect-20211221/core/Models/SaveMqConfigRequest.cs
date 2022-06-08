// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Image_detect20211221.Models
{
    public class SaveMqConfigRequest : TeaModel {
        [NameInMap("ConfigName")]
        [Validation(Required=false)]
        public string ConfigName { get; set; }

        [NameInMap("MqAccessKey")]
        [Validation(Required=false)]
        public string MqAccessKey { get; set; }

        [NameInMap("MqAccessSecret")]
        [Validation(Required=false)]
        public string MqAccessSecret { get; set; }

        [NameInMap("MqEndpoint")]
        [Validation(Required=false)]
        public string MqEndpoint { get; set; }

        [NameInMap("MqGroupId")]
        [Validation(Required=false)]
        public string MqGroupId { get; set; }

        [NameInMap("MqTopic")]
        [Validation(Required=false)]
        public string MqTopic { get; set; }

    }

}
