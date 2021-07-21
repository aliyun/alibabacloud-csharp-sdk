// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteMonitorGroupResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Group")]
        [Validation(Required=false)]
        public DeleteMonitorGroupResponseBodyGroup Group { get; set; }
        public class DeleteMonitorGroupResponseBodyGroup : TeaModel {
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }
            [NameInMap("ContactGroups")]
            [Validation(Required=false)]
            public DeleteMonitorGroupResponseBodyGroupContactGroups ContactGroups { get; set; }
            public class DeleteMonitorGroupResponseBodyGroupContactGroups : TeaModel {
                [NameInMap("ContactGroup")]
                [Validation(Required=false)]
                public List<DeleteMonitorGroupResponseBodyGroupContactGroupsContactGroup> ContactGroup { get; set; }
                public class DeleteMonitorGroupResponseBodyGroupContactGroupsContactGroup : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }
        };

    }

}
