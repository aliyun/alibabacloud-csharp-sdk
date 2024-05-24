// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ListEditableNamespaceResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListEditableNamespaceResponseBodyData Data { get; set; }
        public class ListEditableNamespaceResponseBodyData : TeaModel {
            [NameInMap("editableNamespaces")]
            [Validation(Required=false)]
            public List<EditableNamespace> EditableNamespaces { get; set; }

            [NameInMap("pageIndex")]
            [Validation(Required=false)]
            public string PageIndex { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            [NameInMap("total")]
            [Validation(Required=false)]
            public string Total { get; set; }

        }

        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
