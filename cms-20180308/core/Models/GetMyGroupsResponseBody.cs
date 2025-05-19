// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class GetMyGroupsResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Group")]
        [Validation(Required=false)]
        public GetMyGroupsResponseBodyGroup Group { get; set; }
        public class GetMyGroupsResponseBodyGroup : TeaModel {
            [NameInMap("BindUrl")]
            [Validation(Required=false)]
            public string BindUrl { get; set; }

            [NameInMap("ContactGroups")]
            [Validation(Required=false)]
            public GetMyGroupsResponseBodyGroupContactGroups ContactGroups { get; set; }
            public class GetMyGroupsResponseBodyGroupContactGroups : TeaModel {
                [NameInMap("ContactGroup")]
                [Validation(Required=false)]
                public List<GetMyGroupsResponseBodyGroupContactGroupsContactGroup> ContactGroup { get; set; }
                public class GetMyGroupsResponseBodyGroupContactGroupsContactGroup : TeaModel {
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
            public long? ServiceId { get; set; }

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
