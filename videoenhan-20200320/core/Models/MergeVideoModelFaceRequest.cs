// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class MergeVideoModelFaceRequest : TeaModel {
        [NameInMap("AddWatermark")]
        [Validation(Required=false)]
        public bool? AddWatermark { get; set; }

        [NameInMap("Enhance")]
        [Validation(Required=false)]
        public bool? Enhance { get; set; }

        [NameInMap("FaceImageURL")]
        [Validation(Required=false)]
        public string FaceImageURL { get; set; }

        [NameInMap("MergeInfos")]
        [Validation(Required=false)]
        public List<MergeVideoModelFaceRequestMergeInfos> MergeInfos { get; set; }
        public class MergeVideoModelFaceRequestMergeInfos : TeaModel {
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

            [NameInMap("TemplateFaceID")]
            [Validation(Required=false)]
            public string TemplateFaceID { get; set; }

            [NameInMap("TemplateFaceURL")]
            [Validation(Required=false)]
            public string TemplateFaceURL { get; set; }

        }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
