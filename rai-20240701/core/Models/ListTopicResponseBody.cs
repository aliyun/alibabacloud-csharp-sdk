// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class ListTopicResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>00000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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

        [NameInMap("TopicInfoList")]
        [Validation(Required=false)]
        public List<ListTopicResponseBodyTopicInfoList> TopicInfoList { get; set; }
        public class ListTopicResponseBodyTopicInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1597738932000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("PolicyInfoList")]
            [Validation(Required=false)]
            public List<ListTopicResponseBodyTopicInfoListPolicyInfoList> PolicyInfoList { get; set; }
            public class ListTopicResponseBodyTopicInfoListPolicyInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>412</para>
                /// </summary>
                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public long? PolicyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>bqi1c3s99qx3</para>
                /// </summary>
                [NameInMap("PolicyIdentifier")]
                [Validation(Required=false)]
                public string PolicyIdentifier { get; set; }

                [NameInMap("PolicyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

            }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
