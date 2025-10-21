// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class CreateTopicRequest : TeaModel {
        [NameInMap("BodyData")]
        [Validation(Required=false)]
        public CreateTopicRequestBodyData BodyData { get; set; }
        public class CreateTopicRequestBodyData : TeaModel {
            [NameInMap("TopicExampleInfoList")]
            [Validation(Required=false)]
            public List<CreateTopicRequestBodyDataTopicExampleInfoList> TopicExampleInfoList { get; set; }
            public class CreateTopicRequestBodyDataTopicExampleInfoList : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
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

        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>643168</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public long? WorkspaceId { get; set; }

    }

}
