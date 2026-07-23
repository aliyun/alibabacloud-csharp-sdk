// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class DeleteEventAnalysisJobRequest : TeaModel {
        /// <summary>
        /// <para>The identifier of the source resource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Kafka&quot;:{&quot;RegionId&quot;:&quot;cn-hangzhou&quot;,&quot;InstanceId&quot;:&quot;alikafka_post-cn-xxx&quot;,&quot;Topic&quot;:&quot;my_topic&quot;}}</para>
        /// </summary>
        [NameInMap("SourceResource")]
        [Validation(Required=false)]
        public DeleteEventAnalysisJobRequestSourceResource SourceResource { get; set; }
        public class DeleteEventAnalysisJobRequestSourceResource : TeaModel {
            /// <summary>
            /// <para>The Kafka data source.</para>
            /// </summary>
            [NameInMap("Kafka")]
            [Validation(Required=false)]
            public DeleteEventAnalysisJobRequestSourceResourceKafka Kafka { get; set; }
            public class DeleteEventAnalysisJobRequestSourceResourceKafka : TeaModel {
                /// <summary>
                /// <para>The instance ID of the Kafka instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alikafka_post-cn-xxx</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The region of the Kafka instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The name of the Kafka topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my_topic</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }

            /// <summary>
            /// <para>The RocketMQ data source.</para>
            /// </summary>
            [NameInMap("RocketMQ")]
            [Validation(Required=false)]
            public DeleteEventAnalysisJobRequestSourceResourceRocketMQ RocketMQ { get; set; }
            public class DeleteEventAnalysisJobRequestSourceResourceRocketMQ : TeaModel {
                /// <summary>
                /// <para>The instance ID of the RocketMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rmq-cn-xxx</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The type of the RocketMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Cloud_5</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The region of the RocketMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The name of the RocketMQ topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my_topic</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }

        }

    }

}
