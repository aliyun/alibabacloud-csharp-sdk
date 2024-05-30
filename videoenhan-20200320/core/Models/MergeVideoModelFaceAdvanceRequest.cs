// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class MergeVideoModelFaceAdvanceRequest : TeaModel {
        [NameInMap("AddWatermark")]
        [Validation(Required=false)]
        public bool? AddWatermark { get; set; }

        [NameInMap("Enhance")]
        [Validation(Required=false)]
        public bool? Enhance { get; set; }

        [NameInMap("FaceImageURL")]
        [Validation(Required=false)]
        public Stream FaceImageURLObject { get; set; }

        [NameInMap("MergeInfos")]
        [Validation(Required=false)]
        public List<MergeVideoModelFaceAdvanceRequestMergeInfos> MergeInfos { get; set; }
        public class MergeVideoModelFaceAdvanceRequestMergeInfos : TeaModel {
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("WatermarkType")]
        [Validation(Required=false)]
        public string WatermarkType { get; set; }

    }

}
