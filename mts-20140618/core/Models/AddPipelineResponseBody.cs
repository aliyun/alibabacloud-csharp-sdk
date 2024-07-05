// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class AddPipelineResponseBody : TeaModel {
        /// <summary>
        /// The MPS queue.
        /// </summary>
        [NameInMap("Pipeline")]
        [Validation(Required=false)]
        public AddPipelineResponseBodyPipeline Pipeline { get; set; }
        public class AddPipelineResponseBodyPipeline : TeaModel {
            /// <summary>
            /// The ID of the MPS queue.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The name of the MPS queue.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The MNS configuration.
            /// </summary>
            [NameInMap("NotifyConfig")]
            [Validation(Required=false)]
            public AddPipelineResponseBodyPipelineNotifyConfig NotifyConfig { get; set; }
            public class AddPipelineResponseBodyPipelineNotifyConfig : TeaModel {
                /// <summary>
                /// The tag string.
                /// </summary>
                [NameInMap("MqTag")]
                [Validation(Required=false)]
                public string MqTag { get; set; }

                /// <summary>
                /// The queue of messages that are received.
                /// </summary>
                [NameInMap("MqTopic")]
                [Validation(Required=false)]
                public string MqTopic { get; set; }

                /// <summary>
                /// The name of the queue.
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// The name of the topic.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }

            /// <summary>
            /// The quota that is allocated to the MPS queue.
            /// </summary>
            [NameInMap("QuotaAllocate")]
            [Validation(Required=false)]
            public long? QuotaAllocate { get; set; }

            /// <summary>
            /// The role.
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// The type of the MPS queue.
            /// </summary>
            [NameInMap("Speed")]
            [Validation(Required=false)]
            public string Speed { get; set; }

            /// <summary>
            /// The level of the MPS queue.
            /// </summary>
            [NameInMap("SpeedLevel")]
            [Validation(Required=false)]
            public long? SpeedLevel { get; set; }

            /// <summary>
            /// The state of the MPS queue.
            /// 
            /// *   Active: The MPS queue is active. The jobs in the MPS queue are scheduled and transcoded by MPS.
            /// *   Paused: The MPS queue is paused. Jobs in the MPS queue are no longer scheduled for transcoding by MPS. All of the jobs in the MPS queue remain in the Submitted state. Jobs that are being transcoded are not affected.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
