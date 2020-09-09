// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class ClassifyFNFResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ClassifyFNFResponseData Data { get; set; }
        public class ClassifyFNFResponseData : TeaModel {
            [NameInMap("ImageUrl")]
            [Validation(Required=true)]
            public string ImageUrl { get; set; }
            [NameInMap("OrgId")]
            [Validation(Required=true)]
            public string OrgId { get; set; }
            [NameInMap("OrgName")]
            [Validation(Required=true)]
            public string OrgName { get; set; }
            [NameInMap("Fractures")]
            [Validation(Required=true)]
            public List<ClassifyFNFResponseDataFractures> Fractures { get; set; }
            public class ClassifyFNFResponseDataFractures : TeaModel {
                public float? Value { get; set; }
                public ClassifyFNFResponseDataFracturesTag Tag { get; set; }
                public class ClassifyFNFResponseDataFracturesTag : TeaModel {
                    [NameInMap("Label")]
                    [Validation(Required=true)]
                    public string Label { get; set; }

                }
                public List<string> Boxes { get; set; }
            }
        };

    }

}
