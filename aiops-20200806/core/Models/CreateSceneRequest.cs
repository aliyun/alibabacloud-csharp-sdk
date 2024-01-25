// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class CreateSceneRequest : TeaModel {
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        [NameInMap("MetricListJson")]
        [Validation(Required=false)]
        public string MetricListJson { get; set; }

        [NameInMap("NodeListJson")]
        [Validation(Required=false)]
        public string NodeListJson { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

        [NameInMap("SceneDesc")]
        [Validation(Required=false)]
        public string SceneDesc { get; set; }

        [NameInMap("SceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

        [NameInMap("SceneOwner")]
        [Validation(Required=false)]
        public string SceneOwner { get; set; }

        [NameInMap("SceneWebhook")]
        [Validation(Required=false)]
        public string SceneWebhook { get; set; }

    }

}
