// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class AddPipelineResponseBody : TeaModel {
        /// <summary>
        /// <para>The MPS queue.</para>
        /// </summary>
        [NameInMap("Pipeline")]
        [Validation(Required=false)]
        public AddPipelineResponseBodyPipeline Pipeline { get; set; }
        public class AddPipelineResponseBodyPipeline : TeaModel {
            /// <summary>
            /// <para>The ID of the MPS queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ed450ea0bfbd41e29f80a401fb4d****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the MPS queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Media Fingerprint</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The MNS configuration.</para>
            /// </summary>
            [NameInMap("NotifyConfig")]
            [Validation(Required=false)]
            public AddPipelineResponseBodyPipelineNotifyConfig NotifyConfig { get; set; }
            public class AddPipelineResponseBodyPipelineNotifyConfig : TeaModel {
                /// <summary>
                /// <para>The tag string.</para>
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
                /// <para>example1</para>
                /// </summary>
                [NameInMap("MqTopic")]
                [Validation(Required=false)]
                public string MqTopic { get; set; }

                /// <summary>
                /// <para>The name of the queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mts-queue-1</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// <para>The name of the topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mts-topic-1</para>
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
            /// <para>The role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunMTSDefaultRole</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The type of the MPS queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("Speed")]
            [Validation(Required=false)]
            public string Speed { get; set; }

            /// <summary>
            /// <para>The level of the MPS queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SpeedLevel")]
            [Validation(Required=false)]
            public long? SpeedLevel { get; set; }

            /// <summary>
            /// <para>The state of the MPS queue.</para>
            /// <list type="bullet">
            /// <item><description>Active: The MPS queue is active. The jobs in the MPS queue are scheduled and transcoded by MPS.</description></item>
            /// <item><description>Paused: The MPS queue is paused. Jobs in the MPS queue are no longer scheduled for transcoding by MPS. All of the jobs in the MPS queue remain in the Submitted state. Jobs that are being transcoded are not affected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CFEA608A-5A1C-4C83-A54B-6197BC250D23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
