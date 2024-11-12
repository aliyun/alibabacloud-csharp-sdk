// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListQueueConsumersResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListQueueConsumersResponseBodyData Data { get; set; }
        public class ListQueueConsumersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The consumers.</para>
            /// </summary>
            [NameInMap("Consumers")]
            [Validation(Required=false)]
            public List<ListQueueConsumersResponseBodyDataConsumers> Consumers { get; set; }
            public class ListQueueConsumersResponseBodyDataConsumers : TeaModel {
                /// <summary>
                /// <para>The consumer tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sgen-1</para>
                /// </summary>
                [NameInMap("ConsumerTag")]
                [Validation(Required=false)]
                public string ConsumerTag { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token that marks the end of the current returned page. If this parameter is empty, all data is retrieved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>caebacccb2be03f84eb48b699f0a****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4409B7D5-E4EC-4EB5-804A-385DCDFCD***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
