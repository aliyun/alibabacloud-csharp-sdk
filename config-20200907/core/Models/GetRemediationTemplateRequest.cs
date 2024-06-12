// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetRemediationTemplateRequest : TeaModel {
        /// <summary>
        /// The ID of the automatic remediation template.
        /// 
        /// For more information about how to obtain the ID of a remediation template, see [Compliance library](https://help.aliyun.com/document_detail/2337741.html).
        /// </summary>
        [NameInMap("TemplateIdentifier")]
        [Validation(Required=false)]
        public string TemplateIdentifier { get; set; }

    }

}
