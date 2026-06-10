// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeIntentResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
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
        /// <para>The details of the intent.</para>
        /// </summary>
        [NameInMap("Intent")]
        [Validation(Required=false)]
        public DescribeIntentResponseBodyIntent Intent { get; set; }
        public class DescribeIntentResponseBodyIntent : TeaModel {
            /// <summary>
            /// <para>The time when the intent was created.</para>
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
            /// <para>The ID of the intent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10722701</para>
            /// </summary>
            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public string IntentId { get; set; }

            /// <summary>
            /// <para>The name of the intent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>统一还款</para>
            /// </summary>
            [NameInMap("IntentName")]
            [Validation(Required=false)]
            public string IntentName { get; set; }

            /// <summary>
            /// <para>The keywords for the intent. You can use these keywords to filter intents during list operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;还款&quot;]</para>
            /// </summary>
            [NameInMap("Keywords")]
            [Validation(Required=false)]
            public string Keywords { get; set; }

            /// <summary>
            /// <para>The ID of the script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6ef95fd5-558f-4ee8-af34-b2ede087a87c</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <para>The time when the intent was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1578469042851</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>A list of utterances that trigger the intent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;ok&quot;,&quot;好的&quot;,&quot;好吧&quot;,&quot;好嘞&quot;,&quot;可以&quot;,&quot;行啊&quot;,&quot;行吧&quot;,&quot;那行&quot;,&quot;知道了&quot;,&quot;我看一下&quot;,&quot;能的&quot;,&quot;等会吧&quot;,&quot;等一下&quot;,&quot;马上还&quot;,&quot;等一会&quot;,&quot;过两天&quot;,&quot;我会想办法处理&quot;]</para>
            /// </summary>
            [NameInMap("Utterances")]
            [Validation(Required=false)]
            public string Utterances { get; set; }

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
        /// <para>327FEE69-F173-5B2F-9F3B-DCC6182D7BA0</para>
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
