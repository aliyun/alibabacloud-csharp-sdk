// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ListGroupsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGroupsResponseBodyData Data { get; set; }
        public class ListGroupsResponseBodyData : TeaModel {
            [NameInMap("AppGroups")]
            [Validation(Required=false)]
            public List<ListGroupsResponseBodyDataAppGroups> AppGroups { get; set; }
            public class ListGroupsResponseBodyDataAppGroups : TeaModel {
                public string AppKey { get; set; }
                public string AppName { get; set; }
                public string Description { get; set; }
                public string GroupId { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
