// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListIntentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The paginated list of intents.</para>
        /// </summary>
        [NameInMap("Intents")]
        [Validation(Required=false)]
        public ListIntentsResponseBodyIntents Intents { get; set; }
        public class ListIntentsResponseBodyIntents : TeaModel {
            /// <summary>
            /// <para>The list of intents.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListIntentsResponseBodyIntentsList> List { get; set; }
            public class ListIntentsResponseBodyIntentsList : TeaModel {
                /// <summary>
                /// <para>The time when the intent was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1578469042851</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the intent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>同意还款意图</para>
                /// </summary>
                [NameInMap("IntentDescription")]
                [Validation(Required=false)]
                public string IntentDescription { get; set; }

                /// <summary>
                /// <para>The intent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a8494b35-eefb-4c8a-887b-b60d2f0fa57a</para>
                /// </summary>
                [NameInMap("IntentId")]
                [Validation(Required=false)]
                public string IntentId { get; set; }

                /// <summary>
                /// <para>The intent name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>统一还款</para>
                /// </summary>
                [NameInMap("IntentName")]
                [Validation(Required=false)]
                public string IntentName { get; set; }

                /// <summary>
                /// <para>The keywords of the intent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;还款&quot;]</para>
                /// </summary>
                [NameInMap("Keywords")]
                [Validation(Required=false)]
                public string Keywords { get; set; }

                /// <summary>
                /// <para>The script ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6ef95fd5-558f-4ee8-af34-b2ede087a87c</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                /// <summary>
                /// <para>The time when the intent was last updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1578469042851</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>The user utterances that trigger the intent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;ok&quot;,&quot;好的&quot;,&quot;好吧&quot;,&quot;好嘞&quot;,&quot;可以&quot;,&quot;行啊&quot;,&quot;行吧&quot;,&quot;那行&quot;,&quot;知道了&quot;,&quot;我看一下&quot;,&quot;能的&quot;,&quot;等会吧&quot;,&quot;等一下&quot;,&quot;马上还&quot;,&quot;等一会&quot;,&quot;过两天&quot;,&quot;我会想办法处理&quot;]</para>
                /// </summary>
                [NameInMap("Utterances")]
                [Validation(Required=false)]
                public string Utterances { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of intents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
