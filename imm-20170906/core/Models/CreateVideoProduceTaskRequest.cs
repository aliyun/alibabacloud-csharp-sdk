// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class CreateVideoProduceTaskRequest : TeaModel {
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("Images")]
        [Validation(Required=false)]
        public string Images { get; set; }

        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

        [NameInMap("NotifyEndpoint")]
        [Validation(Required=false)]
        public string NotifyEndpoint { get; set; }

        [NameInMap("TargetUri")]
        [Validation(Required=false)]
        public string TargetUri { get; set; }

        [NameInMap("CustomMessage")]
        [Validation(Required=false)]
        public string CustomMessage { get; set; }

        [NameInMap("Music")]
        [Validation(Required=false)]
        public string Music { get; set; }

        [NameInMap("Width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
