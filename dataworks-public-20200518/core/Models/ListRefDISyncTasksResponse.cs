// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListRefDISyncTasksResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListRefDISyncTasksResponseData Data { get; set; }
        public class ListRefDISyncTasksResponseData : TeaModel {
            [NameInMap("DISyncTasks")]
            [Validation(Required=true)]
            public List<ListRefDISyncTasksResponseDataDISyncTasks> DISyncTasks { get; set; }
            public class ListRefDISyncTasksResponseDataDISyncTasks : TeaModel {
                public string NodeName { get; set; }
                public long? NodeId { get; set; }
                public string TaskType { get; set; }
                public string DiDestinationDatasource { get; set; }
                public string DiSourceDatasource { get; set; }
            }
        };

    }

}
