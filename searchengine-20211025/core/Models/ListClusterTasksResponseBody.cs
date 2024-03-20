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
        /// The information about the index.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListClusterTasksResponseBodyResult> Result { get; set; }
        public class ListClusterTasksResponseBodyResult : TeaModel {
            /// <summary>
            /// The additional attributes of the card.
            /// </summary>
            [NameInMap("extraAttribute")]
            [Validation(Required=false)]
            public string ExtraAttribute { get; set; }

            /// <summary>
            /// The field3 field that is passed through when you create a state machine.
            /// </summary>
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
            /// Indicates whether the change is a data source task change or a cluster task change.
            /// </summary>
            [NameInMap("groupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            /// <summary>
            /// The task name on the card.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The overall status of FSM.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The status tag of the progress bar chart.
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListClusterTasksResponseBodyResultTags> Tags { get; set; }
            public class ListClusterTasksResponseBodyResultTags : TeaModel {
                /// <summary>
                /// The content of the tag.
                /// </summary>
                [NameInMap("msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// The level of the tag.
                /// </summary>
                [NameInMap("tagLevel")]
                [Validation(Required=false)]
                public string TagLevel { get; set; }

            }

            /// <summary>
            /// The information about the task.
            /// </summary>
            [NameInMap("taskNodes")]
            [Validation(Required=false)]
            public List<ListClusterTasksResponseBodyResultTaskNodes> TaskNodes { get; set; }
            public class ListClusterTasksResponseBodyResultTaskNodes : TeaModel {
                /// <summary>
                /// The date when the task was completed.
                /// </summary>
                [NameInMap("finishDate")]
                [Validation(Required=false)]
                public string FinishDate { get; set; }

                /// <summary>
                /// The sequence number of the task.
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public long? Index { get; set; }

                /// <summary>
                /// The name of the task.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The status of the task.
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The timestamp of the task on the card.
            /// </summary>
            [NameInMap("time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// The type of the task on the card.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The user who triggered the FSM process.
            /// </summary>
            [NameInMap("user")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

    }

}
