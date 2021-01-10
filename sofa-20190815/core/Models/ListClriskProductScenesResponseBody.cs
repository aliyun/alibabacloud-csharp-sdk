// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListClriskProductScenesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public long? PageCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("SceneInfos")]
        [Validation(Required=false)]
        public List<ListClriskProductScenesResponseBodySceneInfos> SceneInfos { get; set; }
        public class ListClriskProductScenesResponseBodySceneInfos : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

            [NameInMap("RelatedNodeCount")]
            [Validation(Required=false)]
            public long? RelatedNodeCount { get; set; }

            [NameInMap("SonSceneInfos")]
            [Validation(Required=false)]
            public List<ListClriskProductScenesResponseBodySceneInfosSonSceneInfos> SonSceneInfos { get; set; }
            public class ListClriskProductScenesResponseBodySceneInfosSonSceneInfos : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("ModifyUser")]
                [Validation(Required=false)]
                public string ModifyUser { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                [NameInMap("RelatedNodeCount")]
                [Validation(Required=false)]
                public long? RelatedNodeCount { get; set; }

                [NameInMap("LeafSceneInfos")]
                [Validation(Required=false)]
                public List<ListClriskProductScenesResponseBodySceneInfosSonSceneInfosLeafSceneInfos> LeafSceneInfos { get; set; }
                public class ListClriskProductScenesResponseBodySceneInfosSonSceneInfosLeafSceneInfos : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("ModifyUser")]
                    [Validation(Required=false)]
                    public string ModifyUser { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ParentId")]
                    [Validation(Required=false)]
                    public long? ParentId { get; set; }

                    [NameInMap("RelatedNodeCount")]
                    [Validation(Required=false)]
                    public long? RelatedNodeCount { get; set; }

                }

            }

        }

    }

}
