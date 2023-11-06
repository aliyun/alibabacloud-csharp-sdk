// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetRemediationTemplateRequest : TeaModel {
        /// <summary>
        /// The identifier of the automatic remediation template.
        /// 
        /// For more information about how to obtain the identifier of a remediation template, see [Compliance library](~~2337741~~).
        /// </summary>
        [NameInMap("TemplateIdentifier")]
        [Validation(Required=false)]
        public string TemplateIdentifier { get; set; }

    }

}
