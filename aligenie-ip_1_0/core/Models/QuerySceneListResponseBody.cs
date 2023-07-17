// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class QuerySceneListResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<QuerySceneListResponseBodyResults> Results { get; set; }
        public class QuerySceneListResponseBodyResults : TeaModel {
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            [NameInMap("SceneSource")]
            [Validation(Required=false)]
            public string SceneSource { get; set; }

            [NameInMap("SceneState")]
            [Validation(Required=false)]
            public int? SceneState { get; set; }

            [NameInMap("SceneType")]
            [Validation(Required=false)]
            public string SceneType { get; set; }

            [NameInMap("TemplateInfoDTOList")]
            [Validation(Required=false)]
            public List<QuerySceneListResponseBodyResultsTemplateInfoDTOList> TemplateInfoDTOList { get; set; }
            public class QuerySceneListResponseBodyResultsTemplateInfoDTOList : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("UnavailableReason")]
            [Validation(Required=false)]
            public string UnavailableReason { get; set; }

        }

        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

    }

}
