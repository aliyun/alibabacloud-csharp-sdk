// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class SubmitChatQuestionRequest : TeaModel {
        /// <summary>
        /// <para>Current time</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-09-27 11:23:20</para>
        /// </summary>
        [NameInMap("gmtService")]
        [Validation(Required=false)]
        public string GmtService { get; set; }

        /// <summary>
        /// <para>Live channel script</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>我们家的酒全都是老酒，酒厂直售【当前用户问句】，保证正儿八经的自家酿造，地址都能告诉大家，品质实实在在的有保障。我们家这款酒入口非常绵柔顺滑，酱香、粮食香、花果香层层递进，空杯留香能持续48小时，不会有上头的感觉。今天我们是厂家直销，大家平时买酒在烟酒店要经过好几个环节的中间商，每个环节都要加价，今天在这里拍下，只会让你省不少冤枉钱。如果说你拿去存酒的话， 拍蓝瓶的云端系列也可以，越存的话会越香，你拿去托人办事、请人吃饭、商务宴请、搞接待送礼，直接带白瓶云悠系列。</para>
        /// </summary>
        [NameInMap("liveScriptContent")]
        [Validation(Required=false)]
        public string LiveScriptContent { get; set; }

        /// <summary>
        /// <para>Enable small talk. Default is true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("openSmallTalk")]
        [Validation(Required=false)]
        public bool? OpenSmallTalk { get; set; }

        /// <summary>
        /// <para>Question list</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("questionList")]
        [Validation(Required=false)]
        public List<SubmitChatQuestionRequestQuestionList> QuestionList { get; set; }
        public class SubmitChatQuestionRequestQuestionList : TeaModel {
            /// <summary>
            /// <para>Question content</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>这是多大的体积</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Original question time</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-17 10:05:00</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>Reply content</para>
            /// 
            /// <b>Example:</b>
            /// <para>这是三升的。</para>
            /// </summary>
            [NameInMap("reply")]
            [Validation(Required=false)]
            public string Reply { get; set; }

            /// <summary>
            /// <para>Session ID</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1869300950603128834</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>Question type: PRODUCT_QA (audio submission), GOSSIP (operation submission), UNKNOWN (unknown)</para>
            /// 
            /// <b>Example:</b>
            /// <para>PRODUCT_QA</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Unique ID of the user asking questions in the live channel</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>39485783475638465</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>Name of the user asking questions in the live channel</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张**</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>Request ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FC6636E-380A-5369-AE01-D1C15BB9B254</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Session ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>237645726354</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
