// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class MergeImageFaceAdvanceRequest : TeaModel {
        [NameInMap("AddWatermark")]
        [Validation(Required=false)]
        public bool? AddWatermark { get; set; }

        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public Stream ImageURLObject { get; set; }

        [NameInMap("MergeInfos")]
        [Validation(Required=false)]
        public List<MergeImageFaceAdvanceRequestMergeInfos> MergeInfos { get; set; }
        public class MergeImageFaceAdvanceRequestMergeInfos : TeaModel {
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

            [NameInMap("TemplateFaceID")]
            [Validation(Required=false)]
            public string TemplateFaceID { get; set; }

        }

        [NameInMap("ModelVersion")]
        [Validation(Required=false)]
        public string ModelVersion { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
