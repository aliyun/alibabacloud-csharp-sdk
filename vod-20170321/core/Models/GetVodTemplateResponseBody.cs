// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVodTemplateResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VodTemplateInfo")]
        [Validation(Required=false)]
        public GetVodTemplateResponseBodyVodTemplateInfo VodTemplateInfo { get; set; }
        public class GetVodTemplateResponseBodyVodTemplateInfo : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }
            [NameInMap("VodTemplateId")]
            [Validation(Required=false)]
            public string VodTemplateId { get; set; }
            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            public string TemplateConfig { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }
        };

    }

}
