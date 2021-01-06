// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class ClassifyFNFResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ClassifyFNFResponseBodyData Data { get; set; }
        public class ClassifyFNFResponseBodyData : TeaModel {
            [NameInMap("Fractures")]
            [Validation(Required=false)]
            public List<ClassifyFNFResponseBodyDataFractures> Fractures { get; set; }
            public class ClassifyFNFResponseBodyDataFractures : TeaModel {
                public float? Value { get; set; }
                public List<string> Boxes { get; set; }
                public ClassifyFNFResponseBodyDataFracturesTag Tag { get; set; }
                public class ClassifyFNFResponseBodyDataFracturesTag : TeaModel {
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }
            }
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }
            [NameInMap("OrgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }
        };

    }

}
