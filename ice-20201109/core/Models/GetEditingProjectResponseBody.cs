// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetEditingProjectResponseBody : TeaModel {
        [NameInMap("Project")]
        [Validation(Required=false)]
        public GetEditingProjectResponseBodyProject Project { get; set; }
        public class GetEditingProjectResponseBodyProject : TeaModel {
            [NameInMap("BusinessConfig")]
            [Validation(Required=false)]
            public string BusinessConfig { get; set; }
            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }
            [NameInMap("CreateSource")]
            [Validation(Required=false)]
            public string CreateSource { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }
            [NameInMap("ModifiedSource")]
            [Validation(Required=false)]
            public string ModifiedSource { get; set; }
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }
            [NameInMap("ProjectType")]
            [Validation(Required=false)]
            public string ProjectType { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }
            [NameInMap("Timeline")]
            [Validation(Required=false)]
            public string Timeline { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
