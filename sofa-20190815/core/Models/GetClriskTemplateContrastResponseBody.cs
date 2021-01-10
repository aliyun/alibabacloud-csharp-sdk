// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetClriskTemplateContrastResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ModelDataNodeCodes")]
        [Validation(Required=false)]
        public List<string> ModelDataNodeCodes { get; set; }

        [NameInMap("ModelRuleCodes")]
        [Validation(Required=false)]
        public List<string> ModelRuleCodes { get; set; }

        [NameInMap("TemplateDataNodeCodes")]
        [Validation(Required=false)]
        public List<string> TemplateDataNodeCodes { get; set; }

        [NameInMap("TemplateRuleCodes")]
        [Validation(Required=false)]
        public List<string> TemplateRuleCodes { get; set; }

    }

}
