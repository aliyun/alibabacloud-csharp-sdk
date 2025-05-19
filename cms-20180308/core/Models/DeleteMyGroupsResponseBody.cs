// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class DeleteMyGroupsResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Group")]
        [Validation(Required=false)]
        public DeleteMyGroupsResponseBodyGroup Group { get; set; }
        public class DeleteMyGroupsResponseBodyGroup : TeaModel {
            [NameInMap("BindUrls")]
            [Validation(Required=false)]
            public string BindUrls { get; set; }

            [NameInMap("ContactGroups")]
            [Validation(Required=false)]
            public DeleteMyGroupsResponseBodyGroupContactGroups ContactGroups { get; set; }
            public class DeleteMyGroupsResponseBodyGroupContactGroups : TeaModel {
                [NameInMap("ContactGroup")]
                [Validation(Required=false)]
                public List<DeleteMyGroupsResponseBodyGroupContactGroupsContactGroup> ContactGroup { get; set; }
                public class DeleteMyGroupsResponseBodyGroupContactGroupsContactGroup : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
