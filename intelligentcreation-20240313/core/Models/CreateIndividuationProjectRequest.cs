// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class CreateIndividuationProjectRequest : TeaModel {
        [NameInMap("projectInfo")]
        [Validation(Required=false)]
        public string ProjectInfo { get; set; }

        [NameInMap("projectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("purpose")]
        [Validation(Required=false)]
        public string Purpose { get; set; }

        [NameInMap("sceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

    }

}
