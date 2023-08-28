// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListClusterTasksResponseBody : TeaModel {
        /// <summary>
        /// id of request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The date when the task was completed.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListClusterTasksResponseBodyResult> Result { get; set; }
        public class ListClusterTasksResponseBodyResult : TeaModel {
            [NameInMap("extraAttribute")]
            [Validation(Required=false)]
            public string ExtraAttribute { get; set; }

            [NameInMap("field3")]
            [Validation(Required=false)]
            public string Field3 { get; set; }

            /// <summary>
            /// fsmId
            /// </summary>
            [NameInMap("fsmId")]
            [Validation(Required=false)]
            public string FsmId { get; set; }

            /// <summary>
            /// ### Method
            /// 
            /// ```java
            /// GET
            /// ```
            /// 
            /// ### URI
            /// 
            /// ```java
            /// /openapi/ha3/instances/{instanceId}/cluster-tasks
            /// ```
            /// </summary>
            [NameInMap("groupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            /// <summary>
            /// Displays cluster tasks .
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListClusterTasksResponseBodyResultTags> Tags { get; set; }
            public class ListClusterTasksResponseBodyResultTags : TeaModel {
                [NameInMap("msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                [NameInMap("tagLevel")]
                [Validation(Required=false)]
                public string TagLevel { get; set; }

            }

            [NameInMap("taskNodes")]
            [Validation(Required=false)]
            public List<ListClusterTasksResponseBodyResultTaskNodes> TaskNodes { get; set; }
            public class ListClusterTasksResponseBodyResultTaskNodes : TeaModel {
                [NameInMap("finishDate")]
                [Validation(Required=false)]
                public string FinishDate { get; set; }

                [NameInMap("index")]
                [Validation(Required=false)]
                public long? Index { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("user")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

    }

}
