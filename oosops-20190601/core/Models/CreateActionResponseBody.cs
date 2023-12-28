// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oosops20190601.Models
{
    public class CreateActionResponseBody : TeaModel {
        [NameInMap("ActionName")]
        [Validation(Required=false)]
        public string ActionName { get; set; }

        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        [NameInMap("CreatedDate")]
        [Validation(Required=false)]
        public string CreatedDate { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Popularity")]
        [Validation(Required=false)]
        public int? Popularity { get; set; }

        [NameInMap("Properties")]
        [Validation(Required=false)]
        public string Properties { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
