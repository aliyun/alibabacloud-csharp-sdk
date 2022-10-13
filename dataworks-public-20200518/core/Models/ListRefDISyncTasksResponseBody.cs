// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListRefDISyncTasksResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRefDISyncTasksResponseBodyData Data { get; set; }
        public class ListRefDISyncTasksResponseBodyData : TeaModel {
            [NameInMap("DISyncTasks")]
            [Validation(Required=false)]
            public List<ListRefDISyncTasksResponseBodyDataDISyncTasks> DISyncTasks { get; set; }
            public class ListRefDISyncTasksResponseBodyDataDISyncTasks : TeaModel {
                [NameInMap("DiDestinationDatasource")]
                [Validation(Required=false)]
                public string DiDestinationDatasource { get; set; }

                [NameInMap("DiSourceDatasource")]
                [Validation(Required=false)]
                public string DiSourceDatasource { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
