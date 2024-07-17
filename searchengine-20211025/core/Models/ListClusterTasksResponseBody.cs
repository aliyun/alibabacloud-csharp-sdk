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
        /// The index information.
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
            /// The field3 field that was passed when the FSM was created.
            /// </summary>
            [NameInMap("field3")]
            [Validation(Required=false)]
            public string Field3 { get; set; }

            /// <summary>
            /// The ID of the finite state machine (FSM).
            /// </summary>
            [NameInMap("fsmId")]
            [Validation(Required=false)]
            public string FsmId { get; set; }

            /// <summary>
            /// The change group type.
            /// </summary>
            [NameInMap("groupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            /// <summary>
            /// The card name.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The FSM status.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tags of the progress bar.
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListClusterTasksResponseBodyResultTags> Tags { get; set; }
            public class ListClusterTasksResponseBodyResultTags : TeaModel {
                /// <summary>
                /// The tag content.
                /// </summary>
                [NameInMap("msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// The tag level.
                /// </summary>
                [NameInMap("tagLevel")]
                [Validation(Required=false)]
                public string TagLevel { get; set; }

            }

            /// <summary>
            /// The task information.
            /// </summary>
            [NameInMap("taskNodes")]
            [Validation(Required=false)]
            public List<ListClusterTasksResponseBodyResultTaskNodes> TaskNodes { get; set; }
            public class ListClusterTasksResponseBodyResultTaskNodes : TeaModel {
                /// <summary>
                /// The time when the task was complete.
                /// </summary>
                [NameInMap("finishDate")]
                [Validation(Required=false)]
                public string FinishDate { get; set; }

                /// <summary>
                /// The ordinal number of the task.
                /// </summary>
                [NameInMap("index")]
                [Validation(Required=false)]
                public long? Index { get; set; }

                /// <summary>
                /// The task name.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The task status.
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The timestamp of the card.
            /// </summary>
            [NameInMap("time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// The card type.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The user who triggered the generation of the FSM process.
            /// </summary>
            [NameInMap("user")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

    }

}
