// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListRefDISyncTasksResponseBody : TeaModel {
        /// <summary>
        /// The data returned for the query.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRefDISyncTasksResponseBodyData Data { get; set; }
        public class ListRefDISyncTasksResponseBodyData : TeaModel {
            /// <summary>
            /// The details of the sync nodes.
            /// 
            /// A data source is usually associated with multiple sync nodes. Therefore, the value of this parameter is an array. The following parameters are the elements in the array. The sample values of these parameters show the details of a sync node.
            /// </summary>
            [NameInMap("DISyncTasks")]
            [Validation(Required=false)]
            public List<ListRefDISyncTasksResponseBodyDataDISyncTasks> DISyncTasks { get; set; }
            public class ListRefDISyncTasksResponseBodyDataDISyncTasks : TeaModel {
                /// <summary>
                /// The destination data source of the sync node.
                /// 
                /// If the sync node has multiple destination data sources, the return value is a JSON array, such as \\"odps_writer\\", \\"mysql\\".
                /// 
                /// If the RefType parameter is set to to, the sync nodes that use the specified data source as the destination data source are returned. In this case, the value of this parameter indicates the specified data source.
                /// </summary>
                [NameInMap("DiDestinationDatasource")]
                [Validation(Required=false)]
                public string DiDestinationDatasource { get; set; }

                /// <summary>
                /// The source data source of the sync node.
                /// 
                /// If the sync node has multiple source data sources, the return value is a JSON array, such as \\"odps_writer\\", \\"mysql\\".
                /// 
                /// If the RefType parameter is set to from, the sync nodes that use the specified data source as the source data source are returned. In this case, the value of this parameter indicates the specified data source.
                /// </summary>
                [NameInMap("DiSourceDatasource")]
                [Validation(Required=false)]
                public string DiSourceDatasource { get; set; }

                /// <summary>
                /// The ID of the sync node.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// The name of the sync node.
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// The type of the sync node. Valid values:
                /// 
                /// *   DI_OFFLINE: batch sync node
                /// *   DI_REALTIME: real-time sync node
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true: The request was successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
