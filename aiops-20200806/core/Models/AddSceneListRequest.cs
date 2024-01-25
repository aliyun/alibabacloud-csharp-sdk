// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class AddSceneListRequest : TeaModel {
        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

        [NameInMap("SceneDescribe")]
        [Validation(Required=false)]
        public string SceneDescribe { get; set; }

        [NameInMap("SceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

        [NameInMap("ScenePersonLiable")]
        [Validation(Required=false)]
        public string ScenePersonLiable { get; set; }

        [NameInMap("SceneType")]
        [Validation(Required=false)]
        public string SceneType { get; set; }

        [NameInMap("SceneVoJson")]
        [Validation(Required=false)]
        public string SceneVoJson { get; set; }

        [NameInMap("Webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

    }

}
