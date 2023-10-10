// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class MergeImageFaceRequest : TeaModel {
        [NameInMap("AddWatermark")]
        [Validation(Required=false)]
        public bool? AddWatermark { get; set; }

        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

        [NameInMap("MergeInfos")]
        [Validation(Required=false)]
        public List<MergeImageFaceRequestMergeInfos> MergeInfos { get; set; }
        public class MergeImageFaceRequestMergeInfos : TeaModel {
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

        [NameInMap("WatermarkType")]
        [Validation(Required=false)]
        public string WatermarkType { get; set; }

    }

}
