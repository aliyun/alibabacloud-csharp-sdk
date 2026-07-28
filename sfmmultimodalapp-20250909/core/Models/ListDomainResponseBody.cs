// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SfmMultiModalApp20250909.Models
{
    public class ListDomainResponseBody : TeaModel {
        [NameInMap("DomainInfoList")]
        [Validation(Required=false)]
        public List<ListDomainResponseBodyDomainInfoList> DomainInfoList { get; set; }
        public class ListDomainResponseBodyDomainInfoList : TeaModel {
            [NameInMap("DomainCode")]
            [Validation(Required=false)]
            public string DomainCode { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("ToolCount")]
            [Validation(Required=false)]
            public int? ToolCount { get; set; }

            [NameInMap("ToolList")]
            [Validation(Required=false)]
            public List<ListDomainResponseBodyDomainInfoListToolList> ToolList { get; set; }
            public class ListDomainResponseBodyDomainInfoListToolList : TeaModel {
                [NameInMap("ToolCode")]
                [Validation(Required=false)]
                public string ToolCode { get; set; }

                [NameInMap("ToolName")]
                [Validation(Required=false)]
                public string ToolName { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
