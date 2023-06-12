// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class MergeVideoModelFaceAdvanceRequest : TeaModel {
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

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
