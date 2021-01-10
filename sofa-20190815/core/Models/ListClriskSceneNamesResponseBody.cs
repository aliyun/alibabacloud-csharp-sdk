// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListClriskSceneNamesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        [NameInMap("SceneNameInfos")]
        [Validation(Required=false)]
        public List<ListClriskSceneNamesResponseBodySceneNameInfos> SceneNameInfos { get; set; }
        public class ListClriskSceneNamesResponseBodySceneNameInfos : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public long? ProductId { get; set; }

            [NameInMap("SonSceneNameInfos")]
            [Validation(Required=false)]
            public List<ListClriskSceneNamesResponseBodySceneNameInfosSonSceneNameInfos> SonSceneNameInfos { get; set; }
            public class ListClriskSceneNamesResponseBodySceneNameInfosSonSceneNameInfos : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ProductId")]
                [Validation(Required=false)]
                public long? ProductId { get; set; }

                [NameInMap("LeafSceneNameInfos")]
                [Validation(Required=false)]
                public List<ListClriskSceneNamesResponseBodySceneNameInfosSonSceneNameInfosLeafSceneNameInfos> LeafSceneNameInfos { get; set; }
                public class ListClriskSceneNamesResponseBodySceneNameInfosSonSceneNameInfosLeafSceneNameInfos : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ProductId")]
                    [Validation(Required=false)]
                    public long? ProductId { get; set; }

                }

            }

        }

    }

}
