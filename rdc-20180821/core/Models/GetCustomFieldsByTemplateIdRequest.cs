// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rdc20180821.Models
{
    public class GetCustomFieldsByTemplateIdRequest : TeaModel {
        [NameInMap("AKProjectId")]
        [Validation(Required=false)]
        public int? AKProjectId { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public int? TemplateId { get; set; }

        [NameInMap("CorpIdentifier")]
        [Validation(Required=false)]
        public string CorpIdentifier { get; set; }

    }

}
