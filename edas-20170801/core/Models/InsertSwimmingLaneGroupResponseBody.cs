// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertSwimmingLaneGroupResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public InsertSwimmingLaneGroupResponseBodyData Data { get; set; }
        public class InsertSwimmingLaneGroupResponseBodyData : TeaModel {
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }
            [NameInMap("ApplicationList")]
            [Validation(Required=false)]
            public InsertSwimmingLaneGroupResponseBodyDataApplicationList ApplicationList { get; set; }
            public class InsertSwimmingLaneGroupResponseBodyDataApplicationList : TeaModel {
                [NameInMap("Application")]
                [Validation(Required=false)]
                public List<InsertSwimmingLaneGroupResponseBodyDataApplicationListApplication> Application { get; set; }
                public class InsertSwimmingLaneGroupResponseBodyDataApplicationListApplication : TeaModel {
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                }

            }
            [NameInMap("EntryApplication")]
            [Validation(Required=false)]
            public InsertSwimmingLaneGroupResponseBodyDataEntryApplication EntryApplication { get; set; }
            public class InsertSwimmingLaneGroupResponseBodyDataEntryApplication : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

            }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
