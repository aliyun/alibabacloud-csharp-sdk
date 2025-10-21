// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class UpdateTopicRequest : TeaModel {
        [NameInMap("BodyData")]
        [Validation(Required=false)]
        public UpdateTopicRequestBodyData BodyData { get; set; }
        public class UpdateTopicRequestBodyData : TeaModel {
            [NameInMap("TopicExampleInfoList")]
            [Validation(Required=false)]
            public List<UpdateTopicRequestBodyDataTopicExampleInfoList> TopicExampleInfoList { get; set; }
            public class UpdateTopicRequestBodyDataTopicExampleInfoList : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ExampleType")]
                [Validation(Required=false)]
                public int? ExampleType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TopicDefinition")]
        [Validation(Required=false)]
        public string TopicDefinition { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>216</para>
        /// </summary>
        [NameInMap("TopicId")]
        [Validation(Required=false)]
        public long? TopicId { get; set; }

        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}
