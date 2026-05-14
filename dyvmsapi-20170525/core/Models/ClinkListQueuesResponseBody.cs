// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkListQueuesResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ClinkListQueuesResponseBodyData Data { get; set; }
        public class ClinkListQueuesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>本次请求id</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ClinkRequestId")]
            [Validation(Required=false)]
            public string ClinkRequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>分页大小</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>queues</para>
            /// </summary>
            [NameInMap("Queues")]
            [Validation(Required=false)]
            public List<ClinkListQueuesResponseBodyDataQueues> Queues { get; set; }
            public class ClinkListQueuesResponseBodyDataQueues : TeaModel {
                /// <summary>
                /// <para>呼叫中心座席数</para>
                /// 
                /// <b>Example:</b>
                /// <para>51</para>
                /// </summary>
                [NameInMap("CallClientNum")]
                [Validation(Required=false)]
                public long? CallClientNum { get; set; }

                /// <summary>
                /// <para>在线客服数</para>
                /// 
                /// <b>Example:</b>
                /// <para>72</para>
                /// </summary>
                [NameInMap("ChatClientNum")]
                [Validation(Required=false)]
                public long? ChatClientNum { get; set; }

                /// <summary>
                /// <para>队列 Id</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>队列名</para>
                /// 
                /// <b>Example:</b>
                /// <para>Name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>全渠道座席数</para>
                /// 
                /// <b>Example:</b>
                /// <para>87</para>
                /// </summary>
                [NameInMap("OmniClientNum")]
                [Validation(Required=false)]
                public long? OmniClientNum { get; set; }

                /// <summary>
                /// <para>队列号</para>
                /// 
                /// <b>Example:</b>
                /// <para>1221</para>
                /// </summary>
                [NameInMap("Qno")]
                [Validation(Required=false)]
                public string Qno { get; set; }

            }

            /// <summary>
            /// <para>总数</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9FF70B74-1B3C-44C1-ACDF-8DF962988F0E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
