// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListAuthorityResponseBody : TeaModel {
        [NameInMap("AuthorityList")]
        [Validation(Required=false)]
        public ListAuthorityResponseBodyAuthorityList AuthorityList { get; set; }
        public class ListAuthorityResponseBodyAuthorityList : TeaModel {
            [NameInMap("Authority")]
            [Validation(Required=false)]
            public List<ListAuthorityResponseBodyAuthorityListAuthority> Authority { get; set; }
            public class ListAuthorityResponseBodyAuthorityListAuthority : TeaModel {
                public ListAuthorityResponseBodyAuthorityListAuthorityActionList ActionList { get; set; }
                public class ListAuthorityResponseBodyAuthorityListAuthorityActionList : TeaModel {
                    [NameInMap("Action")]
                    [Validation(Required=false)]
                    public List<ListAuthorityResponseBodyAuthorityListAuthorityActionListAction> Action { get; set; }
                    public class ListAuthorityResponseBodyAuthorityListAuthorityActionListAction : TeaModel {
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("GroupId")]
                        [Validation(Required=false)]
                        public string GroupId { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }
                public string Description { get; set; }
                public string GroupId { get; set; }
                public string Name { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
