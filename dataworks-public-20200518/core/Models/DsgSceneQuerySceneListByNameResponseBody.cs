// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgSceneQuerySceneListByNameResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DsgSceneQuerySceneListByNameResponseBodyData> Data { get; set; }
        public class DsgSceneQuerySceneListByNameResponseBodyData : TeaModel {
            [NameInMap("Children")]
            [Validation(Required=false)]
            public List<object> Children { get; set; }

            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Projects")]
            [Validation(Required=false)]
            public List<DsgSceneQuerySceneListByNameResponseBodyDataProjects> Projects { get; set; }
            public class DsgSceneQuerySceneListByNameResponseBodyDataProjects : TeaModel {
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

            }

            [NameInMap("SceneCode")]
            [Validation(Required=false)]
            public string SceneCode { get; set; }

            [NameInMap("SceneLevel")]
            [Validation(Required=false)]
            public int? SceneLevel { get; set; }

            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            [NameInMap("UserGroups")]
            [Validation(Required=false)]
            public string UserGroups { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
