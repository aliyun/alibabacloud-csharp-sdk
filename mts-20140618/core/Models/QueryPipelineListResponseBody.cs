// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryPipelineListResponseBody : TeaModel {
        /// <summary>
        /// The IDs of MPS queues that do not exist.
        /// </summary>
        [NameInMap("NonExistPids")]
        [Validation(Required=false)]
        public QueryPipelineListResponseBodyNonExistPids NonExistPids { get; set; }
        public class QueryPipelineListResponseBodyNonExistPids : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        /// <summary>
        /// The MPS queues.
        /// </summary>
        [NameInMap("PipelineList")]
        [Validation(Required=false)]
        public QueryPipelineListResponseBodyPipelineList PipelineList { get; set; }
        public class QueryPipelineListResponseBodyPipelineList : TeaModel {
            [NameInMap("Pipeline")]
            [Validation(Required=false)]
            public List<QueryPipelineListResponseBodyPipelineListPipeline> Pipeline { get; set; }
            public class QueryPipelineListResponseBodyPipelineListPipeline : TeaModel {
                [NameInMap("ExtendConfig")]
                [Validation(Required=false)]
                public QueryPipelineListResponseBodyPipelineListPipelineExtendConfig ExtendConfig { get; set; }
                public class QueryPipelineListResponseBodyPipelineListPipelineExtendConfig : TeaModel {
                    [NameInMap("IsBoostNew")]
                    [Validation(Required=false)]
                    public bool? IsBoostNew { get; set; }

                    [NameInMap("MaxMultiSpeed")]
                    [Validation(Required=false)]
                    public int? MaxMultiSpeed { get; set; }

                    [NameInMap("MultiSpeedDowngradePolicy")]
                    [Validation(Required=false)]
                    public string MultiSpeedDowngradePolicy { get; set; }

                }

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
                /// The Message Service (MNS) configuration.
                /// </summary>
                [NameInMap("NotifyConfig")]
                [Validation(Required=false)]
                public QueryPipelineListResponseBodyPipelineListPipelineNotifyConfig NotifyConfig { get; set; }
                public class QueryPipelineListResponseBodyPipelineListPipelineNotifyConfig : TeaModel {
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
                    /// The name of the queue that is created in MNS.
                    /// </summary>
                    [NameInMap("QueueName")]
                    [Validation(Required=false)]
                    public string QueueName { get; set; }

                    /// <summary>
                    /// The name of the topic that is created in MNS.
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
                /// The role that is assigned to the current RAM user.
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// The type of the MPS queue. Default value: **Standard**. Valid values:
                /// 
                /// *   **Boost**: MPS queue with transcoding speed boosted
                /// *   **Standard**: standard MPS queue
                /// *   **NarrowBandHDV2**: MPS queue that supports Narrowband HD 2.0
                /// *   **AIVideoCover**: MPS queue for intelligent snapshot capture
                /// *   **AIVideoFPShot**: MPS queue for media fingerprinting
                /// *   **AIVideoCensor**: MPS queue for automated review
                /// *   **AIVideoMCU**: MPS queue for smart tagging
                /// *   **AIVideoSummary**: MPS queue for video synopsis
                /// *   **AIVideoPorn**: MPS queue for pornography detection in videos
                /// *   **AIAudioKWS**: MPS queue for keyword recognition in audio
                /// *   **AIAudioASR**: MPS queue for speech-to-text conversion
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
                /// The state of the MPS queue. Valid values:
                /// 
                /// *   **Active**: The MPS queue is active.
                /// *   **Paused**: The MPS queue is paused.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
