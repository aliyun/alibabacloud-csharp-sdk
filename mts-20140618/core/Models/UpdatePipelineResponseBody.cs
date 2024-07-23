// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdatePipelineResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the MPS queue.</para>
        /// </summary>
        [NameInMap("Pipeline")]
        [Validation(Required=false)]
        public UpdatePipelineResponseBodyPipeline Pipeline { get; set; }
        public class UpdatePipelineResponseBodyPipeline : TeaModel {
            /// <summary>
            /// <para>The ID of the MPS queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d1ce4d3efcb549419193f50f1fcd****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The new name of the MPS queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-pipeline-****</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The MNS configuration.</para>
            /// </summary>
            [NameInMap("NotifyConfig")]
            [Validation(Required=false)]
            public UpdatePipelineResponseBodyPipelineNotifyConfig NotifyConfig { get; set; }
            public class UpdatePipelineResponseBodyPipelineNotifyConfig : TeaModel {
                /// <summary>
                /// <para>The tags of the messages.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mts-test</para>
                /// </summary>
                [NameInMap("MqTag")]
                [Validation(Required=false)]
                public string MqTag { get; set; }

                /// <summary>
                /// <para>The queue of messages that are received.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example1,example2</para>
                /// </summary>
                [NameInMap("MqTopic")]
                [Validation(Required=false)]
                public string MqTopic { get; set; }

                /// <summary>
                /// <para>The queue that is created in MNS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-queue-****</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// <para>The topic that is created in MNS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-topic-****</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }

            /// <summary>
            /// <para>The quota that is allocated to the MPS queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("QuotaAllocate")]
            [Validation(Required=false)]
            public long? QuotaAllocate { get; set; }

            /// <summary>
            /// <para>The role that is assigned to the current RAM user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunMTSExampleRole</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The type of the MPS queue. Default value: <b>Standard</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Boost</b>: MPS queue with transcoding speed boosted</description></item>
            /// <item><description><b>Standard</b>: standard MPS queue</description></item>
            /// <item><description><b>NarrowBandHDV2</b>: MPS queue that supports Narrowband HD 2.0</description></item>
            /// <item><description><b>AIVideoCover</b>: MPS queue for intelligent snapshot capture</description></item>
            /// <item><description><b>AIVideoFPShot</b>: MPS queue for media fingerprinting</description></item>
            /// <item><description><b>AIVideoCensor</b>: MPS queue for automated review</description></item>
            /// <item><description><b>AIVideoMCU</b>: MPS queue for smart tagging</description></item>
            /// <item><description><b>AIVideoSummary</b>: MPS queue for video synopsis</description></item>
            /// <item><description><b>AIVideoPorn</b>: MPS queue for pornography detection in videos</description></item>
            /// <item><description><b>AIAudioKWS</b>: MPS queue for keyword recognition in audio</description></item>
            /// <item><description><b>AIAudioASR</b>: MPS queue for speech-to-text conversion</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("Speed")]
            [Validation(Required=false)]
            public string Speed { get; set; }

            /// <summary>
            /// <para>The state of the MPS queue. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Active</b>: The MPS queue is active.</description></item>
            /// <item><description><b>Paused</b>: The MPS queue is paused.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Paused</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1FE0F96B-544D-4244-9D83-DFCFB0E5A231</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
