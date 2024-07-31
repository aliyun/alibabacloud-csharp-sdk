// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListRefDISyncTasksResponseBody : TeaModel {
        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRefDISyncTasksResponseBodyData Data { get; set; }
        public class ListRefDISyncTasksResponseBodyData : TeaModel {
            /// <summary>
            /// The details of the synchronization tasks. In most cases, a data source is used by multiple synchronization tasks. Therefore, the value of this parameter is an array. The following parameters are the elements in the array. The sample values of these parameters show the details of a synchronization task.
            /// </summary>
            [NameInMap("DISyncTasks")]
            [Validation(Required=false)]
            public List<ListRefDISyncTasksResponseBodyDataDISyncTasks> DISyncTasks { get; set; }
            public class ListRefDISyncTasksResponseBodyDataDISyncTasks : TeaModel {
                /// <summary>
                /// The destination of the synchronization task. If the synchronization task has multiple destinations, the return value is a JSON array, such as \\\\"odps_writer\\\\", \\\\"mysql\\\\". If the RefType parameter is set to to, the synchronization tasks that use the specified data source as the destination are returned. In this case, the value of this parameter indicates the specified data source.
                /// </summary>
                [NameInMap("DiDestinationDatasource")]
                [Validation(Required=false)]
                public string DiDestinationDatasource { get; set; }

                /// <summary>
                /// The source of the synchronization task. If the synchronization task has multiple sources, the return value is a JSON array, such as \\\\"odps_writer\\\\", \\\\"mysql\\\\". If the RefType parameter is set to from, the synchronization tasks that use the specified data source as the source are returned. In this case, the value of this parameter indicates the specified data source.
                /// </summary>
                [NameInMap("DiSourceDatasource")]
                [Validation(Required=false)]
                public string DiSourceDatasource { get; set; }

                /// <summary>
                /// The ID of the synchronization task.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// The name of the synchronization task.
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// The type of the synchronization task. Valid values:
                /// 
                /// *   DI_OFFLINE: batch synchronization task
                /// *   DI_REALTIME: real-time synchronization task
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

            }

        }

        /// <summary>
        /// The request ID. You can locate logs and troubleshoot issues based on the ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
