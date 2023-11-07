// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListAuthorityTemplateResponseBody : TeaModel {
        [NameInMap("AuthorityTemplateViewList")]
        [Validation(Required=false)]
        public ListAuthorityTemplateResponseBodyAuthorityTemplateViewList AuthorityTemplateViewList { get; set; }
        public class ListAuthorityTemplateResponseBodyAuthorityTemplateViewList : TeaModel {
            [NameInMap("AuthorityTemplateView")]
            [Validation(Required=false)]
            public List<ListAuthorityTemplateResponseBodyAuthorityTemplateViewListAuthorityTemplateView> AuthorityTemplateView { get; set; }
            public class ListAuthorityTemplateResponseBodyAuthorityTemplateViewListAuthorityTemplateView : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public long? CreatorId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

            }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
