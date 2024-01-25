// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class GetScenarioListRequest : TeaModel {
        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ScenarioName")]
        [Validation(Required=false)]
        public string ScenarioName { get; set; }

        [NameInMap("SceneSelectLabel")]
        [Validation(Required=false)]
        public string SceneSelectLabel { get; set; }

    }

}
