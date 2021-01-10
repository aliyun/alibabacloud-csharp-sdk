// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class UpdateSlrConfigurationRequest : TeaModel {
        [NameInMap("MqSubscribe")]
        [Validation(Required=false)]
        public bool? MqSubscribe { get; set; }

        [NameInMap("MqEndpoint")]
        [Validation(Required=false)]
        public string MqEndpoint { get; set; }

        [NameInMap("MqInstanceId")]
        [Validation(Required=false)]
        public string MqInstanceId { get; set; }

        [NameInMap("MqTopic")]
        [Validation(Required=false)]
        public string MqTopic { get; set; }

        [NameInMap("MqGroupId")]
        [Validation(Required=false)]
        public string MqGroupId { get; set; }

        [NameInMap("MqEvent")]
        [Validation(Required=false)]
        public List<string> MqEvent { get; set; }

    }

}
