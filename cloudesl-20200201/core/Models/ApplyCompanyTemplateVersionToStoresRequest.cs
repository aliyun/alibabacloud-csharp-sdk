// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20200201.Models
{
    public class ApplyCompanyTemplateVersionToStoresRequest : TeaModel {
        [NameInMap("Stores")]
        [Validation(Required=false)]
        public string Stores { get; set; }

        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
