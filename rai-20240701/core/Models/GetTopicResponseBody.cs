// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class GetTopicResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>00000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1634122349000</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PolicyInfoList")]
        [Validation(Required=false)]
        public List<GetTopicResponseBodyPolicyInfoList> PolicyInfoList { get; set; }
        public class GetTopicResponseBodyPolicyInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>x1bc5xgs4uhx</para>
            /// </summary>
            [NameInMap("PolicyIdentifier")]
            [Validation(Required=false)]
            public string PolicyIdentifier { get; set; }

            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TopicDefinition")]
        [Validation(Required=false)]
        public string TopicDefinition { get; set; }

        [NameInMap("TopicExampleInfoList")]
        [Validation(Required=false)]
        public List<GetTopicResponseBodyTopicExampleInfoList> TopicExampleInfoList { get; set; }
        public class GetTopicResponseBodyTopicExampleInfoList : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ExampleId")]
            [Validation(Required=false)]
            public long? ExampleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ExampleType")]
            [Validation(Required=false)]
            public int? ExampleType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test_topic</para>
        /// </summary>
        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}
