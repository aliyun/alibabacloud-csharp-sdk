// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAlertActionsRequest : TeaModel {
        [NameInMap("alertActionIds")]
        [Validation(Required=false)]
        public List<string> AlertActionIds { get; set; }

        [NameInMap("alertActionName")]
        [Validation(Required=false)]
        public string AlertActionName { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
