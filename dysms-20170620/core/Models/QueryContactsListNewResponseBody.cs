// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QueryContactsListNewResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<QueryContactsListNewResponseBodyList> List { get; set; }
        public class QueryContactsListNewResponseBodyList : TeaModel {
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OpenPkgWarning")]
            [Validation(Required=false)]
            public int? OpenPkgWarning { get; set; }

            [NameInMap("OpenPreventBrushWarning")]
            [Validation(Required=false)]
            public int? OpenPreventBrushWarning { get; set; }

            [NameInMap("OpenSendWarning")]
            [Validation(Required=false)]
            public int? OpenSendWarning { get; set; }

            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            [NameInMap("ReceiveSignTemplateAuditResult")]
            [Validation(Required=false)]
            public int? ReceiveSignTemplateAuditResult { get; set; }

        }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
