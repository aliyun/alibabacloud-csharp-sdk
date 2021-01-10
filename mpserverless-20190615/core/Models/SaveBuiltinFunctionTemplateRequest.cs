// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class SaveBuiltinFunctionTemplateRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("BuiltinFunctionTemplateCategoryId")]
        [Validation(Required=false)]
        public string BuiltinFunctionTemplateCategoryId { get; set; }

        [NameInMap("BuiltinFunctionTemplateProfile")]
        [Validation(Required=false)]
        public string BuiltinFunctionTemplateProfile { get; set; }

    }

}
